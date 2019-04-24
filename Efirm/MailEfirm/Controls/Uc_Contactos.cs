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
    public partial class Uc_Contactos : UserControl
    {
        //Form formulario;
        tb_Contribuyente_Info row = new tb_Contribuyente_Info();

        public tb_Contribuyente_Info  getInfo_Contacto()
        {
            return row;
        }


        public Uc_Contactos()
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


            }
          
        }

        private void Uc_Contactos_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_contactos();
            }
            catch (Exception ex)
            {
                
                
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


            }
        }
             
    }
}
