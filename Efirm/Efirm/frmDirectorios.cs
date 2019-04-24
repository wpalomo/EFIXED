using FirmElect.Bus;
using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Efirm
{
    public partial class frmDirectorios : Form
    {
        static cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;

        

        List<tb_Empresa_Info> Empresas = new List<tb_Empresa_Info>();
        tb_directorio_Bus BusDirectorios = new tb_directorio_Bus();
        List<tb_directorio_Info> listDirectorios = new List<tb_directorio_Info>();


        string mensajeErrorOut = "";

        public frmDirectorios()
        {
            InitializeComponent();
            
        }

        
        public void GuardarDirectorios()
        {
            try
            {

                if (txtCertificados.Text == "" || txtComprobantesRepositorio.Text == "" || txtComprobantesValidos.Text == "" || txtPathRoot.Text == "")
                {
                    MessageBox.Show("Todos las rutas deben de estar llenas..." ,"Efirm",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }



                tb_directorio_Bus BusDire = new tb_directorio_Bus();


                if (!System.IO.Directory.Exists(txtPathRoot.Text))
                {
                    System.IO.Directory.CreateDirectory(txtPathRoot.Text);
                 
                }

                if (!System.IO.Directory.Exists(txtComprobantesRepositorio.Text))
                {
                    System.IO.Directory.CreateDirectory(txtComprobantesRepositorio.Text);

                    
                }

                if (!System.IO.Directory.Exists(txtComprobantesValidos.Text))
                {
                    System.IO.Directory.CreateDirectory(param.RutaComprobantesValidos);
                
                }

                if (!System.IO.Directory.Exists(txtCertificados.Text))
                {
                    System.IO.Directory.CreateDirectory(txtCertificados.Text);
                
                }

                if (!System.IO.Directory.Exists(txtComprobantes_con_errores.Text))
                {
                    System.IO.Directory.CreateDirectory(txtComprobantes_con_errores.Text);
                
                }

                


                string msg="";


               


                tb_directorio_Info DirInfo= new tb_directorio_Info();
                DirInfo.IdTipoDirectorio = eTipoDirectorio.ROOT.ToString();
                DirInfo.Ruta_directorio = param.RutaPrincipal;
                BusDire.ModificarDB(DirInfo, ref msg);


                DirInfo = new tb_directorio_Info();
                DirInfo.IdTipoDirectorio = eTipoDirectorio.CBTE_VALID.ToString();
                DirInfo.Ruta_directorio = param.RutaComprobantesValidos;
                BusDire.ModificarDB(DirInfo, ref msg);


                DirInfo = new tb_directorio_Info();
                DirInfo.IdTipoDirectorio = eTipoDirectorio.CERTI.ToString();
                DirInfo.Ruta_directorio = param.RutaCertificados;
                BusDire.ModificarDB(DirInfo, ref msg);


                DirInfo = new tb_directorio_Info();
                DirInfo.IdTipoDirectorio = eTipoDirectorio.REPO.ToString();
                DirInfo.Ruta_directorio = param.RutaComprobantesRepositorio;
                BusDire.ModificarDB(DirInfo, ref msg);

                DirInfo = new tb_directorio_Info();
                DirInfo.IdTipoDirectorio = eTipoDirectorio.CBTES_CON_ERROR.ToString();
                DirInfo.Ruta_directorio = param.RutaComprobantes_con_Errores;
                BusDire.ModificarDB(DirInfo, ref msg);



                param.RutaPrincipal = txtPathRoot.Text;
                param.RutaComprobantesRepositorio = txtComprobantesRepositorio.Text;
                param.RutaComprobantesValidos = txtComprobantesValidos.Text;
                param.RutaCertificados = txtCertificados.Text;
                param.RutaComprobantes_con_Errores = txtComprobantes_con_errores.Text;

                


                MessageBox.Show("Directorios Guardados Correctamente");

                MessageBox.Show("Ha procesido a Modificar Variables de Entorno se procedera a reiniciar el Sistema Efirm..", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Restart();

            }
            catch (Exception)
            {


            }

        }
        tb_Empresa_Bus Empresa_B = new tb_Empresa_Bus();
        void CrearCarpetasPorEmpresa() 
        {
           
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDirectorios();
        }
        public string Getpath(String PAHT = "")
        {
            try
            {

                using (FolderBrowserDialog FBD = new FolderBrowserDialog())
                {
                    if (!string.IsNullOrEmpty(PAHT))
                        FBD.SelectedPath = PAHT;

                    if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        return FBD.SelectedPath;
                    else
                        return PAHT;
                }
            }
            catch (Exception)
            {

                return "";
            }
        }
        private void SeleccionarRuta(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.TextEdit TextBoxDirec = ((DevExpress.XtraEditors.TextEdit)(sender));
            TextBoxDirec.Text = Getpath(TextBoxDirec.Text);
        }

        private void frmDirectorios_Load(object sender, EventArgs e)
        {
            try
            {

                Empresas = Empresa_B.GetEmpresas(ref mensajeErrorOut);
                listDirectorios = BusDirectorios.Consultar(ref mensajeErrorOut);

                param.RutaPrincipal = listDirectorios.Find(v => v.IdTipoDirectorio == "ROOT").Ruta_directorio;
                param.RutaCertificados = listDirectorios.Find(v => v.IdTipoDirectorio == "CERTI").Ruta_directorio;
                param.RutaComprobantesRepositorio = listDirectorios.Find(v => v.IdTipoDirectorio == "REPO").Ruta_directorio;
                param.RutaComprobantesValidos = listDirectorios.Find(v => v.IdTipoDirectorio == "CBTE_VALID").Ruta_directorio;
                param.RutaComprobantes_con_Errores = listDirectorios.Find(v => v.IdTipoDirectorio == "CBTES_CON_ERROR").Ruta_directorio;


                if (new System.IO.DirectoryInfo(param.RutaPrincipal).Exists)
                {
                    //setea los valores del directorio
                    P_PresentaValores_Directorio();
                }
                else
                {
                    //Crea directorio
                    P_CrearDirectorio();
                }


            }
            catch (Exception EX)
            {
                
                
            }

        }

        private void P_PresentaValores_Directorio()
            {
                    txtPathRoot.Text = param.RutaPrincipal;
                    txtComprobantesRepositorio.Text = param.RutaComprobantesRepositorio;
                    txtComprobantesValidos.Text = param.RutaComprobantesValidos;
                    txtCertificados.Text = param.RutaCertificados;
                    txtComprobantes_con_errores.Text = param.RutaComprobantes_con_Errores;

            }

        private void P_CrearDirectorio()
        {
           try
            {
               //Crea directorio
                System.IO.Directory.CreateDirectory(param.RutaPrincipal);
                System.IO.Directory.CreateDirectory(param.RutaComprobantesRepositorio);
                System.IO.Directory.CreateDirectory(param.RutaComprobantesValidos);
                System.IO.Directory.CreateDirectory(param.RutaCertificados);
                System.IO.Directory.CreateDirectory(param.RutaComprobantes_con_Errores);

               
                P_PresentaValores_Directorio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se necesita permiso al disco C:" + ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtPathRoot_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
