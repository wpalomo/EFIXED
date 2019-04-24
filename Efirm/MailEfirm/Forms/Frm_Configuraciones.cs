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
using FirmElect.Recursos;



namespace MailEfirm.Forms
{
    public partial class Frm_Configuraciones : Form
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        static cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;

        mail_Parametro_Bus BusParMail = new mail_Parametro_Bus();
        mail_Parametro_Info InfoPara = new mail_Parametro_Info();


        public Frm_Configuraciones()
        {
            InitializeComponent();
        }

        private void cargar_parametros()
        {
            try
            {
                string msg="";



                InfoPara=BusParMail.consultar(ref msg);


                chk_envio_recep_au_salir.Checked = InfoPara.envio_recep_aut_salir;
                cmb_valor_min_env.Value = InfoPara.valor_min_envi_recep_aut;
                chk_envio_pdf.Checked = (InfoPara.enviar_solo_pdf_ride == null) ? false : Convert.ToBoolean(InfoPara.enviar_solo_pdf_ride);
                chk_envio_xml.Checked = (InfoPara.enviar_solo_xml_ride == null) ? false : Convert.ToBoolean(InfoPara.enviar_solo_xml_ride);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }


        private void Frm_Configuraciones_Load(object sender, EventArgs e)
        {
            cargar_parametros();


        }

        Boolean Guardar(ref string mensaje)
        {
            try
            {
             

                InfoPara.envio_recep_aut_salir=chk_envio_recep_au_salir.Checked;
                InfoPara.valor_min_envi_recep_aut=(Int32) cmb_valor_min_env.Value;
                InfoPara.enviar_solo_pdf_ride = chk_envio_pdf.Checked;
                InfoPara.enviar_solo_xml_ride = chk_envio_xml.Checked;

                return BusParMail.Guardar(InfoPara, ref mensaje);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                return false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try 
            {	
                string msg="";

                if (Guardar(ref msg))
                { 
                    MessageBox.Show (FirmElect.Recursos.Properties.Resources.msg_Grabado,param.Nom_Sistema ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(FirmElect.Recursos.Properties.Resources.msg_no_Grabo, param.Nom_Sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
		
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
