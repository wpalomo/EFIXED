using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
   public  class mail_Cuentas_Correo_Bus
    {
       Imail_Cuentas_Correo_Data Odata;

       public mail_Cuentas_Correo_Bus()
       {
           Odata = new mail_Cuentas_Correo_Data();
       }

       public List<mail_Cuentas_Correo_Info> consultar(ref string mensajeErrorOut)
       {
           try
           {
               return Odata.consultar(ref mensajeErrorOut);
           }
           catch (Exception ex)
           {
               return new List<mail_Cuentas_Correo_Info>();
               
           }
       }


       public bool GuardarCuentaBD(mail_Cuentas_Correo_Info infoCuentas, ref string mensajeErrorOut)
       {
           try
           {

               return Odata.GuardarCuentaBD(infoCuentas, ref mensajeErrorOut);
           }
           catch (Exception)
           {
               return false;
               
           }
       }


       public bool ModificarCuentaBD(mail_Cuentas_Correo_Info infoCuentas, ref string mensajeErrorOut)
       {
           try
           {
               return Odata.ModificarCuentaBD(infoCuentas,ref mensajeErrorOut);
           }
           catch (Exception)
           {

               return false;
           }
       }


       public bool Consulta_Si_CuentaExiste(string idCuenta,ref string mensaje)
       {
           try
           {
               return Odata.Consulta_Si_CuentaExiste(idCuenta,ref mensaje);
           }
           catch (Exception)
           {

               return false;
           }

       }


    }
}
