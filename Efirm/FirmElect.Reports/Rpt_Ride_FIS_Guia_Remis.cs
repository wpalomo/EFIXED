using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
    public class Rpt_Ride_FIS_Guia_Remis : IRpt_Ride_Guia_Remis
    {

        public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.GuiaRemision.guiaRemision_Ride_Info InfoGuia)
        {
            try
            {
                xRpt_Ride_GuiaRemision_Gen Reporte = new xRpt_Ride_GuiaRemision_Gen();
                Reporte.cargar_reporte(InfoGuia);
                return Reporte;
            }
            catch (Exception ex)
            {
                return new DevExpress.XtraReports.UI.XtraReport();
            }
        }
    }
}
