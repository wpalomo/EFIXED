using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public  class tb_comprobante_exportado_base_ext_Info
    {
        public int IdEmpresa { get; set; }
        public string IdComprobante { get; set; }
        public string IdTipoDocumento { get; set; }
        public string observacion { get; set; }
        public DateTime fecha_hora_exportacion { get; set; }

    }
}
