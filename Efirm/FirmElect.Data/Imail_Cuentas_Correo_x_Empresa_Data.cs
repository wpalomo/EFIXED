using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
namespace FirmElect.Data
{
   public interface Imail_Cuentas_Correo_x_Empresa_Data
    {

       List<mail_Cuentas_Correo_x_Empresa_Info> Consulta_mail_Cuentas_Correo_x_Empresa(ref string mensaje);
       bool GuardarRelacion(int IdEmisor, string IdCuenta, string Observacion, ref string mensaje);
         
    }
}
