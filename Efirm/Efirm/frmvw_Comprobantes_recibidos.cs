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
    public partial class frmvw_Comprobantes_recibidos : Form
    {
        #region Declaración de Variables
        vw_Comprobantes_recibidos_Info row = new vw_Comprobantes_recibidos_Info();
        vw_Comprobantes_recibidos_Bus bus = new vw_Comprobantes_recibidos_Bus();
        BindingList<vw_Comprobantes_recibidos_Info> lista = new BindingList<vw_Comprobantes_recibidos_Info>();
        string mensajeError = "";

        #endregion

        public frmvw_Comprobantes_recibidos()
        {
            InitializeComponent();
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

                dtp_fechaIni.Value = DateTime.Now.AddMonths(-1);
                dtp_fechaFin.Value = DateTime.Now.AddMonths(1);
                cargargrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargargrid();
            }
            catch (Exception ex)
            {
                            }
        }

        private void cargargrid()
        {
            try
            {
                string msg = "";
                DateTime FechaIni, FechaFin;

                FechaIni = dtp_fechaIni.Value;
                FechaFin = dtp_fechaFin.Value;

                List<string> listadoCbtesRec = new List<string>();
               
                lista = new BindingList<vw_Comprobantes_recibidos_Info>(bus.consultar(FechaIni,FechaFin,ref msg));
                
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        if (item.extencion == ".xml" || item.extencion == ".Xml")
                        {


                            string sXML = "";
                            XmlDocument doc = new XmlDocument();

                            string xml = Encoding.UTF8.GetString(item.Archivo_adjunto);
                            doc.LoadXml(xml);
                            //doc.InnerXml

                            sXML = doc.InnerXml;
                            string ruc_emisor = doc.GetElementsByTagName("ruc")[0].InnerText.Trim();
                            string tipocomp = doc.GetElementsByTagName("codDoc")[0].InnerText.Trim();
                            string Clave_Acceso = doc.GetElementsByTagName("claveAcceso")[0].InnerText.Trim();
                            string Ambiente = doc.GetElementsByTagName("ambiente")[0].InnerText.Trim();
                            string Razon_social = doc.GetElementsByTagName("razonSocial")[0].InnerText.Trim();
                            string fecha_aut = doc.GetElementsByTagName("fechaAutorizacion")[0].InnerText.Trim();
                            string num_auto = doc.GetElementsByTagName("numeroAutorizacion")[0].InnerText.Trim();
                            string Estado_SRI = doc.GetElementsByTagName("estado")[0].InnerText.Trim();
                            

                            item.s_Xml = sXML;
                            item.Ced_Ruc_Emisor = ruc_emisor;
                            item.TipoDocumento = tipocomp;
                            item.Ambiente = Ambiente;
                            item.Razon_Social_emisor = Razon_social;
                            item.Fecha = Convert.ToDateTime(fecha_aut);
                            item.ClaveAcceso = Clave_Acceso;
                            item.Estado_SRI = Estado_SRI;

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

                    }
                    


               
                }
                else
                {
                    MessageBox.Show("No registros que mostrar" + msg, "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridControlFiles.DataSource = null;
                    gridControlFiles.RefreshDataSource();
                }


                gridControlFiles.DataSource = lista;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }

        }

        private void gridViewFiles_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
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

                    if (row.extencion == ".pdf")
                    {
                        string RutaFile = Path.GetTempPath();

                        RutaFile = RutaFile + "\\" + row.descripcion_archi;
                        System.IO.File.WriteAllBytes(RutaFile, row.Archivo_adjunto);

                        System.Diagnostics.Process proc = new System.Diagnostics.Process();

                        proc.StartInfo.FileName = RutaFile;
                        proc.Start();
                        proc.Close();

                    }

                    if (row.extencion == ".Xml" || row.extencion == ".xml")
                    {
                        string RutaFile = Path.GetTempPath();

                        RutaFile = RutaFile + "\\" + row.descripcion_archi;

                        XmlDocument doc = new XmlDocument();
                        string xml = Encoding.UTF8.GetString(row.Archivo_adjunto);
                        doc.LoadXml(xml);


                        doc.Save(RutaFile);


                        System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(RutaFile);
                        string contenido = "";
                        while (reader.Read())
                        {
                            reader.MoveToContent();
                            if (reader.NodeType == System.Xml.XmlNodeType.Element)
                                contenido += "<" + reader.Name + ">\n";
                            if (reader.NodeType == System.Xml.XmlNodeType.Text)
                                contenido += reader.Value + "\n";
                        }

                        if (contenido != "")
                        {
                            frmMensaje frmsg = new frmMensaje();
                            frmsg.richTextBoxMensaje.Text = contenido;
                            frmsg.WindowState = FormWindowState.Maximized;
                            frmsg.ShowDialog();
                        }

                    }



                }


                 if (e.Column.Name == "cols_Xml")
                {

                   if (row.s_Xml != "")
                   {
                    frmMensaje frmsg = new frmMensaje();
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
                    var itemlISTA = lista.ToList().FindAll(q => q.extencion == ".Xml");

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

                                if (item.extencion == ".pdf")
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
                                if (item.extencion == ".xml" || item.extencion == ".Xml")
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


            }
        }

        private void chkPdf_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var itemlISTA = lista.ToList().FindAll(q => q.extencion == ".pdf");

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

     

    }
}
