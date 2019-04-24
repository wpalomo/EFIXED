using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public class vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info
    {

        public string Id { get; set; }
       public string IdCuenta { get; set; }
       public string Nombre_cuenta { get; set; }
       public string direccion_correo { get; set; }
       public string IdTipo_Mensaje { get; set; }
       public string descripcion { get; set; }
       public int orden { get; set; }
       public string estado { get; set; }



        public  vw_mail_Cuentas_Correo_x_mail_Mensaje_Tipo_Info(){
        
        }
    }
}
