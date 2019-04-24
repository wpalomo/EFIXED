using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirmElect.Info;
using FirmElect.Bus;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using DevExpress.XtraReports.UI;
using FirmElect.Reports;
using System.Xml;
using MailEfirm.Forms;

namespace MailEfirm.Controls
{
    public partial class UC_Mail_Buzon_Salida : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        #region Declaración de Variables
        List<cl_error_Info> ListaBindErrores = new List<cl_error_Info>();

        static cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;
        string mensajeError = ""; 
        string RutaArchivos = "";
        BindingList<mail_Mensaje_Info> listaMensajes = new BindingList<mail_Mensaje_Info>();
        BindingList<tb_Comprobante_Info> Listadors_de_Comprobante_Emisor = new BindingList<tb_Comprobante_Info>();
        mail_Mensaje_Bus Bus_Mensaje = new mail_Mensaje_Bus();
        mail_Mensaje_Archi_Adjunto_Bus Bus_MailAdjunto = new mail_Mensaje_Archi_Adjunto_Bus();
        tb_Comprobante_Bus Bus_Comprobante_emisor = new tb_Comprobante_Bus();
        mail_Mensaje_Archi_Adjunto_Bus BusArchivo_Adjunto = new mail_Mensaje_Archi_Adjunto_Bus();
        tb_Empresa_Bus busempresa = new tb_Empresa_Bus();
        mail_Mensaje_Archi_Adjunto_Info AdjuntoInfo = new mail_Mensaje_Archi_Adjunto_Info();
        tb_Comprobante_Info comprobante = new tb_Comprobante_Info();
        List<tb_Empresa_Info> listEmpr = new List<tb_Empresa_Info>();

        List<mail_Mensaje_Archi_Adjunto_Info> ListaArchivo_Adjunto_Sin_Actualizar = new List<mail_Mensaje_Archi_Adjunto_Info>();
        List<mail_Mensaje_Archi_Adjunto_Info> ListaArchivo_Adjunto_Actualizada = new List<mail_Mensaje_Archi_Adjunto_Info>();
        List<tb_Comprobante_Info> listadeComprobantesEmisor = new List<tb_Comprobante_Info>();

        List<mail_Cuentas_Correo_x_Empresa_Info> listMail_x_Empresa = new List<mail_Cuentas_Correo_x_Empresa_Info>();
        mail_Cuentas_Correo_x_Empresa_Bus BusctaxEm = new mail_Cuentas_Correo_x_Empresa_Bus();
        public string dir_correo = "";
        int minutos = 0;
        int CSegundos = 6;
        int totalSegundos = 1;
        int NumeroPaginas = 0;
        Thread HiloEnviar;
        mail_Mensaje_Info Info;  
        #endregion
                     
        public UC_Mail_Buzon_Salida()
        {
            InitializeComponent();
            RutaArchivos = Path.GetTempPath() + "\\";
            
        }

