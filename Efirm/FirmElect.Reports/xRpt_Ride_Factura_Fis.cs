using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_Factura_Fis : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_Factura_Fis()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-MX");

        }

        List<factura_Ride_Info> listaDatasource = new List<factura_Ride_Info>();

        public void cargar_reporte(factura_Ride_Info InfoFactura)
        {
            try
            {

             
                listaDatasource.Add(InfoFactura);
                this.DataSource = listaDatasource.ToArray();

             


            }
            catch (Exception ex)
            {


            }

        }
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

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
