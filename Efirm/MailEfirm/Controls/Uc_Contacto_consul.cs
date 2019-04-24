using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailEfirm;
using MailEfirm.Forms;
using FirmElect.Info;
using FirmElect.Bus;



namespace MailEfirm.Controls
{
    public partial class Uc_Contacto_consul : UserControl
    {
        //Form formulario;

        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        tb_Contribuyente_Info row = new tb_Contribuyente_Info();

        public tb_Contribuyente_Info  getInfo_Contacto()
        {
            return row;
        }


        public Uc_Contacto_consul()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControlContacto_Click(object sender, EventArgs e)
        {

        }


        public void Cargar_contactos()
        {
            try
            {
                string msg="";
                tb_Contribuyente_Bus Bus_cont = new tb_Contribuyente_Bus();

                gridControlContacto.DataSource = Bus_cont.GetListContribuyente(ref msg);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 

            }
          
        }

        private void Uc_Contactos_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_contactos(); //no poner porq la pantalla se pone lenta cargar los contactos al momento q hace click en contacttos
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
                
            }

        }

        private void gridControlContacto_MouseClick(object sender, MouseEventArgs e)
        {
            
           
        }

        private void navBarControlContactoCont_Click(object sender, EventArgs e)
        {

        }

        private void gridViewContactos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                row = (tb_Contribuyente_Info)gridViewContactos.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
                              
            }
        }

        public void Cargar_Data()
        {
            try
            {
                tb_Contribuyente_Info info = new tb_Contribuyente_Info();
                info= row;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
                               
            }
        
        }

        private void btn_Refresc_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_contactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());          

            }
        }
             
    }
}
