using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;

namespace FirmElect.Data
{
    public class vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Data
    {

        public List<vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info> GetVwMailCuentas(ref string MensajeErrorOut)
        {
            try
            {
                List<vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info> VwMailCuenta = new List<vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info>();
                EntitiesFactElectronica OEselecView = new EntitiesFactElectronica();
                var selectViewMail = from C in OEselecView.vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo
                                     where C.estado=="A"
                                     orderby C.orden
                                    select C;
                foreach (var item in selectViewMail)
                {
                    vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info vwCMen = new vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info();
                    vwCMen.IdCuenta = item.IdCuenta;
                    vwCMen.Nombre_cuenta = item.Nombre_cuenta;
                    vwCMen.direccion_correo = item.direccion_correo;
                    vwCMen.IdTipo_Mensaje = item.IdTipo_mensaje;
                    vwCMen.descripcion = item.descripcion;
                    vwCMen.orden = Convert.ToInt32(item.orden);
                    vwCMen.Id = item.Id;
                    vwCMen.estado = item.estado;
                    
                    VwMailCuenta.Add(vwCMen);
                }
                return VwMailCuenta;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return new List<vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info>();
            }

        }

    }
}
