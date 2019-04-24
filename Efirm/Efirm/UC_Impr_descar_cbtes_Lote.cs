using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Info;
using FirmElect.Bus;
using FirmElect.Reports;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using DevExpress.XtraReports.UI;




namespace Efirm
{
    public partial class UC_Impr_descar_cbtes_Lote : UserControl
    {
        #region Variables
        BindingList<tb_Comprobante_Info> listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>();
        tb_Comprobante_Bus buscomp = new tb_Comprobante_Bus();
        string mensajeError = "";
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        Rpt_Ride_bus Rpt_Ride_Bus;
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        Boolean seteo_parametros = false;

        List<tb_Empresa_Info> ListEmpresa = new List<tb_Empresa_Info>();

        #endregion
       
        public UC_Impr_descar_cbtes_Lote()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cargar_xml(uC_Botones_Paginas1.IndicePagina, uC_Botones_Paginas1.NumeroPaginas);
        }

        private void cargar_xml(int IndicePagina, int NumeroPaginas)
        {
            try
            {

                DateTime FechaIni, FechaFin;
                string Stipo_Autorizacion = "";

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

                NumeroPaginas = buscomp.ObtenerNumPag(IdEmpresaIni, IdEmpresaFin, IdTipoDocumentoIni, uC_Botones_Paginas2.Total_Registros_x_pagina, FechaIni, FechaFin, Stipo_Autorizacion, "PROCE"
                    , txtBusqueda.Text, "VALI_&_FIRM_&_REC", ref mensajeError);
                if (NumeroPaginas >= IndicePagina)
                {
                    listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>(buscomp.consultar_listado_cbte(
                        IdEmpresaIni, IdEmpresaFin, IdTipoDocumentoIni, IdTipoDocumentoFin, IndicePagina, uC_Botones_Paginas2.Total_Registros_x_pagina,
                        FechaIni, FechaFin, listadoTipoCbtes, Stipo_Autorizacion, "PROCE", txtBusqueda.Text, ref mensajeError));

                    uC_Botones_Paginas1.NumeroPaginas = NumeroPaginas;
                }
                else
                {
                    listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>(
                        buscomp.consultar_listado_cbte(IdEmpresaIni, IdEmpresaFin, IdTipoDocumentoIni, IdTipoDocumentoFin,IndicePagina,
                        uC_Botones_Paginas2.Total_Registros_x_pagina,
                        FechaIni, FechaFin, listadoTipoCbtes, Stipo_Autorizacion, "PROCE", txtBusqueda.Text, ref mensajeError));

                    uC_Botones_Paginas1.IndicePagina = 1;
                    uC_Botones_Paginas1.NumeroPaginas = NumeroPaginas;
                }
             
                gridControl_Files.DataSource = listComprobanteRecixSRI;



            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }

        }

