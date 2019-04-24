using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
namespace Efirms
{
    public partial class ucge_menu_superior_cons : DevExpress.XtraEditors.XtraUserControl
    {
        public ucge_menu_superior_cons()
        {
            InitializeComponent();
            event_delegate_btn_nuevo_ItemClick += ucge_menu_superior_cons_event_delegate_btn_nuevo_ItemClick;
            event_delegate_btn_modificar_ItemClick += ucge_menu_superior_cons_event_delegate_btn_modificar_ItemClick;
            event_delegate_btn_consultar_ItemClick += ucge_menu_superior_cons_event_delegate_btn_consultar_ItemClick;
            event_delegate_btn_anular_ItemClick += ucge_menu_superior_cons_event_delegate_btn_anular_ItemClick;
            event_delegate_btn_buscar_ItemClick += ucge_menu_superior_cons_event_delegate_btn_buscar_ItemClick;
            event_delegate_btn_imprimir_ItemClick += ucge_menu_superior_cons_event_delegate_btn_imprimir_ItemClick;
            event_delegate_btn_salir_ItemClick += ucge_menu_superior_cons_event_delegate_btn_salir_ItemClick;
        }

        #region Visible
        public bool Visible_grupo_filtros { get { return this.grupo_filtros.Visible; } set { this.grupo_filtros.Visible = value; } }
        public bool Visible_grupo_imprimir { get { return this.grupo_imprimir.Visible; } set { this.grupo_imprimir.Visible = value; } }
        #endregion

        #region Eventos delegados

        void ucge_menu_superior_cons_event_delegate_btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_cons_event_delegate_btn_imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_cons_event_delegate_btn_buscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_cons_event_delegate_btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_cons_event_delegate_btn_consultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_cons_event_delegate_btn_modificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_cons_event_delegate_btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        #endregion
        
        #region delegados
        public delegate void delegate_btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_nuevo_ItemClick event_delegate_btn_nuevo_ItemClick;

        public delegate void delegate_btn_modificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_modificar_ItemClick event_delegate_btn_modificar_ItemClick;

        public delegate void delegate_btn_consultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_consultar_ItemClick event_delegate_btn_consultar_ItemClick;

        public delegate void delegate_btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_anular_ItemClick event_delegate_btn_anular_ItemClick;

        public delegate void delegate_btn_buscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_buscar_ItemClick event_delegate_btn_buscar_ItemClick;

        public delegate void delegate_btn_imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_imprimir_ItemClick event_delegate_btn_imprimir_ItemClick;

        public delegate void delegate_btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_salir_ItemClick event_delegate_btn_salir_ItemClick;
        #endregion

        #region Eventos formulario
        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_nuevo_ItemClick(sender, e);
        }

        private void btn_modificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_modificar_ItemClick(sender, e);
        }

        private void btn_consultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_consultar_ItemClick(sender, e);
        }

        private void btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_anular_ItemClick(sender,e);
        }

        private void btn_buscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_buscar_ItemClick(sender, e);
        }

        private void btn_imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_imprimir_ItemClick(sender, e);
        }

        private void btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_salir_ItemClick(sender, e);
        }
        #endregion

        private void ucge_menu_superior_cons_Load(object sender, EventArgs e)
        {

        }

        public void cargar_combos()
        {
            try
            {
                bei_fecha_fin.EditValue = DateTime.Now.Date;
                bei_fecha_ini.EditValue = DateTime.Now.Date.AddMonths(-1);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
