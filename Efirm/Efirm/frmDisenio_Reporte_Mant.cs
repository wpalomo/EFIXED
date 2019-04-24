using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Reports;
using FirmElect.Info;
using FirmElect.Bus;
using System.Xml;
using System.Xml.Serialization;


namespace Efirm
{
    public partial class frmDisenio_Reporte_Mant : Form
    {
        static string Ruta_Temporal = Path.GetTempPath();
        String RootReporte = Ruta_Temporal + @"saveComprobante.repx";


        DevExpress.XtraReports.UI.XtraReport Guia = new DevExpress.XtraReports.UI.XtraReport();

        

        xRpt_Ride_Factura_Gen ReporteFactura = new xRpt_Ride_Factura_Gen();
        xRpt_Ride_NotaCred_Gen ReporteNota_Cred = new xRpt_Ride_NotaCred_Gen();
        xRpt_Ride_NotaDebito_Gen ReporteNota_Deb = new xRpt_Ride_NotaDebito_Gen();
        xRpt_Ride_Retencion_Gen ReporteRetencion = new xRpt_Ride_Retencion_Gen();
        xRpt_Ride_GuiaRemision_Gen ReporteGuia = new xRpt_Ride_GuiaRemision_Gen();

        xRpt_Ride_Factura_Gen_DatosAdicionales ReporteFactura_DatosAdicionales = new xRpt_Ride_Factura_Gen_DatosAdicionales();
        xRpt_Ride_Factura_Gen_Forma_Pago ReporteFormaPago = new xRpt_Ride_Factura_Gen_Forma_Pago();

        



        public eTipoComprobante TipoCbte;
        tb_Comprobante_tipo_x_empresa_Bus Buscbte = new tb_Comprobante_tipo_x_empresa_Bus();
        tb_Comprobante_tipo_x_empresa_Info Cbte_tipo_Info = new tb_Comprobante_tipo_x_empresa_Info();
        tb_Comprobante_tipo_Info InfoGeneral = new tb_Comprobante_tipo_Info();
        string MensajeError = "";


        public frmDisenio_Reporte_Mant()
        {
            InitializeComponent();
          
        }


        private void frmDisenio_Reporte_Mant_Load(object sender, EventArgs e)
        {


        }

        private void barButtonItemGuardarDB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Grabar(InfoGeneral))
                {
                    MessageBox.Show(" Se Guardaron los Cambios para el tipo Report " + InfoGeneral.descripcion_tipo);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" No Se Guardaron los Cambios para el tipo Report " + InfoGeneral.descripcion_tipo);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void Set(tb_Comprobante_tipo_Info Info )
        {
            try
            {
                InfoGeneral = Info;                            
               commandBarItemNuevo.PerformClick();           
                if (Info.IdComprobante_tipo=="01")
                {
                    // si existe el binario en la base
                    if (Info.ReporteBy != null)
                    {
                        File.WriteAllBytes(RootReporte, Info.ReporteBy);
                        ReporteFactura.LoadLayout(RootReporte);
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteFactura);
                    }
                    else
                    {
                        Info.IdComprobante_tipo = "01";
                        ReporteFactura.CreateDocument();
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteFactura);
                    }
                }

                if (Info.IdComprobante_tipo == "04")
                {
                    if (Info.ReporteBy != null)
                    {
                        File.WriteAllBytes(RootReporte, Info.ReporteBy);

                        ReporteNota_Cred.LoadLayout(RootReporte);
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteNota_Cred);
                    }
                    else
                    {
                        Info.IdComprobante_tipo = "04";
                        ReporteNota_Cred.CreateDocument();
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteNota_Cred);
                    }
                }

                if (Info.IdComprobante_tipo == "05")
                {
                    if (Info.ReporteBy != null)
                    {
                        File.WriteAllBytes(RootReporte, Info.ReporteBy);

                        ReporteNota_Deb.LoadLayout(RootReporte);
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteNota_Deb);
                    }
                    else
                    {
                        Info.IdComprobante_tipo = "05";
                        ReporteNota_Deb.CreateDocument();
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteNota_Deb);
                    }
                }

                if (Info.IdComprobante_tipo == "07")
                {
                    if (Info.ReporteBy != null)
                    {
                        File.WriteAllBytes(RootReporte, Info.ReporteBy);

                        ReporteRetencion.LoadLayout(RootReporte);

                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteRetencion);
                    }
                    else
                    {
                        Info.IdComprobante_tipo = "07";
                        ReporteRetencion.CreateDocument();
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteRetencion);
                    }
                }

                if (Info.IdComprobante_tipo == "06")
                {

                    if (Info.ReporteBy != null)
                    {
                        File.WriteAllBytes(RootReporte, Info.ReporteBy);

                        ReporteGuia.LoadLayout(RootReporte);

                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteGuia);
                    }
                    else
                    {
                        Info.IdComprobante_tipo = "06";
                        ReporteGuia.CreateDocument();
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteGuia);
                    }

                }

                if (Info.IdComprobante_tipo == "10")
                {

                    if (Info.ReporteBy != null)
                    {
                        File.WriteAllBytes(RootReporte, Info.ReporteBy);

                        ReporteFactura_DatosAdicionales.LoadLayout(RootReporte);

                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteFactura_DatosAdicionales);
                    }
                    else
                    {
                        Info.IdComprobante_tipo = "10";
                        ReporteFactura_DatosAdicionales.CreateDocument();
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteFactura_DatosAdicionales);
                    }

                }

                if (Info.IdComprobante_tipo == "11")
                {

                    if (Info.ReporteBy != null)
                    {
                        File.WriteAllBytes(RootReporte, Info.ReporteBy);

                        ReporteFormaPago.LoadLayout(RootReporte);

                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteFormaPago);
                    }
                    else
                    {
                        Info.IdComprobante_tipo = "11";
                        ReporteFormaPago.CreateDocument();
                        xrDesignDockManager.XRDesignPanel.OpenReport(ReporteFormaPago);
                    }

                }
            

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public bool Grabar(tb_Comprobante_tipo_Info Infocbte)
        {
            try
            {
                 string reportruta = Ruta_Temporal + "saveComprobante.repx";
                xrDesignDockManager.XRDesignPanel.SaveReport(reportruta);
                Byte[] data;
                using (System.IO.FileStream FL = new System.IO.FileStream(reportruta, System.IO.FileMode.Open))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        FL.CopyTo(ms);
                        data = ms.ToArray();
                    }
                }
                Infocbte.ReporteBy = data;

                Cbte_tipo_Info.IdEmpresa = Infocbte.IdEmpresa;
                Cbte_tipo_Info.idComprobante_tipo = Infocbte.IdComprobante_tipo;
                Cbte_tipo_Info.File_disenio_rpt = Infocbte.ReporteBy;

                if (Buscbte.ModificarDB(Cbte_tipo_Info, ref MensajeError))
                    return true;
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
