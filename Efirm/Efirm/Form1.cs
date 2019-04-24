using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using FirmElect.Reports;
using FirmElect.Info;
using FirmElect.Bus;
using FirmElect.Info.Log_Exception;
using FirmElect.Info.Properties;
using FirmElect.Info.class_sri.Factura_V2;



//correo
using OpenPop.Pop3;
using System.IO.Compression;
using OpenPop.Mime;
using System.IO;


//otro
using a = System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Collections;
using System.Net.Sockets;
using System.Diagnostics;


namespace Efirm
{
    public partial class Form1 : Form
    {
        readonly Pop3Client pop3Client;
        private readonly Dictionary<int, OpenPop.Mime.Message> messages = new Dictionary<int, OpenPop.Mime.Message>();
        
        public Form1()
        {
            InitializeComponent();
            pop3Client = new Pop3Client();
        }


        List<mail_Mensaje_Info> listaConsul = new List<mail_Mensaje_Info>();
        mail_Mensaje_Bus bus_mail = new mail_Mensaje_Bus();

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void uC_Horario_Actividades1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
         //si   XtraReport Reporte = new XtraReport();
            string msg = "";
         //si   Rpt_Ride_bus Factura_Bus = new Rpt_Ride_bus();

            //Reporte=Factura_Bus.Optener_reporte(12, "001-001-000022550", eTipoComprobante.Factura, "VALI_&_FIRM_&_REC", ref msg);//FAct OMD
           // Reporte = Factura_Bus.Optener_reporte(11, "002-002-000001103", eTipoComprobante.NotaCredito, "VALI", ref msg); //FAct Imporpoint

            ////Reporte = Factura_Bus.Optener_reporte(11, "003-002-100000478", eTipoComprobante.NotaCredito, "VALI", ref msg); //FAct Imporpoint
            ////Reporte.ShowPreview();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {



            try
            {

               // this.WindowState = FormWindowState.Minimized;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Notify Icon Test Application";
                notifyIcon1.BalloonTipText = "You have just minimized the application." +
                                            Environment.NewLine +
                                            "Right-click on the icon for more options.";

                notifyIcon1.ShowBalloonTip(5000);

            //    string mensajeError = "";

            //    if (listaMail1.Count != 0)
            //    {

            //        foreach (var item in listaMail1)
            //        {
            //            mail_Mensaje_Info info = new mail_Mensaje_Info();

            //            //Para
            //            conta = 0;
            //            conta = item.To.ToList().Count();
            //            sec = 0;
            //            foreach (var item2 in item.To)
            //            {
            //                sec = sec + 1;
            //                if (sec != conta)
            //                {
            //                    para += item2 + "; ";
            //                }
            //                else
            //                {
            //                    para += item2;
            //                }
            //            }

            //            //con copia               
            //            conta = 0;
            //            conta = item.conCopia.ToList().Count();
            //            sec = 0;
            //            foreach (var itemCopia in item.conCopia)
            //            {
            //                sec = sec + 1;
            //                if (sec != conta)
            //                {
            //                    CC += itemCopia + "; ";
            //                }
            //                else
            //                {
            //                    CC += itemCopia;
            //                }
            //            }

            //            info.Para = para;
            //            info.Para_CC = CC;
            //            info.Fecha = item.DateSent;
            //            //info.Para = item.Para; 
            //            //  info.Para_CC = item.CC;
            //            info.Asunto = item.Subject;
            //            info.Asunto_texto_mostrado = item.Subject;

            //            info.Tiene_Adjunto = item.Attachments.Count() == 0 ? false : true;

            //            if (item.Prioridad == "Normal")
            //            {
            //                info.Prioridad = 0;
            //            }
            //            if (item.Prioridad == "Alta")
            //            {
            //                info.Prioridad = 1;
            //            }
            //            if (item.Prioridad == "Baja")
            //            {
            //                info.Prioridad = -1;
            //            }

            //            info.Leido = false;
            //            info.Respondido = false;
            //            info.No_Leido = false;
            //            info.Texto_mensaje = item.Texto_mensaje;
            //           // info.mail_remitente = item.From;
            //            info.mail_remitente = dir_correo;                       
            //            info.Eliminado = false;
            //            info.IdTipo_Mensaje = eTipoMail.Buzon_Ent;
            //            info.codMensajeId = item.MessageId;
            //            // info.InfoContribuyente= null;
            //            //info.InfoContribuyente.Mail = item.From;

            //            listaMail.Add(info);
            //        }

            //        foreach (var item in listaMail)
            //        {
            //            if (bus_mail.GrabarMensajeDB(item, ref  mensajeError))
            //            {
            //                MessageBox.Show("Grabado con exito");
            //            }
            //        }

            //    }
            //    else
            //    {
            //        MessageBox.Show("No existen Correos de Entrada en el Grid");                  
            //    }
            
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());   
            }         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                WS_Efirm.Ws_Comprobante clien = new WS_Efirm.Ws_Comprobante();
                string mensa = "";
                foreach (var item in clien.Lista_TipoComprobantes(ref mensa))
                {
                    MessageBox.Show(item.Descripcion);
                }
               
                
                //using (ServiceReference1.Ws_ComprobanteClient cliente=new ServiceReference1.Ws_ComprobanteClient())
                //{
                //    string mensa = "";
                //    foreach (var item in cliente.Lista_TipoComprobantes(ref mensa))
                //    {
                //        MessageBox.Show(item.Descripcion);
                //    }
                
                
                //}
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void uC_Impr_descar_cbtes_Lote1_Load(object sender, EventArgs e)
        {

        }
    
