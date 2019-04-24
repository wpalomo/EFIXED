using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
   public class tb_directorio_Bus
    {

       tb_directorio_Data Odata;

       public tb_directorio_Bus()
       {
           Odata = new tb_directorio_Data();
       }

       public Boolean GuardarDB(tb_directorio_Info Info, ref string MensajeErrorOut)
       {
           try
           {
               return Odata.GuardarDB(Info, ref MensajeErrorOut);

           }
           catch (Exception ex)
           {
               return false;
               
           }
       }


       public Boolean ModificarDB(tb_directorio_Info info, ref string MensajeErrorOut)
       {
           try
           {
                return Odata.ModificarDB(info, ref MensajeErrorOut);
           }
           catch (Exception ex)
           {

               return false;
           }
       }

       public List<tb_directorio_Info> Consultar(ref string MensajeErrorOut)
       {
           try
           {
               return Odata.Consultar(ref MensajeErrorOut);

           }
           catch (Exception ex)
           {
               return new List<tb_directorio_Info>(); 
               
           }
       }
       
    }
}
