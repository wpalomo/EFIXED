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
using MailEfirm.Forms;

namespace MailEfirm.Controls
{
    public partial class UC_Mail_Buzon_Elementos_Enviados : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        
        #region Declaración de Variables
        string mensajeError = ""; string RutaArchivos = "";
        BindingList<mail_Mensaje_Info> listaMensajes = new BindingList<mail_Mensaje_Info>();
        BindingList<tb_Comprobante_Info> Listadors_de_Comprobante_Emisor = new BindingList<tb_Comprobante_Info>();


        mail_Mensaje_Bus MenBus = new mail_Mensaje_Bus();
        mail_Mensaje_Archi_Adjunto_Bus BusMailAdjunto = new mail_Mensaje_Archi_Adjunto_Bus();
        tb_Comprobante_Bus Bus_Comprobante_emisor = new tb_Comprobante_Bus();
        mail_Mensaje_Archi_Adjunto_Bus BusArchivo_Adjunto = new mail_Mensaje_Archi_Adjunto_Bus();
        tb_Empresa_Bus busempresa = new tb_Empresa_Bus();


        mail_Mensaje_Archi_Adjunto_Info AdjuntoInfo = new mail_Mensaje_Archi_Adjunto_Info();
        tb_Comprobante_Info comprobante = new tb_Comprobante_Info();
        List<tb_Empresa_Info> listEmpr = new List<tb_Empresa_Info>();

        List<mail_Mensaje_Archi_Adjunto_Info> ListaArchivo_Adjunto_Sin_Actualizar = new List<mail_Mensaje_Archi_Adjunto_Info>();
        List<mail_Mensaje_Archi_Adjunto_Info> ListaArchivo_Adjunto_Actualizada = new List<mail_Mensaje_Archi_Adjunto_Info>();
        List<tb_Comprobante_Info> listadeComprobantesEmisor = new List<tb_Comprobante_Info>();


        mail_Mensaje_Info Info;
        mail_Mensaje_Bus Bus_Mensaje = new mail_Mensaje_Bus();


        public string dir_correo = "";
        int NumeroPaginas = 0;
        #endregion

        public UC_Mail_Buzon_Elementos_Enviados()
        {
            InitializeComponent();
        }

        public void mostrar_mensajes(string direccionCorreo ,int IndicePagina)
        {
            try
            {
                string msg = "";
                toolStripLabelCorreo.Text = direccionCorreo;
                dir_correo = direccionCorreo;
                listaMensajes = new BindingList<mail_Mensaje_Info>(MenBus.consultar(eTipoMail.Enviado, direccionCorreo, IndicePagina, uC_Botones_Paginas1.Total_Registros_x_pagina, (uC_Botones_Paginas1.Cadena_Busqueda == null) ? "" : uC_Botones_Paginas1.Cadena_Busqueda, ref msg));

                foreach (var item in listaMensajes)
                {
                    item.Checked = true;
                }
                NumeroPaginas = Bus_Mensaje.ObtenerNumPag(uC_Botones_Paginas1.Total_Registros_x_pagina, eTipoMail.Enviado, dir_correo, (uC_Botones_Paginas1.Cadena_Busqueda == null) ? "" : uC_Botones_Paginas1.Cadena_Busqueda, ref msg);
                uC_Botones_Paginas1.NumeroPaginas = NumeroPaginas;
                gridControlVisor_Mail.DataSource = listaMensajes;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                mostrar_mensajes(toolStripLabelCorreo.Text, uC_Botones_Paginas1.IndicePagina);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        private void gridViewVisorMail_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Info = new mail_Mensaje_Info();
                Info = this.gridViewVisorMail.GetFocusedRow() as mail_Mensaje_Info;

                Llamar_form_redactar_mail(Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void gridViewVisorMail_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {            
            try
            {
                mail_Mensaje_Info InfoMensaje = new mail_Mensaje_Info();

                switch (e.Column.Name)
                {
                    case "colcheck":

                        if ((bool)gridViewVisorMail.GetFocusedRowCellValue(colcheck))
                        {
                            gridViewVisorMail.SetFocusedRowCellValue(colcheck, false);

                        }
                        else
                        {
                            gridViewVisorMail.SetFocusedRowCellValue(colcheck, true);
                        }

                        break;

                    case "ColEliminar":

                        InfoMensaje = new mail_Mensaje_Info();
                        InfoMensaje = (mail_Mensaje_Info)gridViewVisorMail.GetFocusedRow();

                        if (MessageBox.Show("Esta seguro de borrar este correo ..", "Mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Bus_Mensaje.Eliminar_Mensaje(InfoMensaje, ref mensajeError);
                            btn_Refresh_Click(null, null);
                        }

                        break;

                    case "ColIcono":

                        InfoMensaje = new mail_Mensaje_Info();
                        InfoMensaje = (mail_Mensaje_Info)gridViewVisorMail.GetFocusedRow();

                        Llamar_form_redactar_mail(InfoMensaje);


                        break;


                    default:

                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void Llamar_form_redactar_mail(mail_Mensaje_Info InfoMail)
        {
            try
            {
                Info.Asunto = "RE:" + Info.Asunto;
                Info.Asunto_texto_mostrado = "RE:" + Info.Asunto_texto_mostrado;

                Frm_Redactar_Email ofrm = new Frm_Redactar_Email();               
                ofrm.set_label_buton_enviar("Reenviar");
                ofrm.set(Info);
                ofrm.ShowDialog();

                btn_Refresh_Click(null, null);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

      
        private void uC_Botones_Paginas1_event_click_buttons_1(object sender, EventArgs e, int _IndicePagina)
        {
            mostrar_mensajes(dir_correo, _IndicePagina);
        }

     
    }
}
