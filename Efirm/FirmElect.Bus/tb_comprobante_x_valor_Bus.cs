using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Serialization;
using System.Web;
using FirmElect.Info;
using FirmElect.Data;
using System.Net;
using System.Threading;
using System.Globalization;
using DevExpress.XtraReports.UI;

namespace FirmElect.Bus
{
   public class tb_comprobante_x_valor_Bus
    {
       tb_comprobante_x_valor_Data data = new tb_comprobante_x_valor_Data();
       public Boolean GrabarDB(tb_comprobante_x_valor_Info Comprobante_info)
       {
           try
           {
               return data.GrabarDB(Comprobante_info);
           }
           catch (Exception)
           {
               
               throw;
           }
       }

       public bool si_existe_comprobante(tb_comprobante_x_valor_Info Comprobante_info)
       {
           try
           {
               return data.si_existe_comprobante(Comprobante_info);
           }
           catch (Exception)
           {

               throw;
           }
       }
    }
}
