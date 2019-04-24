using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Serialization;
using System.Web;
using FirmElect.Info;
using FirmElect.Data;
using System.Net;
using System.Threading;
using System.Globalization;
using DevExpress.XtraReports.UI;


namespace FirmElect.Bus
{
   public  class Firma_Bus
    {
       cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;
       public Firma_Bus(tb_Comprobante_Info _InfoComprobante_a_firmar, List<tb_Empresa_Info> _ListInfoEmpresa
       , List<tb_Tocken_Info> _listToquen, tb_Parametro_Info _InfoParametros, List<tb_tocken_x_usuario_tocken_Info> _listUsuario_de_Tocken
        ,List<mail_Cuentas_Correo_Info>  _listmail_Cuentas_Correo,List<mail_Cuentas_Correo_x_Empresa_Info> _listmail_cuentas_correo_x_empresa )
       {
           InfoComprobante_a_firmar = _InfoComprobante_a_firmar;
           ListInfoEmpresa = _ListInfoEmpresa;
           listToquen = _listToquen;
           InfoParametros = _InfoParametros;
           listUsuario_de_Tocken = _listUsuario_de_Tocken;
           listmail_Cuentas_Correo = _listmail_Cuentas_Correo;
           listmail_cuentas_correo_x_empresa = _listmail_cuentas_correo_x_empresa;

           


       }
       tb_Parametro_Info InfoParametros = new Info.tb_Parametro_Info();
       List<tb_Tocken_Info> listToquen = new List<Info.tb_Tocken_Info>();
       List<tb_tocken_x_usuario_tocken_Info> listUsuario_de_Tocken = new List<tb_tocken_x_usuario_tocken_Info>();

       List<mail_Cuentas_Correo_Info> listmail_Cuentas_Correo = new List<mail_Cuentas_Correo_Info>();
       List<mail_Cuentas_Correo_x_Empresa_Info> listmail_cuentas_correo_x_empresa = new List<mail_Cuentas_Correo_x_Empresa_Info>();
       
       mail_Mensaje_Archi_Adjunto_Bus Bus_Archivo_Adjunto = new mail_Mensaje_Archi_Adjunto_Bus();
       tb_Comprobante_Bus ComProBus = new tb_Comprobante_Bus();
        public string sMensaje_respuesta_ws_auto = "";        
        public string sRespuesta_ws_estado = "";        
        tb_Comprobante_Data ComprobanteData = new tb_Comprobante_Data();
        public tb_Comprobante_Info InfoComprobante_a_firmar { get; set; }
        public List<tb_Empresa_Info> ListInfoEmpresa { get; set; }
        public Boolean HayErrores { get; set; }
        tb_sis_Log_Error_Vzen_Bus BusLogError = new tb_sis_Log_Error_Vzen_Bus();
        Boolean Validaciones(ref string mensajeErrorOut)
        {
            try
            {
                HayErrores = false;

                if (InfoComprobante_a_firmar == null)
                {
                    HayErrores = true;
                    mensajeErrorOut = "el objeto InfoComprobante_a_firmar no esta instanciado ";
                    
                }


                if (InfoComprobante_a_firmar == null)
                {
                    HayErrores = true;
                    mensajeErrorOut = "el objeto InfoComprobante_a_firmar no tiene campo xml lleno";
                    
                }

                if (ListInfoEmpresa == null)
                {
                    HayErrores = true;
                    mensajeErrorOut = "el listado de objeto ListInfoEmpresa no tiene datos se necesita los emisores para claves ";
                    
                }


                if (ListInfoEmpresa.Count == 0)
                {
                    HayErrores = true;
                    mensajeErrorOut = "no hay registros de empresas para firmar ";
                    
                }


                if (InfoParametros == null)
                {
                    HayErrores = true;
                    mensajeErrorOut = "no hay registros de parametros para firmar ";
                    
                }


                if (HayErrores == true)
                {
                    BusLogError.Log_Error(mensajeErrorOut,eTipoError.ERROR_VALIDACION, this.ToString());
                }

                return HayErrores;
            }
            catch (Exception ex)
            {
                BusLogError.Log_Error(ex.Message , eTipoError.ERROR_VALIDACION, this.ToString());

                return false;
            }
        }
      
