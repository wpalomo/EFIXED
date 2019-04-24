using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Info;
using FirmElect.Bus;


namespace Efirm
{
    public partial class frmDisenio_Reporte_Consulta : Form
    {
        tb_Comprobante_tipo_Bus BusTipo = new tb_Comprobante_tipo_Bus();
        List<tb_Comprobante_tipo_Info> lista = new List<tb_Comprobante_tipo_Info>();
        tb_Comprobante_tipo_Info Fila = new tb_Comprobante_tipo_Info();
        frmDisenio_Reporte_Mant frm = null;
        tb_Empresa_Info EmpresaInfo = new tb_Empresa_Info();
        tb_Empresa_Bus EmpresaBus = new tb_Empresa_Bus();
        List<tb_Empresa_Info> Listaempresa = new List<tb_Empresa_Info>();
        string MensajeError = "";
        public frmDisenio_Reporte_Consulta()
        {
            InitializeComponent();
        }


        void cargar_grid()
        {
            try
            {
                string Msg="";
           
                lista=BusTipo.consultar(Convert.ToInt32(cmbemisor.EditValue), ref Msg);

                gridControlTipoCbte.DataSource = lista;

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void btn_disenio_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fila.IdEmpresa == 0)
                {
                    MessageBox.Show("Seleccione un registro");
                    return;
                }
                frm = new frmDisenio_Reporte_Mant();
                frm.Set(Fila);
                frm.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmDisenio_Reporte_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";

                lista = BusTipo.consultar(ref Msg);
                gridControlTipoCbte.DataSource = lista;
                CargarEmpresas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewTipoCbte_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                cmbemisor.Focus();
                Fila = (tb_Comprobante_tipo_Info)gridViewTipoCbte.GetFocusedRow();
            }
            catch (Exception ex)
            {

            }
        }


        public void CargarEmpresas()
        {
            try
            {
                Listaempresa = EmpresaBus.GetEmpresas(ref MensajeError);
                cmbemisor.Properties.DataSource = Listaempresa;
               // int id = Listaempresa.FirstOrDefault().IdEmpresa;
               // cmbemisor.EditValue = id;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + MensajeError);
            }
        }

        private void cmbemisor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + MensajeError);
            }

        }
    }
}
