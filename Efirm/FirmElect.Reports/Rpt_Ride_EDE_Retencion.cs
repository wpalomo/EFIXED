using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
   public class Rpt_Ride_EDE_Retencion:IRpt_Ride_Retencion
    {

       public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.Retencion.comprobanteRetencion_Ride_Info InfoRetencion)
       {
           try
           {
               xRpt_Ride_Retencion_Ede Reporte = new xRpt_Ride_Retencion_Ede();
               Reporte.cargar_reporte(InfoRetencion);

               return Reporte;
           }
           catch (Exception ex)
           {

               return new DevExpress.XtraReports.UI.XtraReport();
           }
       }
    }
}
