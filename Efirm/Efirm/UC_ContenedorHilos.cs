using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;
using FirmElect.Bus;
using FirmElect.Info;






namespace Efirm
{
    [DefaultEvent("DoWork"),
    DefaultProperty("Concurrent")]
    public partial class UC_ContenedorHilos : UserControl
    {

        #region Public Events
        public delegate void DoWorkHandler(object sender, EventArgs e);
        public event DoWorkHandler DoWork;

        public delegate void Finalizo();
        public event Finalizo Event_Finalizo_Proceso;


        protected virtual void OnDoWork(EventArgs e)
        {
            if (DoWork != null)
                DoWork(this, e);
        }
        #endregion
        public int TotalThreads = 0;
        public int Concurrent = 0;
        public int MaxSleepTime = 1000;
        public Orientation Orientation
        {
            get { return splitContainer1.Orientation; }
            set { splitContainer1.Orientation = value; }
        }

        private int Current = 0;
        private bool Cancel = false;
        private int errorID = 1;


        public List<tb_Comprobante_Info>  listComprobanteAFirmar { get; set; }
        public List<tb_Empresa_Info> listaEmpresa { get; set; }
        public List<tb_Tocken_Info> listTocken { get; set; }
        public tb_Parametro_Info InfoParametros { get; set; }
        public List<tb_tocken_x_usuario_tocken_Info> listUsuario_de_Tocken { get; set; }
        public List<mail_Cuentas_Correo_Info> listmail_cuentas_correo { get; set; }
        public List<mail_Cuentas_Correo_x_Empresa_Info> listmail_cuentas_correo_x_empresa { get; set; }




        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();



