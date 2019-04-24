using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using DevExpress.XtraReports.UI;
using FirmElect.Reports;
using System.Xml;
using System.Text.RegularExpressions;
using EASendMail;
using System.Net;
using System.Net.Mail;

namespace FirmElect.Bus
{
   public class mail_Mensaje_Bus
   {
       #region Declaración de variables
       //string mensajeError = "";
       string RutaArchivos = "";
       eTipoEnvioMail Transaccion_q_envia;
       mail_Mensaje_Data Odata;
       mail_Mensaje_Archi_Adjunto_Bus Bus_Archivo_Adjunto = new mail_Mensaje_Archi_Adjunto_Bus();
       mail_Validar_Correo_Info mailValida = new mail_Validar_Correo_Info();
       static cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;

       mail_Mensaje_Archi_Adjunto_Data OdataArchivoAdjunto = new mail_Mensaje_Archi_Adjunto_Data();
       List<mail_Cuentas_Correo_x_Empresa_Info> listMail_x_Empresa = new List<mail_Cuentas_Correo_x_Empresa_Info>();
       mail_Cuentas_Correo_x_Empresa_Bus BusctaxEm = new mail_Cuentas_Correo_x_Empresa_Bus();
       List<mail_Cuentas_Correo_Info> listMail_cta = new List<mail_Cuentas_Correo_Info>();
       mail_Cuentas_Correo_Bus BusMail = new mail_Cuentas_Correo_Bus();
       mail_Cuentas_Correo_Info InfoCuentaCorreo = new mail_Cuentas_Correo_Info();
       mail_Mensaje_Data datamaMail = new mail_Mensaje_Data();
       mail_Mensaje_Info infoMensaje = new mail_Mensaje_Info();
       mail_Mensaje_Archi_Adjunto_Bus BusArchivo_Adjunto = new mail_Mensaje_Archi_Adjunto_Bus();
       tb_Comprobante_Info comprobante = new tb_Comprobante_Info();
       tb_Comprobante_Bus Bus_Comprobante_emisor = new tb_Comprobante_Bus();
       List<tb_Empresa_Info> listEmpr = new List<tb_Empresa_Info>();
       tb_Empresa_Bus busempresa = new tb_Empresa_Bus();
       mail_Mensaje_Archi_Adjunto_Bus Bus_MailAdjunto = new mail_Mensaje_Archi_Adjunto_Bus();


       List<mail_Cuentas_Correo_Info> listmail_Cuentas_Correo = new List<mail_Cuentas_Correo_Info>();
       List<mail_Cuentas_Correo_x_Empresa_Info> listmail_cuentas_correo_x_empresa = new List<mail_Cuentas_Correo_x_Empresa_Info>();


       List<mail_Mensaje_Archi_Adjunto_Info> ListaArchivo_Adjunto_Sin_Actualizar = new List<mail_Mensaje_Archi_Adjunto_Info>();
       List<mail_Mensaje_Archi_Adjunto_Info> ListaArchivo_Adjunto_Actualizada = new List<mail_Mensaje_Archi_Adjunto_Info>();


       #endregion

       public mail_Mensaje_Bus()
       {
           Odata = new mail_Mensaje_Data();
           string mensajeErrorOut = "";
           listMail_x_Empresa = BusctaxEm.Consulta_mail_Cuentas_Correo_x_Empresa(ref mensajeErrorOut);
           listMail_cta = BusMail.consultar(ref mensajeErrorOut);
           listEmpr = busempresa.GetEmpresas(ref mensajeErrorOut);
           RutaArchivos = Path.GetTempPath() + "\\";
           
            listmail_cuentas_correo_x_empresa=listMail_x_Empresa;
            listmail_Cuentas_Correo = listMail_cta;



       }

       public List<mail_Mensaje_Info> consultar_Mail()
       {
           try
           {
               return Odata.consultar_Mail();
           }
           catch (Exception ex)
           {
               
               return new List<mail_Mensaje_Info>();
           }
             
       }

       public List<string> consultar_CodMail_Existentes()
       {
           try
           {
               return Odata.consultar_CodMail_Existentes_x_Buzon_Entrada();
           }
           catch (Exception ex)
           {

               return new List<string>();
           }
       
       }

       public Boolean Verifica_codMensajeId(string codMensajeId)
       {
           try
           {
               return Odata.Verifica_codMensajeId(codMensajeId);
           }
           catch (Exception)
           {

               return false;
           }            
       }

       public List<mail_Mensaje_Info> consultar(eTipoMail TipoCorreo, string direccionCorreo,  int NumPag,int Registro_x_pagina, string CadenaBusqueda, ref string mensajeErrorOut)
       {
           try
           {
               return Odata.consultar(TipoCorreo, direccionCorreo, NumPag,Registro_x_pagina,CadenaBusqueda, ref mensajeErrorOut);
           }
           catch (Exception ex)
           {
               return new List<mail_Mensaje_Info>();
           }
       }

