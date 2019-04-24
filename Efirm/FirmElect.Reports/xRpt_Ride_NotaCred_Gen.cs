using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info;
using FirmElect.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;


namespace FirmElect.Reports
{
    public partial class xRpt_Ride_NotaCred_Gen : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_NotaCred_Gen()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-MX");
        }

        List<notaCredito_Ride_Info> listaDatasource = new List<notaCredito_Ride_Info>();

        public void cargar_reporte(notaCredito_Ride_Info InfoNotaCred)
        {

            try
            {
             
                listaDatasource.Add(InfoNotaCred);
                foreach (var item in listaDatasource)
                {
                    foreach (var item_ in item.notaCredito.infoNotaCredito.totalConImpuestos)
                    {
                        if (item_.codigoPorcentaje == "3")
                        {
                           InfoNotaCred.por_iva = 14;
                        }
                        if (item_.codigoPorcentaje == "2")
                        {
                            InfoNotaCred.por_iva = 12;
                        }
                        if (item_.codigoPorcentaje == "0")
                        {
                            if (Convert.ToDateTime(InfoNotaCred.notaCredito.infoNotaCredito.fechaEmision) < Convert.ToDateTime("01/06/2016"))
                            {
                                InfoNotaCred.por_iva = 12;
                            }
                            else
                                if (Convert.ToDateTime(InfoNotaCred.notaCredito.infoNotaCredito.fechaEmision) > Convert.ToDateTime("31/05/2016"))
                                {
                                    InfoNotaCred.por_iva = 14;
                                }
                        }
                    }
                }


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
