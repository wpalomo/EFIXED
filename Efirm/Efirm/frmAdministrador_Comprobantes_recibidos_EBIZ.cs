using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Bus;
using FirmElect.Info;
using FirmElect.Bus;
using DevExpress.XtraReports.UI;

using System.IO;

//using iTextSharp.text.pdf;
//using iTextSharp.text;

using System.Xml;
using System.Xml.Serialization;

namespace Efirm
{
    public partial class frmAdministrador_Comprobantes_recibidos_EBIZ : Form
    {
        #region Declaración de Variables
        vw_Comprobantes_recibidos_Info row = new vw_Comprobantes_recibidos_Info();
        vw_Comprobantes_recibidos_Bus bus = new vw_Comprobantes_recibidos_Bus();
        List<vw_Comprobantes_recibidos_Info> lista = new List<vw_Comprobantes_recibidos_Info>();

        string mensajeError = "";
        int NumeroPaginas = 0;   
        #endregion

        public frmAdministrador_Comprobantes_recibidos_EBIZ()
        {
            try
            {
                InitializeComponent();
                dtp_fechaIni.EditValue = DateTime.Now.AddMonths(-1);
                dtp_fechaFin.EditValue = DateTime.Now.AddMonths(1);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
           
        }

        private void gridViewFiles_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                row = (vw_Comprobantes_recibidos_Info)gridViewFiles.GetFocusedRow();


              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }
        }
       
