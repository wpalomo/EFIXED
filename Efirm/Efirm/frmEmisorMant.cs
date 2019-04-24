using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using FirmElect.Info;
using FirmElect.Bus;
using System.Data.OleDb;
using System.Data.SqlClient;



namespace Efirm
{
    public partial class frmEmisorMant : Form
    {
        #region Declaración de variables
        List<tb_Catalogo_Info> listCatalogo;        
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Catalogo_Bus busCatalogo;
        tb_Empresa_Info InfoEmp = new tb_Empresa_Info();
        string MensajeErrorOut = "";
        public eTipo_action Accion;

        public delegate void delegate_frmEmisorMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmEmisorMant_FormClosing Event_frmEmisorMant_FormClosing;
        #endregion

        public frmEmisorMant()
        {
            InitializeComponent();
            Event_frmEmisorMant_FormClosing += frmEmisorMant_Event_frmEmisorMant_FormClosing;
        }

        void frmEmisorMant_Event_frmEmisorMant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmRo_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmEmisorMant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
            }
        }

        public tb_Empresa_Info get_Info()
        {
           
            try
            {
                //InfoEmp.IdEmpresa = Convert.ToInt32(txtIdEmpresa.Text);
                InfoEmp.RazonSocial = txtRazon.Text;
                InfoEmp.NombreComercial = txtNomComercial.Text;
                InfoEmp.RUC = txtRuc.Text;
                InfoEmp.Alias = txtalias.Text;
                InfoEmp.url = txturl.Text;
                InfoEmp.DirMatriz = txt_Direccion.Text;
                InfoEmp.cod_Ambiente = Convert.ToString(cmbgrid_Ambiente.EditValue);
                InfoEmp.cod_TipoEmision = Convert.ToString(cmbgrid_TipoEmision.EditValue);
                InfoEmp.ObligadoAllevarConta =chkllevaCont.Checked==true?"S":"N";
                InfoEmp.ContribuyenteEspecial = txtResContEsp.Text;
                InfoEmp.NombreCertificado = txtcertificado.Text;
                InfoEmp.Clave_Certificado = txtclavecertificado.Text;
                InfoEmp.FechaValidez = dtpFechaValidez.Value;
                InfoEmp.IdToquenAFirmar = Convert.ToString(cmbgrid_Tocken.EditValue);
                InfoEmp.Nemonico_RIDE = txtNemRIDE.Text;
                InfoEmp.Tipo_Notificacion_a_cliente = cmbNotifCliente.Text;
                InfoEmp.Tipo_Base_Exterior = cmbBaseExt.Text;
                InfoEmp.Cod_Empresa_Para_DB_Ext = (string)cmb_empresa_ext.SelectedValue;
                InfoEmp.cadena_conexion_Exterior = txtCadConExt.Text;


                InfoEmp.Formato_fecha_Base_ext = cmb_formato_fecha.SelectedValue.ToString();
                InfoEmp.Formato_hora_Base_ext = cmb_formato_hora.SelectedValue.ToString();
                InfoEmp.Nombre_tabla_Base_ext = txt_nom_tabla.Text;


                if (pic_foto.Image != null)
                {
                    MemoryStream memimagen = new MemoryStream();
                    pic_foto.Image.Save(memimagen, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] byfoto = new byte[memimagen.Length];
                    memimagen.Position = 0;
                    memimagen.Read(byfoto, 0, Convert.ToInt32(memimagen.Length));
                    InfoEmp.logo = byfoto;
                }



                return InfoEmp;

            }
            catch (Exception ex)
            {
                return new tb_Empresa_Info();
            }
           
        }

        public void set_info(tb_Empresa_Info Info)
        {
            try
            {
                InfoEmp = Info;
            }
            catch (Exception ex)
            {


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
               
            }

        }

        private void set_controles()
        {
            try
            {
               // txtIdEmpresa.Text = Convert.ToString(InfoEmp.IdEmpresa);
                txtRazon.Text = InfoEmp.RazonSocial;
                txtNomComercial.Text = InfoEmp.NombreComercial;
                txtRuc.Text = InfoEmp.RUC;
                txtalias.Text = InfoEmp.Alias;
                txturl.Text = InfoEmp.url;
                txt_Direccion.Text = InfoEmp.DirMatriz;
                cmbgrid_Ambiente.EditValue = InfoEmp.cod_Ambiente;
                cmbgrid_TipoEmision.EditValue = InfoEmp.cod_TipoEmision;
                chkllevaCont.Checked = (InfoEmp.ObligadoAllevarConta == "S") ? true : false;
                txtResContEsp.Text = InfoEmp.ContribuyenteEspecial;
                txtcertificado.Text = InfoEmp.NombreCertificado;
                txtclavecertificado.Text = InfoEmp.Clave_Certificado;
                dtpFechaValidez.Value = DateTime.Now;// Convert.ToDateTime(InfoEmp.FechaValidez);
                cmbgrid_Tocken.EditValue = InfoEmp.IdToquenAFirmar;
                txtNemRIDE.Text = InfoEmp.Nemonico_RIDE;
                cmbNotifCliente.Text = InfoEmp.Tipo_Notificacion_a_cliente;
                cmbBaseExt.Text = InfoEmp.Tipo_Base_Exterior;
                //txtCodEmpBDExt.Text = InfoEmp.Cod_Empresa_Para_DB_Ext;
                txtCadConExt.Text = InfoEmp.cadena_conexion_Exterior;
                MemoryStream ms = new MemoryStream(InfoEmp.logo);
                pic_foto.Image = System.Drawing.Bitmap.FromStream(ms);

                txt_nom_tabla.Text = InfoEmp.Nombre_tabla_Base_ext;
                cmb_formato_fecha.SelectedValue = InfoEmp.Formato_fecha_Base_ext;
                cmb_formato_hora.SelectedValue = InfoEmp.Formato_hora_Base_ext;
                cmb_empresa_ext.SelectedValue = InfoEmp.Cod_Empresa_Para_DB_Ext;


            }
            catch (Exception ex)
            {
                
            }
           
           
        }

        void carga_Combos()
        {
            try
            {
                busCatalogo = new tb_Catalogo_Bus();

                listCatalogo = new List<tb_Catalogo_Info>();
                listCatalogo = busCatalogo.Consulta_Catalogo_x_IdTipoCatalogo(4);

                cmbgrid_Ambiente.Properties.DataSource = listCatalogo;
                cmbgrid_Ambiente.Properties.DisplayMember = "Descripcion";
                cmbgrid_Ambiente.Properties.ValueMember = "IdCatalogo";

                listCatalogo = new List<tb_Catalogo_Info>();
                listCatalogo = busCatalogo.Consulta_Catalogo_x_IdTipoCatalogo(3);

                cmbgrid_TipoEmision.Properties.DataSource = listCatalogo;
                cmbgrid_TipoEmision.Properties.DisplayMember = "Descripcion";
                cmbgrid_TipoEmision.Properties.ValueMember = "IdCatalogo";

                listCatalogo = new List<tb_Catalogo_Info>();
                listCatalogo = busCatalogo.Consulta_Catalogo_x_IdTipoCatalogo(5);

                cmbgrid_Tocken.Properties.DataSource = listCatalogo;
                cmbgrid_Tocken.Properties.DisplayMember = "Descripcion";
                cmbgrid_Tocken.Properties.ValueMember = "IdCatalogo";


                listCatalogo = new List<tb_Catalogo_Info>();
                listCatalogo = busCatalogo.Consulta_Catalogo_x_IdTipoCatalogo(6);

                cmb_formato_fecha.DataSource = listCatalogo;
                cmb_formato_fecha.DisplayMember = "Descripcion";
                cmb_formato_fecha.ValueMember = "IdCatalogo";


                listCatalogo = new List<tb_Catalogo_Info>();
                listCatalogo = busCatalogo.Consulta_Catalogo_x_IdTipoCatalogo(7);

                cmb_formato_hora.DataSource = listCatalogo;
                cmb_formato_hora.DisplayMember = "Descripcion";
                cmb_formato_hora.ValueMember = "IdCatalogo";

                tb_Empresa_externa_Bus BusEmpresa_Exter = new tb_Empresa_externa_Bus();
                List<tb_Empresa_externa_Info> listEmpre_ext = new List<tb_Empresa_externa_Info>();

                string msg="";
                listEmpre_ext = BusEmpresa_Exter.consultar(ref msg);

                cmb_empresa_ext.DataSource = listEmpre_ext;
                cmb_empresa_ext.DisplayMember = "nom_empresa_ext";
                cmb_empresa_ext.ValueMember = "Cod_Empresa_exte";


            }
            catch (Exception ex)
            {
            }
        }

        private void frmEmisorMant_Load(object sender, EventArgs e)
        {
            try
            {
                
                switch (Accion)
                {
                    case eTipo_action.grabar:
                        carga_Combos();
                        
                        break;

                    case eTipo_action.actualizar:
                        carga_Combos();
                        set_controles();

                        break;

                  
                    case eTipo_action.consultar:
                       
                        carga_Combos();
                        set_controles();
                        btngrabar.Visible = false;
                        
                        break;

                    default:
                        break;
                }

                
            }
            catch (Exception ex)
            {
                
            }
           
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            if (ValidarObjetos() == false)
            {
                try
                {
                    string msg = "";
                    get_Info();
                    switch (Accion)
                    {
                        case eTipo_action.grabar:
                            if (Grabar(ref msg))
                            {
                                MessageBox.Show("Se Grabo correctamente. Se creo variables de Entorno se procedera areiniciar el sistema..", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Restart();
                            }
                            else
                            {
                                MessageBox.Show("No se grabo:" + msg, "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    
                            break;

                        case eTipo_action.actualizar:
                            if (Modificar(ref msg))
                            {
                                MessageBox.Show("Se Modifico correctamente parametros de Ambiente se procedera a reiniciar el sistema..", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Restart();

                            }
                            else
                            {
                                MessageBox.Show("No se Modifico:" + msg, "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    

                            break;


                        case eTipo_action.consultar:

                            carga_Combos();
                            set_controles();
                            btngrabar.Visible = false;

                            break;

                        default:
                            break;
                    }

                    
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                return;
            }
        }
        
       public Boolean Grabar(ref string msg)
        {
            try
            {
                tb_Empresa_Info InfoT = new tb_Empresa_Info();
                InfoT = get_Info();

                return busEmpresa.GuardarDB(InfoT, ref msg);
               

            }
            catch (Exception ex)
            {
                return false;

            }
        }
    
       public Boolean Modificar(ref string msg)
       {
            try
            {
                tb_Empresa_Info InfoT = new tb_Empresa_Info();
                InfoT = get_Info();

                return busEmpresa.ModificarDB(InfoT, ref msg);
               

            }
            catch (Exception ex)
            {
                return false;

            }
        }
       
        public bool ValidarObjetos()
        {
            bool bandera = false;


            if (txtRuc.Text == "")
            {
                errProvider.SetError(txtRuc, "Ingrese Ruc ");
                txtRuc.Focus();
                bandera = true;
            }
            if (txtRazon.Text == "")
            {
                errProvider.SetError(txtRazon, "Ingrese Razon Social");
                txtRazon.Focus();
                bandera = true;
            }

            if (txtNomComercial.Text == "")
            {
                errProvider.SetError(txtNomComercial, "Ingrese el Nombre Comercial");
                bandera = true;
                txtNomComercial.Focus();
            }

            if (cmbgrid_Ambiente.EditValue == "")
            {
                errProvider.SetError(cmbgrid_Ambiente, "Escoga un tipo de Ambiente");
                cmbgrid_Ambiente.Focus();
                bandera = true;
            }

            if (cmbgrid_TipoEmision.EditValue == "")
            {
                errProvider.SetError(cmbgrid_TipoEmision, "Escoga un tipo de Emisión");
                cmbgrid_TipoEmision.Focus();
                bandera = true;
            }

            return bandera;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
               
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imagen = new OpenFileDialog();
                imagen.Filter = "Archivos de Imagen|*.jpg";
                imagen.FileName = "SELECCIONE UNA IMAGEN";
                imagen.InitialDirectory = "C:\\";
                if (imagen.ShowDialog() == DialogResult.OK)
                {
                    string direc = imagen.FileName;
                    pic_foto.ImageLocation = direc;
                }
            }
            catch (Exception) { }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_crear_ocon_Click(object sender, EventArgs e)
        {
            
                MSDASC.DataLinks dataLinks = new MSDASC.DataLinks();

			ADODB._Connection connection;					

				try	
				{		

					connection = (ADODB._Connection)dataLinks.PromptNew();

					this.txtCadConExt.Text=connection.ConnectionString.ToString();
				}
				catch(Exception ex)	
				{
					MessageBox.Show(ex.ToString());	
				}
			
		}

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void txt_nom_tabla_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_test_select.Text = "select * from " + txt_nom_tabla.Text;
                txt_test_insert.Text = "Insert into " + txt_nom_tabla.Text + "\n";
//                txt_test_insert.Text = "(campo1,campo2,campo3,campo4,campo5)" + "\n";
                txt_test_insert.Text =txt_test_insert.Text +  " values()";
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void txt_test_select_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_prueba_selec_Click(object sender, EventArgs e)
        {
            try
            {

            

            // The connection string assumes that the Access  
            // Northwind.mdb is located in the c:\Data folder. 
            string connectionString = txtCadConExt.Text;
            


            // Provide the query string with a parameter placeholder. 
            string queryString = txt_test_select.Text;

            // ensures that all resources will be closed and disposed 
            // when the code exits. 
            using (OleDbConnection connection =
                new OleDbConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                OleDbCommand command = new OleDbCommand(queryString, connection);
            
                // Open the connection in a try/catch block.  
                // Create and execute the DataReader, writing the result 
                // set to the console window. 
                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine("\t{0}\t{1}\t{2}",
                        //    reader[0], reader[1], reader[2]);
                    }

                    
                    reader.Close();
                    MessageBox.Show("conexion ok..");

                }
                catch (Exception ex)
                {
                  //  Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
                }
                //Console.ReadLine();
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void btn_prueba_insert_Click(object sender, EventArgs e)
        {
            try
            {



                // The connection string assumes that the Access  
                // Northwind.mdb is located in the c:\Data folder. 
                string connectionString = txtCadConExt.Text;



                // Provide the query string with a parameter placeholder. 
                string queryString = txt_test_insert.Text;

                // ensures that all resources will be closed and disposed 
                // when the code exits. 
                using (OleDbConnection connection =
                    new OleDbConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    OleDbCommand command = new OleDbCommand(queryString, connection);

                    // Open the connection in a try/catch block.  
                    // Create and execute the DataReader, writing the result 
                    // set to the console window. 
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("insert  ok..");

                    }
                    catch (Exception ex)
                    {
                        //  Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                    //Console.ReadLine();
                }

            }
            catch (Exception ex)
            {


            }
        }
            
       
    }
}
