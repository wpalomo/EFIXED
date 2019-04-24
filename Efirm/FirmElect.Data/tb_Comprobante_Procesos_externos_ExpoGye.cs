using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using FirmElect.Info;
using FirmElect.Data;
namespace FirmElect.Data
{
    public class tb_Comprobante_Procesos_externos_ExpoGye : Itb_Comprobante_Procesos_externos
    {

        string fecha_a_cambiar_autorizacion;
        string Fecha_cambiada_autorizacion;


        string fecha_a_cambiar_envio_doc;
        string Fecha_cambiada_envio_doc;

            string Formato = "", Fecha_Autorizacion, Fecha_EnvioDoc;

            public bool GrabarDB(Info.tb_Comprobante_Info InfoCbte, ref string MensajeErrorOut, string cadena)
            {


                tb_comprobante_exportado_base_ext_Data DataCbte_Expo = new tb_comprobante_exportado_base_ext_Data();
                tb_comprobante_exportado_base_ext_Info InfoCbte_Expo = new tb_comprobante_exportado_base_ext_Info();


                tb_Empresa_Info InfoEmpresa = new tb_Empresa_Info();
                tb_Empresa_Data EmpresaData = new tb_Empresa_Data();
                string SQL = "", id_Comprobante = "", TipoDoc = "";


                InfoEmpresa = EmpresaData.GetEmpresa(InfoCbte.IdEmpresa, ref MensajeErrorOut);
                Formato = InfoEmpresa.Formato_fecha_Base_ext;

                // cambio el formato de la fecha de  autorizacion del documento
                fecha_a_cambiar_autorizacion = InfoCbte.FechaAutorizacion.ToString();
                Fecha_cambiada_autorizacion = Convert.ToDateTime(fecha_a_cambiar_autorizacion).ToString(Formato + " " + "HH:mm:ss");
                Fecha_Autorizacion = Fecha_cambiada_autorizacion.ToString();
                // cambio el formato de la fecha de envio del documento

                fecha_a_cambiar_envio_doc = InfoCbte.Fecha_transaccion.ToString();
                Fecha_cambiada_envio_doc = Convert.ToDateTime(fecha_a_cambiar_envio_doc).ToString(Formato + " " + "HH:mm:ss");
                Fecha_cambiada_envio_doc = Fecha_cambiada_envio_doc.ToString();
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        SqlCommand cmd = new SqlCommand();
                        SqlDataReader reader = null;


                        conexion.Open();
                        TipoDoc = InfoCbte.IdTipoDocumento;
                        switch (TipoDoc)
                        {

                            case "01":
                                id_Comprobante = "FC " + InfoCbte.IdComprobante.Substring(3, 3) + "-" + InfoCbte.IdComprobante.Substring(7, 3) + "-" + InfoCbte.IdComprobante.Substring(11, 9);
                                #region integracion antigua
                                // UPDATE A LA TABLA TLEPAR220
                                //SQL = "UPDATE TLEPAR220 SET T_AUTO='" + InfoCbte.Numero_Autorizacion + "',T_FEEN='" + Fecha_cambiada_envio_doc + "',T_FECO='" + Fecha_Autorizacion + "',T_FERE='" + Fecha_Autorizacion + "',T_STAT='5'" +
                                //  "WHERE T_NINV = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                // cmd = new SqlCommand(SQL, conexion);
                                // reader = cmd.ExecuteReader();
                                // reader.Close();


                                // // UPDATE A LA TABLA TLEPAR221
                                //   id_Comprobante = "F_" + InfoCbte.IdComprobante.Substring(3, 3) + InfoCbte.IdComprobante.Substring(7, 3) + InfoCbte.IdComprobante.Substring(11, 9);

                                //   SQL = "UPDATE TLEPAR221 SET T_AUTO='" + InfoCbte.Numero_Autorizacion + "',T_FEEN='" + Fecha_cambiada_envio_doc + "',T_FECO='" + Fecha_Autorizacion + "',T_FERE='" + Fecha_Autorizacion + "',T_STAT='5'" +
                                //   "WHERE T_NINV = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                //   cmd = new SqlCommand(SQL, conexion);
                                //   reader = cmd.ExecuteReader();
                                //   reader.Close();
                                #endregion

                                // UPDATE A LA TABLA custInvoiceJour
                                SQL = "UPDATE custInvoiceJour SET MNT_EInvoiceAuthNum='" + InfoCbte.Numero_Autorizacion + "',MNT_EInvoiceAuthDate='" + Fecha_Autorizacion + "',MNT_EInvoiceStatusId='2'" + "WHERE INVOICEID = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                cmd = new SqlCommand(SQL, conexion);
                                reader = cmd.ExecuteReader();
                                reader.Close();


                                // UPDATE A LA TABLA ProjInvoiceJour
                                id_Comprobante = "FC " + InfoCbte.IdComprobante.Substring(3, 3) + "-" + InfoCbte.IdComprobante.Substring(7, 3) + "-" + InfoCbte.IdComprobante.Substring(11, 9);

                                SQL = "UPDATE ProjInvoiceJour SET MNT_EInvoiceAuthNum='" + InfoCbte.Numero_Autorizacion + "',MNT_EInvoiceAuthDate='" + Fecha_Autorizacion + "',MNT_EInvoiceStatusId='2'" + "WHERE PROJINVOICEID = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                cmd = new SqlCommand(SQL, conexion);
                                reader = cmd.ExecuteReader();
                                reader.Close();
                                break;

                            case "04":

                                id_Comprobante = "NC " + InfoCbte.IdComprobante.Substring(3, 3) + "-" + InfoCbte.IdComprobante.Substring(7, 3) + "-" + InfoCbte.IdComprobante.Substring(11, 9);
                                #region integracion antigua
                                // UPDATE EN LA TABLA TLEPAR220
                                //SQL = "UPDATE TLEPAR220 SET T_AUTO='" + InfoCbte.Numero_Autorizacion + "',T_FEEN='" + Fecha_cambiada_envio_doc + "',T_FECO='" + Fecha_Autorizacion + "',T_FERE='" + Fecha_Autorizacion + "',T_STAT='5'" +
                                // "WHERE T_NINV = '" + id_Comprobante + "' AND DATAAREAID ='expg'";

                                //cmd = new SqlCommand(SQL, conexion);
                                //reader = cmd.ExecuteReader();
                                //reader.Close();


                                //// UPDATE EN LA TABLA TLEPAR221
                                // id_Comprobante = "NC_" + InfoCbte.IdComprobante.Substring(3, 3) + InfoCbte.IdComprobante.Substring(7, 3) + InfoCbte.IdComprobante.Substring(11, 9);

                                // SQL = "UPDATE TLEPAR221 SET T_AUTO='" + InfoCbte.Numero_Autorizacion + "',T_FEEN='" + Fecha_cambiada_envio_doc + "',T_FECO='" + Fecha_Autorizacion + "',T_FERE='" + Fecha_Autorizacion + "',T_STAT='5'" +
                                // "WHERE T_NINV = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                // cmd = new SqlCommand(SQL, conexion);
                                // reader = cmd.ExecuteReader();
                                // reader.Close();
                                #endregion

                                // UPDATE A LA TABLA custInvoiceJour
                                SQL = "UPDATE custInvoiceJour SET MNT_EInvoiceAuthNum='" + InfoCbte.Numero_Autorizacion + "',MNT_EInvoiceAuthDate='" + Fecha_Autorizacion + "',MNT_EInvoiceStatusId='2'" + "WHERE INVOICEID = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                cmd = new SqlCommand(SQL, conexion);
                                reader = cmd.ExecuteReader();
                                reader.Close();

                                // UPDATE A LA TABLA ProjInvoiceJour
                                id_Comprobante = "NC " + InfoCbte.IdComprobante.Substring(3, 3) + "-" + InfoCbte.IdComprobante.Substring(7, 3) + "-" + InfoCbte.IdComprobante.Substring(11, 9);

                                SQL = "UPDATE ProjInvoiceJour SET MNT_EInvoiceAuthNum='" + InfoCbte.Numero_Autorizacion + "',MNT_EInvoiceAuthDate='" + Fecha_Autorizacion + "',MNT_EInvoiceStatusId='2'" + "WHERE PROJINVOICEID = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                cmd = new SqlCommand(SQL, conexion);
                                reader = cmd.ExecuteReader();
                                reader.Close();

                                break;

                            case "07":


                                id_Comprobante = InfoCbte.IdComprobante.Substring(3, 3) + "-" + InfoCbte.IdComprobante.Substring(7, 3) + "-" + InfoCbte.IdComprobante.Substring(11, 9);

                                SQL = "UPDATE MNT_OCRetentionTable SET MNT_EInvoiceAuthNum='" + InfoCbte.Numero_Autorizacion + "',MNT_EInvoiceAuthDate='" + Fecha_Autorizacion + "',MNT_EInvoiceStatusId='2'" + "WHERE NUMCHECKRETENTION = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                cmd = new SqlCommand(SQL, conexion);
                                reader = cmd.ExecuteReader();
                                reader.Close();

                                #region integracion antigua
                                // // UPDATE EN LA TABLA TLEPAR220
                                // SQL = "UPDATE TLEPAR220 SET T_AUTO='" + InfoCbte.Numero_Autorizacion + "',T_FEEN='" + Fecha_cambiada_envio_doc + "',T_FECO='" + Fecha_Autorizacion + "',T_FERE='" + Fecha_Autorizacion + "',T_STAT='5'" +
                                // "WHERE T_NINV = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                // cmd = new SqlCommand(SQL, conexion);
                                // reader = cmd.ExecuteReader();
                                // reader.Close();

                                // // UPDATE EN LA TABLA TLEPAR223
                                // id_Comprobante = InfoCbte.IdComprobante.Substring(3, 3) + InfoCbte.IdComprobante.Substring(7, 3) + InfoCbte.IdComprobante.Substring(11, 9);
                                // SQL = "UPDATE TLEPAR222 SET T_AUTO='" + InfoCbte.Numero_Autorizacion + "',T_FEEN='" + Fecha_cambiada_envio_doc + "',T_FECO='" + Fecha_Autorizacion + "',T_FERE='" + Fecha_Autorizacion + "',T_STAT='5'" +
                                // "WHERE T_NINV = '" + id_Comprobante + "' AND DATAAREAID ='expg'";
                                // cmd = new SqlCommand(SQL, conexion);
                                // reader = cmd.ExecuteReader();
                                // reader.Close();
                                #endregion

                                break;

                            default:
                                break;

                        }
                    }


                    InfoCbte_Expo.IdEmpresa = InfoCbte.IdEmpresa;
                    InfoCbte_Expo.IdComprobante = InfoCbte.IdComprobante;
                    InfoCbte_Expo.IdTipoDocumento = InfoCbte.IdTipoDocumento;
                    InfoCbte_Expo.observacion = "exportado por efirm";
                    InfoCbte_Expo.fecha_hora_exportacion = DateTime.Now;
                    DataCbte_Expo.GrabarDB(InfoCbte_Expo, ref MensajeErrorOut);

                    return true;
                }
                catch (Exception ex)
                {
                    MensajeErrorOut = ex.Message;
                    return false;
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