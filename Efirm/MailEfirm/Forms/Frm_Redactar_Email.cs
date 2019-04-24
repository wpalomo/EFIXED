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
    public partial class Frm_Redactar_Email : Form
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        public Frm_Redactar_Email()
        {
            InitializeComponent();
            this.uC_Menu_Redactar_Email1.Event_Correo_generado += uC_Menu_Redactar_Email1_Event_Cerrar_form;
            this.uC_Menu_Redactar_Email1.btn_salir.Click += btn_salir_Click;
        }

        void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void uC_Menu_Redactar_Email1_Event_Cerrar_form()
        {
            try
            {
                this.Close();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
        }

       public void set(mail_Mensaje_Info info)
        {
            try
            {
                uC_Menu_Redactar_Email1.setInfo(info);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        
        }

       public void set_label_buton_enviar(string label)
       {
           try
           {
               uC_Menu_Redactar_Email1.BtnEnviarMail.Text = label;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message.ToString());
               BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

           }

       }

        private void Frm_Redactar_Email_Load(object sender, EventArgs e)
        {

        }
    }
}
