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
    public partial class frmAdministrador_Cbte_Electronicos : Form
    {
        public frmAdministrador_Cbte_Electronicos()
        {
            try
            {
                InitializeComponent();
                uC_Comprobante_recibido.Event_fileSystemWatcherRepositorio_Created += uC_Comprobante_recibido_Event_fileSystemWatcherRepositorio_Created;
            }
            catch (Exception ex)
            {
                
                
            }
            
        }

        void uC_Comprobante_recibido_Event_fileSystemWatcherRepositorio_Created(object sender, System.IO.FileSystemEventArgs e, string mensajeOut)
        {
            try
            {
                notifyIconAdmin.BalloonTipText = mensajeOut;
                notifyIconAdmin.BalloonTipIcon = ToolTipIcon.Info;
                notifyIconAdmin.BalloonTipTitle = "EFIRM";
                notifyIconAdmin.ShowBalloonTip(6000);
                notifyIconAdmin.Text = mensajeOut;
                notifyIconAdmin.Visible = true;
                

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void frmAdministrador_Cbte_Electronicos_Load(object sender, EventArgs e)
        {
            try
            {
                set_hide_all();
                uC_Comprobante_recibido.Dock = DockStyle.Fill;
                uC_Comprobante_recibido.Show();
            }
            catch (Exception ex)
            {
                
                
            }
            

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }


        void set_hide_all()
        {
            try
            {
                uC_Comprobante_recibido.Hide();
                uC_Comprobante_Valido_Firmado_efirm.Hide();
                uC_Comprobante_Recibidos_Aut_x_SRI.Hide();
                uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto.Hide();


            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void navBarItemRecibido_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            set_hide_all();
            uC_Comprobante_recibido.Dock = DockStyle.Fill;
            uC_Comprobante_recibido.Show();


        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            set_hide_all();
            uC_Comprobante_Valido_Firmado_efirm.Dock = DockStyle.Fill;
            uC_Comprobante_Valido_Firmado_efirm.Show();


        }

        private void btnFirmadosYAutorizadosxSRI_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            set_hide_all();
            uC_Comprobante_Recibidos_Aut_x_SRI.Dock = DockStyle.Fill;
            uC_Comprobante_Recibidos_Aut_x_SRI.Show();

            

        }

        private void btnCbtesRecibidos__LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
                try 
                {	        
                    set_hide_all();
                    uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto.Dock = DockStyle.Fill;
                    uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto.Show();

		                
                }
                catch (Exception ex)
                {
		
		
                }

            

        }

        private void uC_Comprobante_Valido_Firmado_efirm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
