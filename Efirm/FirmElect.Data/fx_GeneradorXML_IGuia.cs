using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.GuiaRemision;
namespace FirmElect.Data
{
    public interface fx_GeneradorXML_IGuia
  {
      List<guiaRemision> GenerarXmlRetencion(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB);
  
    }
}
