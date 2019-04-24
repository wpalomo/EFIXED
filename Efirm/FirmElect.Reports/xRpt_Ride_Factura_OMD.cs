using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FirmElect.Info;
using FirmElect.Info.class_sri.Factura;



namespace FirmElect.Reports
{
    public partial class xRpt_Ride_Factura_OMD : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_Factura_OMD()
        {
            InitializeComponent();
        }

        public void cargar_data(factura InfoFactura)
        {
                try 
                {
                    this.DataSource = InfoFactura;
                }
                catch (Exception ex)
                {
			
                }
        }

    }
}
