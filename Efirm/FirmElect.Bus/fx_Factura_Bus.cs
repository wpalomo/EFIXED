using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Data;
using FirmElect.Data.Proceso_efixed;
namespace FirmElect.Bus
{
   public class fx_Factura_Bus
    {
       fx_GeneradorXML_IFacturas_Data data;
       public List<factura> GenerarXmlFactura(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente, string OconEfirm, string FormatoFechaSRI, string formatoFechaDB, eCliente cliente)
       {
           try
           {
               switch (cliente)
               {
                   case eCliente.EXPOGYE:
                       data = new fx_Generador_XML_Factura_DinamicsAX();
                       break;

                   case eCliente.FIXED:
                       data = new fx_Generador_XML_Factura_Fixed();
                       break;
                   default:
                       break;
               }

               return data.GenerarXmlFactura(FechaIni, FechaFin, ConexionDBCliente,OconEfirm, FormatoFechaSRI, formatoFechaDB);

           }
           catch (Exception)
           {

               return new List<factura>();
           }
       }
   
   }
}
