using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailEfirm.Forms;
using FirmElect.Bus;
using FirmElect.Info;

namespace Efirm
{
    public partial class frmImportarClavesContin_Consu : Form
    {
        #region Declaración de Variables
        tb_Clave_Conting_Info row = new tb_Clave_Conting_Info();
        tb_Clave_Conting_Bus busclave = new tb_Clave_Conting_Bus();
        BindingList<tb_Clave_Conting_Info> lista = new BindingList<tb_Clave_Conting_Info>();

        #endregion
       
        public frmImportarClavesContin_Consu()
        {
            InitializeComponent();
        }

        private void gridViewClaveCont_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            try
            {
                row = (tb_Clave_Conting_Info)gridViewClaveCont.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ex.Message);

            }
        }

        private void cargar_claves()
        {
            try
            {
                string msg = "";

                lista = new BindingList<tb_Clave_Conting_Info>(busclave.consultar(ref msg));

                foreach (var item in lista)
                {
                    if (item.IdAmbiente == 1)
                    { item.nomAmbiente = "PRUEBAS"; }

                    if(item.IdAmbiente==2)
                    { item.nomAmbiente = "PRODUCCION"; }
                }
                
                if (lista.Count > 0)
                {
                                     
                    gridControlClaveCont.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("No registros que mostrar" + msg, "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridControlClaveCont.DataSource = null;
                    gridControlClaveCont.RefreshDataSource();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }
        }

        private void gridControlClaveCont_Click(object sender, EventArgs e)
        {

        }

        private void frmImportarClavesContin_Consu_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_claves();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            try
            {
                frmImportarClavesContin clave = new frmImportarClavesContin();
                clave.ShowDialog();
                cargar_claves();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {                               
            }
        }

    }
}
