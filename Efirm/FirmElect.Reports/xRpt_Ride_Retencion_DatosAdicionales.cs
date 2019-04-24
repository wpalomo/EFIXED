using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;

using FirmElect.Info.class_sri.Retencion;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_Retencion_DatosAdicionales : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_Retencion_DatosAdicionales()
        {
            InitializeComponent();
        }

        public void cargar_reporte(comprobanteRetencion_Ride_Info InfoRetencion)
        {
            try
            {
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
