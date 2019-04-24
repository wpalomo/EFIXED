using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public class cl_error_Info
    {
       public cl_error_Info()
       {
            
       }

       public cl_error_Info(string _Id, string _detalle, string _sfecha, string _Estado, eTipoError _TipoError, eTipoRespuesta _TipoRespuesta)
       {
           Id = _Id;
           detalle = _detalle;
           sfecha = _sfecha;
           Estado = _Estado;
           TipoError = _TipoError;
           TipoRespuesta = _TipoRespuesta;
           sTipoRespuesta = _TipoRespuesta.ToString();
       }
        public string Id { get; set; }
        public string detalle { get; set; }
        public string sfecha { get; set; }
        public string Estado { get; set; }
        public eTipoError TipoError { get; set; }
        public eTipoRespuesta TipoRespuesta { get; set; }
        public string sTipoRespuesta { get; set; }

    }
}
