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
    [DefaultEvent("JobCompleted"),
    DefaultProperty("MaxSleepTime")]
    public partial class UC_Hilo_Display : UserControl
    {


        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        Firma_Bus FirmaBus;
        private Random r = new Random();
        private string ThreadName = "";
        private int _maxSleep = 100;
        #region public events
        //Declares and handles the Job Completed Event
        public delegate void JobCompletedHandler(object sender, EventArgs e);
        public event JobCompletedHandler JobCompleted;

        tb_Comprobante_Bus BusCbte = new tb_Comprobante_Bus();

        public tb_Comprobante_Info ComprobanteAFirmar_Info { get; set; }
        public tb_Parametro_Info InfoParametros { get; set; }
        public List<tb_Empresa_Info>  ListEmpresa { get; set; }
        public List<tb_Tocken_Info> listTocken { get; set; }
        public List<tb_tocken_x_usuario_tocken_Info> listUsuario_de_Tocken { get; set; }
        public List<mail_Cuentas_Correo_Info> listmail_cuentas_correo{ get; set; }
        public List<mail_Cuentas_Correo_x_Empresa_Info>  listmail_cuentas_correo_x_empresa  { get; set; }

        


      public  Boolean ProcesoConErrores;


        protected virtual void OnJobCompleted(EventArgs e)
        {
            if (JobCompleted != null)
                JobCompleted(this, e);
        }

        //Declares and handles the Job Event Event
        public delegate void JobEventHandler(object sender, JobEventEventArgs e);
        public event JobEventHandler JobEvent;
        protected virtual void OnJobEvent(JobEventEventArgs e)
        {
            if (JobEvent != null)
                JobEvent(this, e);
        }
        #endregion

        public UC_Hilo_Display(string name)
        {
            try
            {
                InitializeComponent();
                ThreadName = name;
            }
            catch (Exception ex)
            {
                
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
            
        }

        private void UC_Hilo_Display_Load(object sender, EventArgs e)
        {

        }


        Thread HiloFirma;


        


        public void Start()
        {
            try
            {

                //Starts the background process
                worker.RunWorkerAsync();



                //LAMANDO A LA FIRMA2
                if (ComprobanteAFirmar_Info != null)
                {
                    if (ListEmpresa.Count > 0)
                    {
                        FirmaBus = new Firma_Bus(ComprobanteAFirmar_Info, ListEmpresa, listTocken, InfoParametros, listUsuario_de_Tocken,listmail_cuentas_correo,listmail_cuentas_correo_x_empresa );
                        //FirmaBus.Firmar_y_Enviar_WSJava();

                        HiloFirma = new Thread(new ThreadStart(FirmaBus.Firmar_y_Enviar_WSJava));
                        HiloFirma.Start();
                        Thread.Sleep(1);
                        timerSensorHiloFirma.Enabled = true;

                        //FirmaBus.HayErrores

                    }
                }

            }
            catch (Exception ex)
            {
                
                 BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
            
            
        }
        public void Cancel()
        {
            //Cancels the background process
            worker.CancelAsync();
        }


        #region Properties Add your own
        public bool ShowCancel
        {
            get { return btnCancel.Visible; }
            set { btnCancel.Visible = value; }
        }
        [DefaultValue(100)]
        public int MaxSleepTime
        {
            get { return _maxSleep; }
            set { _maxSleep = value; }
        }
        #endregion




        




        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
                                                                            {
                //This is where everything is done
                //TODO: Add your code here 

                             

                for (int i = 0; i < 100; i++)
                {
                    //this checks to see if the user pressed the cancel button
                    if (worker.CancellationPending)
                        break;
                    //Whenever you want the progress bar to change use this line.  
                    //i is an integer from 0 to 100 that is the percentage completed
                    worker.ReportProgress(i, "Progreso: " + i.ToString());

                    try
                    {
                        Thread.Sleep(r.Next(0, _maxSleep));
                    }
                    catch (Exception ex)
                    {
                        BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                    }

                    //Whenever you want to send a message out use this line
                    //this signals the container that we have a message to show
                    OnJobEvent(new JobEventEventArgs(ThreadName, "Progres0: " + i.ToString()));
                }


            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }


        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                //Change the progress bar
                barProgress.Value = e.ProgressPercentage;
                //Change the title
                lblTitle.Text = ThreadName + "-" + e.UserState.ToString();
                //Repaint the control
                this.Refresh();
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
           
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                //reset the values
                barProgress.Value = 0;
                lblTitle.Text = "";
                //signal the container that we are done
                this.OnJobCompleted(new EventArgs());
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //signal this control that we want to be done
                Cancel();
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
        }

        public string mensajeErroOut { get; set; }


        private void timerSensorHiloFirma_Tick(object sender, EventArgs e)
        {

            try
            {
                if (HiloFirma.IsAlive == false) //esta ejecutandoce
                {
                    worker.CancelAsync();
                    timerSensorHiloFirma.Enabled = false;
                    barProgress.Value = 100;
                    

                    if (FirmaBus.HayErrores == true)
                    {
                        lblTitle.Text = lblTitle.Text + "PROCESO ERRORES";
                        lblTitle.ForeColor = Color.Red;
                        ProcesoConErrores = true;
                        //mensajeErroOut = FirmaBus.me;
                    }
                    else
                    {
                        lblTitle.Text = lblTitle.Text + "PROCESO OK";
                        lblTitle.ForeColor = Color.Blue;
                        ProcesoConErrores = false;
                    }

                }
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }

        }



    }


    public class JobEventEventArgs : EventArgs
    {
        public string ThreadName = "";
        public string Msg = "";

        public JobEventEventArgs(string threadName, string message)
        {
            ThreadName = threadName;
            Msg = message;
        }
    }
}
