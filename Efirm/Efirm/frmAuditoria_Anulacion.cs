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
    public partial class frmAuditoria_Anulacion : Form
    {
        public frmAuditoria_Anulacion()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_motivo_anulacion.Text == "" || txt_usuario_anulacion.Text == "")
            {
                MessageBox.Show("Debe Ingresar el usuario y el motivo de anulacion ", "Efirm.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Close();
        }
    }
}
