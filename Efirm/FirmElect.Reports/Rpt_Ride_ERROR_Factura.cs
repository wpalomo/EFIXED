using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
    public class Rpt_Ride_ERROR_Factura : IRpt_Ride_Factura
    {
        public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.Factura_V2.factura_Ride_Info InfoFactura)
        {
            return new xRpt_Ride_ERROR();
        }
    }
}
