using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Data;
using FirmElect.Data.Proceso_efixed;
using FirmElect.Info.class_sri.Retencion;
namespace FirmElect.Bus
{
   public class fx_Retencion_Bus
    {
        fx_GeneradorXML_IRetencion data;
        public List< comprobanteRetencion> GenerarXmlRetencion(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB, eCliente cliente)
        {
            try
            {
                switch (cliente)
                {
                    case eCliente.EXPOGYE:
                        data = new fx_GeneradorXML_Retencion_DinamicsAX();
                        break;
                    case eCliente.FIXED:
                        data = new fx_GeneradorXML_Retencion_Fixed();
                        break;
                    default:
                        break;
                }

                return data.GenerarXmlRetencion(FechaIni, FechaFin, ConexionDBCliente,OconEfirm, FormatoFechaSRI, formatoFechaDB);

            }
            catch (Exception)
            {

                return new List<comprobanteRetencion>();
            }
        }
   
    }
}
