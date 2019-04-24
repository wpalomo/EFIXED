using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
  public   class mail_Horario_envio_recepcion_Bus
    {

      mail_Horario_envio_recepcion_Data Odata ;

      public mail_Horario_envio_recepcion_Bus()
      {
          Odata = new mail_Horario_envio_recepcion_Data();
      }

      public mail_Horario_envio_recepcion_Info consultar(ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar(ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new mail_Horario_envio_recepcion_Info();

          }
      }



    }
}
