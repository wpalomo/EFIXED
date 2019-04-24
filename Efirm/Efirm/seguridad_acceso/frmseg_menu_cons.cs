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
    public partial class frmseg_menu_cons : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        cl_parametros_generales_info param = cl_parametros_generales_info.Instance;
        seg_menu_info info_menu = new seg_menu_info();
        seg_menu_bus bus_menu = new seg_menu_bus();
        #endregion

        public frmseg_menu_cons()
        {
            InitializeComponent();
        }

        private void frmseg_menu_cons_Load(object sender, EventArgs e)
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

        private void buscar()
        {
            try
            {
                treeListMenu.DataSource = bus_menu.get_list();
                treeListMenu.Refresh();
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in treeListMenu.Nodes)
                    nodo.Expanded = false;
                treeListMenu.ExpandAll();
                treeListMenu.Focus();
                treeListMenu.Nodes[0].Selected = true;                
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private seg_menu_info NodoSeleccionado()
        {
            try
            {
                info_menu = new seg_menu_info();
                info_menu.IdMenu = (int)treeListMenu.Selection[0].GetValue("IdMenu");
                info_menu.IdMenu_padre = treeListMenu.Selection[0].GetValue("IdMenu_padre") as int?;
                info_menu.me_nombre = (string)treeListMenu.Selection[0].GetValue("me_nombre");
                info_menu.me_nivel = (int)treeListMenu.Selection[0].GetValue("me_nivel");
                info_menu.me_es_menu = (bool)treeListMenu.Selection[0].GetValue("me_es_menu");
                info_menu.me_nom_formulario = (string)treeListMenu.Selection[0].GetValue("me_nom_formulario");
                info_menu.me_nom_assembly = (string)treeListMenu.Selection[0].GetValue("me_nom_assembly");
                info_menu.me_estado = (bool)treeListMenu.Selection[0].GetValue("me_estado");
                return info_menu;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void llamar_formulario(cl_enumeradores_info.eTipoAccion Accion)
        {
            try
            {
                frmseg_menu_mant frm = new frmseg_menu_mant();
                frm.set_accion(Accion);
                if (Accion != cl_enumeradores_info.eTipoAccion.NUEVO)
                    frm.set_info(info_menu);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_delegate_frmseg_menu_mant_FormClosed += frm_event_delegate_frmseg_menu_mant_FormClosed;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_delegate_frmseg_menu_mant_FormClosed(object sender, FormClosedEventArgs e)
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

        private void ucge_menu_superior_cons1_event_delegate_btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_menu = NodoSeleccionado();

                if (info_menu == null)
                {
                    MessageBox.Show("Seleccione un registro", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!info_menu.me_estado)
                {
                    MessageBox.Show("El registro se encuentra anulado",param.nom_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(cl_enumeradores_info.eTipoAccion.ANULAR);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucge_menu_superior_cons1_event_delegate_btn_consultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_menu = NodoSeleccionado();

                if (info_menu == null)
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

        private void ucge_menu_superior_cons1_event_delegate_btn_modificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListMenu.Selection.Count != 1)
                {
                    MessageBox.Show("Seleccione un registro", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                info_menu = NodoSeleccionado();

                if (info_menu == null)
                {
                    MessageBox.Show("Seleccione un registro", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!info_menu.me_estado)
                {
                    MessageBox.Show("El registro se encuentra anulado", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(cl_enumeradores_info.eTipoAccion.MODIFICAR);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucge_menu_superior_cons1_event_delegate_btn_imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                treeListMenu.ShowPrintPreview();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucge_menu_superior_cons1_event_delegate_btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucge_menu_superior_cons1_event_delegate_btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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