       public void Firmar_y_Enviar_WSJava()
       {
           string MensajeError = "";

           try
           {
               
               tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new Info.tb_sis_Log_Error_Vzen_Info();


               string RespuestaWebServiceJavaEfirm = "";
               string Carpeta_para_grabar_file_firmado = ""; // ruta donde se va  a guardar
               string contrasenia_certificado = "";
               string Patchcertificado = "";
               string TipoToquen = "";
               Boolean EsTocken_USB = false;
               string IdToken_en_xml_para_firmar = "";
               string IdSerieTocken = "";
               string IdTocken = "";
               string PasswordTocken = "";
               string parametros_enviados_login = "";
               string IdAmbiente = "";
               string IdEmision = "";
               string sclaveAcceso_x_contin="";
               int digitoVerficador ;
               DateTime fechaEmision_Docu = DateTime.Now;

               string numAutorizacion = "";
               DateTime FechaAutorizacion=DateTime.Now;
               string sXML_autorizado_SRI = "";
               string sRutaCertificados = param.RutaCertificados;

               string SNombreEmpresa = "";
               string STipo_Emision = "";


               List<mail_correos_Info> ListaCorreo = new List<mail_correos_Info>();





               string SRespuestaBoolWS = "";
               string SMensajeErrorWS = "";
               
               HayErrores = false;
               string MensajeError2 = "";
               

               if (Validaciones(ref MensajeError2) == true)
               {
                   MensajeError = MensajeError2;
                   return;
               }


               


               //var selectedCertificate = Cerificado;

               string RespuestXmlLoginWS ="";


               try
               {

                   FirmElect.Bus.Java.EFirmClient SerivicioTest = new Java.EFirmClient();
                   HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(SerivicioTest.Endpoint.ListenUri.ToString() + "?wsdl");
                   HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse(); 
                   // Insert code that uses the response object.
                   HttpWResp.Close();

               }
               catch (Exception ex)
               {

                   HayErrores = true;
                   MensajeError = " http://localhost:8094/Cal?wsdl no esta activo  " + ex.ToString();
                   BusLogError.Log_Error(ex.Message + MensajeError , eTipoError.ERROR_VALIDACION, this.ToString());
                   return;
                   
               }
                  
               using (FirmElect.Bus.Java.EFirmClient Serivicio = new Java.EFirmClient())
               {
                  try
                       {
                           XmlDocument xmlOrigen = new XmlDocument();
                           xmlOrigen.Load(new StringReader(InfoComprobante_a_firmar.s_XML));
                           string TipodDocumento = xmlOrigen.GetElementsByTagName("codDoc")[0].InnerText;
                           string RucEmisor = xmlOrigen.GetElementsByTagName("ruc")[0].InnerText;
                           IdAmbiente = xmlOrigen.GetElementsByTagName("ambiente")[0].InnerText;

                           try
                           {

                               XmlNode xmlNodeMail;
                               XmlElement rootMail = xmlOrigen.DocumentElement;
                               string sMAIL = "";

                               // mail pricipal
                               xmlNodeMail = rootMail.SelectSingleNode("//campoAdicional[@nombre='" + "MAIL" + "']");
                               if(xmlNodeMail==null)
                                   xmlNodeMail = rootMail.SelectSingleNode("//campoAdicional[@nombre='" + "CliEmail" + "']");

                               sMAIL = xmlNodeMail.FirstChild.Value;
                               
                               mail_correos_Info InfoCorreo = new mail_correos_Info();
                               InfoCorreo.correo_principal = sMAIL;
                               

                               List<string> listaCorreoCC = new List<string>();


                               for (int indiceMail = 1; indiceMail < 10; indiceMail++)
                               {
                                   sMAIL = "";
                                   xmlNodeMail = rootMail.SelectSingleNode("//campoAdicional[@nombre='" + "MAIL" + indiceMail + "']");
                                   sMAIL = xmlNodeMail.FirstChild.Value;
                                   listaCorreoCC.Add(sMAIL);
                               }

                               InfoCorreo.correos_copia = listaCorreoCC;
                               ListaCorreo.Add(InfoCorreo);

                           }
                           catch (Exception ex)
                           {
                               
                               
                           }

                          


                           


                           try
                           {

                               SNombreEmpresa = ListInfoEmpresa.Find(v => v.IdEmpresa == InfoComprobante_a_firmar.IdEmpresa).RazonSocial;

                               STipo_Emision = ListInfoEmpresa.Find(v => v.IdEmpresa == InfoComprobante_a_firmar.IdEmpresa).cod_TipoEmision;

                               contrasenia_certificado = ListInfoEmpresa.Find(v => v.IdEmpresa == InfoComprobante_a_firmar.IdEmpresa).Clave_Certificado;
                               Patchcertificado = sRutaCertificados  + "\\" + ListInfoEmpresa.Find(v => v.RUC == RucEmisor).NombreCertificado;

                               TipoToquen = ListInfoEmpresa.Find(v => v.IdEmpresa == InfoComprobante_a_firmar.IdEmpresa).IdToquenAFirmar;
                               eTipoToquen eTipoToquen = (eTipoToquen)Enum.Parse(typeof(eTipoToquen), TipoToquen);




                               switch (eTipoToquen)
                               {
                                   case global::eTipoToquen.ANFCERTEXP:
                                       EsTocken_USB = true;
                                       break;
                                   case global::eTipoToquen.ANFPLUSIG:
                                       EsTocken_USB = true;
                                       break;
                                   case global::eTipoToquen.BCEALAETPR:
                                       EsTocken_USB = true;
                                       break;
                                   case global::eTipoToquen.BCEIKEY203:
                                       EsTocken_USB = false;
                                       break;
                                   case global::eTipoToquen.SDBIOPASS3:
                                       EsTocken_USB = true;
                                       break;
                                   case global::eTipoToquen.SDEPAS3003:
                                       EsTocken_USB = true;
                                       break;

                               }

                               if (EsTocken_USB == false)// es file de firma digital
                               {

                                   if (contrasenia_certificado == "" || TipoToquen == "") // debe de existir la clave del certificado y el tipo de toquen
                                   {
                                       HayErrores = true;
                                       MensajeError = @"contrasenia_certificado =='' || TipoToquen == ''  no existe la contraseña del certifcicado o el tipo de tocken en la base ";
                                       BusLogError.Log_Error(MensajeError, eTipoError.ERROR_VALIDACION, this.ToString());

                                       return;
                                   }

                               }
                               else // es tocken usb
                               {

                                   try
                                   {

                                    //   XmlDocument XmlComprobanteS = new XmlDocument();
                                       //XmlComprobanteS.LoadXml(Funciones.Formating_xml(InfoComprobante_a_firmar.s_XML));

                                       //ENCONTRANDO EL NODO TOKEN CON ESTE SE FIRMARA
                                       XmlNode oldCd;
                                       XmlElement root = xmlOrigen.DocumentElement;
                                       oldCd = root.SelectSingleNode("//campoAdicional[@nombre='" + "TOKEN" + "']");
                                       IdToken_en_xml_para_firmar = oldCd.FirstChild.Value;



                                       if (IdToken_en_xml_para_firmar != "")
                                       {
                                           

                                                       var q = from C in listToquen
                                                               where C.IdTocken == IdToken_en_xml_para_firmar
                                                               select C;


                                                     foreach (var item in q)
                                                    {
                                                        IdSerieTocken = item.Serie;
                                                        PasswordTocken = item.Password;
                                                    }

                                                                                      

                                       }
                                       else
                                       {
                                           BusLogError.Log_Error("IdToken_en_xml_para_firmar esta vacion en el tag TOKEN", eTipoError.ERROR_VALIDACION, this.ToString());

                                           return;

                                       }

                                   }
                                   catch (Exception ex)
                                   {

                                       MensajeError = SMensajeErrorWS;
                                       HayErrores = true;
                                       BusLogError.Log_Error(MensajeError + "ERROR NO EXISTE TAG TOCKEN NO SE PUEDE FIRMAR",eTipoError.ERROR_TRY,this.ToString());

                                       return;
                                       
                                   }
                                   
                                                                  
                               }


                                   //logoneando el certificado 

                               if (IdAmbiente == "1")//pruebas 
                               {
                                   Serivicio.SetParametroAmbiente(IdAmbiente);
                                   Serivicio.SetParametroUrlWSAutorizacion(InfoParametros.url_ws_sri_Autorizacion_cbte_Prueba);
                                   Serivicio.SetParametroUrlWSRecepcion(InfoParametros.url_ws_sri_Recep_cbte_Prueba);
                               }
                              if (IdAmbiente == "2")//producccion
                               {
                                   Serivicio.SetParametroAmbiente(IdAmbiente);
                                   Serivicio.SetParametroUrlWSAutorizacion(InfoParametros.url_ws_sri_Autorizacion_cbte_Produc);
                                   Serivicio.SetParametroUrlWSRecepcion(InfoParametros.url_ws_sri_Recep_cbte_Produc);
                               }

                              if (InfoParametros.Usa_Proxy ==true )
                              {
                                  Serivicio.SetParametroProxyUrl((InfoParametros.Url_Proxy == null) ? "" : InfoParametros.Url_Proxy);
                                  Serivicio.SetParametroProxyPass((InfoParametros.Password_Proxy == null) ? "" : InfoParametros.Password_Proxy);
                                  Serivicio.SetParametroProxyUser((InfoParametros.Usuario_Proxy == null) ? "" : InfoParametros.Usuario_Proxy);
                                  Serivicio.SetParametroProxyPort((InfoParametros.Port_Proxy == null) ? "" : InfoParametros.Port_Proxy.ToString());
                              
                              }

                                  switch (eTipoToquen)
                                   {
                                       case global::eTipoToquen.ANFCERTEXP:
                                           break;
                                       case global::eTipoToquen.ANFPLUSIG:
                                           break;
                                       case global::eTipoToquen.BCEALAETPR:
                                           break;
                                       case global::eTipoToquen.BCEIKEY203:
                                           RespuestXmlLoginWS = Serivicio.Login(1, Patchcertificado, contrasenia_certificado);
                                           parametros_enviados_login = "RespuestXmlLoginWS = Serivicio.Login(1, Patchcertificado, contrasenia_certificado);" +
                                               " Patchcertificado=" + Patchcertificado + " contrasenia_certificado:" + contrasenia_certificado;
                                           break;
                                       case global::eTipoToquen.SDBIOPASS3:
                                           break;
                                       case global::eTipoToquen.SDEPAS3003:


                                         // tipo , serieTocekn , pasword
                                           RespuestXmlLoginWS = Serivicio.Login(3, IdSerieTocken, PasswordTocken);
                                           parametros_enviados_login = "RespuestXmlLoginWS = Serivicio.Login(3, IdSerieTocken, PasswordTocken); " +
                                               " IdSerieTocken=" + IdSerieTocken + " PasswordTocken=" + PasswordTocken;

                                           break;
                                   }


                                   XmlDocument XmlRespuestaWsLogin = new XmlDocument();
                                   XmlRespuestaWsLogin.LoadXml(Funciones.Formating_xml(RespuestXmlLoginWS));
                                   SRespuestaBoolWS = XmlRespuestaWsLogin.GetElementsByTagName("isSuccess")[0].InnerText;
                                   SMensajeErrorWS = XmlRespuestaWsLogin.GetElementsByTagName("msgError")[0].InnerText;

                                   if (SRespuestaBoolWS.ToUpper() == "TRUE")//si logoneo
                                   {
                                       HayErrores = false;
                                       Carpeta_para_grabar_file_firmado = Optener_ruta_destino_x_tipo_cbte(TipodDocumento);
                                       RespuestaWebServiceJavaEfirm = "";
                                       string Param1 = InfoComprobante_a_firmar.RutaArchivo + "\\" + InfoComprobante_a_firmar.Nombre_file;
                                       string Param2 = Carpeta_para_grabar_file_firmado + "\\" + InfoComprobante_a_firmar.Nombre_file;
                                       string Param3 = TipodDocumento;
                                       Param1 = InfoComprobante_a_firmar.s_XML;
                                       RespuestaWebServiceJavaEfirm = Serivicio.Firmar(Param1);
                                       Thread.Sleep(4220);// espero 5 segundos antes de seguir con la optencion de la autorizacion 

                                   }
                                   else
                                   {
                                       MensajeError = SMensajeErrorWS;
                                       HayErrores = true;
                                       BusLogError.Log_Error(RespuestaWebServiceJavaEfirm + " " + parametros_enviados_login + "NO LOGIN ", eTipoError.WARNING, this.ToString());
                                       return;
                                   }

                 

                           }
                           catch (Exception ex)//clave de contingencia
                           {


                               if (STipo_Emision == "NORMAL")
                               {
                                   return;
                               }
                               BusLogError.Log_Error(ex.Message.ToString() + "catch (Exception ex) en secion de loging se va por clave contingencia", eTipoError.ERROR, this.ToString());

                               XmlDocument xmlcon_clave_contigencia = new XmlDocument();
                               xmlcon_clave_contigencia.Load(new StringReader(InfoComprobante_a_firmar.s_XML));


                               IdEmision = "";


                                  // este if para no volver a grabar el xml por clave de contingencia 
                                   // si tiene tipo de emsion en 2 quiere decir a ya tiene clave de contingencia
                               if (xmlcon_clave_contigencia.GetElementsByTagName("tipoEmision")[0].InnerText == "1")
                               {
                                   IdEmision = "2"; //indisponibilidad de sistemas

                                   switch (InfoComprobante_a_firmar.IdTipoDocumento)
                                   {
                                       case "01"://factura
                                           fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                           break;
                                       case "04"://nota cred
                                           fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                           break;
                                       case "05"://nota dev
                                           fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                           break;
                                       case "06"://guia
                                           fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaIniTransporte")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                           break;
                                       case "07"://retencion

                                           fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                           break;

                                   }
                                   

                                   sclaveAcceso_x_contin = ComProBus.GeneraClaveAcceso_x_Contingencia(InfoComprobante_a_firmar.IdEmpresa, fechaEmision_Docu,
                                           InfoComprobante_a_firmar.IdTipoDocumento, IdAmbiente,IdEmision, ref MensajeError);
                                       


                                           if (sclaveAcceso_x_contin   != "" )
                                           {

                                               digitoVerficador = ComProBus.GeneraDigitoVerificadorModulo11(sclaveAcceso_x_contin);
                                               sclaveAcceso_x_contin = sclaveAcceso_x_contin + digitoVerficador.ToString();

                               
                                                   xmlcon_clave_contigencia.GetElementsByTagName("claveAcceso")[0].InnerText = sclaveAcceso_x_contin;
                                                   xmlcon_clave_contigencia.GetElementsByTagName("tipoEmision")[0].InnerText = IdEmision; // Emisión por Indisponibilidad del Sistema

                                                   //grabando en la base el comprobante por clave de contingencia 

                                                   #region Armando Info comprobante a grabar en Base por estado con clave de contingencia
                               
                               
                                                   tb_Comprobante_Info Cbt_con_clave_contingencia = new tb_Comprobante_Info();

                                                    Cbt_con_clave_contingencia.IdEmpresa=InfoComprobante_a_firmar.IdEmpresa;
                                                    Cbt_con_clave_contingencia.IdComprobante = InfoComprobante_a_firmar.IdComprobante;
                                                    Cbt_con_clave_contingencia.IdTipoDocumento = InfoComprobante_a_firmar.IdTipoDocumento;
                                                    Cbt_con_clave_contingencia.IdEstado_cbte = "VALI_&_FIRM_&_CON_CLV";
                                                    Cbt_con_clave_contingencia.Cedula_Ruc = InfoComprobante_a_firmar.Cedula_Ruc;
                                                    Cbt_con_clave_contingencia.Numero_Autorizacion = null;
                                                    Cbt_con_clave_contingencia.RutaArchivo = null;
                                                    Cbt_con_clave_contingencia.Nombre_file = InfoComprobante_a_firmar.Nombre_file;
                                                    Cbt_con_clave_contingencia.s_XML = Funciones.Formating_xml(xmlcon_clave_contigencia.InnerXml);
                                                    Cbt_con_clave_contingencia.Fecha_Emi_Fact = InfoComprobante_a_firmar.Fecha_Emi_Fact;
                                                    Cbt_con_clave_contingencia.FechaAutorizacion = null;
                                                    Cbt_con_clave_contingencia.ClaveContingencia = sclaveAcceso_x_contin;
                                                    Cbt_con_clave_contingencia.EstadoDoc = null;
                                                    Cbt_con_clave_contingencia.Error = null;
                                                    Cbt_con_clave_contingencia.IdEstadoProceso = "PEND";
                                                    Cbt_con_clave_contingencia.IdError_Sri = null;
                                                    Cbt_con_clave_contingencia.Fecha_transaccion = DateTime.Now;

                                                    Cbt_con_clave_contingencia.Ambiente = InfoComprobante_a_firmar.Ambiente;
                                                    Cbt_con_clave_contingencia.Clave_Acceso = sclaveAcceso_x_contin;


                                                    RespuestaWebServiceJavaEfirm=(RespuestaWebServiceJavaEfirm=="")?"":Funciones.Formating_xml(RespuestaWebServiceJavaEfirm);

                                                   Cbt_con_clave_contingencia.RespuestaSRI = RespuestaWebServiceJavaEfirm;


                               

                                                   #endregion
                                                   if( ComprobanteData.GrabarDB(Cbt_con_clave_contingencia, ref MensajeError))
                                                   {

                                                    ///modifico el registro anterior con estado procesado
                                                    ComprobanteData.ModificarDB(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,
                                                        InfoComprobante_a_firmar.IdTipoDocumento, InfoComprobante_a_firmar.IdEstado_cbte, RespuestaWebServiceJavaEfirm, ""
                                                        , eIdEstadoProceso.PROCE, ref MensajeError);
                                                   }
                                           }

                              

                               }

                           }

                           
                               //HAY RESPUESTA DEL WS
                           if (RespuestaWebServiceJavaEfirm != "")
                           {



                               XmlDocument XmlRespuestaWs = new XmlDocument();
                               XmlRespuestaWs.LoadXml(Funciones.Formating_xml(RespuestaWebServiceJavaEfirm));

                               string sEstadoRespuesta = "";
                               string sErrorRespuesta = "";
                               string IdError = "";

                               SRespuestaBoolWS = XmlRespuestaWs.GetElementsByTagName("isSuccess")[0].InnerText;

                               if (SRespuestaBoolWS.ToUpper() == "TRUE")//respuesta del ws true
                               {

                                   sEstadoRespuesta = XmlRespuestaWs.GetElementsByTagName("estado")[0].InnerText;

                                   if (sEstadoRespuesta == "DEVUELTA")
                                   {
                                       sErrorRespuesta = XmlRespuestaWs.GetElementsByTagName("mensaje")[0].InnerText;
                                       //sErrorRespuesta = sErrorRespuesta + " " + XmlRespuestaWs.GetElementsByTagName("informacionAdicional")[0].InnerText;
                                       IdError = XmlRespuestaWs.GetElementsByTagName("identificador")[0].InnerText;


                                       //actualizo la respuesta del SRI de error del cbte enviado
                                       ComprobanteData.ModificarErrorDB(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,
                                           InfoComprobante_a_firmar.IdTipoDocumento, InfoComprobante_a_firmar.IdEstado_cbte, IdError, sErrorRespuesta, Funciones.Formating_xml(XmlRespuestaWs.InnerXml)
                                           , ref MensajeError);

                                       if (IdError == "70" || IdError == "43")
                                       {

                                           ComprobanteData.ModificarDB(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,
                                                      InfoComprobante_a_firmar.IdTipoDocumento, InfoComprobante_a_firmar.IdEstado_cbte, Funciones.Formating_xml(XmlRespuestaWs.InnerXml), "", eIdEstadoProceso.PROCE, ref MensajeError);


                                       }

                                    




                                   }
                                   else // RECIBIDA
                                   {

                                       // se envia la clave de acceso
                                       string claveAcceso = xmlOrigen.GetElementsByTagName("claveAcceso")[0].InnerText;
                                       //opteniendo el file xml con la clave de acceso 
                                       String RespuestaXml_Autorizado = Serivicio.GetAutorizacionWS(claveAcceso);

                                       
                                       #region Log de Errores
                                       BusLogError.Log_Error("RESPUESTA DE : Serivicio.GetAutorizacionWS(claveAcceso); " + RespuestaXml_Autorizado
                                           , eTipoError.LOG, this.ToString());
                                       #endregion


                                       XmlDocument XMlAutorizado = new XmlDocument();
                                       XMlAutorizado.LoadXml(RespuestaXml_Autorizado);
                                       SRespuestaBoolWS = XmlRespuestaWs.GetElementsByTagName("isSuccess")[0].InnerText;


                                       #region Log de Errores
                                       BusLogError.Log_Error("CONVERSION A XML DE RESPUESTA  GetAutorizacionWS"
                                           , eTipoError.LOG, this.ToString());
                                       #endregion


                                       if (SRespuestaBoolWS.ToUpper() == "TRUE")//respuesta AUTORIZACION OK del ws true
                                       {


                                           #region Log de Errores
                                           BusLogError.Log_Error("respuesta true dentro de autorizacion "
                                               , eTipoError.LOG, this.ToString());
                                           #endregion


                                           int cant_de_cbtes_enviados_x_sri = XMlAutorizado.GetElementsByTagName("estado").Count;

                                           if (cant_de_cbtes_enviados_x_sri == 0)//no hay respuesta
                                           {
                                              // ComprobanteData.ModificarDB(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,
                                              //InfoComprobante_a_firmar.IdTipoDocumento, InfoComprobante_a_firmar.IdEstado_cbte, Funciones.Formating_xml(XmlRespuestaWs.InnerXml), "No hay respuesta", eIdEstadoProceso.PROCE, ref MensajeError);

                                               #region Log de Errores
                                               BusLogError.Log_Error("NO HAY RES WS" + XMlAutorizado.InnerXml , eTipoError.LOG, this.ToString());
                                               #endregion

                                          }
                                           else
                                           {

                                               #region Log de Errores
                                               BusLogError.Log_Error("Si hay respuesta mas de 1 cbte)"
                                                   , eTipoError.LOG, this.ToString());
                                               #endregion



                                               tb_Comprobante_Info InfoComprobanteAutorizado = new tb_Comprobante_Info();

                                               //cant : numero de cbtes pueden estar autorizados y no autorizados
                                               sMensaje_respuesta_ws_auto = "";
                                               sRespuesta_ws_estado = "";


                                                                // si esta autorizado 

                                                               XmlDocument XMLdoc_a_guardar = new XmlDocument();
                                                               XMLdoc_a_guardar.CreateXmlDeclaration("1.0", "utf-8", "yes");
                                                               string SXml_a_Guardar = "";
                                                            
                                                              

                                                               try
                                                               {

                                                                   XmlNode Nodo_xml_Autorizado = XMlAutorizado.GetElementsByTagName("numeroAutorizacion")[0].ParentNode;


                                                                   SXml_a_Guardar = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
                                                                   SXml_a_Guardar = SXml_a_Guardar + " <autorizacion> ";
                                                                   SXml_a_Guardar = SXml_a_Guardar + Nodo_xml_Autorizado.InnerXml;
                                                                   SXml_a_Guardar = SXml_a_Guardar + " </autorizacion> ";
                                                                   XMLdoc_a_guardar.LoadXml(SXml_a_Guardar);

                                                                   //
                                                                   XMLdoc_a_guardar.GetElementsByTagName("comprobante")[0].InnerText = "<![CDATA[" + "<?xml version=\"1.0\" encoding=\"utf-8\"?> " + XMLdoc_a_guardar.GetElementsByTagName("comprobante")[0].InnerText + "]]>";

                                                                   

                                                                   

                                                                   sXML_autorizado_SRI = XMLdoc_a_guardar.InnerXml;

                                                                   foreach ( XmlNode item in Nodo_xml_Autorizado.ChildNodes)
                                                                   {
                                                                       //item.Name
                                                                       if (item.Name=="estado")
                                                                       {
                                                                           sRespuesta_ws_estado = item.InnerText;// AUTORIZADO
                                                                       }

                                                                       if (item.Name == "numeroAutorizacion")
                                                                       {
                                                                           numAutorizacion = item.InnerText;
                                                                       }

                                                                       if (item.Name == "fechaAutorizacion")
                                                                       {
                                                                           FechaAutorizacion = Convert.ToDateTime(item.InnerText);
                                                                           InfoComprobanteAutorizado.FechaAutorizacion = FechaAutorizacion;
                                                                       }
                                                                     
                                                                   }

                                                                }
                                                               catch (Exception ex)
                                                               {
                                                                   

                                                                   XmlNodeList xmlNode_f;
                                                                   XmlNode xmlNode_msj;
                                                                   XmlNode xmlNode_Ultimo;
                                                                   XmlElement root = XMlAutorizado.DocumentElement;
                                                                   xmlNode_f = root.SelectNodes(@"//estado[.='NO AUTORIZADO']/..");//xpath para buscar los no autorizados
                                                                   xmlNode_Ultimo= xmlNode_f.Item(0);// encontrando el ultimo nodo no autorizado

                                                                   //creando xml para respuesta del RIDE
                                                                   XmlNode copiedNode = XMLdoc_a_guardar.ImportNode(xmlNode_Ultimo, true);


                                                                   

                                                                   SXml_a_Guardar = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
                                                                   SXml_a_Guardar = SXml_a_Guardar + " <autorizacion> ";
                                                                   SXml_a_Guardar = SXml_a_Guardar + copiedNode.InnerXml;
                                                                   SXml_a_Guardar = SXml_a_Guardar + " </autorizacion> ";
                                                                   XMLdoc_a_guardar.LoadXml(SXml_a_Guardar);

                                                                   //
                                                                   XMLdoc_a_guardar.GetElementsByTagName("comprobante")[0].InnerText = "<![CDATA[" + "<?xml version=\"1.0\" encoding=\"utf-8\"?> " + XMLdoc_a_guardar.GetElementsByTagName("comprobante")[0].InnerText + "]]>";

                                                                   
                                                                   sXML_autorizado_SRI = XMLdoc_a_guardar.InnerXml;



                                                                   XmlElement rootMens = XMLdoc_a_guardar.DocumentElement;
                                                                   xmlNode_msj = rootMens.SelectSingleNode(@"//mensajes");



                                                                   sMensaje_respuesta_ws_auto = xmlNode_msj.InnerXml;
                                                                   sRespuesta_ws_estado = "NO AUTORIZADO";



                                                               }


                                               #region Armando el tb_comprobante para almacenarlo en DB

                                               

                                               InfoComprobanteAutorizado.IdEmpresa = InfoComprobante_a_firmar.IdEmpresa;
                                               InfoComprobanteAutorizado.IdComprobante = InfoComprobante_a_firmar.IdComprobante;
                                               InfoComprobanteAutorizado.IdTipoDocumento = InfoComprobante_a_firmar.IdTipoDocumento;
                                               InfoComprobanteAutorizado.IdEstado_cbte = "VALI_&_FIRM_&_REC";
                                               InfoComprobanteAutorizado.Cedula_Ruc = InfoComprobante_a_firmar.Cedula_Ruc;
                                               InfoComprobanteAutorizado.RutaArchivo = null;
                                               InfoComprobanteAutorizado.Nombre_file = InfoComprobante_a_firmar.Nombre_file;
                                               InfoComprobanteAutorizado.s_XML = Funciones.Formating_xml(sXML_autorizado_SRI);
                                               InfoComprobanteAutorizado.Fecha_Emi_Fact = InfoComprobante_a_firmar.Fecha_Emi_Fact;
                                               InfoComprobanteAutorizado.Fecha_transaccion = DateTime.Now;
                                               InfoComprobanteAutorizado.ClaveContingencia = null;
                                               InfoComprobanteAutorizado.EstadoDoc = sRespuesta_ws_estado;
                                               InfoComprobanteAutorizado.Error = sMensaje_respuesta_ws_auto;
                                               InfoComprobanteAutorizado.IdEstadoProceso = eIdEstadoProceso.PROCE.ToString();
                                               InfoComprobanteAutorizado.IdError_Sri = null;
                                               InfoComprobanteAutorizado.RespuestaSRI = Funciones.Formating_xml(XmlRespuestaWs.InnerXml);
                                               InfoComprobanteAutorizado.Total = InfoComprobante_a_firmar.Total;
                                               InfoComprobanteAutorizado.Numero_Autorizacion = numAutorizacion;
                                               InfoComprobanteAutorizado.Ambiente = InfoComprobante_a_firmar.Ambiente;
                                               InfoComprobanteAutorizado.Clave_Acceso = claveAcceso;
                                               

                                               #endregion

                                               if (ComprobanteData.GrabarDB(InfoComprobanteAutorizado, ref MensajeError))
                                               {
                                                   ///modifico el estado anterior
                                                   ComprobanteData.ModificarDB(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,
                                                       InfoComprobante_a_firmar.IdTipoDocumento, InfoComprobante_a_firmar.IdEstado_cbte, Funciones.Formating_xml(XmlRespuestaWs.InnerXml), "", eIdEstadoProceso.PROCE, ref MensajeError);




                                                   Envio_Cbte_x_correo(InfoComprobanteAutorizado, ListaCorreo, SNombreEmpresa, InfoComprobanteAutorizado.EstadoDoc, IdAmbiente, eTipoEnvioMail.NUEVO, "Firmar_y_Enviar_WSJava", ref MensajeError2);


                                                   //INSERTAR EN TABLA_EXTERNA

                                                   tb_Comprobante_Procesos_externos_Bus BusCbte = new tb_Comprobante_Procesos_externos_Bus(ListInfoEmpresa);
                                                               BusCbte.GrabarDB(InfoComprobanteAutorizado, ref MensajeError);


                                                   }
                                           }

                                       }
                                       else// LA RESPUESTA FUE POR FALSE GRABO EL LOG DE ESA REPUESTA 
                                       {


                                           #region Log de Errores
                                           BusLogError.Log_Error("error " + RespuestaXml_Autorizado + " NO HAY RES DE : Serivicio.GetAutorizacionWS(claveAcceso);", eTipoError.LOG, this.ToString());
                                           #endregion



                                       }


                                   }//FIN ELSE

                               }
                               else // SI LA REPUESTA DEL WS FIRMA ESTA FALSE por que se cayo en el java se va por clave de contingencia
                               {

                                  

                                   #region Log de Errores
                                   MensajeError = " mensaje log  WS FIRMA ESTA FALSE por que se cayo en el java se va por clave de contingencia ";
                                   BusLogError.Log_Error(MensajeError  + " " +XmlRespuestaWs.InnerXml, eTipoError.LOG, this.ToString());
                                   #endregion


                                   #region si el wsJavaEfirm responde false hacer clave de acceso

                                   XmlDocument xmlcon_clave_contigencia = new XmlDocument();
                                   xmlcon_clave_contigencia.Load(new StringReader(InfoComprobante_a_firmar.s_XML));

                                   if (STipo_Emision == "NORMAL")
                                   {
                                       return;
                                   }
                                   IdEmision = "2";

                                   // este if para no volver a grabar el xml por clave de contingencia 
                                   // si tiene tipo de emsion en 2 quiere decir a ya tiene clave de contingencia
                                   //solo cuando sea tipo de emsion 1 busca clave de cntingencia
                                   if (xmlcon_clave_contigencia.GetElementsByTagName("tipoEmision")[0].InnerText == "1")
                                   {



                                       switch (InfoComprobante_a_firmar.IdTipoDocumento)
                                       {
                                           case "01"://factura
                                               fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));

                                               break;
                                           case "04"://nota cred
                                               fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                               break;
                                           case "05"://nota dev
                                               fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                               
                                               break;
                                           case "06"://guia
                                               fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaIniTransporte")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                               break;
                                           case "07"://retencion
                                               fechaEmision_Docu = DateTime.Parse(xmlcon_clave_contigencia.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                               break;

                                       }


                                       sclaveAcceso_x_contin = ComProBus.GeneraClaveAcceso_x_Contingencia(InfoComprobante_a_firmar.IdEmpresa, fechaEmision_Docu,
                                           InfoComprobante_a_firmar.IdTipoDocumento, IdAmbiente ,IdEmision , ref MensajeError);



                                       if (sclaveAcceso_x_contin != "")
                                       {

                                           digitoVerficador = ComProBus.GeneraDigitoVerificadorModulo11(sclaveAcceso_x_contin);

                                           sclaveAcceso_x_contin = sclaveAcceso_x_contin + digitoVerficador.ToString();


                                           xmlcon_clave_contigencia.GetElementsByTagName("claveAcceso")[0].InnerText = sclaveAcceso_x_contin;
                                           xmlcon_clave_contigencia.GetElementsByTagName("tipoEmision")[0].InnerText = IdEmision;

                                           //grabando en la base el comprobante por clave de contingencia 

                                           #region Armando Info comprobante a grabar en Base por estado con clave de contingencia


                                           tb_Comprobante_Info Cbt_con_clave_contingencia = new tb_Comprobante_Info();

                                           Cbt_con_clave_contingencia.IdEmpresa = InfoComprobante_a_firmar.IdEmpresa;
                                           Cbt_con_clave_contingencia.IdComprobante = InfoComprobante_a_firmar.IdComprobante;
                                           Cbt_con_clave_contingencia.IdTipoDocumento = InfoComprobante_a_firmar.IdTipoDocumento;
                                           Cbt_con_clave_contingencia.IdEstado_cbte = "VALI_&_FIRM_&_CON_CLV";
                                           Cbt_con_clave_contingencia.Cedula_Ruc = InfoComprobante_a_firmar.Cedula_Ruc;
                                           Cbt_con_clave_contingencia.Numero_Autorizacion = null;
                                           Cbt_con_clave_contingencia.RutaArchivo = null;
                                           Cbt_con_clave_contingencia.Nombre_file = InfoComprobante_a_firmar.Nombre_file;
                                           Cbt_con_clave_contingencia.s_XML = Funciones.Formating_xml(xmlcon_clave_contigencia.InnerXml);
                                           Cbt_con_clave_contingencia.Fecha_Emi_Fact = InfoComprobante_a_firmar.Fecha_Emi_Fact;
                                           Cbt_con_clave_contingencia.FechaAutorizacion = null;
                                           Cbt_con_clave_contingencia.ClaveContingencia = sclaveAcceso_x_contin;
                                           Cbt_con_clave_contingencia.EstadoDoc = null;
                                           Cbt_con_clave_contingencia.Error = null;
                                           Cbt_con_clave_contingencia.IdEstadoProceso = "PEND";
                                           Cbt_con_clave_contingencia.IdError_Sri = null;
                                           Cbt_con_clave_contingencia.Fecha_transaccion = DateTime.Now;
                                           Cbt_con_clave_contingencia.Ambiente = InfoComprobante_a_firmar.Ambiente;
                                           Cbt_con_clave_contingencia.Clave_Acceso = sclaveAcceso_x_contin;


                                           RespuestaWebServiceJavaEfirm = (RespuestaWebServiceJavaEfirm == "") ? "" : Funciones.Formating_xml(RespuestaWebServiceJavaEfirm);

                                           Cbt_con_clave_contingencia.RespuestaSRI = RespuestaWebServiceJavaEfirm;


                                           #endregion

                                           // si graba modifico 
                                           if (ComprobanteData.GrabarDB(Cbt_con_clave_contingencia, ref MensajeError))
                                           {

                                               ///modifico el registro anterior con estado procesado
                                               ComprobanteData.ModificarDB(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,
                                                   InfoComprobante_a_firmar.IdTipoDocumento, InfoComprobante_a_firmar.IdEstado_cbte, RespuestaWebServiceJavaEfirm, ""
                                                   , eIdEstadoProceso.PROCE, ref MensajeError);
                                           }
                                       }
                                   #endregion

                                   }
                               }



                           }
                           else
                           { 
                           
                           }


                       }
                       catch (Exception ex)
                       {

                           #region Log de Errores
                           BusLogError.Log_Error(ex.Message + " " + MensajeError, eTipoError.ERROR, this.ToString());
                           #endregion


                           HayErrores = true;
                       }
                       
                   
                   
               }//fin using


               

           }
           catch (Exception ex)
           {

               #region Log de Errores
               MensajeError = ex.Message.ToString();
               BusLogError.Log_Error(MensajeError, eTipoError.ERROR, this.ToString());
               #endregion

               HayErrores = true;

           }
       }
       
