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
    public partial class frmseg_menu_x_empresa_x_usuario : DevExpress.XtraEditors.XtraForm
    {
        #region variables
        cl_parametros_generales_info param = cl_parametros_generales_info.Instance;
        seg_menu_x_tb_empresa_x_seg_usuario_bus bus_menu_x_empresa_x_usuario = new seg_menu_x_tb_empresa_x_seg_usuario_bus();
        BindingList<seg_menu_x_tb_empresa_x_seg_usuario_info> blst_menu_x_empresa_x_usuario = new BindingList<seg_menu_x_tb_empresa_x_seg_usuario_info>();
        seg_menu_x_tb_empresa_bus bus_menu_x_empresa = new seg_menu_x_tb_empresa_bus();
        List<tb_Empresa_Info> lst_empresa = new List<tb_Empresa_Info>();
        tb_Empresa_Bus bus_empresa = new tb_Empresa_Bus();
        List<seg_usuario_x_tb_empresa_info> lst_usuario_x_empresa = new List<seg_usuario_x_tb_empresa_info>();
        seg_usuario_x_tbl_empresa_bus bus_usuario_x_empresa = new seg_usuario_x_tbl_empresa_bus();
        #endregion

        public frmseg_menu_x_empresa_x_usuario()
        {
            InitializeComponent();
        }

        private void cmb_empresa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string msg = "";
                lst_usuario_x_empresa = new List<seg_usuario_x_tb_empresa_info>();
                blst_menu_x_empresa_x_usuario = new BindingList<seg_menu_x_tb_empresa_x_seg_usuario_info>();
                treeListMenu.DataSource = blst_menu_x_empresa_x_usuario;
                if (cmb_empresa.EditValue != null)
                {
                    lst_usuario_x_empresa = bus_usuario_x_empresa.get_list(Convert.ToInt32(cmb_empresa.EditValue));
                    cmb_usuario.Properties.DataSource = lst_usuario_x_empresa;
                    if (cmb_usuario.EditValue != null)
                    {
                        if (lst_usuario_x_empresa.Where(q => q.IdUsuario == cmb_usuario.EditValue.ToString()).Count() == 0)
                            cmb_usuario.EditValue = null;
                        else
                            cargar_combos();
                    }
                }
                else
                    cmb_usuario.EditValue = null;
                cmb_usuario.Properties.DataSource = lst_usuario_x_empresa;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_usuario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                blst_menu_x_empresa_x_usuario = new BindingList<seg_menu_x_tb_empresa_x_seg_usuario_info>();
                treeListMenu.DataSource = blst_menu_x_empresa_x_usuario;
                if (cmb_usuario.EditValue != null)
                {
                    cargar_menu();
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
                cmb_empresa.Properties.DataSource = lst_empresa;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmseg_menu_x_empresa_x_usuario_Load(object sender, EventArgs e)
        {
            try
            {
                ucge_menu_superior_mant1.set_accion(eTipoAccion.NUEVO);
                cargar_combos();
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
                EstablecerCheckeo(treeListMenu.Nodes);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckearMenu(DevExpress.XtraTreeList.Nodes.TreeListNodes lNodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lNodos)
                {
                    if ((bool)nodo.GetValue("seleccionado"))
                        nodo.Checked = true;
                    if (nodo.Nodes.Count > 0)
                        CheckearMenu(nodo.Nodes);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ArreglarCheckeo(DevExpress.XtraTreeList.Nodes.TreeListNodes lNodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lNodos)
                {
                    if ((bool)nodo.GetValue("seleccionado"))
                    {
                        if (nodo.Nodes.Count > 0)
                        {
                            ArreglarCheckeo(nodo.Nodes);
                            bool todoCheckeado = true;
                            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodoHijo in nodo.Nodes)
                            {
                                if (nodoHijo.Checked == false)
                                {
                                    todoCheckeado = false;
                                }
                            }
                            if (todoCheckeado == false)
                            {
                                nodo.CheckState = CheckState.Indeterminate;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstablecerCheckeo(DevExpress.XtraTreeList.Nodes.TreeListNodes lNodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lNodos)
                {
                    if (nodo.CheckState == CheckState.Unchecked)
                    {
                        nodo.SetValue("seleccionado", false);
                    }
                    else
                    {
                        nodo.SetValue("seleccionado", true);
                    }
                    if (nodo.Nodes.Count > 0)
                        EstablecerCheckeo(nodo.Nodes);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_menu()
        {
            try
            {
                List<seg_menu_x_tb_empresa_x_seg_usuario_info> lst_menu_x_empresa_x_usuario = new List<seg_menu_x_tb_empresa_x_seg_usuario_info>();
                lst_menu_x_empresa_x_usuario = bus_menu_x_empresa_x_usuario.get_list(Convert.ToInt32(cmb_empresa.EditValue), cmb_usuario.EditValue.ToString());
                lst_menu_x_empresa_x_usuario.AddRange(bus_menu_x_empresa_x_usuario.get_no_list(Convert.ToInt32(cmb_empresa.EditValue), cmb_usuario.EditValue.ToString()));
                blst_menu_x_empresa_x_usuario = new BindingList<seg_menu_x_tb_empresa_x_seg_usuario_info>(lst_menu_x_empresa_x_usuario);
                treeListMenu.DataSource = blst_menu_x_empresa_x_usuario;
                treeListMenu.ExpandAll();
                CheckearMenu(treeListMenu.Nodes);
                ArreglarCheckeo(treeListMenu.Nodes);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool guardarDB()
        {
            try
            {
                get_info();

                bus_menu_x_empresa_x_usuario.eliminarDB(Convert.ToInt32(cmb_empresa.EditValue), cmb_usuario.EditValue.ToString());

                if (bus_menu_x_empresa_x_usuario.guardarDB(blst_menu_x_empresa_x_usuario.Where(q => q.seleccionado == true).ToList()))
                {
                    MessageBox.Show("Registros actualizados correctamente", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ucge_menu_superior_mant1_event_delegate_btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (guardarDB())
                {
                    cmb_empresa.EditValue = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucge_menu_superior_mant1_event_delegate_btn_guardar_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (guardarDB())
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucge_menu_superior_mant1_event_delegate_btn_limpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cmb_empresa.EditValue = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucge_menu_superior_mant1_event_delegate_btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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