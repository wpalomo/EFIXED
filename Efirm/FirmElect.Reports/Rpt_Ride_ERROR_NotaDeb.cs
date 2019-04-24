using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
   public  class Rpt_Ride_ERROR_NotaDeb:IRpt_Ride_NotaDeb
    {
        public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.NotaDebito.notaDebito_Ride_Info InfoNotaDeb)
        {
            return new xRpt_Ride_ERROR();
        }
    }
}
