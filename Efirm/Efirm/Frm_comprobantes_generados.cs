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
using FirmElect.Data;
namespace Efirm
{
    public partial class Frm_comprobantes_generados : Form
    {
        public Frm_comprobantes_generados()
        {
            InitializeComponent();
        }
        string conexion = "";
        string cliente = "";

        BindingList<fx_Comprobante_generados_Info> listaComprobanteGenerados = new BindingList<fx_Comprobante_generados_Info>();
        fx_Comprobantes_generados_Bus BusComprobanteGenerados = new fx_Comprobantes_generados_Bus();
        private void Frm_comprobantes_generados_Load(object sender, EventArgs e)
        {
            try
            {
                conexion = Properties.Settings.Default.Conexioncliente;
                cliente = Properties.Settings.Default.Cliente_Fuente;

                listaComprobanteGenerados = new BindingList<fx_Comprobante_generados_Info>(BusComprobanteGenerados.Listacomprobantes_generados_AX(conexion, cliente));
                gridControlCG.DataSource = listaComprobanteGenerados;

            }
            catch (Exception)
            {
            } 
        }

        private void gridViewCG_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

                switch (e.Column.Name)
                {

                    case "Checke":

                        fx_Comprobante_generados_Info InfoCbteT;
                        InfoCbteT = (fx_Comprobante_generados_Info)gridViewCG.GetFocusedRow();
                           if(InfoCbteT!=null)
                           {
                                if (MessageBox.Show("Esta seguro que desear anular el comprobante #:" + InfoCbteT.IdRegistro, "Efixed confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    if (BusComprobanteGenerados.Eliminar_Comprobantes_Generados_FX(InfoCbteT, conexion, cliente))
                                    {
                                        MessageBox.Show("Eliminacion de comprobante Ok", "Efixed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        listaComprobanteGenerados.Remove(InfoCbteT);
                                        gridControlCG.DataSource = listaComprobanteGenerados;
                                    }
                                }

                            }


                        break;
                    default:
                    break;
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
