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


namespace Efirm
{
    public partial class UC_Comprobante_x_Enviar_firmar_al_SRI_efirm : UserControl
    {

        tb_Comprobante_Bus buscomp = new tb_Comprobante_Bus();
        BindingList<tb_Comprobante_Info> listComprobanteValidos = new BindingList<tb_Comprobante_Info>();
        List<tb_Comprobante_Info> listComprobanteValidosFirmados = new List<tb_Comprobante_Info>();
        List<tb_Empresa_Info> ListEmpresa = new List<tb_Empresa_Info>();
        List<tb_Tocken_Info> listTocken = new List<tb_Tocken_Info>();
        tb_Parametro_Info InfoParametros = new tb_Parametro_Info();
        List<tb_tocken_x_usuario_tocken_Info> listUsuario_de_Tocken = new List<tb_tocken_x_usuario_tocken_Info>();
        tb_Empresa_Bus EmpresaBus = new tb_Empresa_Bus();
        tb_Actividades_Horario_Info InfoActividad = new tb_Actividades_Horario_Info();
        tb_Actividades_Horario_Bus BusActividad = new tb_Actividades_Horario_Bus();
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        List<mail_Cuentas_Correo_Info> listmail_cuentas_correo = new List<mail_Cuentas_Correo_Info>();
        List<mail_Cuentas_Correo_x_Empresa_Info> listmail_cuentas_correo_x_empresa = new List<mail_Cuentas_Correo_x_Empresa_Info>();

        mail_Cuentas_Correo_Bus Busmail_Cuentas_Correo = new mail_Cuentas_Correo_Bus();
        mail_Cuentas_Correo_x_Empresa_Bus Busmail_Cuentas_Correo_x_Empresa = new mail_Cuentas_Correo_x_Empresa_Bus();

        Rpt_Ride_bus Rpt_Ride_Bus;
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();

        int countSegundosSensor_firmar = 0;
        int countSegundosRefrescarFiles = 0;
        int TiempoEspera_Proceso1 = 0;
        int TiempoEspera_Proceso2 = 0;
        string CadenaBusqueda = "";
        string mensajeError = "";




        public UC_Comprobante_x_Enviar_firmar_al_SRI_efirm()
        {
            InitializeComponent();
            uC_Horario_Actividades.event_btn_guardar_Click += uC_Horario_Actividades_event_btn_guardar_Click;
        }

