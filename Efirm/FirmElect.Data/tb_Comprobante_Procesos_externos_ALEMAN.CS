using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FirmElect.Info;
namespace FirmElect.Data
{
    public class tb_Comprobante_Procesos_externos_ALEMAN : Itb_Comprobante_Procesos_externos
    {
        string mensajeErrorOut = "";
        private string idcomprobante_modificado;
        private string final_comprobante;
        private int cod_Error;

        public bool GrabarDB(Info.tb_Comprobante_Info InfoCbte, ref string MensajeErrorOut, string cadena)
        {
            SqlConnection objconexion;
            SqlCommand cmd = new SqlCommand();
            objconexion = new SqlConnection(cadena);
            cmd = new SqlCommand();
            cmd.Connection = objconexion;

            switch (InfoCbte.IdTipoDocumento)
            {
                //facturas,nota credito,nota debito,retencion
                case "01":
                case "04":
                case "05":
                case "07":
                    idcomprobante_modificado = InfoCbte.IdComprobante.Replace("-", "");
                    final_comprobante = idcomprobante_modificado.Substring(2, 15);
                    break;
                //guia de remision
                case "06":
                    idcomprobante_modificado = InfoCbte.IdComprobante.Replace("-", "");
                    final_comprobante = idcomprobante_modificado.Substring(3, 15);
                    break;
                default:
                    break;

            }

            if (InfoCbte.EstadoDoc == "AUTORIZADO")
            {
                cod_Error = 100;
            }
            else
            {
                cod_Error = 10;
            }


            //Elimina registro si existe en base
            bool bandEliminar = P_Elimina_Registro_Existente(final_comprobante, InfoCbte.IdTipoDocumento, cadena);

            //Registra Respuesta

            //cmd.CommandText = "insert into SYP_FE_RESPUESTA_SRI (numDoc,codDoc, FechaAutorizacion, claveAcceso,  numeroautorizacion,  Estado,   Error,RutaArchivo)" +
            //"values( '" + final_comprobante + "','" + InfoCbte.IdTipoDocumento + "','" + InfoCbte.FechaAutorizacion + "'," + 0 + ",'" + InfoCbte.Numero_Autorizacion + "'," +
            //cod_Error + ",'" + InfoCbte.Error + "','" + 0 + "')";

            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Parameters.Clear();
            //try
            //{
            //    objconexion.Open();
            //    cmd.ExecuteNonQuery();
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    return false;

            //}

            try
            {
                using (SqlCommand command = new SqlCommand(
                "INSERT INTO SYP_FE_RESPUESTA_SRI  (numDoc,codDoc, FechaAutorizacion, claveAcceso,  numeroautorizacion,  Estado,   Error,RutaArchivo) " +
                "VALUES(@numDoc,@codDoc, @FechaAutorizacion, @claveAcceso,  @numeroautorizacion,  @Estado,   @Error,@RutaArchivo)",objconexion ))
                {
                    command.Parameters.Add(new SqlParameter("numDoc", final_comprobante));
                    command.Parameters.Add(new SqlParameter("codDoc", InfoCbte.IdTipoDocumento ));
                    command.Parameters.Add(new SqlParameter("FechaAutorizacion", InfoCbte.FechaAutorizacion));
                    command.Parameters.Add(new SqlParameter("claveAcceso", 0));
                    command.Parameters.Add(new SqlParameter("numeroautorizacion", InfoCbte.Numero_Autorizacion));
                    command.Parameters.Add(new SqlParameter("Estado", cod_Error));
                    command.Parameters.Add(new SqlParameter("Error", InfoCbte.Error));
                    command.Parameters.Add(new SqlParameter("RutaArchivo", 0));
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensajeErrorOut = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeErrorOut, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                return false;
            }

            finally
            {
                objconexion.Close();

            }



        }

        private bool P_Elimina_Registro_Existente(string pnumdoc, string codDoc, string cadena)
        {
            SqlConnection objconexion;
            SqlCommand cmd = new SqlCommand();
            objconexion = new SqlConnection(cadena);
            cmd = new SqlCommand();
            cmd.Connection = objconexion;
            cmd.CommandText = "delete from SYP_FE_RESPUESTA_SRI where numdoc = '" + pnumdoc + "' and codDoc = '" + codDoc + "'";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Clear();
            try
            {
                objconexion.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                mensajeErrorOut = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeErrorOut, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                return false;

            }
            finally
            {
                objconexion.Close();

            }



        }


        public List<Info.tb_Comprobante_Info> Consultar(int IdEmpresa, ref string MensajeErrorOut, string cadena)
        {
            throw new NotImplementedException();
        }
    }
}

   
