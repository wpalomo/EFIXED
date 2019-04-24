using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;


using FirmElect.Info.class_sri.Factura_V2;

namespace FirmElect.Reports
{
    public partial class xRpt_Ride_Factura_Gen_DatosAdicionales : DevExpress.XtraReports.UI.XtraReport
    {
        public xRpt_Ride_Factura_Gen_DatosAdicionales()
        {
            InitializeComponent();
        }


        public void cargar_reporte(factura_Ride_Info InfoFactura)
        {
            try
            {
                if (InfoFactura.factura.infoTributaria.ambiente == "1")
                {
                    string ambiente = InfoFactura.factura.infoTributaria.ambiente;
                }

                List<factura_Ride_Info> listaDatasource = new List<factura_Ride_Info>();
                listaDatasource.Add(InfoFactura);
                this.DataSource = listaDatasource.ToArray();
            }
            catch (Exception ex)
            {

            }
        }
    
    
    }
}