        public UC_ContenedorHilos()
        {
            try
            {
                InitializeComponent();
                Event_Finalizo_Proceso += UC_ContenedorHilos_Event_Finalizo_Proceso;
            }
            catch (Exception ex)
            {

                BusSisLog.Log_Error("public UC_ContenedorHilos() " + ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
            
        }

        void UC_ContenedorHilos_Event_Finalizo_Proceso()
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlThreads_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            try
            {

                //Change the name on the button
                if (btnDetails.Text == "Mas Info >>")
                    btnDetails.Text = "<< Menos Info";
                else
                    btnDetails.Text = "Mas Info >>";

                //Change the panel visibility
                splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error("private void btnDetails_Click(object sender, EventArgs e) " + ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }
        }


        public void Start(int totalHilos, int concurrent)
        {
            try
            {

                //Clear out the previous Results
                dsErrors1.Errors.Clear();

                //Set the Overall Progress bar up
                barProgress.Maximum = totalHilos;
                barProgress.Visible = true;

                //setup the run
                Concurrent = concurrent;
                TotalThreads = totalHilos;
                Cancel = false;
                Current = 0;
                pnlThreads.Controls.Clear();

                int c = 0;

                
                    //Start the first set of threads
                    //crea los controles por hilo 
                    //for (int i = 0; i < Concurrent; i++)
                    //{
                    //    CreateJob(i.ToString(),new tb_Comprobante_Info());
                    //}

               
                    if (listaEmpresa.Count > 0 && listComprobanteAFirmar.Count > 0)
                    {
                        foreach (tb_Comprobante_Info item in listComprobanteAFirmar)
                        {
                            c = c + 1;
                            CreateJob(c.ToString(), item, listaEmpresa,listTocken,InfoParametros,listUsuario_de_Tocken,listmail_cuentas_correo,listmail_cuentas_correo_x_empresa);
                        }
                    }
               
                

                
              


                

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error("public void Start(int totalHilos, int concurrent) " + ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }


        }


        private void CreateJob(string name,tb_Comprobante_Info _InfoCbteAFirmar,List<tb_Empresa_Info> _listaEmpresa,
            List<tb_Tocken_Info> _listTocken, tb_Parametro_Info _InfoParametro, List<tb_tocken_x_usuario_tocken_Info> _listUsuario_de_Tocken
            ,List<mail_Cuentas_Correo_Info> _listmail_Cuentas_Correo_Info,List<mail_Cuentas_Correo_x_Empresa_Info> _listmail_Cuentas_Correo_x_Empresa_Info )
        {
            try
            {


                //Create the thread
                UC_Hilo_Display j = new UC_Hilo_Display(name + " Firmando comprobante #:"  + _InfoCbteAFirmar.IdComprobante.ToString() );
                j.ComprobanteAFirmar_Info = _InfoCbteAFirmar;
                j.ListEmpresa = _listaEmpresa;
                j.listTocken = _listTocken;
                j.InfoParametros = _InfoParametro;
                j.listUsuario_de_Tocken = _listUsuario_de_Tocken;
                j.listmail_cuentas_correo = _listmail_Cuentas_Correo_Info;
                j.listmail_cuentas_correo_x_empresa = _listmail_Cuentas_Correo_x_Empresa_Info;


                

                //Make sure it will resize to the container whatever the size
                j.Dock = DockStyle.Top;

                //Tell it how much to sleep so it will look like it is doing something
                j.MaxSleepTime = MaxSleepTime;

                //Consume the Job Completed event so that we can know when the thread is done 
                j.JobCompleted += new UC_Hilo_Display.JobCompletedHandler(this.UC_Hilo_Display_JobCompleted);
                //Consume the Job Event event so that we can know when the thread has a message
                j.JobEvent += new UC_Hilo_Display.JobEventHandler(this.UC_Hilo_Display_JobEvent);

                //add the thread to the panel so it can be viewed
                pnlThreads.Controls.Add(j);

                //Start the thread
                j.Start();

                //Adjust the counters
                TotalThreads--;
                Current++;

            }
            catch (Exception ex)
            {

                BusSisLog.Log_Error("private void CreateJob(string name, " + ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }


        }

        
        private void UC_Hilo_Display_JobCompleted(object sender, EventArgs e)
        {
            try
            {

                //Are we not on the UI thread
                if (InvokeRequired)
                {
                    //Change to the UI thread
                    Invoke(new UC_Hilo_Display.JobCompletedHandler(this.UC_Hilo_Display_JobCompleted), new object[] { sender, e });

                }
                else
                {
                    //Find out who we are
                    UC_Hilo_Display j = (UC_Hilo_Display)sender;
                    //Take the thread off
                    Thread.Sleep(1500);



                    if (j.ProcesoConErrores)
                    {
                        errorID++;
                        dsErrors1.Errors.AddErrorsRow(j.mensajeErroOut, errorID, j.Name);
                    }
                    


                    pnlThreads.Controls.Remove(j);

                    //if i am the last one and the user hadn't pressed cancel then start another thread
                    if (TotalThreads > 0 && !Cancel)
                        CreateJob(Current.ToString(), j.ComprobanteAFirmar_Info, listaEmpresa,listTocken,InfoParametros,listUsuario_de_Tocken,listmail_cuentas_correo,listmail_cuentas_correo_x_empresa);

                    //Show the data
                    dataGridView1.Refresh();
                    //Increment the overall progress bar

                    if (barProgress.Maximum > 0 && barProgress.Minimum > 0)
                    {
                        barProgress.Value++;
                    }

                    if (pnlThreads.Controls.Count == 0)
                    { 
                    // no hay controles quiere decir q termio todo el proceso 
                        Event_Finalizo_Proceso();
                    }
                }

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error("private void UC_Hilo_Display_JobCompleted(object sender, EventArgs e) " + ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
        }


        private void UC_Hilo_Display_JobEvent(object sender, JobEventEventArgs e)
        {
            try
            {
                //Are we not on the UI thread
                if (InvokeRequired)
                    Invoke(new UC_Hilo_Display.JobEventHandler(this.UC_Hilo_Display_JobEvent), new object[] { sender, e });
                else
                {
                    //add the message to the list
                    errorID++;
                    dsErrors1.Errors.AddErrorsRow(e.Msg, errorID, e.ThreadName);
                }
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error("private void UC_Hilo_Display_JobEvent(object sender, JobEventEventArgs e)" + ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }



        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {

            try
            {

                //tell the control that we are stopping and don't start any new threads
                Cancel = true;

                //Stop all of the currently running threads
                foreach (Control ctl in pnlThreads.Controls)
                {
                    ((UC_Hilo_Display)ctl).Cancel();
                }

                //Clear the progress bar
                barProgress.Value = 0;
                barProgress.Visible = false;
                //cargo el event finalizo todo 
                Event_Finalizo_Proceso();
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error("private void btnCancelAll_Click(object sender, EventArgs e)" + ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }
        }

    }
}
