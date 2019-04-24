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

//comentario

namespace Efirm
{
    public partial class frmEmisor : Form
    {
        #region Declaración de variables
        BindingList<tb_Empresa_Info> ListaBin;
        List<tb_Catalogo_Info> listCatalogo;
        List<tb_Empresa_Info> listAUX;
        List<tb_Empresa_Info> listaGrabar = new List<tb_Empresa_Info>();
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Catalogo_Bus busCatalogo;
        tb_Empresa_Info row = new tb_Empresa_Info();
        frmEmisorMant emi = new frmEmisorMant();
        frmEmisorMant frmEmiMant;
        private eTipo_action Accion;
        string MensajeErrorOut = "";
        #endregion
                                          
        public frmEmisor()
        {
            InitializeComponent();          
        }
     
        void carga_Combos()
        {
            try
            {
                busCatalogo = new tb_Catalogo_Bus();

                listCatalogo = new List<tb_Catalogo_Info>();
                listCatalogo = busCatalogo.Consulta_Catalogo_x_IdTipoCatalogo(4);

                cmbgrid_Ambiente.DataSource = listCatalogo;
                cmbgrid_Ambiente.DisplayMember = "Descripcion";
                cmbgrid_Ambiente.ValueMember = "IdCatalogo";

                listCatalogo = new List<tb_Catalogo_Info>();
                listCatalogo = busCatalogo.Consulta_Catalogo_x_IdTipoCatalogo(3);

                cmbgrid_TipoEmision.DataSource = listCatalogo;
                cmbgrid_TipoEmision.DisplayMember = "Descripcion";
                cmbgrid_TipoEmision.ValueMember = "IdCatalogo";

                listCatalogo = new List<tb_Catalogo_Info>();
                listCatalogo = busCatalogo.Consulta_Catalogo_x_IdTipoCatalogo(5);

                cmbgrid_Tocken.DataSource = listCatalogo;
                cmbgrid_Tocken.DisplayMember = "Descripcion";
                cmbgrid_Tocken.ValueMember = "IdCatalogo";
            }
            catch (Exception ex)
            {
                             
            }                           
        }

        private void frmEmisor_Load(object sender, EventArgs e)
        {
            try
            {
                carga_Combos();
                                    
                List<tb_Empresa_Info> lista = new List<tb_Empresa_Info>();
                lista = busEmpresa.GetEmpresas(ref  MensajeErrorOut);

                foreach (var item in lista)
                {
                    if (item.logo != null)
                    {
                        item.imagen = Funciones.ArrayAImage(item.logo);                       
                    }
                }

                listAUX = new List<tb_Empresa_Info>();
                listAUX = busEmpresa.GetEmpresas(ref  MensajeErrorOut);

                foreach (var item in listAUX)
                {
                    if (item.logo != null)
                    {
                        item.imagen = Funciones.ArrayAImage(item.logo);
                    }
                }

                                            
                ListaBin = new BindingList<tb_Empresa_Info>(lista);

                gridControlEmisor.DataSource = ListaBin.OrderByDescending(x=>x.IdEmpresa);
                       
            }
            catch (Exception ex)
            {                            
            }
        }

