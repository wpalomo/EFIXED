using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;

namespace FirmElect.Data
{
    public class tb_FormaPago_Data
    {
        public tb_FormaPago_info Get_Info_FormaPago(string IdFormaPAgo, ref string mensajeErrorOut)
        {
            try
            {
                tb_FormaPago_info Info_Forma_Pago = new tb_FormaPago_info();
                
                using (EntitiesFactElectronica DBFactElec = new EntitiesFactElectronica())
                {
                    var querry2 = from q in DBFactElec.tb_FormaPago
                                  where q.IdFormaPago == IdFormaPAgo
                                  select q;

                    foreach (var item in querry2)
                    {
                        Info_Forma_Pago.IdFormaPago = item.IdFormaPago;
                        Info_Forma_Pago.nombre = item.nombre;
                    }
                }
                return Info_Forma_Pago;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                mensajeErrorOut = ex.InnerException + " " + ex.Message;
                return new tb_FormaPago_info();
            }
        }
    }
}
