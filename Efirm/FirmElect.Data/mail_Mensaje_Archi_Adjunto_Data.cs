using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;
namespace FirmElect.Data
{
    /// <summary>
    /// /////sldlsmldsmd
    /// </summary>
   public class mail_Mensaje_Archi_Adjunto_Data:Imail_Mensaje_Archi_Adjunto_Data
    {


       public bool EmailGuardarArchivoAdjunto(mail_Mensaje_Archi_Adjunto_Info infoAdjunto, ref string mensajeError)
        {
            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    var Reg_a_Guardar = new mail_Mensaje_Archi_Adjunto();
                    Reg_a_Guardar.IdMensaje = infoAdjunto.IdMensaje;
                    Reg_a_Guardar.Secuencia = infoAdjunto.Secuencia;
                    Reg_a_Guardar.Archivo_adjunto = infoAdjunto.Archivo_adjunto;
                    Reg_a_Guardar.descripcion_archi = infoAdjunto.descripcion_archi;
                    Reg_a_Guardar.extencion = infoAdjunto.extensionArchivo;
                    Reg_a_Guardar.IdComprobante = infoAdjunto.IdComprobante;
                    Reg_a_Guardar.IdEmpresa = infoAdjunto.IdEmpresa; 

                    conexion.mail_Mensaje_Archi_Adjunto.Add(Reg_a_Guardar);
                    conexion.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
                return false;
            }       
        }

       public int SecuenciaArchivoAdjunto()
        {


            int Id = 0;
            try
            {
                EntitiesFactElectronica contex = new EntitiesFactElectronica();
                var selecte = contex.mail_Mensaje_Archi_Adjunto.Count();

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.mail_Mensaje_Archi_Adjunto
                                     select q.IdMensaje).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {

                return 0;
            }
        
        }
      
