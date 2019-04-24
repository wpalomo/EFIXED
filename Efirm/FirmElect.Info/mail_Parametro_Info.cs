using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public class mail_Parametro_Info
    {
       public string IdParametro { get; set; }
       public int valor_min_envi_recep_aut { get; set; }
       public bool envio_recep_aut_salir { get; set; }
       public bool ? enviar_solo_pdf_ride { get; set; }
       public bool ? enviar_solo_xml_ride { get; set; }

    }
}
