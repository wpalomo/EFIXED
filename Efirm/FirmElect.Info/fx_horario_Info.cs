using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
  public  class fx_horario_Info
  {
      public int id_horario { get; set; }
      public bool lunes { get; set; }
      public bool martes { get; set; }
      public bool miercoles { get; set; }
      public bool jueves { get; set; }
      public bool viernes { get; set; }
      public bool sabado { get; set; }
      public bool domingo { get; set; }
      public bool ocurre_1_vez { get; set; }
      public TimeSpan valor_ocurre_1_vez { get; set; }
      public bool ocurra_cada { get; set; }
      public Int32 valor_ocurre_cada { get; set; }
      public TimeSpan hora_inicia_a_las { get; set; }
      public TimeSpan hora_finaliza_a_las { get; set; }
      public string tipo_ejecucion { get; set; }
      public string tipo_frecuencia_ocurrencia { get; set; }
      public Int32 DiasRestaFecha { get; set; }
    }
}
