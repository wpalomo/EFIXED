using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Bus;
using FirmElect.Info;

namespace Efirm
{
    public partial class UC_Emisor : UserControl
    {
        List<tb_Empresa_Info> listEmpresa = new List<tb_Empresa_Info>();
        tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
        string MensajeError = "";


        public int Get_IdEmisor()
        {
            try
            {
                tb_Empresa_Info InfoEmpresa = new tb_Empresa_Info();
                InfoEmpresa = listEmpresa.FirstOrDefault(v => v.IdEmpresa == Convert.ToInt32(cmb_emisor.EditValue));


                return InfoEmpresa.IdEmpresa;
            }
            catch (Exception ex)
            {

                return 0;
            }
            
        }

        public tb_Empresa_Info Get_InfoEmisor()
        {
            try
            {
                tb_Empresa_Info InfoEmpresa = new tb_Empresa_Info();
                InfoEmpresa = listEmpresa.FirstOrDefault(v => v.IdEmpresa == Convert.ToInt32(cmb_emisor.EditValue));
                return InfoEmpresa;
            }
            catch (Exception ex)
            {
                return new tb_Empresa_Info();
            }
        }

        public UC_Emisor()
        {
            InitializeComponent();
        }



        private void cmb_emisor_EditValueChanged(object sender, EventArgs e)
        {
            

        }

        private void UC_Emisor_Load(object sender, EventArgs e)
        {
            try
            {

                listEmpresa = BusEmpresa.GetEmpresas(ref MensajeError);

                listEmpresa.Add(new tb_Empresa_Info(0, "TODOS"));

                cmb_emisor.Properties.DataSource = listEmpresa;
                cmb_emisor.EditValue = "1";

            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}
