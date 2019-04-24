using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




using EAGetMail;
using System.IO;
using System.Text.RegularExpressions;

using FirmElect.Info;
using FirmElect.Bus;



namespace MailEfirm.Forms
{
    public partial class Frm_Correo_POP_IMAP : Form
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        mail_Mensaje_Info infoMensaje ;
        List<mail_Mensaje_Info> lista_Mensaje = new List<mail_Mensaje_Info>();
        mail_Mensaje_Bus Bus_Mensaje = new mail_Mensaje_Bus();

        List<mail_Mensaje_Archi_Adjunto_Info> lista_Adjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();
        mail_Mensaje_Archi_Adjunto_Bus bus_Adjunto = new mail_Mensaje_Archi_Adjunto_Bus();

        string para = "";
        string CC = "";
        int conta = 0;
        int sec = 0;

        string correo = "";
        string IdCuenta = "";
        
        
        public Frm_Correo_POP_IMAP()
        {
            InitializeComponent();
        }

        private string m_curpath = "";
        private bool m_bcancel = false;
        private string m_uidlfile = "uidl.txt";

        public void OnAuthorized(object sender, ref bool cancel)
        {
            lblStatus.Text = "Authorized ...";
            cancel = m_bcancel;
            Application.DoEvents();
        }

        public void OnConnected(object sender, ref bool cancel)
        {
            lblStatus.Text = "Connected ...";
            cancel = m_bcancel;
            Application.DoEvents();
        }


        public void OnIdle(object sender, ref bool cancel)
        {
            cancel = m_bcancel;
            Application.DoEvents();
        }
        public void OnSecuring(object sender, ref bool cancel)
        {
            lblStatus.Text = "Securing ...";
            cancel = m_bcancel;
            Application.DoEvents();
        }


