using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.IO;
using FirmElect.Info;
using FirmElect.Bus;
using System.Threading;

using EAGetMail;
using EASendMail;

using System.IO;
using System.Text.RegularExpressions;








namespace MailEfirm.Forms
{
    public partial class Frm_Test_Config_Mail_Envio_Recep : Form
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        public Frm_Test_Config_Mail_Envio_Recep()
        {
            InitializeComponent();
        }

       List<cl_error_Info> listErrores = new List<cl_error_Info>();

       
        public mail_Cuentas_Correo_Info InfoCuenta { get; set; }


       private eTipo_Conexion_seguridad_SMTP Tipo_conexion;

       public Frm_Test_Config_Mail_Envio_Recep(mail_Cuentas_Correo_Info Info)
           : this()
        {
            InfoCuenta = Info;

            listErrores = new List<cl_error_Info>();
            gridControl_tareas_realizadas.DataSource = listErrores;

        }

        
        
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        Thread HiloValidar;
      
        
        
        private void Frm_Test_Mail_Envio_Recep_Load(object sender, EventArgs e)
        {
            try
            {

                HiloValidar = new Thread(new ThreadStart(Procesos));
                HiloValidar.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

        }


        private void Procesos()
        {
            try
            {
                Enviar_mail();
                Login_server_correo_();
            }
            catch (Exception ex)
            {
                
                
            }
        }


        public Boolean Enviar_mail()
        {
            try
            {


                SmtpMail oSmtpMail_msg = new SmtpMail("ES-C1407722592-00106-56VB4AE2B4F8TB75-641B598EBE4D439A");
                SmtpServer oSmtpServer = new SmtpServer(InfoCuenta.ServidorCorreoSaliente, InfoCuenta.Port_salida);
                EASendMail.SmtpClient ooSmtpMail_oSmtpMail_msgSmtp = new EASendMail.SmtpClient();





                oSmtpMail_msg.From = new EASendMail.MailAddress(InfoCuenta.direccion_correo);
                oSmtpMail_msg.To.Add(new EASendMail.MailAddress(InfoCuenta.direccion_correo));
                oSmtpMail_msg.Subject = "Mensaje de Prueba " + DateTime.Now;
                oSmtpMail_msg.TextBody= "Mensaje de Prueba configuracion de correo "  + DateTime.Now;

                if (InfoCuenta.tipo_Seguridad != "Ninguno")
                {
                    oSmtpServer.User = InfoCuenta.Usuario;
                    oSmtpServer.Password = InfoCuenta.Password;
                }
                switch (InfoCuenta.tipo_Seguridad)
                {
                    case "SSL":
                        oSmtpServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                        oSmtpServer.Port = 465;
                        break;
                    case "TLS":
                        oSmtpServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                        break;
                    case "Ninguno":
                        oSmtpServer.ConnectType = SmtpConnectType.ConnectNormal;
                        break;
                    case "STARTTLS":
                        oSmtpServer.ConnectType = SmtpConnectType.ConnectSTARTTLS;
                        break;
                    default:
                        oSmtpServer.ConnectType = SmtpConnectType.ConnectNormal;
                        break;
                }

                ooSmtpMail_oSmtpMail_msgSmtp.SendMail(oSmtpServer, oSmtpMail_msg);



                listErrores.Add(new cl_error_Info("0", "ENVIO DE CORREO OK..", DateTime.Now.ToString(), "A", eTipoError.INFO,eTipoRespuesta.OK));
                gridControl_tareas_realizadas.RefreshDataSource();

                return true;

            }
            catch (Exception ex)
            {
                listErrores.Add(new cl_error_Info("1","NO SE ENVIO CORREO..."+ ex.Message, DateTime.Now.ToString(), "A", eTipoError.INFO, eTipoRespuesta.ERROR));
                gridControl_tareas_realizadas.RefreshDataSource();
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                return false;
            }
        }



        private Boolean Login_server_correo_()
        {
            try
            {

                if (InfoCuenta.ServidorCorreoEntrante.Length == 0 || InfoCuenta.Usuario.Length == 0 || InfoCuenta.Password.Length == 0)
                {
                    //MessageBox.Show("Por favor ingrese servidor, usuario y contraseña.");
                }

                //oSmtpServer.User = InfoCuenta.Usuario;
                //oSmtpServer.Password = InfoCuenta.Password;
                ServerAuthType authType = ServerAuthType.AuthLogin;

                if (InfoCuenta.Tipo_Authenticacion== "APOP")
                    authType = ServerAuthType.AuthCRAM5;
                else if (InfoCuenta.Tipo_Authenticacion == "NTLM")
                    authType = ServerAuthType.AuthNTLM;


                EAGetMail.ServerProtocol protocol = new EAGetMail.ServerProtocol();


                if (InfoCuenta.TipoCuenta == "POP3")
                {
                    protocol = EAGetMail.ServerProtocol.Pop3;
                }
                if (InfoCuenta.TipoCuenta == "IMAP4")
                {
                    protocol = EAGetMail.ServerProtocol.Imap4;
                }
                if (InfoCuenta.TipoCuenta == "EXCHA_WEB_SER")
                {
                    protocol = EAGetMail.ServerProtocol.ExchangeEWS;
                }
                if (InfoCuenta.TipoCuenta == "EXCHA_WEB_DAV")
                {
                    protocol = EAGetMail.ServerProtocol.ExchangeWebDAV;
                }

                //MailServer oServer = new MailServer(server, user, password,
                //    chkSSL.Checked, authType, protocol );
                Boolean UsaSll=false;

                UsaSll = (InfoCuenta.Usa_SSL_Conexion_para_Descarga_correo == null) ? false :(Boolean)InfoCuenta.Usa_SSL_Conexion_para_Descarga_correo;


                MailServer oServer = new MailServer(InfoCuenta.ServidorCorreoEntrante, InfoCuenta.Usuario, InfoCuenta.Password,
                  UsaSll, authType, protocol);



                // Para el uso de la evaluación, por favor utilice "TryIt" como el código de licencia, de lo contrario el
                // será lanzado  excepción "código de licencia no válida". Sin embargo, el objeto expirará en 1-2 meses, y luego
                // "versión de prueba expiró" se lanzará una excepción.

                MailClient oClient = new MailClient("EG-B1374632949-00215-D3BEB6416TE2E729-A84ADDF9C5A1C85F");

                //Catching the following events is not necessary, 
                //just make the application more user friendly.
                //If you use the object in asp.net/windows service or non-gui application, 
                //You need not to catch the following events.
                //To learn more detail, please refer to the code in EAGetMail EventHandler region

                oClient.OnAuthorized += new MailClient.OnAuthorizedEventHandler(OnAuthorized);
                oClient.OnConnected += new MailClient.OnConnectedEventHandler(OnConnected);
                //oClient.OnIdle += new MailClient.OnIdleEventHandler(OnIdle);
                //oClient.OnSecuring += new MailClient.OnSecuringEventHandler(OnSecuring);
                //oClient.OnReceivingDataStream += new MailClient.OnReceivingDataStreamEventHandler(OnReceivingDataStream);

                //   bool bLeaveCopy = chkLeaveCopy.Checked;

                bool bLeaveCopy = (InfoCuenta.Guardar_1_copia_de_corre_en_server_mail == null) ? false : (Boolean)InfoCuenta.Guardar_1_copia_de_corre_en_server_mail;


                // UIDL es el identificador de cada correo electrónico de POP3 / IMAP4 / servidor de Exchange, para evitar recuperar
                // El mismo correo electrónico desde el servidor más de una vez, que registra el email UIDL recuperada cada vez
                // Si elimina el correo electrónico desde el servidor cada vez y no dejar una copia del correo electrónico en
                // El servidor, por favor, elimine toda la función sobre uidl.
                // UIDLManager envuelve la función de escribir / leer el registro uidl desde un archivo de texto.

                UIDLManager oUIDLManager = new UIDLManager();
                string mensaje = "";

                try
                {
                    mensaje = "Conectando al server de correo ok ...";
                    oClient.Connect(oServer);

                    MailInfo[] infos = oClient.GetMailInfos();
                    mensaje =   mensaje + "  " +  String.Format("Total {0} email(s)", infos.Length);
                   
                    // Salir método puro los mensajes de correo electrónico desde el servidor exactamente.
                    oClient.Quit();
                    infos = null;

                    listErrores.Add(new cl_error_Info("0", mensaje, DateTime.Now.ToString(), "A", eTipoError.INFO, eTipoRespuesta.OK));
                    gridControl_tareas_realizadas.RefreshDataSource();


                }
                catch (Exception ex)
                {
                    mensaje = "Error al conectar con el server de correo " + ex.Message;
                    listErrores.Add(new cl_error_Info("0", mensaje, DateTime.Now.ToString(), "A", eTipoError.INFO, eTipoRespuesta.ERROR));
                    gridControl_tareas_realizadas.RefreshDataSource();

                    BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
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


        public void OnAuthorized(object sender, ref bool cancel)
        {
            //lblStatus.Text = "Authorized ...";
            //cancel = m_bcancel;
            Application.DoEvents();
        }

        public void OnConnected(object sender, ref bool cancel)
        {
            //lblStatus.Text = "Connected ...";
            //cancel = m_bcancel;
            Application.DoEvents();
        }

        private void timerSensorHilo_enviar_mail_Tick(object sender, EventArgs e)
        {
            

        }

    }
}
