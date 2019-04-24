using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efirm
{
    public partial class frmComprobantes_autorizados_no_autorizados : Form
    {
        public frmComprobantes_autorizados_no_autorizados()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager_buscar.ShowWaitForm();
                uC_Comprobante_Autoriz_No_Autoriz_x_SRI1.cargar_xml(1);
                splashScreenManager_buscar.CloseWaitForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                splashScreenManager_buscar.CloseWaitForm();

            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                uC_Comprobante_Autoriz_No_Autoriz_x_SRI1.Imprimir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
