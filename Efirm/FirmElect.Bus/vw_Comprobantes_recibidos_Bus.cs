using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;

namespace FirmElect.Bus
{
    public class vw_Comprobantes_recibidos_Bus
    {
        vw_Comprobantes_recibidos_Data Odata;

        public vw_Comprobantes_recibidos_Bus()
        {
            try
            {
                Odata = new vw_Comprobantes_recibidos_Data();
            }
            catch (Exception ex)
            {


            }
        }

        public List<vw_Comprobantes_recibidos_Info> consultar(int indicepagina, int RegistroxPag, DateTime FechaIni, DateTime FechaFin, string CadenaBusqueda, ref string mensajeErrorOut)
        {
            try
            {
                return Odata.Consultar(indicepagina, RegistroxPag,FechaIni,FechaFin, CadenaBusqueda,ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                return new List<vw_Comprobantes_recibidos_Info>();

            }
        }

        public int ObtenerNumPag(int Registro_x_Pag, DateTime FechaIni, DateTime FechaFin,string cadena_Busqueda,  ref string MensajeErrorOut)
        {
            try
            {
                return Odata.ObtenerNumPagina(Registro_x_Pag, FechaIni, FechaFin,cadena_Busqueda, ref MensajeErrorOut);
            }
            catch (Exception)
            {
                return 1;
            }
        }


    }
}
