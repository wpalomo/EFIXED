using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System.Diagnostics;
using FirmElect.Info;
using FirmElect.Bus;
using System.Xml;


namespace Efirm
{
    public partial class frmValidadorFileXML : Form
    {

        
        
        BindingList<Archivo_Info> listArchivos = new BindingList<Archivo_Info>();


        public frmValidadorFileXML()
        {
            InitializeComponent();
        }


        private void frmValidadorFileXML_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_file_desde_directorio(txt_ruta.Text);
            }
            catch (Exception ex)
            {
                
                
            }

        }

        void cargar_file_desde_directorio(string Patch)
        {

            try
            {

                listArchivos.Clear();
                gridControlDirectorio.DataSource = null;


                // System.IO.DriveInfo di = new System.IO.DriveInfo(@Patch);

                // Get the root directory and print out some information about it.
                System.IO.DirectoryInfo dirInfo = new DirectoryInfo(Patch);


                // Get the files in the directory and print out some information about them.
                System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.xml");



                // linea datasource q carga
                


                foreach (var itemFile in fileNames)
                {
                    Archivo_Info itemAr = new Archivo_Info();

                    itemAr.Checked = true;
                    itemAr.CreationTime = itemFile.CreationTime;
                    itemAr.Estado_Valicion = "";
                    itemAr.Extension = itemFile.Extension;
                    itemAr.FullName = itemFile.FullName;
                    itemAr.LastAccessTime = itemFile.LastAccessTime;
                    itemAr.Length = itemFile.Length;
                    itemAr.mensaje_error_validacion = "";
                    itemAr.Name = itemFile.Name;

                    listArchivos.Add(itemAr);

                }





                gridControlDirectorio.DataSource = listArchivos;

            }
            catch (Exception ex)
            {
                
                
            }

            
        
        }

        private void btnBuscarDirectorio_Click(object sender, EventArgs e)
        {
            try
            {

                FolderBrowserDialog FolderDia = new FolderBrowserDialog();
                FolderDia.ShowDialog();

                txt_ruta.Text = FolderDia.SelectedPath;

                cargar_file_desde_directorio(txt_ruta.Text);

            }
            catch (Exception ex)
            {
                
                
            }

            
            
        }

        private void gridControlDirectorio_Click(object sender, EventArgs e)
        {

        }

        private void btn_validar_file_xml_Click(object sender, EventArgs e)
        {
            
            validar_archivos();
            
        }


        void validar_archivos()
        {

            string tipocomp = "";

            foreach (var item in listArchivos)
            {
                // cargando el file y leyendo el tag de tipo de documento
                XmlDocument comprobante = new XmlDocument();

                try
                {
                    comprobante.Load(item.FullName);
                    tipocomp = comprobante.GetElementsByTagName("codDoc")[0].InnerText.Trim();
                }
                catch (Exception)
                {
                    tipocomp = "";
                }

                string mensaje = "";
                switch (tipocomp)
                {
                    case "01":
                            factura_Bus factBus = new factura_Bus();
                            if (factBus.Validar_xml_vs_sxd(comprobante, ref mensaje))
                            {
                               item.Estado_Valicion = "VALIDO";
                            }
                            else
                            {
                                item.Estado_Valicion = "ERROR";
                            }
                            item.mensaje_error_validacion = mensaje;
                            
                        break;
                    case "04":

                        notaCredito_Bus Bus_nota_cred = new notaCredito_Bus();
                        if (Bus_nota_cred.Validar_xml_vs_sxd(comprobante, ref mensaje))
                            {
                               item.Estado_Valicion = "VALIDO";
                            }
                            else
                            {
                                item.Estado_Valicion = "ERROR";
                            }
                            item.mensaje_error_validacion = mensaje;
                        break;
                    case "05":

                        notaDebito_Bus Bus_nota_deb = new notaDebito_Bus();
                        if (Bus_nota_deb.Validar_xml_vs_sxd(comprobante, ref mensaje))
                            {
                               item.Estado_Valicion = "VALIDO";
                            }
                            else
                            {
                                item.Estado_Valicion = "ERROR";
                            }
                            item.mensaje_error_validacion = mensaje;
                        break;
                    case "06":
                        fx_GuiaRemision_Bus Bus_guia = new fx_GuiaRemision_Bus();
                        if (Bus_guia.Validar_xml_vs_sxd(comprobante, ref mensaje))
                            {
                               item.Estado_Valicion = "VALIDO";
                            }
                            else
                            {
                                item.Estado_Valicion = "ERROR";
                            }
                            item.mensaje_error_validacion = mensaje;
                        break;
                    case "07":

                        comprobanteRetencion_Bus Bus_ret = new comprobanteRetencion_Bus();
                        if (Bus_ret.Validar_xml_vs_sxd(comprobante, ref mensaje))
                            {
                               item.Estado_Valicion = "VALIDO";
                            }
                            else
                            {
                                item.Estado_Valicion = "ERROR";
                            }
                            item.mensaje_error_validacion = mensaje;
                        break;
                    default:
                        item.Estado_Valicion = "ERROR";
                        item.mensaje_error_validacion = "Archivo no  tiene el tag codDoc o no es un xml valido del SRI";
                       break;
                }                

            }

            gridControlDirectorio.DataSource = null;
            gridControlDirectorio.DataSource = listArchivos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            

        }

        private void gridViewDirectorio_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewDirectorio.GetRow(e.RowHandle) as Archivo_Info;
                if (data == null)
                    return;
                if (data.mensaje_error_validacion.ToString() != "")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                //Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewDirectorio_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colmensaje_error_validacion")
                {

                    string mensaje = (string)gridViewDirectorio.GetFocusedRowCellValue(colmensaje_error_validacion);


                    if (mensaje != "")
                    {

                        frmMensaje frmsg = new frmMensaje();
                        frmsg.richTextBoxMensaje.Text = mensaje;
                        frmsg.ShowDialog();
                    }
                }


                if (e.Column.Name == "colName")
                {


                    // cargando el file y leyendo el tag de tipo de documento
                    string fulname = (string)gridViewDirectorio.GetFocusedRowCellValue(colFullName);
                    XmlDocument comprobante = new XmlDocument();

                    try
                    {
                        comprobante.Load(fulname);

                        if (comprobante.InnerXml != "")
                        {

                            frmMensaje frmsg = new frmMensaje();
                            frmsg.richTextBoxMensaje.Text = comprobante.InnerXml;
                            frmsg.ShowDialog();
                        }

                     
                    }
                    catch (Exception)
                    {

                        //tipocomp = "";
                    }

                }

            }
            catch (Exception ex)
            {
                
                
            }

            

        }

        
        
    }
}
