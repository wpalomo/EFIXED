using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using FirmElect.Info.class_sri.GuiaRemision;


namespace FirmElect.Reports
{
   public interface IRpt_Ride_Guia_Remis
    {
       DevExpress.XtraReports.UI.XtraReport Optener_reporte(guiaRemision_Ride_Info InfoGuia);


    }
}
