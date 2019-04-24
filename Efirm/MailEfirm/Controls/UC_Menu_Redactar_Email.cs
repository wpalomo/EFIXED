using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Bus;
using FirmElect.Info;
using System.IO;
using DevExpress.XtraReports.UI;
using FirmElect.Reports;
using System.Xml;
using MailEfirm.Forms;
using FirmElect.Info;


namespace MailEfirm.Controls
{
    public partial class UC_Menu_Redactar_Email : UserControl
    {


        cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        string RutaArchivos = ""; string referencia;
        mail_Mensaje_Bus BusMensaje = new mail_Mensaje_Bus();
        mail_Mensaje_Archi_Adjunto_Info AdjuntoInfo = null;
        List<mail_Mensaje_Archi_Adjunto_Info> listadosArchivoaAdjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();
        List<tb_Contribuyente_Info> ListaInfoContribuyente = new List<tb_Contribuyente_Info>();
        mail_Mensaje_Info mensajeEnviar = new mail_Mensaje_Info();
        tb_Contribuyente_Bus BusContribuyebte = new tb_Contribuyente_Bus();
        mail_Mensaje_Archi_Adjunto_Bus Bus_ArchivoAdjunto = new mail_Mensaje_Archi_Adjunto_Bus();
        tb_Comprobante_Info Infocomprobante = new tb_Comprobante_Info();
        List<tb_Comprobante_Info> ListaComprobate_destinatario = new List<tb_Comprobante_Info>();
        tb_Comprobante_Bus Bus_Comprobante_emisor = new tb_Comprobante_Bus();
        mail_Validar_Correo_Info ValidarCorreo = new mail_Validar_Correo_Info();
        List<tb_Empresa_Info> listEmpr = new List<tb_Empresa_Info>();
        tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();

        List<mail_Cuentas_Correo_x_Empresa_Info> listmail_Cuentas_Correo_x_Empresa = new List<mail_Cuentas_Correo_x_Empresa_Info>();
        mail_Cuentas_Correo_x_Empresa_Bus Busmail_Cuentas_Correo_x_Empresa = new mail_Cuentas_Correo_x_Empresa_Bus();
        List<mail_Cuentas_Correo_Info> listmail_Cuentas_Correo = new List<mail_Cuentas_Correo_Info>();
        mail_Cuentas_Correo_Bus Busmail_Cuentas_Correo_Info = new mail_Cuentas_Correo_Bus();

        string message = "";
        


        
        BindingList<tb_Comprobante_Info> Listadors_de_Comprobante_Emisor = new BindingList<tb_Comprobante_Info>();


        public delegate void delegare_Correo_generado();
        public event delegare_Correo_generado Event_Correo_generado;

       


        public void setInfo(mail_Mensaje_Info info)
        {
            try
            {
                txt_correo_destinatario.Text = info.Para;
                txt_correo_destinatario_CC.Text = info.Para_CC;
                txtAsunto.Text = info.Asunto;
                txt_mensaje.Text = info.Texto_mensaje;
                cmbDestinatarios.EditValue = info.InfoContribuyente.IdContribuyente;

                //consultar  tabla mail_Mensaje_Archi_Adjunto

                string mensajeError = "";
                List<mail_Mensaje_Archi_Adjunto_Info> listaMenArchiAdj = new List<mail_Mensaje_Archi_Adjunto_Info>();
                listaMenArchiAdj = Bus_ArchivoAdjunto.Lista_ArchivoAdjunto_Mensaje_x_comprobante(info.IdMensaje, ref mensajeError);

                

                Listadors_de_Comprobante_Emisor = new BindingList<tb_Comprobante_Info>(Bus_Comprobante_emisor.ComprobantesPorEmisor(info.InfoContribuyente.cedulaRuc_contri, ref mensajeError));
                gridControlComprobantes.DataSource = Listadors_de_Comprobante_Emisor;

                if (listaMenArchiAdj.Count > 0)
                {
                    foreach (var itemFileAdjuntosxMensaje in listaMenArchiAdj)
                    {
                        foreach (var item in Listadors_de_Comprobante_Emisor)
                        {
                            if (item.IdEmpresa == itemFileAdjuntosxMensaje.IdEmpresa && item.IdComprobante == itemFileAdjuntosxMensaje.IdComprobante)
                            {
                                item.Checked = true;
                            }

                        }
                        
                    }

                    gridControlComprobantes.RefreshDataSource();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());            
            }
               
        }