        public void set_parametros(DateTime fechaIni,DateTime fechaFin,string TipoAutorizacion)
        {
            try
            {
                dtp_fechaIni.Value = fechaIni;
                dtp_fechaFin.Value = fechaFin;
                cmb_tipo_Autorizacion.SelectedText = (TipoAutorizacion == "") ? "TODOS" : TipoAutorizacion;
                seteo_parametros = true;

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void UC_Impr_descar_cbtes_Lote_Load(object sender, EventArgs e)
        {
            try
            {

                cargar_combo();



                if (seteo_parametros != true)
                {
                    dtp_fechaIni.Value = new DateTime(DateTime.Now.Year , DateTime.Now.Month, 1);
                    dtp_fechaFin.Value = DateTime.Now;
                    cmb_tipo_Autorizacion.SelectedIndex = 0;
                }
                
                
            }
            catch (Exception ex)
            {
                
                
            }
            




        }


        void cargar_combo()
        {
            try
            {

                ListEmpresa = busEmpresa.GetEmpresas(ref mensajeError);
                Rpt_Ride_Bus = new Rpt_Ride_bus(ListEmpresa);


            }
            catch (Exception ex)
            {
                
                
            }

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_Files.RowCount; i++)
                {
                    gridView_Files.GetRow(i);
                    gridView_Files.SetRowCellValue(i, colCheked, chk_Todos.Checked);
                }

                gridControl_Files.RefreshDataSource();
                
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private Boolean Eliminar(tb_Comprobante_Info Info_a_Elim)
        {
            try
            {
                string msg="";


                buscomp.Eliminar_Cbte(Info_a_Elim.IdEmpresa, Info_a_Elim.IdComprobante, "","", ref msg);


                return true;
            }
            catch (Exception ex)
            {
                return false;
                
            }
        }

        private Boolean Descargar_file(tb_Comprobante_Info InfoCbteT,string Ruta_File, string OpcionNombreDes)
        {
            try
            {
                string nombreArchivo = "";
                XmlDocument xmlOrigen = new XmlDocument();
                //
                tb_Comprobante_Bus BusComprobante = new tb_Comprobante_Bus();
               InfoCbteT.s_XML= BusComprobante.Get_XML(InfoCbteT.IdEmpresa, InfoCbteT.IdComprobante, ref mensajeError);

                xmlOrigen.LoadXml((InfoCbteT.s_XML));

                if (OpcionNombreDes == "claveAcceso")
                {
                    XmlDocument xmlOrigenCdata = new XmlDocument();
                    xmlOrigenCdata.LoadXml(InfoCbteT.s_XML); 
                    string claveAcceso = xmlOrigenCdata.GetElementsByTagName("comprobante")[0].InnerXml.Replace("<![CDATA[", "").Replace("]]>", "");
                    xmlOrigenCdata.LoadXml(claveAcceso);
                    nombreArchivo = xmlOrigenCdata.GetElementsByTagName("claveAcceso")[0].InnerText;
                }
                else
                    nombreArchivo = InfoCbteT.Nom_emisor + "_" + InfoCbteT.IdComprobante;
                
                xmlOrigen.Save(Ruta_File + "\\" + nombreArchivo + ".xml");       

                return true;
            }
            catch (Exception ex)
            {
                return false;
                
            }
        }

        private Boolean Descargar_PDF_RIDE(tb_Comprobante_Info InfoCbteT, string Ruta_File, string OpcionNombreDes)
        {
            try
            {
                string msg = "";
                string nombreArchivo = "";
                XtraReport Reporte = new XtraReport();
                Reporte = Rpt_Ride_Bus.Optener_reporte(InfoCbteT, ref msg); 
                Stream FileBinary;               
                if (OpcionNombreDes == "claveAcceso")
                {
                    XmlDocument xmlOrigenCdata = new XmlDocument();
                    xmlOrigenCdata.LoadXml(InfoCbteT.s_XML);
                    string claveAcceso = xmlOrigenCdata.GetElementsByTagName("comprobante")[0].InnerXml.Replace("<![CDATA[", "").Replace("]]>", "");
                    xmlOrigenCdata.LoadXml(claveAcceso);
                    nombreArchivo = xmlOrigenCdata.GetElementsByTagName("claveAcceso")[0].InnerText;
                }
                else
                    nombreArchivo = InfoCbteT.Nom_emisor + "_" + InfoCbteT.IdComprobante;

               
                FileBinary = new FileStream(Ruta_File + "\\" + nombreArchivo + ".pdf", FileMode.Create);
                DevExpress.XtraPrinting.PdfExportOptions Optione = new DevExpress.XtraPrinting.PdfExportOptions();
                Reporte.ExportToPdf(FileBinary, Optione);
                FileBinary.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        private void Eliminar_Listado()
        {
            try
            {

                foreach (var item in listComprobanteRecixSRI)
                {

                    if (item.Checked == true)
                    {
                        Eliminar(item);
                    }

                    
                }
           }
            catch (Exception ex)
            {
                
                
            }
        }

        private void btn_eliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar_Listado();
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void Descarga_Listado_xml()
        {
            try
            {
                txtfocus.Focus();
                FolderBrowserDialog FolderDia = new FolderBrowserDialog();
                FolderDia.ShowDialog();

                string Ruta=  FolderDia.SelectedPath;
                string OpcionNombreDes;
                if (rdb_ClaveAcceso.Checked == true)
                    OpcionNombreDes = "claveAcceso";
                else
                    OpcionNombreDes = "default";

                if (Ruta != "")
                {
                    foreach (var item in listComprobanteRecixSRI)
                    {

                        if (item.Checked == true)
                        {
                            Descargar_file(item, Ruta, OpcionNombreDes);
                        }


                    }


                    MessageBox.Show("Descarga de File XML Finalizado con Exito...");
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void Descarga_Listado_PDF()
        {
            try
            {
                txtfocus.Focus();
                FolderBrowserDialog FolderDia = new FolderBrowserDialog();
                FolderDia.ShowDialog();

                string Ruta = FolderDia.SelectedPath;
                string OpcionNombreDes;
                if (rdb_ClaveAcceso.Checked == true)
                    OpcionNombreDes = "claveAcceso";
                else
                    OpcionNombreDes = "default";

                if (Ruta != "")
                {
                    foreach (var item in listComprobanteRecixSRI)
                    {
                        if (item.Checked == true)
                        {
                            Descargar_PDF_RIDE(item, Ruta, OpcionNombreDes);
                        }
                    }
                    MessageBox.Show("Descarga de File XML Finalizado con Exito...");
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void btn_descargar_Click(object sender, EventArgs e)
        {
            try
            {
                cmbEmisor.Focus();
                Descarga_Listado_xml();
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void btn_descarga_pdf_ride_Click(object sender, EventArgs e)
        {

            try
            {
                cmbEmisor.Focus();
                Descarga_Listado_PDF();
            }
            catch (Exception ex)
            {


            }

        }

        private void gridViewFiles_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void uC_Botones_Paginas1_event_click_buttons(object sender, EventArgs e, int _IndicePagina, int _Total_Registros_x_pagina)
        {
            cargar_xml(_IndicePagina, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView_Files_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                tb_Comprobante_Info InfoCbteT = new tb_Comprobante_Info();
                string MensajeError = "";
                switch (e.Column.Name)
                {
                    case "col_Ride":
                        XtraReport Reporte = new XtraReport();
                        string msg = "";
                        InfoCbteT = (tb_Comprobante_Info)gridView_Files.GetFocusedRow();
                        Reporte = Rpt_Ride_Bus.Optener_reporte(InfoCbteT, ref msg); //FAct Imporpoint
                        Reporte.ShowPreview();

                        break;

                    case "col_Xml":
                        InfoCbteT = (tb_Comprobante_Info)gridView_Files.GetFocusedRow();
                        tb_Comprobante_Bus BusCbte = new tb_Comprobante_Bus();
                        string sXML = "";
                        sXML = BusCbte.Get_XML(InfoCbteT.IdEmpresa, InfoCbteT.IdComprobante, ref MensajeError);
                        XmlDocument xmlOrigen = new XmlDocument();
                        xmlOrigen.Load(new StringReader(sXML));

                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;
                        saveFileDialog1.FileName = "SRI_" + InfoCbteT.Nombre_file;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {
                                xmlOrigen.Save(myStream);
                                myStream.Close();
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


    }
}