       public int ObtenerNumPag(int Registro_x_Pag, eTipoMail IdTipo_Mensaje, string mail_remitente, string CadenaBusqueda, ref string MensajeErrorOut)
       {
           try
           {
               return Odata.ObtenerNumPagina(Registro_x_Pag,IdTipo_Mensaje, mail_remitente,CadenaBusqueda, ref MensajeErrorOut);
           }
           catch (Exception)
           {
               return 1;
           }
       }

       public List<mail_Mensaje_Info> consultar_mail_sin_correo_destino_x_contribuyente(decimal IdContribuyente, ref string mensajeErrorOut)
       {
           try
           {
               return Odata.consultar_mail_sin_correo_destino_x_contribuyente(IdContribuyente, ref mensajeErrorOut);
           }
           catch (Exception ex)
           {

               return new List<mail_Mensaje_Info>();
           }
       }

       public Boolean Enviar_Correo_hold(mail_Mensaje_Info MensajeInfo, ref string mensajeErrorOut)
       {
           string SConfigCta = "";
           
           try
           {


               if (param.AUTORIZADO_ENVIO_CORREO == false)
               {
                   mensajeErrorOut = "No esta autorizado para envio de correo ";
                   return false;
               }

               string mensajeError = "";
               string tipo_conex_cifrada_smtp = "";


               //optengo el nombre de la pc para saber desde donde se envi el correo para auditar la duplicacion...
               MensajeInfo.Texto_mensaje = MensajeInfo.Texto_mensaje + " PC/Envio: " + Funciones.Get_Nombre_PC();
               /////////////
  

               mail_Cuentas_Correo_Info InfoCtaMail_Remitente = new mail_Cuentas_Correo_Info();
               InfoCtaMail_Remitente = listMail_cta.FirstOrDefault(v => v.IdCuenta == MensajeInfo.IdCuenta);


               if (listMail_x_Empresa.Count == 0)
               {
                   mensajeErrorOut = "No Existe cuentas para envio de correo configuradas en la base ";
                   return false;
               }

               if (InfoCtaMail_Remitente == null || InfoCtaMail_Remitente.IdCuenta == null)
               {
                   mensajeErrorOut = "No existe una cuenta relaciona en la base para la cuenta del mensaje verique por base";
                   return false;
               }


               if (!mailValida.email_bien_escrito(MensajeInfo.Para))
               {
                   mensajeErrorOut = "La cuenta de correo es Invalida ";
                   MensajeInfo.IdTipo_Mensaje = eTipoMail.Mail_NO_Env_x_error;
                   datamaMail.Actualizar_TipoMensaje(MensajeInfo, ref mensajeErrorOut);
                   return false;
               }

               if (MensajeInfo.IdCuenta == "" || MensajeInfo.IdCuenta == null)
               {
                   InfoCtaMail_Remitente = listMail_cta.FirstOrDefault(v => v.cta_predeterminada == true);
                   MensajeInfo.IdCuenta = InfoCtaMail_Remitente.IdCuenta;
                   MensajeInfo.mail_remitente = InfoCtaMail_Remitente.direccion_correo;

                   datamaMail.Actualizar_Datos_Cuenta(MensajeInfo, ref mensajeErrorOut);

                   mensajeErrorOut = "la Cuenta Remitente no esta establecido en el mensaje se enviara con la cuenta por default ...";
                   
               }
               SmtpMail oSmtpMail_msg = new SmtpMail("ES-C1407722592-00106-56VB4AE2B4F8TB75-641B598EBE4D439A");
               SmtpServer oSmtpServer = new SmtpServer(InfoCtaMail_Remitente.ServidorCorreoSaliente, InfoCtaMail_Remitente.Port_salida);
               EASendMail.SmtpClient oclienteSmtp = new EASendMail.SmtpClient();



               if (InfoCtaMail_Remitente.Confirmacion_de_Entrega == true || InfoCtaMail_Remitente.Confirmacion_de_Lectura==true)
               {

                   oSmtpMail_msg.DeliveryNotification = EASendMail.DeliveryNotificationOptions.OnFailure | EASendMail.DeliveryNotificationOptions.OnSuccess | EASendMail.DeliveryNotificationOptions.Delay;

                   if (InfoCtaMail_Remitente.Confirmacion_de_Lectura==true)
                   {
                       oSmtpMail_msg.Headers.Add("Read-Receipt-To", InfoCtaMail_Remitente.direccion_correo);
                   }
                   if (InfoCtaMail_Remitente.Confirmacion_de_Entrega==true)
                   {
                       oSmtpMail_msg.Headers.Add("Disposition-Notification-To", InfoCtaMail_Remitente.direccion_correo);
                   }

               }

               // si tiene archivo adjunto
               if (MensajeInfo.Tiene_Adjunto == true)
               {

                        #region codigo viejo q actualiza el campo de mail
		 
	
                   

                   #endregion


                   //optengo los archivos adjuntos
                   MensajeInfo.list_Archivos_Adjuntos = OdataArchivoAdjunto.Lista_ArchivoAdjunto_Mensaje_x_comprobante(MensajeInfo.IdMensaje, ref  mensajeErrorOut);
                   foreach (var item in MensajeInfo.list_Archivos_Adjuntos)
                   {


                           comprobante = new tb_Comprobante_Info();
                           comprobante = Bus_Comprobante_emisor.Comprobante_consulta_Id_Comprobante(item.IdEmpresa, item.IdComprobante, ref mensajeError);

                           byte[] BinarioFileAdjunto = null;




                           if (comprobante.IdComprobante != null)
                           {

                               // si la extencion ex .pdf lo creo en el tmp 
                               if (item.extensionArchivo.ToUpper() == ".PDF")
                               {
                                   XtraReport Reporte = new XtraReport();
                                   Rpt_Ride_bus Rpt_Ride_Bus = new Rpt_Ride_bus(listEmpr);
                                   Reporte = Rpt_Ride_Bus.Optener_reporte(comprobante, ref mensajeError);
                                   //pdf 
                                   FileStream FileBinary;
                                   FileBinary = new FileStream(RutaArchivos + "\\" + comprobante.IdComprobante + ".pdf", FileMode.Create);
                                   DevExpress.XtraPrinting.PdfExportOptions Optione = new DevExpress.XtraPrinting.PdfExportOptions();
                                   Reporte.ExportToPdf(FileBinary, Optione);
                                   FileBinary.Close();
                                   // lleno la clase archivo adjunto con el pdf que se creo en el tmp
                                   DirectoryInfo Directorio_Pdf_Xml = new DirectoryInfo(RutaArchivos);
                                   List<FileInfo> listaFiles = Directorio_Pdf_Xml.GetFiles(comprobante.IdComprobante + ".pdf").ToList();
                                   foreach (var itemBi in listaFiles)
                                   {

                                       FileStream file = new FileStream(RutaArchivos + itemBi.Name, FileMode.Open);
                                       BinarioFileAdjunto = new byte[file.Length];

                                       file.Read(BinarioFileAdjunto, 0, Convert.ToInt32(file.Length));
                                       file.Close();
                                   }

                               }


                           }

                           // LLENO EL BINARIO PARA EL XML
                           if (item.extensionArchivo.ToUpper() == ".XML")
                           {
                               
                               XmlDocument xmlOrigen = new XmlDocument();
                               xmlOrigen.Load(new StringReader(comprobante.s_XML));
                               BinarioFileAdjunto = Encoding.UTF8.GetBytes(xmlOrigen.OuterXml);
                           }


                           oSmtpMail_msg.AddAttachment(item.IdComprobante + item.extensionArchivo, BinarioFileAdjunto);
                   }

                       
                           
                       

                }
               

               tipo_conex_cifrada_smtp = InfoCtaMail_Remitente.tipo_Seguridad;

               if (InfoCtaMail_Remitente.tipo_Seguridad != "Ninguno")
               {
                   oSmtpServer.User = InfoCtaMail_Remitente.Usuario;
                   oSmtpServer.Password = InfoCtaMail_Remitente.Password;
               }

               
               switch (tipo_conex_cifrada_smtp)
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



               oSmtpMail_msg.To.Add(new EASendMail.MailAddress(MensajeInfo.Para));

               if (MensajeInfo.Para_CC != "" && MensajeInfo.Para_CC != null)
               {

                   string[] slistaCorreo = MensajeInfo.Para_CC.Split(';');

                   foreach (var item in slistaCorreo)
                   {
                       oSmtpMail_msg.Cc.Add(new EASendMail.MailAddress(item.Trim()));
                       
                   }
                  

               }

               oSmtpMail_msg.From =  new EASendMail.MailAddress(InfoCtaMail_Remitente.direccion_correo);
               oSmtpMail_msg.Subject = MensajeInfo.Asunto;
               oSmtpMail_msg.TextBody = MensajeInfo.Texto_mensaje;



               SConfigCta = "msg.From :" + oSmtpMail_msg.From.ToString() + "\n";
               SConfigCta = SConfigCta + " msg.To:" + oSmtpMail_msg.To.ToString() + "\n";
               SConfigCta = SConfigCta + " msg.Subject " + oSmtpMail_msg.Subject.ToString() + "\n";
               SConfigCta = SConfigCta + "msg.Body :" + oSmtpMail_msg.TextBody.ToString() + "\n";
               SConfigCta = SConfigCta + "oSmtpServer.Port:" + oSmtpServer.Port.ToString() + "\n";
               SConfigCta = SConfigCta + " oSmtpServer.User:" + oSmtpServer.User.ToString() + "\n";
               SConfigCta = SConfigCta + " oSmtpServer.Password:" + oSmtpServer.Password  + "\n";
               SConfigCta = SConfigCta + " oSmtpServer.Protocol :" + oSmtpServer.Protocol + "\n";

               if (MensajeInfo.Para == "")
               {
                   mensajeErrorOut = "No hay cuenta de correo a quien enviar ";
                   return false;
               }

               //enviando correo 

               oclienteSmtp.SendMail(oSmtpServer, oSmtpMail_msg);

               if (MensajeInfo.IdMensaje > 0)// modificar
               {
                   MensajeInfo.IdTipo_Mensaje = eTipoMail.Enviado;
                   datamaMail.Actualizar_TipoMensaje(MensajeInfo, ref mensajeErrorOut);
               }
               else
               {
                   MensajeInfo.IdTipo_Mensaje = eTipoMail.Enviado;
                   datamaMail.GrabarMensajeDB(MensajeInfo, ref mensajeErrorOut);
               }

              return true;
           }
           catch (Exception ex)
           {
               mensajeErrorOut = "catch (SmtpException ex) : " + ex.Message + " " + ex.InnerException + " datos de la cta:" + SConfigCta;
               return false;
           }

       }

