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
using FirmElect.Info;



namespace FirmElect.Reports
{
    public partial class xRpt_Ride_Factura_Natu : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_Factura_Natu()
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

                foreach (var item in listaDatasource)
                {
                    foreach (var item_ in item.factura.infoFactura.totalConImpuestos)
                    {
                        if (item_.codigoPorcentaje == "3")
                        {
                            InfoFactura.por_iva = 14;
                        }
                        if (item_.codigoPorcentaje == "2")
                        {
                            InfoFactura.por_iva = 12;
                        }
                        if (item_.codigoPorcentaje == "0")
                        {
                            if (Convert.ToDateTime(InfoFactura.factura.infoFactura.fechaEmision) < Convert.ToDateTime("01/06/2016"))
                            {
                                InfoFactura.por_iva = 12;
                            }
                            else
                                if (Convert.ToDateTime(InfoFactura.factura.infoFactura.fechaEmision) > Convert.ToDateTime("31/05/2016"))
                                {
                                    InfoFactura.por_iva = 14;
                                }
                        }
                    }
                    InfoFactura.numeros_en_letras = Funciones.NumeroALetras(InfoFactura.factura.infoFactura.importeTotal);
                }
                this.DataSource = listaDatasource.ToArray();
            }
            catch (Exception ex)
            {


            }

        }

       

        private void xrSubreportForma_Pago_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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

        private void xrSubreportDatosAdicionales_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
