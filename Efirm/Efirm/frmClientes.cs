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
    public partial class frmClientes : Form
    {

        BindingList<tb_Cliente_Info> ListaBind ;
        tb_Cliente_Bus bus_Cliente = new tb_Cliente_Bus();
        List<tb_Cliente_Info> list_Cliente = new List<tb_Cliente_Info>();
        
        public frmClientes()
        {
            InitializeComponent();
        }

        void carga_grid()
        {
            try
            {
                string msg = "";

                list_Cliente = bus_Cliente.Consulta_Clientes(ref msg);
                ListaBind = new BindingList<tb_Cliente_Info>(list_Cliente);
                gridControlClientes.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                             
            }
        
        }
         
        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                carga_grid();
            }
            catch (Exception ex)
            {
                               
            }
        }

        tb_Cliente_Info Info;
        List<tb_Cliente_Info> lista = new List<tb_Cliente_Info>();

        private void gridViewClientes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Info = (tb_Cliente_Info)this.gridViewClientes.GetFocusedRow();
          
                foreach (var item in ListaBind)
                {

                    if (Info.IdEmpresa == item.IdEmpresa && Info.IdCliente==item.IdCliente)
                    {
                        tb_Cliente_Info info = new tb_Cliente_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.Razon_Social = item.Razon_Social;
                        info.Nombre = item.Nombre;
                        info.Apellido = item.Apellido;
                        info.Cedula_RUC = item.Cedula_RUC;
                        info.Direccion = item.Direccion;
                        info.Telefono = item.Telefono;
                        info.Correo = item.Correo;
                        info.EsEmpresa = item.EsEmpresa;
                        info.Estado = item.Estado;

                        lista.Add(Info);                  
                   }
                                     
                }
            }
            catch (Exception ex)
            {
                
                
            }
        }
        string msg = "";
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (bus_Cliente.Modificar_Cliente(lista, ref msg))
                {
                    MessageBox.Show(msg);                  
                }
                else
                {
                    MessageBox.Show("Error al Actualizar Clientes");
                }
               

            }
            catch (Exception ex)
            {
                                
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

        private void btnActualizarySalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_Cliente.Modificar_Cliente(lista, ref msg))
                {
                    MessageBox.Show(msg);
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al Actualizar Clientes");
                }
            }
            catch (Exception ex)
            {
                
             
            }
            
          
        }


    }
}
