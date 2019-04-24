using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
    public class seg_menu_info
    {
        public int IdMenu { get; set; }
        public Nullable<int> IdMenu_padre { get; set; }
        public string me_nombre { get; set; }
        public bool me_es_menu { get; set; }
        public string me_nom_formulario { get; set; }
        public string me_nom_assembly { get; set; }
        public int me_nivel { get; set; }
        public bool me_estado { get; set; }
    }
}
