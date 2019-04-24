using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
namespace FirmElect.Data
{
    public class tb_Comprobante_Procesos_externos_Toyocosta : Itb_Comprobante_Procesos_externos
    {
        private string idcomprobante_modificado;
        private string final_comprobante;
        private int cod_Error;

        public bool GrabarDB(Info.tb_Comprobante_Info InfoCbte, ref string MensajeErrorOut, string cadena)
        {
           

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


            try
            {
                using (OracleConnection con = new OracleConnection(cadena))
                {
                    using (OracleCommand command = new OracleCommand(
                    "INSERT INTO SYP_FE_RESPUESTA_SRI  (numDoc,codDoc, FechaAutorizacion, claveAcceso,numeroautorizacion,  Estado,   Error,RutaArchivo) " +
                    "VALUES(:numDoc,:codDoc, :FechaAutorizacion, :claveAcceso,  :numeroautorizacion,  :Estado,   :Error,:RutaArchivo)", con))
                    {
                        command.Parameters.Add ("numDoc",OracleType.VarChar ,17 ).Value = final_comprobante;
                        command.Parameters.Add("codDoc", OracleType.VarChar, 2).Value = InfoCbte.IdTipoDocumento;
                        command.Parameters.Add("FechaAutorizacion",OracleType.DateTime ,50).Value =Convert.ToDateTime ( InfoCbte.FechaAutorizacion);
                        command.Parameters.Add("claveAcceso",OracleType.VarChar, 49).Value = "0";
                        command.Parameters.Add("numeroautorizacion",OracleType.VarChar, 37).Value = InfoCbte.Numero_Autorizacion;
                        command.Parameters.Add("Estado",OracleType.Int32 ).Value = cod_Error;
                        command.Parameters.Add("Error", OracleType.NVarChar , 2000).Value =InfoCbte.Error;
                        command.Parameters.Add("RutaArchivo", OracleType.NVarChar, 2000).Value ="0";
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                        return true;
                    } 
                }
            }
            catch (Exception ex)
            {
                return false;
            }

       



        }

        private bool P_Elimina_Registro_Existente(string pnumdoc, string codDoc, string cadena)
        {
           OracleConnection  objconexion;
           OracleCommand  cmd = new OracleCommand();
            objconexion = new OracleConnection (cadena);
            cmd = new OracleCommand();
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