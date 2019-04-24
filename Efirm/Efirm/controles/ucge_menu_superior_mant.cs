using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace Efirms
{
    public partial class ucge_menu_superior_mant : DevExpress.XtraEditors.XtraUserControl
    {
        public ucge_menu_superior_mant()
        {
            InitializeComponent();
            event_delegate_btn_salir_ItemClick += ucge_menu_superior_mant_event_delegate_btn_salir_ItemClick;
            event_delegate_btn_anular_ItemClick += ucge_menu_superior_mant_event_delegate_btn_anular_ItemClick;
            event_delegate_btn_limpiar_ItemClick += ucge_menu_superior_mant_event_delegate_btn_limpiar_ItemClick;
            event_delegate_btn_guardar_salir_ItemClick += ucge_menu_superior_mant_event_delegate_btn_guardar_salir_ItemClick;
            event_delegate_btn_guardar_ItemClick += ucge_menu_superior_mant_event_delegate_btn_guardar_ItemClick;
            event_delegate_btn_imprimir_ItemClick+=ucge_menu_superior_mant_event_delegate_btn_imprimir_ItemClick;
        }

        #region Eventos delegados
        void ucge_menu_superior_mant_event_delegate_btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_mant_event_delegate_btn_guardar_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_mant_event_delegate_btn_limpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_mant_event_delegate_btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void ucge_menu_superior_mant_event_delegate_btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }


        void ucge_menu_superior_mant_event_delegate_btn_imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region delegados
        public delegate void delegate_btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_salir_ItemClick event_delegate_btn_salir_ItemClick;

        public delegate void delegate_btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_anular_ItemClick event_delegate_btn_anular_ItemClick;

        public delegate void delegate_btn_limpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_limpiar_ItemClick event_delegate_btn_limpiar_ItemClick;

        public delegate void delegate_btn_guardar_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_guardar_salir_ItemClick event_delegate_btn_guardar_salir_ItemClick;

        public delegate void delegate_btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_guardar_ItemClick event_delegate_btn_guardar_ItemClick;

        public delegate void delegate_btn_imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_imprimir_ItemClick event_delegate_btn_imprimir_ItemClick;

        #endregion

        #region Eventos formulario
        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_guardar_ItemClick(sender, e);
        }

        private void btn_guardar_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_guardar_salir_ItemClick(sender, e);
        }

        private void btn_limpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_limpiar_ItemClick(sender, e);
        }

        private void btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_anular_ItemClick(sender, e);
        }

        private void btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_salir_ItemClick(sender, e);
        }

        private void btn_imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_delegate_btn_imprimir_ItemClick(sender, e);
        }
        #endregion

        public void set_accion(cl_enumeradores_info.eTipoAccion Accion)
        {
            try
            {
                switch (Accion)
                {
                    case cl_enumeradores_info.eTipoAccion.NUEVO:
                        btn_anular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btn_guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_guardar_salir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_limpiar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_imprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case cl_enumeradores_info.eTipoAccion.MODIFICAR:
                        btn_anular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btn_guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_guardar_salir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_limpiar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_imprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        break;
                    case cl_enumeradores_info.eTipoAccion.CONSULTAR:
                        btn_anular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btn_guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btn_guardar_salir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btn_limpiar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_imprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        break;
                    case cl_enumeradores_info.eTipoAccion.ANULAR:
                        btn_anular.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btn_guardar_salir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btn_limpiar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        break;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        
    }
}
