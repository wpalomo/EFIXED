using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;


using FirmElect.Info.class_sri.NotaDebito;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_NotaDebito_DatosAdicionales : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_NotaDebito_DatosAdicionales()
        {
            InitializeComponent();
        }


        public void cargar_reporte(notaDebito_Ride_Info InfoNotaDebito)
        {
            try
            {
                List<notaDebito_Ride_Info> listaDatasource = new List<notaDebito_Ride_Info>();
                listaDatasource.Add(InfoNotaDebito);
                this.DataSource = listaDatasource.ToArray();
            }
            catch (Exception ex)
            {


            }

        }

    }
}
