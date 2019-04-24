using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Data
{
    public class sp_consulta_x_cbtes_x_paginas_Data
    {
        public List<sp_consulta_x_cbtes_x_paginas_Info> sp_consulta_x_cbtes_x_paginas(int IdEmpresa, int Tamanio_Pagina, int Indice_Pagina, string CedulaRuc,String TipoComprobante,String StrinABuscar,DateTime FechaInicio,DateTime FechaFin) 
        {
            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {

                    string SQL = string.Format("exec  sp_consulta_x_cbtes_x_paginas {0},{1},{2},'{3}','{4}','{5}','{6}','{7}'", IdEmpresa, Tamanio_Pagina, Indice_Pagina, CedulaRuc, TipoComprobante, StrinABuscar, FechaInicio.ToString("yyyy-MM-dd"), FechaFin.ToString("yyyy-MM-dd"));
                    List<sp_consulta_x_cbtes_x_paginas_Info> Result = conexion.Database.SqlQuery<sp_consulta_x_cbtes_x_paginas_Info>(SQL).ToList();
                    return Result;
                }
            }
            catch (Exception)
            {

                return new List<sp_consulta_x_cbtes_x_paginas_Info>();
            }
        }
    }
}
