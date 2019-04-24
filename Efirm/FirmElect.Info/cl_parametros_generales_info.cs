using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
    public sealed class cl_parametros_generales_info
    {
        static readonly cl_parametros_generales_info instance = new cl_parametros_generales_info();

        public seg_usuario_info info_usuario { get; set; }
        public tb_Empresa_Info info_empresa { get; set; }
        public string nom_sistema { get; set; }
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public static cl_parametros_generales_info Instance
        {
            get { return instance; }
        }

        static cl_parametros_generales_info()
        {

        }

        cl_parametros_generales_info()
        {
            nom_sistema = "Fixed FIRMA";
        }

    }
}