        public void OnReceivingDataStream(object sender, MailInfo info, int received, int total, ref bool cancel)
        {
            pgBar.Minimum = 0;
            pgBar.Maximum = total;
            pgBar.Value = received;
            cancel = m_bcancel;
            Application.DoEvents();
        }

      
        private void LoadMails()
        {
            try
            {              
                string mailFolder = String.Format("{0}\\inbox", m_curpath);
                if (!Directory.Exists(mailFolder))
                    Directory.CreateDirectory(mailFolder);

                string[] files = Directory.GetFiles(mailFolder, "*.eml");
                int count = files.Length;
                for (int i = 0; i < count; i++)
                {
                    string fullname = files[i];
                    // Para el uso de la evaluación, por favor utilice "TryIt" como el código de licencia, de lo contrario el
                    // será lanzado  excepción "código de licencia no válida". Sin embargo, el objeto expirará en 1-2 meses, y luego
                    // "versión de prueba expiró" se lanzará una excepción.

                    Mail oMail = new Mail("EG-B1374632949-00215-D3BEB6416TE2E729-A84ADDF9C5A1C85F");

                    // Carga (archivo, true) sólo cargar el encabezado del correo electrónico a Correo objeto de salvar la CPU y la memoria
                    // El objeto Correo cargará el archivo de correo electrónico entera tarde de forma automática si se requiere bodyText o apego ..                

                    oMail.Load(fullname, true);                 
              
                    //llenar grid

                    int conta = oMail.Headers.Count;
                    string MessageID = "";
                    for (int y = 0; y < conta; y++)
                    {
                        if (y == 17)
                        {
                            MessageID = oMail.Headers[y].ToString();
                            break;
                        }
                    }
                 
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

                    infoMensaje = new mail_Mensaje_Info();
                    infoMensaje.Asunto = oMail.Subject;
                    infoMensaje.Asunto_texto_mostrado = oMail.Subject;
                    infoMensaje.codMensajeId = MessageID;
                    infoMensaje.fileName = fullname;
                    infoMensaje.Para = para;
                    infoMensaje.Para_CC = CC;
                    infoMensaje.Fecha = oMail.ReceivedDate;
                    infoMensaje.Texto_mensaje = oMail.TextBody;
                 
                    infoMensaje.Tiene_Adjunto = oMail.Attachments.ToList().Count() == 0 ? false : true;

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

                    infoMensaje.mail_remitente = correo;
                    infoMensaje.Eliminado = false;
                    infoMensaje.IdTipo_Mensaje = eTipoMail.Buzon_Ent;


                    infoMensaje.IdCuenta = IdCuenta;

                    foreach (var itemAdju in oMail.Attachments.ToList())
                    {
                        mail_Mensaje_Archi_Adjunto_Info infoAdju = new mail_Mensaje_Archi_Adjunto_Info();

                        string nomAdju = itemAdju.Name;

                        string extAdj = Path.GetExtension(nomAdju);
                        if (extAdj == ".pdf" || extAdj == ".xml")
                        {

                            infoAdju.extensionArchivo = extAdj;
                            infoAdju.Archivo_adjunto = itemAdju.Content;
                            infoAdju.descripcion_archi = itemAdju.Name;

                            infoMensaje.list_Archivos_Adjuntos.Add(infoAdju);
                        }

                    }
                               
                    lista_Mensaje.Add(infoMensaje);
                   
                    gridControl_Correo.DataSource = lista_Mensaje;
                    //llenar grid


                    int pos = fullname.LastIndexOf(".");
                    string mainName = fullname.Substring(0, pos);
                    string htmlName = mainName + ".htm";
                    if (!File.Exists(htmlName))
                    {
                        // Este mensaje está sin leer, fijamos el estilo de fuente en negrita.
                       // item.Font = new System.Drawing.Font(item.Font, FontStyle.Bold);
                    }

                    oMail.Clear();
                }
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

        // generamos un html + carpeta de datos adjuntos para cada correo electrónico, una vez que el html es crear,
        // Próxima vez que no es necesario analizar el correo electrónico de nuevo.


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
                    catch (Exception ex)
                    {

                        oMail.Load(emlFile, false);
                        BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                        MessageBox.Show(ex.Message.ToString());
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
                        BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                        MessageBox.Show(ex.Message.ToString());
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
                    FileInfo file = new FileInfo(tempFolder);
                    file.Delete();

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
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ShowMail(string fileName)
        {
            try
            {



                //bool test2 = fileName.EndsWith(".");

                //bool test1 = fileName.StartsWith(".");


                int pos = fileName.LastIndexOf(".");
                string mainName = fileName.Substring(0, pos);
                string htmlName = mainName + ".htm";

                string tempFolder = mainName;
                if (!File.Exists(htmlName))
                {	// no hemos generar el html de este correo electrónico, generar ahora.
                    _GenerateHtmlForEmail(htmlName, fileName, tempFolder);
                }

                object empty = System.Reflection.Missing.Value;
                webMail.Navigate(htmlName);
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void mostrar_mensajes(eTipoMail TipoMail, string direccionCorreo)
        {
            try
            {
                string msg = "", CadenaBusqueda = "";

                //listaMensajes = new BindingList<mail_Mensaje_Info>(Bus_Mensaje.consultar(TipoMail, direccionCorreo, ref msg));

                lista_Mensaje = new List<mail_Mensaje_Info>(Bus_Mensaje.consultar(TipoMail, direccionCorreo,1,50, CadenaBusqueda, ref msg));

                //  cargar_Correo_Entrada();

                foreach (var item in lista_Mensaje)
                {
                    item.Checked = true;

                    var item2 = lista_Adjunto.FindAll(q => q.IdMensaje == item.IdMensaje);

                    if (item2.Count() != 0)
                    {

                        //MessageBox.Show("" +item.IdMensaje);
                        foreach (var item3 in item2)
                        {
                            if (item3.extensionArchivo == ".pdf")
                            {
                                item.MosTrar_icono_Ride = true;
                            }
                            if (item3.extensionArchivo == ".xml")
                            {
                                item.MosTrar_icono_xml = true;
                            }

                        }
                    }

                }
                gridControl_Correo.DataSource = lista_Mensaje;

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                MessageBox.Show(ex.Message.ToString());

            }

        }

          
        private void Frm_Correo_POP_IMAP_Load(object sender, EventArgs e)        
        {
            try
            {
               // correo = "ryanza@it-corp.com";
              //  correo = "hayauca@it-corp.com";
                correo = "malbarracin@beralsa.com";

                string mensajError = "";
                mail_Cuentas_Correo_Bus bus_correo = new mail_Cuentas_Correo_Bus();
                List<mail_Cuentas_Correo_Info> lista_Correo = new List<mail_Cuentas_Correo_Info>();

                lista_Correo = bus_correo.consultar(ref mensajError);

                var itemCuenta = lista_Correo.FirstOrDefault(q => q.direccion_correo == correo);

                if(itemCuenta !=null)
                IdCuenta = itemCuenta.IdCuenta;
                
                object empty = System.Reflection.Missing.Value;
                webMail.Navigate("about:blank");
                              
                // carga combos
                
                lstProtocol.Items.Add("POP3");
                lstProtocol.Items.Add("IMAP4");
                lstProtocol.Items.Add("Exchange Web Service - 2007/2010");
                lstProtocol.Items.Add("Exchange WebDAV - Exchange 2000/2003");

                lstProtocol.SelectedIndex = 0;

                lstAuthType.Items.Add("USER/LOGIN");
                lstAuthType.Items.Add("APOP");
                lstAuthType.Items.Add("NTLM");
                lstAuthType.SelectedIndex = 0;


                string RutaFile = Path.GetTempPath();
                int pos = RutaFile.LastIndexOf('\\');
                if (pos != -1)
                    RutaFile = RutaFile.Substring(0, pos);
                                         
                m_curpath = RutaFile;
                              
                 // LoadMails();


                //consulta de la base de datos


                ////Consulta archivos adjuntos              
                string mensajeError = "";
                lista_Adjunto = bus_Adjunto.Lista_ArchivoAdjunto(ref mensajeError);

                mostrar_mensajes(eTipoMail.Buzon_Ent, correo);
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                MessageBox.Show(ex.Message.ToString()); 
                
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {

                string server, user, password;
                //server = textServer.Text.Trim();
                //user = textUser.Text.Trim();
                //password = textPassword.Text.Trim();

                server = "mail.it-corp.com";
                user = "hayauca";
                password = "msabhaac20071976";

                //user = "hayauca";
                //password = "msabhaac20071976";

                if (server.Length == 0 || user.Length == 0 || password.Length == 0)
                {
                    MessageBox.Show("Por favor ingrese servidor, usuario y contraseña.");
                    return;
                }

                btnStart.Enabled = false;
                btnCancel.Enabled = true;

                ServerAuthType authType = ServerAuthType.AuthLogin;
                if (lstAuthType.SelectedIndex == 1)
                    authType = ServerAuthType.AuthCRAM5;
                else if (lstAuthType.SelectedIndex == 2)
                    authType = ServerAuthType.AuthNTLM;

                ServerProtocol protocol = (ServerProtocol)lstProtocol.SelectedIndex;

                MailServer oServer = new MailServer(server, user, password,
                    chkSSL.Checked, authType, protocol);

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

                bool bLeaveCopy = chkLeaveCopy.Checked;

                // UIDL es el identificador de cada correo electrónico de POP3 / IMAP4 / servidor de Exchange, para evitar recuperar
                // El mismo correo electrónico desde el servidor más de una vez, que registra el email UIDL recuperada cada vez
                // Si elimina el correo electrónico desde el servidor cada vez y no dejar una copia del correo electrónico en
                // El servidor, por favor, elimine toda la función sobre uidl.
                // UIDLManager envuelve la función de escribir / leer el registro uidl desde un archivo de texto.

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
                    lblStatus.Text = "Connecting ...";
                    oClient.Connect(oServer);
                    MailInfo[] infos = oClient.GetMailInfos();
                    lblStatus.Text = String.Format("Total {0} email(s)", infos.Length);

                    // Eliminar el uidl local que no se existía en el servidor.
                    oUIDLManager.SyncUIDL(oServer, infos);
                    oUIDLManager.Update();

                    int count = infos.Length;

                    if (count > 0)
                        lista_Mensaje = new List<mail_Mensaje_Info>();

                    for (int i = 0; i < count; i++)
                    {


                        MailInfo info = infos[i];

                        //verificar en base
                        if (Bus_Mensaje.Verifica_codMensajeId(info.UIDL) == false)
                        {

                            //}
                            //if (oUIDLManager.FindUIDL(oServer, info.UIDL) != null /*&& "si esta en base"|| oUIDLManager.FindUIDL(oServer, info.UIDL) == null && "si esta en base"*/ )
                            //{
                            //    // este correo electrónico se ha descargado antes.
                            //    continue;
                            //}

                            lblStatus.Text = String.Format("Retrieving {0}/{1}...", info.Index, count);

                            Mail oMail = oClient.GetMail(info);
                            System.DateTime d = System.DateTime.Now;
                            System.Globalization.CultureInfo cur = new System.Globalization.CultureInfo("en-US");
                            string sdate = d.ToString("yyyyMMddHHmmss", cur);
                            string fileName = String.Format("{0}\\{1}{2}{3}.eml", mailFolder, sdate, d.Millisecond.ToString("d3"), i);
                            oMail.SaveAs(fileName, true);

                            //llenar grid

                            //int conta = oMail.Headers.Count;
                            //string MessageID = "";
                            //for (int y = 0; y < conta; y++)
                            //{

                            //        string valida = "Message-ID";
                            //        string extrae = oMail.Headers[y].ToString().Substring(0, 10);

                            //        string result = "";
                            //        if (extrae == valida)
                            //        {
                            //            MessageID = oMail.Headers[y].ToString();
                            //            break;  
                            //        }

                            //       // break;                                                                          
                            //}

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

                            infoMensaje.mail_remitente = correo;
                            infoMensaje.Eliminado = false;
                            infoMensaje.IdTipo_Mensaje = eTipoMail.Buzon_Ent;


                            infoMensaje.IdCuenta = IdCuenta;

                            foreach (var itemAdju in oMail.Attachments)
                            {
                                mail_Mensaje_Archi_Adjunto_Info infoAdju = new mail_Mensaje_Archi_Adjunto_Info();

                                string nomAdju = itemAdju.Name;

                                string extAdj = Path.GetExtension(nomAdju);
                                if (extAdj == ".pdf" || extAdj == ".xml")
                                {

                                    infoAdju.extensionArchivo = extAdj;
                                    infoAdju.Archivo_adjunto = itemAdju.Content;
                                    infoAdju.descripcion_archi = itemAdju.Name;

                                    infoMensaje.list_Archivos_Adjuntos.Add(infoAdju);
                                }

                            }

                            infoMensaje.Archivo_correo = System.IO.File.ReadAllBytes(infoMensaje.fileName);

                            lista_Mensaje.Add(infoMensaje);


                            gridControl_Correo.DataSource = lista_Mensaje;

                            gridControl_Correo.RefreshDataSource();

                            oMail.Clear();

                            // si lblTotal.Text = String.Format("Total {0} email(s)", lstMail.Items.Count);

                            if (bLeaveCopy)
                            {
                                // añadir el uidl correo electrónico a uidl archivo para evitar recuperamos la próxima vez.
                                oUIDLManager.AddUIDL(oServer, info.UIDL, fileName);
                            }

                        }


                    }

                    if (!bLeaveCopy)
                    {
                        lblStatus.Text = "Deleting ...";
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

                    if (lista_Mensaje.Count() == 0)
                    {
                        MessageBox.Show("No existen Correos de Entrada Nuevos");
                        return;
                    }

                }
                catch (Exception ex)
                {
                    BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                    MessageBox.Show(ex.Message.ToString());
                }

                // Actualizar la lista uidl de archivo uidl local y luego podemos cargar la próxima vez.
                oUIDLManager.Update();

                lblStatus.Text = "Completed";
                pgBar.Maximum = 100;
                pgBar.Minimum = 0;
                pgBar.Value = 0;
                btnStart.Enabled = true;
                btnCancel.Enabled = false;
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                MessageBox.Show(ex.Message.ToString());
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_bcancel = true;
        }

        private void gridControl_Correo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                infoMensaje = new mail_Mensaje_Info();                             
                infoMensaje = (mail_Mensaje_Info)gridView_Correo.GetFocusedRow();

                if (infoMensaje.fileName == null)
                {
                    string RutaFile = Path.GetTempPath();
                    int pos = RutaFile.LastIndexOf('\\');
                    if (pos != -1)
                        RutaFile = RutaFile.Substring(0, pos);

                    m_curpath = RutaFile;

                    string uidlfile = String.Format("{0}\\{1}", m_curpath, infoMensaje.codMensajeId);

                    System.IO.File.WriteAllBytes(uidlfile, infoMensaje.Archivo_correo);

                    ShowMail(uidlfile);
                }
                else 
                {
                    ShowMail(infoMensaje.fileName);
                
                }

               // ShowMail(infoMensaje.fileName);
                                       
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                MessageBox.Show(ex.Message.ToString());             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                                             
               // byte[] bytes = System.IO.File.ReadAllBytes(@"D:\Efirm_Local\Efirm\bin\Debug\inbox\201502111630127640.eml");
                //// munge bytes with whatever pdf software you want
                //// ...
                //// and save back
                //System.IO.File.WriteAllBytes(@"c:\\201502111630127640.eml", bytes);
                              
                // grabar en mail_Mensaje
                string mensajeError = "";

                if (lista_Mensaje.Count() != 0)
                {
                    foreach (var item in lista_Mensaje)
                    {
                        if (Bus_Mensaje.GrabarMensajeDB(item, ref  mensajeError))
                        {

                        }
                    }

                    MessageBox.Show("Correos Grabados Exitosamente");
                }                            
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                MessageBox.Show(ex.Message.ToString());
              
            }
        }
    }
}
