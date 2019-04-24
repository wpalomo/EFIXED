using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using FirmElect.Info;
using FirmElect.Bus;
using FirmElect.Reports;


namespace Efirm
{
    public partial class UC_Comprobante_Autoriz_No_Autoriz_x_SRI : UserControl
    {
        #region Declaración de variables
        BindingList<tb_Comprobante_Info> listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>();
        tb_Comprobante_Bus buscomp = new tb_Comprobante_Bus();
        string mensajeError = "";
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        Rpt_Ride_bus Rpt_Ride_Bus;
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        List<tb_Empresa_Info> ListEmpresa = new List<tb_Empresa_Info>();



        #endregion

        public UC_Comprobante_Autoriz_No_Autoriz_x_SRI()
        {
            InitializeComponent();
            
        }

        public void cargar_xml(int IndicePagina )
        {
            try
            {

                DateTime FechaIni, FechaFin;
                string Stipo_Autorizacion = "";
                int NumeroPaginas=0;

                int IdEmpresaIni = 0;
                int IdEmpresaFin = 0;
                string IdTipoDocumentoIni = "";
                string IdTipoDocumentoFin = "";


                IdEmpresaIni = cmbEmisor.Get_IdEmisor();
                IdTipoDocumentoIni = cmbTipoDoc.Get_IdTipoDocumento();

                IdTipoDocumentoFin = (IdTipoDocumentoIni == "00") ? "99" : IdTipoDocumentoIni;
                IdEmpresaFin = (IdEmpresaIni == 0) ? 900 : IdEmpresaIni;
                

                FechaIni = dtp_fechaIni.Value;
                FechaFin = dtp_fechaFin.Value;

                Stipo_Autorizacion = (cmb_tipo_Autorizacion.Text.Trim() == "TODOS" ? "" : cmb_tipo_Autorizacion.Text.Trim());

                List<string> listadoTipoCbtes = new List<string>();
                listadoTipoCbtes.Add("VALI_&_FIRM_&_REC");

                NumeroPaginas = buscomp.ObtenerNumPag(IdEmpresaIni, IdEmpresaFin, IdTipoDocumentoIni, uC_Botones_Paginas1.Total_Registros_x_pagina, FechaIni, FechaFin, Stipo_Autorizacion, "PROCE", txtBusqueda.Text, "VALI_&_FIRM_&_REC", ref mensajeError);
                if (NumeroPaginas > IndicePagina)
                {
                    listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>(buscomp.consultar_listado_cbte(IdEmpresaIni, IdEmpresaFin, IdTipoDocumentoIni, IdTipoDocumentoFin, IndicePagina, uC_Botones_Paginas1.Total_Registros_x_pagina, FechaIni, FechaFin, listadoTipoCbtes, Stipo_Autorizacion, "PROCE", txtBusqueda.Text, ref mensajeError));
                    uC_Botones_Paginas1.NumeroPaginas = NumeroPaginas;
                }
                else
                {
                    listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>(buscomp.consultar_listado_cbte(IdEmpresaIni, IdEmpresaFin, IdTipoDocumentoIni, IdTipoDocumentoFin,IndicePagina, uC_Botones_Paginas1.Total_Registros_x_pagina, FechaIni, FechaFin, listadoTipoCbtes, Stipo_Autorizacion, "PROCE", txtBusqueda.Text, ref mensajeError));
                    uC_Botones_Paginas1.NumeroPaginas = NumeroPaginas;
                    uC_Botones_Paginas1.IndicePagina = 1; 
                }
                                      
                gridControlFiles.DataSource = listComprobanteRecixSRI;

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }

        }
            
        private void gridControlFiles_Click(object sender, EventArgs e)
        {

        }

        private void UC_Comprobante_Recibidos_Aut_x_SRI_Load(object sender, EventArgs e)
        {
            try
            {


                ListEmpresa = busEmpresa.GetEmpresas(ref mensajeError);

                Rpt_Ride_Bus = new Rpt_Ride_bus(ListEmpresa);

                //dtp_fechaIni.Value = DateTime.Now.AddMonths(-1);
                //dtp_fechaFin.Value = DateTime.Now.AddMonths(1);

                dtp_fechaIni.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtp_fechaFin.Value = DateTime.Now;

                cmb_tipo_Autorizacion.SelectedIndex = 0;

              
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }
        }

