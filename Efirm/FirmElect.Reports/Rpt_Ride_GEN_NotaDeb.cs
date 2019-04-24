using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
    public class Rpt_Ride_GEN_NotaDeb : IRpt_Ride_NotaDeb
    {
        public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.NotaDebito.notaDebito_Ride_Info InfoNotaDeb)
        {
           // throw new NotImplementedException();
            try
            {
                xRpt_Ride_NotaDebito_Gen Reporte = new xRpt_Ride_NotaDebito_Gen();
                Reporte.cargar_reporte(InfoNotaDeb);
                return Reporte;
            }
            catch (Exception ex)
            {
                return new DevExpress.XtraReports.UI.XtraReport();
            }


        }
    }
}
