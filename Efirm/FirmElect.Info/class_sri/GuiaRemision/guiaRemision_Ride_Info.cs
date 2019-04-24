using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FirmElect.Info.class_sri.GuiaRemision
{
    public class guiaRemision_Ride_Info
    {
        public string Num_Autorizacion { get; set; }
        public DateTime Fecha_Autorizacion { get; set; }
        public guiaRemision guiaremision { get; set; }
        public Image Logo { get; set; }
        public string MAIL { get; set; }
        public string DESTINO { get; set; }
        public string REFERENCIA { get; set; }
        public string OBRA { get; set; }
        public string FORMA_PAGO { get; set; }
        public string FECHA_VENCI { get; set; }
        public string observaciones { get; set; }
        public string numeros_en_letras { get; set; }

        public guiaRemision_Ride_Info()
        {
            guiaremision = new guiaRemision();
        }
    }
}