        public UC_Menu_Redactar_Email()
        {
            try
            {
                InitializeComponent();
                RutaArchivos = Path.GetTempPath() + "\\"; //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
                Event_Correo_generado += UC_Menu_Redactar_Email_Event_Cerrar_form;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        void UC_Menu_Redactar_Email_Event_Cerrar_form()
        {
            
        }

        private void BtnEnviarMail_Click(object sender, EventArgs e)
        {
            txt_correo_destinatario.Focus();
            if (ValidarCorreo.email_bien_escrito(txt_correo_destinatario.Text) == false)
            {
                MessageBox.Show("Correo destinatario esta mal escrito ... Error mail no valido");
                return;
            }

            listadosArchivoaAdjunto = new List<mail_Mensaje_Archi_Adjunto_Info>();

            if (ValidarTxt() == true)
            {
                return;
            }

            Int32 Secuencia_Archivo_Adjunto = Bus_ArchivoAdjunto.SecuenciaArchivoAdjunto();
            bool BCorreo_GraboOk;
            try
            {
                tb_Contribuyente_Info InfoContribuyente = ListaInfoContribuyente.FirstOrDefault(var => var.IdContribuyente == Convert.ToDecimal(cmbDestinatarios.EditValue));

                mail_Mensaje_Info Mensaje = new mail_Mensaje_Info();
                Mensaje.InfoContribuyente = InfoContribuyente;
                Mensaje.IdContribuyente = InfoContribuyente.IdContribuyente;
                Mensaje.Para = txt_correo_destinatario.Text;
                Mensaje.Para_CC = txt_correo_destinatario_CC.Text;
                Mensaje.Asunto = txtAsunto.Text;
                Mensaje.Texto_mensaje = txt_mensaje.Text;
                Mensaje.IdTipo_Mensaje = eTipoMail.Buzon_Sal;
                Mensaje.Fecha = DateTime.Now;
                Mensaje.Eliminado = false;
                Mensaje.Respondido = false;
                Mensaje.Leido = true;

                if (lbRuta.Text == "")
                {
                    Mensaje.Tiene_Adjunto = false;
                }
                else
                {
                    Mensaje.Tiene_Adjunto = true;
                }
                Mensaje.Prioridad = 1;
                Mensaje.No_Leido = false;
                Mensaje.mail_remitente = InfoContribuyente.Mail;
                // lleno la clase de archivos adjuntos con los item check =true
                //Listadors_de_Comprobante_Emisor

                var lista_Filtrada = from filtrado in Listadors_de_Comprobante_Emisor
                                     where filtrado.Checked == true
                                     select filtrado;

                //recorro los cbtes chequeados
                foreach (var item in lista_Filtrada)
                {
                    try
                    {
                        mail_Mensaje_Archi_Adjunto_Info FilePdf = new mail_Mensaje_Archi_Adjunto_Info();
                        FilePdf.descripcion_archi = item.IdComprobante + ".pdf";
                        FilePdf.extensionArchivo = ".pdf";
                        FilePdf.Archivo_adjunto = null;
                        FilePdf.Archivo_adjunto_stream = null;
                        FilePdf.IdComprobante = item.IdComprobante;
                        listadosArchivoaAdjunto.Add(FilePdf);
                        FilePdf.Secuencia = 1;
                        FilePdf.IdEmpresa = item.IdEmpresa;

                        mail_Mensaje_Archi_Adjunto_Info FileXML = new mail_Mensaje_Archi_Adjunto_Info();
                        FileXML.descripcion_archi = item.IdComprobante + ".xml";
                        FileXML.extensionArchivo = ".xml";
                        FileXML.Archivo_adjunto = null;
                        FileXML.Archivo_adjunto_stream = null;
                        FileXML.IdComprobante = item.IdComprobante;
                        listadosArchivoaAdjunto.Add(FileXML);
                        FileXML.Secuencia = 2;
                        FileXML.IdEmpresa = item.IdEmpresa;

                        if (lbRuta.Text != "Ruta del Archivo Adjunto")
                        {
                            AdjuntoInfo = new mail_Mensaje_Archi_Adjunto_Info();
                            AdjuntoInfo.IdMensaje = BusMensaje.IdMensaje();
                            AdjuntoInfo.Secuencia = Secuencia_Archivo_Adjunto;
                            FileStream file = new FileStream(lbRuta.Text, FileMode.Open);
                            Byte[] ArchivoAdjunto = new byte[file.Length];
                            file.Read(ArchivoAdjunto, 0, Convert.ToInt32(file.Length));
                            AdjuntoInfo.Archivo_adjunto = ArchivoAdjunto;
                            AdjuntoInfo.extensionArchivo = Path.GetExtension(lbRuta.Text);
                            AdjuntoInfo.descripcion_archi = Path.GetFileName(lbRuta.Text);
                            listadosArchivoaAdjunto.Add(AdjuntoInfo);
                            Secuencia_Archivo_Adjunto = Secuencia_Archivo_Adjunto + 1;
                            file.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                    }
                }

                Mensaje.list_Archivos_Adjuntos = listadosArchivoaAdjunto;//le asigno la lista de archivo adjunto a la clase mensaje que lleva los datos para enviar el correo
                DialogResult result = DialogResult.Yes;

                if (txtAsunto.Text == "")
                {
                    result = MessageBox.Show("El Mensaje no Tiene Asunto Desea Enviar sin Asunto?", "MailEfirm", MessageBoxButtons.YesNoCancel);
                }

                if (result == DialogResult.Yes)
                {

                    mail_Cuentas_Correo_x_Empresa_Info InfoCtaxCorreo = new mail_Cuentas_Correo_x_Empresa_Info();
                    mail_Cuentas_Correo_Info InfoCtaCorreo = new mail_Cuentas_Correo_Info();
                    listmail_Cuentas_Correo_x_Empresa = Busmail_Cuentas_Correo_x_Empresa.Consulta_mail_Cuentas_Correo_x_Empresa(ref message);

                    InfoCtaxCorreo = listmail_Cuentas_Correo_x_Empresa.Find(v => v.IdEmpresa == Mensaje.InfoContribuyente.IdEmpresa);
                    InfoCtaCorreo = listmail_Cuentas_Correo.Find(v => v.IdCuenta == InfoCtaxCorreo.IdCuenta);

                    Mensaje.IdCuenta = InfoCtaCorreo.IdCuenta;
                    Mensaje.mail_remitente = InfoCtaCorreo.direccion_correo;

                    BCorreo_GraboOk = BusMensaje.GrabarMensajeDB(Mensaje, ref referencia);
                    if (BCorreo_GraboOk == true)
                    {

                        try
                        {



                            if (InfoCtaCorreo.enviar_copia_x_cada_mail_enviado == true)
                            {
                                Mensaje.Asunto = "Copia Bak. " + Mensaje.Asunto;
                                Mensaje.Asunto_texto_mostrado = "Copia Bak. " + Mensaje.Asunto_texto_mostrado;
                                Mensaje.IdMensaje = 0;
                                Mensaje.Para = InfoCtaCorreo.cta_mail_para_envio_x_cbte_enviado;
                                BCorreo_GraboOk = BusMensaje.GrabarMensajeDB(Mensaje, ref referencia);
                            }

                        }
                        catch (Exception)
                        { }

                        Event_Correo_generado();

                    }
                    else
                    {
                        MessageBox.Show("Correo No Guardado Coreectamente");
                    }





                }
                else if (result == DialogResult.No)
                {
                    txtAsunto.Focus();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void panelControl_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public void CargarContribuyentes()
        {
            string mensaje = "";
            try
            {
                ListaInfoContribuyente=BusContribuyebte.GetListContribuyente(ref mensaje);
                cmbDestinatarios.Properties.DataSource = ListaInfoContribuyente;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void UC_Menu_Redactar_Email_Load(object sender, EventArgs e)
        {
            try
            {
                string msg = "";

                CargarContribuyentes();
                listEmpr = BusEmpresa.GetEmpresas(ref msg);

                listmail_Cuentas_Correo_x_Empresa = Busmail_Cuentas_Correo_x_Empresa.Consulta_mail_Cuentas_Correo_x_Empresa(ref msg);
                listmail_Cuentas_Correo = Busmail_Cuentas_Correo_Info.consultar(ref msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }


        }

        private void BtnAdjuntar_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opd = new OpenFileDialog();
                opd.DefaultExt = ".*";
                opd.Filter = "Archivo (.*)|*.*";
                opd.ShowDialog();
                lbRuta.Text = opd.FileName;
                //listadosArchivoaAdjunto
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void cmbDestinatarios_Click(object sender, EventArgs e)
        {

        }

        private void cmbDestinatarios_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string mensajeEror = "";

                tb_Contribuyente_Info Info =ListaInfoContribuyente.FirstOrDefault(v => v.IdContribuyente == Convert.ToDecimal( cmbDestinatarios.EditValue));
                if (Info != null)
                {

                    Listadors_de_Comprobante_Emisor = new BindingList<tb_Comprobante_Info>(Bus_Comprobante_emisor.ComprobantesPorEmisor(Info.cedulaRuc_contri, ref mensajeEror));
                    gridControlComprobantes.DataSource = Listadors_de_Comprobante_Emisor;
                    txt_correo_destinatario.Text = Info.Mail;
                    txt_correo_destinatario_CC.Text = Info.Mail_secundario;

                    String CuerpoMensaje = "Estimado(a):" + Info.Nom_Contribuyente + "\n";
                    CuerpoMensaje = CuerpoMensaje + "\n";
                    CuerpoMensaje = CuerpoMensaje + " Se le informa que ha recibido un nuevo comprobante electronico";
                    CuerpoMensaje = CuerpoMensaje + "\n";
                    CuerpoMensaje = CuerpoMensaje + "\n";

                    txt_mensaje.Text = CuerpoMensaje;



                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }


        private void Creacion_pdf_a_directorio_TMP()
        {
            try
            {
                
                foreach (var item in Listadors_de_Comprobante_Emisor)
                {

                    if (item.Checked == true)
                    {
                        Crear_Pdf_en_TMP(item, RutaArchivos);
                    }
                }
               // MessageBox.Show("Descarga de File XML Finalizado con Exito...");
            }
            catch (Exception ex)
            {
                
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Creacion_pdf_a_directorio_TMP();
        }


        private Boolean Crear_Pdf_en_TMP(tb_Comprobante_Info InfoCbteT, string Ruta_File)
        {
            try
            {
                string msg = "";
                XtraReport Reporte = new XtraReport();              
                tb_Empresa_Bus EmB = new tb_Empresa_Bus();
                


                Rpt_Ride_bus Rpt_Ride_Bus = new Rpt_Ride_bus(listEmpr);
                Reporte = Rpt_Ride_Bus.Optener_reporte(InfoCbteT, ref msg);
                //pdf
                Stream FileBinary;
                FileBinary = new FileStream(Ruta_File + "\\" + InfoCbteT.IdComprobante + ".pdf", FileMode.Create);
                DevExpress.XtraPrinting.PdfExportOptions Optione = new DevExpress.XtraPrinting.PdfExportOptions();
                Reporte.ExportToPdf(FileBinary, Optione);
                FileBinary.Close();               
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                return false;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridControlComprobantes_Click(object sender, EventArgs e)
        {

        }

        private void txt_mensaje_Click(object sender, EventArgs e)
        {

        }

        public bool ValidarTxt()
        {
            bool Bsi_Text_Null=false;
            try
            {
                if (cmbDestinatarios.Text == "")
                {
                    cmbDestinatarios.Focus();
                    errorPValidarTxt.SetError(cmbDestinatarios,"Escoga un Destinatario");
                    Bsi_Text_Null = true;
                }
                if (txt_correo_destinatario.Text == "")
                {
                    txt_correo_destinatario.Focus();
                    errorPValidarTxt.SetError(txt_correo_destinatario, "Digite el Correo del destinatario");
                    Bsi_Text_Null = true;
                }
                return Bsi_Text_Null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                return Bsi_Text_Null;
            }
        }

        private void gridViewgridComprobantes_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            try
            {
                if (e.Column.Name == "colChecked")
                {

                    if ((bool)gridViewgridComprobantes.GetFocusedRowCellValue(colChecked))
                    {
                        gridViewgridComprobantes.SetFocusedRowCellValue(colChecked, false);

                    }
                    else
                    {
                        gridViewgridComprobantes.SetFocusedRowCellValue(colChecked, true);
                    }

                    tb_Contribuyente_Info Info  = ListaInfoContribuyente.FirstOrDefault(v => v.IdContribuyente == Convert.ToDecimal(cmbDestinatarios.EditValue));
                    string Nom_Emisor_Aux = "";
                    string Nom_Emisor = "";



                    

                    String CuerpoMensaje = "Estimado(a):" + Info.Nom_Contribuyente + "\n";
                    CuerpoMensaje = CuerpoMensaje + "\n";
                    CuerpoMensaje = CuerpoMensaje + " Se le informa que ha recibido un nuevo comprobante electronico";
                    CuerpoMensaje = CuerpoMensaje + "\n";
                    CuerpoMensaje = CuerpoMensaje + "\n";

                   


                    CuerpoMensaje = CuerpoMensaje + "Resumen";
                    CuerpoMensaje = CuerpoMensaje + "\n";


                    foreach (var item in Listadors_de_Comprobante_Emisor)
                    {
                        if (item.Checked == true)
                        {
                            Nom_Emisor_Aux = "";

                            CuerpoMensaje = CuerpoMensaje + "Tipo de Documento:" + item.Nom_TipoDocumento + "\n";
                            CuerpoMensaje = CuerpoMensaje + "No. documento:" + item.IdComprobante + "\n";
                            CuerpoMensaje = CuerpoMensaje + "Fecha de Emisión:" + item.Fecha_Emi_Fact + "\n";
                            CuerpoMensaje = CuerpoMensaje + "No.Autorizacion:" + item.Numero_Autorizacion + "\n";
                            CuerpoMensaje = CuerpoMensaje + "Fecha Autorizacion:" + item.FechaAutorizacion + "\n";
                            CuerpoMensaje = CuerpoMensaje + "\n";

                            Nom_Emisor_Aux = item.Nom_emisor;
                            
                            
                        
                        }

                        
                    }

                   
                    CuerpoMensaje = CuerpoMensaje + "Atentamente,";
                    CuerpoMensaje = CuerpoMensaje + "\n";
                    CuerpoMensaje = CuerpoMensaje + Nom_Emisor_Aux;
                    CuerpoMensaje = CuerpoMensaje + "\n";

                    CuerpoMensaje = CuerpoMensaje + "\n";
                    CuerpoMensaje = CuerpoMensaje + "Ahorremos papel y ayudemos al medio ambiente! ";
                    CuerpoMensaje = CuerpoMensaje + "\n";
                    
                    CuerpoMensaje = CuerpoMensaje + "\n";
                    CuerpoMensaje = CuerpoMensaje + " Tr:" + "Mail Manual" + " fx:" + "gridViewgridComprobantes_RowCellClick";
                    CuerpoMensaje = CuerpoMensaje + " version:" + param.Version;

                    


                    txt_mensaje.Text = CuerpoMensaje;


                    
                }


               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }



            
        }

        private void gridViewgridComprobantes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void TopSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
         
        }



































    }
}
