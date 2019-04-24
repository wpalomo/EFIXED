using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.general;
using FirmElect.Bus;
using FirmElect.Info;


namespace Efirm
{
    public partial class frmseg_login : DevExpress.XtraEditors.XtraForm
    {
        cl_parametros_generales_info param = cl_parametros_generales_info.Instance;
        seg_usuario_info info_usuario = new seg_usuario_info();
        seg_usuario_bus bus_usuario = new seg_usuario_bus();

        public frmseg_login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ingresar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas",param.nom_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private bool validar()
        {
            try
            {
                if (txt_usuario.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el usuario",param.nom_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txt_contrasenia.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la contraseña", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void frmseg_login_Load(object sender, EventArgs e)
        {
            try
            {
                txt_usuario.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txt_contrasenia.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_contrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ingresar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ingresar()
        {
            try
            {
                if (!validar()) return;

                info_usuario = bus_usuario.get_info(txt_usuario.Text);

                if (info_usuario.IdUsuario == null)
                {
                    MessageBox.Show("El usuario ingresado no existe", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_usuario.Focus();
                    return;
                }

                info_usuario = bus_usuario.get_info(txt_usuario.Text, txt_contrasenia.Text);

                if (info_usuario.IdUsuario == null)
                {
                    MessageBox.Show("La contraseña ingresada es incorrecta", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_contrasenia.Focus();
                    return;
                }

                cl_parametros_generales_info.Instance.info_usuario = info_usuario;
                cl_parametros_generales_info.Instance.IdUsuario = info_usuario.IdUsuario;
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.nom_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}