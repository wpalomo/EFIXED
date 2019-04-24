using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public class tb_Cliente_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public string Razon_Social { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula_RUC { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string EsEmpresa { get; set; }
        public bool Estado { get; set; }

       public tb_Cliente_Info(){}
    }
}
