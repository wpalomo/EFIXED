using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
    public class seg_usuario_info
    {
        public string IdUsuario { get; set; }
        public string us_contrasenia { get; set; }
        public string us_nombre { get; set; }
        public bool estado { get; set; }

        public List<seg_usuario_x_tb_empresa_info> lst_usuario_x_empresa { get; set; }

        public seg_usuario_info()
        {
            lst_usuario_x_empresa = new List<seg_usuario_x_tb_empresa_info>();
        }
    }
}
