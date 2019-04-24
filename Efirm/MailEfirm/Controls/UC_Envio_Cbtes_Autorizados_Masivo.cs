using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

using FirmElect.Info;
using FirmElect.Bus;
using FirmElect.Reports;






namespace MailEfirm.Controls
{
    public partial class UC_Envio_Cbtes_Autorizados_Masivo : UserControl
    {


        #region Declaración de variables
        BindingList<tb_Comprobante_Info> listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>();
        tb_Comprobante_Bus buscomp = new tb_Comprobante_Bus();
        string mensajeError = "";
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        Rpt_Ride_bus Rpt_Ride_Bus;
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        #endregion


        public UC_Envio_Cbtes_Autorizados_Masivo()
        {
            InitializeComponent();
            cmb_estadoEnvio.SelectedIndex = 0;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cargar_xml();
        }


        private void cargar_xml()
        {
            try
            {

                DateTime FechaIni, FechaFin;
                FechaIni = dtp_fechaIni.Value;
                FechaFin = dtp_fechaFin.Value;

                int EstadoEnvio = 0;


                EstadoEnvio = (cmb_estadoEnvio.Text == "Por Enviar Mail") ? 0 : 1;



               

                listComprobanteRecixSRI = new BindingList<tb_Comprobante_Info>(buscomp.consultar_listado_cbte_Autorizados_Enviado_o_NOenviados_x_mail
                    (FechaIni, FechaFin, EstadoEnvio, ref mensajeError));
                gridControlFiles.DataSource = listComprobanteRecixSRI;


                if (listComprobanteRecixSRI.Count() == 0)
                {
                    MessageBox.Show("No hay registros q mostrar");
                }

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }

        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            try
            {
                txt_espacio.Focus();
                Enviar_mail_masivo();
                cargar_xml();
            }
            catch (Exception ex)
            {
                
                
            }
        }


        void Enviar_mail_masivo()
        {
            try
            {

                mail_Mensaje_Bus BusMail = new mail_Mensaje_Bus();
                mail_Mensaje_Info InfoMail= new mail_Mensaje_Info();
                string MensajeError="";

                List<tb_Comprobante_Info> listComprobantesValidosChequeados = new List<tb_Comprobante_Info>();


                listComprobantesValidosChequeados =(from C in listComprobanteRecixSRI
                                where C.Checked == true
                                select C).ToList();



                    foreach (var item in listComprobantesValidosChequeados)
                    {

                        BusMail.Envio_Cbte_x_correo(item, new List<string>(), item.Nom_emisor, item.EstadoDoc, "2", eTipoEnvioMail.RENVIO, ref MensajeError);
      
                    }

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }


        }

        private void checkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkSeleccionarTodos.Checked == true)
                {
                    SeleccionarTodos(true);
                }
                else
                {
                    SeleccionarTodos(false);
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }


        public void SeleccionarTodos( bool E)
        {
            try
            {
                foreach (var item in listComprobanteRecixSRI)
                {
                    item.Checked = E;

                }
                gridControlFiles.RefreshDataSource();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gridControlFiles.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}
