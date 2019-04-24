using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public  class tb_Comprobante_tipo_Info
    {

       public string IdComprobante_tipo { get; set; }
       public string cod_tipo { get; set; }
       public string descripcion_tipo { get; set; }
       public string IdComprobante { get; set; }
       public byte[] ReporteBy { get; set; }
       public int IdEmpresa { get; set; }
       public string Empresa { get; set; }

       public tb_Comprobante_tipo_Info()
       {

       }
       public tb_Comprobante_tipo_Info(string IdComprobante_tipo_, string cod_tipo_, string descripcion_tipo_)
       {
           IdComprobante_tipo = IdComprobante_tipo_;
           cod_tipo = cod_tipo_;
           descripcion_tipo = descripcion_tipo_;
       }
   }
}
