using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailEfirm.Forms;

using System.Linq;
using FirmElect.Info;
using FirmElect.Bus;
//correo
using OpenPop.Pop3;
using System.IO.Compression;
using OpenPop.Mime;
using System.IO;

using System.Xml;
using System.Xml.Serialization;

namespace Efirm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

      
        mail_Mensaje_Bus Bus_Mensaje = new mail_Mensaje_Bus();
        BindingList<mail_Mensaje_Info> listaMensajes = new BindingList<mail_Mensaje_Info>();

        mail_Mensaje_Archi_Adjunto_Bus bus_Adjunto = new mail_Mensaje_Archi_Adjunto_Bus();
        List<mail_Mensaje_Archi_Adjunto_Info> lista_Adjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();

        public class Email
        {
            public Email()
            {
                this.Attachments = new List<Attachment>();

                To = new List<string>();
                conCopia = new List<string>();
            }
            public int MessageNumber { get; set; }
            // public string From { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
            public DateTime DateSent { get; set; }
            public List<Attachment> Attachments { get; set; }

            public string MessageId { get; set; }
            public string Para { get; set; }
            public string Texto_mensaje { get; set; }
            public string Prioridad { get; set; }
            public string CC { get; set; }

            public List<string> To { get; set; }
            public List<string> conCopia { get; set; }
        }

        public class Attachment
        {
            public string FileName { get; set; }
            public string ContentType { get; set; }
            public byte[] Content { get; set; }
        }

        string para = "";
        string valida = "";
        string CC = "";
        int conta = 0;
        int sec = 0;

        string ServiCorreoEnt = "";
        int por_Ent = 0;
        string dir_correo = "";
        string password = "";

        MessagePart selectedMessagePart;
        List<string> listPara = new List<string>();
        List<string> list_concopia = new List<string>();

        List<Email> listaMail = new List<Email>();

        string IdCuenta = "";

        void cargar_Correo_Entrada()
        {
            
            try
            {
                try
                {
                    string mensajError = "";
                    mail_Cuentas_Correo_Bus bus_correo = new mail_Cuentas_Correo_Bus();
                    List<mail_Cuentas_Correo_Info> lista_Correo = new List<mail_Cuentas_Correo_Info>();

                    lista_Correo = bus_correo.consultar(ref mensajError);

                    var itemCuenta = lista_Correo.FirstOrDefault(q => q.direccion_correo == correo);

                    IdCuenta = itemCuenta.IdCuenta;

                    Pop3Client pop3Client;

                    pop3Client = new Pop3Client();
                    pop3Client.Connect(itemCuenta.ServidorCorreoEntrante, itemCuenta.port_entrada, true);
                    pop3Client.Authenticate(itemCuenta.direccion_correo, itemCuenta.Password);


                    int count = pop3Client.GetMessageCount();
                    // int counter = 0;
                    for (int i = count; i >= 1; i -= 1)
                    {
                        string MessageId = pop3Client.GetMessageHeaders(i).MessageId;

                        if (Bus_Mensaje.Verifica_codMensajeId(MessageId) == false)
                        {

                            var itemIdMensaje = listaMensajes.FirstOrDefault(q => q.codMensajeId == MessageId);

                            if (itemIdMensaje == null)
                            {
                                OpenPop.Mime.Message message = pop3Client.GetMessage(i);

                                //Para
                                listPara = new List<string>();
                                foreach (var item in message.Headers.To.ToList())
                                {
                                    listPara.Add(item.Address);
                                }

                                //con copia                     
                                list_concopia = new List<string>();
                                foreach (var item in message.Headers.Cc.ToList())
                                {
                                    list_concopia.Add(item.Address);
                                }

                                //texto mensaje
                                selectedMessagePart = message.FindFirstPlainTextVersion();

                                if (selectedMessagePart != null)
                                {
                                    if (selectedMessagePart.IsText)
                                    {
                                        valida = selectedMessagePart.GetBodyAsText();
                                    }
                                }

                                Email email = new Email()
                                {
                                    MessageNumber = i,
                                    Subject = message.Headers.Subject,
                                    DateSent = message.Headers.DateSent,
                                    Prioridad = Convert.ToString(message.Headers.Importance),
                                    //  From = string.Format("<a href = 'mailto:{1}'>{0}</a>", message.Headers.From.DisplayName, message.Headers.From.Address),
                                    //  From =  message.Headers.From.DisplayName,
                                    MessageId = message.Headers.MessageId,
                                    Para = para,
                                    Texto_mensaje = valida,
                                    CC = CC,
                                    To = listPara,
                                    conCopia = list_concopia
                                };

                                List<MessagePart> attachments = message.FindAllAttachments();

                                foreach (MessagePart attachment in attachments)
                                {
                                    email.Attachments.Add(new Attachment
                                    {
                                        FileName = attachment.FileName,
                                        ContentType = attachment.ContentType.MediaType,
                                        Content = attachment.Body
                                    });
                                }

                                listaMail.Add(email);
                            }
                        }

                    }

                    if (listaMail.Count() == 0)
                    {
                        MessageBox.Show("No existen Correos de Entrada Nuevos");
                        return;
                    }
                    // gridControl2.DataSource = listaMail1;               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void mostrar_mensajes(eTipoMail TipoMail, string direccionCorreo)
        {
            try
            {
                string msg = "", CadenaBusqueda = "";
              
                listaMensajes = new BindingList<mail_Mensaje_Info>(Bus_Mensaje.consultar(TipoMail, direccionCorreo,1, 50, CadenaBusqueda, ref msg));

                //  cargar_Correo_Entrada();

                foreach (var item in listaMensajes)
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
                gridControl_Buzon_Entrada.DataSource = listaMensajes;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        string correo = "";
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                //correo = "ryanza@it-corp.com";
                correo = "recepcionnaturisa@naturisa.com.ec";
             
                //Consulta archivos adjuntos              
                string mensajeError = "";
                lista_Adjunto = bus_Adjunto.Lista_ArchivoAdjunto(ref mensajeError);
                
                mostrar_mensajes(eTipoMail.Buzon_Ent,correo);
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void gridView_Buzon_Entrada_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                mail_Mensaje_Info InfoMail = new mail_Mensaje_Info();

                if (e.Column.Name == "colMosTrar_icono_Ride" || e.Column.Name == "colMosTrar_icono_xml")
                {
                    InfoMail = new mail_Mensaje_Info();
                    InfoMail = (mail_Mensaje_Info)gridView_Buzon_Entrada.GetFocusedRow();
                   
                  
                    List<mail_Mensaje_Archi_Adjunto_Info> lista = new List<mail_Mensaje_Archi_Adjunto_Info>();
                    lista = lista_Adjunto.FindAll(q => q.IdMensaje == InfoMail.IdMensaje);
                    
                    Frm_Carga_PDF_XML frm = new Frm_Carga_PDF_XML();
                    frm.carga(lista);
                    frm.Show();
                    
                                                                        
                    //string RutaFile = Path.GetTempPath();


                    //var item2 = lista_Adjunto.FindAll(q => q.IdMensaje == InfoMail.IdMensaje);
                    //if (item2.Count() != 0)
                    //{

                    //    foreach (var item3 in item2)
                    //    {
                    //         if (item3.extensionArchivo == ".pdf")
                    //        {
                    //          // RutaFile = RutaFile + "\\" + item3.descripcion_archi;                          
                    //          // System.IO.File.WriteAllBytes(RutaFile, item3.Archivo_adjunto);
                      
                    //          //// System.Diagnostics.Process proc = new System.Diagnostics.Process();
                           
                    //          //// proc.StartInfo.FileName = RutaFile;
                    //          //// proc.Start();
                    //          ////proc.Close();
                    //       }


                    //         //guardar PDF
                    //         Stream myStream;
                    //         SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                       

                    //         saveFileDialog1.Filter = "pdf files (*.pdf)|*.pdf";
                    //         saveFileDialog1.FilterIndex = 2;
                    //         saveFileDialog1.RestoreDirectory = true;
                    //         saveFileDialog1.FileName =  item3.descripcion_archi;

                    //         if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    //         {
                    //             if ((myStream = saveFileDialog1.OpenFile()) != null)
                    //             {
                    //                 //xmlOrigen.Save(myStream);
                    //                 //myStream.Close();

                    //                // System.IO.File.WriteAllBytes(RutaFile, item3.Archivo_adjunto);

                    //                 using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    //                     sw.WriteLine("Hello World!");
                    //             }
                    //         }

                    //    }

                                                                 
                    //}
                }

                //if (e.Column.Name == "colMosTrar_icono_xml")
                //{
                //    InfoMail = new mail_Mensaje_Info();
                //    InfoMail = (mail_Mensaje_Info)gridView_Buzon_Entrada.GetFocusedRow();

                //    //XmlDocument xmlOrigen = new XmlDocument();
                //    //xmlOrigen.Load(new StringReader(InfoCbteT.s_XML));

                //    string RutaFile = Path.GetTempPath();

                //    var item2 = lista_Adjunto.FindAll(q => q.IdMensaje == InfoMail.IdMensaje);
                //    if (item2.Count() != 0)
                //    {

                //        foreach (var item3 in item2)
                //        {
                //            if (item3.extensionArchivo == ".xml")
                //            {

                //                RutaFile = RutaFile + "\\" + item3.descripcion_archi;

                //                XmlDocument doc = new XmlDocument();
                //                string xml = Encoding.UTF8.GetString(item3.Archivo_adjunto);
                //                doc.LoadXml(xml);
                //                doc.Save(RutaFile);
                                
                               
                                                                            
                //                System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(RutaFile);
                //                string contenido = "";
                //                while (reader.Read())
                //                {
                //                    reader.MoveToContent();
                //                    if (reader.NodeType == System.Xml.XmlNodeType.Element)
                //                        contenido += "<" + reader.Name + ">\n";
                //                    if (reader.NodeType == System.Xml.XmlNodeType.Text)
                //                        contenido += reader.Value + "\n";
                //                }

                //                if (contenido != "")
                //                {

                //                    frmMensaje frmsg = new frmMensaje();
                //                    frmsg.richTextBoxMensaje.Text = contenido;
                //                    frmsg.WindowState = FormWindowState.Maximized;
                //                    frmsg.ShowDialog();
                //                }
                //                //  Console.Write(contents);

                //              //  MessageBox.Show("" + contents);
                                
                                
                //                //XmlReaderSettings settings = new XmlReaderSettings();

                //                //XmlElement xml = new XmlElement();

                //                //using (MemoryStream stream = new MemoryStream(item3.Archivo_adjunto))
                //                //using (XmlReader reader = XmlReader.Create(stream, settings))
                //                //{
                //                //    return xml.(reader);
                //                //}

                //                //si
                //                //MemoryStream m = new MemoryStream();
                //                //m.Write(item3.Archivo_adjunto, 0, item3.Archivo_adjunto.Length);
                //                //m.Position = 0;
                //                //XmlDocument o = new XmlDocument();
                //                //o.Load(m);
                //                //o.Save(RutaFile);
                //                //m.Close();

                //                //string xmlString = System.Text.UTF8Encoding.UTF8.GetString(item3.Archivo_adjunto);
                //                //XmlTextReader reader = new XmlTextReader(new StringReader(xmlString));
                //                //MessageBox.Show("" + xmlString);


                //                ////si
                //                //  Guardar archivo en ubicacion

                //                //XmlDocument xmlOrigen = new XmlDocument();
                //                //xmlOrigen.Load(new StringReader(xml));

                //                //Stream myStream;
                //                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                //                //saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
                //                //saveFileDialog1.FilterIndex = 2;
                //                //saveFileDialog1.RestoreDirectory = true;
                //                //saveFileDialog1.FileName =  item3.descripcion_archi;

                //                //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                //                //{
                //                //    if ((myStream = saveFileDialog1.OpenFile()) != null)
                //                //    {
                //                //        xmlOrigen.Save(myStream);
                //                //        myStream.Close();
                //                //    }
                //                //}
                //                ////si
                            
                //            }
                            
                //        }
                        
                       
                //    }                            
                //}
            }
            catch (Exception ex)
            {
                         
            }
        }

        private void btn_Bajar_Correo_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_Correo_Entrada();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                 string mensajeError="";
          
                if (listaMail.Count != 0)
                {
                   listaMensajes = new BindingList<mail_Mensaje_Info>();
                    
                    foreach (var item in listaMail)
                    {
                        mail_Mensaje_Info info = new mail_Mensaje_Info();

                        //Para
                        conta = 0;
                        conta = item.To.ToList().Count();
                        sec = 0;
                        foreach (var item2 in item.To)
                        {
                            sec = sec + 1;
                            if (sec != conta)
                            {
                                para += item2 + "; ";
                            }
                            else
                            {
                                para += item2;
                            }
                        }

                        //con copia               
                        conta = 0;
                        conta = item.conCopia.ToList().Count();
                        sec = 0;
                        foreach (var itemCopia in item.conCopia)
                        {
                            sec = sec + 1;
                            if (sec != conta)
                            {
                                CC += itemCopia + "; ";
                            }
                            else
                            {
                                CC += itemCopia;
                            }
                        }

                        info.Para = para;
                        info.Para_CC = CC;
                        info.Fecha = item.DateSent;
                        //info.Para = item.Para; 
                        //  info.Para_CC = item.CC;
                        info.Asunto = item.Subject;
                        info.Asunto_texto_mostrado = item.Subject;

                        info.Tiene_Adjunto = item.Attachments.Count() == 0 ? false : true;

                        if (item.Prioridad == "Normal")
                        {
                            info.Prioridad = 0;
                        }
                        if (item.Prioridad == "Alta")
                        {
                            info.Prioridad = 1;
                        }
                        if (item.Prioridad == "Baja")
                        {
                            info.Prioridad = -1;
                        }

                        info.Leido = false;
                        info.Respondido = false;
                        info.No_Leido = false;
                        info.Texto_mensaje = item.Texto_mensaje;
                        // info.mail_remitente = item.From;
                       // info.mail_remitente = dir_correo;
                      //  info.InfoContribuyente.Mail = correo;
                        info.mail_remitente = correo;
                        info.Eliminado = false;
                        info.IdTipo_Mensaje = eTipoMail.Buzon_Ent;
                        info.codMensajeId = item.MessageId;
                        // info.InfoContribuyente= null;
                        //info.InfoContribuyente.Mail = item.From;
                        info.IdCuenta = IdCuenta;
                  
                        foreach (var itemAdju in item.Attachments)
                        {
                            mail_Mensaje_Archi_Adjunto_Info infoAdju = new mail_Mensaje_Archi_Adjunto_Info();

                            string nomAdju = itemAdju.FileName;

                            string extAdj = Path.GetExtension(nomAdju);
                            if (extAdj == ".pdf" || extAdj == ".xml")
                            {

                                infoAdju.extensionArchivo = extAdj;
                                infoAdju.Archivo_adjunto = itemAdju.Content;
                                infoAdju.descripcion_archi = itemAdju.FileName;

                                info.list_Archivos_Adjuntos.Add(infoAdju);
                            }

                        }

                        listaMensajes.Add(info);
                    }
                }

                foreach (var item in listaMensajes)
                {
                    if (Bus_Mensaje.GrabarMensajeDB(item, ref  mensajeError))
                   {
                                
                   }               
                }

                // consultar los nuevos correos
                mostrar_mensajes(eTipoMail.Buzon_Ent,correo);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
