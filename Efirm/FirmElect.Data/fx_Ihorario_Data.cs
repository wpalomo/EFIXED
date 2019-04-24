using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
namespace FirmElect.Data
{
    public interface fx_Ihorario_Data
    {
        bool Guarardar_Horario( fx_horario_Info horario);
        bool EliminarConfiguracionHorario();
        fx_horario_Info ObtenerConfiguracion();
    }
}
