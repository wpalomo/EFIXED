using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.NotaDebito;
namespace FirmElect.Data
{
    public interface fx_GeneradorXML_INotaDebito
    {
        List<notaDebito> GenerarXmlNotaDebito(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente, string FormatoFechaSRI, string formatoFechaDB);
  
    }
}
