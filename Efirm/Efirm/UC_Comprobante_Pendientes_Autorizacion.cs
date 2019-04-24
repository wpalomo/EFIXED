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
using System.Net;
using System.Threading;


namespace Efirm
{
    public partial class UC_Comprobante_Pendientes_Autorizacion : UserControl
    {

        tb_Comprobante_Bus buscomp = new tb_Comprobante_Bus();
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        BindingList<tb_Comprobante_Info> listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>();
        List<tb_Comprobante_Info> listComprobanteValidosFirmados = new List<tb_Comprobante_Info>();
        List<tb_Empresa_Info> ListEmpresa = new List<tb_Empresa_Info>();
        List<tb_Tocken_Info> listTocken = new List<tb_Tocken_Info>();
        tb_Parametro_Info InfoParametros = new tb_Parametro_Info();
        List<tb_tocken_x_usuario_tocken_Info> listUsuario_de_Tocken = new List<tb_tocken_x_usuario_tocken_Info>();
        tb_Empresa_Bus EmpresaBus = new tb_Empresa_Bus();
        tb_Actividades_Horario_Info InfoActividad = new tb_Actividades_Horario_Info();
        tb_Actividades_Horario_Bus BusActividad = new tb_Actividades_Horario_Bus();

        List<mail_Cuentas_Correo_Info> listmail_cuentas_correo = new List<mail_Cuentas_Correo_Info>();
        List<mail_Cuentas_Correo_x_Empresa_Info> listmail_cuentas_correo_x_empresa = new List<mail_Cuentas_Correo_x_Empresa_Info>();

        mail_Cuentas_Correo_Bus Busmail_Cuentas_Correo = new mail_Cuentas_Correo_Bus();
        mail_Cuentas_Correo_x_Empresa_Bus Busmail_Cuentas_Correo_x_Empresa = new mail_Cuentas_Correo_x_Empresa_Bus();




        

        string mensajeError = "";
        Thread HiloValidar;



