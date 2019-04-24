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
using DevExpress.XtraReports.UI;
using System.IO;
using System.Net;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info.class_sri.Retencion;
using System.Xml.Serialization;
using System.Collections;
using System.Threading;
using System.Globalization;
using System.Xml;
namespace Efirm
{
    public partial class UC_CargarComprobantes : UserControl
    {

        #region variables
       
        tb_Parametro_Info InfoParametros = new tb_Parametro_Info();
        List<tb_tocken_x_usuario_tocken_Info> listUsuario_de_Tocken = new List<tb_tocken_x_usuario_tocken_Info>();
        tb_Actividades_Horario_Info InfoActividad = new tb_Actividades_Horario_Info();
        tb_Actividades_Horario_Bus BusActividad = new tb_Actividades_Horario_Bus();
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        string msg = "";
        StreamWriter myWriter;
        DirectoryInfo DirIn;
        eCliente Cliente;
        // instancias de clases
        string ConexionDbcliente = "";
        string ClienteFuente = "";
        string formatoFechaDB = "";
        string FormatoFechaSRI = "";

        BindingList<fx_GeneradorXML_Comprobante_Info> listado_cbtes_info = null;

        List<factura> listadoFaactura = null;
        List<comprobanteRetencion> listadoRetencion = null;
        List<notaCredito> listadoNC = null;
        List<notaDebito> listadoND = null;
        List<guiaRemision> listadoGR = null;

        //instanacia de clase para obtener la configuracion del horario
        fx_horario_Info horario = new fx_horario_Info();

        fx_Factura_Bus OBusFac = null;
        fx_NotaCredito_Bus OBusNC = null;
        fx_Retencion_Bus OBusRet = null;
        fx_Comprobantes_generados_Bus ObuscComp = null;
        fx_GuiaRemision_Bus OBusGuia = null;
        fx_NotaDebito_Bus OBusND = null;

        fx_horario_Bus ObusHorario = null;
     
        int countSegundosSensor_firmar = 0;
        int countSegundosRefrescarFiles = 0;
        int TiempoEspera_Proceso1 = 0;
        int TiempoEspera_Proceso2 = 0;
        string CadenaBusqueda = "";
        string mensajeError = "";
        #endregion

        public UC_CargarComprobantes()
        {
            InitializeComponent();
            uC_Horario_Actividades.event_btn_guardar_Click += uC_Horario_Actividades_event_btn_guardar_Click;
        }