        void uC_Horario_Actividades_event_btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                InfoActividad = BusActividad.consultar("CBTE_A_FIRMAR", ref mensajeError);
            }
            catch (Exception ex)
            {
                
                
            }
            
            
            
        }

        

        private void cargar_xml()
        {
            try
            {

                DateTime fechaIni = DateTime.Now.AddYears(-1);
                DateTime fechaFin = DateTime.Now.AddYears(1);
                int Pagina = 1;

                List<string> listadoTipoCbtes= new List<string>();
                listadoTipoCbtes.Add("VALI");
                listadoTipoCbtes.Add("VALI_&_FIRM_&_CON_CLV");


               gridControlFiles.DataSource = null;
               listComprobanteValidos = new BindingList<tb_Comprobante_Info>(buscomp.consultar_listado_cbte_Pendientes_x_Autoriza(fechaIni, fechaFin, listadoTipoCbtes, "", "PEND", CadenaBusqueda, ref mensajeError));
               gridControlFiles.DataSource = listComprobanteValidos;


               


                
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }
        
        }

       
        private void btn_refresh_listado_Click(object sender, EventArgs e)
        {


            try
            {
                cargar_xml();

            }
            catch (Exception ex)
            {

                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
            
        }


        Boolean hay_errores_antes_firmar(ref string mensajeErroOut)
        {
            try
            {

                Boolean HayErrores = false;
                
                try
                {
                    HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(InfoParametros.url_ws_firma_efirm);
                    HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
                    
                    HttpWResp.Close();

                }
                catch (Exception ex)
                {

                    HayErrores = true;
                    mensajeErroOut = InfoParametros.url_ws_firma_efirm + " SERVICIO JABA EFIRM NO ESTA ACTIVO ";
                    MessageBox.Show(mensajeErroOut  ,"Efirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                return HayErrores;

            }
            catch (Exception ex)
            {

                return false;
            }
        }



        Boolean Servicios_WS_SRI_Activos(ref List<string> listaMensajeError  , ref string mensajeErroOut)
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

                listaMensajeError.Add(" fecha de consulta: " + DateTime.Now );


                    return EstanActivos;



                

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        
        private void btn_firmar_Click(object sender, EventArgs e)
        {
            try
            {


                string msg = "";


                if (!hay_errores_antes_firmar(ref msg))
                {
                   

                    firmar();
                }
        

            }
            catch (Exception ex)
            {

                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }

        }

        void firmar()
        {
            try
            {

                int TotalArchivosAfirmar = 0;
                int countadorBloquexPagina = 0;




                
                List<tb_Comprobante_Info> listComprobantesValidosChequeados = new List<tb_Comprobante_Info>();

                uC_ContenedorHilos.Focus();


                var TotalFile = from C in listComprobanteValidos
                                where C.Checked == true
                                select C;

                TotalArchivosAfirmar = Convert.ToInt32(TotalFile.Count());



                if (InfoActividad.IdTipoEjecucion == "AUTO")
                {
                    countadorBloquexPagina = InfoActividad.Num_cbtes_x_pagina;
                }

                if (InfoActividad.IdTipoEjecucion == "MANU")
                {
                    countadorBloquexPagina = TotalArchivosAfirmar;
                }


                if (TotalArchivosAfirmar > countadorBloquexPagina)
                {
                    MessageBox.Show("No se pueden firmar mas documentos q lo q permite los parametros se firmara solo en bloques de :" + InfoActividad.Num_cbtes_x_pagina 
                        , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //no selecciono nada proceser con lo q dice el bloque 
                if (InfoActividad.IdTipoEjecucion == "AUTO")
                {
                    if (TotalArchivosAfirmar == 0)
                    {

                        //chequando los items s
                        foreach (var item in listComprobanteValidos)
                        {
                            if (item.Error == "" || item.Error == null)
                            {

                                item.Checked = true;
                                countadorBloquexPagina = countadorBloquexPagina - 1;
                                if (countadorBloquexPagina == 0)
                                {
                                    break;
                                }
                            }
                        }

                    }

                    gridControlFiles.DataSource = null;
                    gridControlFiles.DataSource = listComprobanteValidos;
                    gridControlFiles.RefreshDataSource();

                }



                listComprobantesValidosChequeados = (from C in listComprobanteValidos
                                                     where C.Checked == true
                                                     select C).ToList();


                tb_Comprobante_Bus BusCtae= new tb_Comprobante_Bus();
                foreach (var item in listComprobantesValidosChequeados)
                {
                    item.s_XML = BusCtae.Get_XML(item.IdEmpresa, item.IdComprobante, item.IdEstado_cbte, ref mensajeError);
                } 


                uC_ContenedorHilos.listComprobanteAFirmar = listComprobantesValidosChequeados;
                uC_ContenedorHilos.listaEmpresa = ListEmpresa;
                uC_ContenedorHilos.listTocken = listTocken;
                uC_ContenedorHilos.InfoParametros = InfoParametros;
                uC_ContenedorHilos.listUsuario_de_Tocken = listUsuario_de_Tocken;
                uC_ContenedorHilos.listmail_cuentas_correo = listmail_cuentas_correo;
                uC_ContenedorHilos.listmail_cuentas_correo_x_empresa = listmail_cuentas_correo_x_empresa;

                




                uC_ContenedorHilos.MaxSleepTime = 1000;
                uC_ContenedorHilos.Start(TotalArchivosAfirmar, TotalArchivosAfirmar);
                uC_ContenedorHilos.Event_Finalizo_Proceso += uC_ContenedorHilos_Event_Finalizo_Proceso;



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
                string msg="";

                ListEmpresa = EmpresaBus.GetEmpresas(ref mensajeError);
                InfoActividad = BusActividad.consultar("CBTE_A_FIRMAR", ref msg);


            listmail_cuentas_correo=Busmail_Cuentas_Correo.consultar(ref msg);
            listmail_cuentas_correo_x_empresa = Busmail_Cuentas_Correo_x_Empresa.Consulta_mail_Cuentas_Correo_x_Empresa(ref msg);

               
                tb_Tocken_Bus BusTocken= new tb_Tocken_Bus();
                tb_Parametro_Bus BusPara= new tb_Parametro_Bus();
                tb_tocken_x_usuario_tocken_Bus BusUsuerTocke = new tb_tocken_x_usuario_tocken_Bus();



                listTocken = BusTocken.ConsulTocken(ref msg);
                InfoParametros = BusPara.consultar(ref msg);
                listUsuario_de_Tocken = BusUsuerTocke.ConsultaTockenUsuario();



                xtraTabPageHorario.Show();
                xtraTabPageFileValidos.Show();


            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gridViewFiles_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                string mensaje = "";
                tb_Comprobante_Info InfoCbteT = new tb_Comprobante_Info();

                switch (e.Column.Name)
                {
                   
                    case "colEliminar":

                            tb_Comprobante_Info Info = new tb_Comprobante_Info();
                            string msg = "";

                            Info = (tb_Comprobante_Info)gridViewFiles.GetFocusedRow();

                            if (MessageBox.Show("Esta seguro que desear anular el comprobante #:" + Info.IdComprobante, "Efirm confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                    if (buscomp.Eliminar_Cbte(Info.IdEmpresa, Info.IdComprobante,"","", ref msg))
                                    {
                                         MessageBox.Show("Eliminacion de comprobante Ok", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                            }

                        break;

                    case "ColRide":

                        XtraReport Reporte = new XtraReport();
                        string msj = "";

                        Rpt_Ride_Bus = new Rpt_Ride_bus(busEmpresa.GetEmpresas(ref mensajeError));
                        InfoCbteT = (tb_Comprobante_Info)gridViewFiles.GetFocusedRow();

                        Reporte = Rpt_Ride_Bus.Optener_reporte(InfoCbteT, ref msj); //FAct Imporpoint
                        Reporte.ShowPreview();

                        break;
                    default:

                        mensaje = (string)gridViewFiles.GetFocusedRowCellValue(e.Column);


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

                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
            
        }

        private void gridViewFiles_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewFiles.GetRow(e.RowHandle) as tb_Comprobante_Info;
                if (data == null)
                    return;

                if (data.Error!=null)
                {
                    if (data.Error.ToString() != "")
                        e.Appearance.ForeColor = Color.OrangeRed;
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

                btn_firmar.Text = "Firmar Xmls Efirm(" + countSegundosSensor_firmar + ")";

                if (countSegundosSensor_firmar <= 0)
                {
                    //TiempoEspera_Proceso1 viene del evento
                    countSegundosSensor_firmar = TiempoEspera_Proceso2;
                    timerFirmarXML.Enabled = false;// apago este proceso 
                    firmar();
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


                btn_refresh_listado.Text = "Refrescar Listado (" + countSegundosRefrescarFiles + ")";

                if (countSegundosRefrescarFiles <= 0)
                {
                    countSegundosRefrescarFiles = TiempoEspera_Proceso1;
                    timerRefrescar.Enabled = false;// apago este proceso
                    cargar_xml();
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

        private void xtraTabControlMain_Click(object sender, EventArgs e)
        {

        }

        private void btn_test_ws_sri_Click(object sender, EventArgs e)
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

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewFiles.RowCount; i++)
                {
                    gridViewFiles.GetRow(i);
                    gridViewFiles.SetRowCellValue(i, colChecked, chkTodos.Checked);
                }

                gridControlFiles.RefreshDataSource();

            }
            catch (Exception ex)
            {


            }
        }

       
    
    }
}
