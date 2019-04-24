using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;

namespace Efirms
{
    public partial class ucseg_menu_x_empresa_x_usuario : UserControl
    {
        public ucseg_menu_x_empresa_x_usuario()
        {
            InitializeComponent();
            event_delegate_treeList_menu_FocusedNodeChanged += ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_FocusedNodeChanged;
            event_delegate_treeList_menu_KeyUp += ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_KeyUp;
            event_delegate_treeList_menu_MouseClick += ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_MouseClick;
            event_delegate_treeList_menu_MouseDoubleClick += ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_MouseDoubleClick;
            event_delegate_treeList_menu_MouseDown += ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_MouseDown;
            event_delegate_treeList_menu_NodeCellStyle += ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_NodeCellStyle;
            event_delegate_treeList_menu_SelectImageClick += ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_SelectImageClick;
            event_delegate_treeList_menu_TreeListMenuItemClick += ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_TreeListMenuItemClick;
            event_delegate_btn_refrescar_ItemClick += ucseg_menu_x_empresa_x_usuario_event_delegate_btn_refrescar_ItemClick;
        }

        #region delegados
        public delegate void delegate_treeList_menu_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e);
        public event delegate_treeList_menu_FocusedNodeChanged event_delegate_treeList_menu_FocusedNodeChanged;

        public delegate void delegate_treeList_menu_KeyUp(object sender, KeyEventArgs e);
        public event delegate_treeList_menu_KeyUp event_delegate_treeList_menu_KeyUp;

        public delegate void delegate_treeList_menu_MouseClick(object sender, MouseEventArgs e);
        public event delegate_treeList_menu_MouseClick event_delegate_treeList_menu_MouseClick;

        public delegate void delegate_treeList_menu_MouseDoubleClick(object sender, MouseEventArgs e);
        public event delegate_treeList_menu_MouseDoubleClick event_delegate_treeList_menu_MouseDoubleClick;

        public delegate void delegate_treeList_menu_MouseDown(object sender, MouseEventArgs e);
        public event delegate_treeList_menu_MouseDown event_delegate_treeList_menu_MouseDown;

        public delegate void delegate_treeList_menu_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e);
        public event delegate_treeList_menu_NodeCellStyle event_delegate_treeList_menu_NodeCellStyle;

        public delegate void delegate_treeList_menu_SelectImageClick(object sender, DevExpress.XtraTreeList.NodeClickEventArgs e);
        public event delegate_treeList_menu_SelectImageClick event_delegate_treeList_menu_SelectImageClick;

        public delegate void delegate_treeList_menu_TreeListMenuItemClick(object sender, DevExpress.XtraTreeList.TreeListMenuItemClickEventArgs e);
        public event delegate_treeList_menu_TreeListMenuItemClick event_delegate_treeList_menu_TreeListMenuItemClick;

        public delegate void delegate_btn_refrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_refrescar_ItemClick event_delegate_btn_refrescar_ItemClick;
        #endregion

        #region eventos formulario
        private void treeList_menu_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            event_delegate_treeList_menu_FocusedNodeChanged(sender, e);
        }

        private void treeList_menu_KeyUp(object sender, KeyEventArgs e)
        {
            event_delegate_treeList_menu_KeyUp(sender, e);
        }

        private void treeList_menu_MouseClick(object sender, MouseEventArgs e)
        {
            event_delegate_treeList_menu_MouseClick(sender, e);
        }

        private void treeList_menu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            event_delegate_treeList_menu_MouseDoubleClick(sender, e);
        }

        private void treeList_menu_MouseDown(object sender, MouseEventArgs e)
        {
            event_delegate_treeList_menu_MouseDown(sender, e);
        }

        private void treeList_menu_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            event_delegate_treeList_menu_NodeCellStyle(sender, e);
        }

        private void treeList_menu_SelectImageClick(object sender, DevExpress.XtraTreeList.NodeClickEventArgs e)
        {
            event_delegate_treeList_menu_SelectImageClick(sender, e);
        }

        private void treeList_menu_TreeListMenuItemClick(object sender, DevExpress.XtraTreeList.TreeListMenuItemClickEventArgs e)
        {
            event_delegate_treeList_menu_TreeListMenuItemClick(sender, e);
        }

        private void btn_refrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_refrescar_ItemClick(sender, e);
        }
        #endregion

        #region eventos delegados
        void ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {

        }

        void ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_KeyUp(object sender, KeyEventArgs e)
        {

        }

        void ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_MouseClick(object sender, MouseEventArgs e)
        {

        }

        void ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        void ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_MouseDown(object sender, MouseEventArgs e)
        {

        }
        void ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {

        }

        void ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_SelectImageClick(object sender, NodeClickEventArgs e)
        {

        }

        void ucseg_menu_x_empresa_x_usuario_event_delegate_treeList_menu_TreeListMenuItemClick(object sender, TreeListMenuItemClickEventArgs e)
        {

        }

        void ucseg_menu_x_empresa_x_usuario_event_delegate_btn_refrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        private void treeList_menu_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            try
            {
                TreeList lista = sender as TreeList;
                if (e.Node == lista.FocusedNode)
                {
                    e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                    Rectangle rectangulo = new Rectangle(e.EditViewInfo.ContentRect.Left,
                        e.EditViewInfo.ContentRect.Top,
                        Convert.ToInt32(e.Graphics.MeasureString(e.CellText, this.treeList_menu.Font).Width + 1),
                        Convert.ToInt32(e.Graphics.MeasureString(e.CellText, this.treeList_menu.Font).Height));
                    e.Graphics.FillRectangle(SystemBrushes.Highlight, rectangulo);
                    e.Graphics.DrawString(e.CellText, treeList_menu.Font, SystemBrushes.HighlightText, rectangulo);

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