       public Boolean Enviar_Correo(mail_Mensaje_Info MensajeInfo, ref string mensajeErrorOut)
       {
           string SConfigCta = "";

           try
           {
              
               if (param.AUTORIZADO_ENVIO_CORREO == false)
               {
                   mensajeErrorOut = "No esta autorizado para envio de correo ";
                   return false;
               }

               string mensajeError = "";
               string tipo_conex_cifrada_smtp = "";


               //optengo el nombre de la pc para saber desde donde se envi el correo para auditar la duplicacion...
               MensajeInfo.Texto_mensaje = MensajeInfo.Texto_mensaje + " PC/Envio: " + Funciones.Get_Nombre_PC();
               /////////////


               mail_Cuentas_Correo_Info InfoCtaMail_Remitente = new mail_Cuentas_Correo_Info();
               InfoCtaMail_Remitente = listMail_cta.FirstOrDefault(v => v.IdCuenta == MensajeInfo.IdCuenta);


               if (listMail_x_Empresa.Count == 0)
               {
                   mensajeErrorOut = "No Existe cuentas para envio de correo configuradas en la base ";
                   return false;
               }

               if (InfoCtaMail_Remitente == null || InfoCtaMail_Remitente.IdCuenta == null)
               {
                   mensajeErrorOut = "No existe una cuenta relaciona en la base para la cuenta del mensaje verique por base";
                   return false;
               }


               //if (!mailValida.email_bien_escrito(MensajeInfo.Para))
               //{
               //    mensajeErrorOut = "La cuenta de correo es Invalida ";
               //    MensajeInfo.IdTipo_Mensaje = eTipoMail.Mail_NO_Env_x_error;
               //    datamaMail.Actualizar_TipoMensaje(MensajeInfo, ref mensajeErrorOut);
               //    return false;
               //}

               if (MensajeInfo.IdCuenta == "" || MensajeInfo.IdCuenta == null)
               {
                   InfoCtaMail_Remitente = listMail_cta.FirstOrDefault(v => v.cta_predeterminada == true);
                   MensajeInfo.IdCuenta = InfoCtaMail_Remitente.IdCuenta;
                   MensajeInfo.mail_remitente = InfoCtaMail_Remitente.direccion_correo;

                   datamaMail.Actualizar_Datos_Cuenta(MensajeInfo, ref mensajeErrorOut);

                   mensajeErrorOut = "la Cuenta Remitente no esta establecido en el mensaje se enviara con la cuenta por default ...";

               }
               MailMessage oSmtpMail_msg = new MailMessage();

             
               // si tiene archivo adjunto
               if (MensajeInfo.Tiene_Adjunto == true)
               {

                   
                 

                   //optengo los archivos adjuntos
                   MensajeInfo.list_Archivos_Adjuntos = OdataArchivoAdjunto.Lista_ArchivoAdjunto_Mensaje_x_comprobante(MensajeInfo.IdMensaje, ref  mensajeErrorOut);
                   foreach (var item in MensajeInfo.list_Archivos_Adjuntos)
                   {
                       comprobante = new tb_Comprobante_Info();
                       comprobante = Bus_Comprobante_emisor.Comprobante_consulta_Id_Comprobante(item.IdEmpresa, item.IdComprobante, ref mensajeError);

                       byte[] BinarioFileAdjunto = null;
                       if (comprobante.IdComprobante != null)
                       {

                           // si la extencion ex .pdf lo creo en el tmp 
                           if (item.extensionArchivo.ToUpper() == ".PDF")
                           {
                               XtraReport Reporte = new XtraReport();
                               Rpt_Ride_bus Rpt_Ride_Bus = new Rpt_Ride_bus(listEmpr);
                               Reporte = Rpt_Ride_Bus.Optener_reporte(comprobante, ref mensajeError);
                               //pdf 
                               FileStream FileBinary;
                               FileBinary = new FileStream(RutaArchivos + "\\" + comprobante.IdComprobante + ".pdf", FileMode.Create);
                               DevExpress.XtraPrinting.PdfExportOptions Optione = new DevExpress.XtraPrinting.PdfExportOptions();
                               Reporte.ExportToPdf(FileBinary, Optione);
                               FileBinary.Close();
                               // lleno la clase archivo adjunto con el pdf que se creo en el tmp
                               DirectoryInfo Directorio_Pdf_Xml = new DirectoryInfo(RutaArchivos);
                               List<FileInfo> listaFiles = Directorio_Pdf_Xml.GetFiles(comprobante.IdComprobante + ".pdf").ToList();
                               foreach (var itemBi in listaFiles)
                               {

                                   FileStream file = new FileStream(RutaArchivos + itemBi.Name, FileMode.Open);
                                   BinarioFileAdjunto = new byte[file.Length];

                                   file.Read(BinarioFileAdjunto, 0, Convert.ToInt32(file.Length));
                                   file.Close();
                               }

                           }
                       }

                       // LLENO EL BINARIO PARA EL XML
                       if (item.extensionArchivo.ToUpper() == ".XML")
                       {

                           XmlDocument xmlOrigen = new XmlDocument();
                           xmlOrigen.Load(new StringReader(comprobante.s_XML));
                           BinarioFileAdjunto = Encoding.UTF8.GetBytes(xmlOrigen.OuterXml);
                       }


                       oSmtpMail_msg.Attachments.Add(new System.Net.Mail.Attachment(new MemoryStream(BinarioFileAdjunto), item.IdComprobante + item.extensionArchivo));
                   }
               }


               tipo_conex_cifrada_smtp = InfoCtaMail_Remitente.tipo_Seguridad;


               if (MensajeInfo.Para == "")
                   return false;
               oSmtpMail_msg.To.Add(MensajeInfo.Para);

               if (MensajeInfo.Para_CC != "" && MensajeInfo.Para_CC != null)
               {

                   string[] slistaCorreo = MensajeInfo.Para_CC.Split(';');

                   foreach (var item in slistaCorreo)
                   {
                       oSmtpMail_msg.CC.Add(item.Trim());

                   }
               }
            
               oSmtpMail_msg.From = new System.Net.Mail.MailAddress(InfoCtaMail_Remitente.direccion_correo);
               oSmtpMail_msg.Subject = MensajeInfo.Asunto;
               oSmtpMail_msg.Body = MensajeInfo.Asunto + "\n\n\n\n";
               oSmtpMail_msg.Body = oSmtpMail_msg.Body + " "+MensajeInfo.RazonSocial_Emisor;
              

               if (MensajeInfo.Para == "")
               {
                   mensajeErrorOut = "No hay cuenta de correo a quien enviar ";
                   return false;
               }

               //enviando correo 


               System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
               smtp.Host = InfoCtaMail_Remitente.ServidorCorreoSaliente;
               smtp.EnableSsl = InfoCtaMail_Remitente.precisa_conexion_cifrada;
               smtp.Port = InfoCtaMail_Remitente.Port_salida;
               smtp.Credentials = new NetworkCredential(InfoCtaMail_Remitente.direccion_correo, InfoCtaMail_Remitente.Password);
               smtp.Send(oSmtpMail_msg);


               if (MensajeInfo.IdMensaje > 0)// modificar
               {
                   MensajeInfo.IdTipo_Mensaje = eTipoMail.Enviado;
                   datamaMail.Actualizar_TipoMensaje(MensajeInfo, ref mensajeErrorOut);
               }
               //else
               //{
               //    MensajeInfo.IdTipo_Mensaje = eTipoMail.Enviado;
               //    datamaMail.GrabarMensajeDB(MensajeInfo, ref mensajeErrorOut);
               //}

               return true;
           }
           catch (Exception ex)
           {
               mensajeErrorOut = "catch (SmtpException ex) : " + ex.Message + " " + ex.InnerException + " datos de la cta:" + SConfigCta;
               return false;
           }

       }
      
