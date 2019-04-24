using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Info;
using FirmElect.Bus;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.IO;
using MailEfirm.Forms;




namespace MailEfirm.Controls
{
    public partial class UC_Cuenta_Mant : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        #region Declaración de Variables
        public eAcciones eAccion { get; set; }
        mail_Cuentas_Correo_Info Info_Mail_Cta = new mail_Cuentas_Correo_Info();
        mail_Validar_Correo_Info Info_Validar_correo = new mail_Validar_Correo_Info();
        mail_Mensaje_Info Info_mensaje = new mail_Mensaje_Info();
        mail_Mensaje_Bus Bus_Mensaje = new mail_Mensaje_Bus();
        mail_Cuentas_Correo_Bus BusMail = new mail_Cuentas_Correo_Bus();
        mail_Catalogo_Bus BusMailCatalogo = new mail_Catalogo_Bus();

        public eTipo_action Accion;
        #endregion


        public UC_Cuenta_Mant()
        {
            InitializeComponent();
        }
       
        private void groupBoxInfoUsuario_Enter(object sender, EventArgs e)
        {

        }

        public mail_Cuentas_Correo_Info get_Info()
        {
            try
            {
                Info_Mail_Cta.IdCuenta = txtidCuenta.Text;
                Info_Mail_Cta.Nombre_cuenta = txtSuNombre.Text;
                Info_Mail_Cta.direccion_correo = txtdirecioncorreoElectronico.Text;
                Info_Mail_Cta.Usuario = TxtNombreUsuario.Text;
                Info_Mail_Cta.Password = TxtContraseña.Text;

                Info_Mail_Cta.TipoCuenta =(string) cmbtipoCuenta.SelectedValue;
                Info_Mail_Cta.Tipo_Authenticacion = (string)cmbTipoAutenticacion.SelectedValue;

                Info_Mail_Cta.ServidorCorreoEntrante = TxtServidorEntrante.Text;
                Info_Mail_Cta.ServidorCorreoSaliente = TxtServidorSaliente.Text;
                Info_Mail_Cta.port_entrada =Convert.ToInt32( TxtPuertoEntada.Value);
                Info_Mail_Cta.Port_salida =Convert.ToInt32( txtpuertoSalida.Value);


                //para smtp
                Info_Mail_Cta.precisa_conexion_cifrada = (Info_Mail_Cta.tipo_Seguridad=="SSL" ||  Info_Mail_Cta.tipo_Seguridad=="TLS") ? true:false;
                
                
                Info_Mail_Cta.tipo_Seguridad =(string) cmbtiposeguridad.SelectedValue;


                Info_Mail_Cta.cta_predeterminada = chk_Cuenta_predeterminada.Checked;
                Info_Mail_Cta.enviar_copia_x_cada_mail_enviado = chk_enviar_copia_x_cada_mail_enviado.Checked;
                Info_Mail_Cta.enviar_mail_x_cada_cbte_no_auto = chk_envioMail_Cbte_NoAuto.Checked;
                Info_Mail_Cta.cta_mail_para_envio_x_cbte_enviado = txtenviomail_ctaRespaldo.Text;
                Info_Mail_Cta.cta_mail_para_envio_x_cbte_no_auto = txtEnviaMail_CbteNoAuto.Text;
                Info_Mail_Cta.Usar_Credenciales_x_default_SMTP = chk_UseDefaultCredentials.Checked;
                Info_Mail_Cta.Usa_SSL_Conexion_para_Descarga_correo = chkConexCifra.Checked;
                Info_Mail_Cta.Guardar_1_copia_de_corre_en_server_mail = chkCopiaCorreo.Checked;
                Info_Mail_Cta.Borra_server_mail_cada_dias = Convert.ToInt32(txtDiasServer.Value);
                Info_Mail_Cta.Usuario_smtp = txtUsuario_smtp.Text;
                Info_Mail_Cta.Password_smtp = txtPassword_smtp.Text;
                Info_Mail_Cta.Confirmacion_de_Entrega = chkConfirmacion_de_entrega.Checked;
                Info_Mail_Cta.Confirmacion_de_Lectura = chkConfirmacion_de_lectura.Checked;


                return Info_Mail_Cta;

            }
            catch (Exception ex)
            {
                return new mail_Cuentas_Correo_Info();
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        public void set_controles()
        {
            try
            {
                TxtPuertoEntada.Maximum = 80000;
                txtpuertoSalida.Maximum = 80000;

                cmbtiposeguridad.SelectedValue = (Info_Mail_Cta.tipo_Seguridad == null || Info_Mail_Cta.tipo_Seguridad == "") ? "Ninguno" : Info_Mail_Cta.tipo_Seguridad;
                cmbTipoAutenticacion.SelectedValue = (Info_Mail_Cta.Tipo_Authenticacion == null || Info_Mail_Cta.Tipo_Authenticacion == "") ? "USER_LOGIN" : Info_Mail_Cta.Tipo_Authenticacion;
                cmbtipoCuenta.SelectedValue = (Info_Mail_Cta.TipoCuenta == null || Info_Mail_Cta.TipoCuenta == "") ? "POP3" : Info_Mail_Cta.TipoCuenta;  

                chk_Cuenta_predeterminada.Checked = Info_Mail_Cta.cta_predeterminada;

                txtidCuenta.Text = Info_Mail_Cta.IdCuenta;
                txtSuNombre.Text = Info_Mail_Cta.Nombre_cuenta;
                txtdirecioncorreoElectronico.Text = Info_Mail_Cta.direccion_correo;
                TxtContraseña.Text = Info_Mail_Cta.Password;
                cmbtipoCuenta.Text = Info_Mail_Cta.TipoCuenta;
                TxtServidorEntrante.Text = Info_Mail_Cta.ServidorCorreoEntrante;
                TxtServidorSaliente.Text = Info_Mail_Cta.ServidorCorreoSaliente;
                TxtNombreUsuario.Text = Info_Mail_Cta.Usuario;
                TxtPuertoEntada.Value =Convert.ToDecimal( Info_Mail_Cta.port_entrada);
                txtpuertoSalida.Value = Convert.ToDecimal(Info_Mail_Cta.Port_salida);
                chk_enviar_copia_x_cada_mail_enviado.Checked = (Info_Mail_Cta.enviar_copia_x_cada_mail_enviado == null) ? false : Convert.ToBoolean(Info_Mail_Cta.enviar_copia_x_cada_mail_enviado);
                chk_envioMail_Cbte_NoAuto.Checked = (Info_Mail_Cta.enviar_mail_x_cada_cbte_no_auto == null) ? false : Convert.ToBoolean(Info_Mail_Cta.enviar_mail_x_cada_cbte_no_auto);
                txtEnviaMail_CbteNoAuto.Text = Info_Mail_Cta.cta_mail_para_envio_x_cbte_no_auto;
                txtenviomail_ctaRespaldo.Text = Info_Mail_Cta.cta_mail_para_envio_x_cbte_enviado;
                chk_UseDefaultCredentials.Checked = (Info_Mail_Cta.Usar_Credenciales_x_default_SMTP == null) ? false : Convert.ToBoolean(Info_Mail_Cta.Usar_Credenciales_x_default_SMTP);
                chkConexCifra.Checked = (Info_Mail_Cta.Usa_SSL_Conexion_para_Descarga_correo == null) ? false : Convert.ToBoolean(Info_Mail_Cta.Usa_SSL_Conexion_para_Descarga_correo);
                chkCopiaCorreo.Checked = (Info_Mail_Cta.Guardar_1_copia_de_corre_en_server_mail == null) ? false : Convert.ToBoolean(Info_Mail_Cta.Guardar_1_copia_de_corre_en_server_mail);
                txtDiasServer.Value = Convert.ToInt32(Info_Mail_Cta.Borra_server_mail_cada_dias);

                chkConfirmacion_de_lectura.Checked = (Info_Mail_Cta.Confirmacion_de_Lectura == null) ? false :Convert.ToBoolean( Info_Mail_Cta.Confirmacion_de_Lectura);
                chkConfirmacion_de_entrega.Checked = (Info_Mail_Cta.Confirmacion_de_Entrega == null) ? false : Convert.ToBoolean(Info_Mail_Cta.Confirmacion_de_Entrega);
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        public void set_info_Modificar(mail_Cuentas_Correo_Info Info)
        {
            try
            {
                Info_Mail_Cta = Info;
            }
            catch (Exception ex)
            {

            }

        }

        public void llenarCombos()
        {
            try
            {
                string msg = "";
                string estadoCatalogo = "A";
                string tipoCatalogo = "TIP_PROT";
                List<mail_Catalogo_Info> lstMailCatalogo = new List<mail_Catalogo_Info>();
                lstMailCatalogo = BusMailCatalogo.consultarCatalogo(estadoCatalogo, tipoCatalogo , ref msg);
                cmbtipoCuenta.DataSource = lstMailCatalogo;
                cmbtipoCuenta.DisplayMember = "IdCatalogo";
                cmbtipoCuenta.ValueMember = "nom_catalogo";

                
                tipoCatalogo = "TIP_AUTH";
                List<mail_Catalogo_Info> lstMailCatalogo_Auth = new List<mail_Catalogo_Info>();
                lstMailCatalogo_Auth = BusMailCatalogo.consultarCatalogo(estadoCatalogo, tipoCatalogo, ref msg);
                cmbTipoAutenticacion.DataSource = lstMailCatalogo_Auth;
                cmbTipoAutenticacion.ValueMember = "IdCatalogo";
                cmbTipoAutenticacion.DisplayMember = "nom_catalogo";


                tipoCatalogo = "TIP_SEG";
                List<mail_Catalogo_Info> lstMailCatalogo_Seg = new List<mail_Catalogo_Info>();
                lstMailCatalogo_Seg = BusMailCatalogo.consultarCatalogo(estadoCatalogo, tipoCatalogo, ref msg);
                cmbtiposeguridad.DataSource = lstMailCatalogo_Seg;
                cmbtiposeguridad.ValueMember = "IdCatalogo";
                cmbtiposeguridad.DisplayMember = "nom_catalogo";

                


            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public void set_info_Nuevo(mail_Cuentas_Correo_Info Info)
        {
            try
            {
                Info_Mail_Cta = Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {



                if (Info_Validar_correo.email_bien_escrito(txtdirecioncorreoElectronico.Text) == false)
                {
                    MessageBox.Show("Error mail no valido");
                    return;

                }



            string mensaje="";
            if (BusMail.Consulta_Si_CuentaExiste(txtidCuenta.Text,ref  mensaje) == true)
            {
                if (Modificar(ref mensaje))
                {
                    MessageBox.Show("Datos Actualizados Ok");

                }
               
            }
            else
            {

                if (ValidarObjetos() == false)
                {
                    try
                    {
                        string msg = "";

                        if (Guadrdar(ref msg))
                        {
                            MessageBox.Show("Se Actualizaron los datos", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("no se grabo:" + msg, "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

                    }
                }
                else
                {
                    return;
                }
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

        }
        
        private void UC_Cuenta_Mant_Load(object sender, EventArgs e)
        {
            llenarCombos();
            switch (Accion)
            {
                case eTipo_action.grabar:
                    set_controles();
                    break;

                case eTipo_action.actualizar:
                    set_controles();

                    break;

                case eTipo_action.consultar:
                    set_controles();
                    BtnGuardar.Visible = false;
                    break;

                default:
                    break;
            }



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


        private void groupBoxServidor_Enter(object sender, EventArgs e)
        {

        }

        public Boolean Modificar(ref string msg)
        {
            try
            {
                mail_Cuentas_Correo_Info InfoT = new mail_Cuentas_Correo_Info();
                InfoT = get_Info();

                return BusMail.ModificarCuentaBD(InfoT, ref msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                return false;

            }
        }

        public Boolean Guadrdar(ref string msg)
        {
            try
            {
                mail_Cuentas_Correo_Info InfoT = new mail_Cuentas_Correo_Info();
                InfoT = get_Info();

                return BusMail.GuardarCuentaBD(InfoT, ref msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                return false;

            }
        }

        public bool ValidarObjetos()
        {
            try
            {

            

            bool Bsi_datosNull = false;
            if (txtidCuenta.Text == "")
            {
                ErrProvider.SetError(txtidCuenta, "Falta Cuenta");
                txtidCuenta.Focus();
                Bsi_datosNull = true;
            }

            if (txtdirecioncorreoElectronico.Text == "")
            {
                ErrProvider.SetError(txtdirecioncorreoElectronico, "Ingrese Correo");
                txtdirecioncorreoElectronico.Focus();
                Bsi_datosNull = true;
            }

            if (TxtNombreUsuario.Text == "")
            {
                ErrProvider.SetError(TxtNombreUsuario, "Ingrese Su Usuario");
                TxtNombreUsuario.Focus();
                Bsi_datosNull = true;
            }


            if (TxtContraseña.Text == "")
            {
                ErrProvider.SetError(TxtContraseña, "Ingrese Pasword");
                TxtContraseña.Focus();
                Bsi_datosNull = true;
            }

            if (txtSuNombre.Text == "")
            {
                ErrProvider.SetError(txtSuNombre, "Ingrese Su Nombre");
                txtSuNombre.Focus();
                Bsi_datosNull = true;
            }
            if (TxtServidorEntrante.Text == "")
            {
                ErrProvider.SetError(TxtServidorEntrante, "Ingrese nombre Servidor Correo");
                TxtServidorEntrante.Focus();
                Bsi_datosNull = true;
            }

            if (TxtServidorSaliente.Text == "")
            {
                ErrProvider.SetError(TxtServidorSaliente, "Ingrese nombre Servidor de Correo");//cmbtipoCuenta
                TxtServidorSaliente.Focus();
                Bsi_datosNull = true;
            }
            if (cmbtipoCuenta.Text == "")
            {
                ErrProvider.SetError(cmbtipoCuenta, "Escoga un tipo de Cuenta");//
                cmbtipoCuenta.Focus();
                Bsi_datosNull = true;
            }
            if (cmbtiposeguridad.Text == "")
            {
                ErrProvider.SetError(cmbtiposeguridad, "Escoga un tipo del Servidor");//
                cmbtiposeguridad.Focus();
                Bsi_datosNull = true;
            }
            return Bsi_datosNull;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                return false;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCuentaPredeterminada_Click(object sender, EventArgs e)
        {
            try
            {
                txtpuertoSalida.Value = 25;
                TxtPuertoEntada.Value = 110;
                cmbtipoCuenta.Text = "POP3";
                cmbtiposeguridad.Text = "Ninguno";
                chk_UseDefaultCredentials.Checked = false;
                chkConexCifra.Checked = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
               
            }
        }

        private void cmbtiposeguridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbtiposeguridad.Text == "Ninguno")
                {
                    txtpuertoSalida.Value = 25;
                    //TxtPuertoEntada.Value = 110;
                }
                else if (cmbtiposeguridad.Text == "SSL")
                {
                    txtpuertoSalida.Value = 587;
                    //TxtPuertoEntada.Value = 995;

                }
                else if (cmbtiposeguridad.Text == "TLS")
                {
                    txtpuertoSalida.Value = 587;
                    //TxtPuertoEntada.Value = 995;
                }
                //else if (cmbtiposeguridad.Text == "Autom.")
                //{
                //    txtpuertoSalida.Value = 25;
                //    TxtPuertoEntada.Value = 110;

                //}

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }

        }

        private void chkconexionCifrada_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTesCuenta_Click(object sender, EventArgs e)
        {
            try
            {

                mail_Cuentas_Correo_Info InfoT = new mail_Cuentas_Correo_Info();
                InfoT = get_Info();

                Frm_Test_Config_Mail_Envio_Recep frm = new Frm_Test_Config_Mail_Envio_Recep(InfoT);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }   
        
        }

        private void txtdirecioncorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkConexCifra_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                TxtPuertoEntada.Value = (chkConexCifra.Checked == true) ? 995 : 110;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void toolStripMenu_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    
    }
}
