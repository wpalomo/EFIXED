using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using FirmElect.Bus;
using FirmElect.Info;
namespace Efirm
{
    public partial class frmseg_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        cl_parametros_generales_info param = cl_parametros_generales_info.Instance;
        seg_menu_x_tb_empresa_x_seg_usuario_bus bus_menu_x_empresa_x_usuario = new seg_menu_x_tb_empresa_x_seg_usuario_bus();
        seg_menu_info info_menu = new seg_menu_info();

        public frmseg_main()
        {
            InitializeComponent();
        }

        private void frmseg_main_Load(object sender, EventArgs e)
        {
            try
            {
                DevExpress.UserSkins.BonusSkins.Register();
                SkinHelper.InitSkinPopupMenu(btn_temas);
                EstablecerTema(btn_temas.ItemLinks);
                CapturarEventosApariencia(btn_temas.ItemLinks);

                if (ValidarIngreso())
                {
                    CargarMenu();
                    ucseg_menu_x_empresa_x_usuario1.treeList_menu.Focus();
                }

            }
            catch (Exception)
            {
                
            }
        }

        private void EstablecerTema(BarItemLinkCollection links)
        {
            try
            {
                foreach (var item in links)
                {
                    if (item.GetType() == typeof(BarSubItemLink))
                    {
                        BarSubItemLink subItems = (BarSubItemLink)item;
                        CapturarEventosApariencia(subItems.Item.ItemLinks);
                    }
                    if (item.GetType() == typeof(BarButtonItemLink))
                    {
                        BarButtonItemLink barItem = (BarButtonItemLink)item;
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void CapturarEventosApariencia(BarItemLinkCollection links)
        {
            try
            {
                foreach (var item in links)
                {
                    if (item.GetType() == typeof(BarSubItemLink))
                    {
                        BarSubItemLink subItems = (BarSubItemLink)item;
                        CapturarEventosApariencia(subItems.Item.ItemLinks);
                    }
                    if (item.GetType() == typeof(BarButtonItemLink))
                    {
                        BarButtonItemLink barItem = (BarButtonItemLink)item;
                        barItem.Item.ItemPress += itemAparienciaPresionado;
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private void itemAparienciaPresionado(object sender, ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
               
            }
        }

        private bool ValidarIngreso()
        {
            try
            {
                frmseg_login login = new frmseg_login();
                login.ShowDialog(this);

                if (param.info_usuario.IdUsuario == null)
                {
                    Application.Exit();
                    return false;
                }

                frmseg_login_x_empresa frm_login_x_empresas = new frmseg_login_x_empresa();
                frm_login_x_empresas.ShowDialog(this);               
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void CargarMenu()
        {
            try
            {
                //if (param.IdEmpresa == 0 && param.IdUsuario == null)
                //{
                //    param.IdEmpresa = 1;
                //    param.IdUsuario = "admin";
                //}
                List<seg_menu_x_tb_empresa_x_seg_usuario_info> lMenuInfo = bus_menu_x_empresa_x_usuario.get_list(param.IdEmpresa, param.IdUsuario);
                ucseg_menu_x_empresa_x_usuario1.treeList_menu.SelectImageList = ucseg_menu_x_empresa_x_usuario1.imageList1;
                ucseg_menu_x_empresa_x_usuario1.treeList_menu.ColumnsImageList = ucseg_menu_x_empresa_x_usuario1.imageList1;
                ucseg_menu_x_empresa_x_usuario1.treeList_menu.DataSource = null;
                ucseg_menu_x_empresa_x_usuario1.treeList_menu.DataSource = lMenuInfo;
                EstablecerIcono(ucseg_menu_x_empresa_x_usuario1.treeList_menu.Nodes);
                ucseg_menu_x_empresa_x_usuario1.treeList_menu.ExpandAll();


                //List<string> formularios = new List<string>();

                //formularios.Add("Frm_Main_Mail");             
                //formularios.Add("frmComprobantes_autorizados_no_autorizados");             
                //formularios.Add("frmComprobantes_en_repocitorio");             
                //formularios.Add("frmComprobantes_recibidos_sin_respuestas");
                //formularios.Add("frmComprobantes_validos");

                //foreach (var item in formularios)
                //{

                //    if (!this.FormularioEstaAbierto(item))
                //    {
                //        if (item == "Frm_Main_Mail")
                //        {
                //            MailEfirm.Frm_Main_Mail frm11 = new MailEfirm.Frm_Main_Mail();
                //            frm11.WindowState = FormWindowState.Maximized;
                //            frm11.MdiParent = this;
                //            frm11.Show();
                //        }

                //        if (item == "frmComprobantes_autorizados_no_autorizados")
                //        {
                //            frmComprobantes_autorizados_no_autorizados frm10 = new frmComprobantes_autorizados_no_autorizados();
                //            frm10.WindowState = FormWindowState.Maximized;
                //            frm10.MdiParent = this;
                //            frm10.Show();
                //        }

                //        if (item == "frmComprobantes_en_repocitorio")
                //        {
                //            frmComprobantes_en_repocitorio frm1 = new frmComprobantes_en_repocitorio();
                //            frm1.WindowState = FormWindowState.Maximized;
                //            frm1.MdiParent = this;
                //            frm1.Show();
                //        }
                //        if (item == "frmComprobantes_validos")
                //        {
                //            frmComprobantes_validos frm2 = new frmComprobantes_validos();
                //            frm2.WindowState = FormWindowState.Maximized;
                //            frm2.MdiParent = this;
                //            frm2.Show();

                //        }
                //        if (item == "frmComprobantes_recibidos_sin_respuestas")
                //        {
                //            frmComprobantes_recibidos_sin_respuestas frm3 = new frmComprobantes_recibidos_sin_respuestas();
                //            frm3.Show();
                //            frm3.MdiParent = this;
                //            frm3.WindowState = FormWindowState.Maximized;

                //        }
                //    }
                    
               // }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void EstablecerIcono(DevExpress.XtraTreeList.Nodes.TreeListNodes lnodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lnodos)
                {
                    string descripcion = (string)nodo.GetValue("info_menu.me_nombre");
                    if (nodo.Nodes.Count > 0)
                    {
                        EstablecerIcono(nodo.Nodes);                        
                    }
                    if ((bool)nodo.GetValue("info_menu.me_es_menu"))
                    {
                        nodo.ImageIndex = 2;
                        nodo.SelectImageIndex = 2;
                    }
                    else if (nodo.GetValue("info_menu.IdMenu_padre") == null)
                    {
                        nodo.ImageIndex = 0;
                        nodo.SelectImageIndex = 0;
                    }
                    else
                    {
                        nodo.ImageIndex = 1;
                        nodo.SelectImageIndex = 1;
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private void ucseg_menu_x_empresa_x_usuario1_event_delegate_btn_refrescar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                CargarMenu();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void ucseg_menu_x_empresa_x_usuario1_event_delegate_treeList_menu_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DevExpress.XtraTreeList.TreeList tree = (DevExpress.XtraTreeList.TreeList)sender;
                DevExpress.XtraTreeList.TreeListHitInfo hitInfo = tree.CalcHitInfo(e.Location);
                if (hitInfo.HitInfoType == DevExpress.XtraTreeList.HitInfoType.Cell)
                {
                    SeleccionarNodo(hitInfo.Node);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SeleccionarNodo(DevExpress.XtraTreeList.Nodes.TreeListNode nodo)
        {
            try
            {
                if (nodo.Id == -100000)
                {
                    ucseg_menu_x_empresa_x_usuario1.treeList_menu.ExpandAll();
                }
                else
                {
                    if ((bool)nodo.GetValue("info_menu.me_es_menu"))
                    {
                        info_menu.IdMenu = (int)nodo.GetValue("IdMenu");
                        info_menu.IdMenu_padre = (int)nodo.GetValue("info_menu.IdMenu_padre");
                        info_menu.me_nombre = (string)nodo.GetValue("info_menu.me_nombre");
                        info_menu.me_nivel = (int)nodo.GetValue("info_menu.me_nivel");                        
                        info_menu.me_es_menu = (bool)nodo.GetValue("info_menu.me_es_menu");
                        info_menu.me_nom_formulario = (string)nodo.GetValue("info_menu.me_nom_formulario");
                        info_menu.me_nom_assembly = (string)nodo.GetValue("info_menu.me_nom_assembly");
                        
                        this.Cursor = Cursors.WaitCursor;
                        LlamarFormulario();
                        MarcarNodoPadre(nodo);
                    }
                }

            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void MarcarNodoPadre(DevExpress.XtraTreeList.Nodes.TreeListNode nodo)
        {
            try
            {
                if (nodo.ParentNode != null)
                {
                    if (nodo.GetValue("info_menu.IdMenu_padre") as int? != 0)
                    {
                        if (!(bool)nodo.ParentNode.GetValue("info_menu.me_es_menu"))
                        {
                            nodo.ParentNode.Selected = true;
                        }
                        else
                        {
                            MarcarNodoPadre(nodo.ParentNode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlamarFormulario()
        {
            try
            {
                if (info_menu.me_es_menu == false)
                {
                    return;
                }

                string NombreFormulario = info_menu.me_nom_formulario;
                string Nombre_Asamble = info_menu.me_nom_assembly;
                string nombre_dll = "";

                string RutaPantalla = "";

                nombre_dll = Nombre_Asamble;
                System.Reflection.Assembly Ensamblado;
                Ensamblado = System.Reflection.Assembly.LoadFrom(nombre_dll);
                System.Reflection.AssemblyName assemName = Ensamblado.GetName();
                Version ver = assemName.Version;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(assemName.Name + "." + NombreFormulario);

                RutaPantalla = assemName.Name + "." + NombreFormulario;

                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario Emsamblado:" + Nombre_Asamble + "  Formulario:" + NombreFormulario, param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!this.FormularioEstaAbierto(NombreFormulario))
                    {
                        ObjFrm = Activator.CreateInstance(tipo);
                        Form Formulario = (Form)ObjFrm;
                        Formulario.Text = info_menu.me_nombre;
                        Formulario.MdiParent = this;
                        Formulario.Tag = info_menu;
                        Formulario.WindowState = FormWindowState.Maximized;
                        Formulario.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La aplicacion necesita ser reiniciada, se reiniciara..", "Efixed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {
            try
            {
                bool estaAbierto = false;
                if (this.MdiChildren.Length > 0)
                {
                    for (int i = 0; i < this.MdiChildren.Length; i++)
                    {
                        int posicion = NombreDelFrm.LastIndexOf('.');
                        string nombreCorto = NombreDelFrm.Substring(posicion + 1, NombreDelFrm.Length - posicion - 1);
                        if (posicion != -1)
                        {
                            if (nombreCorto.Equals(this.MdiChildren[i].Name))
                            {
                                estaAbierto = true;
                            }
                        }
                        else if (NombreDelFrm.Contains(this.MdiChildren[i].Name))
                        {
                            estaAbierto = true;
                        }

                        if (estaAbierto)
                        {
                            this.MdiChildren[i].Focus();
                            //MessageBox.Show("El formulario o reporte solicitado ya se encuentra abierto",param.nom_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                            return true;
                        }
                    }
                    return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La aplicacion necesita ser reiniciada, se reiniciara..", "Efixed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
                return false;
            }
        }

        private void ucseg_menu_x_empresa_x_usuario1_event_delegate_treeList_menu_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (ucseg_menu_x_empresa_x_usuario1.treeList_menu.Selection.Count > 0)
                {
                    switch(e.KeyCode)
                    {
                        case Keys.Enter:
                            SeleccionarNodo(ucseg_menu_x_empresa_x_usuario1.treeList_menu.Selection[0]);
                            break;
                        case Keys.Left:
                            ucseg_menu_x_empresa_x_usuario1.treeList_menu.Selection[0].Expanded = false;
                            break;
                        case Keys.Right:
                            ucseg_menu_x_empresa_x_usuario1.treeList_menu.Selection[0].Expanded = true;
                            break;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucseg_menu_x_empresa_x_usuario1_event_delegate_treeList_menu_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            try
            {
                if (e.Node.GetValue("info_menu.IdMenu_padre") as int? == 0)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La aplicacion necesita ser reiniciada, se reiniciara..", "Efixed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private void ucseg_menu_x_empresa_x_usuario1_event_delegate_treeList_menu_SelectImageClick(object sender, DevExpress.XtraTreeList.NodeClickEventArgs e)
        {
            try
            {
                SeleccionarNodo(e.Node);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La aplicacion necesita ser reiniciada, se reiniciara..", "Efixed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }
    }
}