       public void UCRedactarMail_Event_Correo_generado()
        {
            try
            {
                btn_Refresh_Click(null, null);
                btn_enviar_Click(null, null);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
            
        }

       public void mostrar_mensajes(eTipoMail TipoMail, int IndicePagina, string direccionCorreo)
        {
            try
            {
                string msg = "";
                toolStripLabelCorreo.Text = direccionCorreo;
                dir_correo = direccionCorreo;
                listaMensajes = new BindingList<mail_Mensaje_Info>(Bus_Mensaje.consultar(TipoMail, direccionCorreo, uC_Botones_Paginas1.IndicePagina, uC_Botones_Paginas1.Total_Registros_x_pagina, (uC_Botones_Paginas1.Cadena_Busqueda == null) ? "" : uC_Botones_Paginas1.Cadena_Busqueda, ref msg));

                foreach (var item in listaMensajes)
                {
                    item.Checked = true;
                }
                NumeroPaginas = Bus_Mensaje.ObtenerNumPag(uC_Botones_Paginas1.Total_Registros_x_pagina, TipoMail, direccionCorreo, (uC_Botones_Paginas1.Cadena_Busqueda == null) ? "" : uC_Botones_Paginas1.Cadena_Busqueda, ref msg);
              
                uC_Botones_Paginas1.NumeroPaginas = NumeroPaginas;

                gridControlVisor_Mail.DataSource = listaMensajes;
                gridControlVisor_Mail.RefreshDataSource();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
        
        }
       
        private void gridControlVisor_Mail_Load(object sender, EventArgs e)
        {
            try
            {
                string mensajeErrorOut = "";
                listMail_x_Empresa = BusctaxEm.Consulta_mail_Cuentas_Correo_x_Empresa(ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }


        }

        private void UC_Visor_Mail_Load(object sender, EventArgs e)
        {
            try
            {


                

               

                cl_parametrosGenerales_Bus BusParam = new cl_parametrosGenerales_Bus();

                BusParam.Cargar_Variables_Globales(ref mensajeError);


                lblAutorzacion_envio_mail.Text = (param.AUTORIZADO_ENVIO_CORREO == true ? "Usted esta Autorizado para enviar correo" : "Usted NO esta Autorizado para enviar correo");
                lblAutorzacion_envio_mail.Text = (param.AUTORIZADO_ENVIO_CORREO == true ? "Usted esta Autorizado para enviar correo" : "");
                lblAutorzacion_envio_mail.ForeColor = (param.AUTORIZADO_ENVIO_CORREO == true ? Color.Blue : Color.Red);
               



                listEmpr = busempresa.GetEmpresas(ref mensajeError);
                gridControlError.DataSource = ListaBindErrores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private Boolean Validacion_x_Mensaje(mail_Mensaje_Info MensajeInfo, ref string mensajeErrorOut)
        {
            try
            {
                string IdCuenta_mail = "";


                if (MensajeInfo.InfoContribuyente == null)
                {
                    mensajeErrorOut = "No existe contribuyente en el objeto MensajeInfo";
                    return false;
                }

                mail_Cuentas_Correo_Info InfoCtaMail_Remitente = new mail_Cuentas_Correo_Info();


                if (listMail_x_Empresa.Count > 0)
                {
                    var qMail = from C in listMail_x_Empresa
                                where C.IdEmpresa == MensajeInfo.InfoContribuyente.IdEmpresa
                                select C;

                    if (qMail.Count() > 0)
                    {
                        foreach (var item in qMail)
                        {
                            IdCuenta_mail = item.IdCuenta;
                        }
                    }
                    else
                    {
                        mensajeErrorOut = "No Existe cuenta de correo relacionada con el emisor verique en configuracion de cuenta de correo";
                        return false;
                    }
                }
                else
                {
                    mensajeErrorOut = "No Existe cuenta de correo relacionada con el emisor verique en configuracion de cuenta de correo";
                    return false;
                }


                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                return false;
            }
        }

        private void enviar()
        {
            try
            {
                lblMensajeError.Text = "";
                mensajeError = "";

                


                btn_enviar.Enabled = false;

                //timerSensor_Envio.Enabled = false;
                
                //vivo el sensor del hilo
                timerSensorHilo.Enabled = true;
                backgroundWorker_BarraEstado.RunWorkerAsync();
                HiloEnviar = new Thread(new ThreadStart(enviar_lista_correo));
                HiloEnviar.Start();
               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (listMail_x_Empresa.Count == 0)
                {

                    MessageBox.Show("No Existe cuenta de correo relacionada con el emisor verique en configuracion de cuenta de correo", param.Nom_Sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }

                
                    enviar();
               
        

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }


            
        }

        private void enviar_lista_correo()
        {
            try
            {

                string mensajeFile = "";
                string msg="";
                ListaArchivo_Adjunto_Actualizada = new List<mail_Mensaje_Archi_Adjunto_Info>();

                List<mail_Mensaje_Info> listCorreo_x_Enviar = new List<mail_Mensaje_Info>();

                listCorreo_x_Enviar = Bus_Mensaje.consultar(eTipoMail.Buzon_Sal, dir_correo, 1, 50, "", ref msg);

                foreach (var item in listCorreo_x_Enviar)
                {   

                    if (Validacion_x_Mensaje(item, ref mensajeError))
                    {

                        item.Texto_mensaje = item.Texto_mensaje + " " + mensajeFile;

                        if (Bus_Mensaje.Enviar_Correo(item, ref mensajeError)==false)
                        {
                            cl_error_Info infoError = new cl_error_Info();
                            mensajeError  = "Correo No Enviado :" + mensajeError;
                            infoError.detalle = mensajeError;
                            infoError.sfecha = DateTime.Now.ToString();
                            ListaBindErrores.Add(infoError);
                        }

                        
                        
                    }
               }


            }
            catch (Exception ex)
            {

                cl_error_Info infoError = new cl_error_Info();
                mensajeError = "Correo No Enviado :" + mensajeError + ex.Message;
                infoError.detalle = mensajeError;
                infoError.sfecha = DateTime.Now.ToString();

                ListaBindErrores.Add(infoError);

            }
        }         

        private void backgroundWorker_BarraEstado_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

               for (int i = 0; i < 100; i++)
                {
                    if (backgroundWorker_BarraEstado.CancellationPending)
                        break;


                    backgroundWorker_BarraEstado.ReportProgress(i);
                    Thread.Sleep(1000);
                }


            }
            catch (Exception ex)
            {
               
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void backgroundWorker_BarraEstado_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (pgb_barra_estado.Value != null)
                {
                    pgb_barra_estado.Value = e.ProgressPercentage;
                }
            }
            catch (Exception ex)
            {
                backgroundWorker_BarraEstado.CancelAsync();
                //MessageBox.Show(ex.Message.ToString());
                //BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

        }

        private void backgroundWorker_BarraEstado_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                pgb_barra_estado.Value = 0;

               

                lblMensajeError.Text =  mensajeError;
            }
            catch (Exception ex)
            {
                backgroundWorker_BarraEstado.CancelAsync();
                //MessageBox.Show(ex.Message.ToString());
                //BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
            
        }
        
        private void timerSensorHilo_Tick(object sender, EventArgs e)
        {
            try
            {
                if (HiloEnviar != null)
                {
                    if (HiloEnviar.IsAlive == false)
                    {
                        backgroundWorker_BarraEstado.CancelAsync();
                        lblMensajeError.Text = "Envio y Recepcion finalizado...";
                        mostrar_mensajes(eTipoMail.Buzon_Sal, uC_Botones_Paginas1.IndicePagina, toolStripLabelCorreo.Text);
                        btn_enviar.Enabled = true;
                        timerSensorHilo.Enabled = false;
                        gridControlError.RefreshDataSource();


                    }
                }

            }
            catch (Exception ex)
            {
                timerSensorHilo.Enabled = false;
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeError.Text = "";
                mostrar_mensajes(eTipoMail.Buzon_Sal,uC_Botones_Paginas1.IndicePagina , toolStripLabelCorreo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
        }
      
        private void gridViewVisorMail_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                mail_Mensaje_Info InfoMensaje = new mail_Mensaje_Info();
                               
                switch (e.Column.Name)
                {
                    case "colcheck":

                        if ((bool)gridViewVisorMail.GetFocusedRowCellValue(colcheck))
                        {
                                gridViewVisorMail.SetFocusedRowCellValue(colcheck, false);

                        }
                        else
                        {
                                gridViewVisorMail.SetFocusedRowCellValue(colcheck, true);
                        }

                        break;

                    case "ColEliminar":

                             InfoMensaje= new mail_Mensaje_Info();
                            InfoMensaje = (mail_Mensaje_Info)gridViewVisorMail.GetFocusedRow();

                            if (MessageBox.Show("Esta seguro de borrar este correo ..", "Mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Bus_Mensaje.Eliminar_Mensaje(InfoMensaje, ref mensajeError);
                                btn_Refresh_Click(null, null);
                            }
                           
                        break;

                    case "ColIcono":

                        InfoMensaje = new mail_Mensaje_Info();
                        InfoMensaje = (mail_Mensaje_Info)gridViewVisorMail.GetFocusedRow();

                        Llamar_form_redactar_mail(InfoMensaje);


                        break;


                    default:

                        break;

                }                          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }
                  
        private void gridViewVisorMail_DoubleClick(object sender, EventArgs e)
        {
            try
            {                                
                Info = new mail_Mensaje_Info();
                Info = this.gridViewVisorMail.GetFocusedRow() as mail_Mensaje_Info;

                Llamar_form_redactar_mail(Info);               
            }
            catch (Exception ex)
            {              
            }
        }

        private void Llamar_form_redactar_mail(mail_Mensaje_Info InfoMail)
        {
            try
            {
                Info.Asunto = "RE:" + Info.Asunto;
                Info.Asunto_texto_mostrado = "RE:" + Info.Asunto_texto_mostrado;

                Frm_Redactar_Email ofrm = new Frm_Redactar_Email();
                ofrm.set_label_buton_enviar("Reenviar..");

                ofrm.set(Info);
                ofrm.ShowDialog();

                btn_Refresh_Click(null, null);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void gridViewVisorMail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {                                                   
            }
            catch (Exception ex)
            {                              
            }
        }

        private void chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in listaMensajes)
                {
                    item.Checked = chk_todos.Checked;
                }

                gridControlVisor_Mail.RefreshDataSource();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
                
            }
        }

        private void uC_Botones_Paginas1_event_click_buttons_1(object sender, EventArgs e, int _IndicePagina)
        {
            mostrar_mensajes(eTipoMail.Buzon_Sal, _IndicePagina, dir_correo);
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gridControlVisor_Mail_Click(object sender, EventArgs e)
        {

        }

        
      
    }
}
