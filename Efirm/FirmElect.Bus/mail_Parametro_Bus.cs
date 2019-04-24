using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
  public  class mail_Parametro_Bus
    {
      mail_Parametro_Data Odata;

      public mail_Parametro_Bus()
      {
          Odata = new mail_Parametro_Data();

      }

      public mail_Parametro_Info consultar(ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar(ref mensajeErrorOut);
          }
          catch (Exception ex)
          {
              return new mail_Parametro_Info();
              
          }
      }

      public Boolean Guardar(mail_Parametro_Info Info, ref string mensajeErrorOut)
        {
            try 
            {
              return   Odata.Guardar(Info, ref mensajeErrorOut);
            }
            catch (Exception)
            {
                return false;
              
            }
        }

    }
}
