using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.NotaCredito;
namespace FirmElect.Data
{
   public interface fx_GeneradorXML_INotaCredito
    {
       List<notaCredito> GenerarXmlNotaCredito(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB);
  
    }
}
