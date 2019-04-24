using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using FirmElect.Info;
using FirmElect.Info.class_sri.Retencion;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_Retencion_Gen : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_Retencion_Gen()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-MX");
        }

        List<comprobanteRetencion_Ride_Info> listaDatasource = new List<comprobanteRetencion_Ride_Info>();

        public void cargar_reporte(comprobanteRetencion_Ride_Info InfoRetencion)
        {
            try
            {

                
                listaDatasource.Add(InfoRetencion);
                this.DataSource = listaDatasource.ToArray();

                


            }
            catch (Exception ex)
            {


            }

        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                ((XRSubreport)sender).ReportSource.DataSource = listaDatasource;
                ((XRSubreport)sender).ReportSource.FillDataSource();

            }
            catch (Exception ex)
            {


            }
        }

    }
}
