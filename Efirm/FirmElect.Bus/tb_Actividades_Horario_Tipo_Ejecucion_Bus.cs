using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
  public   class tb_Actividades_Horario_Tipo_Ejecucion_Bus
    {
      Itb_Actividades_Horario_Tipo_Ejecucion_Data Odata;

      public tb_Actividades_Horario_Tipo_Ejecucion_Bus()
      {
          Odata = new tb_Actividades_Horario_Tipo_Ejecucion_Data_SQL();
      }

      public List<tb_Actividades_Horario_Tipo_Ejecucion_Info> consultar(ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consulta(ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new List<tb_Actividades_Horario_Tipo_Ejecucion_Info>();
          }
      }

    }
}
