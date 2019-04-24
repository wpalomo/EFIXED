using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using FirmElect.Info;
using FirmElect.Bus;
using EAGetMail;
using System.IO;
using System.Text.RegularExpressions;
using MailEfirm.Forms;

namespace MailEfirm.Forms
{
    public partial class Frm_Paginacion_Prueba : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        mail_Mensaje_Info infoMensaje;
        mail_Mensaje_Bus Bus_Mensaje = new mail_Mensaje_Bus();
        mail_Cuentas_Correo_Info InfoCuenta = new mail_Cuentas_Correo_Info();
        List<mail_Mensaje_Info> lista_Mensaje = new List<mail_Mensaje_Info>();
        List<string> lista_codMensajeId_Existentes = new List<string>();
        mail_Mensaje_Archi_Adjunto_Bus bus_Adjunto = new mail_Mensaje_Archi_Adjunto_Bus();
        List<mail_Mensaje_Archi_Adjunto_Info> lista_Adjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();
        string server = "";
        string user = "";
        string password = "";
        string protocolo = "";
        public  string dir_correo = "";
        string para = "";
        string CC = "";
        int conta = 0;
        int sec = 0;
        bool usa_sll;
        bool guardar_copia;
        string IdCuenta = "";
        private string m_curpath = "";
        private bool m_bcancel = false;
        private string m_uidlfile = "uidl.txt";
        #endregion

        public Frm_Paginacion_Prueba()
        {
            InitializeComponent();
        }

        public void OnAuthorized(object sender, ref bool cancel)
        {
            lblStatus.Text = "Authorized ...";
            cancel = m_bcancel;
            Application.DoEvents();
        }

