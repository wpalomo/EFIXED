using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using FirmElect.Info;
using FirmElect.Data;

using FirmElect.Info.class_sri.NotaCredito;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_NotaCred_Ede : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_NotaCred_Ede()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-MX");
        }


        public void cargar_reporte(notaCredito_Ride_Info InfoNotaCred)
        {
            try
            {
                foreach (var item in InfoNotaCred.notaCredito.infoAdicional)
                {
                    //if (item.nombre == "MAIL")
                    //{
                    //    this.campo_adicional_mail.Expression = "\'" + item.Value + "\'";

                    //}

                    if (item.nombre == "OBRA")
                    {
                        this.campo_adicional_obra.Expression = "\'" + item.Value + "\'";

                    }

                    //if (item.nombre == "FORMA_PAGO")
                    //{
                    //    this.campo_adicional_forma_pago.Expression = "\'" + item.Value + "\'";

                    //}

                    //if (item.nombre == "REFERENCIA")
                    //{
                    //    this.campo_adicional_referencia.Expression = "\'" + item.Value + "\'";

                    //}

                    if (item.nombre == "OBSERVACIONES")
                    {
                        this.campo_adicional_observaciones.Expression = "\'" + item.Value + "\'";

                    }

                    if (item.nombre == "DIRECCION_CLIENTE")
                    {
                        this.campo_adicional_direccion.Expression = "\'" + item.Value + "\'";

                    }

                }


                List<notaCredito_Ride_Info> listaDatasource = new List<notaCredito_Ride_Info>();
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
                    }
                }

                this.DataSource = listaDatasource.ToArray();
              
            }
            catch (Exception ex)
            {


            }

        }

    }
}
