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
    public partial class frmTest : Form
    {
        tb_sis_Log_Error_Vzen_Bus BusLoginError = new tb_sis_Log_Error_Vzen_Bus();
        static cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            try
            {
                string MensajeErrpr = "";
                cl_parametrosGenerales_Bus BusPara = new cl_parametrosGenerales_Bus();
                BusPara.Cargar_Variables_Globales(ref MensajeErrpr);

                this.Text = "Efirm Version:" + param.Version;


                if (param.Parametro_Info.Version != param.Version)
                {
                    MessageBox.Show("Esta no es la version actual del Efirm consulte con sistema o comuniquece con It-Corp.. version Base:" + param.Parametro_Info.Version + " version Exec:" + param.Version.ToString(), "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

            //    cargando_perfil_efirm();


            }
            catch (Exception ex)
            {

                BusLoginError.Log_Error(ex.Message, eTipoError.ERROR, this.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
