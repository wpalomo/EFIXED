using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;





namespace FirmElect.Bus
{
   public class Mensaje_Bus
    {

      mail_Mensaje_Data Odata;


       public Mensaje_Bus()
       {
           Odata = new mail_Mensaje_Data();

       }

       public List<mail_Mensaje_Info> consultar(eTipoMail TipoCorreo, ref string mensajeErrorOut)
       {
           try
           {
               return Odata.consultar(TipoCorreo, ref mensajeErrorOut);
           }
           catch (Exception ex)
           {

               return new List<mail_Mensaje_Info>();
           }
       }
    }
}
