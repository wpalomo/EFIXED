using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;


namespace FirmElect.Bus
{
  public   class fx_funciones_files_Bus
    {

      public Boolean copiar_mover_eliminar_archivos_x_cbtes(string PathFuente, string PathDestino, string NombreFile,ref  string MensajeError)
      {
          try
          {
              string NombreFile_local = "";
              //string PathFuente = param.RutaComprobantesRepositorio;
              //string PathDestino = param.RutaComprobantesValidos;


              // Use Path class to manipulate file and directory paths.
              string ArchivoFuente = System.IO.Path.Combine(PathFuente, NombreFile);
              string ArchivoDestino = System.IO.Path.Combine(PathDestino, NombreFile);

              // To copy a folder's contents to a new location:
              // Create a new target folder, if necessary.
              if (!System.IO.Directory.Exists(PathDestino))
              {
                  System.IO.Directory.CreateDirectory(PathDestino);
              }

              // To copy a file to another location and 
              // overwrite the destination file if it already exists.
              System.IO.File.Copy(ArchivoFuente, ArchivoDestino, true);

              //       in this code example.
              if (System.IO.Directory.Exists(PathFuente))
              {
                  string[] files = System.IO.Directory.GetFiles(PathFuente);

                  // Copy the files and overwrite destination files if they already exist.
                  foreach (string s in files)
                  {
                      //copio solo el archivo que me dice el parametro de entrada

                      NombreFile_local = System.IO.Path.GetFileName(s);

                      if (NombreFile_local == NombreFile)
                      {
                          ArchivoDestino = System.IO.Path.Combine(PathDestino, NombreFile);
                          System.IO.File.Copy(s, ArchivoDestino, true);
                      }
                  }

                  //una vez q lo copio lo borro del origen 

                  if (System.IO.File.Exists(PathFuente + "\\" + NombreFile))
                  {
                      // Use a try block to catch IOExceptions, to
                      // handle the case of the file already being
                      // opened by another process.
                      try
                      {
                          System.IO.File.Delete(PathFuente + "\\" + NombreFile);
                      }
                      catch (System.IO.IOException e)
                      {
                          Console.WriteLine(e.Message);
                          return false;
                      }
                  }


              }
              else
              {
                  Console.WriteLine("Source path does not exist!");
              }

              return true;

          }
          catch (Exception ex)
          {

              
              

              #region Log de Errores
              MensajeError = ex.Message;
              tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "",
                  "", "", "", "", DateTime.Now);
              oData.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              #endregion

              return false;

          }
      }

      public Boolean Crear_file(string Ruta_destino, string NombreFile,string Lineas_Mensaje,ref string MensajeError)
      {
          try
          {
                string lines = Lineas_Mensaje;

                // Write the string to a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter(Ruta_destino +"\\"+ NombreFile);
                file.WriteLine(lines);

                file.Close();

                return true;

          }
          catch (Exception ex)
          {
              #region Log de Errores
              MensajeError = ex.Message;
              tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "",
                  "", "", "", "", DateTime.Now);
              oData.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              #endregion

              return false;
              

              
          }
      
      }

    }
}
