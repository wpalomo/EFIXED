using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FirmElect.Bus;
using FirmElect.Info;


namespace MailEfirm.Forms
{
    public partial class Frm_Enviar_y_Recibir_Cuentas : Form
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        Thread HiloEnviar;

        public Frm_Enviar_y_Recibir_Cuentas()
        {
            InitializeComponent();
        }

       

        private void Frm_Enviar_y_Recibir_Cuentas_Load(object sender, EventArgs e)
        {
            try
            {
                ProcesoHiloenviar();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
        }


        private void ProcesoHiloenviar()
        {
            try
            {
                timerSensorHiloEnviar.Enabled = true;
                backgroundWorkerEnvio_y_Recep.RunWorkerAsync();
                HiloEnviar = new Thread(new ThreadStart(enviar_correo_buzon_salida));
                HiloEnviar.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        List<cl_error_Info> listErrores = new List<cl_error_Info>();


        private void enviar_correo_buzon_salida()
        {
            try
            {
                mail_Mensaje_Bus BusMensaje = new mail_Mensaje_Bus();
                BusMensaje.enviar_correo_buzon_salida(ref listErrores);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enviar_correo_buzon_salida();
        }

        private void backgroundWorkerEnvio_y_Recep_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                for (int i = 0; i < 100; i++)
                {
                    if (backgroundWorkerEnvio_y_Recep.CancellationPending)
                        break;


                    backgroundWorkerEnvio_y_Recep.ReportProgress(i);
                    Thread.Sleep(1000);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }

        }

        private void backgroundWorkerEnvio_y_Recep_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (pgb_estado_envio != null)
                {
                    pgb_estado_envio.Value = e.ProgressPercentage;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void backgroundWorkerEnvio_y_Recep_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                pgb_estado_envio.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            try
            {
                backgroundWorkerEnvio_y_Recep.CancelAsync();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
            

        }

        private void timerSensorHiloEnviar_Tick(object sender, EventArgs e)
        {
            try
            {

                if (HiloEnviar.IsAlive == false) //esta ejecutandoce
                {
                   backgroundWorkerEnvio_y_Recep.CancelAsync();
                   timerSensorHiloEnviar.Enabled = false;
                   pgb_estado_envio.Value = 100;
                  
                   lbl_mensaje.ForeColor = Color.Blue;
                   lbl_mensaje.Text = "Finalizacion Proceso de Envio..";
                   timerCerrarForm.Enabled = true;

                   if (listErrores.Count > 0)
                   {
                       lbl_mensaje.ForeColor = Color.Red;
                       gridControl_errores.DataSource = listErrores;
                       gridControl_errores.RefreshDataSource();

                       iSegundosAntesDecerrar = 3;
                       
                   }
                   else
                   {
                       iSegundosAntesDecerrar = 1;
                   }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                timerSensorHiloEnviar.Enabled = false;
            
            }
        }

        int iSegundosAntesDecerrar = 0;


        private void timerCerrarForm_Tick(object sender, EventArgs e)
        {
            try
            {
                if (iSegundosAntesDecerrar == 0)
                {
                    this.Close();
                    timerCerrarForm.Enabled = false;
                }
                iSegundosAntesDecerrar = iSegundosAntesDecerrar - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                timerCerrarForm.Enabled = false;
                
            }
        }

    }
}
