using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;
namespace FirmElect.Bus
{
   public class fx_horario_Bus
   {
       fx_Ihorario_Data Odata;

       public bool Guarardar_Horario(fx_horario_Info horario)
       {
           try
           {
               Odata = new fx_horario_Data();
               return Odata.Guarardar_Horario(horario);

           }
           catch (Exception)
           {

               return false;
           }

       }

       public bool EliminarConfiguracionHorario()
       {
           try
           {
               Odata = new fx_horario_Data();
               return Odata.EliminarConfiguracionHorario();

           }
           catch (Exception)
           {

               return false;
           }

       }

       public fx_horario_Info ObtenerConfiguracion()
       {
           try
           {
               Odata = new fx_horario_Data();
               return Odata.ObtenerConfiguracion();

           }
           catch (Exception)
           {

               return new fx_horario_Info();
           }
       }
    }
}
