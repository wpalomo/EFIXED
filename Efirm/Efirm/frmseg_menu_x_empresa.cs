using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FirmElect.Bus;
using FirmElect.Info;
using System.Linq;

using FirmElect.Bus;
using FirmElect.Info;


namespace Efirm
{
    public partial class frmseg_menu_x_empresa : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        cl_parametros_generales_info param = cl_parametros_generales_info.Instance;
        List<tb_Empresa_Info> lst_empresa = new List<tb_Empresa_Info>();
        tb_Empresa_Bus bus_empresa = new tb_Empresa_Bus();
        BindingList<seg_menu_x_tb_empresa_info> blst_menu_x_empresa = new BindingList<seg_menu_x_tb_empresa_info>();
        seg_menu_x_tb_empresa_bus bus_menu_x_empresa = new seg_menu_x_tb_empresa_bus();
        #endregion

        public frmseg_menu_x_empresa()
        {
            InitializeComponent();
        }

        private void cmb_empresa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                List<seg_menu_x_tb_empresa_info> lst_menu_x_empresa = new List<seg_menu_x_tb_empresa_info>();
                if (cmb_empresa.EditValue == null)
                {
                    blst_menu_x_empresa = new BindingList<seg_menu_x_tb_empresa_info>(lst_menu_x_empresa);
                    treeListMenu.DataSource = blst_menu_x_empresa;
                    return;
                }
                lst_menu_x_empresa = bus_menu_x_empresa.get_list(Convert.ToInt32(cmb_empresa.EditValue));
                lst_menu_x_empresa.AddRange(bus_menu_x_empresa.get_no_list(Convert.ToInt32(cmb_empresa.EditValue)));
                blst_menu_x_empresa = new BindingList<seg_menu_x_tb_empresa_info>(lst_menu_x_empresa);
                treeListMenu.DataSource = blst_menu_x_empresa;
                treeListMenu.ExpandAll();
                CheckearMenu(treeListMenu.Nodes);
                ArreglarCheckeo(treeListMenu.Nodes);
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

        private void frmseg_menu_x_empresa_Load(object sender, EventArgs e)
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

        private bool guardarDB()
        {
            try
            {
                get_info();

                bus_menu_x_empresa.eliminarDB(Convert.ToInt32(cmb_empresa.EditValue));

                if (bus_menu_x_empresa.guardarDB(blst_menu_x_empresa.Where(q=>q.seleccionado == true).ToList()))
                {
                    MessageBox.Show("Registros actualizados correctamente",param.nom_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
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