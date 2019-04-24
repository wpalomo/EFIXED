using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailEfirm.Forms;
using MailEfirm.Controls;
using FirmElect.Info;
using FirmElect.Bus;
using System.Threading;



namespace MailEfirm.Controls
{
    public partial class UC_Menu_Main : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        Frm_Nuevo_Usuario formulario;
        Frm_Redactar_Email FrmMain;
        int CSegundoEnvioRecepcion = 0;
        int TiempoSegundosEnviarRecibir = 0;

        //public eTipo_Perfil_Usuario P_Perfil_Usuario { get; set; }

        public void set_perfil(eTipo_Perfil_Usuario Perfil)
        {
            try
            {

                //if (Perfil == eTipo_Perfil_Usuario.CLIENTE)
                //{
                //    btnEnviar_y_recibir.Enabled = false;
                //    btn_EnvioMailMasivo.Enabled = false;
                //    btn_nuevo_mail.Enabled = false;
                //    lblEstadoPerfil.Caption = "PERFIL:CLIENTE CIERTAS OPCIONES ESTAN DESHABILITADAS.";
                //    timerContadorEnvioRecepcion.Enabled = false;
                //}

                //if (Perfil == eTipo_Perfil_Usuario.SERVER)
                //{
                //    lblEstadoPerfil.Caption = "PERFIL:SERVER";
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
                
            }
        }


        Thread HiloEnviar;



        public delegate void delegate_btn_nuevo_mail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_nuevo_mail_ItemClick event_btn_nuevo_mail_ItemClick;

        Uc_Contacto_consul uc_Contactos = new Uc_Contacto_consul();

        UC_Mail_Buzon_Salida uC_Buzon_Salida = new UC_Mail_Buzon_Salida();
        UC_Mail_Buzon_Elementos_Enviados uC_Buzon_Elementos_Enviados = new UC_Mail_Buzon_Elementos_Enviados();
        UC_Mail_Buzon_Entrada uC_Buzon_Entrada = new UC_Mail_Buzon_Entrada();
        UC_Mail_Elementos_Eliminados uC_Buzon_Elementos_Eliminados = new UC_Mail_Elementos_Eliminados();
        UC_Mail_No_Enviados_x_Errores UC_Buzon_Mail_No_Enviados_x_Errores = new UC_Mail_No_Enviados_x_Errores();



        mail_Mensaje_Bus BusMensaje = new mail_Mensaje_Bus();
        List<cl_error_Info> listError = new List<cl_error_Info>();


        string cuentaCorreo;


        public UC_Menu_Main()
        {
            InitializeComponent();
            event_btn_nuevo_mail_ItemClick += UC_Menu_Main_event_btn_nuevo_mail_ItemClick;
            panelMain.Controls.Add(uc_Contactos);
            panelMain.Controls.Add(uC_Buzon_Salida);
            panelMain.Controls.Add(uC_Buzon_Elementos_Enviados);
            panelMain.Controls.Add(uC_Buzon_Elementos_Eliminados);
            panelMain.Controls.Add(uC_Buzon_Entrada);
            panelMain.Controls.Add(UC_Buzon_Mail_No_Enviados_x_Errores);
        }

        void UC_Menu_Main_event_btn_nuevo_mail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

       
        void Visibilidad_controles(Boolean Valor)
        {
            try
            {
                uc_Contactos.Visible = Valor;
                uC_Buzon_Salida.Visible = Valor;
                uC_Buzon_Elementos_Enviados.Visible = Valor;
                uC_Buzon_Elementos_Eliminados.Visible = Valor;
                uC_Buzon_Entrada.Visible = Valor;
                UC_Buzon_Mail_No_Enviados_x_Errores.Visible = Valor;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
                
            }
        }

