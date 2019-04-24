using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirmElect.Info;
using FirmElect.Data;

namespace FirmElect.Bus
{
  public  class tb_Catalogo_Bus
    {
      tb_Catalogo_Data odata = new tb_Catalogo_Data();

        public List<tb_Catalogo_Info> Consulta_Catalogo_x_IdTipoCatalogo(int IdTipoCatalogo)
      {
          try
          {

              return odata.Consulta_Catalogo_x_IdTipoCatalogo(IdTipoCatalogo);
          }
          catch (Exception ex)
          {
              string MensajeErrorOut = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR_TRY, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
              MensajeErrorOut = ex.InnerException + " " + ex.Message;

              return new List<tb_Catalogo_Info>();
          }
      }

        public List<tb_Catalogo_Info> Lista_TipoComprobantes(ref string MensajeErrorOut)
        {
            try
            {
                return odata.Lista_TipoComprobantes(ref  MensajeErrorOut);
            }
            catch (Exception ex)
            {
                
                // string MensajeErrorOut = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR_TRY, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
              MensajeErrorOut = ex.InnerException + " " + ex.Message;

              return new List<tb_Catalogo_Info>();
            }
        
        
        
        }


      
    }
}
