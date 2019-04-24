using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;
using System.IO;



namespace FirmElect.Bus
{
   public  class tb_sis_Log_Error_Vzen_Bus
    {

        tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
        cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;


        public tb_sis_Log_Error_Vzen_Bus()
        {

        }

        public void Log_Error(string msg,eTipoError TipoError,string clase,string mensaje2=null,Boolean GuardarLog=false)
        {
            try
            {

                string mensaje = "";
                Boolean Guardar = true;


                if (TipoError == eTipoError.LOG)
                {
                    if (param.Parametro_Info != null)
                    {
                        if (param.Parametro_Info.Registra_Log == false || param.Parametro_Info.Registra_Log==null)
                        {
                            Guardar = false;
                        }
                        
                    }

                    
                }


                


                if (Guardar == true)
                {

                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(msg, TipoError, clase, mensaje2,
                            "", "", "", "", DateTime.Now);

                    oData.Guardar_Log_Error(Log_Error_sis, ref msg, true);
                  
                }



            }
            catch (Exception ex)
            {

                //_path = Path.GetTempPath();
                string RutaFile = Path.GetTempPath();
                string _file = RutaFile + "\\Log_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + ".txt";
                System.IO.File.WriteAllText(_file, msg );
                
            }
            


            

        }


       


        public List<tb_sis_Log_Error_Vzen_Info> ObtenerLista_logError()
        {
            try
            {
                return oData.ObtenerLista_logError();
            }
            catch (Exception ex)
            {
                return new List<tb_sis_Log_Error_Vzen_Info>();
            }
        }

        public Boolean Eliminar_Log(ref string mensajeErrorOut)
        {
            try
            {
                return oData.Eliminar_Log(ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                return false;
                
            }
        }
    }
}