        public  void Mostrar_control(eTipoControl TipoControl,eTipoMail TipoMensaje, string direccionCorreo )
        {
            try
            {
                Visibilidad_controles(false);

                switch (TipoControl)
                { 
                    case eTipoControl.VisorMail:


                        switch (TipoMensaje)
                        {
                            case eTipoMail.Buzon_Ent:
                                  
                                  uC_Buzon_Entrada.Visible = true;
                                  uC_Buzon_Entrada.Dock = DockStyle.Fill;
                                  uC_Buzon_Entrada.dir_correo = direccionCorreo;
                                  uC_Buzon_Entrada.mostrar_mensajes(eTipoMail.Buzon_Ent, 1, direccionCorreo);
                                
                                break;
                            case eTipoMail.Buzon_Sal:

                                uC_Buzon_Salida.Visible = true;
                                uC_Buzon_Salida.Dock = DockStyle.Fill;
                                uC_Buzon_Salida.mostrar_mensajes(TipoMensaje, 1,direccionCorreo);
                                break;
                            case eTipoMail.Enviado:
                                  uC_Buzon_Elementos_Enviados.Visible = true;
                                uC_Buzon_Elementos_Enviados.Dock = DockStyle.Fill;
                                uC_Buzon_Elementos_Enviados.mostrar_mensajes( direccionCorreo, 1);
                                break;
                            case eTipoMail.Eliminado:

                                uC_Buzon_Elementos_Eliminados.Visible = true;
                                uC_Buzon_Elementos_Eliminados.Dock = DockStyle.Fill;
                                uC_Buzon_Elementos_Eliminados.mostrar_mensajes(direccionCorreo,1);
                                break;
                            case eTipoMail.Mail_NO_Env_x_error:

                                UC_Buzon_Mail_No_Enviados_x_Errores.Visible = true;
                                UC_Buzon_Mail_No_Enviados_x_Errores.Dock = DockStyle.Fill;
                                UC_Buzon_Mail_No_Enviados_x_Errores.mostrar_mensajes(direccionCorreo, 1);
                                break;
                            case eTipoMail.Borrador:
                                break;

                        }

                      
                        break;
                    case eTipoControl.Contacto:
                        //ribbonPageMail.Visible = true;
                        //uc_Contactos.Visible = true;
                        uc_Contactos.Dock = DockStyle.Fill;
                        break;
                    

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
               
        }
       
        public void MostarControlUsuario(eTipo_Contacto tipo)
        {
         

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                Mostrar_control(eTipoControl.Contacto, eTipoMail.Borrador, cuentaCorreo);
                //ribbonPagecontacto.Visible = true;
                //ribbonPageMail.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
            
        }

        private void navBarItemSendItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                Mostrar_control(eTipoControl.VisorMail, eTipoMail.Enviado, cuentaCorreo);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void uC_Visor_Mail_Load(object sender, EventArgs e)
        {

        }

        private void navBarItemDelete_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {Mostrar_control(eTipoControl.VisorMail, eTipoMail.Borrador, cuentaCorreo);

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void barButtonINewContat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemEditCont_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //uc_Contactos.getin
            tb_Contribuyente_Info Info = new tb_Contribuyente_Info();
            Info=uc_Contactos.getInfo_Contacto();
            if (Info.IdContribuyente == 0)
            {
                MessageBox.Show("Selecione un Registro", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                formulario = new Frm_Nuevo_Usuario();                
                formulario.uC_Registro_Contacto.set_info(Info);
                formulario.ShowDialog();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        mail_Parametro_Info InfoParametros = new mail_Parametro_Info();
        mail_Parametro_Bus BusParametros = new mail_Parametro_Bus();


        private void UC_Menu_Main_Load(object sender, EventArgs e)
        {
            try
            {
                string msg = "";

                cuentaCorreo = uC_Menu_cuentas_mail.obtenerPrimerNodo();
                Mostrar_control(eTipoControl.VisorMail, eTipoMail.Buzon_Sal, cuentaCorreo);

                InfoParametros = BusParametros.consultar(ref msg);



                TiempoSegundosEnviarRecibir = InfoParametros.valor_min_envi_recep_aut * 60;
              


                CSegundoEnvioRecepcion = TiempoSegundosEnviarRecibir;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
           
        }

        private void btnConfigCuenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Menu_Cuentas cuentas = new Frm_Menu_Cuentas();
            cuentas.ShowDialog();
        }

        private void btn_nuevo_mail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmMain = new Frm_Redactar_Email();
                FrmMain.StartPosition = FormStartPosition.CenterScreen;
                FrmMain.ShowDialog();
                //event_btn_nuevo_mail_ItemClick(sender, e);

                uC_Buzon_Salida.mostrar_mensajes(eTipoMail.Buzon_Sal,1, cuentaCorreo);
                uC_Buzon_Salida.UCRedactarMail_Event_Correo_generado();
                             


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void barbtnConfgs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Configuraciones conf = new Frm_Configuraciones();
            conf.ShowDialog();
        }

        private void uC_Menu_cuentas_mail_event_treeListMenuMail_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info Info = (vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info)e.Node.Tag;

                if (Info.IdTipo_Mensaje != null)
                {
                    eTipoMail TipoBuzon;
                    TipoBuzon = (eTipoMail)Enum.Parse(typeof(eTipoMail), Info.IdTipo_Mensaje);
                    cuentaCorreo = Info.direccion_correo;
                    Mostrar_control(eTipoControl.VisorMail, TipoBuzon, Info.direccion_correo);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }


        }

        private void dockPanelMail_Click(object sender, EventArgs e)
        {

        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnEnviar_y_recibir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                timerContadorEnvioRecepcion.Enabled = false;
                Frm_Enviar_y_Recibir_Cuentas frm = new Frm_Enviar_y_Recibir_Cuentas();
                frm.ShowDialog();
                timerContadorEnvioRecepcion.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        


        private void timerContadorEnvioRecepcion_Tick(object sender, EventArgs e)
        {
            try
            {

                if (CSegundoEnvioRecepcion <= 0  )
                {
                    if (TiempoSegundosEnviarRecibir > 0)
                    {
                        CSegundoEnvioRecepcion = TiempoSegundosEnviarRecibir;
                    }
                    else
                    {
                        CSegundoEnvioRecepcion = 300;
                    }
                    
                    
                    ProcesoHiloenviar();

                    //descargar_correo_buzon_entrada();

                }

                

                CSegundoEnvioRecepcion = CSegundoEnvioRecepcion - 1;

                //lbl_contador_envio_recepcion.Caption = "El correo se enviara en:" + CSegundoEnvioRecepcion;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
            }
        }


        private void descargar_correo_buzon_entrada()
        {
            try
            {
                string mensajError = "";
                  mail_Cuentas_Correo_Bus bus_correo = new mail_Cuentas_Correo_Bus();
                  List<mail_Cuentas_Correo_Info> lista_Correo = new List<mail_Cuentas_Correo_Info>();
                  UC_Mail_Buzon_Entrada UC_Buz_Ent = new UC_Mail_Buzon_Entrada();
                  lista_Correo = bus_correo.consultar(ref mensajError);

                  foreach (var item in lista_Correo)
                  {
                      mail_Cuentas_Correo_Info Info_Buz_Ent = new mail_Cuentas_Correo_Info();
                      Info_Buz_Ent = item;
                      UC_Buz_Ent.Buzon_Entrada_Descarga(Info_Buz_Ent);
                  }                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
            }
        }


        private void enviar_correo_buzon_salida()
        {
            try
            {
                BusMensaje.enviar_correo_buzon_salida(ref listError);
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
                timerContadorEnvioRecepcion.Enabled = false;
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
            //    if (prg_progreso_main != null)
            //    {
            //        UpdateProgressBar(e.ProgressPercentage);
            //    }
            }
            catch (Exception ex)
            {

            }
        }

        private void backgroundWorkerEnvio_y_Recep_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                //prg_progreso_main.Edit.va Value = 100;
                UpdateProgressBar(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

        }

        private void UpdateProgressBar(int value)
        {
            //if (prg_progreso_main.EditValue != null)
            //{
            //    BeginInvoke(new MethodInvoker(delegate { prg_progreso_main.EditValue = value; }));
            //}
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcesoHiloenviar();
        }

        private void timerSensorHiloEnviar_Tick(object sender, EventArgs e)
        {
            try
            {

                if (HiloEnviar.IsAlive == false) //esta ejecutandoce
                {
                    backgroundWorkerEnvio_y_Recep.CancelAsync();
                    timerSensorHiloEnviar.Enabled = false;
                    UpdateProgressBar(100);
                    timerContadorEnvioRecepcion.Enabled = true;//prengo en contador


                    //lbl_mensaje_error.ItemAppearance.Normal.ForeColor = Color.Blue;
                    //lbl_mensaje_error.Caption = "";

                    if (listError.Count > 0)
                    {
                        
                        string msg = "";

                        foreach (var item in listError)
                        {
                            msg = msg  + item.detalle;
                        }
                        //lbl_mensaje_error.Caption = msg;
                        //lbl_mensaje_error.ItemAppearance.Normal.ForeColor = Color.Red;
                    }
                    


                }

            }
            catch (Exception ex)
            {
                timerSensorHiloEnviar.Enabled = false;
                backgroundWorkerEnvio_y_Recep.CancelAsync();
                MessageBox.Show(ex.Message);
                BusSisLog.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
        }

        private void uC_Menu_cuentas_mail_Load(object sender, EventArgs e)
        {

        }

        private void btn_EnvioMailMasivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Frm_Enviar_Cbtes_Auto_Mail frm = new Frm_Enviar_Cbtes_Auto_Mail();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();


                
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void btn_EnvioMailMasivo_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }



        
    }
}
