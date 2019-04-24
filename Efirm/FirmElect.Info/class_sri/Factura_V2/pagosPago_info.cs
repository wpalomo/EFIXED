using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info.class_sri.Factura_V2
{
   public class pagosPago_info
    {
       public pagosPago formaPago { get; set; }
       public tb_FormaPago_info Tipo_Forma_Pago { get; set; }

       public pagosPago_info()
       {
           formaPago = new pagosPago();
           Tipo_Forma_Pago = new tb_FormaPago_info();
       }
    }
}
