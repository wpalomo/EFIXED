using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;
namespace FirmElect.Bus
{
   public class mail_Cuentas_Correo_x_Empresa_Bus
   {
       mail_Cuentas_Correo_x_Empresa_Data Odata;
       public mail_Cuentas_Correo_x_Empresa_Bus()
       {
           Odata = new mail_Cuentas_Correo_x_Empresa_Data();
       }
       
       public List<mail_Cuentas_Correo_x_Empresa_Info> Consulta_mail_Cuentas_Correo_x_Empresa(ref string mensaje)
       {
           try
           {
               return  Odata.Consulta_mail_Cuentas_Correo_x_Empresa(ref  mensaje);
           }
           catch (Exception)
           {

               return new List<mail_Cuentas_Correo_x_Empresa_Info>();
           }
    
       }
       public bool GuardarRelacion(int IdEmisor, string IdCuenta, string Observacion)
       {
           string mensaje="";

           try
           {
               return Odata.GuardarRelacion(IdEmisor, IdCuenta, Observacion,ref mensaje);
           }
           catch (Exception)
           {
               return false;  
               
           }
       }

       public List<mail_Cuentas_Correo_x_Empresa_Info> Consulta_mail_Cuentas_Correo_x_Empresa(int IdEmpresa, ref string mensaje)
       {
           try
           {
               return Odata.Consulta_mail_Cuentas_Correo_x_Empresa(IdEmpresa,ref  mensaje);
           }
           catch (Exception)
           {

               return new List<mail_Cuentas_Correo_x_Empresa_Info>();
           }

       }

    }
}