        private void gridViewFiles_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
            try
            {
                tb_Comprobante_Info InfoCbteT = new tb_Comprobante_Info();

                string MensajeError="";


                switch (e.Column.Name)
                {
                    case "colRide":

                            XtraReport Reporte = new XtraReport();
                            string msg = "";
                    
               
                            InfoCbteT = (tb_Comprobante_Info)gridViewFiles.GetFocusedRow();
                           
                            Reporte = Rpt_Ride_Bus.Optener_reporte(InfoCbteT, ref msg); //FAct Imporpoint
                            Reporte.ShowPreview();

                        break;

                    case "colXml":

                            
                         InfoCbteT = (tb_Comprobante_Info)gridViewFiles.GetFocusedRow();
                            
                        tb_Comprobante_Bus BusCbte= new tb_Comprobante_Bus();
                        string sXML = "";
                        sXML=BusCbte.Get_XML(InfoCbteT.IdEmpresa, InfoCbteT.IdComprobante, ref MensajeError);

                            XmlDocument xmlOrigen = new XmlDocument();
                            xmlOrigen.Load(new StringReader(sXML));

                    

                            Stream myStream;
                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
                            saveFileDialog1.FilterIndex = 2;
                            saveFileDialog1.RestoreDirectory = true;
                            saveFileDialog1.FileName = "SRI_"+InfoCbteT.Nombre_file ;

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                                    {
                                        xmlOrigen.Save(myStream);
                                        myStream.Close();
                                    }
                            }


                        break;

                    case "colEliminar":


                          
                            string msgError = "";

                            InfoCbteT = (tb_Comprobante_Info)gridViewFiles.GetFocusedRow();
                            if (InfoCbteT.EstadoDoc == "NO AUTORIZADO")
                            {
                                if (MessageBox.Show("Esta seguro que desear anular el comprobante #:" + InfoCbteT.IdComprobante, "Efirm confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    if (buscomp.Eliminar_Cbte(InfoCbteT.IdEmpresa, InfoCbteT.IdComprobante, "", "", ref msgError))
                                    {
                                        MessageBox.Show("Eliminacion de comprobante Ok", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }

                            }

                            if (InfoCbteT.EstadoDoc == "AUTORIZADO")
                            {

                                if (Efirm.Properties.Settings.Default.P_ESTADO_CARGA_EFIRM == "CLIENTE")
                                {
                                    MessageBox.Show("Usted no tiene Permiso para Eliminar Comprobantes AUTORIZADOS .. solicite a sistemas o inicie como administrador", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }


                                if (MessageBox.Show("Esta seguro que desear anular el comprobante #:" + InfoCbteT.IdComprobante, "Efirm confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    if (MessageBox.Show("Esta REALMENTE seguro que desear anular el comprobante #:" + InfoCbteT.IdComprobante + " RECUERDE EL COMPROBANTE ESTA AUTORIZADO DEBERA REALIZAR TODO EL PROCESO NUEVAMENTE", "Efirm confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                                    {

                                        if (MessageBox.Show("***ATENCION....CUIDADO ESTA ELIMINANDO UN CBTE *AUTORIZADO* ESTE COMPROBANTE YA ESTA EN LA BASE DEL SRI y no sera elimado del mismo solo se eliminara de efirm... comprobante #:" + InfoCbteT.IdComprobante , "Efirm confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                        {

                                            frmAuditoria_Anulacion frm = new frmAuditoria_Anulacion();
                                            frm.ShowDialog();

                                            if (buscomp.Eliminar_Cbte(InfoCbteT.IdEmpresa, InfoCbteT.IdComprobante, frm.txt_usuario_anulacion.Text, frm.txt_motivo_anulacion.Text, ref msgError))
                                            {
                                                MessageBox.Show("Eliminacion de comprobante Ok", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                    }
                                }

                            }


                        break;



                    default:
                            string mensaje = (string)gridViewFiles.GetFocusedRowCellValue(e.Column);


                            if (mensaje != "")
                            {

                                    frmMensaje frmsg = new frmMensaje();
                                    frmsg.richTextBoxMensaje.Text = mensaje;
                                    frmsg.WindowState = FormWindowState.Maximized;
                                    frmsg.ShowDialog();
                            }

                        break;

                
                }
                           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
           
        }

        
        private void dtp_fechaIni_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridViewFiles.ViewCaption = "Comprobante desde:" + Convert.ToDateTime(dtp_fechaIni.Value).Date + " hasta:" + Convert.ToDateTime(dtp_fechaFin.Value).Date;
                listComprobanteRecixSRI.Clear();
                gridControlFiles.RefreshDataSource();
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void dtp_fechaFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridViewFiles.ViewCaption = "Comprobante desde:" + Convert.ToDateTime(dtp_fechaIni.Value).Date + " hasta:" + Convert.ToDateTime(dtp_fechaFin.Value).Date;
                listComprobanteRecixSRI.Clear();
                gridControlFiles.RefreshDataSource();
            }
            catch (Exception ex)
            {


            }
        }

        private void gridViewFiles_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewFiles.GetRow(e.RowHandle) as tb_Comprobante_Info;
                if (data == null)
                    return;
                if (data.EstadoDoc == "NO AUTORIZADO")
                {
                    e.Appearance.ForeColor = Color.OrangeRed;
                }
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_tipo_Autorizacion_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                listComprobanteRecixSRI.Clear();
                gridControlFiles.RefreshDataSource();
            }
            catch (Exception ex)
            {
                
                
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Impresion_Lote_Click(object sender, EventArgs e)
        {

        }

        private void uC_Botones_Paginas1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Botones_Paginas1_event_click_buttons(object sender, EventArgs e, int _IndicePagina, int _Total_Registros_x_pagina)
        {
            cargar_xml(_IndicePagina);

        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            cargar_xml(1);
        }

        public void Imprimir()
        {
            try
            {
                gridViewFiles.ViewCaption = "Comprobante desde:" +Convert.ToDateTime( dtp_fechaIni.Value).Date + " hasta:" +Convert.ToDateTime( dtp_fechaFin.Value).Date;
                gridControlFiles.ShowPrintPreview();

            }
            catch (Exception ex)
            {


            }
        }
    }

}
