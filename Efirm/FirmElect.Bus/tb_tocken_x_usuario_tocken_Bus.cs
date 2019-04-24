using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirmElect.Info;
using FirmElect.Data;

namespace FirmElect.Bus
{
  public  class tb_tocken_x_usuario_tocken_Bus
    {

      tb_tocken_x_usuario_tocken_Data odata = new tb_tocken_x_usuario_tocken_Data();

      public List<tb_tocken_x_usuario_tocken_Info> ConsultaTockenUsuario()
      {
         
          try
          {

              return odata.ConsultaTockenUsuario();
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

              return new List<tb_tocken_x_usuario_tocken_Info>();
          }
      }

    }
}
