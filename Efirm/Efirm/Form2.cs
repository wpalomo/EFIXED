using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Bus;



using System.IO;

using FirmElect.Info;

namespace Efirm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg="";

            WSEfirm_cbte.Ws_ComprobanteClient cliente = new WSEfirm_cbte.Ws_ComprobanteClient();
           
            List<tb_Catalogo_Info> lista = new List<tb_Catalogo_Info>();
         
            foreach (var item in cliente.Lista_TipoComprobantes(ref msg).ToList())
            {
                tb_Catalogo_Info info = new tb_Catalogo_Info();
                info.IdCatalogo = item.IdCatalogo;
                info.Descripcion = item.Descripcion;
                lista.Add(info);               
            }

            gridControlTipoCbte.DataSource = lista;                 
        }

        private void gridControlTipoCbte_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAliasUrl_Click(object sender, EventArgs e)
        {
            try
            {
                string alias = "";
                alias = txtAlias.Text;

               string msg = "";       
                WSEfirm_Empresa.Ws_EmpresaClient empresa = new WSEfirm_Empresa.Ws_EmpresaClient();

                List<tb_Empresa_Info> listaEmp = new List<tb_Empresa_Info>();
                
                if(rdbAlias.Checked==true)
               {
                 
                  foreach (var item in empresa.GetEmpresas_x_Alias(alias.Trim(), ref msg))
                  {
                      tb_Empresa_Info info = new tb_Empresa_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.RazonSocial = item.RazonSocial;
                      info.logo = item.logo;
                      listaEmp.Add(info);
                  }
              
               }

                if (rdbUrl.Checked == true)
                {
                    
                    foreach (var item in empresa.GetEmpresas_x_Url(alias.Trim(), ref msg))
                    {
                        tb_Empresa_Info info = new tb_Empresa_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.RazonSocial = item.RazonSocial;
                        info.logo = item.logo;
                        listaEmp.Add(info);
                    }
                }
                            
                gridControlAliasUrl.DataSource = listaEmp;
            }
            catch (Exception ex)
            {
                
               
            }
        }

        private void btnBuscarContri_Click(object sender, EventArgs e)
        {
            try
            {
                int idempresa = 0;
                string cedulaRuc = "";
                string password = "";
                string mail = "";

                 idempresa = Convert.ToInt32(txtIdEmpresa.Text);
                 cedulaRuc = txtcedulaRuc.Text;
                 password = txtPassword.Text;
                 mail =txtMail.Text;


               string msg = "";
               WSEfirm_Contribuyente.Ws_ContribuyenteClient contri = new WSEfirm_Contribuyente.Ws_ContribuyenteClient();

               List<tb_Contribuyente_Info> listaContri = new List<tb_Contribuyente_Info>();
                
                if(this.rdbLista.Checked==true)
               {

                   foreach (var item in contri.GetContribuyente(idempresa,cedulaRuc.Trim(),password.Trim(), ref msg))
                  {
                      tb_Contribuyente_Info info = new tb_Contribuyente_Info();
                      info.IdContribuyente = item.IdContribuyente;
                      info.cedulaRuc_contri = item.cedulaRuc_contri;
                      info.Nom_Contribuyente = item.Nom_Contribuyente;
                      listaContri.Add(info);
                  }
              
               }

                if (rdbInfo.Checked == true)
                {

                    tb_Contribuyente_Info infoContri = new tb_Contribuyente_Info();
                    infoContri = contri.GetContribuyente_Info(idempresa, cedulaRuc.Trim(), ref msg);

                    listaContri.Add(infoContri);
                                      
                }

                if (rdbModifica.Checked == true)
                {

                    contri.Modificar_GetContribuyente_Info(idempresa, cedulaRuc.Trim(), mail.TrimEnd(), password.Trim(), ref msg);
                    
                }

                gridControlContri.DataSource = listaContri;
            }
            catch (Exception ex)
            {
                
               
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idempresa = 0;
                string cedulaRuc = "";
                string tipoCbte = "";
                string buscar = "";
                DateTime FecIni;
                DateTime FecFin;
                string msg = "";

                idempresa = Convert.ToInt32(txtIdEmpresaCbte.Text);
                cedulaRuc = txtCedulaRucCbte.Text;
                tipoCbte = txtTipoCbte.Text;
                buscar = txtBuscar.Text;
                FecIni = Convert.ToDateTime(dteFecIni.EditValue);
                FecFin = Convert.ToDateTime(dteFecFin.EditValue);
                                           
                WSEfirm_cbte.Ws_ComprobanteClient Cbte = new WSEfirm_cbte.Ws_ComprobanteClient();
                List<tb_Comprobante_Info> listaCbte = new List<tb_Comprobante_Info>();

                foreach (var item in Cbte.consultar_listado_comprobantes(idempresa, cedulaRuc.Trim(), tipoCbte.Trim(),FecIni,FecFin,buscar.Trim(),1,10, ref msg))
                {
                    tb_Comprobante_Info info = new tb_Comprobante_Info();
              
                    info.IdComprobante = item.IdComprobante;
                    info.IdTipoDocumento = item.IdTipoDocumento;
                    info.Numero_Autorizacion = item.Numero_Autorizacion;
                    info.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                    info.Nom_TipoDocumento = item.Nom_TipoDocumento;
                    info.Total = Convert.ToDouble(item.Total);

                    listaCbte.Add(info);
                }

                gridControlCbte.DataSource = listaCbte;

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void btnConsultarXML_Click(object sender, EventArgs e)
        {
            try
            {
                int idempresa = 0;
                string cedulaRuc = "";
                string IdComprobante= "";

                 idempresa = Convert.ToInt32(txtIdEmpresaXML.Text);
                 cedulaRuc = txtcedulaRucXML.Text;
                 IdComprobante = txtIdComprobante.Text;

                 string msg = "";

                 WSEfirm_cbte.Ws_ComprobanteClient Cbte = new WSEfirm_cbte.Ws_ComprobanteClient();
                 List<tb_Comprobante_Info> listaXML = new List<tb_Comprobante_Info>();

                // tb_Comprobante_Info infoXML = new tb_Comprobante_Info();
                 string xml = "";
                 xml = Cbte.getXML(idempresa, cedulaRuc.Trim(), IdComprobante.Trim(), ref msg);

                 //string xml = "";
                 //xml = infoXML.s_XML;

                 //listaXML.Add(infoXML);

                 //gridControlXML.DataSource = listaXML;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnConsultarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                int idempresa = 0;
                string cedulaRuc = "";
                string IdComprobante = "";

                idempresa = Convert.ToInt32(txtIdEmpresaPDF.Text);
                cedulaRuc = txtcedulaRucPDF.Text;
                IdComprobante = txtIdComprobantePDF.Text;

                string msg = "";

                WSEfirm_cbte.Ws_ComprobanteClient Cbte = new WSEfirm_cbte.Ws_ComprobanteClient();
              

                byte[] resul;
                resul = Cbte.getRide_Pdf(idempresa, cedulaRuc.Trim(), IdComprobante.Trim());

              
                //System.IO.File.WriteAllBytes("myfile.pdf", resul);

             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg="";

            tb_Comprobante_Bus bus = new tb_Comprobante_Bus();
            bus.consultar_listado_comprobantes_x_web(1, "0990360545001","01", DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(1), "", 1, 10, ref msg);



        }
    }
}
