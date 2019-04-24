using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using FirmElect.Info.class_sri.NotaCredito;

namespace FirmElect.Reports
{
   public interface IRpt_Ride_NotaCred
    {


       DevExpress.XtraReports.UI.XtraReport Optener_reporte(notaCredito_Ride_Info InfoNotaCred);

    }
}
