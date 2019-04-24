using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using FirmElect.Info;
using FirmElect.Bus;

using System.IO;

using iTextSharp.text.pdf;
using iTextSharp.text;

using System.Xml;
using System.Xml.Serialization;



namespace MailEfirm.Forms
{
    public partial class Frm_Carga_PDF_XML : Form
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        public Frm_Carga_PDF_XML()
        {
            InitializeComponent();
        }
   
        List<mail_Mensaje_Archi_Adjunto_Info> lista_Adjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();
    
        public void carga(List<mail_Mensaje_Archi_Adjunto_Info> lista)
        {
            try
            {
                 lista_Adjunto = lista;             
            }
            catch (Exception ex)
            {                            
            }
              
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();          
        }

        private void Frm_Carga_PDF_XML_Load(object sender, EventArgs e)
        {
            try
            {
                //// para prueba
                //string mensajeError = "";
                //mail_Mensaje_Archi_Adjunto_Bus bus_adjunto = new mail_Mensaje_Archi_Adjunto_Bus();
                //lista_Adjunto = bus_adjunto.Lista_ArchivoAdjunto_Mensaje_x_comprobante(180, ref mensajeError);
                //// para prueba

                gridControl_PDF_XML.DataSource = lista_Adjunto;
            }
            catch (Exception ex)
            {
                              
            }
        }

        private void gridView_PDF_XML_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                mail_Mensaje_Archi_Adjunto_Info InfoAdjunto = new mail_Mensaje_Archi_Adjunto_Info();
                InfoAdjunto = (mail_Mensaje_Archi_Adjunto_Info)gridView_PDF_XML.GetFocusedRow();

                if (e.Column.Name == "colCheked")
                {

                    if ((bool)gridView_PDF_XML.GetFocusedRowCellValue(colCheked))
                    {
                        gridView_PDF_XML.SetFocusedRowCellValue(colCheked, false);
                    }
                    else 
                    {
                        gridView_PDF_XML.SetFocusedRowCellValue(colCheked, true);
                    
                    }                             
                }
                
                              
                if (e.Column.Name == "colMosTrar_icono_Imprimir")
                {

                    if (InfoAdjunto.extensionArchivo==".pdf")
                   {
                       string RutaFile = Path.GetTempPath();

                       RutaFile = RutaFile + "\\" + InfoAdjunto.descripcion_archi;
                       System.IO.File.WriteAllBytes(RutaFile, InfoAdjunto.Archivo_adjunto);

                       System.Diagnostics.Process proc = new System.Diagnostics.Process();

                       proc.StartInfo.FileName = RutaFile;
                       proc.Start();
                       proc.Close();
                   
                   }

                    if (InfoAdjunto.extensionArchivo == ".Xml" || InfoAdjunto.extensionArchivo == ".xml")
                    {
                        string RutaFile = Path.GetTempPath();

                        RutaFile = RutaFile + "\\" + InfoAdjunto.descripcion_archi;

                        XmlDocument doc = new XmlDocument();
                        string xml = Encoding.UTF8.GetString(InfoAdjunto.Archivo_adjunto);
                        doc.LoadXml(xml);
                        //doc.InnerXml


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
                            frmMensaje_XML frmsg = new frmMensaje_XML();
                            frmsg.richTextBoxMensaje.Text = contenido;
                            frmsg.WindowState = FormWindowState.Maximized;
                            frmsg.ShowDialog();
                        }

                    }
                                                    
                }

                //Para Descargar

                if (e.Column.Name == "colMosTrar_icono_Descargar")
                {
                    if (InfoAdjunto.extensionArchivo == ".pdf")
                    {
                        //  Guardar archivo en ubicacion
                                                     
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Title = "Save As PDF";
                        sfd.Filter = "(*.pdf)|*.pdf";
                        sfd.InitialDirectory = @"C:\";
                        sfd.FileName = InfoAdjunto.descripcion_archi;
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {                                                 
                            string RutaFile ="";

                            RutaFile = RutaFile + "\\" + InfoAdjunto.descripcion_archi;
                            System.IO.File.WriteAllBytes(sfd.FileName, InfoAdjunto.Archivo_adjunto);

                        }                                                          
                    }

                    if (InfoAdjunto.extensionArchivo == ".xml" || InfoAdjunto.extensionArchivo == ".Xml")
                    {
                       
                        //  Guardar archivo en ubicacion

                        string xml = Encoding.UTF8.GetString(InfoAdjunto.Archivo_adjunto);

                        XmlDocument xmlOrigen = new XmlDocument();
                        xmlOrigen.Load(new StringReader(xml));

                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;
                        saveFileDialog1.FileName = InfoAdjunto.descripcion_archi;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {
                                xmlOrigen.Save(myStream);
                                myStream.Close();
                            }
                        }
                       
                    }
                                                           
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
               
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {                             
                   //validar seleccionados
                int count = lista_Adjunto.Count();

                int contaChek = lista_Adjunto.Count(q=>q.Checked==false);


                if (contaChek == count)
                {
                    MessageBox.Show("Seleccione un Registro","Sistemas");
                    return;
                
                }
                                                                      
                using (FolderBrowserDialog FBD = new FolderBrowserDialog())
                    {
                      
                        if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            string ruta = FBD.SelectedPath;
                     
                                foreach (var item in lista_Adjunto)
                                {
                                   
                                  if(item.Checked==true)
                                  {
                                    
                                    if (item.extensionArchivo == ".pdf")
                                    {
                                        string RutaFile = "";

                                        RutaFile = ruta + "\\" + item.descripcion_archi;
                                        System.IO.File.WriteAllBytes(RutaFile, item.Archivo_adjunto);
                                    }

                                    if (item.extensionArchivo == ".xml" || item.extensionArchivo == ".Xml")
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

                    MessageBox.Show("Archivos Descargados Exitosamente","Sistemas");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }
        int contador;
        int i;//bandera para controlar check
        int j;//bandera para validar si se esta selccionando un check
        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkTodos.Checked == true)
                {
                    foreach (var item in lista_Adjunto)
                    {
                        item.Checked = true;
                        contador++;
                        j = 1;
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        foreach (var item in lista_Adjunto)
                        {
                            item.Checked = false;
                            contador = 0;
                        }
                    }
                    i = 0;
                    j = 0;
                }
                gridControl_PDF_XML.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
               
            }
        }
    }
}
