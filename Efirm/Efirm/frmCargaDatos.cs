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
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info.class_sri.Retencion;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using System.Threading;
using System.Globalization;
using System.Xml;

namespace Efirm
{
    public partial class frmCargaDatos : Form
    {
        StreamWriter myWriter ;
        DirectoryInfo DirIn;
        eCliente Cliente;
      // instancias de clases
      string ConexionDbcliente = "";
      string ClienteFuente = "";
      string formatoFechaDB = "";
      string FormatoFechaSRI = "";

      BindingList<fx_GeneradorXML_Comprobante_Info> listado_cbtes_info = null;
        /// <summary>
        /// 
        /// </summary>
        List<factura> listadoFaactura = null;
        List<comprobanteRetencion> listadoRetencion=null;
        List<notaCredito> listadoNC = null;
        List<notaDebito> listadoND = null;
        List<guiaRemision> listadoGR = null;

        //instanacia de clase para obtener la configuracion del horario
        fx_horario_Info horario = new fx_horario_Info();
        /// <summary>
        /// 
        /// </summary>
        fx_Factura_Bus OBusFac = null;
        fx_NotaCredito_Bus OBusNC = null;
        fx_Retencion_Bus OBusRet = null;
        fx_Comprobantes_generados_Bus ObuscComp = null;
        fx_horario_Bus ObusHorario = null;
        public frmCargaDatos()
        {
            InitializeComponent();
           // Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("fr-FR");
            if (Thread.CurrentThread.CurrentCulture.Name != "fr-FR")
            {
                // If current culture is not fr-FR, set culture to fr-FR.
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("fr-FR");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("fr-FR");
            }
           
        }



        private void frmCargaDatos_Load(object sender, EventArgs e)
        {
            try
            {

                txtRuta.Text = Efirm.Properties.Settings.Default.PatchXml;
                chkSelecTodos.Checked = false;

                ObusHorario = new fx_horario_Bus();
                horario=  ObusHorario.ObtenerConfiguracion();
                if (horario != null)
                {
                    ValidarConfiguracionAutomatica();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }   
          
        }

        public void ValidarConfiguracionAutomatica()
        {
            
        }

        void refresh_archivos()
        {
            try
            {
                
                     DirIn = new DirectoryInfo(txtRuta.Text);
                
                FileInfo[] lista = DirIn.GetFiles("*.xml");                
                gridControlXml.DataSource = lista;
            }
            catch (Exception ex)
            {
                
                
            }
            
        }


        private void txtRuta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //fileSystemWatcher.Path = txtRuta.Text;
            }
            catch (Exception ex)
            {
                
                
            }
           
        }

