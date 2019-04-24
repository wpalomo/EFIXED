using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
    public class seg_menu_x_tb_empresa_x_seg_usuario_info
    {
        public int IdEmpresa { get; set; }
        public int IdMenu { get; set; }
        public string IdUsuario { get; set; }
        public bool nuevo { get; set; }
        public bool modificar { get; set; }
        public bool consultar { get; set; }
        public bool anular { get; set; }

        //grilla
        public bool seleccionado { get; set; }

        public seg_menu_info info_menu { get; set; }

        public seg_menu_x_tb_empresa_x_seg_usuario_info()
        {
            info_menu = new seg_menu_info();
        }
    }
}