        public class Correos
        {
            public String Detalle { get; set; }
            public OpenPop.Mime.Message Correo { get; set; }
            public string Remitente { get; set; }
            public string MessageId { get; set; }
            public DateTime Fecha { get; set; }
            public string Para { get; set; }
            public string Texto_Mensaje { get; set; }
            public string Prioridad { get; set; }
            public string From { get; set; }
            public string CC { get; set; }
        }

        public class Adjunto
        {
            public string Nombre { get; set; }
            public MessagePart Adjunto_ { get; set; }

        }

      
        List<Correos> Datasource = new List<Correos>();
        string para = "";
        string valida = "";
        string CC = "";
       
        MessagePart selectedMessagePart;
        List<mail_Mensaje_Info> listaMail = new List<mail_Mensaje_Info>();

        int conta = 0;
        int sec = 0;

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            string IdMsg_Error = "";
            
            try
            {                          
                messages.Clear();
               
                if (pop3Client.Connected)
                    pop3Client.Disconnect();
                pop3Client.Connect("mail.it-corp.com", 995, true);
                  pop3Client.Authenticate("ryanza", "RYitcorp2014");
               // pop3Client.Authenticate("hayauca", "msabhaac20071976");
                int count = pop3Client.GetMessageCount();

                for (int i = count; i >= 1; i -= 1)
                {
                    Application.DoEvents();                   
                    //OpenPop.Mime.Message message = pop3Client.GetMessage(i);
                    //messages.Add(i, message);
                  
                    string MessageId = pop3Client.GetMessageHeaders(i).MessageId;


                   // OpenPop.Mime.Header.MessageHeader messageHeader = pop3Client.GetMessageHeaders(i);
                    var itemIdMensaje = listaConsul.FirstOrDefault(q => q.codMensajeId == MessageId);


                    //IdMsg_Error = MessageId;
                    //if (/*IdMsg_Error == "20150202155438.645851D44D6D@mail2.it-corp.com" || */IdMsg_Error == "1032107435.62561.1416524474220.JavaMail.zimbra@it-corp.com")
                    //{
                    //    IdMsg_Error = "";
                    //}

                    if (itemIdMensaje == null)
                    {

                        OpenPop.Mime.Message message = pop3Client.GetMessage(i);
                        messages.Add(i, message);


                        para = "";

                        conta = 0;
                        conta = message.Headers.To.ToList().Count();
                        sec = 0;
                        foreach (var item in message.Headers.To.ToList())
                        {
                            sec = sec + 1;
                            if (sec != conta)
                            {
                                para += item.Address + "; ";
                            }
                            else
                            {
                                para += item.Address;
                            }
                        }


                        conta = 0;
                        conta = message.Headers.Cc.ToList().Count();
                        sec = 0;
                        foreach (var item in message.Headers.Cc.ToList())
                        {
                            //CC = item.Raw.ToString();
                            sec = sec + 1;
                            if (sec != conta)
                            {
                                CC += item.Address + "; ";
                            }
                            else
                            {
                                CC += item.Address;
                            }
                        }

                        selectedMessagePart = message.FindFirstPlainTextVersion();

                        if (selectedMessagePart != null)
                        {
                            if (selectedMessagePart.IsText)
                            {
                                valida = selectedMessagePart.GetBodyAsText();
                            }
                        }

                        Datasource.Add(new Correos()
                        {
                            Correo = message,

                            Detalle = message.Headers.Subject,
                            Remitente = message.Headers.From.DisplayName,
                            MessageId = message.Headers.MessageId,
                            Fecha = message.Headers.DateSent,
                            Para = para,
                            Texto_Mensaje = valida,
                            Prioridad =Convert.ToString( message.Headers.Importance),
                            From = Convert.ToString(message.Headers.From),
                            CC = CC,
                        }
                        );


                        foreach (var item in Datasource)
                        {

                            List<MessagePart> attachment = item.Correo.FindAllAttachments();
                            //List<Adjunto> DatasourceAdjunto = new List<Adjunto>();

                            //foreach (MessagePart item2 in attachment)
                            //{
                            //    DatasourceAdjunto.Add(new Adjunto() { Nombre = item2.FileName, Adjunto_ = item2 });
                            //}
                            
                            mail_Mensaje_Info info = new mail_Mensaje_Info();

                            info.Fecha = item.Fecha;
                            info.Para = item.Para;
                            info.Asunto = item.Detalle;
                            info.Asunto_texto_mostrado = item.Detalle;

                            info.Tiene_Adjunto = attachment.Count() == 0 ? false : true;
                            
                           // info.Tiene_Adjunto = Convert.ToBoolean(0); //validar false

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

                            //info.Prioridad = 0; //validar
                            info.Leido =  false;  //*Convert.ToBoolean(0);
                            info.Respondido = false;  //Convert.ToBoolean(0);
                            info.No_Leido = false;  //Convert.ToBoolean(0);
                            info.Texto_mensaje = item.Texto_Mensaje;
                            info.mail_remitente = item.From;
                            info.Para_CC = item.CC;
                            info.Eliminado = false;  //Convert.ToBoolean(0);
                            info.IdTipo_Mensaje = eTipoMail.Buzon_Ent;
                            info.codMensajeId = item.MessageId;
                            // info.InfoContribuyente= null;
                            info.InfoContribuyente.Mail = item.From;

                            listaMail.Add(info);
                        }
                        // gridControl1.DataSource = Datasource;
                        // gridControl1.DataSource = listaMail;
                    }
                    
                }

                gridControl_Buzon_Ent.DataSource = listaMail;

            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.ToString() + IdMsg_Error);    
            }
        }

        mail_Mensaje_Bus Bus_Mensaje = new mail_Mensaje_Bus();
        BindingList<mail_Mensaje_Info> listaMensajes = new BindingList<mail_Mensaje_Info>();
        mail_Mensaje_Archi_Adjunto_Bus bus_Adjunto = new mail_Mensaje_Archi_Adjunto_Bus();
        List<mail_Mensaje_Archi_Adjunto_Info> lista_Adjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();

        public void mostrar_mensajes(eTipoMail TipoMail, string direccionCorreo)
        {
            try
            {
                string msg = "", CadenaBusqueda = "";
               

               // toolStripLabelCorreo.Text = direc_correo = direccionCorreo;
                listaMensajes = new BindingList<mail_Mensaje_Info>(Bus_Mensaje.consultar(TipoMail, direccionCorreo,1, 50,CadenaBusqueda, ref msg));


                //  cargar_Correo_Entrada();

                foreach (var item in listaMensajes)
                {
                    item.Checked = true;

                    var item2 = lista_Adjunto.FirstOrDefault(q => q.IdMensaje == item.IdMensaje);
                    if (item2 != null)
                    {
                        if (item2.extensionArchivo == ".pdf")
                        {
                            item.MosTrar_icono_Ride = true;
                        }
                        if (item2.extensionArchivo == ".xml")
                        {
                            item.MosTrar_icono_xml = true;
                        }
                    }

                }
                gridControl2.DataSource = listaMensajes;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                
                
            }
            
          
        }

        [Serializable]
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

        [Serializable]
        public class Attachment
        {
            public string FileName { get; set; }
            public string ContentType { get; set; }
            public byte[] Content { get; set; }
        }

        //protected List<Email> Emails
        //{
        //    get { return (List<Email>)ViewState["Emails"]; }
        //    set { ViewState["Emails"] = value; }
        //}

        List<Email> listaMail1 = new List<Email>();

        List<string> listPara = new List<string>();
        List<string> list_concopia = new List<string>();

        string ServiCorreoEnt = "";
        int por_Ent = 0;
        string dir_correo = "";
        string password = "";
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
                tb_Comprobante_Info InfoCbteT = new tb_Comprobante_Info();
                tb_Comprobante_Bus BusCbteT = new tb_Comprobante_Bus();

                XtraReport Reporte = new XtraReport();
                string msj = "";

                Rpt_Ride_bus Rpt_Ride_Bus = new Rpt_Ride_bus(busEmpresa.GetEmpresas(ref msj));

                InfoCbteT = BusCbteT.consultar(1, "FA-001-002-000004078", "01", "VALI", ref msj);

                Reporte = Rpt_Ride_Bus.Optener_reporte(InfoCbteT, ref msj); //FAct Imporpoint
                Reporte.ShowPreview();

                //object ds = Reporte.DataSource;

                //xRpt_Ride_Factura_Gen_Forma_Pago reporte = new xRpt_Ride_Factura_Gen_Forma_Pago();
                //reporte.DataSource = ds;
                //reporte.ShowPreview();

                ////XtraReport1 repor = new XtraReport1();
                ////repor.DataSource = ds;
                ////repor.ShowPreview();





            }
            catch (Exception ex)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, ex.Message);
                throw new DalException(string.Format(Resource_Mensajes_Error.RetrieveError, "PricingRule", ex.Message), ex) { EntityType = typeof(Form1) };

            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                mail_Mensaje_Info InfoMail = new mail_Mensaje_Info();
                
                
                if (e.Column.Name == "colMosTrar_icono_Ride")
                {
                    //MessageBox.Show("RIDE");
                    InfoMail = (mail_Mensaje_Info)gridView2.GetFocusedRow();

                    string RutaFile = Path.GetTempPath();
                  
                    var item2 = lista_Adjunto.FirstOrDefault(q => q.IdMensaje == InfoMail.IdMensaje);
                    if (item2 != null)
                    {
                        if (item2.extensionArchivo == ".pdf")
                        {
                            RutaFile = RutaFile + "\\" + item2.descripcion_archi ;                         
                         //  System.IO.File.WriteAllBytes("myfile.pdf", item2.Archivo_adjunto);
                            System.IO.File.WriteAllBytes(RutaFile, item2.Archivo_adjunto);

                          // RutaFile = RutaFile + "\\" "myfile.pdf";
                          // File.WriteAllBytes(@"C:\testpdf.pdf", myArrayOfBytes);
                                           
                            System.Diagnostics.Process proc = new System.Diagnostics.Process();
                          // proc.StartInfo.FileName = "C:\\FA-001-001-000023456.pdf";
                            proc.StartInfo.FileName = RutaFile;
                            proc.Start();
                            proc.Close();
                        }                     
                    }                                                                                               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         


        }
       

      

    }
}
