using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailEfirm
{
    public partial class Frm_Main_Mail : Form
    {
        


        public Frm_Main_Mail()
        {
            InitializeComponent();
            
        }

        private void uC_Menu_Main_Load(object sender, EventArgs e)
        {

        }

        public void set_Perfil(eTipo_Perfil_Usuario Perfil)
        {
            
                this.uC_Menu_Main.set_perfil(Perfil);
          
        }

        private void Frm_Main_Mail_Load(object sender, EventArgs e)
        {
            
        }
    }
}
