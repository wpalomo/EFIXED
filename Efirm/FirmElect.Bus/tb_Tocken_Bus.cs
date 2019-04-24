using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

using FirmElect.Data;
using FirmElect.Info;

namespace FirmElect.Bus
{
  public  class tb_Tocken_Bus
    {

      tb_Tocken_Data odata = new tb_Tocken_Data();

      public Boolean GuardarDB(List<tb_Tocken_Info> lista, ref string MensajeErrorOut)  
        {
            try
            {
                return odata.GuardarDB(lista, ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                //string MensajeErrorOut = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return false;
            }
        }

      public Boolean ModificarDB(tb_Tocken_Info info, ref string MensajeErrorOut)
       {
           try
           {
               return odata.ModificarDB(info, ref MensajeErrorOut); ;
           }
           catch (Exception ex)
           {
             //  string MensajeErrorOut = "";
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;
               return false;
           }
       }

      public Boolean AnularDB(tb_Tocken_Info info, ref string MensajeErrorOut)
       {
           try
           {
               return odata.AnularDB(info, ref MensajeErrorOut);
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

      public List<tb_Tocken_Info> ConsulTocken(ref string MensajeErrorOut)
        {           
            try
            {
                return odata.ConsulTocken(ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
              //  string MensajeErrorOut = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return new List<tb_Tocken_Info>();
            }
        }

        public Boolean EliminarDB()
        {
            try
            {
                return odata.EliminarDB();
            }
            catch (Exception ex)
            {

                string MensajeErrorOut = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return false;
            }

        }

    }
}
