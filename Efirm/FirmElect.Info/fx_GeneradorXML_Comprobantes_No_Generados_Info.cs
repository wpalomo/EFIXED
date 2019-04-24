using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
  public  class fx_GeneradorXML_Comprobantes_No_Generados_Info
    {
        public bool Checked { get; set; }
        public String id_Comprobante { get; set; }
        public String Nom_vista { get; set; }
        public String Mensaje_Error { get; set; }
        public DateTime Fecha_Carga { get; set; }
    }
}
