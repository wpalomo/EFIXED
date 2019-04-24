using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Data;
using FirmElect.Data.Proceso_efixed;

namespace FirmElect.Bus
{
   public class fx_NotaCredito_Bus
    {
        fx_GeneradorXML_INotaCredito data;
        public List<notaCredito> GenerarXmlNC(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB, eCliente cliente)
        {
            try
            {
                switch (cliente)
                {
                    case eCliente.EXPOGYE:
                        data = new fx_GeneradorXML_NotaCredito_DinamicsAX();
                        break;
                    case eCliente.FIXED:
                        data = new fx_GeneradorXML_NotaCredito_Fixed();
                        break;
                   
                    default:
                        break;
                }

                return data.GenerarXmlNotaCredito(FechaIni, FechaFin, ConexionDBCliente,OconEfirm, FormatoFechaSRI, formatoFechaDB);

            }
            catch (Exception)
            {

                return new List<notaCredito>();
            }
        }
   
    }
}
