using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
   public  interface Imail_Cuentas_Correo_Data
    {

       List<mail_Cuentas_Correo_Info>  consultar(ref string mensajeErrorOut);

       bool GuardarCuentaBD(mail_Cuentas_Correo_Info infoCuentas, ref string mensajeErrorOut);

       bool ModificarCuentaBD(mail_Cuentas_Correo_Info infoCuentas, ref string mensajeErrorOut);

       bool Consulta_Si_CuentaExiste(string idCuenta,ref string mensaje);      
    }

    
}
