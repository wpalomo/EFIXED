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
using FirmElect.Bus;
using FirmElect.Info;

namespace MailEfirm.Controls
{
    

    public partial class UC_Cuentas : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        #region Declaración de variables
        BindingList<mail_Cuentas_Correo_Info> lista = new BindingList<mail_Cuentas_Correo_Info>();
        mail_Cuentas_Correo_Bus BusMailCorreo = new mail_Cuentas_Correo_Bus();
        mail_Cuentas_Correo_Info row = new mail_Cuentas_Correo_Info();
        mail_Cuentas_Correo_x_Empresa_Bus BusCuentaemisor = new mail_Cuentas_Correo_x_Empresa_Bus();
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        BindingList<mail_Cuentas_Correo_x_Empresa_Info> CuentasExistente = new BindingList<mail_Cuentas_Correo_x_Empresa_Info>();

        #endregion
       
        public UC_Cuentas()
        {
            InitializeComponent();
        }

        private void btnNuevaCuenta_Click(object sender, EventArgs e)
        {
            Frm_Nueva_Cuenta newCuenta = new Frm_Nueva_Cuenta();
            newCuenta.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        { //modificar
            try
            {                                      
                  Frm_Cuenta_Configuracion formulario = new Frm_Cuenta_Configuracion();                            
                  formulario.set_Info_Cuenta_Modificar(row);
                  formulario.ShowDialog();
                  cargar_cuentas();
                  CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }       
        }
        
        private void cargar_cuentas()
        { 
            try 
            {
                string msg="";

                lista = new BindingList<mail_Cuentas_Correo_Info>( BusMailCorreo.consultar(ref msg));
                if (lista.Count > 0)
                {
                  gridControlCuentas.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("No registros que mostrar" + msg, "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridControlCuentas.DataSource = null;
                    gridControlCuentas.RefreshDataSource();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            
            }
        }

        private void UC_Cuentas_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_cuentas();
                CargarCombos();
                CargarCuentasRelacionadas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_cuentas();
                CargarCuentasRelacionadas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }
               
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Cuenta_Configuracion formulario = new Frm_Cuenta_Configuracion();
                formulario.ShowDialog();
                cargar_cuentas();
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }
        }
           
        private void gridViewCuentas_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                row = (mail_Cuentas_Correo_Info)gridViewCuentas.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());

            }
        }

        public void CargarCombos()
        {
            try
            {
                //lleno el combo de las cuentas
                string mensaj = "";
                List<mail_Cuentas_Correo_Info> listaCuenta = new List<mail_Cuentas_Correo_Info>();
                listaCuenta = BusMailCorreo.consultar(ref mensaj);
                cmbCuentas.Properties.DataSource = listaCuenta;



                // lleno el combo de emisores  
                List<tb_Empresa_Info> listaEmpresa = new List<tb_Empresa_Info>();
                listaEmpresa = busEmpresa.GetEmpresas(ref mensaj);
                cmbEmisores.Properties.DataSource = listaEmpresa;
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
        }
        
        public void CargarCuentasRelacionadas()
        {
            string mensaj="";
            try
            {
                //lleno la grilla
                CuentasExistente = new BindingList<mail_Cuentas_Correo_x_Empresa_Info>(BusCuentaemisor.Consulta_mail_Cuentas_Correo_x_Empresa(ref mensaj));
                gridControlCtaPoEmisor.DataSource = CuentasExistente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
        }

        private void btnAgregarRelacion_Click(object sender, EventArgs e)
        {
            
            try
            {


               var Existe= CuentasExistente.FirstOrDefault(v => v.IdEmpresa == Convert.ToInt32(cmbEmisores.EditValue));

               if (Existe != null)
               {
                   MessageBox.Show("El emisor ya esta relacionado con una cuenta **NO PUEDE ESTAR RELACIONADO CON MAS DE UNA CUENTA*** ", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   return;
               }


                



                foreach (var item in CuentasExistente)
                {

                    if (item.IdCuenta == Convert.ToString(cmbCuentas.EditValue) && item.IdEmpresa == Convert.ToInt32(cmbEmisores.EditValue))
                    {
                        MessageBox.Show("Cuentas ya Relacionada con esta empresa", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }



                if (BusCuentaemisor.GuardarRelacion(Convert.ToInt32(cmbEmisores.EditValue), Convert.ToString(cmbCuentas.EditValue), txtObservaciones.Text) == true)
                {
                    MessageBox.Show("Registro Guardado Ok", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Relacion no Completada", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                CargarCuentasRelacionadas();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
                
            }
        }

        // ---------------------------------------------------------

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void gbx_top_Enter(object sender, EventArgs e)
        {

        }

        private void cmbEmisores_EditValueChanged(object sender, EventArgs e)
        {

        }
      
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Cuenta_Configuracion formulario = new Frm_Cuenta_Configuracion();
                formulario.set_Info_Cuenta_Modificar(row);
                formulario.set_Accion(eTipo_action.consultar);
                formulario.ShowDialog();
                cargar_cuentas();
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }    
        }

        private void gridControlCuentas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gridControlCuentas_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gridControlCuentas_Click(object sender, EventArgs e)
        {

        }
    }
}
