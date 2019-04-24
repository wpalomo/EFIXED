using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using FirmElect.Bus;
using FirmElect.Info;


namespace Efirm
{
    public partial class frmseg_usuario_mant : DevExpress.XtraEditors.XtraForm
    {
        #region variables
        cl_parametros_generales_info param = cl_parametros_generales_info.Instance;
        seg_usuario_info info_usuario = new seg_usuario_info();
        seg_usuario_bus bus_usuario = new seg_usuario_bus();
        BindingList<seg_usuario_x_tb_empresa_info> blst_usuario_x_empresa = new BindingList<seg_usuario_x_tb_empresa_info>();
        eTipoAccion Accion;
        seg_usuario_x_tbl_empresa_bus bus_usuario_x_empresa = new seg_usuario_x_tbl_empresa_bus();
        List<tb_Empresa_Info> lst_empresa = new List<tb_Empresa_Info>();
        tb_Empresa_Bus bus_empresa = new tb_Empresa_Bus();
        #endregion

        #region delegados
        public delegate void delegate_frmseg_usuario_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmseg_usuario_mant_FormClosed event_delegate_frmseg_usuario_mant_FormClosed;
        #endregion

        public frmseg_usuario_mant()
        {
            InitializeComponent();
            event_delegate_frmseg_usuario_mant_FormClosed += frmseg_usuario_mant_event_delegate_frmseg_usuario_mant_FormClosed;
        }

        void frmseg_usuario_mant_event_delegate_frmseg_usuario_mant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmseg_usuario_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmseg_usuario_mant_FormClosed(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmseg_usuario_mant_Load(object sender, EventArgs e)
        {
            try
            {
                set_accion_in_controls();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_info(seg_usuario_info _info)
        {
            try
            {
                info_usuario = _info;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion(eTipoAccion _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                txt_usuario.Text = info_usuario.IdUsuario;
                txt_contrasenia.Text = info_usuario.us_contrasenia;
                txt_nombre.Text = info_usuario.us_nombre;
                lbl_anulado.Visible = !info_usuario.estado;

                info_usuario.lst_usuario_x_empresa = bus_usuario_x_empresa.get_list(info_usuario.IdUsuario);

                foreach (var item in lst_empresa)
                {
                    seg_usuario_x_tb_empresa_info info_us_x_em = info_usuario.lst_usuario_x_empresa.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa);
                    if (info_us_x_em == null)
                    {
                        info_us_x_em = new seg_usuario_x_tb_empresa_info();
                        info_us_x_em.IdEmpresa = item.IdEmpresa;
                        info_us_x_em.em_razon_social = item.RazonSocial;
                        info_usuario.lst_usuario_x_empresa.Add(info_us_x_em);
                    }
                }

                blst_usuario_x_empresa = new BindingList<seg_usuario_x_tb_empresa_info>(info_usuario.lst_usuario_x_empresa);
                gridControl_empresas.DataSource = blst_usuario_x_empresa;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                menu.set_accion(Accion);
                cargar_combos();
                switch (Accion)
                {
                    case eTipoAccion.NUEVO:
                        txt_usuario.Properties.ReadOnly = false;
                        break;
                    case eTipoAccion.MODIFICAR:
                        set_info_in_controls();
                        txt_usuario.Properties.ReadOnly = true;
                        break;
                    case eTipoAccion.CONSULTAR:
                        set_info_in_controls();
                        txt_usuario.Properties.ReadOnly = true;
                        break;
                    case eTipoAccion.ANULAR:
                        set_info_in_controls();
                        txt_usuario.Properties.ReadOnly = true;
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_empresas.RowCount; i++)
                {
                    gridView_empresas.SetRowCellValue(i, col_seleccionado, chk_seleccionar_visibles.Checked);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                lst_empresa = bus_empresa.get_list();
                blst_usuario_x_empresa = new BindingList<seg_usuario_x_tb_empresa_info>();
                foreach (var item in lst_empresa)
                {
                    seg_usuario_x_tb_empresa_info info_us = new seg_usuario_x_tb_empresa_info();
                    info_us.IdEmpresa = item.IdEmpresa;
                    info_us.seleccionado = false;
                    info_us.IdUsuario = "";
                    info_us.em_razon_social = item.RazonSocial;
                    blst_usuario_x_empresa.Add(info_us);
                }
                gridControl_empresas.DataSource = blst_usuario_x_empresa;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_info()
        {
            try
            {
                info_usuario.us_nombre = txt_nombre.Text.Trim();
                info_usuario.IdUsuario = txt_usuario.Text.Trim();
                info_usuario.us_contrasenia = txt_contrasenia.Text.Trim();
                info_usuario.lst_usuario_x_empresa = blst_usuario_x_empresa.Where(q => q.seleccionado == true).ToList();
                foreach (var item in info_usuario.lst_usuario_x_empresa)
                {
                    item.IdUsuario = info_usuario.IdUsuario;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            try
            {
                txt_usuario.Text = "";
                txt_contrasenia.Text = "";
                txt_nombre.Text = "";
                lbl_anulado.Visible = false;

                info_usuario = new seg_usuario_info();
                blst_usuario_x_empresa = new BindingList<seg_usuario_x_tb_empresa_info>();
                Accion = eTipoAccion.NUEVO;
                set_accion_in_controls();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            try
            {
                txt_usuario.Focus();

                if (txt_usuario.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el usuario", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txt_nombre.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el nombre de usuario", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txt_contrasenia.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la contraseña", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool accion_grabar()
        {
            try
            {
                bool res = false;
                if (!validar()) return false;

                get_info();

                switch (Accion)
                {
                    case eTipoAccion.NUEVO:
                        res = guardarDB();
                        break;
                    case eTipoAccion.MODIFICAR:
                        res = modificarDB();
                        break;
                    case eTipoAccion.ANULAR:
                        res = anularDB();
                        break;
                }

                return res;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool guardarDB()
        {
            try
            {
                string mensaje = "";
                if (bus_usuario.guardarDB(info_usuario, ref mensaje))
                {
                    if (bus_usuario_x_empresa.guardarDB(info_usuario.lst_usuario_x_empresa))
                    {
                        MessageBox.Show("Registro guardado exitosamente", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return true;
                    }
                }
                else
                    MessageBox.Show(mensaje, param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool modificarDB()
        {
            try
            {
                if (bus_usuario.modificarDB(info_usuario))
                {
                    bus_usuario_x_empresa.eliminarDB(info_usuario.IdUsuario);
                    if (bus_usuario_x_empresa.guardarDB(info_usuario.lst_usuario_x_empresa))
                    {
                        MessageBox.Show("Registro modificado exitosamente", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return true;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool anularDB()
        {
            try
            {
                if (bus_usuario.anularDB(info_usuario))
                {
                    bus_usuario_x_empresa.eliminarDB(info_usuario.IdUsuario);
                    MessageBox.Show("Registro anulado exitosamente", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void menu_event_delegate_btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_delegate_btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    this.limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_delegate_btn_guardar_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_delegate_btn_limpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                limpiar();
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

    }
}