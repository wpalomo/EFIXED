using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
   public class tb_Contribuyente_Bus
    {
       Itb_Contribuyente_Data OData;


       public tb_Contribuyente_Bus()
       {
           OData=new tb_Contribuyente_Data();
       }


       public bool GuardarDB(Info.tb_Contribuyente_Info InfoContribuyente, ref string MensajeErrorOut)
       {
           try
           {
               return OData.GuardarDB(InfoContribuyente, ref MensajeErrorOut);
           }
           catch (Exception ex)
           {

               return false;
           }
       }


       public Boolean ModificarDB_x_WEB(int IdEmpresa, string cedulaRuc, string Password
          , string mail, ref string mensajeErrorOut)
       {
           try
           {
               return OData.ModificarDB_x_WEB(IdEmpresa, cedulaRuc,Password,mail,ref mensajeErrorOut);
           }
           catch (Exception ex)
           {

               return false;
           }
       }


       public List<tb_Contribuyente_Info> GetContribuyente(int IdEmpresa, string cedulaRuc, string password, ref string MensajeErrorOut)
       {
           try
           {

               return OData.GetContribuyente(IdEmpresa, cedulaRuc, password, ref MensajeErrorOut);
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;

               return new List<tb_Contribuyente_Info>();
           }
       }



    public tb_Contribuyente_Info GetContribuyente_Info(int IdEmpresa, string cedulaRuc, ref string MensajeErrorOut)
       {
           try
           {
               return OData.GetContribuyente_Info(IdEmpresa, cedulaRuc, ref MensajeErrorOut);
           }
           catch (Exception ex)
           {
               
                string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;

               return new tb_Contribuyente_Info();
           }             
       }


       public Boolean Modificar_GetContribuyente_Info(int IdEmpresa, string cedulaRuc, string mail, string password, ref string MensajeErrorOut)
       {

           try
           {
               return OData.Modificar_GetContribuyente_Info(IdEmpresa, cedulaRuc,mail, password, ref MensajeErrorOut);
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;

               return false;
           }                  
       }
    
 

       public List<tb_Contribuyente_Info> GetListContribuyente(ref string MensajeErrorOut )
       {

           try
           {

               return OData.GetListContribuyente(ref MensajeErrorOut);
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;

               return new List<tb_Contribuyente_Info>();
           }
       }



       public bool ModificarDB(tb_Contribuyente_Info infoContribuyente, ref string MensajeErrorOut)
       {
           try
           {

               return OData.ModificarDB(infoContribuyente,ref MensajeErrorOut);
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;

               return false;
           }
       }



       public sp_Registro_Contribuyente_Info Registrar_Contribuyente(int IdEmpresa, String CedulaRUc, String TipoComprobantes, String NumComprobante
           , String Correo, String Contrasenia, String link_registro, ref String mensajeErrorOut)
       {
           try
           {
              

               tb_Empresa_Bus BusEmp = new tb_Empresa_Bus();
               tb_Empresa_Info InfoEmpresa = new tb_Empresa_Info();
               InfoEmpresa=BusEmp.GetEmpresa(IdEmpresa, ref mensajeErrorOut);

               sp_Registro_Contribuyente_Info respuestaRegistro =OData.Registrar_Contribuyente(IdEmpresa,CedulaRUc, TipoComprobantes, NumComprobante, Correo,
                   Contrasenia, link_registro, ref mensajeErrorOut);


               string sTipoCbt = "";

               switch (TipoComprobantes)
               {
                   case "01": sTipoCbt = "FACTURA";
                       break;
                   case "04": sTipoCbt = "NOTA CREDITO";
                       break;
                   case "05": sTipoCbt = "NOTA DEBITO";
                       break;
                   case "06": sTipoCbt = "GUIA REMISION";
                       break;
                   case "07": sTipoCbt = "RETENCION";
                       break;
               }

               if (respuestaRegistro.Respuesta == "True")
               {
                   string sMensaje = "Estimado(a) cliente:\n"  ;

                   sMensaje = sMensaje + InfoEmpresa.RazonSocial + " le informa que usted se a registrado con el comprobante electrónico: " + sTipoCbt +" #: " + NumComprobante;
                   sMensaje = sMensaje + " Para finalizar su registro acceda al siguiente enlace:" + link_registro + respuestaRegistro.HashText;
                   sMensaje = sMensaje +  " \n\n";
                   sMensaje = sMensaje + " Favor no responder a este correo.";
                   sMensaje = sMensaje + " \n\n";

                   
                   mail_Mensaje_Bus mail_b = new mail_Mensaje_Bus();
                   mail_Mensaje_Info itemCorreo = new mail_Mensaje_Info();
                   itemCorreo.Asunto = "Bienvenido ***Validacion Cuenta**";
                   itemCorreo.Fecha = DateTime.Now;
                   itemCorreo.Asunto_texto_mostrado = link_registro + respuestaRegistro.HashText;
                   itemCorreo.Para = Correo;
                   itemCorreo.Tiene_Adjunto = false;
                   itemCorreo.Texto_mensaje = sMensaje;
                   itemCorreo.InfoContribuyente.IdEmpresa = IdEmpresa;
                   itemCorreo.InfoContribuyente.IdContribuyente = respuestaRegistro.IdContribuyente;
                   itemCorreo.IdTipo_Mensaje = eTipoMail.Buzon_Sal;





                   mail_Cuentas_Correo_x_Empresa_Bus BusCtasxCorreo_x_empresa = new mail_Cuentas_Correo_x_Empresa_Bus();
                   List<mail_Cuentas_Correo_x_Empresa_Info> lista = new List<mail_Cuentas_Correo_x_Empresa_Info>();
                   lista = BusCtasxCorreo_x_empresa.Consulta_mail_Cuentas_Correo_x_Empresa(ref mensajeErrorOut);


                   var InfoEmpresa_x_cta = lista.FirstOrDefault(v => v.IdEmpresa == IdEmpresa);

                   itemCorreo.IdCuenta = InfoEmpresa_x_cta.IdCuenta;
                   itemCorreo.mail_remitente = InfoEmpresa_x_cta.direccion_correo;


                   mail_b.GrabarMensajeDB(itemCorreo, ref mensajeErrorOut);


                   if (mail_b.Enviar_Correo(itemCorreo, ref mensajeErrorOut) == false)
                   {
                       respuestaRegistro.Mensaje = respuestaRegistro.Mensaje + " " + mensajeErrorOut;
                       respuestaRegistro.Respuesta = "false";
                   }
               }
               return respuestaRegistro;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
               mensajeErrorOut = ex.InnerException + " " + ex.Message;

               return new  sp_Registro_Contribuyente_Info();
           }
       }
       public sp_ValidarRegistros_Info sp_ValidarRegistros(int IdEmpresa, String HashText, ref String mensajeErrorOut)
       {
           try
           {
               return OData.sp_ValidarRegistros(IdEmpresa, HashText, ref mensajeErrorOut);
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
               mensajeErrorOut = ex.InnerException + " " + ex.Message;

               return new sp_ValidarRegistros_Info();
           }
       }

       public sp_RecuperaciondeContraseña_Info sp_RecuperaciondeContraseña(int IdEmpresa, string CedulaRuc, string Link, ref string mensajeErrorOut)
       {
           try
           {


               
               
               sp_RecuperaciondeContraseña_Info result = OData.sp_RecuperaciondeContraseña(IdEmpresa, CedulaRuc, ref mensajeErrorOut);

               
              


               string sMensaje = "Estimado(a) cliente:\n";

               sMensaje = sMensaje + " Para recuperar su contraseña acceda al siguiente enlace:" + Link + result.HashText;
               sMensaje = sMensaje + " \n\n";
               sMensaje = sMensaje + " Favor no responder a este correo.";
               sMensaje = sMensaje + " \n\n";




               mail_Mensaje_Bus mail_b = new mail_Mensaje_Bus();
               mail_Mensaje_Info itemCorreo = new mail_Mensaje_Info();
               itemCorreo.Asunto = "**Recuperacion contraseña**";
               itemCorreo.Fecha = DateTime.Now;
               itemCorreo.Asunto_texto_mostrado = Link + result.HashText;
               itemCorreo.Para = (result.CorreoContribuyente == null) ? "" : result.CorreoContribuyente;
               itemCorreo.Tiene_Adjunto = false;
               itemCorreo.Texto_mensaje = sMensaje;
               itemCorreo.InfoContribuyente.IdEmpresa = IdEmpresa;
               itemCorreo.InfoContribuyente.IdContribuyente = result.IdContribuyente;
               itemCorreo.IdTipo_Mensaje = eTipoMail.Buzon_Sal;
               

               mail_Cuentas_Correo_x_Empresa_Bus BusCtasxCorreo_x_empresa= new mail_Cuentas_Correo_x_Empresa_Bus();
               List<mail_Cuentas_Correo_x_Empresa_Info> lista= new List<mail_Cuentas_Correo_x_Empresa_Info>();
               lista = BusCtasxCorreo_x_empresa.Consulta_mail_Cuentas_Correo_x_Empresa(ref mensajeErrorOut);


              var InfoEmpresa_x_cta= lista.FirstOrDefault(v => v.IdEmpresa == IdEmpresa);

              itemCorreo.IdCuenta = InfoEmpresa_x_cta.IdCuenta;
              itemCorreo.mail_remitente = InfoEmpresa_x_cta.direccion_correo;


              mail_b.GrabarMensajeDB(itemCorreo, ref mensajeErrorOut);

               if (mail_b.Enviar_Correo(itemCorreo, ref mensajeErrorOut)==false)
               {
                   result.Respuesta = "False";
                   result.Mensaje = "no se ha podido enviar el correo ... error efirm de envio:" + mensajeErrorOut;
               }


               return result;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
               mensajeErrorOut = ex.InnerException + " " + ex.Message;

               sp_RecuperaciondeContraseña_Info resError= new sp_RecuperaciondeContraseña_Info();
               resError.Respuesta = "False";
               resError.Mensaje = "Errot try:" + mensajeErrorOut;
               return resError;
           }
       }

       public tb_Contribuyente_Info sp_VerificarRecuperaciondeContrasenia(int IdEmpresa, string HashText, ref string mensajeErrorOut)
       {
           try
           {
               return OData.sp_VerificarRecuperaciondeContrasenia(IdEmpresa, HashText, ref mensajeErrorOut);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return new tb_Contribuyente_Info();
           }
       }


    }
}
