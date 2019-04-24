using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailEfirm.Forms;
using System.IO;
using FirmElect.Info;
using FirmElect.Bus;


namespace MailEfirm.Controls
{
    public partial class UC_Contacto_mant : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
        #region Declaración de Variables
        tb_Contribuyente_Info Info_contribuyente = new tb_Contribuyente_Info();
        tb_Contribuyente_Bus Bus_Contri = new tb_Contribuyente_Bus();
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        Cl_ValidarEmail validarMail = new Cl_ValidarEmail();
        #endregion
        
        public tb_Contribuyente_Info get_Info()
        {
            try
            {
                Info_contribuyente.IdContribuyente = Convert.ToInt32(lbIdcontribuyente.Text);
                Info_contribuyente.IdEmpresa = Convert.ToInt32(cmb_empresa.EditValue);
                Info_contribuyente.cedulaRuc_contri = txtcedulaRuc.Text;
                Info_contribuyente.Nom_Contribuyente = Nombrecontribuyente.Text;
                Info_contribuyente.Observacion = txtobservaciones.Text;
                Info_contribuyente.EsProveedor = chkesproveedor.Checked;
                Info_contribuyente.EsCliente = chkesclinte.Checked;
                Info_contribuyente.Telefono = txttelefono.Text;
                Info_contribuyente.Password = txtContraseña.Text;
                Info_contribuyente.Estado = chkEstado.Checked;
                Info_contribuyente.Direccion = txtdireccion.Text;
                Info_contribuyente.Mail_secundario = txtMailSecuandario.Text;
                Info_contribuyente.Mail = txtmail.Text;
                Info_contribuyente.TipoContacto = (eTipo_Contacto)Enum.Parse(typeof(eTipo_Contacto), cmbtipoCintribuyente.Text);

                

                //validar mail
                if ((validarMail.ValidarCorreoElectronico(txtmail.Text) == true) || txtmail.Text=="")
                {
                    Info_contribuyente.Mail = txtmail.Text;
                }
                else
                {
                    MessageBox.Show("Correo no Escrito corectamente", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if ((validarMail.ValidarCorreoElectronico(txtMailSecuandario.Text) == true) || txtMailSecuandario.Text=="")
                {
                    Info_contribuyente.Mail_secundario = txtMailSecuandario.Text;
                }
                else
                {
                    MessageBox.Show("Correo no Escrito corectamente", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                Info_contribuyente.Direccion = txtdireccion.Text;
                
                Info_contribuyente.Password = txtContraseña.Text;
                Info_contribuyente.EsCliente = chkesclinte.Checked ;
                Info_contribuyente.EsProveedor = chkesproveedor.Checked ;
                


                if (chkEstado.Checked == true)
                {
                    Info_contribuyente.Estado = true;
                }
                else
                {
                    Info_contribuyente.Estado = false;
                }

                //Info_contribuyente.Fecha_transaccion = Convert.ToDateTime(dtpFechaRegistro.Text);
                //Info_contribuyente.Fecha_Registro_web = dtpFechaRegistroWeb.Value;
                Info_contribuyente.Fecha_Actualizacion_datos = DateTime.Now;
                Info_contribuyente.Telefono = txttelefono.Text;


                // conversion imagen a binario
                if (ptbImagen.Image != null)
                {
                    MemoryStream memimagen = new MemoryStream();
                    ptbImagen.Image.Save(memimagen, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] byfoto = new byte[memimagen.Length];
                    memimagen.Position = 0;
                    memimagen.Read(byfoto, 0, Convert.ToInt32(memimagen.Length));
                    Info_contribuyente.Foto = byfoto;
                }
                return Info_contribuyente;
            }
            catch (Exception ex)
            {
                return new tb_Contribuyente_Info();
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString()); 
            }
        }

        public void set_info(tb_Contribuyente_Info Info)
        {
            try 
            {
                Info_contribuyente = Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
		
            }
        
        }

        private void set_controles()
        {
            try
            {
               // lbempresa.Text =Convert.ToString( Info_contribuyente.IdContribuyente);
                txtmail.Text = Info_contribuyente.Mail;
                txtMailSecuandario.Text = Info_contribuyente.Mail_secundario;
                txtcedulaRuc.Text = Info_contribuyente.cedulaRuc_contri;
                lbIdcontribuyente.Text = Info_contribuyente.IdContribuyente.ToString();
                Nombrecontribuyente.Text = Info_contribuyente.Nom_Contribuyente;
                txttelefono.Text = Info_contribuyente.Telefono;
                txtContraseña.Text = Info_contribuyente.Password;
                cmbtipoCintribuyente.Text = Info_contribuyente.TipoContacto.ToString();
                txtdireccion.Text = Info_contribuyente.Direccion;
                dtpFechaRegistro.Text = Info_contribuyente.Fecha_Registro_web.ToString();
                dtpFechaRegistroWeb.Text = Info_contribuyente.Fecha_Actualizacion_datos.ToString();
                cmb_empresa.Text = Info_contribuyente.RazonSocial;
                cmbtipoCintribuyente.Text = Info_contribuyente.TipoContacto.ToString();
                cmb_empresa.EditValue = Info_contribuyente.IdEmpresa;
                txtobservaciones.Text = Info_contribuyente.Observacion;
                chkesproveedor.Checked = Info_contribuyente.EsProveedor;
                chkesclinte.Checked = Info_contribuyente.EsCliente;
                txttelefono.Text = Info_contribuyente.Telefono;
                txtcedulaRuc.Text = Info_contribuyente.Password;
                chkEstado.Checked = Info_contribuyente.Estado;
                txtdireccion.Text = Info_contribuyente.Direccion;
                txtMailSecuandario.Text = Info_contribuyente.Mail_secundario;
                txtmail.Text = Info_contribuyente.Mail;
                txtcedulaRuc.Text = Info_contribuyente.cedulaRuc_contri;
               // Info_contribuyente.TipoContacto = (eTipo_Contacto)Enum.Parse(typeof(eTipo_Contacto), cmbtipoCintribuyente.Text);
                cmbtipoCintribuyente.Text = Info_contribuyente.TipoContacto.ToString();

                MemoryStream ms = new MemoryStream(Info_contribuyente.Foto);
                ptbImagen.Image = System.Drawing.Bitmap.FromStream(ms);
                if (Info_contribuyente.EsCliente == true)
                {
                    chkesclinte.Checked = true;
                }
                else
                {
                    chkesclinte.Checked = false;
                }
                if(Info_contribuyente.EsProveedor==true)
                {
                    chkesproveedor.Checked = true;
                }
                else
                {
                    chkesproveedor.Checked = false;
                }
                if (Info_contribuyente.Estado == true)
                {
                    chkEstado.Checked = true;
                }
                else
                {
                    chkEstado.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        public Boolean Modificar(ref string  msg)
        {
            try
            {
                tb_Contribuyente_Info InfoT = new tb_Contribuyente_Info();
                InfoT = get_Info();
                List<mail_Mensaje_Info> listMensaje = new List<mail_Mensaje_Info>();

                mail_Mensaje_Bus BusMensaje = new mail_Mensaje_Bus();
                listMensaje=BusMensaje.consultar_mail_sin_correo_destino_x_contribuyente(InfoT.IdContribuyente, ref msg);

                if (listMensaje.Count > 0)
                {
                    if (MessageBox.Show("Existen correos sin mail destinario en el buzon de salida para este Contacto .. Desea actualizar estos mail.", "Efirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (var item in listMensaje)
                            {
                                item.Para = InfoT.Mail;
                                BusMensaje.Actualizar_correo_destino(item, ref msg);
                            }
                          
                    }
                }



                return Bus_Contri.ModificarDB(InfoT, ref msg);

            }
            catch (Exception ex)
            {
                return false;
                
            }
        }

        private void cargar_combos()
        {
            try
            {
                string msg = "";


                List<tb_Empresa_Info> listaEmpresa = new List<tb_Empresa_Info>();
                listaEmpresa = busEmpresa.GetEmpresas(ref msg);
                cmb_empresa.Properties.DataSource = listaEmpresa;

                List<eTipo_Contacto> listConta= new List<eTipo_Contacto>();
                
                
                
                
                foreach(eTipo_Contacto TipoContacto in Enum.GetValues(typeof(eTipo_Contacto)).Cast<eTipo_Contacto>())
                {
                    listConta.Add(TipoContacto);
                
                }

                cmbtipoCintribuyente.DataSource = listConta;






                		        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
		
            }
        }

        public UC_Contacto_mant()
        {
            InitializeComponent();
            
        }

        private void UC_Registro_Contacto_Load(object sender, EventArgs e)
        {
            cargar_combos();
            set_controles();
          

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imagen = new OpenFileDialog();
                imagen.Filter = "Archivos de Imagen|*.JPG";
                imagen.FileName = "SELECCIONE UNA IMAGEN";
                imagen.InitialDirectory = "C:\\";
                if (imagen.ShowDialog() == DialogResult.OK)
                {
                    string direc = imagen.FileName;
                    ptbImagen.ImageLocation = direc;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }

        private void ptbImagen_Click(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            if (ValidarObjetos() == false)
            {
                try
                {
                    string msg = "";

                    if (Modificar(ref msg))
                    {
                        MessageBox.Show("Se Actualizaron los datos", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se grabo:" + msg, "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panelDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool ValidarObjetos()
        {
            bool bandera = false;
            //if (txtmail.Text == "")
            //{
            //    errProvider.SetError(txtmail, "Ingrese Mail");
            //    txtmail.Focus();
            //    bandera = true;
            //}
             if (lbempresa.Text == "")
            {
                errProvider.SetError(cmb_empresa, "Escoga un Emisor");
                bandera = true;
            }
             if (txtcedulaRuc.Text == "")
            {
                errProvider.SetError(txtcedulaRuc,"Ingrese Ruc Cedula");
                txtcedulaRuc.Focus();
                bandera = true;
            }
             if (Nombrecontribuyente.Text == "")
            {
                errProvider.SetError(Nombrecontribuyente,"Ingrese Nombre");
                Nombrecontribuyente.Focus();
                bandera = true;
            }
            // if (txtContraseña.Text == "")
            //{
            //    errProvider.SetError(txtContraseña, "Ingrese Contraseña");
            //    vandera = true;
            //    txtContraseña.Focus();
            //}
             if (cmbtipoCintribuyente.Text == "")
            {
                errProvider.SetError(cmbtipoCintribuyente, "Escoga un tipo");
                cmbtipoCintribuyente.Focus();
                bandera = true;
            }

             //if (txttelefono.Text == "(   )   -")
             //{
             //    errProvider.SetError(txttelefono,"Ingrese Telefono");
             //    txttelefono.Focus();
             //    vandera = true;

             //}
            return bandera;
        }

        private void cmb_empresa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
