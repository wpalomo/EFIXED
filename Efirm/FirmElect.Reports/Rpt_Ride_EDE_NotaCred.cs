using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
   public class Rpt_Ride_EDE_NotaCred:IRpt_Ride_NotaCred
    {
       public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.NotaCredito.notaCredito_Ride_Info InfoNotaCred)
       {
           try
           {
               xRpt_Ride_NotaCred_Ede Reporte = new xRpt_Ride_NotaCred_Ede();
               Reporte.cargar_reporte(InfoNotaCred);

               return Reporte;
           }
           catch (Exception ex)
           {

               return new DevExpress.XtraReports.UI.XtraReport();
           }
       }
    }
}
