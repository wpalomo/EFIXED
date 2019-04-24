using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
   public  class tb_Comprobante_tipo_Data
    {

       public List<tb_Comprobante_tipo_Info> consultar(int IdEmpresa, ref string mensajeErrorOut)
       {

           try
           {
               List<tb_Comprobante_tipo_Info> lista_cuentas = new List<tb_Comprobante_tipo_Info>();

               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   var q = from C in conexion.vw_Comprobante_Tipo
                           where C.IdEmpresa == IdEmpresa
                           select C;


                   foreach (var item in q)
                   {
                       tb_Comprobante_tipo_Info InfoComprobantes_tipo = new tb_Comprobante_tipo_Info();

                       InfoComprobantes_tipo.IdComprobante_tipo = item.IdComprobante_tipo;
                       InfoComprobantes_tipo.descripcion_tipo = item.descripcion_tipo;
                       InfoComprobantes_tipo.cod_tipo = item.cod_tipo;
                       InfoComprobantes_tipo.IdComprobante = item.IdComprobante_tipo;
                       InfoComprobantes_tipo.ReporteBy = item.File_disenio_rpt;
                       InfoComprobantes_tipo.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                       InfoComprobantes_tipo.Empresa = item.RazonSocial;
                       lista_cuentas.Add(InfoComprobantes_tipo);
                   }

               }

               return lista_cuentas;


           }
           catch (Exception ex)
           {


               string mensaje = "";
               mensaje = ex.InnerException + " " + ex.Message;

               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

               return new List<tb_Comprobante_tipo_Info>();
           }
       }

       public List<tb_Comprobante_tipo_Info> consultar(ref string mensajeErrorOut)
       {

           try
           {
               List<tb_Comprobante_tipo_Info> lista_cuentas = new List<tb_Comprobante_tipo_Info>();

               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   var q = from C in conexion.vw_Comprobante_Tipo
                           select C;


                   foreach (var item in q)
                   {
                       tb_Comprobante_tipo_Info InfoComprobantes_tipo = new tb_Comprobante_tipo_Info();

                       InfoComprobantes_tipo.IdComprobante_tipo = item.IdComprobante_tipo;
                       InfoComprobantes_tipo.descripcion_tipo = item.descripcion_tipo;
                       InfoComprobantes_tipo.cod_tipo = item.cod_tipo;
                       InfoComprobantes_tipo.IdComprobante = item.IdComprobante_tipo;
                       InfoComprobantes_tipo.ReporteBy = item.File_disenio_rpt;
                       InfoComprobantes_tipo.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                       InfoComprobantes_tipo.Empresa = item.RazonSocial;
                       lista_cuentas.Add(InfoComprobantes_tipo);
                   }

               }

               return lista_cuentas;


           }
           catch (Exception ex)
           {


               string mensaje = "";
               mensaje = ex.InnerException + " " + ex.Message;

               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

               return new List<tb_Comprobante_tipo_Info>();
           }
       }

       public List<tb_Comprobante_tipo_Info> consultar_solo_comprobantes(ref string mensajeErrorOut)
       {
           try
           {
               List<tb_Comprobante_tipo_Info> lista_cuentas = new List<tb_Comprobante_tipo_Info>();

               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   var q = from C in conexion.tb_Comprobante_tipo
                           select C;


                   foreach (var item in q)
                   {
                       tb_Comprobante_tipo_Info InfoComprobantes_tipo = new tb_Comprobante_tipo_Info();

                       InfoComprobantes_tipo.IdComprobante_tipo = item.IdComprobante_tipo;
                       InfoComprobantes_tipo.cod_tipo = item.cod_tipo;
                       InfoComprobantes_tipo.descripcion_tipo = item.descripcion_tipo;
                       lista_cuentas.Add(InfoComprobantes_tipo);
                   }

               }

               return lista_cuentas;


           }
           catch (Exception ex)
           {


               string mensaje = "";
               mensaje = ex.InnerException + " " + ex.Message;

               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

               return new List<tb_Comprobante_tipo_Info>();
           }
       }

       public Boolean ModificarDB(tb_Comprobante_tipo_Info info, ref string MensajeErrorOut)
       {
           try
           {
               using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
               {
                   EntitiesFactElectronica param = new EntitiesFactElectronica();
                   var select = (from C in param.tb_Comprobante_tipo
                                        where C.IdComprobante_tipo == info.IdComprobante_tipo 
                                        select C).Count();

                   if (select == 0)
                   {

                       tb_Comprobante_tipo addressG = new tb_Comprobante_tipo();
                       addressG.IdComprobante_tipo = info.IdComprobante_tipo;
                       addressG.descripcion_tipo = info.descripcion_tipo;
                       addressG.cod_tipo = info.cod_tipo;

                       oEnti.tb_Comprobante_tipo.Add(addressG);   
                       oEnti.SaveChanges();
                   }
                   else
                   {
                       var contact = oEnti.tb_Comprobante_tipo.First(var => var.IdComprobante_tipo == info.IdComprobante_tipo );
                       contact.IdComprobante_tipo = info.IdComprobante_tipo;
                       contact.descripcion_tipo = info.descripcion_tipo;
                       contact.cod_tipo = info.cod_tipo;

                       oEnti.SaveChanges();
                   }
               }
               return true;
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

       public tb_Comprobante_tipo_Info consultar_tipo(int IdEmpresa, string idDocumento, ref string mensajeErrorOut)
       {

           try
           {
               tb_Comprobante_tipo_Info infoTipoComprobante = new tb_Comprobante_tipo_Info();


               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   var q = from C in conexion.vw_Comprobante_Tipo
                           where C.IdComprobante_tipo==idDocumento
                           && C.IdEmpresa == IdEmpresa
                           select C;


                   foreach (var item in q)
                   {
                       infoTipoComprobante.IdEmpresa =Convert.ToInt32( item.IdEmpresa);
                       infoTipoComprobante.IdComprobante_tipo = item.IdComprobante_tipo;
                       infoTipoComprobante.descripcion_tipo = item.descripcion_tipo;
                       infoTipoComprobante.cod_tipo = item.cod_tipo;
                       infoTipoComprobante.ReporteBy = item.File_disenio_rpt;

                       
                   }

               }

               return infoTipoComprobante;


           }
           catch (Exception ex)
           {


               string mensaje = "";
               mensaje = ex.InnerException + " " + ex.Message;

               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

               return new tb_Comprobante_tipo_Info();
           }
       }

    }
}
