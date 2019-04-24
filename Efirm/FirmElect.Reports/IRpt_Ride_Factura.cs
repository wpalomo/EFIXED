using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using FirmElect.Info.class_sri.Factura_V2;



namespace FirmElect.Reports
{
   public interface IRpt_Ride_Factura
    {

       DevExpress.XtraReports.UI.XtraReport Optener_reporte(factura_Ride_Info InfoFactura);


    }
}
