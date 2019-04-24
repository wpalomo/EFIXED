using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailEfirm.Data;
using MailEfirm.Info;
namespace MailEfirm.Bus
{
   public class Empresa_Bus
    {
       
       Empresa_Data Odata;

       public Empresa_Bus()
       {
           Odata = new Empresa_Data();

       }

       public List<Empresa_Info> consultar()
       {
           try
           {
               return Odata.listarEmpresas();
           }
           catch (Exception ex)
           {

               return new List<Empresa_Info>();
           }
       }
    }
}