       public bool Actualizar_correo_destino(mail_Mensaje_Info correoInfo, ref string mensajeError)
       {
           try
           {
               return Odata.Actualizar_correo_destino(correoInfo, ref mensajeError);
           }
           catch (Exception )
           {

               return false;
           }
       }

       public bool Actualizar_Fecha_recepcion_x_correo(decimal IdMensaje, DateTime Fecha_recepcion, ref string mensajeError)
       {
           try
           {
               return Odata.Actualizar_Fecha_recepcion_x_correo(IdMensaje,Fecha_recepcion, ref mensajeError);
           }
           catch (Exception)
           {

               return false;
           }
       }
       
       public bool Actualizar_TipoMensaje(mail_Mensaje_Info correoInfo, ref string mensajeError)
       {
           try
           {
               return Odata.Actualizar_TipoMensaje(correoInfo, ref mensajeError);
           }
           catch (Exception )
           {

               return false;
           }
       }

       public bool GrabarMensajeDB(mail_Mensaje_Info infoMensaje, ref string MensajeError)
       {
          try
           {
               Boolean Res = false;
               int secuencial = 0;


               Res = Odata.GrabarMensajeDB(infoMensaje, ref MensajeError);
              if (Res)
              {
                  mail_Mensaje_Archi_Adjunto_Bus Bus_ArchivoAdjunto = new mail_Mensaje_Archi_Adjunto_Bus();

                   foreach (var item in infoMensaje.list_Archivos_Adjuntos)
                   {
                       secuencial = secuencial + 1;
                       item.IdMensaje = infoMensaje.IdMensaje;
                       item.Secuencia = secuencial;

                     
                      
                       Bus_ArchivoAdjunto.EmailGuardarArchivoAdjunto(item, ref MensajeError);
                   }
              }

              return Res;

           }
           catch (Exception)
           {

               return false;
           }
       }

