using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
    public class Rpt_Ride_Factura_OMD : IRpt_Ride_Factura
    {


        public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.Factura.factura InfoFactura)
        {
            try
            {
                xRpt_Ride_Factura_OMD Reporte = new xRpt_Ride_Factura_OMD();

                return Reporte;

            }
            catch (Exception ex)
            {

                return new DevExpress.XtraReports.UI.XtraReport();
            }
        }
    }
}