       public List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto_Mensaje_x_comprobante(Decimal idMensaje, ref string mensajeError)
        {
            try
            {
                List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    var registros = (from q in conexion.mail_Mensaje_Archi_Adjunto
                                     where q.IdMensaje == idMensaje
                                     && q.IdComprobante!=null
                                     && q.IdComprobante != ""
                                     && q.IdEmpresa>0
                                     select q);
                    foreach (var item in registros)
                    {
                        mail_Mensaje_Archi_Adjunto_Info infoAdjunto = new mail_Mensaje_Archi_Adjunto_Info();
                        infoAdjunto.IdMensaje = item.IdMensaje;
                        infoAdjunto.Secuencia = item.Secuencia;
                        infoAdjunto.Archivo_adjunto = item.Archivo_adjunto;
                        infoAdjunto.descripcion_archi = item.descripcion_archi;
                        infoAdjunto.extensionArchivo = item.extencion;
                        infoAdjunto.IdComprobante = item.IdComprobante;
                        infoAdjunto.IdEmpresa = (item.IdEmpresa == null) ? 0 : Convert.ToInt32(item.IdEmpresa);


                        infoAdjunto.MosTrar_icono_Imprimir = true;
                        infoAdjunto.MosTrar_icono_Descargar = true;

                        Lista_ArchivoAdjunto.Add(infoAdjunto);
                       
                    }
                    return Lista_ArchivoAdjunto;
                }


               
            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
                return new List<mail_Mensaje_Archi_Adjunto_Info>();
            }

        }

       public List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto_x_IdMensaje(Decimal idMensaje, ref string mensajeError)
       {
           try
           {
               List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {
                   var registros = (from q in conexion.mail_Mensaje_Archi_Adjunto
                                    where q.IdMensaje == idMensaje
                                   
                                    select q);
                   foreach (var item in registros)
                   {
                       mail_Mensaje_Archi_Adjunto_Info infoAdjunto = new mail_Mensaje_Archi_Adjunto_Info();
                       infoAdjunto.IdMensaje = item.IdMensaje;
                       infoAdjunto.Secuencia = item.Secuencia;
                       infoAdjunto.Archivo_adjunto = item.Archivo_adjunto;
                       infoAdjunto.descripcion_archi = item.descripcion_archi;
                       infoAdjunto.extensionArchivo = item.extencion;
                       infoAdjunto.IdComprobante = item.IdComprobante;
                       infoAdjunto.IdEmpresa = (item.IdEmpresa == null) ? 0 : Convert.ToInt32(item.IdEmpresa);


                       infoAdjunto.MosTrar_icono_Imprimir = true;
                       infoAdjunto.MosTrar_icono_Descargar = true;

                       Lista_ArchivoAdjunto.Add(infoAdjunto);

                   }
                   return Lista_ArchivoAdjunto;
               }



           }
           catch (Exception ex)
           {
               mensajeError = ex.InnerException + " " + ex.Message;

               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
               return new List<mail_Mensaje_Archi_Adjunto_Info>();
           }

       }

       public List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto(ref string mensajeError)
       {
           try
           {
               List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {
                   var registros = (from q in conexion.mail_Mensaje_Archi_Adjunto
                                   
                                    select q);
                   foreach (var item in registros)
                   {
                       mail_Mensaje_Archi_Adjunto_Info infoAdjunto = new mail_Mensaje_Archi_Adjunto_Info();
                       infoAdjunto.IdMensaje = item.IdMensaje;
                       infoAdjunto.Secuencia = item.Secuencia;
                       infoAdjunto.Archivo_adjunto = item.Archivo_adjunto;
                       infoAdjunto.descripcion_archi = item.descripcion_archi;
                       infoAdjunto.extensionArchivo = item.extencion;
                       infoAdjunto.IdComprobante = item.IdComprobante;
                       infoAdjunto.IdEmpresa = (item.IdEmpresa == null) ? 0 : Convert.ToInt32(item.IdEmpresa);

                       infoAdjunto.MosTrar_icono_Imprimir = true;
                       infoAdjunto.MosTrar_icono_Descargar = true;


                       Lista_ArchivoAdjunto.Add(infoAdjunto);

                   }
                   return Lista_ArchivoAdjunto;
               }



           }
           catch (Exception ex)
           {
               mensajeError = ex.InnerException + " " + ex.Message;

               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
               return new List<mail_Mensaje_Archi_Adjunto_Info>();
           }

       }

       public bool Tiene_Adjunto_Null_x_Comprobante(Decimal idMensaje, ref string mensajeError)
       {
           bool BSi_Null = false;
           try
           {
               List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {
                   var registros = (from q in conexion.mail_Mensaje_Archi_Adjunto
                                    where q.IdMensaje == idMensaje
                                    select q);
                   
                   foreach (var item in registros)
                   {
                       if(item.Archivo_adjunto==null && item.IdComprobante!=null && item.IdEmpresa!=null)
                       {                          
                           BSi_Null =true;
                           break;
                       }
                   }                 
               }
               return BSi_Null;
           }
           catch (Exception ex)
           {
               mensajeError = ex.InnerException + " " + ex.Message;
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
               return false;
           }
           
       }

       public bool Actualizar_Archivo_Adjuno(List<mail_Mensaje_Archi_Adjunto_Info> ArchivoAdjunto, ref string mensajeError)
       {

           try
           {

               using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
               {
                   foreach (var item in ArchivoAdjunto)
                   {
                       var Reg_a_Modificar = oEnti.mail_Mensaje_Archi_Adjunto.First(var =>var.IdEmpresa==item.IdEmpresa &&  var.IdComprobante == item.IdComprobante &&  var.Secuencia == item.Secuencia && var.IdMensaje==item.IdMensaje);
                       Reg_a_Modificar.Archivo_adjunto = item.Archivo_adjunto;
                       Reg_a_Modificar.descripcion_archi = item.descripcion_archi;
                       Reg_a_Modificar.extencion = item.extensionArchivo;
                       oEnti.SaveChanges();
                   }
               }

               return true;

           }
           catch (Exception ex)
           {
               mensajeError = ex.InnerException + " " + ex.Message;

               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
               return false;
           }
       }

       public bool Verificar_Correo_Existe_x_cbte_Autorizado(int IdEmpresa, string IdComprobante, ref string mensajeError)
       {
           bool B_Si_Existe_Correo = false;
           try
           {
               

               List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {
                   var registros = (from q in conexion.mail_Mensaje_Archi_Adjunto
                                    where q.IdComprobante == IdComprobante
                                    && q.IdEmpresa==IdEmpresa
                                    select q.IdComprobante);


                   if (registros.Count() > 1)
                   {


                       var registro_auto = (from q in conexion.vw_Comprobante
                                        where q.IdComprobante == IdComprobante
                                        && q.IdEmpresa == IdEmpresa
                                        && q.EstadoDoc=="AUTORIZADO"
                                        select q.IdComprobante);

                       if (registro_auto.Count() > 1)
                       {
                           B_Si_Existe_Correo = true;
                       }
                       else
                       {
                           B_Si_Existe_Correo = false;
                       }
                   }

               }
               return B_Si_Existe_Correo ;

           }
           catch (Exception)
           {

               return B_Si_Existe_Correo;
           }
       }

      
     
      
    }
}

