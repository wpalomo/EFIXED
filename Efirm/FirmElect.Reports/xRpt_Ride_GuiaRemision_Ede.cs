using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_GuiaRemision_Ede : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_GuiaRemision_Ede()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-MX");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-MX");
        }
        public void cargar_reporte(guiaRemision_Ride_Info InfoGuiaRemis)
        {
            try
            {
                foreach (var item in InfoGuiaRemis.guiaremision.infoAdicional)
                {
                    if (item.nombre == "MAIL")
                    {
                        campo_adicional_mail.Expression = "\'" + item.Value + "\'";
                    }
                    if (item.nombre == "DESTINO")
                    {
                        campo_adicional_destino.Expression = "\'" + item.Value + "\'"; 
                    }
                    if (item.nombre == "OBRA")
                    {
                        campo_adicional_obra.Expression = "\'" + item.Value + "\'";
                    }
                }
                List<guiaRemision_Ride_Info> listaDatasource = new List<guiaRemision_Ride_Info>();
                listaDatasource.Add(InfoGuiaRemis);
                this.DataSource = listaDatasource.ToArray();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
