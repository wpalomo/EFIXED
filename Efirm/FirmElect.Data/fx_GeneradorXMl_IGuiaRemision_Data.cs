using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.GuiaRemision;
namespace FirmElect.Data
{
    public interface fx_GeneradorXMl_IGuiaRemision_Data
    {
        List<guiaRemision> GenerarXmlGuiaRemision(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente, string FormatoFechaSRI, string formatoFechaDB);
  
    }
}