        void uC_Horario_Actividades_event_btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                InfoActividad = BusActividad.consultar("CBTE_CARGAR", ref mensajeError);
            }
            catch (Exception ex)
            {
                
                
            }
            
            
            
        }
       
        private void btn_refresh_listado_Click(object sender, EventArgs e)
        {


            try
            {
                buscar_comprobantes();
                Seleccionar_Registro_Cargados();
               
            }
            catch (Exception ex)
            {

                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
            
        }

       private void btn_firmar_Click(object sender, EventArgs e)
        {
            try
            {

                GenerarArchivosXml();
            }
            catch (Exception ex)
            {

            }

        }

        void buscar_comprobantes()
        {
            try
            {
                CargarDatos();
                Seleccionar_Registro_Cargados();

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }

            
        }

        void uC_ContenedorHilos_Event_Finalizo_Proceso()
        {
            
        }

        private void UC_Comprobante_Valido_Firmado_efirm_Load(object sender, EventArgs e)
        {
            try
            {
               



                dtpFechaFin.EditValue = DateTime.Now;
                dtpFechaInicio.EditValue = DateTime.Now.AddMonths(-1);
                uC_Horario_Actividades.IdTransaccion = "CBTE_CARGAR";                
                //IdTransaccion = "CBTE_CARGAR";
                InfoActividad = BusActividad.consultar("CBTE_CARGAR", ref msg);
                txtRuta.Text = Efirm.Properties.Settings.Default.PatchXml;
                chkSelecTodos.Checked = true;

                foreach (DevExpress.XtraTab.XtraTabPage item in xtraTabControlMain.TabPages)
                {

                    xtraTabControlMain.SelectedTabPage = item;


                }
               
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }
        }

        private void timerFirmarXML_Tick(object sender, EventArgs e)
        {
            try
            {

                btn_firmar.Text = "Generar(" + countSegundosSensor_firmar + ")";

                if (countSegundosSensor_firmar <= 0)
                {
                    //TiempoEspera_Proceso1 viene del evento
                    countSegundosSensor_firmar = TiempoEspera_Proceso2;
                    timerFirmarXML.Enabled = false;// apago este proceso 
                    dtpFechaFin.EditValue = DateTime.Now;
                    dtpFechaInicio.EditValue = DateTime.Now.AddMonths(-1);
                    GenerarArchivosXml();
                }
                countSegundosSensor_firmar = countSegundosSensor_firmar - 1;


            }
            catch (Exception ex)
            {
                timerFirmarXML.Enabled = false;
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }
        }

        private void timerRefrescar_Tick(object sender, EventArgs e)
        {
            try
            {


                btn_refresh_listado.Text = "Buscar (" + countSegundosRefrescarFiles + ")";

                if (countSegundosRefrescarFiles <= 0)
                {
                    countSegundosRefrescarFiles = TiempoEspera_Proceso1;
                    timerRefrescar.Enabled = false;// apago este proceso
                     buscar_comprobantes();
                    timerFirmarXML.Enabled = true;
                }
                countSegundosRefrescarFiles = countSegundosRefrescarFiles - 1;
            }
            catch (Exception ex)
            {
                timerRefrescar.Enabled = false;
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }
        }

        void uC_Horario_Actividades_event_Disparador_horario(int _TiempoEspera_Proceso1, int _TiempoEspera_Proceso2, int _TiempoEspera_Proceso3, int _TiempoEspera_Proceso4, int _TiempoEspera_Proceso5, int _TiempoEspera_Proceso6, TimeSpan HoraDisparo, tb_Actividades_Horario_Info InfoActividad_en_proceso)
        {

            try
            {
                string msg = "";

                TiempoEspera_Proceso1 = _TiempoEspera_Proceso1;
                TiempoEspera_Proceso2 = _TiempoEspera_Proceso2;


                countSegundosRefrescarFiles = _TiempoEspera_Proceso1;
                countSegundosSensor_firmar = _TiempoEspera_Proceso2;

                timerRefrescar.Enabled = true;
                timerFirmarXML.Enabled = false;


                InfoActividad = InfoActividad_en_proceso;


                

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

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
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_FX(comprobante);

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
                                mySerializer.Serialize(myWriter, item.cbteRet, NamespaceObject);
                                myWriter.Close();
                                // GRABAR COMP
                                ObuscComp = new fx_Comprobantes_generados_Bus();
                                fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                                comprobante.IdRegistro = sIdCbteFact;
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_FX(comprobante);
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
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_FX(comprobante);

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
                                mySerializer.Serialize(myWriter, item.cbtGR, NamespaceObject);
                                myWriter.Close();
                                // GRABAR COMP
                                ObuscComp = new fx_Comprobantes_generados_Bus();
                                fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                                comprobante.IdRegistro = sIdCbteFact;
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_FX(comprobante);
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



                                mySerializer.Serialize(myWriter, item.cbteDeb, NamespaceObject);
                                myWriter.Close();
                                // GRABAR COMP
                                ObuscComp = new fx_Comprobantes_generados_Bus();
                                fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                                comprobante.IdRegistro = sIdCbteFact;
                                comprobante.Estado = "A";
                                ObuscComp.GuardarComprobantes_generados_FX(comprobante);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                    }
                }
                listado_cbtes_info = new BindingList<fx_GeneradorXML_Comprobante_Info>();
                gridControlCbtes.DataSource = listado_cbtes_info;
                gridControlCbtes.RefreshDataSource();
                


            }
            catch (Exception ex)
            {


            }
            finally
            {

            }

        }

        public void CargarDatos()
        {
            string OconEfirm = Properties.Settings.Default.Ocon_Efirm;
            try
            {

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
            fechaI =Convert.ToDateTime( dtpFechaInicio.EditValue);
            fchaF =Convert.ToDateTime( dtpFechaFin.EditValue);
            listado_cbtes_info = new BindingList<fx_GeneradorXML_Comprobante_Info>();


            try
            {


                #region listados de facturas
                OBusFac = new fx_Factura_Bus();
                listadoFaactura = new List<factura>();
                listadoFaactura = OBusFac.GenerarXmlFactura(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);
                foreach (var item in listadoFaactura)
                {
                    DateTime fecha;
                    try
                    {
                        fecha = Convert.ToDateTime(item.infoFactura.fechaEmision);
                        listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                            , Convert.ToDateTime(fecha), eTipoComprobante.Factura
                            , item.infoFactura.razonSocialComprador, item)
                            );
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                #endregion

                #region  listados de Retenciones
                OBusRet = new fx_Retencion_Bus();
                    listadoRetencion = new List<comprobanteRetencion>();
                    listadoRetencion = OBusRet.GenerarXmlRetencion(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);
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
                #endregion

                #region  LISTADOS DE NOTAS DE CREDITOS

                    OBusNC = new fx_NotaCredito_Bus();
                    listadoNC = new List<notaCredito>();
                    listadoNC = OBusNC.GenerarXmlNC(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);
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
                    #endregion

                #region  LISTADOS DE guias de remision
                OBusGuia = new fx_GuiaRemision_Bus();
                listadoGR = new List<guiaRemision>();
                listadoGR = OBusGuia.GenerarXmlGuiaRemision(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);

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

                    #endregion


                #region  LISTADOS DE NOTA EBITO
                OBusND = new fx_NotaDebito_Bus();
                listadoND = new List<notaDebito>();
                listadoND = OBusND.GenerarXmlND(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);

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

                #endregion

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

        private void txtRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void chkSelecTodos_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_Registro_Cargados();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

    }
}
