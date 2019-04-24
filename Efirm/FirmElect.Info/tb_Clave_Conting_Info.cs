using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public  class tb_Clave_Conting_Info
    {

       public int IdEmpresa { get; set; }
       public decimal IdClave { get; set; }
       public bool Usado { get; set; }
       public DateTime Fecha_Trans { get; set; }
       public string ClaveContingencia { get; set; }
       public DateTime Fecha_Importacion { get; set; }
       public bool Estado { get; set; }
       public int ? IdAmbiente { get; set; }

       public string nomAmbiente { get; set; }
       public string RazonSocial { get; set; }

       


    }
}