       public string Optener_ruta_destino_x_tipo_cbte(string TipoDocumento)
       {
           try
           {
       
               String RutaFinal = "";
               //if (TipoDocumento == "01")
               //    RutaFinal = param.PathFactura;
               //else if (TipoDocumento == "04")
               //    RutaFinal = param.PathNotaCredito;
               //else if (TipoDocumento == "05")
               //    RutaFinal = param.PathNotaDebito;
               //else if (TipoDocumento == "06")
               //    RutaFinal = param.PathGuiaRemision;
               //else if (TipoDocumento == "07")
               //    RutaFinal = param.PathComprobanteRetencion;

               return RutaFinal + "\\";

           }
           catch (Exception ex)
           {

               #region Log de Errores
               BusLogError.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
               #endregion
               return "";
           }
       }
       public Boolean Optener_Autorizacion_WSJava(ref string MensajeError)
       {
           try
           {

               tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new Info.tb_sis_Log_Error_Vzen_Info();

               string SRespuestaLoginBoolWS = "";
               string SRespuestaBoolWS_Autorizacion = "";
               string contrasenia_certificado = "";
               string Patchcertificado = "";
               string TipoToquen = "";
               Boolean EsTocken_USB = false;
               string IdToken_en_xml_para_firmar = "";
               string IdSerieTocken = "";
               string PasswordTocken = "";
               string parametros_enviados_login = "";
               string IdAmbiente = "";
               string SMensajeErrorWS = "";
               string numAutorizacion = "";
               string sXML_autorizado_SRI = "";
               DateTime FechaAutorizacion = DateTime.Now;

               string sRutaCertificados = param.RutaCertificados;

               List<mail_correos_Info> ListaCorreo = new List<mail_correos_Info>();
               List<string> listaCorreosCC = new List<string>();
              
               string SNombreEmpresa = "";

               mail_correos_Info InfoMail = new mail_correos_Info();

               HayErrores = false;
               string mensajeErroOut2 = "";


               if (Validaciones(ref MensajeError) == true)
               {
                                      return HayErrores;
               }





               //var selectedCertificate = Cerificado;

               string RespuestXmlLoginWS = "";


               try
               {

                   FirmElect.Bus.Java.EFirmClient SerivicioTest = new Java.EFirmClient();
                   HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(SerivicioTest.Endpoint.ListenUri.ToString() + "?wsdl");
                   HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
                   // Insert code that uses the response object.
                   HttpWResp.Close();

               }
               catch (Exception ex)
               {

                   HayErrores = true;
                   MensajeError = " http://localhost:8094/Cal?wsdl no esta activo  " + ex.ToString();
                   BusLogError.Log_Error(ex.Message + MensajeError, eTipoError.ERROR_VALIDACION, this.ToString());
                   return false;

               }



               using (FirmElect.Bus.Java.EFirmClient Serivicio = new Java.EFirmClient())
               {


                   try
                   {


                       XmlDocument xmlOrigen = new XmlDocument();
                       xmlOrigen.Load(new StringReader(InfoComprobante_a_firmar.s_XML));
                       string TipodDocumento = xmlOrigen.GetElementsByTagName("codDoc")[0].InnerText;
                       string RucEmisor = xmlOrigen.GetElementsByTagName("ruc")[0].InnerText;

                       IdAmbiente = xmlOrigen.GetElementsByTagName("ambiente")[0].InnerText;



                       try
                       {

                           XmlNode xmlNodeMail;
                           XmlElement rootMail = xmlOrigen.DocumentElement;
                           string sMAIL = "";

                           xmlNodeMail = rootMail.SelectSingleNode("//campoAdicional[@nombre='" + "MAIL" + "']");
                           sMAIL = xmlNodeMail.FirstChild.Value;

                           
                           InfoMail.correo_principal = sMAIL;

                           

                           for (int indiceMail = 1; indiceMail < 10; indiceMail++)
                           {
                               sMAIL = "";
                               xmlNodeMail = rootMail.SelectSingleNode("//campoAdicional[@nombre='" + "MAIL" + indiceMail + "']");
                               sMAIL = xmlNodeMail.FirstChild.Value;
                               listaCorreosCC.Add(sMAIL);
                           }

                          

                       }
                       catch (Exception ex)
                       {


                       }

                       InfoMail.correos_copia = listaCorreosCC;
                       ListaCorreo.Add(InfoMail);


                       try
                       {


                           SNombreEmpresa = ListInfoEmpresa.Find(v => v.IdEmpresa == InfoComprobante_a_firmar.IdEmpresa).RazonSocial;
                           contrasenia_certificado = ListInfoEmpresa.Find(v => v.IdEmpresa == InfoComprobante_a_firmar.IdEmpresa).Clave_Certificado;
                           Patchcertificado = sRutaCertificados + "\\" + ListInfoEmpresa.Find(v => v.RUC == RucEmisor).NombreCertificado;

                           TipoToquen = ListInfoEmpresa.Find(v => v.IdEmpresa == InfoComprobante_a_firmar.IdEmpresa).IdToquenAFirmar;
                           eTipoToquen eTipoToquen = (eTipoToquen)Enum.Parse(typeof(eTipoToquen), TipoToquen);




                           switch (eTipoToquen)
                           {
                               case global::eTipoToquen.ANFCERTEXP:
                                   EsTocken_USB = true;
                                   break;
                               case global::eTipoToquen.ANFPLUSIG:
                                   EsTocken_USB = true;
                                   break;
                               case global::eTipoToquen.BCEALAETPR:
                                   EsTocken_USB = true;
                                   break;
                               case global::eTipoToquen.BCEIKEY203:
                                   EsTocken_USB = false;
                                   break;
                               case global::eTipoToquen.SDBIOPASS3:
                                   EsTocken_USB = true;
                                   break;
                               case global::eTipoToquen.SDEPAS3003:
                                   EsTocken_USB = true;
                                   break;

                           }

                           if (EsTocken_USB == false)// es file de firma digital
                           {

                               if (contrasenia_certificado == "" || TipoToquen == "") // debe de existir la clave del certificado y el tipo de toquen
                               {
                                   HayErrores = true;
                                   MensajeError = @"contrasenia_certificado =='' || TipoToquen == ''  no existe la contraseña del certifcicado o el tipo de tocken en la base ";
                                   BusLogError.Log_Error(MensajeError, eTipoError.ERROR_VALIDACION, this.ToString());

                                   return false;
                               }

                           }
                           else // es tocken usb
                           {

                               try
                               {

                                   XmlDocument XmlComprobanteS = new XmlDocument();
                                   XmlComprobanteS.LoadXml(Funciones.Formating_xml(InfoComprobante_a_firmar.s_XML));

                                   //ENCONTRANDO EL NODO TOKEN CON ESTE SE FIRMARA
                                   XmlNode oldCd;
                                   XmlElement root = XmlComprobanteS.DocumentElement;
                                   oldCd = root.SelectSingleNode("//campoAdicional[@nombre='" + "TOKEN" + "']");
                                   IdToken_en_xml_para_firmar = oldCd.FirstChild.Value;




                                   if (IdToken_en_xml_para_firmar != "")
                                   {


                                       var q = from C in listToquen
                                               where C.IdTocken == IdToken_en_xml_para_firmar
                                               select C;


                                       foreach (var item in q)
                                       {
                                           IdSerieTocken = item.Serie;
                                           PasswordTocken = item.Password;
                                       }



                                   }
                                   else
                                   {
                                       BusLogError.Log_Error("IdToken_en_xml_para_firmar esta vacion en el tag TOKEN", eTipoError.ERROR_VALIDACION, this.ToString());

                                       return false;

                                   }

                               }
                               catch (Exception ex)
                               {

                                   MensajeError = ex.Message + " " + SMensajeErrorWS;
                                   HayErrores = true;
                                   BusLogError.Log_Error(MensajeError + "ERROR NO EXISTE TAG TOCKEN NO SE PUEDE FIRMAR", eTipoError.ERROR_TRY, this.ToString());

                                   return false;

                               }


                           }


                           //logoneando el certificado 

                           if (IdAmbiente == "1")//pruebas 
                           {
                               Serivicio.SetParametroAmbiente(IdAmbiente);
                               Serivicio.SetParametroUrlWSAutorizacion(InfoParametros.url_ws_sri_Autorizacion_cbte_Prueba);
                               Serivicio.SetParametroUrlWSRecepcion(InfoParametros.url_ws_sri_Recep_cbte_Prueba);
                           }
                           if (IdAmbiente == "2")//producccion
                           {
                               Serivicio.SetParametroAmbiente(IdAmbiente);
                               Serivicio.SetParametroUrlWSAutorizacion(InfoParametros.url_ws_sri_Autorizacion_cbte_Produc);
                               Serivicio.SetParametroUrlWSRecepcion(InfoParametros.url_ws_sri_Recep_cbte_Produc);
                           }

                           if (InfoParametros.Usa_Proxy == true)
                           {
                               Serivicio.SetParametroProxyUrl((InfoParametros.Url_Proxy == null) ? "" : InfoParametros.Url_Proxy);
                               Serivicio.SetParametroProxyPass((InfoParametros.Password_Proxy == null) ? "" : InfoParametros.Password_Proxy);
                               Serivicio.SetParametroProxyUser((InfoParametros.Usuario_Proxy == null) ? "" : InfoParametros.Usuario_Proxy);
                               Serivicio.SetParametroProxyPort((InfoParametros.Port_Proxy == null) ? "" : InfoParametros.Port_Proxy.ToString());

                           }

                           switch (eTipoToquen)
                           {
                               case global::eTipoToquen.ANFCERTEXP:
                                   break;
                               case global::eTipoToquen.ANFPLUSIG:
                                   break;
                               case global::eTipoToquen.BCEALAETPR:
                                   break;
                               case global::eTipoToquen.BCEIKEY203:
                                   RespuestXmlLoginWS = Serivicio.Login(1, Patchcertificado, contrasenia_certificado);
                                   parametros_enviados_login = "RespuestXmlLoginWS = Serivicio.Login(1, Patchcertificado, contrasenia_certificado);" +
                                       " Patchcertificado=" + Patchcertificado + " contrasenia_certificado:" + contrasenia_certificado;
                                   break;
                               case global::eTipoToquen.SDBIOPASS3:
                                   break;
                               case global::eTipoToquen.SDEPAS3003:
                                   // tipo , serieTocekn , pasword
                                   RespuestXmlLoginWS = Serivicio.Login(3, IdSerieTocken, PasswordTocken);
                                   parametros_enviados_login = "RespuestXmlLoginWS = Serivicio.Login(3, IdSerieTocken, PasswordTocken); " +
                                       " IdSerieTocken=" + IdSerieTocken + " PasswordTocken=" + PasswordTocken;

                                   break;
                           }


                           


                           XmlDocument XmlRespuestaWsLogin = new XmlDocument();
                           XmlRespuestaWsLogin.LoadXml(Funciones.Formating_xml(RespuestXmlLoginWS));
                           SRespuestaLoginBoolWS = XmlRespuestaWsLogin.GetElementsByTagName("isSuccess")[0].InnerText;
                           SMensajeErrorWS = XmlRespuestaWsLogin.GetElementsByTagName("msgError")[0].InnerText;

                           HayErrores = false;


                           if (SRespuestaLoginBoolWS.ToUpper() == "FALSE")//NO  logoneo
                           {
                               MensajeError = SMensajeErrorWS;
                               HayErrores = true;
                               BusLogError.Log_Error(" NO LOGIN al optener la Autorizacion" + RespuestXmlLoginWS , eTipoError.WARNING, this.ToString());
                               return false;
                           }



                       }
                       catch (Exception ex)
                       {

                           BusLogError.Log_Error("catch (Exception ex) en secion de loging " + ex.Message.ToString()  , eTipoError.ERROR, this.ToString());
                       }


                       
                       if (SRespuestaLoginBoolWS.ToUpper() == "TRUE")//SI LOGONEO
                       {

                                    BusLogError.Log_Error("Login OK..", eTipoError.LOG, this.ToString());
                                   // se envia la clave de acceso
                                   string claveAcceso = xmlOrigen.GetElementsByTagName("claveAcceso")[0].InnerText;
                                   //opteniendo el file xml con la clave de acceso DEL WS SRI
                                   String RespuestaXml_Autorizado = Serivicio.GetAutorizacionWS(claveAcceso);

                                   SRespuestaBoolWS_Autorizacion = "";

                                
                                   XmlDocument XMlAutorizado = new XmlDocument();
                                   XMlAutorizado.LoadXml(RespuestaXml_Autorizado);
                                   SRespuestaBoolWS_Autorizacion = XMlAutorizado.GetElementsByTagName("isSuccess")[0].InnerText;

                                   if (SRespuestaBoolWS_Autorizacion.ToUpper() == "TRUE")//respuesta AUTORIZACION OK del ws true
                                   {

                                       int cant = XMlAutorizado.GetElementsByTagName("estado").Count;

                                       if (cant == 0)//no hay respuesta
                                       {

                                           BusLogError.Log_Error( " no hay respuesta de WS " +  XMlAutorizado.InnerXml , eTipoError.LOG, this.ToString(),"No hay respuesta ");


                                            ComprobanteData.ModificarDB(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,
                                                InfoComprobante_a_firmar.IdTipoDocumento, InfoComprobante_a_firmar.IdEstado_cbte, Funciones.Formating_xml(XMlAutorizado.InnerXml), "No hay respuesta", eIdEstadoProceso.PEND, ref MensajeError);

                                           //actualizo la respuesta del SRI de error del cbte enviado
                                           ComprobanteData.ModificarErrorDB(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,
                                               InfoComprobante_a_firmar.IdTipoDocumento, InfoComprobante_a_firmar.IdEstado_cbte, "", "", Funciones.Formating_xml(XMlAutorizado.InnerXml)
                                               , ref mensajeErroOut2);

                                       }
                                       else
                                       {

                                           BusLogError.Log_Error("si hay respuesta" +  XMlAutorizado.InnerXml, eTipoError.LOG, this.ToString(), "si de ws autorizacion hay respuesta ");


                                           #region Armando el tb_comprobante para almacenarlo en DB


                                           tb_Comprobante_Info InfoComprobanteAutorizado = new tb_Comprobante_Info();

                                           //cant : numero de cbtes pueden estar autorizados y no autorizados
                                           sMensaje_respuesta_ws_auto = "";
                                           sRespuesta_ws_estado = "";

                                           string SXml_a_Guardar = "";
                                           


                                           // si esta autorizado 

                                           XmlDocument XMLdoc_a_guardar = new XmlDocument();
                                           XMLdoc_a_guardar.CreateXmlDeclaration("1.0", "utf-8", "yes");


                                           try
                                           {

                                               XmlNode Nodo_xml_Autorizado = XMlAutorizado.GetElementsByTagName("numeroAutorizacion")[0].ParentNode;
                                               XmlNode copiedNode = XMLdoc_a_guardar.ImportNode(Nodo_xml_Autorizado, true);
                                               SXml_a_Guardar = "<?xml version=\"1.0\" encoding=\"utf-8\"?> ";
                                               SXml_a_Guardar = SXml_a_Guardar + " <autorizacion> ";
                                               SXml_a_Guardar = SXml_a_Guardar + copiedNode.InnerXml;
                                               SXml_a_Guardar = SXml_a_Guardar + " </autorizacion> ";
                                               XMLdoc_a_guardar.LoadXml(SXml_a_Guardar);

                                               XMLdoc_a_guardar.GetElementsByTagName("comprobante")[0].InnerText = "<![CDATA[" + "<?xml version=\"1.0\" encoding=\"utf-8\"?> " + XMLdoc_a_guardar.GetElementsByTagName("comprobante")[0].InnerText + "]]>";

                                               sXML_autorizado_SRI = XMLdoc_a_guardar.InnerXml;


                                              


                                               foreach (XmlNode item in Nodo_xml_Autorizado.ChildNodes)
                                               {
                                                   //item.Name
                                                   if (item.Name == "estado")
                                                   {
                                                       sRespuesta_ws_estado = item.InnerText;// AUTORIZADO
                                                   }

                                                   if (item.Name == "numeroAutorizacion")
                                                   {
                                                       numAutorizacion = item.InnerText;
                                                       InfoComprobanteAutorizado.Numero_Autorizacion = numAutorizacion;
                                                   }

                                                   if (item.Name == "fechaAutorizacion")
                                                   {
                                                       FechaAutorizacion = Convert.ToDateTime(item.InnerText);
                                                       InfoComprobanteAutorizado.FechaAutorizacion = FechaAutorizacion;
                                                   }

                                               }

                                           }
                                           catch (Exception ex)
                                           {
                                               //sRespuesta_ws_estado = XMlAutorizado.GetElementsByTagName("estado")[0].InnerText;// NO AUTORIZADO
                                               //sXML_autorizado_SRI = XMlAutorizado.GetElementsByTagName("autorizacion")[0].InnerXml;
                                               //sMensaje_respuesta_ws_auto = XMlAutorizado.GetElementsByTagName("informacionAdicional")[0].InnerText;

                                               XmlNodeList xmlNode_f;
                                               XmlNode xmlNode_msj;
                                               XmlNode xmlNode_Ultimo;
                                               XmlElement root = XMlAutorizado.DocumentElement;
                                               xmlNode_f = root.SelectNodes(@"//estado[.='NO AUTORIZADO']/..");//xpath para buscar los no autorizados
                                               xmlNode_Ultimo = xmlNode_f.Item(0);// encontrando el ultimo nodo no autorizado

                                               //creando xml para respuesta del RIDE
                                               XmlNode copiedNode = XMLdoc_a_guardar.ImportNode(xmlNode_Ultimo, true);


                                               SXml_a_Guardar = "<?xml version=\"1.0\" encoding=\"utf-8\"?> ";
                                               SXml_a_Guardar = SXml_a_Guardar + " <autorizacion> ";
                                               SXml_a_Guardar = SXml_a_Guardar + copiedNode.InnerXml;
                                               SXml_a_Guardar = SXml_a_Guardar + " </autorizacion> ";
                                               XMLdoc_a_guardar.LoadXml(SXml_a_Guardar);

                                               XMLdoc_a_guardar.GetElementsByTagName("comprobante")[0].InnerText = "<![CDATA[" + "<?xml version=\"1.0\" encoding=\"utf-8\"?> " + XMLdoc_a_guardar.GetElementsByTagName("comprobante")[0].InnerText + "]]>";


                                               sXML_autorizado_SRI = XMLdoc_a_guardar.InnerXml;



                                               XmlElement rootMens = XMLdoc_a_guardar.DocumentElement;
                                               xmlNode_msj = rootMens.SelectSingleNode(@"//mensajes");



                                               sMensaje_respuesta_ws_auto = xmlNode_msj.InnerXml;
                                               sRespuesta_ws_estado = "NO AUTORIZADO";



                                           }



                                           InfoComprobanteAutorizado.IdEmpresa = InfoComprobante_a_firmar.IdEmpresa;
                                           InfoComprobanteAutorizado.IdComprobante = InfoComprobante_a_firmar.IdComprobante;
                                           InfoComprobanteAutorizado.IdTipoDocumento = InfoComprobante_a_firmar.IdTipoDocumento;
                                           InfoComprobanteAutorizado.IdEstado_cbte = "VALI_&_FIRM_&_REC";
                                           InfoComprobanteAutorizado.Cedula_Ruc = InfoComprobante_a_firmar.Cedula_Ruc;
                                           InfoComprobanteAutorizado.RutaArchivo = null;
                                           InfoComprobanteAutorizado.Nombre_file = InfoComprobante_a_firmar.Nombre_file;
                                           InfoComprobanteAutorizado.s_XML = Funciones.Formating_xml(sXML_autorizado_SRI);
                                           InfoComprobanteAutorizado.Fecha_Emi_Fact = InfoComprobante_a_firmar.Fecha_Emi_Fact;
                                           InfoComprobanteAutorizado.Fecha_transaccion = DateTime.Now;
                                           InfoComprobanteAutorizado.ClaveContingencia = claveAcceso;
                                           InfoComprobanteAutorizado.EstadoDoc = sRespuesta_ws_estado;
                                           InfoComprobanteAutorizado.Error = sMensaje_respuesta_ws_auto;
                                           InfoComprobanteAutorizado.IdEstadoProceso = eIdEstadoProceso.PROCE.ToString();
                                           InfoComprobanteAutorizado.IdError_Sri = null;
                                           InfoComprobanteAutorizado.RespuestaSRI = "";
                                           InfoComprobanteAutorizado.Total = InfoComprobante_a_firmar.Total;
                                           InfoComprobanteAutorizado.Ambiente = InfoComprobante_a_firmar.Ambiente;
                                           InfoComprobanteAutorizado.Clave_Acceso = claveAcceso;

                                           #endregion

                                           if (ComprobanteData.GrabarDB(InfoComprobanteAutorizado, ref MensajeError))
                                           {

                                               //Grabar datos 

                                               BusLogError.Log_Error("Grabo y Modifico .. ComprobanteData.GrabarDB ok..", eTipoError.LOG, this.ToString());

                                               ///modifico el estado anterior
                                               ComprobanteData.ModificarDB(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,
                                                   InfoComprobante_a_firmar.IdTipoDocumento, InfoComprobante_a_firmar.IdEstado_cbte, "", "", eIdEstadoProceso.PROCE, ref mensajeErroOut2);
                                               //enviar correo si grabo en la base
                                               Envio_Cbte_x_correo(InfoComprobanteAutorizado, ListaCorreo, SNombreEmpresa, InfoComprobanteAutorizado.EstadoDoc, IdAmbiente, eTipoEnvioMail.NUEVO, "Optener_Autorizacion_WSJava", ref mensajeErroOut2);
                                           
                                           }
                                           
                                                                                      

                                       }

                                   }
                                   else// LA RESPUESTA FUE POR FALSE GRABO EL LOG DE ESA REPUESTA 
                                   {
                                       #region Log de Errores
                                       BusLogError.Log_Error("NO HAY RESPUESTA DE : Serivicio.GetAutorizacionWS(claveAcceso)" + RespuestaXml_Autorizado, eTipoError.LOG, this.ToString());
                                       #endregion
                                   }
                       }

                   }
                   catch (Exception ex)
                   {

                       #region Log de Errores
                       BusLogError.Log_Error(ex.Message + " " + MensajeError, eTipoError.ERROR, this.ToString());
                       #endregion

                       HayErrores = true;
                   }

               }//fin using

               return true;
           }
           catch (Exception ex)
           {

               #region Log de Errores
               MensajeError = ex.Message.ToString();
               BusLogError.Log_Error(MensajeError, eTipoError.ERROR, this.ToString());
               #endregion

               return false;
               HayErrores = true;

           }
       }
      
