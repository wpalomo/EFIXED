using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using FirmElect.Info.class_sri.Retencion;
using FirmElect.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_Retencion_Ede : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_Retencion_Ede()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-MX");

        }

        public void cargar_reporte(comprobanteRetencion_Ride_Info InfoRetencion)
        {
            try
            {
                //foreach (var item in InfoRetencion.cbteRetencion.infoAdicional)
                //{
                //    if (item.nombre == "MAIL")
                //    {
                //        InfoRetencion.MAIL = item.Value;
                //        //this.campo_adicional_mail.Expression = "\'" + item.Value + "\'";
                //    }

                //    if (item.nombre == "DIRECCION_CLIENTE")
                //    {
                //        InfoRetencion.DIRECCION = item.Value;
                //        //this.campo_adicional_direccion.Expression = "\'" + item.Value + "\'";

                //    }

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
                //}

                List<comprobanteRetencion_Ride_Info> listaDatasource = new List<comprobanteRetencion_Ride_Info>();
                listaDatasource.Add(InfoRetencion);
                this.DataSource = listaDatasource.ToArray();           
            }
            catch (Exception ex)
            {
            }

        }
    }
}