        private void frmvw_Comprobantes_recibidos_Load(object sender, EventArgs e)
        {
            try
            {

                //cargargrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }
        }

        private void cargargrid(int IndicePagina, int NumeroPaginas)
        {
            try
            {
                string msg = "";

                string ruc_emisor = "";
                string tipocomp = "";
                string Clave_Acceso = "";
                string Ambiente = "";
                string Razon_social = "";
                string sXML = "";
                string fecha_aut = "";
                string num_auto = "";
                string Estado_SRI = "";
                string sXml_a_descerializar = "";


                tb_Comprobante_Bus ComprobanteBUS = new FirmElect.Bus.tb_Comprobante_Bus();
                DateTime FechaIni, FechaFin;

                FechaIni = Convert.ToDateTime(dtp_fechaIni.EditValue);
                FechaFin = Convert.ToDateTime(dtp_fechaFin.EditValue);

                List<string> listadoCbtesRec = new List<string>();
                NumeroPaginas = bus.ObtenerNumPag(uC_Botones_Paginas1.Total_Registros_x_pagina, FechaIni, FechaFin, txtBusqueda.Text, ref msg);
                if (NumeroPaginas >= IndicePagina)
                {
                    lista = bus.consultar(IndicePagina, uC_Botones_Paginas1.Total_Registros_x_pagina, FechaIni, FechaFin, txtBusqueda.Text, ref msg);                    
                    uC_Botones_Paginas1.NumeroPaginas = NumeroPaginas;
                }
                else
                {
                    lista = bus.consultar(1, uC_Botones_Paginas1.Total_Registros_x_pagina, FechaIni, FechaFin, txtBusqueda.Text, ref msg);                    
                    uC_Botones_Paginas1.IndicePagina = 1; 
                    uC_Botones_Paginas1.NumeroPaginas = NumeroPaginas; 
                }





               
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        if (item.extencion.ToUpper() == ".XML")
                        {

                          
                            
                            XmlDocument doc = new XmlDocument();
                            string xml  = Encoding.UTF8.GetString(item.Archivo_adjunto);
                           
                            try
                            { 
                               
                                doc.LoadXml(xml);

                            }
                            catch (Exception ex)
                            {  
                                item.ClaveAcceso = ex.Message;
                                item.Error = ex.Message;
                                continue;                              
                            }
                          

                          
                            try
                            {

                                sXML = doc.InnerXml;
                                try
                                {
                                    fecha_aut = doc.GetElementsByTagName("fechaAutorizacion")[0].InnerText.Trim();
                                    num_auto = doc.GetElementsByTagName("numeroAutorizacion")[0].InnerText.Trim();
                                    Estado_SRI = doc.GetElementsByTagName("estado")[0].InnerText.Trim();

                                }
                                catch (Exception ex)
                                {
                                    item.Error ="Error en estructura de Xml: No se encuentran los Tags de Autorización "+ ex.Message;
                                    item.ClaveAcceso = item.Error;
                                    continue;     
                                   
                                }
                                
                                
                                 sXml_a_descerializar="";
                                sXml_a_descerializar = ComprobanteBUS.Quitar_a_xml_CDATA_y_Signature(doc.GetElementsByTagName("comprobante")[0].InnerXml,ref mensajeError);
                                if (sXml_a_descerializar == "")
                                {
                                    item.Error = mensajeError;
                                    item.ClaveAcceso = item.Error;
                                    continue;      
                                }

                                XmlDocument xmlCbte_a_descr = new XmlDocument();
                                xmlCbte_a_descr.Load(new StringReader(sXml_a_descerializar));

                                ruc_emisor = xmlCbte_a_descr.GetElementsByTagName("ruc")[0].InnerText.Trim();
                                tipocomp = xmlCbte_a_descr.GetElementsByTagName("codDoc")[0].InnerText.Trim();
                                Clave_Acceso = xmlCbte_a_descr.GetElementsByTagName("claveAcceso")[0].InnerText.Trim();
                                Ambiente = xmlCbte_a_descr.GetElementsByTagName("ambiente")[0].InnerText.Trim();
                                Razon_social = xmlCbte_a_descr.GetElementsByTagName("razonSocial")[0].InnerText.Trim();

                            }
                            catch (Exception ex)
                            {
                               
                                item.Error = ex.Message;
                                item.ClaveAcceso = item.Error;
                                continue;                      
                                
                            }

                            try
                            {

                                item.s_Xml = sXML;
                                item.Ced_Ruc_Emisor = ruc_emisor;
                                item.TipoDocumento = tipocomp;
                                item.Ambiente = Ambiente;
                                item.Razon_Social_emisor = Razon_social;
                                item.ClaveAcceso = Clave_Acceso;
                                item.Estado_SRI = Estado_SRI;
                                item.fecha_aut = fecha_aut;
                                item.num_auto = num_auto;

                                if (item.TipoDocumento == "01")
                                { tipocomp = "Factura"; }

                                if (item.TipoDocumento == "04")
                                { tipocomp = "NOTA CREDITO"; }

                                if (item.TipoDocumento == "05")
                                { tipocomp = "NOTA DEBITO"; }

                                if (item.TipoDocumento == "06")
                                { tipocomp = "GUIA REMISION"; }

                                if (item.TipoDocumento == "07")
                                { tipocomp = "RETENCION FTE"; }

                                item.nomTipoDoc = tipocomp;

                            }
                            catch (Exception ex)
                            {
                                
                                item.Error = ex.Message;
                                item.ClaveAcceso = item.Error;
                                continue;       
                            }

                           
                            
                        }

                    }
                    


               
                }
                else
                {
                     MessageBox.Show("No registros que mostrar" + msg, "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridControlFiles.DataSource = null;
                    gridControlFiles.RefreshDataSource();
                }


                var listMensajes_XML = lista.GroupBy(u => u.IdMensaje).Select(grp => grp.ToList()).ToList();


                List<vw_Comprobantes_recibidos_Info> lista_Auxi = new List<vw_Comprobantes_recibidos_Info>();




                foreach (var item in listMensajes_XML)
                {
                    try
                    {

                        var QXML = item.Find(v => v.extencion == ".XML");


                        for (int i = 0; i < item.Count; i++)
                        {
                            string sExtencion = item[i].extencion;

                            if (sExtencion == ".PDF" && QXML!=null)
                            {

                                item[i].Ced_Ruc_Emisor = QXML.Ced_Ruc_Emisor;
                                item[i].nomTipoDoc = QXML.nomTipoDoc;
                                item[i].ClaveAcceso = QXML.ClaveAcceso;
                                item[i].Ambiente = QXML.Ambiente;
                                item[i].Razon_Social_emisor = QXML.Razon_Social_emisor;
                                item[i].fecha_aut = QXML.fecha_aut;
                                item[i].num_auto = QXML.num_auto;
                                item[i].Estado_SRI = QXML.Estado_SRI;

                            }
                        }

                        var QPDF = item.Find(v => v.extencion == ".PDF");

                        if (QXML != null)
                        { lista_Auxi.Add(QXML); }

                        if (QPDF != null)
                        { lista_Auxi.Add(QPDF); }


                    }
                    catch (Exception ex)
                    {
                        
                        
                    }
                    

                    
                }



                gridControlFiles.DataSource = lista_Auxi;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }

        }

