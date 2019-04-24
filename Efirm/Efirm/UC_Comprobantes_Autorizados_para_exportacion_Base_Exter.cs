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
using System.Xml;
using System.Xml.Serialization;
using System.Threading;





namespace Efirm
{
    public partial class UC_Comprobantes_Autorizados_para_exportacion_Base_Exter : UserControl
    {

        #region Declaración de variables
        BindingList<tb_Comprobante_Info> listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>();
        List<tb_Comprobante_Info> listComprobante_exportados = new List<tb_Comprobante_Info>();


        tb_Comprobante_Bus buscomp = new tb_Comprobante_Bus();
        //tb_Comprobante_Bus buscomp
        string mensajeError = "";
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        Rpt_Ride_bus Rpt_Ride_Bus;
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        List<tb_Empresa_Info> listEmpresas = new List<tb_Empresa_Info>();

        tb_Comprobante_Procesos_externos_Bus BusCbte_exte ;//= new tb_Comprobante_Procesos_externos_Bus();

        

        #endregion

        public UC_Comprobantes_Autorizados_para_exportacion_Base_Exter()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UC_Comprobantes_Autorizados_para_exportacion_Base_Exter_Load(object sender, EventArgs e)
        {
            try
            {

                listEmpresas = busEmpresa.GetEmpresas(ref mensajeError);
                Rpt_Ride_Bus = new Rpt_Ride_bus(listEmpresas);

                BusCbte_exte = new tb_Comprobante_Procesos_externos_Bus(listEmpresas);

                dtp_fechaIni.Value = DateTime.Now.AddMonths(-1);
                dtp_fechaFin.Value = DateTime.Now.AddMonths(1);


                
                



                cargar_cbtes_por_exportar();
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cargar_cbtes_por_exportar();
        }

        


        private void cargar_cbtes_por_exportar()
        {
            try
            {

                DateTime FechaIni, FechaFin;
                FechaIni = DateTime.Now.AddYears(-5);
                FechaFin = DateTime.Now.AddYears(5);

                listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>(buscomp.consultar_listado_cbte_para_exportar(FechaIni,FechaFin,eTipoExportacion.X_EXPORTAR, ref mensajeError));

                gridControlFiles.DataSource = listComprobanteRecixSRI;

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }

        }


        private void cargar_cbtes_exportados()
        {
            try
            {

                DateTime FechaIni, FechaFin;
                FechaIni = dtp_fechaIni.Value;
                FechaFin = dtp_fechaFin.Value;

                BindingList<tb_Comprobante_Info>  listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>();

                listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>(buscomp.consultar_listado_cbte_para_exportar(FechaIni, FechaFin, eTipoExportacion.EXPORTADOS, ref mensajeError));

                gridControlCbtesExportados.DataSource = listComprobanteRecixSRI;

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }

        }

        private void Exportar_comprobantes()
        {
            try
            {
                string msg="";
                List<tb_Comprobante_Info> lista = new List<tb_Comprobante_Info>();
                listComprobante_exportados.Clear();

                foreach (var item in listEmpresas)
                {
                    lista = new List<tb_Comprobante_Info>();
                    lista   = BusCbte_exte.Consultar(item.IdEmpresa, ref msg);

                    foreach (var item2 in lista)
                    {
                        listComprobante_exportados.Add(item2);
                        
                    }
                }

                

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
                tb_Comprobante_Info InfoCbteT = new tb_Comprobante_Info();
                string msg="";


                switch (e.Column.Name)
                {
                    case "colRide":

                        XtraReport Reporte = new XtraReport();
                        


                        InfoCbteT = (tb_Comprobante_Info)gridViewFiles.GetFocusedRow();

                        Reporte = Rpt_Ride_Bus.Optener_reporte(InfoCbteT, ref msg); //FAct Imporpoint
                        Reporte.ShowPreview();

                        break;

                    case "colXml":


                        InfoCbteT = (tb_Comprobante_Info)gridViewFiles.GetFocusedRow();

                        XmlDocument xmlOrigen = new XmlDocument();
                        xmlOrigen.Load(new StringReader(InfoCbteT.s_XML));



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

                    case "colIconoGuardar":


                        InfoCbteT = (tb_Comprobante_Info)gridViewFiles.GetFocusedRow();
                        
                        if (BusCbte_exte.GrabarDB(InfoCbteT, ref msg))
                        {
                            MessageBox.Show("Proceso de exportacion OK...","efirm",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            listComprobanteRecixSRI.Remove(InfoCbteT);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo procesar el Proceso de exportacion..." + msg, "efirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void dtp_fechaIni_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridViewFiles.ViewCaption = "Comprobante desde:" + dtp_fechaIni.Value + " hasta:" + dtp_fechaFin.Value;
                listComprobanteRecixSRI.Clear();
                gridControlFiles.RefreshDataSource();
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void dtp_fechaFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridViewFiles.ViewCaption = "Comprobante desde:" + dtp_fechaIni.Value + " hasta:" + dtp_fechaFin.Value;
                listComprobanteRecixSRI.Clear();
                gridControlFiles.RefreshDataSource();
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }


        private void cmb_tipo_Autorizacion_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                listComprobanteRecixSRI.Clear();
                gridControlFiles.RefreshDataSource();
            }
            catch (Exception ex)
            {

                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewFiles.ViewCaption = "Solo se muestran los comprobantes ***AUTORIZADOS***" + "\n" + "Comprobante desde:" + dtp_fechaIni.Value + " hasta:" + dtp_fechaFin.Value;
                gridControlFiles.ShowPrintPreview();

            }
            catch (Exception ex)
            {

                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewFiles.RowCount; i++)
                {
                    gridViewFiles.GetRow(i);
                    gridViewFiles.SetRowCellValue(i, colCheked, chkTodos.Checked);
                }


             
                gridControlFiles.RefreshDataSource();

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void btn_buscar_cbtes_Click(object sender, EventArgs e)
        {
            cargar_cbtes_por_exportar();
        }

        private void btn_exportar_cbtes_base_ext_Click(object sender, EventArgs e)
        {
            
        }

        private void Exportar_data()
        {
            try
            {

                se_esta_procesando_exportacion = true;
                
                string msg = "";
                int C=1;
                decimal CtotalCbtes_a_exportar = 0;
                tb_comprobante_exportado_base_ext_Bus BusCbte_Expo = new tb_comprobante_exportado_base_ext_Bus();


                

                var tRegistro = from Q in listComprobanteRecixSRI
                                where Q.Exportado == false
                                select Q;

                CtotalCbtes_a_exportar = tRegistro.Count();
                //Preparar_progres_bar(CtotalCbtes_a_exportar);

                foreach (var item in tRegistro)
                {
                   
                    //lblNumCbtesExportados.Text = Convert.ToString(C++) + "/" +CtotalCbtes_a_exportar; 

                    //Avance_progres_bar(C);
                    if (item.Checked == true)
                    {
                        if (item.Exportado == false)
                        {

                            if (BusCbte_exte.GrabarDB(item, ref msg))
                            {

                                item.Exportado = true;
                                item.Mostrar_IconoExportar = true;
                                // listComprobanteRecixSRI.Remove(item);
                                item.msgError = "";
                                ///listComprobanteRecixSRI.Remove(item);
                                //gridControlFiles.RefreshDataSource();
                            }
                            else
                            {
                                item.Exportado = false;
                                item.Mostrar_IconoExportar = false;
                                item.msgError = msg;
                            }
                        }

                        gridControlFiles.RefreshDataSource();

                        //Application.DoEvents();


                    }
                }

                
                //btn_exportar_cbts_bex.Enabled = true;
                se_esta_procesando_exportacion = false;

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
        }

        private void Preparar_progres_bar(decimal NumRegistros)
        {
            try
            {
                if (NumRegistros <= 2147483647)
                {
                    pgb_estado_expo.Maximum =Convert.ToInt32(NumRegistros);//NumRegistros;
                    pgb_estado_expo.Minimum = 0;
                }
                else
                {
                    pgb_estado_expo.Maximum = 2147483647;//NumRegistros;
                    pgb_estado_expo.Minimum = 0;
                
                }

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
            
        }

        private void Avance_progres_bar(decimal ValorAvance)
        {
            try
            {
                if (ValorAvance <= pgb_estado_expo.Maximum &&  ValorAvance <= 2147483647)
                {
                    pgb_estado_expo.Value = Convert.ToInt32(ValorAvance);
                }
                else
                {
                    pgb_estado_expo.Value = 0;
                }

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

        }

        private void gridControlFiles_Click(object sender, EventArgs e)
        {

        }

        private void btn_cbtes_en_base_Click(object sender, EventArgs e)
        {
            try
            {

                Exportar_comprobantes();
                gridControlCbtes_en_base.DataSource = listComprobante_exportados;
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
            
        }

        Thread HiloExportar;


        private void Procesar_Hilo_exportar()
        {
            btn_exportar_cbts_bex.Enabled = false;
            backgroundWorker.RunWorkerAsync();
            HiloExportar = new Thread(new ThreadStart(Exportar_data));
            HiloExportar.Start();
            Thread.Sleep(1);
            timerSensorHilo.Enabled = true;

        }

        private void btn_exportar_cbts_bex_Click(object sender, EventArgs e)
        {
            label1.Focus();
            Procesar_Hilo_exportar();
            
        }

        private void tabPageComprobantesExportados_Click(object sender, EventArgs e)
        {

        }

        private void btn_cbtes_exportados_Click(object sender, EventArgs e)
        {
            cargar_cbtes_exportados();
        }

        Boolean se_esta_procesando_exportacion = false;


        private void uC_Horario_Actividades1_event_Disparador_horario(int _TiempoEspera_Proceso1, int _TiempoEspera_Proceso2, int _TiempoEspera_Proceso3, int _TiempoEspera_Proceso4, int _TiempoEspera_Proceso5, int _TiempoEspera_Proceso6, TimeSpan HoraDisparo, tb_Actividades_Horario_Info InfoActividad_en_proceso)
        {
            try
            {
                if (se_esta_procesando_exportacion == false)
                {
                    se_esta_procesando_exportacion = true;
                    cargar_cbtes_por_exportar();
                    Exportar_data();
                }
            }
            catch (Exception ex)
            {
                
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

            

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                DateTime start = DateTime.Now;
                e.Result = "";

                for (int i = 0; i <= 200; i++)
                {

                    int percentage = i;

                    System.Threading.Thread.Sleep(1000); //simulamos trabajo

                    backgroundWorker.ReportProgress(percentage, DateTime.Now);

                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                TimeSpan duration = DateTime.Now - start;

                e.Result = "Duration: " + duration.TotalMilliseconds.ToString() + " ms.";


            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {

                pgb_estado_expo.Value = e.ProgressPercentage; //actualizamos la barra de progreso
                DateTime time = Convert.ToDateTime(e.UserState); //obtenemos información adicional si procede
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {

                }
                else if (e.Error != null)
                {
                }
                else
                {
                    
                }

                pgb_estado_expo.Value = 100;
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }

        }

        private void timerSensorHilo_Tick(object sender, EventArgs e)
        {
            try
            {
                if (HiloExportar.IsAlive == false) //termino de  ejecutarse
                {
                    backgroundWorker.CancelAsync();

                    timerSensorHilo.Enabled = false;
                    pgb_estado_expo.Value = 100;
                    gridControlFiles.RefreshDataSource();
                    btn_exportar_cbts_bex.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

       
       

    }
}
