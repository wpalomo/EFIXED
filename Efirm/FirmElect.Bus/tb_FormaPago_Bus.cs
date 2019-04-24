using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;

namespace FirmElect.Bus
{
    public class tb_FormaPago_Bus
    {
        string mensajeOut = "";
        tb_FormaPago_Data oData = new tb_FormaPago_Data();

        public tb_FormaPago_info Get_Info_FormaPago(string IdFormaPAgo, ref string mensajeErrorOut)
        {
            try
            {
                return oData.Get_Info_FormaPago(IdFormaPAgo, ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                mensajeOut = ex.Message.ToString();
                tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "", "", "", "", "", DateTime.Now);
                oData.Guardar_Log_Error(Log_Error_sis, ref mensajeOut);
                return new tb_FormaPago_info();
            }
        }
    }
}
