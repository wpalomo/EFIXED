using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;


using FirmElect.Info.class_sri.NotaCredito;


namespace FirmElect.Reports
{
    public partial class xRpt_Ride_NotaCred_DatosAdicionales : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_NotaCred_DatosAdicionales()
        {
            InitializeComponent();
        }

        public void cargar_reporte(notaCredito InfoNotaCred)
        {
            try
            {
                List<notaCredito> listaDatasource = new List<notaCredito>();
                listaDatasource.Add(InfoNotaCred);
                this.DataSource = listaDatasource.ToArray();
            }
            catch (Exception ex)
            {


            }

        }

    }
}
