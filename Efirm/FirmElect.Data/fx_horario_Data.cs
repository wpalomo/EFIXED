using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
namespace FirmElect.Data
{
   public class fx_horario_Data:fx_Ihorario_Data
    {
        public bool Guarardar_Horario(Info.fx_horario_Info horario)
        {
            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    

                }

                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool EliminarConfiguracionHorario()
        {
            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {


                }

                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Info.fx_horario_Info ObtenerConfiguracion()
        {
            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    

                }

                return new fx_horario_Info();

            }
            catch (Exception ex)
            {

                return new fx_horario_Info();
            }
        }
    }
}
