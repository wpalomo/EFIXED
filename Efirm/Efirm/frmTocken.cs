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
    public partial class frmTocken : Form
    {
        BindingList<tb_Tocken_Info> lisTocken;

        tb_Tocken_Bus busTocken = new tb_Tocken_Bus();
        List<tb_Tocken_Info> listaGrabar = new List<tb_Tocken_Info>();
        List<tb_Tocken_Info> listAUX;

        string MensajeErrorOut = "";
        int sec = 0;
       
        public frmTocken()
        {
            InitializeComponent();
        }

        private void frmTocken_Load(object sender, EventArgs e)
        {
            try
            {
                List<tb_Tocken_Info> lista = new List<tb_Tocken_Info>();
                lista = busTocken.ConsulTocken(ref MensajeErrorOut );

                listAUX = busTocken.ConsulTocken(ref MensajeErrorOut);

                sec = 0;
                foreach (var item in lista)
                {
                    sec = sec + 1;
                    item.secuencial = sec;
                }

                lisTocken = new BindingList<tb_Tocken_Info>(lista);
                gridControlTocken.DataSource = lisTocken.OrderByDescending(x=> x.secuencial);
              
            }
            catch (Exception ex)
            {                            
            }
        }

        Boolean Verifica_IdTocken()
        {
            try
            {
                int focus = this.gridViewTocken.FocusedRowHandle;
                gridViewTocken.FocusedRowHandle = focus + 1;  
                              
                foreach (var item in lisTocken)
                {
                    if (item.IdTocken == null || item.IdTocken == "")
                    {
                        MessageBox.Show("Ingrese en el detalle el IdTocken: ");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {               
                return false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {                              
                if (Verifica_IdTocken())
               {
                   if (verificarrepetidos(row.IdTocken))
                      {
                          if (lisTocken.Count != 0)
                          {                             
                              int focus = this.gridViewTocken.FocusedRowHandle;
                              gridViewTocken.FocusedRowHandle = focus + 1;

                              foreach (var item in lisTocken)
                              {
                                  if (item.IdTockenAUX == null)
                                  {
                                      tb_Tocken_Info info = new tb_Tocken_Info();

                                      info.IdTocken = item.IdTocken.Trim();
                                      info.nom_tocken = item.nom_tocken;
                                      info.Password = item.Password;
                                      info.Serie = item.Serie;
                                      info.Modelo = item.Modelo;
                                      info.IdTipo = item.IdTipo;
                                      info.Estado = item.Estado;
                                      info.IdTockenAUX = item.IdTockenAUX;

                                      listaGrabar.Add(info);
                                  }

                                  else
                                  {
                                      foreach (var itemAUX in listAUX)
                                      {
                                          if (item.IdTockenAUX == itemAUX.IdTockenAUX)
                                          {
                                              if (item.nom_tocken.Trim() != itemAUX.nom_tocken.Trim() || item.Password.Trim() != itemAUX.Password.Trim() || item.Serie != itemAUX.Serie.Trim()
                                                 || item.Modelo != itemAUX.Modelo || item.IdTipo != itemAUX.IdTipo || item.Estado.Trim() != itemAUX.Estado.Trim())
                                              {
                                                  tb_Tocken_Info info = new tb_Tocken_Info();

                                                  info.IdTocken = item.IdTocken.Trim();
                                                  info.nom_tocken = item.nom_tocken;
                                                  info.Password = item.Password;
                                                  info.Serie = item.Serie;
                                                  info.Modelo = item.Modelo;
                                                  info.IdTipo = item.IdTipo;
                                                  info.Estado = item.Estado;
                                                  info.IdTockenAUX = item.IdTockenAUX;

                                                  listaGrabar.Add(info);

                                              }
                                          }
                                      }
                                  }
                              }                          
                              if (busTocken.GuardarDB(listaGrabar,ref  MensajeErrorOut))
                              {
                                  MessageBox.Show("Grabado Okey");
                                  btnGrabar.Enabled = false;
                                                           
                              }
                              else { MessageBox.Show("Error al Grabar" + MensajeErrorOut); }                            
                          }
                       }               
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

        tb_Tocken_Info info;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                btnGrabar.Enabled = true;
                
                if (lisTocken != null)
                {
                    if (lisTocken.Count >0)
                    {
                        int maximo = lisTocken.Max(x => x.secuencial);

                        info = new tb_Tocken_Info();
                        info.secuencial = maximo + 1;
                    
                        lisTocken.Add(info);
                       gridControlTocken.DataSource = lisTocken.OrderByDescending(x=>x.secuencial);
                    }
                    else
                    {

                        info = new tb_Tocken_Info();
                        info.secuencial = 1;

                        lisTocken = new BindingList<tb_Tocken_Info>();
                        lisTocken.Add(info);
                        gridControlTocken.DataSource = lisTocken.OrderByDescending(x=>x.secuencial);
                        
                    }
                }
            }
            catch (Exception ex)
            {                              
            }
        }

        private Boolean verificarrepetidos(string id)
        {
            try
            {
                var cont = from C in lisTocken
                           where C.IdTocken == id
                           select C;
                if (cont.Count() == 1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El IdTocken: " + id + " ya se encuentra Ingresado. Ingrese un Código diferente");
                    return false;
                }
            }
            catch (Exception ex)
            {              
                return false;
            }

        }

        tb_Tocken_Info row ;
        private void gridViewTocken_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                row = new tb_Tocken_Info();
                row = (tb_Tocken_Info)gridViewTocken.GetFocusedRow();

                if (e.Column.Name == "colIdTocken")
                {
                   if(row.IdTockenAUX!=null)
                   {                      
                       foreach (var item in lisTocken)
                       {
                           if (item.IdTockenAUX == row.IdTockenAUX)
                           {
                               item.IdTocken = row.IdTockenAUX;
                           }
                       }
                   }                               
                }
            }
            catch (Exception ex)
            {                              
            }
        }
      
        private void gridViewTocken_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                {
                    row = new tb_Tocken_Info();
                    row = (tb_Tocken_Info)gridViewTocken.GetFocusedRow();

                    if (row.IdTockenAUX == null)
                    {
                        if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            lisTocken.Remove(row);

                            gridControlTocken.DataSource = lisTocken.OrderByDescending(x => x.secuencial);

                            gridControlTocken.RefreshDataSource();
                        }
                    }
                    else
                    {
                        // anular
                        if (busTocken.AnularDB(row, ref MensajeErrorOut))
                        {
                            MessageBox.Show("Anulado Okey");


                            lisTocken = new BindingList<tb_Tocken_Info>(busTocken.ConsulTocken(ref  MensajeErrorOut));
                            sec = 0;
                            foreach (var item in lisTocken)
                            {
                                sec = sec + 1;
                                item.secuencial = sec;
                            }                           
                            gridControlTocken.DataSource = lisTocken.OrderByDescending(x => x.secuencial);
                        }
                        else
                        {
                            MessageBox.Show("Error al Anular" + MensajeErrorOut);                       
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                              
            }
        }

        private void gridViewTocken_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                 var data = gridViewTocken.GetRow(e.RowHandle) as tb_Tocken_Info;
                if (data == null)
                    return;
                if (data.Estado=="I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                               
            }
        }
    }
}
