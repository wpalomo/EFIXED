using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using System.IO;



namespace FirmElect.Data
{
   public  class tb_sis_Log_Error_Vzen_Data
    {

        string mensaje = "";
        public Boolean Guardar_Log_Error(tb_sis_Log_Error_Vzen_Info Item, ref string mensaje,Boolean GuardarLog=false)
        {
            try
            {

                Boolean Guardar = true;


                if (Item.Tipo == "LOG")
                {
                    Guardar = GuardarLog;
                }

                System.Console.WriteLine("===============================================================\n");
                System.Console.WriteLine("===================== ERROR EN CONSOLA " + DateTime.Now.ToString() + " =================\n");
                System.Console.WriteLine("===============================================================\n");
                System.Console.Write(Item.Detalle);
                grabar_file(Item.Detalle);
                
                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.InnerException + " " + ex.Message + Item.Detalle ;
                grabar_file(mensaje);
                return false;
            }
        }

        private void grabar_file(string mensaje)
        {
            try
            {


                //grabado en un file de log
                string _path ="";

                    try 
                    {	        
		                 var _assembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
                        _path = System.IO.Path.GetDirectoryName(_assembly);
                        _path = _path.Replace("file:\\", "");
                    }
                    catch (Exception ex)
                    {
                        _path = Path.GetTempPath();
		            }

                
                
                 string folderName = _path + "\\LOG_ERRO_EFIRM";

                 try
                 {
                     System.IO.Directory.CreateDirectory(folderName);
                 }
                 catch (Exception ex)
                 { }

                 _path = folderName;
                

                string _file = _path + "\\Log_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + ".txt";
                System.IO.File.WriteAllText(_file, mensaje);





            }
            catch (Exception ex)
            {
                
                
            }
        }

        public void Log_Error(string msg, string IdUsuario, string ip, string nom_pc, DateTime Fecha_Trans)
        {
            try
            {
                string arreglo = ToString();
                var palabras = arreglo.Split(',');
                string clase = "";
                string pantalla = "";
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(msg, eTipoError.ERROR, clase = palabras[0], pantalla = palabras[1],
                    "", IdUsuario, ip, nom_pc, Fecha_Trans);
                string mensaje = "";

                //llamado a la función de grabado de log
                Guardar_Log_Error(Log_Error_sis, ref mensaje);
            }
            catch (Exception ex)
            {

                mensaje = ex.InnerException + " " + ex.Message;

                grabar_file(mensaje);

            }
        }

        public List<tb_sis_Log_Error_Vzen_Info> ObtenerLista_logError()
        {

            try
            {


               

                List<tb_sis_Log_Error_Vzen_Info> lM = new List<tb_sis_Log_Error_Vzen_Info>();
                EntitiesFactElectronica OEselecEmpresa = new EntitiesFactElectronica();

                var selectEmpresa = from C in OEselecEmpresa.tb_sis_Log_Error_Vzen
                                    orderby C.Id descending
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_sis_Log_Error_Vzen_Info Cbt = new tb_sis_Log_Error_Vzen_Info();
                    Cbt.Asamble = item.Asamble;
                    Cbt.Clase = item.Clase;
                    Cbt.Detalle = item.Detalle;
                    
                    Cbt.Fecha_Trans = item.Fecha_Trans;
                    Cbt.Ip = item.Ip;
                    Cbt.Pantalla = item.Pantalla;
                    Cbt.PC = item.PC;
                    Cbt.Tipo = item.Tipo;
                    Cbt.Usuario = item.Usuario;
                    Cbt.Id = item.Id;

                    Cbt.sFecha = item.Fecha_Trans.ToString();

                    lM.Add(Cbt);
                }

                return (lM);
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                grabar_file(mensaje);
                return new List<tb_sis_Log_Error_Vzen_Info>();
            }


        }

        public Boolean Eliminar_Log(ref string mensajeErrorOut)
        {
            try
            {

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Context.Database.ExecuteSqlCommand("delete tb_sis_Log_Error_Vzen ");
                }
                return true;
              
            }
            catch (Exception ex)
            {
                mensajeErrorOut = ex.InnerException + " " + ex.Message;
                grabar_file(mensaje);
                return false;
            }
        }


    }
}
