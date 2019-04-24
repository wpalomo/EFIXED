using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
   public class tb_directorio_Data
    {

       public Boolean GuardarDB(tb_directorio_Info Info, ref string MensajeErrorOut)
       {
           try
           {
               using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
               {
                   var Address = new tb_directorio();


                   Address.IdTipoDirectorio = Info.IdTipoDirectorio;
                   Address.Ruta_directorio= Info.Ruta_directorio;

                   oEnti.tb_directorio.Add(Address);
                   oEnti.SaveChanges();
               }
               return true;
           }
           catch (Exception ex)
           {
               //string MensajeErrorOut = "";
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;

               return false;
           }
       }


       public Boolean ModificarDB(tb_directorio_Info info, ref string MensajeErrorOut)
       {
           try
           {
               using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
               {
                   var contact = oEnti.tb_directorio.First(var => var.IdTipoDirectorio== info.IdTipoDirectorio);

                   contact.Ruta_directorio = info.Ruta_directorio;
                   
                   oEnti.SaveChanges();
               }
               return true;
           }
           catch (Exception ex)
           {
               // string MensajeErrorOut = "";
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;
               return false;
           }
       }


       public List<tb_directorio_Info> Consultar(ref string MensajeErrorOut)
       {
           try
           {
               List<tb_directorio_Info> Empresas = new List<tb_directorio_Info>();
               EntitiesFactElectronica OEselecEmpresa = new EntitiesFactElectronica();
               var selectEmpresa = from C in OEselecEmpresa.tb_directorio
                                   select C;

               foreach (var item in selectEmpresa)
               {
                   tb_directorio_Info Cbt = new tb_directorio_Info();

                   Cbt.IdTipoDirectorio = item.IdTipoDirectorio;
                   Cbt.Ruta_directorio = item.Ruta_directorio;

                   Empresas.Add(Cbt);
               }
               return Empresas;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;

               return new List<tb_directorio_Info>();
           }
       }

    }
}
