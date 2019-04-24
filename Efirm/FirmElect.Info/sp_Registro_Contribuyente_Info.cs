using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
    public class sp_Registro_Contribuyente_Info
    {
        [DataMember]
        public string Respuesta { get; set; }
        [DataMember]
        public string Mensaje { get; set; }

         public string HashText { get; set; }

         public string CorreoContribuyente { get; set; }

         public decimal IdContribuyente { get; set; }



         public sp_Registro_Contribuyente_Info()
         {
         }

         public sp_Registro_Contribuyente_Info(string Respuesta_, string Mensaje_, string HashText_, string CorreoContribuyente_)
         {
                Respuesta=Respuesta_;
                Mensaje=Mensaje_;
                HashText=HashText_;
                CorreoContribuyente = CorreoContribuyente_;
         }
    }
}