        public UC_Comprobante_Pendientes_Autorizacion()
        {
            InitializeComponent();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_xml();
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void cargar_xml()
        {
            try
            {



                listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>(buscomp.consultar_listado_cbte_pendiente_de_autorizar(ref mensajeError));
                gridControlCbtes.DataSource = listComprobanteRecixSRI;

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
                string msgError="";


                switch (e.Column.Name)
                {
                    case "colEliminar":

                         tb_Comprobante_Info Info = new tb_Comprobante_Info();

                    Info =(tb_Comprobante_Info)gridViewCbtes.GetFocusedRow();

                    if (MessageBox.Show("Esta seguro que desear anular el comprobante #:" + Info.IdComprobante, "Efirm confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (buscomp.Eliminar_Cbte(Info.IdEmpresa, Info.IdComprobante,"","", ref msgError))
                        {
                            MessageBox.Show("Eliminacion de comprobante Ok", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                        break;

                   
                    default:

                        string mensaje = (string)gridViewCbtes.GetFocusedRowCellValue(e.Column);

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
               // MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }

        }

        Boolean esta_opteniendo_Autorizacion = false;

       

        void Autorizar()
        {
            try
            {

                esta_opteniendo_Autorizacion = true;
                int TotalArchivosAfirmar = 0;
                
                
                listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>(buscomp.consultar_listado_cbte_pendiente_de_autorizar(ref mensajeError));
                


                tb_Comprobante_Bus BusCtae = new tb_Comprobante_Bus();
                foreach (var item in listComprobanteRecixSRI)
                {
                    item.s_XML = BusCtae.Get_XML(item.IdEmpresa, item.IdComprobante,item.IdEstado_cbte, ref mensajeError);
                } 


                int Contador_fila = 0;

                Preparar_progres_bar(TotalArchivosAfirmar);


                foreach (var item in listComprobanteRecixSRI)
                {
                    
                    Contador_fila++;
                    lblEstado.Text = TotalArchivosAfirmar + "/" + Contador_fila;
                    //Avance_progres_bar(Contador_fila);

                    Firma_Bus BusFirm = new Firma_Bus(item, ListEmpresa, listTocken, InfoParametros, listUsuario_de_Tocken, listmail_cuentas_correo, listmail_cuentas_correo_x_empresa);
                
                    if (BusFirm.Optener_Autorizacion_WSJava(ref mensajeError)==false)
                    {

                        item.msgError = mensajeError;
                    }


                    Application.DoEvents();
                    

                }


                esta_opteniendo_Autorizacion = false;
            }
            catch (Exception ex)
            {
               //BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        BindingList<tb_Comprobante_Info> listCbtes = new BindingList<tb_Comprobante_Info>();


        Boolean validaciones()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        private void Procesar_cbtes_para_optencion_Auto()
        {
            try
            {
                
                HiloValidar = new Thread(new ThreadStart(Autorizar));
                HiloValidar.Start();


            }
            catch (Exception ex)
            {
            }
        }

        private void btnOptenerAutoSri_Click(object sender, EventArgs e)
        {
            try
            {
        
                    txt_focus.Focus();
                    Procesar_cbtes_para_optencion_Auto();

            }
            catch (Exception ex)
            {

                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void UC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto_Load(object sender, EventArgs e)
        {
            try
            {

                string msg = "";

                ListEmpresa = EmpresaBus.GetEmpresas(ref mensajeError);
                InfoActividad = BusActividad.consultar("CBTE_PEN_AUTO", ref msg);

                //=
                    


                   listmail_cuentas_correo= Busmail_Cuentas_Correo.consultar(ref msg);
                   listmail_cuentas_correo_x_empresa = Busmail_Cuentas_Correo_x_Empresa.Consulta_mail_Cuentas_Correo_x_Empresa(ref msg);






                tb_Tocken_Bus BusTocken = new tb_Tocken_Bus();
                tb_Parametro_Bus BusPara = new tb_Parametro_Bus();
                tb_tocken_x_usuario_tocken_Bus BusUsuerTocke = new tb_tocken_x_usuario_tocken_Bus();

                listTocken = BusTocken.ConsulTocken(ref msg);
                InfoParametros = BusPara.consultar(ref msg);
                listUsuario_de_Tocken = BusUsuerTocke.ConsultaTockenUsuario();


                xtraTabPageHorarioActividades.Show();
                xtraTabPageCbtes.Show();

                cargar_xml();



            }
            catch (Exception ex)
            {
                
                
            }


            



            
        }


        Boolean Servicios_WS_SRI_Activos(ref List<string> listaMensajeError, ref string mensajeErroOut)
        {
            try
            {


                listaMensajeError.Clear();
                string mensajeErrorOut = "";




                Boolean EstanActivos = true;

                var ListadoAmbiente = from C in ListEmpresa
                                      group C by C.cod_Ambiente into newGroup
                                      select newGroup;


                foreach (var item in ListadoAmbiente)
                {

                    if (item.Key == "PRUE")
                    {
                        try
                        {
                            HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(InfoParametros.url_ws_sri_Autorizacion_cbte_Prueba);
                            HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
                            HttpWResp.Close();
                            EstanActivos = true;
                        }
                        catch (Exception ex)
                        {
                            mensajeErrorOut = "No se Encuentra Activo el Web Service  del SRI en Ambiente de Prueba :" + InfoParametros.url_ws_sri_Autorizacion_cbte_Prueba;
                            listaMensajeError.Add(mensajeErrorOut);
                            EstanActivos = false;

                        }

                        try
                        {
                            HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(InfoParametros.url_ws_sri_Recep_cbte_Prueba);
                            HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
                            HttpWResp.Close();
                            EstanActivos = true;
                        }
                        catch (Exception ex)
                        {
                            mensajeErrorOut = "No se Encuentra Activo el Web Service del SRI en Ambiente de Prueba :" + InfoParametros.url_ws_sri_Recep_cbte_Prueba;
                            listaMensajeError.Add(mensajeErrorOut);
                            EstanActivos = false;

                        }


                    }
                    else
                    {
                        try
                        {
                            HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(InfoParametros.url_ws_sri_Autorizacion_cbte_Produc);
                            HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
                            HttpWResp.Close();
                            EstanActivos = true;
                        }
                        catch (Exception ex)
                        {
                            mensajeErrorOut = "No se Encuentra Activo el Web Service  del SRI en Ambiente de Prueba :" + InfoParametros.url_ws_sri_Autorizacion_cbte_Produc;
                            listaMensajeError.Add(mensajeErrorOut);
                            EstanActivos = false;

                        }

                        try
                        {
                            HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(InfoParametros.url_ws_sri_Recep_cbte_Produc);
                            HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
                            HttpWResp.Close();
                            EstanActivos = true;
                        }
                        catch (Exception ex)
                        {
                            mensajeErrorOut = "No se Encuentra Activo el Web Service del SRI en Ambiente de Prueba :" + InfoParametros.url_ws_sri_Recep_cbte_Produc;
                            listaMensajeError.Add(mensajeErrorOut);
                            EstanActivos = false;

                        }

                    }

                }

                listaMensajeError.Add(" fecha de consulta: " + DateTime.Now);


                return EstanActivos;





            }
            catch (Exception ex)
            {

                return false;
            }
        }

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                string msg = "";
                List<string> listErrores = new List<string>();
                Boolean EstanActivoWS_SRI;
                string msgErrores = "";

                EstanActivoWS_SRI = Servicios_WS_SRI_Activos(ref listErrores, ref msg);

                if (EstanActivoWS_SRI == false)//los servicios estan abajo
                {
                    frmMensaje frm = new frmMensaje();

                    foreach (var item in listErrores)
                    {
                        msgErrores = msgErrores + item + "\n";
                    }

                    frm.richTextBoxMensaje.Text = msgErrores;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void gridControlFiles_Click(object sender, EventArgs e)
        {

        }

        private void uC_Horario_Actividades1_event_btn_guardar_Click(object sender, EventArgs e)
        {

        }

        int countSegundosSensor_firmar = 0;
        int countSegundosRefrescarFiles = 0;
        int TiempoEspera_Proceso1 = 0;
        int TiempoEspera_Proceso2 = 0;

        private void uC_Horario_Actividades1_event_Disparador_horario(int _TiempoEspera_Proceso1, int _TiempoEspera_Proceso2, int _TiempoEspera_Proceso3, int _TiempoEspera_Proceso4, int _TiempoEspera_Proceso5, int _TiempoEspera_Proceso6, TimeSpan HoraDisparo, tb_Actividades_Horario_Info InfoActividad_en_proceso)
        {
            try
            {
                //string msg = "";

                TiempoEspera_Proceso1 = _TiempoEspera_Proceso1;
                TiempoEspera_Proceso2 = _TiempoEspera_Proceso2;


                countSegundosRefrescarFiles = _TiempoEspera_Proceso1;
                countSegundosSensor_firmar = _TiempoEspera_Proceso2;


                

                InfoActividad = InfoActividad_en_proceso;

                if (esta_opteniendo_Autorizacion == false)
                {
                    timerRefrescar.Enabled = true;
                    esta_opteniendo_Autorizacion = true;
                }



            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timerSensorHiloValidador_Tick(object sender, EventArgs e)
        {
            try
            {
                
                    if (HiloValidar.IsAlive == false) //esta ejecutandoce
                    {
                        backgroundWorker.CancelAsync();
                        timerSensorHiloValidador.Enabled = false;
                        prb_barra_proceso.Value = 100;
                        gridControlCbtes.RefreshDataSource();
                            lblMensajeError.Text="Finalizacion Optencion de Autorizacion.." + mensajeError ;
                        
                    }
                
            }
            catch (Exception ex)
            { }
        }

        private void timerRefrescar_Tick(object sender, EventArgs e)
        {
            try
            {


                btnRefrescar.Text = "Refrescar Listado (" + countSegundosRefrescarFiles + ")";

                if (countSegundosRefrescarFiles <= 0)
                {
                    countSegundosRefrescarFiles = TiempoEspera_Proceso1;
                    timerRefrescar.Enabled = false;// apago este proceso
                    cargar_xml();
                    timerFirmarXML.Enabled = true;
                    esta_opteniendo_Autorizacion = false;
                }
                countSegundosRefrescarFiles = countSegundosRefrescarFiles - 1;
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

                btnOptenerAutoSri.Text = "Obtener Autorizacion del SRI(" + countSegundosSensor_firmar + ")";

                if (countSegundosSensor_firmar <= 0)
                {
                    //TiempoEspera_Proceso1 viene del evento
                    countSegundosSensor_firmar = TiempoEspera_Proceso2;
                    timerFirmarXML.Enabled = false;// apago este proceso 
                    Procesar_cbtes_para_optencion_Auto();
                }
                countSegundosSensor_firmar = countSegundosSensor_firmar - 1;


            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewCbtes.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                for (int i = 0; i < 100; i++)
                {
                    if (backgroundWorker.CancellationPending)
                        break;


                    backgroundWorker.ReportProgress(i);
                    Thread.Sleep(1000);
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (prb_barra_proceso != null)
                {
                    prb_barra_proceso.Value = e.ProgressPercentage;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                prb_barra_proceso.Value = 0;
                lblMensajeError.Text = mensajeError;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }
        }


        private void Preparar_progres_bar(decimal NumRegistros)
        {
            try
            {
                if (NumRegistros <= 2147483647)
                {
                    prb_barra_proceso.Maximum = Convert.ToInt32(NumRegistros);//NumRegistros;
                    prb_barra_proceso.Minimum = 0;
                }
                else
                {
                    prb_barra_proceso.Maximum = 2147483647;//NumRegistros;
                    prb_barra_proceso.Minimum = 0;

                }

            }
            catch (Exception ex)
            {

            }

        }

        private void Avance_progres_bar(decimal ValorAvance)
        {
            try
            {
                if (ValorAvance <= prb_barra_proceso.Maximum && ValorAvance <= 2147483647)
                {
                    prb_barra_proceso.Value = Convert.ToInt32(ValorAvance);
                }
                else
                {
                    prb_barra_proceso.Value = 0;
                }

                Application.DoEvents();
            }
            catch (Exception ex)
            {

            }

        }
    
    }
}
