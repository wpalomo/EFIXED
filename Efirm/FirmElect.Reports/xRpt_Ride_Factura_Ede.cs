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
    public partial class xRpt_Ride_Factura_Ede : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_Factura_Ede()
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
                //foreach (var item in InfoFactura.factura.infoAdicional)
                //{
                    //if (item.nombre == "MAIL")
                    //{
                    //    this.campo_adicional_mail.Expression = "\'" + item.Value + "\'";
                      
                    //}

                    //if (item.nombre == "OBRA")
                    //{
                    //    this.campo_adicional_obra.Expression = "\'" + item.Value + "\'";

                    //}


                    //if (item.nombre == "FORMA_PAGO")
                    //{
                    //    this.campo_adicional_forma_pago.Expression = "\'" + item.Value + "\'";

                    //}

                    //if (item.nombre == "REFERENCIA")
                    //{
                    //    this.campo_adicional_referencia.Expression = "\'" + item.Value + "\'";

                    //}

                    //if (item.nombre == "FECHA_VENCI")
                    //{
                    //    this.campo_adicional_fecha_vencimiento.Expression = "\'" + item.Value + "\'";

                    //}

                    //if (item.nombre == "observaciones")
                    //{
                    //    this.campo_adicional_observaciones.Expression = "\'" + item.Value + "\'";

                    //}

                    //if (item.nombre == "DIRECCION_CLIENTE")
                    //{
                    //    this.campo_adicional_direccion.Expression = "\'" + item.Value + "\'";

                    //}

              //  } 
                
                                                       
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

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
