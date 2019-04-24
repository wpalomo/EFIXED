using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Diagnostics;
using FirmElect.Bus;
using MailEfirm;
using System.Globalization;
using System.Threading;
using FirmElect.Info;




namespace Efirm
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {







        #region Variables
        frmLogin formLogin;
        tb_sis_Log_Error_Vzen_Bus BusLoginError = new tb_sis_Log_Error_Vzen_Bus();
        static cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;
        #endregion
       
        public frmMain()
        {
            try
            {
                InitializeComponent();
            

            }
            catch (Exception ex)
            {

                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
            


        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        void cargando_perfil_efirm()
        {
            try
            {
                lblNomEjecucion.Text = Convert.ToString(Efirm.Properties.Settings.Default.P_ESTADO_CARGA_EFIRM);

                if (Efirm.Properties.Settings.Default.P_ESTADO_CARGA_EFIRM == "CLIENTE")
                {
                    btnParametros.Enabled = false;
                    btn_token.Enabled = false;
                    btnConfDirectorios.Enabled = false;
                    btnEmisor.Enabled = false;
                    btnAdministradorCbtes.Enabled = false;
                    btnCbtes_para_exportacion.Enabled = false;
                    barConsultaReporte.Enabled = false;
                    

                    //frmRpt_Cbtes_Auto_NoAuto frm = new frmRpt_Cbtes_Auto_NoAuto();
                    //frm.MdiParent = this;
                    //frm.WindowState = FormWindowState.Maximized;
                    //frm.Show();

                    //MailEfirm.Frm_Main_Mail frmMail = new Frm_Main_Mail();
                    //frmMail.set_Perfil(eTipo_Perfil_Usuario.CLIENTE);
                    //frmMail.MdiParent = this;
                    //frmMail.WindowState = FormWindowState.Maximized;
                    //frmMail.Show();


                }
                else
                {
                    frmAdministrador_Cbte_Electronicos frmAdminCbte = new frmAdministrador_Cbte_Electronicos();
                    frmAdminCbte.MdiParent = this;
                    frmAdminCbte.WindowState = FormWindowState.Maximized;
                    frmAdminCbte.Show();


                    MailEfirm.Frm_Main_Mail frmMail = new Frm_Main_Mail();
                    frmMail.set_Perfil(eTipo_Perfil_Usuario.SERVER);
                    frmMail.MdiParent = this;
                    frmMail.WindowState = FormWindowState.Maximized;
                    frmMail.Show();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                cl_parametrosGenerales_Bus BusPara = new cl_parametrosGenerales_Bus();
                string MensajeError = "";
                BusPara.Cargar_Variables_Globales(ref MensajeError);

                try
                {
                    param.AUTORIZADO_ENVIO_CORREO = (Efirm.Properties.Settings.Default.AUTORIZADO_ENVIO_CORREO == "S") ? true : false;
                }
                catch (Exception EX)
                {
                    param.AUTORIZADO_ENVIO_CORREO = false;
                    MessageBox.Show("No existe en el APP confign el parametro:   AUTORIZADO_ENVIO_CORREO  ");
                }

                this.Text = "Efirm Version:" + param.Version;

                if (param.Parametro_Info == null)
                {
                    MessageBox.Show("param.Parametro_Info = null Esta no es la version actual del Efirm consulte con sistema o comuniquece con It-Corp.. version Base:" + param.Parametro_Info.Version + " version Exec:" + param.Version.ToString(), "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;                
                }

                if (param.Parametro_Info.Version != param.Version)
                {
                    MessageBox.Show("Esta no es la version actual del Efirm consulte con sistema o comuniquece con It-Corp.. version Base:" + param.Parametro_Info.Version + " version Exec:" + param.Version.ToString(), "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
                cargando_perfil_efirm();
                
            }
            catch (Exception ex)
            {
                
                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
            
            


        }

        private void btnConfDirectorios_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDirectorios frm = new frmDirectorios();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
        }

        private void btnValidadorFileXML_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmValidadorFileXML frm = new frmValidadorFileXML();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
        }

        private void btnAdmin_cbte_elec_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
                ////frmImportarClavesContin frm = new frmImportarClavesContin();
                //frm.MdiParent = this;
                //frm.Show();
            }
            catch (Exception EX)
            {

            }
        }

        private void btnImprt_claves_con_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //frmImportarClavesContin frm = new frmImportarClavesContin();
                //frm.MdiParent = this;
                //frm.Show();
            }
            catch (Exception EX)
            {

            }

        }

        public Boolean FocusWindo(string NomForm)
        {
            var r = this.MdiChildren;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].Name == NomForm)
                {
                    MdiChildren[i].Activate();
                    return true ;
                }
            }
            return false;
        }

        private void btnParametros_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmParametros frm = new frmParametros();
                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
        }

        private void btn_wsefirm_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                //Process p = new Process();
                //p.StartInfo.FileName = "C:\\FirmaSRI\\EjecutarFirma.bat";
                //p.Start();

            }
            catch (Exception ex)
            {

                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
        }

        private void btnAdministradorCbtes_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmAdministrador_Cbte_Electronicos frm = new frmAdministrador_Cbte_Electronicos();
                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                
                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
            
        }

        private void btn_logError_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btnEmisor_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmEmisor frm = new frmEmisor();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
                
            }
        }

        private void btn_token_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {


                frmTocken frm = new frmTocken();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void btn_Cbtes_Auto_noAuto_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                frmRpt_Cbtes_Auto_NoAuto frm = new frmRpt_Cbtes_Auto_NoAuto();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void btn_ImportarClaveConting_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                frmImportarClavesContin_Consu frm = new frmImportarClavesContin_Consu();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {


            }

        }



        private void btn_Mail_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                MailEfirm.Frm_Main_Mail frm = new Frm_Main_Mail();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Procesos_En_Lotes_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {

                frmImpre_Descar_Anu_Lotes_Cbtes frm = new frmImpre_Descar_Anu_Lotes_Cbtes();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void barbtnCbteRe_ItemClick(object sender, ItemClickEventArgs e)
        {
            //try
            //{

            //    MessageBox.Show("EBIZ en mantenimiento ... Disculpe las molestias ... Este proceso se encuentra en desarrollo ", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                

            //}
            //catch (Exception ex)
            //{


            //}
            try
            {

                frmAdministrador_Comprobantes_recibidos_EBIZ frm = new frmAdministrador_Comprobantes_recibidos_EBIZ();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void btnCbtes_para_exportacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                frmAdministrador_cbtes_Auto_para_exportacion frm = new frmAdministrador_cbtes_Auto_para_exportacion();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void barConsultaReporte_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDisenio_Reporte_Consulta frm = new frmDisenio_Reporte_Consulta();

                if (!FocusWindo(frm.Name))
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());

            }
        }

        private void timerValidarFecha_Tick(object sender, EventArgs e)
        {
            try
            {
                string strMsj = "";
                List<tb_Empresa_Info> lstInfoEmp = new List<tb_Empresa_Info>();
                tb_Empresa_Bus busEmp = new tb_Empresa_Bus();
                timerValidarFecha.Enabled = false;// apago este proceso
                lstInfoEmp = busEmp.ValidarFechaCertificado();
                if (lstInfoEmp.Count > 0)
                {
                    foreach (var item in lstInfoEmp)
                    {
                        if (item.DiasExpirar > 0)
                            strMsj = strMsj +  "El Certificado de la Empresa " + item.NombreComercial + ", le faltan " + item.DiasExpirar + " dias por Expirar. \n";
                        else
                            strMsj = strMsj + "El Certificado de la Empresa " + item.NombreComercial + ", tiene " + item.DiasExpirar + " dias Expirado.  \n";
                    }
                    barMsjValidez.Caption = strMsj;
                }
                else {
                    barMsjValidez.Caption = "";
                }
                timerValidarFecha.Enabled = true;
               
            }
            catch (Exception ex) 
            {
                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
        }
    }
}