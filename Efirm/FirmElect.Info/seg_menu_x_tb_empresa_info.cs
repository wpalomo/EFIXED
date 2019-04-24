using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
    public class seg_menu_x_tb_empresa_info
    {
        public int IdEmpresa { get; set; }
        public int IdMenu { get; set; }
        public bool estado { get; set; }

        public bool seleccionado { get; set; }
        public seg_menu_info info_menu { get; set; }

        public seg_menu_x_tb_empresa_info()
        {
            info_menu = new seg_menu_info();
        }
    }
}