        private void gridViewFiles_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string xml = ""; frmMensaje frmsg = null;
            try
            {
                row = (vw_Comprobantes_recibidos_Info)gridViewFiles.GetFocusedRow();

                if (e.Column.Name == "colCheked")
                {

                    if ((bool)gridViewFiles.GetFocusedRowCellValue(colCheked))
                    {
                        gridViewFiles.SetFocusedRowCellValue(colCheked, false);
                    }
                    else
                    {
                        gridViewFiles.SetFocusedRowCellValue(colCheked, true);

                    }
                }


                if (e.Column.Name == "colextencion")
                {

                    if (row.extencion.ToUpper() == ".PDF")
                    {
                        string RutaFile = Path.GetTempPath();

                        RutaFile = RutaFile + "\\" + row.descripcion_archi;
                        System.IO.File.WriteAllBytes(RutaFile, row.Archivo_adjunto);

                        System.Diagnostics.Process proc = new System.Diagnostics.Process();

                        proc.StartInfo.FileName = RutaFile;
                        proc.Start();
                        proc.Close();

                    }

                    if (row.extencion.ToUpper() == ".XML")
                    {
                        try
                        { 
                        string RutaFile = Path.GetTempPath();
                        string sxml = "";
                        RutaFile = RutaFile + "\\" + row.descripcion_archi;
                        XmlDocument doc = new XmlDocument();
                        xml = Encoding.UTF8.GetString(row.Archivo_adjunto);


                        frmsg = new frmMensaje();
                        frmsg.richTextBoxMensaje.Text = xml;
                        frmsg.WindowState = FormWindowState.Maximized;
                        frmsg.ShowDialog();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error "+ex.Message);
                           
                        }

                    }



                }


                 if (e.Column.Name == "cols_Xml")
                {

                   if (row.s_Xml != "")
                   {
                     frmsg = new frmMensaje();
                    frmsg.richTextBoxMensaje.Text = row.s_Xml;
                    frmsg.WindowState = FormWindowState.Maximized;
                    frmsg.ShowDialog();
                  }
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void chkXml_CheckedChanged(object sender, EventArgs e)
        {
            try
            {               
                    var itemlISTA = lista.ToList().FindAll(q => q.extencion.ToUpper() == ".XML");

                    foreach (var item2 in itemlISTA)
                    {
                        item2.Checked = chkXml.Checked;
                    }                

                gridControlFiles.RefreshDataSource();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnDescargaPDF_Click(object sender, EventArgs e)
        {
            try
            {                
                int count = lista.Count();
                int contaChek = lista.Count(q => q.Checked == false);

                if (contaChek == count)
                {
                    MessageBox.Show("Seleccione un Registro", "Sistemas");
                    return;
                }
                using (FolderBrowserDialog FBD = new FolderBrowserDialog())
                {

                    if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string ruta = FBD.SelectedPath;

                        foreach (var item in lista)
                        {

                            if (item.Checked == true)
                            {

                                if (item.extencion.ToUpper() == ".PDF")
                                {
                                    string RutaFile = "";

                                    RutaFile = ruta + "\\" + item.descripcion_archi;
                                    System.IO.File.WriteAllBytes(RutaFile, item.Archivo_adjunto);
                                }
                                
                            }
                        }
                    }


                }

                MessageBox.Show("PDF Descargados Exitosamente", "Sistemas");
            }
            catch (Exception ex)
            {
            }
        }

        private void btnDescargaXML_Click(object sender, EventArgs e)
        {
            try
            {
                //validar seleccionados
                int count = lista.Count();

                int contaChek = lista.Count(q => q.Checked == false);


                if (contaChek == count)
                {
                    MessageBox.Show("Seleccione un Registro", "Sistemas");
                    return;

                }

                using (FolderBrowserDialog FBD = new FolderBrowserDialog())
                {

                    if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string ruta = FBD.SelectedPath;

                        foreach (var item in lista)
                        {

                            if (item.Checked == true)
                            {
                                if (item.extencion.ToUpper() == ".XML" )
                                {

                                    string RutaFile = "";

                                    RutaFile = ruta + "\\" + item.descripcion_archi;

                                    XmlDocument doc = new XmlDocument();
                                    string xml = Encoding.UTF8.GetString(item.Archivo_adjunto);
                                    doc.LoadXml(xml);

                                    doc.Save(RutaFile);

                                }
                            }
                        }
                    }

                }

                MessageBox.Show("XML Descargados Exitosamente", "Sistemas");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ex.Message);

            }
        }

        private void chkPdf_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var itemlISTA = lista.ToList().FindAll(q => q.extencion.ToUpper() == ".PDF");

                foreach (var item2 in itemlISTA)
                {
                    item2.Checked = chkPdf.Checked;
                }

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
                var data = gridViewFiles.GetRow(e.RowHandle) as vw_Comprobantes_recibidos_Info;
                if (data == null)
                    return;
                if (data.Error != null)
                {
                    if (data.Error.Length > 0)
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
               // BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            gridViewFiles.ViewCaption = "";
        }
      
        private void cmbRegistro_X_Pag_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                frmvw_Comprobantes_recibidos_Load(sender, e);
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Error " + ex.Message); 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargargrid(uC_Botones_Paginas1.IndicePagina, uC_Botones_Paginas1.NumeroPaginas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void uC_Botones_Paginas1_event_click_buttons(object sender, EventArgs e, int _IndicePagina, int _Total_Registros_x_pagina)
        {
            cargargrid(_IndicePagina, 0);
        }

     

    }
}
