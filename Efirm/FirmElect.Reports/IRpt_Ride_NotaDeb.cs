using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using FirmElect.Info.class_sri.NotaDebito;

namespace FirmElect.Reports
{
   public  interface IRpt_Ride_NotaDeb
    {
       DevExpress.XtraReports.UI.XtraReport Optener_reporte(notaDebito_Ride_Info InfoNotaDeb);

    }
}
