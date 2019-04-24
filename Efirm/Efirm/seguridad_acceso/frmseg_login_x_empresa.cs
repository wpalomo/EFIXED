using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.general;
using System.Linq;
using FirmElect.Bus;
using FirmElect.Info;


namespace Efirm
{
    public partial class frmseg_login_x_empresa : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        cl_parametros_generales_info param = cl_parametros_generales_info.Instance;
        List<seg_usuario_x_tbl_empresa_info> lst_usuario_x_empresa = new List<seg_usuario_x_tbl_empresa_info>();
        seg_usuario_x_tbl_empresa_bus bus_usuario_x_empresa = new seg_usuario_x_tbl_empresa_bus();
        tbl_empresa_bus bus_empresa = new tbl_empresa_bus();
        tbl_empresa_info info_empresa = new tbl_empresa_info();
        #endregion

        public frmseg_login_x_empresa()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validar()) return;
                info_empresa = bus_empresa.get_info(Convert.ToInt32(cmb_empresa.EditValue));
                cl_parametros_generales_info.Instance.info_empresa = info_empresa;
                cl_parametros_generales_info.Instance.IdEmpresa = info_empresa.IdEmpresa;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmseg_login_x_empresa_Load(object sender, EventArgs e)
        {
            try
            {
                lst_usuario_x_empresa = bus_usuario_x_empresa.get_list(param.info_usuario.IdUsuario);
                
                if (lst_usuario_x_empresa.Count == 0)
                {
                    MessageBox.Show("El usuario no tiene permitido el uso de la aplicación en ninguna empresa",param.nom_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    Application.Exit();
                }

                cmb_empresa.Properties.DataSource = lst_usuario_x_empresa;
                cmb_empresa.EditValue = lst_usuario_x_empresa.First().IdEmpresa;
                cmb_empresa.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            try
            {
                if (cmb_empresa.EditValue == null)
                {
                    MessageBox.Show("Seleccione la empresa", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_empresa.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}