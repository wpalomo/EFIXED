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
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;

namespace MailEfirm.Controls
{
    public partial class UC_Menu_cuentas_mail : UserControl
    {
        public delegate void delegate_treeListMenuMail_AfterFocusNode(object sender, NodeEventArgs e);
        public event delegate_treeListMenuMail_AfterFocusNode event_treeListMenuMail_AfterFocusNode;
        List<vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info> list_vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo = new List<vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info>();
        vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Bus Bus_vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo = new vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Bus();
        vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info Info_Seleccionado = new vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info();

        public UC_Menu_cuentas_mail()
        {
            InitializeComponent();
            this.event_treeListMenuMail_AfterFocusNode += UC_Menu_cuentas_mail_event_treeListMenuMail_AfterFocusNode;
        }

        void UC_Menu_cuentas_mail_event_treeListMenuMail_AfterFocusNode(object sender, NodeEventArgs e)
        {
            
        }

        public string  obtenerPrimerNodo() {
            try
            {
                cargarTreeListImage();
                vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info Info = (vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info)treeListMenuMail.Nodes.FirstNode.Tag;
                return Info.direccion_correo;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private void UC_Menu_cuentas_mail_Load(object sender, EventArgs e)
        {
            cargarTreeListImage();          
        }

        public void cargarTreeListImage()
        {
            try
            {
                string msg = "";

                list_vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo = Bus_vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo.GetVwMailCuentas(ref msg);
                treeListMenuMail.Columns.Clear();
                TreeListColumn newColumn = treeListMenuMail.Columns.Add();
                newColumn.Caption = "Cuentas de Correo";
                newColumn.Visible = true;
                
                treeListMenuMail.Nodes.Clear();
                foreach (var item in list_vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo)
                {
                    if (item.IdCuenta == null)
                    {
                        TreeListNode rootNode = treeListMenuMail.Nodes.Add(new object[] { item.descripcion });
                        rootNode.Tag = item;
                        foreach (var item2 in list_vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo)
                        {
                            if (item2.IdCuenta == item.Id)
                            {
                                TreeListNode child1 = rootNode.Nodes.Add(new object[] { item2.descripcion });
                                child1.ImageIndex = imageList1.Images.IndexOfKey(item2.IdTipo_Mensaje); ;
                                child1.SelectImageIndex = imageList1.Images.IndexOfKey(item2.IdTipo_Mensaje); ;
                                child1.Tag = item2;
                            }
                        }
                        treeListMenuMail.RefreshNode(rootNode);
                    }

                }
                treeListMenuMail.ExpandAll();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void treeListMenuMail_AfterFocusNode(object sender, NodeEventArgs e)
        {
            event_treeListMenuMail_AfterFocusNode(sender, e);
            
        }

        private void treeListMenuMail_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            
        }

     
    }
}
