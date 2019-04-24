using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.Factura_V2;
namespace FirmElect.Data
{
    public interface fx_GeneradorXML_IFacturas_Data
    {
        List<factura> GenerarXmlFactura(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB);
       
    }
}
