using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
   public class Rpt_Ride_TAL_Factura:IRpt_Ride_Factura
    {
       public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.Factura_V2.factura_Ride_Info InfoFactura)
        {
            try
            {
                return new DevExpress.XtraReports.UI.XtraReport();

            }
            catch (Exception ex)
            {

                return new DevExpress.XtraReports.UI.XtraReport();
            }

        }
    }
}
