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


namespace Efirm
{
    public partial class frmParametro : Form
    {
        public frmParametro()
        {
            InitializeComponent();
        }

        tb_Parametro_Bus BusPar = new tb_Parametro_Bus();
        tb_Parametro_Info InfoParametro = new tb_Parametro_Info();
        BindingList<tb_Parametro_Info> DataSource = new BindingList<tb_Parametro_Info>();
        
        private void cargar()
        {
            try
            {
                string msg = "";

                InfoParametro = BusPar.consultar(ref msg);
               DataSource.Add(InfoParametro);
               gridControlParametro.DataSource = DataSource;
            }
            catch (Exception ex)
            {
            }
        }


        private void frmParametro_Load(object sender, EventArgs e)
        {
            try
            {
                cargar();

            }
            catch (Exception ex)
            {
                
                
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Parametro_Info InfoM= new tb_Parametro_Info();
                string msg="";
                statusStripBarraEstado.Focus();


                foreach (var item in DataSource)
                {
                    InfoM.IdParametro=item.IdParametro;
                    InfoM.url_ws_sri_Recep_cbte_Prueba=item.url_ws_sri_Recep_cbte_Prueba;
                    InfoM.url_ws_sri_Recep_cbte_Produc=item.url_ws_sri_Recep_cbte_Produc;
                    InfoM.url_ws_sri_Autorizacion_cbte_Prueba=item.url_ws_sri_Autorizacion_cbte_Prueba;
                    InfoM.url_ws_sri_Autorizacion_cbte_Produc=item.url_ws_sri_Autorizacion_cbte_Produc;
                    InfoM.url_ws_firma_efirm=item.url_ws_firma_efirm;

                    InfoM.Usa_Proxy = item.Usa_Proxy;
                    InfoM.Url_Proxy = item.Url_Proxy;
                    InfoM.Port_Proxy = item.Port_Proxy;
                    InfoM.Usuario_Proxy = item.Usuario_Proxy;
                    InfoM.Password_Proxy = item.Password_Proxy;

                }

                BusPar.ModificarDB(InfoM, ref msg);

                MessageBox.Show("Grabado Ok","sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void gridControlParametro_Click(object sender, EventArgs e)
        {

        }
    }
}
