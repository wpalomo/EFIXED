using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailEfirm.Controls;
using FirmElect.Info;


namespace MailEfirm.Forms
{
    public partial class Frm_Nuevo_Usuario : Form
    {
        public Frm_Nuevo_Usuario()
        {
            InitializeComponent();
        }


        public void set_Info_Contacto(tb_Contribuyente_Info Info)
        {
            this.uC_Registro_Contacto.set_info(Info);
        
        }

        private void uC_Registro_Contacto1_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Nuevo_Usuario_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void uC_Registro_Contacto1_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_Registro_Contacto1_Load_2(object sender, EventArgs e)
        {
         
        }
    }
}
