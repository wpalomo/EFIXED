using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;


namespace FirmElect.Bus
{
   public class tb_Empresa_externa_Bus
    {
       tb_Empresa_externa_Data Odata = new tb_Empresa_externa_Data();


       public List<tb_Empresa_externa_Info> consultar(ref string mensajeErrorOut)
       {
           try
           {
               return Odata.consultar(ref mensajeErrorOut);
           }
           catch (Exception ex)
           {
               return new List<tb_Empresa_externa_Info>();
               
           }
       }
    }
}
