using FirmElect.Data;
using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Bus
{
    public class sp_consulta_x_cbtes_x_paginas_Bus
    {
        sp_consulta_x_cbtes_x_paginas_Data Data = new sp_consulta_x_cbtes_x_paginas_Data();
        public List<sp_consulta_x_cbtes_x_paginas_Info> sp_consulta_x_cbtes_x_paginas(int IdEmpresa, int Tamanio_Pagina, int Indice_Pagina, string CedulaRuc, String TipoComprobante, String StrinABuscar, DateTime FechaInicio, DateTime FechaFin)
        {
            return Data.sp_consulta_x_cbtes_x_paginas(IdEmpresa, Tamanio_Pagina, Indice_Pagina, CedulaRuc, TipoComprobante, StrinABuscar, FechaInicio, FechaFin);
        }
    }
}