       public bool Eliminar_Mensaje(mail_Mensaje_Info correoInfo, ref string mensajeError)
       {
           try
           {
               return Odata.Eliminar_Mensaje(correoInfo, ref mensajeError);

           }
           catch (Exception )
           {
               return false;
               
           }

       }

       public decimal IdMensaje()
       {
           decimal idMensaj = 0;
           string mensajeError = "";
           try
           {
             return  idMensaj = Odata.getId(ref mensajeError);
  
           }
           catch (Exception )
           {

               return idMensaj;
           }
       }

       public Boolean enviar_correo_buzon_salida(ref List<cl_error_Info>  MensajeErrores)
       {

           try
           {

               string msg = "";
               string CadenaBusqueda = "";
               MensajeErrores = new List<cl_error_Info>();

               int cError=1;

               
               List<mail_Mensaje_Info> listMail_mensaje = new List<mail_Mensaje_Info>();
               mail_Cuentas_Correo_Bus BusCuenta = new mail_Cuentas_Correo_Bus();
               List<mail_Cuentas_Correo_Info> listCuentas = new List<mail_Cuentas_Correo_Info>();

               listCuentas = BusCuenta.consultar(ref msg);

               listMail_mensaje = new List<mail_Mensaje_Info>();

               foreach (var itemCuentas in listCuentas)
               {
                   foreach (var item in this.consultar(eTipoMail.Buzon_Sal, itemCuentas.direccion_correo,1,50,CadenaBusqueda, ref msg))
                   {
                       listMail_mensaje.Add(item);
                   }
               }

               foreach (var itemMensaje in listMail_mensaje)
               {

                   if (this.Enviar_Correo(itemMensaje, ref msg) == false)
                   {

                       MensajeErrores.Add(new cl_error_Info(cError.ToString(), msg, DateTime.Now.ToShortDateString(), "A", eTipoError.ERROR, eTipoRespuesta.ERROR));
                        cError=cError+1;
                   }

               }

               return true;

           }
           catch (Exception ex)
           {
               return false;

           }

       }

