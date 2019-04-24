using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FirmElect.Info;
using FirmElect.Info.class_sri.Factura;
using System.Collections.Generic;
using System.ComponentModel;



namespace FirmElect.Reports
{
    public partial class xRpt_Ride_Factura : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_Factura()
        {
            InitializeComponent();
        }

        public void cargar_reporte(factura_Ride_Info InfoFactura)
        {
            try
            {
                              
                List<factura_Ride_Info> listaDatasource = new List<factura_Ride_Info>();
                listaDatasource.Add(InfoFactura);
                this.DataSource = listaDatasource.ToArray();

                xRpt_Ride_Factura_DatosAdicionales rep= new xRpt_Ride_Factura_DatosAdicionales();
                rep.cargar_reporte(InfoFactura);

                xrSubreport1.ReportSource = rep;


            }
            catch (Exception ex)
            {


            }

        }

    }
}
