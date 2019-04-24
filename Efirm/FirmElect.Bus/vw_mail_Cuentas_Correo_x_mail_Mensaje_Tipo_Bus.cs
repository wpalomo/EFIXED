using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;

namespace FirmElect.Bus
{
    public class vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Bus
    {

        vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Data Data = new vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Data();
        public vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Bus(){

        }

        public List<vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info> GetVwMailCuentas(ref string MensajeErrorOut) 
        {
            try
            {

                return Data.GetVwMailCuentas(ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        
        }



    }
}
