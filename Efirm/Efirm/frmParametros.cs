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
using System.IO;


namespace Efirm
{
    public partial class frmParametros : Form
    {
        tb_Parametro_Bus BusPar = new tb_Parametro_Bus();
        tb_Parametro_Info InfoParametro = new tb_Parametro_Info();
        BindingList<tb_Parametro_Info> DataSource = new BindingList<tb_Parametro_Info>();
        System.Windows.Forms.ErrorProvider errProvider = new System.Windows.Forms.ErrorProvider();

        public frmParametros()
        {
            InitializeComponent();
        }

        private void frmParametros_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                cargar();

            }
            catch (Exception ex)
            {


            }
        }


        private void cargar()
        {
            try
            {
                string msg = "";

                InfoParametro = BusPar.consultar(ref msg);
                lblIdParametro.Text = InfoParametro.IdParametro.ToString();
                txtWebServiPrueba.Text = InfoParametro.url_ws_sri_Recep_cbte_Prueba;
                txtWebServiProduc.Text = InfoParametro.url_ws_sri_Recep_cbte_Produc;
                txtWebAutoriPrueba.Text = InfoParametro.url_ws_sri_Autorizacion_cbte_Prueba;
                txtWebAutoriProduccion.Text = InfoParametro.url_ws_sri_Autorizacion_cbte_Produc;
                txtWebServiEfirm.Text = InfoParametro.url_ws_firma_efirm;
                checkUsaProxy.Checked = (InfoParametro.Usa_Proxy == null) ? false : Convert.ToBoolean(InfoParametro.Usa_Proxy);
                txtUrlProxy.Text = InfoParametro.Url_Proxy;
                txtPuertoProxy.Text = InfoParametro.Port_Proxy.ToString();
                txtUsuarioProxy.Text = InfoParametro.Usuario_Proxy;
                txtPasswordProxy.Text = InfoParametro.Password_Proxy;
                chkRegistraLog.Checked = (InfoParametro.Registra_Log == null) ? false : Convert.ToBoolean(InfoParametro.Registra_Log);
                txtVersion.Text = InfoParametro.Version.ToString();
                cmb_tipo_emision.EditValue = InfoParametro.offline_online;

            }
            catch (Exception ex)
            {
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarRegistros();
        }


        private void guardarRegistros()
        {
            try
            {
                tb_Parametro_Info InfoM = new tb_Parametro_Info();
                string msg = "";
              //  statusStripBarraEstado.Focus();
                if (validarObjetos())
                {
                    InfoM.IdParametro = Convert.ToInt16(lblIdParametro.Text);
                    InfoM.url_ws_sri_Recep_cbte_Prueba = txtWebServiPrueba.Text;
                    InfoM.url_ws_sri_Recep_cbte_Produc = txtWebServiProduc.Text;
                    InfoM.url_ws_sri_Autorizacion_cbte_Prueba = txtWebAutoriPrueba.Text;
                    InfoM.url_ws_sri_Autorizacion_cbte_Produc = txtWebAutoriProduccion.Text;
                    InfoM.url_ws_firma_efirm = txtWebServiEfirm.Text;
                    InfoM.Usa_Proxy = checkUsaProxy.Checked;
                    InfoM.Url_Proxy = txtUrlProxy.Text;
                    InfoM.Port_Proxy = Convert.ToInt32(txtPuertoProxy.Text);
                    InfoM.Usuario_Proxy = txtUsuarioProxy.Text;
                    InfoM.Password_Proxy = txtPasswordProxy.Text;
                    InfoM.Registra_Log = chkRegistraLog.Checked;
                    //InfoM.Version = Convert.ToInt32(txtVersion.EditValue);
                    InfoM.offline_online=Convert.ToInt32( cmb_tipo_emision.EditValue);
                    BusPar.ModificarDB(InfoM, ref msg);

                    MessageBox.Show("Grabado Ok", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ha ocurrido un error comuniquese con sistemas", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public bool validarObjetos() {
            try
            {
                
                bool resultValida = true;
                if (txtWebServiPrueba.Text == "")
                {
                    errProvider.SetError(txtWebServiPrueba, "Falta Ruta Web Service Prueba");
                    txtWebServiPrueba.Focus();
                    resultValida = false;
                }

                if (txtWebServiProduc.Text == "")
                {
                    errProvider.SetError(txtWebServiProduc, "Falta Ruta Web Service Produccion");
                    txtWebServiProduc.Focus();
                    resultValida = false;
                }

                if (txtWebAutoriPrueba.Text == "")
                {
                    errProvider.SetError(txtWebAutoriPrueba, "Falta Ruta Web Service Autorizacion Prueba");
                    txtWebAutoriPrueba.Focus();
                    resultValida = false;
                }


                if (txtWebAutoriProduccion.Text == "")
                {
                    errProvider.SetError(txtWebAutoriProduccion, "Falta Ruta Web Service Autorizacion Produccion");
                    txtWebAutoriProduccion.Focus();
                    resultValida = false;
                }

                if (txtWebServiEfirm.Text == "")
                {
                    errProvider.SetError(txtWebServiEfirm, "Falta Ruta Web Service Efirm");
                    txtWebServiEfirm.Focus();
                    resultValida = false;
                }

                if (txtVersion.Text == "")
                {
                    errProvider.SetError(txtVersion, "Falta la Versión");
                    txtVersion.Focus();
                    resultValida = false;
                }

                if (cmb_tipo_emision.EditValue ==null)
                {
                    errProvider.SetError(cmb_tipo_emision, "Falta tipo de emision");
                    cmb_tipo_emision.Focus();
                    resultValida = false;
                }
                return resultValida;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }

        }


        private void txtWebServiEfirm_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkUsaProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUsaProxy.Checked)
                habilitaControl(true);
            else
                habilitaControl(false);
        }

        private void habilitaControl(bool opcionBloqueo) {
            try
            {
                txtPuertoProxy.Enabled = opcionBloqueo;
                txtUrlProxy.Enabled = opcionBloqueo;
                txtUsuarioProxy.Enabled = opcionBloqueo;
                txtPasswordProxy.Enabled = opcionBloqueo;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void cargar_combos()
        {
            try
            {
                Dictionary<int, string> impuesto = Enum.GetValues(typeof(eTipo_emision))
                  .Cast<eTipo_emision>().ToDictionary(x => (int)x, x => x.ToString());

                cmb_tipo_emision.Properties.ValueMember = "Key";
                cmb_tipo_emision.Properties.DisplayMember = " Value";
                cmb_tipo_emision.Properties.DataSource = impuesto.ToList();

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
