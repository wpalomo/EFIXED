using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Info;
using FirmElect.Bus;
namespace Efirm
{
    public partial class frmImportarClavesContin : Form
    {
        public frmImportarClavesContin()
        {
            InitializeComponent();
        }

        private void txtUrl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (OpenFileDialog OPD = new OpenFileDialog())
                {
                    OPD.Filter = "archivos txt (*.txt)|*.txt";
                    OPD.ShowDialog();
                    if (OPD.OpenFile() != null)
                    {
                        txtUrl.Text = OPD.FileName;
                        LeerArchivo(OPD.FileName);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        //cl_parametrosGenerales param = cl_parametrosGenerales.Instance;
        List<tb_Clave_Conting_Info> Claves = new List<tb_Clave_Conting_Info>();
        void LeerArchivo(string PATH) 
        {
            try
            {
                string msg="";
                int IdEmpresa = 0;
                string ruc="";

                tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
                List<tb_Empresa_Info> listEmpresa = new List<tb_Empresa_Info>();
                listEmpresa =BusEmpresa.GetEmpresas(ref msg);

                if (listEmpresa.Count == 0)
                {
                    MessageBox.Show("No emisores para cargar este file .. debe crear un emisor con el mismo ruc que tenga este file");
                    return;
                }

                string line;
                    decimal idclave ;

                    idclave = clave_b.getId(ref msg);

                using (StreamReader FILETXT = new StreamReader(PATH))
                {

                    

                    while ((line = FILETXT.ReadLine()) != null)
                    {


                        ruc = line.Substring(0, 13);
                        var item=listEmpresa.FirstOrDefault(q=>q.RUC==ruc);
                        

                        Claves.Add(new tb_Clave_Conting_Info() {  IdClave= idclave,ClaveContingencia = line
                            , IdEmpresa = item.IdEmpresa
                            , Estado = true, Usado = false, Fecha_Importacion = DateTime.Now
                            , Fecha_Trans = DateTime.Now  ,IdAmbiente=0});
                        idclave++;
                    }
                }
                gridControl1.DataSource = Claves;
            }
            catch (Exception)
            {
                
                

            }
        
        }
        tb_Clave_Conting_Bus clave_b = new tb_Clave_Conting_Bus();
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdAmbiente = 0;
                string sAmbiente = "";
                if (cmb_ambiente.SelectedItem == null)
                {
                    MessageBox.Show("Escoja el ambiente de estas claves ...", "efirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                sAmbiente=cmb_ambiente.SelectedItem.ToString();

                IdAmbiente = (sAmbiente == "PRUEBAS") ? 1 : 2;


                foreach (var item in Claves)
                {
                    item.IdAmbiente = IdAmbiente;
                    
                }
             
                splashScreenManager1.ShowWaitForm();

                if(clave_b.Guardar_Clave_Contigencia(Claves))
                {
                    MessageBox.Show("Guardado OK");
                    splashScreenManager1.CloseWaitForm();
                }
                else
                {
                    MessageBox.Show("Error al Guardar  las Claves");
                }
            }
            catch (Exception)
            {
                
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUrl_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_ambiente_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_ambiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int IdAmbiente = 0;
                string sAmbiente = "";
                if (cmb_ambiente.SelectedItem == null)
                {
                    MessageBox.Show("Escoja el ambiente de estas claves ...", "efirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                sAmbiente = cmb_ambiente.SelectedItem.ToString();

                IdAmbiente = (sAmbiente == "PRUEBAS") ? 1 : 2;




                foreach (var item in Claves)
                {
                    item.IdAmbiente = IdAmbiente;

                }
                gridControl1.RefreshDataSource();

            }
            catch (Exception ex)
            {


            }

        }
    }
}
