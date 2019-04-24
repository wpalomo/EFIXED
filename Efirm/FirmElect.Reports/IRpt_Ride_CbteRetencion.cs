using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using FirmElect.Info.class_sri.Retencion;


namespace FirmElect.Reports
{
   public  interface IRpt_Ride_Retencion
    {

      //  DevExpress.XtraReports.UI.XtraReport Optener_reporte(comprobanteRetencion_Ride_Info InfoRetencion);
       DevExpress.XtraReports.UI.XtraReport Optener_reporte(comprobanteRetencion_Ride_Info InfoRetencion);
     
    }
}