       private string optener_nombre_tipo_documento(string IdTipo)
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

       private void Envio_Cbte_x_correo(tb_Comprobante_Info InfoComprobante_a_firmar, List<mail_correos_Info> ListaCorreo,
           string SNombreEmpresa, string EstadoDoc_Auto_o_NoAuto, string IdAmbiente, eTipoEnvioMail STransaccion_q_envia, string SFuncion_q_envia, ref string mensajeErroOut)
       {

           try
           {             
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
               CuerpoMensaje = CuerpoMensaje + " Tr-Efirm:" + STransaccion_q_envia + " fx:" + SFuncion_q_envia;
               CuerpoMensaje = CuerpoMensaje + " version:" + param.Version;
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

               if (EstadoDoc_Auto_o_NoAuto  == "AUTORIZADO" && IdAmbiente == "2")
               {

                   if (Bus_Archivo_Adjunto.Verificar_Correo_Existe(InfoComprobante_a_firmar.IdEmpresa, InfoComprobante_a_firmar.IdComprobante,ref mensajeErroOut))
                   {
                       return;
                   }

                   if (ListaCorreo.Count > 0)// si hay correo envio con ese correo 
                   {
                           foreach (var itemCorreo in ListaCorreo)
                           {
                               InfoMail.Para = itemCorreo.correo_principal;
                               InfoMail.Para_CC = "";
                               int Count = 1;

                               foreach (var itemCorreoCC in itemCorreo.correos_copia)
                               {
                                   if (Count == 1)
                                   {
                                       InfoMail.Para_CC = itemCorreoCC;
                                       Count++;
                                   }
                                   else
                                   {
                                       InfoMail.Para_CC = InfoMail.Para_CC + "; " + itemCorreoCC;
                                   }
                               }

                               BusMail.GrabarMensajeDB(InfoMail, ref mensajeErroOut);
                               Envio_Correo_al_cliente = true;
                           }

                   }
                   else // envio un solo correo con el mail de contribuyente 
                   {
                       InfoMail.Para = InfoContibuyente.Mail;
                       BusMail.GrabarMensajeDB(InfoMail, ref mensajeErroOut);
                       Envio_Correo_al_cliente = true;
                   }


                   string notificacion = "";
                   
                   if (Envio_Correo_al_cliente == true)// solo si envio correo al cliente envio una copia
                   {

                       if (InfoCta_remitente.enviar_copia_x_cada_mail_enviado == true)
                       {
                           


                           try
                           {
                               
                               System.Net.Mail.MailAddress mail = new System.Net.Mail.MailAddress(InfoMail.Para);
                               
                           }
                           catch (Exception ex)
                           {
                               notificacion = "Noti.Error mail NO ENVIADO.. direc. destino INVALIDA Para:[" + InfoMail.Para + "]";
                           }

                           InfoMail.Para = InfoCta_remitente.cta_mail_para_envio_x_cbte_enviado;
                           InfoMail.Asunto =notificacion +  "Copia.." + InfoMail.Asunto;
                           BusMail.GrabarMensajeDB(InfoMail, ref mensajeErroOut);
                       }
                   }

               }

                  else if(EstadoDoc_Auto_o_NoAuto == "NO AUTORIZADO")
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

    }
}
