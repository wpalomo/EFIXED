using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
    public class seg_usuario_x_tb_empresa_info
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }

        public seg_usuario_info info_usuario { get; set; }
        //vista
        public string em_razon_social { get; set; }
        //grillas
        public bool seleccionado { get; set; }

        public seg_usuario_x_tb_empresa_info()
        {
            info_usuario = new seg_usuario_info();
        }
    }
}
