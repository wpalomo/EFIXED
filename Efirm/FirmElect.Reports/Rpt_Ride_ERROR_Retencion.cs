using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
   public  class Rpt_Ride_ERROR_Retencion:IRpt_Ride_Retencion
    {
        public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.Retencion.comprobanteRetencion_Ride_Info InfoRetencion)
        {
            return new xRpt_Ride_ERROR();
        }
    }
}