        private void chkSelecTodos_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkSelecTodos.Checked == true)
            //{

            //}

            foreach (var item in listado_cbtes_info)
            {
                item.Checked = chkSelecTodos.Checked;
            }

            gridControlCbtes.Refresh();
            gridControlCbtes.DataSource = null;
            gridControlCbtes.DataSource = listado_cbtes_info;
          
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            refresh_archivos();
        }

        private void txtRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Reset();
            folder.Description = " Seleccionar una carpeta ";
            folder.SelectedPath = txtRuta.Text;
            //fileSystemWatcher.Path = txtRuta.Text;
            folder.ShowNewFolderButton = false;
            DialogResult ret = new DialogResult();
            ret = folder.ShowDialog();//' abre el diálogo   
            txtRuta.Text = folder.SelectedPath + @"\";        
            folder.Dispose();
        }

        




        private void chkSelecTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            Seleccionar_Registro_Cargados();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            refresh_archivos();
        }

        public void Seleccionar_Registro_Cargados()
        {
            try
            {
                foreach (var item in listado_cbtes_info)
                {
                    item.Checked = chkSelecTodos.Checked;
                }

                gridControlCbtes.Refresh();
                gridControlCbtes.DataSource = null;
                gridControlCbtes.DataSource = listado_cbtes_info;
            }
            catch (Exception)
            {
            }
        }

       
        public void GenerarArchivosXml()
        {
            gridControlCbtes.RefreshDataSource();
            //splashScreenManager1.ShowWaitForm();
            try
            {

                foreach (var item in listado_cbtes_info)
                {
                    string sIdCbteFact = "";
                    //item.CbteFactura.infoTributaria = new infoTributaria();


                    if (item.Checked == true)
                    { // si es factura
                        if (item.TipoCbte == eTipoComprobante.Factura)
                        {
                            try
                            {
                                
                                sIdCbteFact = item.CbteFactura.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.FAC + "-" + item.CbteFactura.infoTributaria.estab + "-" + item.CbteFactura.infoTributaria.ptoEmi + "-" + item.CbteFactura.infoTributaria.secuencial;

                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(factura));
                               
                                   myWriter = new StreamWriter(txtRuta.Text + sIdCbteFact + ".xml");

                                
                                mySerializer.Serialize(myWriter, item.CbteFactura, NamespaceObject);
                                myWriter.Close();
                                // GRABAR COMP
                                ObuscComp = new fx_Comprobantes_generados_Bus();
                                fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                                comprobante.IdRegistro = sIdCbteFact;
                                comprobante.FECHA_CARGA = DateTime.Now;
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_AX(comprobante, ConexionDbcliente);

                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }

                        }
                        // si es retencion
                        else if (item.TipoCbte == eTipoComprobante.Retencion)
                        {
                            try
                            {
                                sIdCbteFact = item.cbteRet.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.RET + "-" + item.cbteRet.infoTributaria.estab + "-" + item.cbteRet.infoTributaria.ptoEmi + "-" + item.cbteRet.infoTributaria.secuencial;
                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(comprobanteRetencion));

                               
                                    myWriter = new StreamWriter(txtRuta.Text + sIdCbteFact + ".xml");
                                //StreamWriter myWriter = new StreamWriter(txtRuta.Text + sIdCbteFact + ".xml");
                                mySerializer.Serialize(myWriter, item.cbteRet, NamespaceObject);
                                myWriter.Close();
                                // GRABAR COMP
                                ObuscComp = new fx_Comprobantes_generados_Bus();
                                fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                                comprobante.IdRegistro = sIdCbteFact;
                                comprobante.FECHA_CARGA = DateTime.Now;
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_AX(comprobante, ConexionDbcliente);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                        // si es nota de credito
                        else if (item.TipoCbte == eTipoComprobante.NotaCred)
                        {
                            try
                            {
                                sIdCbteFact = item.cbteNC.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.NTC + "-" + item.cbteNC.infoTributaria.estab + "-" + item.cbteNC.infoTributaria.ptoEmi + "-" + item.cbteNC.infoTributaria.secuencial;
                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(notaCredito));

                                
                                    myWriter = new StreamWriter(txtRuta.Text + sIdCbteFact + ".xml");
                                
                                mySerializer.Serialize(myWriter, item.cbteNC, NamespaceObject);
                                myWriter.Close();
                                // GRABAR COMP
                                ObuscComp = new fx_Comprobantes_generados_Bus();
                                fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                                comprobante.IdRegistro = sIdCbteFact;
                                comprobante.FECHA_CARGA =DateTime.Now;
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_AX(comprobante,ConexionDbcliente);

                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }

                        // si es guia de remision
                        else if (item.TipoCbte == eTipoComprobante.Guia)
                        {
                            try
                            {
                                sIdCbteFact = sIdCbteFact = item.cbtGR.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.GUI + "-" + item.cbtGR.infoTributaria.estab + "-" + item.cbtGR.infoTributaria.ptoEmi + "-" + item.cbtGR.infoTributaria.secuencial;
                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(guiaRemision));

                               
                                    myWriter = new StreamWriter(txtRuta.Text + sIdCbteFact + ".xml");

                                

                                //StreamWriter myWriter = new StreamWriter(txtRuta.Text + sIdCbteFact + ".xml");
                                mySerializer.Serialize(myWriter, item.cbtGR, NamespaceObject);
                                myWriter.Close();
                                // GRABAR COMP
                                ObuscComp = new fx_Comprobantes_generados_Bus();
                                fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                                comprobante.IdRegistro = sIdCbteFact;
                                comprobante.FECHA_CARGA = DateTime.Now;
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_AX(comprobante, ConexionDbcliente);

                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                        // si es nota debito
                        else if (item.TipoCbte == eTipoComprobante.NotaDeb)
                        {
                            try
                            {
                                sIdCbteFact = sIdCbteFact = item.cbteDeb.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.NTD + "-" + item.cbteDeb.infoTributaria.estab + "-" + item.cbteDeb.infoTributaria.ptoEmi + "-" + item.cbteDeb.infoTributaria.secuencial;
                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(notaDebito));
                               
                                    myWriter = new StreamWriter(txtRuta.Text + sIdCbteFact + ".xml");

                                

                                //StreamWriter myWriter = new StreamWriter(txtRuta.Text + sIdCbteFact + ".xml");
                                mySerializer.Serialize(myWriter, item.cbteDeb, NamespaceObject);
                                myWriter.Close();
                                // GRABAR COMP
                                ObuscComp = new fx_Comprobantes_generados_Bus();
                                fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                                comprobante.IdRegistro = sIdCbteFact;
                                comprobante.FECHA_CARGA = DateTime.Now;
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_AX(comprobante,ConexionDbcliente);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                    }
                }

                refresh_archivos();
            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
        
        }

        private void txtRuta_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Reset();
                folder.Description = " Seleccionar una carpeta ";
                folder.SelectedPath = txtRuta.Text;
                //fileSystemWatcher.Path = txtRuta.Text;
                folder.ShowNewFolderButton = false;
                DialogResult ret = new DialogResult();
                ret = folder.ShowDialog();//' abre el diálogo   
                txtRuta.Text = folder.SelectedPath + @"\";
                folder.Dispose();
            }
            catch (Exception ex) { }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

    
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     
        public void CargarDatos()
        {
                          List<string> tipo_documento = new List<string>();
                          string OconEfirm = Properties.Settings.Default.Ocon_Efirm;
            try
            {


                foreach (var item in cmb_tipo_doc.Properties.Items.GetCheckedValues().ToList())
                {
                    tipo_documento.Add(item.ToString());
                }

               

                ClienteFuente = Efirm.Properties.Settings.Default.Cliente_Fuente;
                Cliente = (eCliente)Enum.Parse(typeof(eCliente), ClienteFuente);

                ConexionDbcliente = Efirm.Properties.Settings.Default.Conexioncliente;
                formatoFechaDB = Efirm.Properties.Settings.Default.Formato_fecha;

                FormatoFechaSRI = Efirm.Properties.Settings.Default.Formato_fecha_xml_sri;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Cliente " + ex + " No Exiaste");
                return;
            }



            DateTime fechaI, fchaF;
            fechaI = dtpFechaInicio.Value;
            fchaF = dtpFechaFin.Value;
            listado_cbtes_info = new BindingList<fx_GeneradorXML_Comprobante_Info>();


            try
            {
                if (tipo_documento.Contains("Factura"))
                {

                    // listados de facturas
                    OBusFac = new fx_Factura_Bus();
                    listadoFaactura = new List<factura>();
                    listadoFaactura = OBusFac.GenerarXmlFactura(fechaI, fchaF, ConexionDbcliente,OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);
                    foreach (var item in listadoFaactura)
                    {
                        DateTime fecha;

                        try
                        {
                            fecha = Convert.ToDateTime(item.infoFactura.fechaEmision);
                            listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                                , Convert.ToDateTime(fecha), eTipoComprobante.Factura
                                , item.infoFactura.razonSocialComprador, item));
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                if (tipo_documento.Contains("Retención"))
                {
                    // listados de Retenciones
                    OBusRet = new fx_Retencion_Bus();
                    listadoRetencion = new List<comprobanteRetencion>();
                    listadoRetencion = OBusRet.GenerarXmlRetencion(fechaI, fchaF, ConexionDbcliente,OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);
                    foreach (var item in listadoRetencion)
                    {
                        try
                        {
                            listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                               , Convert.ToDateTime(item.infoCompRetencion.fechaEmision), eTipoComprobante.Retencion
                               , item.infoCompRetencion.razonSocialSujetoRetenido, item));
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                // LISTADOS DE NOTAS DE CREDITOS
                if (tipo_documento.Contains("Nota crédito"))
                {
                    OBusNC = new fx_NotaCredito_Bus();
                    listadoNC = new List<notaCredito>();
                    listadoNC = OBusNC.GenerarXmlNC(fechaI, fchaF, ConexionDbcliente,OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);
                    foreach (var item in listadoNC)
                    {
                        try
                        {
                            listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                                 , Convert.ToDateTime(item.infoNotaCredito.fechaEmision), eTipoComprobante.NotaCred
                                 , item.infoNotaCredito.razonSocialComprador, item));
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                /*

                // LISTADOS DE guias de remision
                OBusGR = new GuiaRemision_Bus();
                listadoGR = new List<guiaRemision>();
                //listadoGR = OBusGR.GenerarXmlGuiaRemision(fechaI, fchaF, Ocon);
                foreach (var item in listadoGR)
                {
                    try
                    {
                        listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                             , Convert.ToDateTime(item.infoGuiaRemision.fechaIniTransporte), eTipoComprobante.Guia
                             , item.infoGuiaRemision.razonSocialTransportista, item));
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                */
                //listados de nota debito

                /*
                OBusND = new NotaDebito_Bus();
                listadoND = new List<notaDebito>();
                listadoND = OBusND.GenerarXmlNotaDebito(fechaI, fchaF, Ocon);
                foreach (var item in listadoND)
                {
                    try
                    {
                        listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                             , Convert.ToDateTime(item.infoNotaDebito.fechaEmision), eTipoComprobante.NotaDeb
                             , item.infoNotaDebito.razonSocialComprador, item));
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                 * */
                if (listado_cbtes_info == null)
                {
                    MessageBox.Show("No hay Datos para la fecha Seleccionada");
                }
                gridControlCbtes.DataSource = listado_cbtes_info;
            }
            catch (Exception ex)
            {
            }
            finally
            {

            }

        }

   
        private void lbTimer_Click(object sender, EventArgs e)
        {

        }

    
        private void lbTiempoOcurencia_Click(object sender, EventArgs e)
        {

        }

       

        private void TxtRutaLocal_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Reset();
                folder.Description = " Seleccionar una carpeta ";
                folder.SelectedPath = txtRuta.Text;
                //fileSystemWatcher.Path = txtRuta.Text;
                folder.ShowNewFolderButton = false;
                DialogResult ret = new DialogResult();
                ret = folder.ShowDialog();//' abre el diálogo   
                folder.Dispose();
            }
            catch (Exception ex) { }
        }

      
        private void gridViewCNG_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == "collIdComprobante" || e.Column.Name == "gridColumn3" || e.Column.Name == "collTipoCbte" || e.Column.Name == "collObservacion")
                {

                //Comprobante_Info info = new Comprobante_Info();
                //info = (Comprobante_Info)gridViewCNG.GetFocusedRow();
                //XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                //NamespaceObject.Add("", "");
                //XmlSerializer mySerializer = new XmlSerializer(typeof(comprobanteRetencion));               
                //myWriter = new StreamWriter(TxtRutaLocal.Text + info.cbteRet + ".xml");
                //mySerializer.Serialize(myWriter, info.cbteRet, NamespaceObject);
                //myWriter.Close();

                //FrmXml frmXml = new FrmXml();
                
                }
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager_espera.ShowWaitForm();
                CargarDatos();
                splashScreenManager_espera.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                splashScreenManager_espera.CloseWaitForm();


            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            try
            {
                            GenerarArchivosXml();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        
        

    }
}
