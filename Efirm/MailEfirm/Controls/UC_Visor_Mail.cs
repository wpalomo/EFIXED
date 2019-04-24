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




namespace MailEfirm.Controls
{
    public partial class UC_Visor_Mail : UserControl
    {
        public UC_Visor_Mail()
        {
            InitializeComponent();
        }

        private void gridControlVisor_Mail_Click(object sender, EventArgs e)
        {

        }

        public  void mostrar_mensajes(eTipoMail TipoMail)
        {
            try
            {
                string msg="";
                mail_Mensaje_Bus MenBus = new mail_Mensaje_Bus();
                gridControlVisor_Mail.DataSource = MenBus.consultar(TipoMail, ref msg);

            }
            catch (Exception ex)
            {
                
                
            }
        
        }

        private void gridControlVisor_Mail_Load(object sender, EventArgs e)
        {
            
        }

        private void UC_Visor_Mail_Load(object sender, EventArgs e)
        {
            ///this.UC_Visor_Mail.Dock = DockStyle.Fill;
        }

    }
}