       public string optener_nombre_tipo_documento(string IdTipo)
       {
           try
           {
               string sTipoDoc = "";

               switch (IdTipo)
               {
                   case "01"://factura
                       sTipoDoc = "FACTURA";
                       break;
                   case "04"://nota cred
                       sTipoDoc = "NOTA CREDITO";
                       break;
                   case "05"://nota dev
                       sTipoDoc = "NOTA DEBITO";
                       break;
                   case "06"://guia
                       sTipoDoc = "GUIA REMISION";
                       break;
                   case "07"://retencion
                       sTipoDoc = "RETENCION";
                       break;

               }

               return sTipoDoc;
           }
           catch (Exception ex)
           {
               return "";

           }

       }
       
       public void Envio_Cbte_x_correo(tb_Comprobante_Info InfoComprobante_a_firmar, List<string> ListaCorreo, string SNombreEmpresa, string EstadoDoc_Auto_o_NoAuto, string IdAmbiente, eTipoEnvioMail STransaccion_q_envia, ref string mensajeErroOut)
       {

           try
           {
               Transaccion_q_envia = STransaccion_q_envia;
               tb_Contribuyente_Info InfoContibuyente = new tb_Contribuyente_Info();
               tb_Contribuyente_Bus BusContri = new tb_Contribuyente_Bus();
               InfoContibuyente = BusContri.GetContribuyente_Info(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.Cedula_Ruc, ref  mensajeErroOut);
               string sTipoDoc = optener_nombre_tipo_documento(InfoComprobante_a_firmar.IdTipoDocumento);
               mail_Mensaje_Bus BusMail = new mail_Mensaje_Bus();
               mail_Mensaje_Info InfoMail = new mail_Mensaje_Info();
               InfoMail.Asunto = "Ha recibido un nuevo comprobante electronico " + sTipoDoc + " Cbte#" + InfoComprobante_a_firmar.IdComprobante + " ";
               InfoMail.Asunto_texto_mostrado = "Ha recibido un nuevo comprobante electronico" + sTipoDoc + " Cbte#" + InfoComprobante_a_firmar.IdComprobante + " ";
               InfoMail.Fecha = DateTime.Now;
               InfoMail.IdTipo_Mensaje = eTipoMail.Buzon_Sal;
               mail_Mensaje_Archi_Adjunto_Info FilePdf = new mail_Mensaje_Archi_Adjunto_Info();
               FilePdf.descripcion_archi = InfoComprobante_a_firmar.IdComprobante + ".pdf";
               FilePdf.extensionArchivo = ".pdf";
               FilePdf.Archivo_adjunto = null;
               FilePdf.Archivo_adjunto_stream = null;
               FilePdf.Secuencia = 1;
               FilePdf.IdComprobante = InfoComprobante_a_firmar.IdComprobante;
               FilePdf.IdEmpresa = InfoComprobante_a_firmar.IdEmpresa;
               InfoMail.list_Archivos_Adjuntos.Add(FilePdf);
               mail_Mensaje_Archi_Adjunto_Info FileXML = new mail_Mensaje_Archi_Adjunto_Info();
               FileXML.descripcion_archi = InfoComprobante_a_firmar.IdComprobante + ".xml";
               FileXML.extensionArchivo = ".xml";
               FileXML.Archivo_adjunto = null;
               FileXML.Archivo_adjunto_stream = null;
               FileXML.IdComprobante = InfoComprobante_a_firmar.IdComprobante;
               FileXML.Secuencia = 2;
               FileXML.IdEmpresa = InfoComprobante_a_firmar.IdEmpresa;
               InfoMail.list_Archivos_Adjuntos.Add(FileXML);
               InfoMail.IdContribuyente = InfoContibuyente.IdContribuyente;
               InfoMail.Prioridad = 0;
               string CuerpoMensaje = "Estimado(a):" + InfoContibuyente.Nom_Contribuyente + "\n";
               CuerpoMensaje = CuerpoMensaje + "\n";
               CuerpoMensaje = CuerpoMensaje + " Se le informa que ha recibido un nuevo comprobante electronico";
               CuerpoMensaje = CuerpoMensaje + "\n";
               CuerpoMensaje = CuerpoMensaje + "\n";
               CuerpoMensaje = CuerpoMensaje + "Resumen";
               CuerpoMensaje = CuerpoMensaje + "\n";
               CuerpoMensaje = CuerpoMensaje + "Tipo de Documento:" + sTipoDoc + "\n";
               CuerpoMensaje = CuerpoMensaje + "No. documento:" + InfoComprobante_a_firmar.IdComprobante + "\n";
               CuerpoMensaje = CuerpoMensaje + "Fecha de Emisión:" + InfoComprobante_a_firmar.Fecha_Emi_Fact + "\n";
               CuerpoMensaje = CuerpoMensaje + "No.Autorizacion:" + InfoComprobante_a_firmar.Numero_Autorizacion + "\n";
               CuerpoMensaje = CuerpoMensaje + "Fecha Autorizacion:" + InfoComprobante_a_firmar.FechaAutorizacion + "\n";
               CuerpoMensaje = CuerpoMensaje + "\n";
               CuerpoMensaje = CuerpoMensaje + "Ahorremos papel y ayudemos al medio ambiente! ";
               CuerpoMensaje = CuerpoMensaje + "\n";
               CuerpoMensaje = CuerpoMensaje + "Atentamente,";
               CuerpoMensaje = CuerpoMensaje + "\n";
               CuerpoMensaje = CuerpoMensaje + SNombreEmpresa;
               CuerpoMensaje = CuerpoMensaje + "\n";
               CuerpoMensaje = CuerpoMensaje + " Tr-Efirm:" + STransaccion_q_envia;
               InfoMail.Texto_mensaje = CuerpoMensaje;
               InfoMail.Tiene_Adjunto = true;


               InfoMail.InfoContribuyente = InfoContibuyente;



               mail_Cuentas_Correo_x_Empresa_Info InfoCuentaCorreo_ = new mail_Cuentas_Correo_x_Empresa_Info();
               mail_Cuentas_Correo_Info InfoCta_remitente = new mail_Cuentas_Correo_Info();


            
            


               if (listmail_cuentas_correo_x_empresa != null)
               {
                   InfoCuentaCorreo_ = listmail_cuentas_correo_x_empresa.Find(v => v.IdEmpresa == InfoComprobante_a_firmar.IdEmpresa);

                   if (InfoCuentaCorreo_.IdCuenta != null)
                   {
                       InfoCta_remitente = listmail_Cuentas_Correo.Find(v => v.IdCuenta == InfoCuentaCorreo_.IdCuenta);

                       InfoMail.IdCuenta = InfoCta_remitente.IdCuenta;
                       InfoMail.mail_remitente = InfoCta_remitente.direccion_correo;

                   }
               }
               Boolean Envio_Correo_al_cliente = false;

               if (EstadoDoc_Auto_o_NoAuto == "AUTORIZADO" && IdAmbiente == "2")
               {

                   if (Bus_Archivo_Adjunto.Verificar_Correo_Existe(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante, ref mensajeErroOut))
                   {
                       if (Convert.ToString(Transaccion_q_envia) == "NUEVO")
                       return;
                   }



                   if (ListaCorreo.Count > 0)// si hay correo envio con ese correo 
                   {
                       foreach (var itemCorreo in ListaCorreo)
                       {
                           InfoMail.Para = itemCorreo;


                            if (InfoCta_remitente.enviar_copia_x_cada_mail_enviado == true)
                            {
                               InfoMail.Para_CCO = InfoCta_remitente.cta_mail_para_envio_x_cbte_enviado;
                            }

                           BusMail.GrabarMensajeDB(InfoMail, ref mensajeErroOut);
                           Envio_Correo_al_cliente = true;

                       }

                   }
                   else // envio un solo correo con el mail de contribuyente 
                   {
                       InfoMail.Para = InfoContibuyente.Mail;
                       if (InfoCta_remitente.enviar_copia_x_cada_mail_enviado == true)
                       {
                           InfoMail.Para_CCO = InfoCta_remitente.cta_mail_para_envio_x_cbte_enviado;
                       }
                       BusMail.GrabarMensajeDB(InfoMail, ref mensajeErroOut);
                       Envio_Correo_al_cliente = true;
                   }



                   //if (Envio_Correo_al_cliente == true)// solo si envio correo al cliente envio una copia
                   //{

                   //    if (InfoCta_remitente.enviar_copia_x_cada_mail_enviado == true)
                   //    {

                   //        InfoMail.Para = InfoCta_remitente.cta_mail_para_envio_x_cbte_enviado;

                   //        InfoMail.Asunto = "Copia.." + InfoMail.Asunto;
                   //        BusMail.GrabarMensajeDB(InfoMail, ref mensajeErroOut);
                   //    }
                   //}



               }

               else if (EstadoDoc_Auto_o_NoAuto == "NO AUTORIZADO")
               {
                   if (InfoCta_remitente.enviar_mail_x_cada_cbte_no_auto == true)
                   {

                       InfoMail.Para = InfoCta_remitente.cta_mail_para_envio_x_cbte_no_auto;
                       InfoMail.Asunto = "Alerta.. cbte No Autorizado.. " + InfoMail.Asunto;
                       BusMail.GrabarMensajeDB(InfoMail, ref mensajeErroOut);
                   }

               }
           }
           catch (Exception ex)
           {
           }
       }

       public byte[]  Get_File_x_Mensaje(decimal IdMensaje, string CodMensajeId, ref string mensajeErrorOut)
        {
            byte[] file = null;

            try
            {
                file =Odata.Get_File_x_Mensaje(IdMensaje, CodMensajeId, ref mensajeErrorOut);
                return file ;
            }
            catch (Exception ex)
            {
                return file;
                
            }

        }

    }
}
