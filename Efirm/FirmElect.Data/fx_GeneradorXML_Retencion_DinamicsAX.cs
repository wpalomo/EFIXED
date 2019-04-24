using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FirmElect.Info.class_sri.Retencion;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info;
namespace FirmElect.Data
{
   public class fx_GeneradorXML_Retencion_DinamicsAX:fx_GeneradorXML_IRetencion
   {
       List<tb_Empresa_Info> lista_empresas_fx = new List<tb_Empresa_Info>();
       tb_Empresa_Data data_empresa = new tb_Empresa_Data();
       string campoAdicional = null; string secuencia = null;
       string ruc = "", Rz = "", Nomcom = "", contspecia = "", direccion = "", IdComprobanteError = "";
       string OconEfirm = "";
       string sql = ""; string Ocon = "";

       public List<comprobanteRetencion> GenerarXmlRetencion(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB)
       {

           #region conexion de base detos efrim
           try
           {
               using (SqlConnection co = new SqlConnection(OconEfirm))
               {
                   co.Open();
                   sql = "select RUC,RAZONSOCIAL,NOMBRECOMERCIAL,DIRMATRIZ,CONTRIBUYENTEESPECIAL from tb_Empresa where RUC ='0992496797001'";
                   SqlCommand cmd = new SqlCommand(sql, co);
                   SqlDataReader reader = cmd.ExecuteReader();
                   if (reader.Read())
                   {
                       ruc = reader.GetString(0);
                       Rz = reader.GetString(1);
                       Nomcom = reader.GetString(2);
                       direccion = reader.GetString(3);
                       contspecia = reader.GetString(4);
                   }
                   co.Close();
                   reader.Close();
               }
           }
           catch (Exception ex)
           {
           }
           #endregion
           // formato fecha

           string sFi, sFf;
           sFi = string.Format(formatoFechaDB, FechaIni);
           sFf = string.Format(formatoFechaDB, FechaFin);

         



           try
           {
               List<comprobanteRetencion> lista = new List<comprobanteRetencion>();
               using (SqlConnection conexion = new SqlConnection(ConexionDBCliente))
               {
                   conexion.Open();
                   string sqlcabFact = "select * from ELECTRONICA_RET_CABECERA  where fechaEmision between '" + sFi + "' and '" + sFf + "'";
                   SqlCommand cmdcabRet = new SqlCommand(sqlcabFact, conexion);
                   SqlDataReader dtrCabRet = cmdcabRet.ExecuteReader();
                   while (dtrCabRet.Read())
                   {
                       try
                       {
                           comprobanteRetencion myObjectRete = new comprobanteRetencion();
                           myObjectRete.id = comprobanteRetencionID.comprobante;
                           myObjectRete.version = "1.0.0";
                           myObjectRete.idSpecified = true;
                           myObjectRete.infoTributaria = new infoTributaria();
                           myObjectRete.infoCompRetencion = new comprobanteRetencionInfoCompRetencion();
                           myObjectRete.impuestos = new List<FirmElect.Info.class_sri.Retencion.impuesto>();
                           myObjectRete.infoTributaria.ambiente = "1";
                           myObjectRete.infoTributaria.tipoEmision = "1";
                           myObjectRete.infoTributaria.razonSocial = Rz;
                           myObjectRete.infoTributaria.nombreComercial = Nomcom;
                           myObjectRete.infoTributaria.ruc = ruc;
                           myObjectRete.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                           myObjectRete.infoTributaria.codDoc = "07";
                           myObjectRete.infoTributaria.estab = dtrCabRet.GetString(5);
                           myObjectRete.infoTributaria.ptoEmi = dtrCabRet.GetString(6);
                           myObjectRete.infoTributaria.secuencial = Convert.ToString(dtrCabRet.GetString(0));
                           myObjectRete.infoTributaria.dirMatriz = direccion;
                           myObjectRete.infoCompRetencion.fechaEmision = string.Format("{0:dd/MM/yyyy}", dtrCabRet.GetDateTime(3)).Replace('-', '/');//.Trim();
                           myObjectRete.infoCompRetencion.dirEstablecimiento = direccion;
                           myObjectRete.infoCompRetencion.contribuyenteEspecial = contspecia;
                           myObjectRete.infoCompRetencion.obligadoContabilidad = "SI";
                           myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = dtrCabRet.GetString(4);
                           myObjectRete.infoCompRetencion.razonSocialSujetoRetenido = dtrCabRet.GetString(2);
                           myObjectRete.infoCompRetencion.identificacionSujetoRetenido = Convert.ToString(dtrCabRet.GetString(1));
                           myObjectRete.infoCompRetencion.periodoFiscal = Convert.ToString(myObjectRete.infoCompRetencion.fechaEmision).Substring(3, 7);
                           // sentencia para extraer detalle de retencion
                           using (SqlConnection conexion1 = new SqlConnection(ConexionDBCliente))
                           {
                               conexion1.Open();
                               string sqlDetalleRet = "select * from ELECTRONICA_RET_DETALLE where secuencial='" + dtrCabRet.GetString(0) + "' ";
                               SqlCommand cmdDetalleFac = new SqlCommand(sqlDetalleRet, conexion1);
                               SqlDataReader dtrDetalleRet = cmdDetalleFac.ExecuteReader();
                               while (dtrDetalleRet.Read())
                               {

                                   FirmElect.Info.class_sri.Retencion.impuesto imp = new FirmElect.Info.class_sri.Retencion.impuesto();
                                   imp.codigo = dtrDetalleRet.GetString(1);
                                   imp.codigoRetencion = dtrDetalleRet.GetString(2);
                                   imp.baseImponible = dtrDetalleRet.GetDecimal(3);
                                   imp.porcentajeRetener = Convert.ToDecimal(dtrDetalleRet.GetInt32(4));
                                   imp.valorRetenido = dtrDetalleRet.GetDecimal(5);
                                   imp.codDocSustento = dtrDetalleRet.GetString(6);
                                   imp.numDocSustento = dtrDetalleRet.GetString(7);
                                   myObjectRete.infoCompRetencion.fechaEmision = string.Format("{0:dd/MM/yyyy}", dtrCabRet.GetDateTime(3)).Replace('-', '/');//.Trim();
                                   myObjectRete.impuestos.Add(imp);
                                   if (dtrDetalleRet.IsDBNull(8) == false)
                                   {
                                       campoAdicional = dtrDetalleRet.GetString(8);
                                   }
                               }

                               // campos adicionales 

                               fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();
                               if (datosAdc.email_bien_escrito(campoAdicional) == true)
                               {
                                   comprobanteRetencionCampoAdicional compoadicional = new comprobanteRetencionCampoAdicional();
                                   compoadicional.nombre = "MAIL";
                                   compoadicional.Value = campoAdicional;
                                   myObjectRete.infoAdicional = new List<comprobanteRetencionCampoAdicional>();
                                   myObjectRete.infoAdicional.Add(compoadicional);
                               }





                               dtrDetalleRet.Close();
                               conexion1.Close();
                               lista.Add(myObjectRete);
                           }
                       }
                       catch (Exception ex)
                       {

                       }
                   }
                   dtrCabRet.Close();
                   conexion.Close();
                   return lista;
               }
           }
           catch (Exception ex)
           {
               return new List<comprobanteRetencion>();
           }
       }
   }
}
