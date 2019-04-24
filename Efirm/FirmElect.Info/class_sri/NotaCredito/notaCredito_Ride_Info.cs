using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FirmElect.Info.class_sri.NotaCredito
{
   public class notaCredito_Ride_Info
    {
        public string Num_Autorizacion { get; set; }
        public DateTime Fecha_Autorizacion { get; set; }
        public notaCredito notaCredito{ get; set; }
        public Image Logo { get; set; }
        public string MAIL { get; set; }
        public string DIRECCION_CLIENTE { get; set; }
        public string REFERENCIA { get; set; }
        public string OBRA { get; set; }
        public string FORMA_PAGO { get; set; }
        public string FECHA_VENCI { get; set; }
        public string observaciones { get; set; }
        public decimal por_iva { get; set; }
        public string numeros_en_letras { get; set; }
        public notaCredito_Ride_Info()
        {
            notaCredito = new notaCredito();
   
        }

    }
}
