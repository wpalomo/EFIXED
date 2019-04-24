using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;

using System.Globalization;
using System.Threading;

using FirmElect.Info.class_sri.GuiaRemision;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_GuiaRemision_Gen : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_GuiaRemision_Gen()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-MX");
        }

        public void cargar_reporte(guiaRemision_Ride_Info InfoGuia)
        {

            try
            {
                List<guiaRemision_Ride_Info> listaDatasource = new List<guiaRemision_Ride_Info>();
                listaDatasource.Add(InfoGuia);

                this.DataSource = listaDatasource.ToArray();

              //  xRpt_Ride_NotaCred_DatosAdicionales rep = new xRpt_Ride_NotaCred_DatosAdicionales();
              //  rep.cargar_reporte(InfoGuia);

               // xrSubreport1.ReportSource = rep;

            }
            catch (Exception ex)
            {


            }

        }

    }
}
