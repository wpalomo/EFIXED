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


namespace Efirm
{
    public partial class frmseg_menu_mant : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        cl_parametros_generales_info param = cl_parametros_generales_info.Instance;
        seg_menu_info info_menu = new seg_menu_info();
        seg_menu_bus bus_menu = new seg_menu_bus();
        eTipoAccion Accion;
        #endregion

        #region delegados
        public delegate void delegate_frmseg_menu_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmseg_menu_mant_FormClosed event_delegate_frmseg_menu_mant_FormClosed;
        #endregion

        public frmseg_menu_mant()
        {
            InitializeComponent();
            event_delegate_frmseg_menu_mant_FormClosed += frmseg_menu_mant_event_delegate_frmseg_menu_mant_FormClosed;
        }

        void frmseg_menu_mant_event_delegate_frmseg_menu_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmseg_menu_mant_Load(object sender, EventArgs e)
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

        public void set_info(seg_menu_info _info_menu)
        {
            try
            {
                info_menu = _info_menu;
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
                treeListMenu.Focus();
                treeListMenu.Nodes[0].Selected = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListMenu_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            try
            {
                treeListMenu.UncheckAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DevExpress.XtraTreeList.Nodes.TreeListNode nodoCheckeado = null;

        private void RecorrerNodos(DevExpress.XtraTreeList.Nodes.TreeListNodes listaNodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in listaNodos)
                {
                    nodo.Expanded = false;
                    if ((int)nodo.GetValue("IdMenu") == this.info_menu.IdMenu_padre)
                    {
                        nodo.CheckState = CheckState.Checked;
                        nodoCheckeado = nodo;
                        return;
                    }
                    if (nodo.Nodes.Count > 0)
                        RecorrerNodos(nodo.Nodes);
                }
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
                txt_IdMenu.Text = info_menu.IdMenu.ToString();
                txt_nivel.Text = info_menu.me_nivel.ToString();
                txt_nom_assembly.Text = info_menu.me_nom_assembly;
                txt_nom_formulario.Text = info_menu.me_nom_formulario;
                txt_nombre.Text = info_menu.me_nombre;
                chk_tiene_formulario.Checked = info_menu.me_es_menu;
                lbl_anulado.Visible = !info_menu.me_estado;

                if (this.info_menu.IdMenu_padre == null)
                {
                    chk_tiene_formulario.Checked = false;
                    this.treeListMenu.UncheckAll();
                }
                else
                {
                    RecorrerNodos(treeListMenu.Nodes);
                    this.nodoCheckeado.Selected = true;
                    chk_tiene_formulario.Checked = true;
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
                txt_IdMenu.Text = "";
                txt_nivel.Text = "";
                txt_nom_assembly.Text = "";
                txt_nom_formulario.Text = "";
                txt_nombre.Text = "";
                chk_tiene_formulario.Checked = false;
                lbl_anulado.Visible = false;
                this.treeListMenu.UncheckAll();
                info_menu = new seg_menu_info();
                Accion = eTipoAccion.NUEVO;
                set_accion_in_controls();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DevExpress.XtraTreeList.Nodes.TreeListNode RetornarNodoCheckeado(DevExpress.XtraTreeList.Nodes.TreeListNodes listaNodos)
        {
            try
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode nodoTemporal = null;

                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in listaNodos)
                {
                    if (nodo.Checked)
                    {
                        return nodo;
                    }
                    if (nodo.Nodes.Count > 0)
                    {
                        nodoTemporal = RetornarNodoCheckeado(nodo.Nodes);
                        if (nodoTemporal != null)
                        {
                            return nodoTemporal;
                        }
                    }
                }
                return nodoTemporal;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void frmseg_menu_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmseg_menu_mant_FormClosed(sender, e);
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
                info_menu.IdMenu = txt_IdMenu.Text == "" ? 0 : Convert.ToInt32(txt_IdMenu.Text);
                if (!chk_tiene_padre.Checked)
                    info_menu.IdMenu_padre = null;
                else
                {
                    int? nodo = RetornarNodoCheckeado(treeListMenu.Nodes).GetValue("IdMenu") as int?;
                    if (nodo == null)
                        return;
                    info_menu.IdMenu_padre = nodo;
                }
                info_menu.me_nivel = Convert.ToInt32(txt_nivel.Text);
                info_menu.me_nom_assembly = txt_nom_assembly.Text;
                info_menu.me_nom_formulario = txt_nom_formulario.Text;
                info_menu.me_nombre = txt_nombre.Text;
                info_menu.me_es_menu = chk_tiene_formulario.Checked;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_tiene_formulario_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_nom_assembly.Visible = chk_tiene_formulario.Checked;
                lbl_nom_formulario.Visible = chk_tiene_formulario.Checked;
                txt_nom_formulario.Visible = chk_tiene_formulario.Checked;
                txt_nom_assembly.Visible = chk_tiene_formulario.Checked;
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
                buscar();
                menu.set_accion(Accion);

                if (Accion!= eTipoAccion.NUEVO)
                {
                    set_info_in_controls();    
                }
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
                if (txt_nombre.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el nombre del formulario", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (chk_tiene_padre.Checked && RetornarNodoCheckeado(treeListMenu.Nodes) == null)
                {
                    MessageBox.Show("Seleccione el formulario padre", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (bus_menu.guardarDB(info_menu))
                {
                    MessageBox.Show("Registro guardado exitosamente", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private bool modificarDB()
        {
            try
            {
                if (bus_menu.modificarDB(info_menu))
                {
                    MessageBox.Show("Registro modificar exitosamente", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private bool anularDB()
        {
            try
            {
                if (bus_menu.anularDB(info_menu))
                {
                    MessageBox.Show("Registro anulado exitosamente", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                this.limpiar();
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