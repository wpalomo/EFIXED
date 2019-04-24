using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Info;
using FirmElect.Bus;


namespace Efirm
{
    public partial class frmLogError : Form
    {
        public frmLogError()
        {
            InitializeComponent();
        }

        tb_sis_Log_Error_Vzen_Bus BusLog = new tb_sis_Log_Error_Vzen_Bus();

        private void frmLogError_Load(object sender, EventArgs e)
        {

        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            refrescar_log();
        }

        void refrescar_log()
        {
            try
            {
                
                gridControlLog.DataSource = BusLog.ObtenerLista_logError();

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void gridViewLog_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colDetalle")
                {

                    string mensaje = (string)gridViewLog.GetFocusedRowCellValue(colDetalle);

                    if (mensaje != "")
                    {

                        frmMensaje frmsg = new frmMensaje();
                        frmsg.richTextBoxMensaje.Text = mensaje;
                        frmsg.WindowState = FormWindowState.Maximized;
                        frmsg.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void bnt_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string msg="";

                BusLog.Eliminar_Log(ref msg);
            }
            catch (Exception ex)
            {
                
                
            }

        }

        private void gridControlLog_Click(object sender, EventArgs e)
        {

        }
    }
}
