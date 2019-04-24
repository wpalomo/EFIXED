using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.general;
using FirmElect.Bus;
using FirmElect.Info;


namespace Efirm
{
    public partial class frmseg_usuario_cons : DevExpress.XtraEditors.XtraForm
    {
        #region variables
        cl_parametros_generales_info param = cl_parametros_generales_info.Instance;
        List<seg_usuario_info> lst_usuario = new List<seg_usuario_info>();
        seg_usuario_bus bus_usuario = new seg_usuario_bus();
        seg_usuario_info info_usuario = new seg_usuario_info();
        #endregion

        public frmseg_usuario_cons()
        {
            InitializeComponent();
        }

        private void buscar()
        {
            try
            {
                lst_usuario = bus_usuario.get_list();
                gridControl_usuarios.DataSource = lst_usuario;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamar_formulario(cl_enumeradores_info.eTipoAccion Accion)
        {
            try
            {
                frmseg_usuario_mant frm = new frmseg_usuario_mant();
                frm.set_accion(Accion);
                if (Accion != cl_enumeradores_info.eTipoAccion.NUEVO)
                    frm.set_info(info_usuario);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_delegate_frmseg_usuario_mant_FormClosed += frm_event_delegate_frmseg_usuario_mant_FormClosed;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_delegate_frmseg_usuario_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmseg_usuario_cons_Load(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_delegate_btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_usuario = (seg_usuario_info)gridView_usuarios.GetFocusedRow();

                if (info_usuario == null)
                {
                    MessageBox.Show("Seleccione un registro", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!info_usuario.estado)
                {
                    MessageBox.Show("El registro seleccionado se encuentra anulado", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(cl_enumeradores_info.eTipoAccion.ANULAR);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_delegate_btn_consultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_usuario = (seg_usuario_info)gridView_usuarios.GetFocusedRow();

                if (info_usuario == null)
                {
                    MessageBox.Show("Seleccione un registro", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(cl_enumeradores_info.eTipoAccion.CONSULTAR);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_delegate_btn_imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControl_usuarios.ShowPrintPreview();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_delegate_btn_modificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_usuario = (seg_usuario_info)gridView_usuarios.GetFocusedRow();

                if (info_usuario == null)
                {
                    MessageBox.Show("Seleccione un registro",param.nom_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                if (!info_usuario.estado)
                {
                    MessageBox.Show("El registro seleccionado se encuentra anulado", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(cl_enumeradores_info.eTipoAccion.MODIFICAR);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_delegate_btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_formulario(cl_enumeradores_info.eTipoAccion.NUEVO);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_delegate_btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void gridView_usuarios_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                seg_usuario_info row = (seg_usuario_info)gridView_usuarios.GetRow(e.RowHandle);
                if (row == null) return;
                if (!row.estado) e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}