        public Boolean Validar()
        {
            try
            {

                int focus = gridViewEmisor.FocusedRowHandle;
                gridViewEmisor.FocusedRowHandle = focus + 1;
         
                foreach (var item in ListaBin)
                {
                    if (item.RazonSocial == null || item.RazonSocial == "")
                   {
                       MessageBox.Show("Ingrese la Razon Social");
                       return false;                  
                    }

                    if (item.NombreComercial == null || item.NombreComercial == "")
                    {
                        MessageBox.Show("Ingrese el Nombre Comercial");
                        return false;
                    }

                    if (item.RUC == null || item.RUC == "")
                    {
                        MessageBox.Show("Ingrese el RUC");
                        return false;
                    }

                    if (item.ContribuyenteEspecial == null || item.ContribuyenteEspecial == "")
                    {
                        MessageBox.Show("Indique si Aplica como Contribuyente Especial");
                        return false;
                    }

                    if (item.ObligadoAllevarConta == null || item.ObligadoAllevarConta == "")
                    {
                        MessageBox.Show("Indique si Aplica a llevar Contablilidad");
                        return false;
                    }

                    if (item.cod_Ambiente == null || item.cod_Ambiente == "")
                    {
                        MessageBox.Show("Ingrese el Tipo de Ambiente");
                        return false;
                    }

                    if (item.cod_TipoEmision == null || item.cod_TipoEmision == "")
                    {
                        MessageBox.Show("Ingrese el Tipo de Emisión");
                        return false;
                    }

                    if (item.IdToquenAFirmar == null || item.IdToquenAFirmar == "")
                    {
                        MessageBox.Show("Ingrese el Tocken a Firmar");
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            #region Codigo Antiguo
            //try
            //{
            //    if(Validar())
            //    {
            //        if (ListaBin.Count != 0)
            //        {                       
            //                int focus = this.gridViewEmisor.FocusedRowHandle;
            //                gridViewEmisor.FocusedRowHandle = focus + 1;

            //                foreach (var item in ListaBin)                         
            //                {
            //                    if (item.IdEmpresAUX == 0 || item.IdEmpresAUX == null)
            //                    {
            //                        item.logo = item.imagen == null ? null :Funciones.ImageAArray(item.imagen);

            //                        listaGrabar.Add(item);
            //                    }

            //                    else
            //                    {
            //                        foreach (var itemAUX in listAUX)
            //                        {
            //                            if (item.IdEmpresa == itemAUX.IdEmpresa)
            //                            {
            //                                if (item.RazonSocial != itemAUX.RazonSocial || item.NombreComercial != itemAUX.NombreComercial || item.RUC != itemAUX.RUC ||
            //                                    item.DirMatriz != itemAUX.DirMatriz || item.ContribuyenteEspecial != itemAUX.ContribuyenteEspecial || item.ObligadoAllevarConta != itemAUX.ObligadoAllevarConta ||
            //                                    item.NombreCertificado != itemAUX.NombreCertificado || item.Clave_Certificado != itemAUX.Clave_Certificado ||
            //                                    //item.IdAmbiente != itemAUX.IdAmbiente || item.TipoEmision != itemAUX.TipoEmision || 
            //                                    item.FechaValidez != itemAUX.FechaValidez ||
            //                                    item.Estado != itemAUX.Estado || /*item.logo != itemAUX.logo ||  item.imagen != itemAUX.imagen */ item.ValidaImagen == 1 || item.IdToquenAFirmar != itemAUX.IdToquenAFirmar ||
            //                                    item.Alias != itemAUX.Alias || item.cod_Ambiente != itemAUX.cod_Ambiente || item.cod_TipoEmision != itemAUX.cod_TipoEmision)
            //                                {
            //                                    item.logo = item.imagen == null ? null :Funciones.ImageAArray(item.imagen);

            //                                    listaGrabar.Add(item);
            //                                }
            //                            }
            //                        }

            //                    }                             
            //                }  

            //                if (busEmpresa.GuardarDB(listaGrabar, ref MensajeErrorOut))                                                   
            //                {
            //                    MessageBox.Show("Grabado ok");
            //                    btnGrabar.Enabled = false;

            //                    MessageBox.Show("Ha procesido a Modificar Variables de Entorno se procedera a reiniciar el Sistema Efirm..", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                    Application.Restart();


            //                }
            //                else { MessageBox.Show("Error al Grabar " + MensajeErrorOut);
            //           }   

            //        } 

            //    }

            //}
            //catch (Exception ex)
            //{

            //}
            #endregion

            try
            {               
                if (row.IdEmpresa == 0)   
                {
                    MessageBox.Show("Selecione un Emisor", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frmEmiMant = new frmEmisorMant();                    
                    frmEmiMant.set_info(row);
                    frmEmiMant.set_Accion(eTipo_action.actualizar);
                    frmEmiMant.Event_frmEmisorMant_FormClosing += frmEmiMant_Event_frmEmisorMant_FormClosing;
                    frmEmiMant.ShowDialog();
                }
            }
            catch (Exception)
            {
            }                       
        }
        
        private void gridViewEmisor_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                            
                if (e.Column.Name == "colContribuyenteEspecial")
                {

                    if (Convert.ToString(gridViewEmisor.GetFocusedRowCellValue(colContribuyenteEspecial)) == "SI")
                    {
                        gridViewEmisor.SetFocusedRowCellValue(colContribuyenteEspecial, "S");
                    }

                    if (Convert.ToString(gridViewEmisor.GetFocusedRowCellValue(colContribuyenteEspecial)) == "NO")
                    {
                        gridViewEmisor.SetFocusedRowCellValue(colContribuyenteEspecial, "N");
                    }
                }

                if (e.Column.Name == "colObligadoAllevarConta")
                {

                    if (Convert.ToString(gridViewEmisor.GetFocusedRowCellValue(colObligadoAllevarConta)) == "SI")
                    {
                        gridViewEmisor.SetFocusedRowCellValue(colObligadoAllevarConta, "S");
                    }

                    if (Convert.ToString(gridViewEmisor.GetFocusedRowCellValue(colObligadoAllevarConta)) == "NO")
                    {
                        gridViewEmisor.SetFocusedRowCellValue(colObligadoAllevarConta, "N");
                    }
                }
         
            }
            catch (Exception ex)
            {
                                
            }
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            #region Codigo Antiguo Grilla
            //try
            //{
            //    btnGrabar.Enabled = true;
            //    if (ListaBin != null)
            //    {

            //        if (ListaBin.Count > 0)
            //        {
            //            int maximo = ListaBin.Max(x => x.IdEmpresa);

            //            info = new tb_Empresa_Info();
            //            info.IdEmpresa = maximo + 1;

            //            ListaBin.Add(info);
            //            gridControlEmisor.DataSource = ListaBin.OrderByDescending(x => x.IdEmpresa);

            //        }

            //        else
            //        {
            //            info = new tb_Empresa_Info();
            //            info.IdEmpresa = 1;

            //            ListaBin = new BindingList<tb_Empresa_Info>();
            //            ListaBin.Add(info);
            //            gridControlEmisor.DataSource = ListaBin.OrderByDescending(x => x.IdEmpresa);

            //        }

            //    }

            //}
            //catch (Exception ex)
            //{                               
            //}
            #endregion

            frmEmisorMant frmEmiMant = new frmEmisorMant();
            frmEmiMant.set_Accion(eTipo_action.grabar);
            frmEmiMant.Event_frmEmisorMant_FormClosing += frmEmiMant_Event_frmEmisorMant_FormClosing;
            frmEmiMant.ShowDialog();
           
        }

        private void gridViewEmisor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                {
                    row = (tb_Empresa_Info)gridViewEmisor.GetFocusedRow();

                    if (row.IdEmpresAUX == 0)
                    {
                        if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ListaBin.Remove(row);

                            gridControlEmisor.DataSource = ListaBin.OrderByDescending(x => x.IdEmpresa);

                            gridControlEmisor.RefreshDataSource();
                        }
                    }
                    else
                    {
                        // anular
                        if (busEmpresa.AnularDB(row, ref MensajeErrorOut))
                        {
                            MessageBox.Show("Anulado Okey");
                       
                            ListaBin = new BindingList<tb_Empresa_Info>(busEmpresa.GetEmpresas(ref  MensajeErrorOut));
                            gridControlEmisor.DataSource = ListaBin.OrderByDescending(x => x.IdEmpresa);
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

        private void gridViewEmisor_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewEmisor.GetRow(e.RowHandle) as tb_Empresa_Info;
                if (data == null)
                    return;
                if (data.Estado== false && data.IdEmpresAUX !=0)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {              
            }
        }

        private void gridViewEmisor_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {               
                if (e.Column.Name == "colimagen")
                {
                    try
                    {
                        row = (tb_Empresa_Info)gridViewEmisor.GetFocusedRow();
                        
                        OpenFileDialog EscojaFoto = new OpenFileDialog();
                        EscojaFoto.InitialDirectory = "c:\\";
                        EscojaFoto.Filter = "JPG FILES (*.JPG)|*.jpg|GIF FILES (*.GIF)|*.gif|JPEG FILES (*.JPEG)|*.jpeg|PNG FILES (*.PNG)|*.png";
                        EscojaFoto.RestoreDirectory = true;
                        EscojaFoto.ShowDialog();

                        if (EscojaFoto.FileName != "")
                        {
                            if (row.IdEmpresAUX == 0 || row.IdEmpresAUX == null)
                            {
                                gridViewEmisor.SetFocusedRowCellValue(colimagen, Image.FromFile(EscojaFoto.FileName));
                                return;                           
                            }

                            if (gridViewEmisor.GetFocusedRowCellValue(colimagen) == null)
                            {
                                gridViewEmisor.SetFocusedRowCellValue(colimagen, Image.FromFile(EscojaFoto.FileName));
                                gridViewEmisor.SetFocusedRowCellValue(colValidaImagen, 1);
                                return;
                            }
                         
                            string fame2 = "";
                            fame2 = EscojaFoto.FileName.ToString();                       

                            Bitmap img1;
                            Bitmap img2;
                            bool flag=true;

                            string img1_ref;
                            string img2_ref;

                            int count2=0;
                            int count1=0;

                            img1 = new Bitmap((Bitmap)gridViewEmisor.GetFocusedRowCellValue(colimagen));
                            img2 = new Bitmap(fame2);

                            if (img1.Width == img2.Width && img1.Height == img2.Height)
                            {
                                for (int i = 0; i < img1.Width; i++)
                                {
                                    for (int j = 0; j < img1.Height; j++)
                                    {
                                        img1_ref = img1.GetPixel(i, j).ToString();
                                        img2_ref = img2.GetPixel(i, j).ToString();
                                        if (img1_ref != img2_ref)
                                        {
                                            count2++;
                                            flag = true;
                                            break;
                                        }
                                        count1++;
                                        flag = false;
                                    }

                                }
                                if (flag == true)
                                {
                                    // MessageBox.Show("No son iguales, " + count2 + " Pixeles incorrectos", "Pixeles incorrectos");
                                    gridViewEmisor.SetFocusedRowCellValue(colimagen, Image.FromFile(EscojaFoto.FileName));
                                    gridViewEmisor.SetFocusedRowCellValue(colValidaImagen, 1);
                                }
                                else
                                {
                                    // MessageBox.Show("Imagenes iguales " + count1 + " Pixelex iguales", "Imágenes iguales");
                                    gridViewEmisor.SetFocusedRowCellValue(colValidaImagen, 0);

                                }
                            }
                            else
                            {
                                // MessageBox.Show("No se pueden comparar las imagenes", "Tamaño distinto de imágenes");
                                gridViewEmisor.SetFocusedRowCellValue(colimagen, Image.FromFile(EscojaFoto.FileName));
                                gridViewEmisor.SetFocusedRowCellValue(colValidaImagen, 1);
                            }

                        //s  gridViewEmisor.SetFocusedRowCellValue(colimagen, Image.FromFile(EscojaFoto.FileName));
                          
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }     
            }
            catch (Exception ex)
            {
                             
            }
        }

        private void gridControlEmisor_Click(object sender, EventArgs e)
        {

        }

        void frmEmiMant_Event_frmEmisorMant_FormClosing(object sender, FormClosingEventArgs e)
        {
             
        }

        private void gridViewEmisor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                row = (tb_Empresa_Info)gridViewEmisor.GetFocusedRow();
            }
            catch (Exception ex)
            {

            }
        }

        void frm_Event_frmEmisorMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmEmisor_Load(sender, e);
            }
            catch (Exception ex)
            {
                
            }
           

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (row.IdEmpresa == 0)
                {
                    MessageBox.Show("Selecione un Emisor", "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frmEmiMant = new frmEmisorMant();
                    frmEmiMant.set_info(row);
                    frmEmiMant.set_Accion(eTipo_action.consultar);
                    frmEmiMant.Event_frmEmisorMant_FormClosing += frmEmiMant_Event_frmEmisorMant_FormClosing;
                    frmEmiMant.ShowDialog();
                }
            }
            catch (Exception)
            {
            }  
        }

        private void btnRefresca_Click(object sender, EventArgs e)
        {
            try
            {

                frmEmisor_Load(sender, e);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
