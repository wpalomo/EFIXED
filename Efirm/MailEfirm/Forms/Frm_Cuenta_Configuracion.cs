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

namespace MailEfirm.Forms
{
    public partial class Frm_Cuenta_Configuracion : Form
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        public eTipo_action Accion;

        public Frm_Cuenta_Configuracion()
        {
            InitializeComponent();
        }

        public void set_Accion(eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }

        }

        public void set_Info_Cuenta_Modificar(mail_Cuentas_Correo_Info Info)
        {
            try
            {
                this.uC_Cuenta_Configuracion1.set_info_Modificar(Info);
                this.uC_Cuenta_Configuracion1.set_controles();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
            
        }

        public void set_Info_Cuenta_Nueva(mail_Cuentas_Correo_Info Info)
        {

            this.uC_Cuenta_Configuracion1.set_info_Nuevo(Info);
        }

        private void Frm_Cuenta_Configuracion_Load(object sender, EventArgs e)
        {
            try
            {
                /////
                // cambio deñl switc
                 switch(Accion)
                 {
                    case eTipo_action.actualizar:
                        this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                        this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

                        break;


                    case eTipo_action.consultar:
                        this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                        this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                        uC_Cuenta_Configuracion1.BtnGuardar.Visible = false;

                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
              BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void uC_Cuenta_Configuracion1_Load(object sender, EventArgs e)
        {

        }

    }
}
