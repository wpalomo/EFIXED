using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
    public class tb_Actividades_Horario_Acciones_Data_SQL : Itb_Actividades_Horario_Acciones_Data
    {

        

        List<tb_Actividades_Horario_Acciones_Info> Itb_Actividades_Horario_Acciones_Data.Consultar(string sIdTransaccion, ref string mensajeErrorOut)
        {
            try
            {



                List<tb_Actividades_Horario_Acciones_Info> listAcciones = new List<tb_Actividades_Horario_Acciones_Info>();

                EntitiesFactElectronica OEselecEmpresa = new EntitiesFactElectronica();

                var selectEmpresa = from C in OEselecEmpresa.tb_Actividades_Horario_Acciones
                                    where C.IdTransaccion == sIdTransaccion
                                    orderby C.Secuencia_ejecucion
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Actividades_Horario_Acciones_Info Cbt = new tb_Actividades_Horario_Acciones_Info();


                    Cbt.IdTransaccion = item.IdTransaccion;
                    Cbt.IdAccion = item.IdAccion;
                    Cbt.Descripcion = item.Descripcion;
                    Cbt.TiempoEspera = item.TiempoEspera;
                    Cbt.Secuencia_ejecucion = item.Secuencia_ejecucion;
                  

                    listAcciones.Add(Cbt);
                }




                return listAcciones;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                mensajeErrorOut = ex.InnerException + " " + ex.Message;
                return new List<tb_Actividades_Horario_Acciones_Info>();
            }
        }


        public bool GrabarDB(List<tb_Actividades_Horario_Acciones_Info> ListInfo, ref string mensajeErrorOut)
        {
            try
            {

                string IdTransaccion = "";

                foreach (var item in ListInfo)
                {
                    IdTransaccion = item.IdTransaccion;
                }


                using (EntitiesFactElectronica Entity = new EntitiesFactElectronica())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete from tb_Actividades_Horario_Acciones where IdTransaccion='" + IdTransaccion + "'");
                }



                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    foreach (var item in ListInfo)
                    {
                        var Address = new tb_Actividades_Horario_Acciones();
                        Address.IdTransaccion=item.IdTransaccion;
                        Address.IdAccion=item.IdAccion;
                        Address.Descripcion=item.Descripcion;
                        Address.TiempoEspera = item.TiempoEspera;
                        Address.Secuencia_ejecucion = item.Secuencia_ejecucion;

                        Context.tb_Actividades_Horario_Acciones.Add(Address);
                        Context.SaveChanges();
                    }
                }

                


                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                mensajeErrorOut = ex.InnerException + " " + ex.Message;
                return false;
                
            }
        }

    }
}
