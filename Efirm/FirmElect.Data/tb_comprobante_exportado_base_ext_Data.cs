using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;

namespace FirmElect.Data
{
   public  class tb_comprobante_exportado_base_ext_Data
    {
       public List<tb_comprobante_exportado_base_ext_Info> consultar(ref string MensajeError)
       {
           try
           {
               List<tb_comprobante_exportado_base_ext_Info> lista = new List<tb_comprobante_exportado_base_ext_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   conexion.Database.CommandTimeout = 3000;


                   var q = from C in conexion.tb_comprobante_exportado_base_ext
                           select C;
                   foreach (var item in q)
                   {
                       tb_comprobante_exportado_base_ext_Info infoC = new tb_comprobante_exportado_base_ext_Info();

                       infoC.IdEmpresa = item.IdEmpresa;
                       infoC.IdComprobante = item.IdComprobante;
                       infoC.IdTipoDocumento = item.IdTipoDocumento;
                       infoC.fecha_hora_exportacion = item.fecha_hora_exportacion;
                       infoC.observacion = item.observacion;

                       lista.Add(infoC);

                       MensajeError = "Proceso OK";
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               
               MensajeError = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

               return new List<tb_comprobante_exportado_base_ext_Info>();
           }
       
       }

       public Boolean GrabarDB(tb_comprobante_exportado_base_ext_Info Comprobante_info, ref string MensajeError)
       {
           try
           {
               using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
               {

                   var Address = new tb_comprobante_exportado_base_ext();

                   Address.IdEmpresa = Comprobante_info.IdEmpresa;
                   Address.IdComprobante = Comprobante_info.IdComprobante;
                   Address.IdTipoDocumento = Comprobante_info.IdTipoDocumento;
                   Address.observacion = Comprobante_info.observacion;
                   Address.fecha_hora_exportacion = DateTime.Now;
                   Context.tb_comprobante_exportado_base_ext.Add(Address);
                   Context.SaveChanges();
                   MensajeError = "Proceso OK";

               }

               return true;
           }
           catch (Exception ex)
           {
               MensajeError = ex.InnerException + " " + ex.Message;
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, MensajeError, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               return false;
           }
            
       }
      
   }
}
