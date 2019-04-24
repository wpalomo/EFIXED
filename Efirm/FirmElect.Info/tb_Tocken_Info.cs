using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
  public  class tb_Tocken_Info
    {
      public string IdTocken { get; set; }
      public string nom_tocken { get; set; }
      public string Password { get; set; }
      public string Serie { get; set; }
      public string Modelo { get; set; }
      public string IdTipo { get; set; }
      public string Estado { get; set; }
      public string IdTocken_para_xml { get; set; }

      public string IdTockenAUX { get; set; }


      public int secuencial { get; set; }
                   
      public   tb_Tocken_Info(){}
    }
}
