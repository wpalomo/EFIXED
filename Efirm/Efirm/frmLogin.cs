using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Bus;
using FirmElect.Info;


namespace Efirm
{
    public partial class frmLogin : Form
    {
        public Boolean logoneado { get; set; }


        public frmLogin()
        {
            InitializeComponent();
            logoneado = false;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string msg="";


                tb_usuario_Bus OBusUser = new tb_usuario_Bus();

                if (OBusUser.Login(txtUsuario.Text, txtContraseña.Text, ref msg))
                {
                    logoneado = true;
                }
                else
                {
                    logoneado = false;
                    MessageBox.Show("Usuario no valido " + msg);
                }

                this.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            logoneado = false;
            this.Close();

        }
    }
}
