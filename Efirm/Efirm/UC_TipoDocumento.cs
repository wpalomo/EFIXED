using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Bus;
using FirmElect.Info;


namespace Efirm
{
    public partial class UC_TipoDocumento : UserControl
    {
        tb_Comprobante_tipo_Bus BusTipoDoc = new tb_Comprobante_tipo_Bus();
        List<tb_Comprobante_tipo_Info> ListTipoDocumento = new List<tb_Comprobante_tipo_Info>();
        string MensajeError = "";


        public string Get_IdTipoDocumento()
        {
           try
            {
               tb_Comprobante_tipo_Info InfoTipoDoc= ListTipoDocumento.FirstOrDefault(v=>v.IdComprobante_tipo==cmb_tipo_documento.EditValue);
               return InfoTipoDoc.IdComprobante_tipo;
            }
            catch (Exception ex)
            {
                return "";
                
            }
        }



        public tb_Comprobante_tipo_Info Get_InfoTipoDocumento()
        {
            try
            {
                tb_Comprobante_tipo_Info InfoTipoDoc = ListTipoDocumento.FirstOrDefault(v => v.IdComprobante_tipo == cmb_tipo_documento.EditValue);
                return InfoTipoDoc;
            }
            catch (Exception ex)
            {
                return new tb_Comprobante_tipo_Info();

            }
        }

        public UC_TipoDocumento()
        {
            InitializeComponent();
        }


        private void cmb_tipo_documento_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_TipoDocumento_Load(object sender, EventArgs e)
        {
            try
            {

               ListTipoDocumento= BusTipoDoc.consultar_solo_comprobantes(ref MensajeError);
               ListTipoDocumento.Add(new tb_Comprobante_tipo_Info("00", "00", "TODOS"));

               cmb_tipo_documento.Properties.DataSource = ListTipoDocumento;
               cmb_tipo_documento.EditValue = "00";

            }
            catch (Exception ex)
            {
                
                
            }

        }
    }
}
