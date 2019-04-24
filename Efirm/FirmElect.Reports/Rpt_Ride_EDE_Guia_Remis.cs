using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
   public class Rpt_Ride_EDE_Guia_Remis:IRpt_Ride_Guia_Remis
    {
       DevExpress.XtraReports.UI.XtraReport IRpt_Ride_Guia_Remis.Optener_reporte(Info.class_sri.GuiaRemision.guiaRemision_Ride_Info InfoGuiaRemis)
       {
           try
           {
               xRpt_Ride_GuiaRemision_Ede Reporte = new xRpt_Ride_GuiaRemision_Ede();
               Reporte.cargar_reporte(InfoGuiaRemis);
               return Reporte;           
           }
           catch (Exception ex)
           {
               return new DevExpress.XtraReports.UI.XtraReport();
           }

       }
    }
}
