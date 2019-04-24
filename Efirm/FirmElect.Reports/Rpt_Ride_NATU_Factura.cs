using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
    public class Rpt_Ride_NATU_Factura : IRpt_Ride_Factura
    {
        DevExpress.XtraReports.UI.XtraReport IRpt_Ride_Factura.Optener_reporte(Info.class_sri.Factura_V2.factura_Ride_Info InfoFactura)
        {
            try
            {
                xRpt_Ride_Factura_Natu Reporte = new xRpt_Ride_Factura_Natu();
                Reporte.cargar_reporte(InfoFactura);
                return Reporte;
            }
            catch (Exception ex)
            {
                return new DevExpress.XtraReports.UI.XtraReport();

            }

        }

    }
}
