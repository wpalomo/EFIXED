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
   public class tb_Comprobante_Procesos_externos_GRAFINPREN :Itb_Comprobante_Procesos_externos  
    {   string fecha_a_cambiar_autorizacion;
        string Fecha_cambiada_autorizacion;
        string fecha_a_cambiar_envio_doc;
        string Fecha_cambiada_envio_doc;
        string Formato = "", Fecha_Autorizacion,Fecha_EnvioDoc;
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
                    string serie1="";
                    string serie2 = "";
                    string NumDocumento="";

                    switch (TipoDoc)
                    {
                        // UPDATE A LA TABLA TLEPAR220
                        case "01":
                           
                            serie1 = InfoCbte.IdComprobante.Substring(3, 3);
                            serie2 = InfoCbte.IdComprobante.Substring(7, 3);
                            NumDocumento = InfoCbte.IdComprobante.Substring(11, 9);

                            SQL = "UPDATE fa_factura SET vt_autorizacion='" + InfoCbte.Numero_Autorizacion + "',Fecha_Autorizacion='" + InfoCbte.FechaAutorizacion + "'" +
                                "from vwfa_factura_x_empresa as E "+
                                "where E.IdEmpresa=fa_factura.IdEmpresa "+
                                "and E.vt_serie1=fa_factura.vt_serie1 "+
                                "and E.vt_serie2=fa_factura.vt_serie2 "+
                                "and E.vt_NumFactura=fa_factura.vt_NumFactura " +
                                "and E.em_ruc='" + InfoEmpresa.RUC + "' " +
                                "and E.vt_serie1='" + serie1 + "' " +
                                "and E.vt_serie2 ='" + serie2 + "' " +
                                "and E.vt_NumFactura ='" + NumDocumento + "' ";
                            cmd = new SqlCommand(SQL, conexion);
                            reader = cmd.ExecuteReader();
                            reader.Close();  
                       
                            // actualizo el talonario

                            SQL = "UPDATE tb_sis_Documento_Tipo_Talonario SET NumAutorizacion='" + InfoCbte.Numero_Autorizacion + "'" +
                                "from vwtb_tb_sis_Documento_Tipo_Talonario as E " +
                                "where E.IdEmpresa=tb_sis_Documento_Tipo_Talonario.IdEmpresa " +
                                "and E.Establecimiento=tb_sis_Documento_Tipo_Talonario.Establecimiento " +                                
                                "and E.PuntoEmision=tb_sis_Documento_Tipo_Talonario.PuntoEmision " +
                                "and tb_sis_Documento_Tipo_Talonario.CodDocumentoTipo='FACT'" +
                                "and E.NumDocumento=tb_sis_Documento_Tipo_Talonario.NumDocumento " +
                                "and E.em_ruc='" + InfoEmpresa.RUC + "' " +
                                "and E.Establecimiento='" + serie1 + "' " +
                                "and E.PuntoEmision ='" + serie2 + "' " +
                                "and E.NumDocumento ='" + NumDocumento + "' ";
                            cmd = new SqlCommand(SQL, conexion);
                            reader = cmd.ExecuteReader();
                            reader.Close();  


                            break;

                        case "04":


                            serie1 = InfoCbte.IdComprobante.Substring(3, 3);
                            serie2 = InfoCbte.IdComprobante.Substring(7, 3);
                            NumDocumento = InfoCbte.IdComprobante.Substring(11, 9);
                            SQL = "UPDATE fa_notaCreDeb SET NumAutorizacion='" + InfoCbte.Numero_Autorizacion + "',Fecha_Autorizacion='" + InfoCbte.FechaAutorizacion + "'" +
                                "from vwfa_fa_notaCreDeb_x_empresa as E " +
                                "where E.IdEmpresa=fa_factura.IdEmpresa "+
                                "and fa_notaCreDeb.CreDeb='C'"+
                                "and E.Serie1=fa_factura.Serie1 " +
                                "and E.Serie2=fa_factura.Serie2 " +
                                "and E.NumNota_Impresa=fa_notaCreDeb.NumNota_Impresa " +
                                "and E.em_ruc='" + InfoEmpresa.RUC + "' " +
                                "and E.Serie1='" + serie1 + "' " +
                                "and E.Serie1 ='" + serie2 + "' " +
                                "and E.NumNota_Impresa ='" + NumDocumento + "' ";
                                
                            cmd = new SqlCommand(SQL, conexion);
                            reader = cmd.ExecuteReader();
                            reader.Close();

                            // actualizo el talonario

                            SQL = "UPDATE tb_sis_Documento_Tipo_Talonario SET NumAutorizacion='" + InfoCbte.Numero_Autorizacion + "'" +
                                "from vwtb_tb_sis_Documento_Tipo_Talonario as E " +
                                "where E.IdEmpresa=tb_sis_Documento_Tipo_Talonario.IdEmpresa " +
                                "and E.Establecimiento=tb_sis_Documento_Tipo_Talonario.Establecimiento " +
                                "and E.PuntoEmision=tb_sis_Documento_Tipo_Talonario.PuntoEmision " +
                                "and tb_sis_Documento_Tipo_Talonario.CodDocumentoTipo='NTCR'" +
                                "and E.NumDocumento=tb_sis_Documento_Tipo_Talonario.NumDocumento " +
                                "and E.em_ruc='" + InfoEmpresa.RUC + "' " +
                                "and E.Establecimiento='" + serie1 + "' " +
                                "and E.PuntoEmision ='" + serie2 + "' " +
                                "and E.NumDocumento ='" + NumDocumento + "' ";
                            cmd = new SqlCommand(SQL, conexion);
                            reader = cmd.ExecuteReader();
                            reader.Close();  


                            break;


                        case "07":

                            serie1 = InfoCbte.IdComprobante.Substring(3, 3);
                            serie2 = InfoCbte.IdComprobante.Substring(7, 3);
                            serie1 = serie1 + "-" + serie2;
                            NumDocumento = InfoCbte.IdComprobante.Substring(11, 9);
                            SQL = "UPDATE cp_retencion SET NAutorizacion='" + InfoCbte.Numero_Autorizacion + "',Fecha_Autorizacion='" + InfoCbte.FechaAutorizacion + "'" +
                                "FROM dbo.cp_retencion AS ret INNER JOIN"+
                                  " dbo.vwcp_cp_retencion_x_empresa AS ret_x_emp ON ret.IdEmpresa = ret_x_emp.IdEmpresa AND ret.IdRetencion = ret_x_emp.IdRetencion " +
                                " where em_ruc='" + InfoEmpresa.RUC + "' " +
                                " and serie='" + serie1 + "' " +
                                " and ret.NumRetencion ='" + NumDocumento + "' ";
                                
                            cmd = new SqlCommand(SQL, conexion);
                            reader = cmd.ExecuteReader();
                            reader.Close();


                            // actualizo el talonario

                            SQL = "UPDATE tb_sis_Documento_Tipo_Talonario SET NumAutorizacion='" + InfoCbte.Numero_Autorizacion + "'" +
                                "from vwtb_tb_sis_Documento_Tipo_Talonario as E " +
                                "where E.IdEmpresa=tb_sis_Documento_Tipo_Talonario.IdEmpresa " +
                                "and E.Establecimiento=tb_sis_Documento_Tipo_Talonario.Establecimiento " +
                                "and E.PuntoEmision=tb_sis_Documento_Tipo_Talonario.PuntoEmision " +
                                "and tb_sis_Documento_Tipo_Talonario.CodDocumentoTipo='RETEN'" +
                                "and E.NumDocumento=tb_sis_Documento_Tipo_Talonario.NumDocumento " +
                                "and E.em_ruc='" + InfoEmpresa.RUC + "' " +
                                "and E.Establecimiento='" + serie1 + "' " +
                                "and E.PuntoEmision ='" + serie2 + "' " +
                                "and E.NumDocumento ='" + NumDocumento + "' ";
                            cmd = new SqlCommand(SQL, conexion);
                            reader = cmd.ExecuteReader();
                            reader.Close();  

                            break;



                        case "06":

                            serie1 = InfoCbte.IdComprobante.Substring(3, 3);
                            serie2 = InfoCbte.IdComprobante.Substring(7, 3);
                            serie1 = serie1 + "-" + serie2;
                            NumDocumento = InfoCbte.IdComprobante.Substring(11, 9);
                            SQL = "UPDATE fa_guia_remision SET NUAutorizacion='" + InfoCbte.Numero_Autorizacion + "',Fecha_Autorizacion='" + InfoCbte.FechaAutorizacion + "'" +
                                "from vwfa_fa_guia_remision_x_empresa as E " +
                                "where E.IdEmpresa=fa_guia_remision.IdEmpresa " +
                                "and E.Serie1=fa_guia_remision.Serie1 " +
                                "and E.Serie2=fa_guia_remision.Serie2 " +
                                "and E.NumGuia_Preimpresa=fa_guia_remision.NumGuia_Preimpresa " +
                                "and E.em_ruc='" + InfoEmpresa.RUC + "' " +
                                "and E.Serie1='" + serie1 + "' " +
                                "and E.Serie2='" + serie1 + "' " +
                                "and E.NumGuia_Preimpresa ='" + NumDocumento + "' ";

                            cmd = new SqlCommand(SQL, conexion);
                            reader = cmd.ExecuteReader();
                            reader.Close();


                            // actualizo el talonario

                            SQL = "UPDATE tb_sis_Documento_Tipo_Talonario SET NumAutorizacion='" + InfoCbte.Numero_Autorizacion + "'" +
                                "from vwtb_tb_sis_Documento_Tipo_Talonario as E " +
                                "where E.IdEmpresa=tb_sis_Documento_Tipo_Talonario.IdEmpresa " +
                                "and E.Establecimiento=tb_sis_Documento_Tipo_Talonario.Establecimiento " +
                                "and E.PuntoEmision=tb_sis_Documento_Tipo_Talonario.PuntoEmision " +
                                "and tb_sis_Documento_Tipo_Talonario.CodDocumentoTipo='GUIA'" +
                                "and E.NumDocumento=tb_sis_Documento_Tipo_Talonario.NumDocumento " +
                                "and E.em_ruc='" + InfoEmpresa.RUC + "' " +
                                "and E.Establecimiento='" + serie1 + "' " +
                                "and E.PuntoEmision ='" + serie2 + "' " +
                                "and E.NumDocumento ='" + NumDocumento + "' ";
                            cmd = new SqlCommand(SQL, conexion);
                            reader = cmd.ExecuteReader();
                            reader.Close();

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

        public List<Info.tb_Comprobante_Info> Consultar(int IdEmpresa, ref string MensajeErrorOut, string cadena)
        {
            throw new NotImplementedException();
        }
    }
}