        public void OnConnected(object sender, ref bool cancel)
        {
            try
            {
                lblStatus.Text = "Connected ...";
                cancel = m_bcancel;
                Application.DoEvents();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        public void OnIdle(object sender, ref bool cancel)
        {
            try
            {
                cancel = m_bcancel;
                Application.DoEvents();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        public void OnSecuring(object sender, ref bool cancel)
        {
            lblStatus.Text = "Securing ...";
            cancel = m_bcancel;
            Application.DoEvents();
        }

        public void OnReceivingDataStream(object sender, MailInfo info, int received, int total, ref bool cancel)
        {
            try
            {
                pgBar.Minimum = 0;
                pgBar.Maximum = total;
                pgBar.Value = received;
                cancel = m_bcancel;
                Application.DoEvents();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private string _FormatHtmlTag(string src)
        {
            src = src.Replace(">", "&gt;");
            src = src.Replace("<", "&lt;");
            return src;
        }

        private void ShowMail(string fileName)
        {
            try
            {
                string mainName = "";
                int pos = fileName.LastIndexOf(".");

                if (pos < 0)
                {
                    mainName = fileName;
                }
                else
                {
                    mainName = fileName.Substring(0, pos);
                }

                // mainName = fileName.Substring(0, pos);
                string htmlName = mainName + ".htm";

                string tempFolder = mainName;
                if (!File.Exists(htmlName))
                {	// no hemos generar el html de este correo electrónico, generar ahora.
                    _GenerateHtmlForEmail(htmlName, fileName, tempFolder);
                }
                else
                {
                    _GenerateHtmlForEmail(htmlName, fileName, tempFolder);

                }

                object empty = System.Reflection.Missing.Value;
                //webMail.Navigate(htmlName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void _GenerateHtmlForEmail(string htmlName, string emlFile, string tempFolder)
        {

            try
            {
                Mail oMail = new Mail("EG-B1374632949-00215-D3BEB6416TE2E729-A84ADDF9C5A1C85F");

                oMail.Load(emlFile, false);

                if (oMail.IsEncrypted)
                {
                    try
                    {
                        // este mensaje es encriptado, que descifrarlo por certificado predeterminado de usuario.
                        // También puede utilizar el certificado especificado como este
                        // OCert = nuevo Certificado ();
                        // OCert.Load ("c: \\ test.pfx", "pfxpassword", Certificate.CertificateKeyLocation.CRYPT_USER_KEYSET)
                        // Omail = oMail.Decrypt (oCert);

                        oMail = oMail.Decrypt(null);
                    }
                    catch (Exception ep)
                    {
                        MessageBox.Show(ep.Message);
                        oMail.Load(emlFile, false);
                    }
                }

                if (oMail.IsSigned)
                {
                    try
                    {
                        // este correo electrónico se firma digital.
                        EAGetMail.Certificate cert = oMail.VerifySignature();
                        MessageBox.Show("This email contains a valid digital signature.");

                        // puede agregar el certificado en el almacén de certificados como este
                        //cert.AddToStore (Certificate.CertificateStoreLocation.CERT_SYSTEM_STORE_CURRENT_USER,
                        // "Libreta de direcciones");
                        // Entonces usted puede utilizar enviar el correo electrónico cifrado de nuevo a este remitente.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                    }
                }

                // Winmail.dat decodificación (corriente de Outlook TNEF) automáticamente.
                // También convertir cuerpo RTF a cuerpo HTML automáticamente.
                oMail.DecodeTNEF();

                string html = oMail.HtmlBody;
                StringBuilder hdr = new StringBuilder();

                hdr.Append("<font face=\"Courier New,Arial\" size=2>");
                hdr.Append("<b>From:</b> " + _FormatHtmlTag(oMail.From.ToString()) + "<br>");
                MailAddress[] addrs = oMail.To;
                int count = addrs.Length;
                if (count > 0)
                {
                    hdr.Append("<b>To:</b> ");
                    for (int i = 0; i < count; i++)
                    {
                        hdr.Append(_FormatHtmlTag(addrs[i].ToString()));
                        if (i < count - 1)
                        {
                            hdr.Append(";");
                        }
                    }
                    hdr.Append("<br>");
                }

                addrs = oMail.Cc;

                count = addrs.Length;
                if (count > 0)
                {
                    hdr.Append("<b>Cc:</b> ");
                    for (int i = 0; i < count; i++)
                    {
                        hdr.Append(_FormatHtmlTag(addrs[i].ToString()));
                        if (i < count - 1)
                        {
                            hdr.Append(";");
                        }
                    }
                    hdr.Append("<br>");
                }

                hdr.Append(String.Format("<b>Subject:</b>{0}<br>\r\n", _FormatHtmlTag(oMail.Subject)));

                Attachment[] atts = oMail.Attachments;
                count = atts.Length;
                if (count > 0)
                {

                    if (!Directory.Exists(tempFolder))
                        Directory.CreateDirectory(tempFolder);

                    hdr.Append("<b>Attachments:</b>");
                    for (int i = 0; i < count; i++)
                    {
                        Attachment att = atts[i];

                        string attname = String.Format("{0}\\{1}", tempFolder, att.Name);
                        att.SaveAs(attname, true);
                        hdr.Append(String.Format("<a href=\"{0}\" target=\"_blank\">{1}</a> ", attname, att.Name));
                        if (att.ContentID.Length > 0)
                        {	//show embedded image.
                            html = html.Replace("cid:" + att.ContentID, attname);
                        }
                        else if (String.Compare(att.ContentType, 0, "image/", 0, "image/".Length, true) == 0)
                        {
                            //show attached image.
                            html = html + String.Format("<hr><img src=\"{0}\">", attname);
                        }
                    }
                }

                Regex reg = new Regex("(<meta[^>]*charset[ \t]*=[ \t\"]*)([^<> \r\n\"]*)", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                html = reg.Replace(html, "$1utf-8");
                if (!reg.IsMatch(html))
                {
                    hdr.Insert(0, "<meta HTTP-EQUIV=\"Content-Type\" Content=\"text/html; charset=utf-8\">");
                }

                html = hdr.ToString() + "<hr>" + html;
                FileStream fs = new FileStream(htmlName, FileMode.Create, FileAccess.Write, FileShare.None);
                byte[] data = System.Text.UTF8Encoding.UTF8.GetBytes(html);
                fs.Write(data, 0, data.Length);
                fs.Close();
                oMail.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }


        private void btndescargarcorreo_Click(object sender, EventArgs e)
        {
            try
            {
                string mensajError = "";
                if (InfoCuenta == null)
                {
                    mail_Cuentas_Correo_Bus bus_correo = new mail_Cuentas_Correo_Bus();
                    List<mail_Cuentas_Correo_Info> lista_Correo = new List<mail_Cuentas_Correo_Info>();
                    lista_Correo = bus_correo.consultar(ref mensajError);
                    InfoCuenta = lista_Correo.FirstOrDefault(q => q.direccion_correo == dir_correo);
                }

                if (InfoCuenta.ServidorCorreoEntrante.Length == 0 || InfoCuenta.Usuario.Length == 0 || InfoCuenta.Password.Length == 0)
                {
                    MessageBox.Show("Por favor ingrese servidor, usuario y contraseña.");
                    return;
                }
                // cargo los ID de mensaje para no tener q ir a la DB
                lista_codMensajeId_Existentes = new List<string>();
                lista_codMensajeId_Existentes = Bus_Mensaje.consultar_CodMail_Existentes();
                btndescargarcorreo.Enabled = false;
                btnCancel.Enabled = true;
                lista_Mensaje = new List<mail_Mensaje_Info>();
                string mensajeError = "";

                ServerAuthType authType = ServerAuthType.AuthLogin;

                if (InfoCuenta.Tipo_Authenticacion == "APOP")
                    authType = ServerAuthType.AuthCRAM5;
                else if (InfoCuenta.Tipo_Authenticacion == "NTLM")
                    authType = ServerAuthType.AuthNTLM;
                // ServerProtocol protocol = (ServerProtocol)lstProtocol.SelectedIndex;
                ServerProtocol protocol = new ServerProtocol();
                if (InfoCuenta.TipoCuenta == "POP3")
                {
                    protocol = ServerProtocol.Pop3;
                }
                if (InfoCuenta.TipoCuenta == "IMAP4")
                {
                    protocol = ServerProtocol.Imap4;
                }
                if (InfoCuenta.TipoCuenta == "EXCHA_WEB_SER")
                {
                    protocol = ServerProtocol.ExchangeEWS;
                }
                if (InfoCuenta.TipoCuenta == "EXCHA_WEB_DAV")
                {
                    protocol = ServerProtocol.ExchangeWebDAV;
                }


                usa_sll = (InfoCuenta.Usa_SSL_Conexion_para_Descarga_correo == null) ? false : (Boolean)InfoCuenta.Usa_SSL_Conexion_para_Descarga_correo;

                MailServer oServer = new MailServer(InfoCuenta.ServidorCorreoEntrante, InfoCuenta.Usuario, InfoCuenta.Password,
                    usa_sll, authType, protocol);



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
                oClient.OnIdle += new MailClient.OnIdleEventHandler(OnIdle);
                oClient.OnSecuring += new MailClient.OnSecuringEventHandler(OnSecuring);
                oClient.OnReceivingDataStream += new MailClient.OnReceivingDataStreamEventHandler(OnReceivingDataStream);

                bool bMantener_copia_correo = (InfoCuenta.Guardar_1_copia_de_corre_en_server_mail == null) ? false : (Boolean)InfoCuenta.Guardar_1_copia_de_corre_en_server_mail;

                UIDLManager oUIDLManager = new UIDLManager();

                try
                {
                    // Carga existían registros UIDL a UIDLManager
                    string uidlfile = String.Format("{0}\\{1}", m_curpath, m_uidlfile);
                    oUIDLManager.Load(uidlfile);

                    string mailFolder = String.Format("{0}\\inbox", m_curpath);
                    if (!Directory.Exists(mailFolder))
                        Directory.CreateDirectory(mailFolder);

                    m_bcancel = false;
                    lblStatus.Text = "Conectando ...";
                    oClient.Connect(oServer);
                    MailInfo[] infos = oClient.GetMailInfos();
                    lblStatus.Text = String.Format("Total {0} email(s)", infos.Length);

                    // Eliminar el uidl local que no se existía en el servidor.
                    oUIDLManager.SyncUIDL(oServer, infos);
                    oUIDLManager.Update();

                    int count = infos.Length;

                    if (count > 0)
                        lista_Mensaje = new List<mail_Mensaje_Info>();

                    int CountError = 0;

                    for (int i = 0; i < count; i++)
                    {
                        MailInfo info = infos[i];
                        CountError = i;
                        //if (i == 2587) { MessageBox.Show(""); }


                        //verificar en base NO debo ir a la base uno a uno sino se hace muy largo
                        if (lista_codMensajeId_Existentes.Contains(info.UIDL) == false)
                        {


                            lblStatus.Text = String.Format("Retrieving {0}/{1}...", info.Index, count);
                            Mail oMail = oClient.GetMail(info);
                            System.DateTime d = System.DateTime.Now;
                            System.Globalization.CultureInfo cur = new System.Globalization.CultureInfo("en-US");
                            string sdate = d.ToString("yyyyMMddHHmmss", cur);
                            string fileName = String.Format("{0}\\{1}{2}{3}.eml", mailFolder, sdate, d.Millisecond.ToString("d3"), i);


                            try//try1
                            {
                                oMail.SaveAs(fileName, true);

                                conta = 0;
                                conta = oMail.To.ToList().Count();
                                sec = 0;
                                foreach (var itemTo in oMail.To.ToList())
                                {
                                    sec = sec + 1;
                                    if (sec != conta)
                                    {
                                        para += itemTo.Address + "; ";
                                    }
                                    else
                                    {
                                        para += itemTo.Address;
                                    }
                                }

                                conta = 0;
                                conta = oMail.Cc.ToList().Count();
                                sec = 0;
                                foreach (var itemCopia in oMail.Cc.ToList())
                                {
                                    sec = sec + 1;
                                    if (sec != conta)
                                    {
                                        CC += itemCopia.Address + "; ";
                                    }
                                    else
                                    {
                                        CC += itemCopia.Address;
                                    }
                                }


                            }
                            catch (Exception EX)
                            {
                                MessageBox.Show(EX.Message + " try 1");

                            }


                            try//try2
                            {



                                infoMensaje = new mail_Mensaje_Info();
                                infoMensaje.Asunto = oMail.Subject;
                                infoMensaje.Asunto_texto_mostrado = oMail.Subject;
                                // infoMensaje.codMensajeId = MessageID;
                                infoMensaje.codMensajeId = info.UIDL;

                                infoMensaje.fileName = fileName;
                                infoMensaje.Para = para;
                                infoMensaje.Para_CC = CC;
                                infoMensaje.Fecha = oMail.ReceivedDate;
                                infoMensaje.Texto_mensaje = oMail.TextBody;

                                infoMensaje.Tiene_Adjunto = oMail.Attachments.Count() == 0 ? false : true;

                                if (Convert.ToString(oMail.Priority) == "Normal")
                                {
                                    infoMensaje.Prioridad = 0;
                                }
                                if (Convert.ToString(oMail.Priority) == "Alta")
                                {
                                    infoMensaje.Prioridad = 1;
                                }
                                if (Convert.ToString(oMail.Priority) == "Baja")
                                {
                                    infoMensaje.Prioridad = -1;
                                }

                                infoMensaje.Leido = false;
                                infoMensaje.Respondido = false;
                                infoMensaje.No_Leido = false;

                                infoMensaje.mail_remitente = dir_correo;
                                infoMensaje.Eliminado = false;
                                infoMensaje.IdTipo_Mensaje = eTipoMail.Buzon_Ent;


                                infoMensaje.IdCuenta = IdCuenta;

                                foreach (var itemAdju in oMail.Attachments)
                                {
                                    mail_Mensaje_Archi_Adjunto_Info infoAdju = new mail_Mensaje_Archi_Adjunto_Info();

                                    string nomAdju = itemAdju.Name;

                                    string extAdj = Path.GetExtension(nomAdju);
                                    if (extAdj.ToUpper() == ".PDF" || extAdj.ToUpper() == ".XML")
                                    {

                                        infoAdju.extensionArchivo = extAdj;
                                        infoAdju.Archivo_adjunto = itemAdju.Content;
                                        infoAdju.descripcion_archi = itemAdju.Name;

                                        infoMensaje.list_Archivos_Adjuntos.Add(infoAdju);
                                    }

                                }

                                infoMensaje.Archivo_correo = System.IO.File.ReadAllBytes(infoMensaje.fileName);


                                Bus_Mensaje.GrabarMensajeDB(infoMensaje, ref  mensajeError);
                                //lista_Mensaje.Add(infoMensaje);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + " try 2");

                            }


                            oMail.Clear();

                            // si lblTotal.Text = String.Format("Total {0} email(s)", lstMail.Items.Count);

                            if (bMantener_copia_correo)
                            {
                                // añadir el uidl correo electrónico a uidl archivo para evitar recuperamos la próxima vez.
                                oUIDLManager.AddUIDL(oServer, info.UIDL, fileName);
                            }





                        }

                    }

                    if (!bMantener_copia_correo)
                    {
                        lblStatus.Text = "Borrando ...";
                        for (int i = 0; i < count; i++)
                        {
                            oClient.Delete(infos[i]);
                            // Eliminar UIDL de archivo uidl local.
                            oUIDLManager.RemoveUIDL(oServer, infos[i].UIDL);
                        }
                    }
                    // Eliminar método sólo marcar el correo electrónico como eliminado,
                    // Salir método puro los mensajes de correo electrónico desde el servidor exactamente.
                    oClient.Quit();

                    //if (lista_Mensaje.Count() == 0)
                    //{
                    //    MessageBox.Show("No existen Correos de Entrada Nuevos");
                    //    btndescargarcorreo.Enabled = true;
                    //    btnCancel.Enabled = false;
                    //    return;
                    //}


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                }

                // Actualizar la lista uidl de archivo uidl local y luego podemos cargar la próxima vez.
                oUIDLManager.Update();

                lblStatus.Text = "Completed";
                pgBar.Maximum = 100;
                pgBar.Minimum = 0;
                pgBar.Value = 0;
                btndescargarcorreo.Enabled = true;
                btnCancel.Enabled = false;


                //mostrar_mensajes(eTipoMail.Buzon_Ent, dtp_desde.Value, dtp_hasta.Value, dir_correo);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }
    }
}
