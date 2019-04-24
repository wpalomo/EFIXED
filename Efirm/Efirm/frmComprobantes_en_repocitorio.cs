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
    public partial class frmComprobantes_en_repocitorio : Form
    {
        public frmComprobantes_en_repocitorio()
        {
            InitializeComponent();
            uC_Comprobante_En_Repositorio1.Event_fileSystemWatcherRepositorio_Created += uC_Comprobante_En_Repositorio1_Event_fileSystemWatcherRepositorio_Created;
            uC_Comprobante_En_Repositorio1.btn_salir.Click+=btn_salir_Click;
        }

        void uC_Comprobante_En_Repositorio1_Event_fileSystemWatcherRepositorio_Created(object sender, System.IO.FileSystemEventArgs e, string mensajeOut)
        {
            try
            {
                //notifyIconAdmin.BalloonTipText = mensajeOut;
                //notifyIconAdmin.BalloonTipIcon = ToolTipIcon.Info;
                //notifyIconAdmin.BalloonTipTitle = "EFIRM";
                //notifyIconAdmin.ShowBalloonTip(6000);
                //notifyIconAdmin.Text = mensajeOut;
                //notifyIconAdmin.Visible = true;


            }
            catch (Exception ex)
            {


            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
