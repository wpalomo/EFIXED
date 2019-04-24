using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
    public class tb_Actividades_Horario_Tipo_Ejecucion_Data_SQL : Itb_Actividades_Horario_Tipo_Ejecucion_Data
    {

      

        public List<tb_Actividades_Horario_Tipo_Ejecucion_Info> consulta(ref string mensajeErrorOut)
        {
            try
            {


                List<tb_Actividades_Horario_Tipo_Ejecucion_Info> TEjecuacion = new List<tb_Actividades_Horario_Tipo_Ejecucion_Info>();

                EntitiesFactElectronica OEselecEmpresa = new EntitiesFactElectronica();

                var selectEmpresa = from C in OEselecEmpresa.tb_Actividades_Horario_Tipo_Ejecucion
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Actividades_Horario_Tipo_Ejecucion_Info Cbt = new tb_Actividades_Horario_Tipo_Ejecucion_Info();


                    Cbt.IdTipoEjecucion = item.IdTipoEjecucion;
                    Cbt.Descripcion = item.Descripcion;
                    

                    TEjecuacion.Add(Cbt);
                }



                return TEjecuacion;
            }
            catch (Exception ex)
            {


                return new List<tb_Actividades_Horario_Tipo_Ejecucion_Info>();

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                mensajeErrorOut = ex.InnerException + " " + ex.Message;
            }
        }
    }
}
