using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using FirmElect.Info.class_sri.NotaDebito;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_NotaDebito_Gen : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_NotaDebito_Gen()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-MX");
        }

        List<notaDebito_Ride_Info> listaDatasource = new List<notaDebito_Ride_Info>();

        public void cargar_reporte(notaDebito_Ride_Info InfoNotaDebito)
        {
            try
            {

                
                listaDatasource.Add(InfoNotaDebito);


                foreach (var item in listaDatasource)
                {
                    foreach (var item_ in item.notaDebito.infoNotaDebito.impuestos)
                    {
                        if (item_.codigoPorcentaje == "3")
                        {
                            InfoNotaDebito.por_iva = 14;
                        }
                        if (item_.codigoPorcentaje == "2")
                        {
                            InfoNotaDebito.por_iva = 12;
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
