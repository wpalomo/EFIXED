using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailEfirm.Info;
using MailEfirm.Data;



namespace MailEfirm.Bus
{
   public class Mensaje_Bus
    {

       Mensaje_Data Odata;

       public Mensaje_Bus()
       {
           Odata = new Mensaje_Data();

       }

       public List<Mensaje_Info> consultar(eTipoMail TipoCorreo, ref string mensajeErrorOut)
       {
           try
           {
               return Odata.consultar(TipoCorreo, ref mensajeErrorOut);
           }
           catch (Exception ex)
           {

               return new List<Mensaje_Info>();
           }
       }
    }
}
