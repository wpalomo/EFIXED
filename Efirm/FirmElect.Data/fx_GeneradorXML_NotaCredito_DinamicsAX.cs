using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info;
using System.Data.SqlClient;
using FirmElect.Info.class_sri.Factura_V2;
namespace FirmElect.Data
{
   public class fx_GeneradorXML_NotaCredito_DinamicsAX:fx_GeneradorXML_INotaCredito
    {
        List<tb_Empresa_Info> lista_empresas_fx = new List<tb_Empresa_Info>();
        string campoAdicional = null; string secuencia = null;
        string ruc = "", Rz = "", Nomcom = "", contspecia = "", direccion = "", IdComprobanteError = "";
        string OconEfirm = "";
        string sql = ""; string Ocon = "";
        public List<Info.class_sri.NotaCredito.notaCredito> GenerarXmlNotaCredito(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB)
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

            string sFi, sFf;
            sFi = string.Format(formatoFechaDB, FechaIni);
            sFf = string.Format(formatoFechaDB, FechaFin);



            try
            {

                List<notaCredito> lista = new List<notaCredito>();
                using (SqlConnection conexion = new SqlConnection(ConexionDBCliente))
                {

                    conexion.Open();
                    string sqlcabFact = "select * from ELECTRONICA_NTC_CABECERA where  fechaEmision between '" + sFi + "' and '" + sFf + "'";
                    SqlCommand cmdNC = new SqlCommand(sqlcabFact, conexion);
                    SqlDataReader dtrNC = cmdNC.ExecuteReader();
                    while (dtrNC.Read())
                    {

                        try
                        {
                            notaCredito myObject;
                            myObject = new notaCredito();
                            myObject.id = notaCreditoID.comprobante;
                            myObject.version = "1.1.0";
                          //  myObject.idSpecified = true;
                         
                            totalConImpuestos imp = new totalConImpuestos();
                            myObject.infoNotaCredito = new notaCreditoInfoNotaCredito();
                            myObject.infoTributaria = new infoTributaria();
                            myObject.detalles = new List<notaCreditoDetalle>();
                            myObject.infoNotaCredito.totalConImpuestos = new List<totalConImpuestosTotalImpuesto>();
                            totalConImpuestosTotalImpuesto impuesto = null;

                            myObject.infoTributaria.ambiente = "1";
                            myObject.infoTributaria.tipoEmision = "1";
                            myObject.infoTributaria.razonSocial =Rz;
                            myObject.infoTributaria.nombreComercial =Nomcom;
                            myObject.infoTributaria.ruc =ruc;
                            myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                            myObject.infoTributaria.codDoc = "04";
                            myObject.infoTributaria.estab = dtrNC.GetString(5);
                            myObject.infoTributaria.ptoEmi = dtrNC.GetString(6);
                            myObject.infoTributaria.secuencial = dtrNC.GetString(4).PadLeft(9, '0');
                            myObject.infoTributaria.dirMatriz = direccion;
                            myObject.infoNotaCredito.fechaEmision = string.Format("{0:dd/MM/yyyy}", dtrNC.GetDateTime(0));//.Trim();
                            myObject.infoNotaCredito.dirEstablecimiento = direccion;
                            myObject.infoNotaCredito.tipoIdentificacionComprador = Convert.ToString(dtrNC.GetString(1));
                            myObject.infoNotaCredito.razonSocialComprador = Convert.ToString(dtrNC.GetString(3));
                            myObject.infoNotaCredito.identificacionComprador = Convert.ToString(dtrNC.GetString(2));
                            myObject.infoNotaCredito.contribuyenteEspecial = contspecia;
                            myObject.infoNotaCredito.obligadoContabilidad = "SI";
                            myObject.infoNotaCredito.codDocModificado = "01";
                            myObject.infoNotaCredito.numDocModificado = Convert.ToString(dtrNC.GetString(12));
                            myObject.infoNotaCredito.fechaEmisionDocSustento = string.Format("{0:dd/MM/yyyy}", dtrNC.GetDateTime(0));//.Trim();
                            myObject.infoNotaCredito.totalSinImpuestos = dtrNC.GetDecimal(9);
                            myObject.infoNotaCredito.valorModificacion = dtrNC.GetDecimal(14);
                            myObject.infoNotaCredito.moneda = "DOLAR";
                            myObject.infoNotaCredito.motivo = dtrNC.GetString(13);
                            
                            using (SqlConnection conexion2 = new SqlConnection( ConexionDBCliente))
                            {
                                conexion2.Open();
                                string SQLTot_impuesto = "select * from ELECTRONICA_NC_TOT_IMPUESTOS  where secuencial='" + dtrNC.GetString(16) + "'";
                                SqlCommand cmdTotImpuesto = new SqlCommand(SQLTot_impuesto, conexion2);
                                SqlDataReader dtrTotImpuesto = cmdTotImpuesto.ExecuteReader();
                                while (dtrTotImpuesto.Read())
                                {
                                    impuesto = new totalConImpuestosTotalImpuesto();
                                    impuesto.codigo = dtrTotImpuesto.GetString(3);
                                    impuesto.codigoPorcentaje = dtrTotImpuesto.GetString(4);
                                    if (dtrTotImpuesto.GetString(4) == "0")
                                    {
                                        impuesto.baseImponible = dtrTotImpuesto.GetDecimal(7);
                                    }
                                    else
                                    {
                                        if (dtrTotImpuesto.GetString(4) == "2")
                                            impuesto.baseImponible = dtrTotImpuesto.GetDecimal(6);
                                        else
                                            if (dtrTotImpuesto.GetString(4) == "3")
                                                impuesto.baseImponible = dtrTotImpuesto.GetDecimal(5);
                                    }

                                    impuesto.valor = dtrTotImpuesto.GetDecimal(8);
                                    myObject.infoNotaCredito.totalConImpuestos.Add(impuesto);
                                }

                            }



                            // detalle de nota credito
                            using (SqlConnection conexion1 = new SqlConnection( ConexionDBCliente))
                            {
                                string sqlDetalleRet = "";
                                conexion1.Open();
                                if (dtrNC.GetSqlInt32(15) == 0)
                                {
                                    sqlDetalleRet = "select * from ELECTRONICA_NTC_DETALLE  where secuencial='" + dtrNC.GetString(16) + "'";
                                }
                                else
                                {
                                    sqlDetalleRet = "select * from ELECTRONICA_NTC_DETALLE_S  where secuencial='" + dtrNC.GetString(16) + "'";
                                }

                                SqlCommand cmdDetalleNC = new SqlCommand(sqlDetalleRet, conexion1);
                                SqlDataReader dtrDetalleNC = cmdDetalleNC.ExecuteReader();
                                while (dtrDetalleNC.Read())
                                {
                                    impuesto impue = new impuesto();
                                    notaCreditoDetalle NCdetalle = new notaCreditoDetalle();
                                    // NCdetalle.descuento = dtrDetalleNC.GetDecimal(9);
                                    NCdetalle.descuentoSpecified = true;
                                    NCdetalle.codigoInterno = dtrDetalleNC.GetString(1);
                                    NCdetalle.descripcion = dtrDetalleNC.GetString(5);
                                    if (dtrNC.GetSqlInt32(15) == 1)
                                    {
                                        NCdetalle.cantidad = Convert.ToDecimal(dtrDetalleNC.GetInt32(2));
                                    }
                                    else
                                    {
                                        NCdetalle.cantidad = dtrDetalleNC.GetDecimal(2);
                                    }
                                    NCdetalle.precioUnitario = dtrDetalleNC.GetDecimal(3);
                                                                     
                                    NCdetalle.precioTotalSinImpuesto = dtrDetalleNC.GetDecimal(4);
                                    NCdetalle.impuestos = new List<impuesto>();
                                    if (dtrDetalleNC.GetString(6) == "VS-12%")
                                    {
                                        impue.codigo = "2";
                                        impue.codigoPorcentaje = "2";
                                        impue.tarifa = 12;
                                        impue.baseImponible = dtrDetalleNC.GetDecimal(4);
                                        impue.valor = dtrDetalleNC.GetDecimal(7);

                                    }
                                    else
                                        if (dtrDetalleNC.GetString(6) == "VS-14%")
                                        {
                                            impue.codigo = "2";
                                            impue.codigoPorcentaje = "3";
                                            impue.tarifa = 14;
                                            impue.baseImponible = dtrDetalleNC.GetDecimal(4);
                                            impue.valor = dtrDetalleNC.GetDecimal(7);

                                        }
                                        else
                                        {
                                            impue.codigo = "2";
                                            impue.codigoPorcentaje = "0";
                                            impue.tarifa = 0;
                                            impue.baseImponible = dtrDetalleNC.GetDecimal(4);
                                            impue.valor = dtrDetalleNC.GetDecimal(7);
                                        }
                                    NCdetalle.impuestos.Add(impue);
                                    myObject.detalles.Add(NCdetalle);
                                    if (dtrNC.GetSqlInt32(15) == 0)
                                    {
                                        if (dtrDetalleNC.IsDBNull(8) == false)
                                        {
                                            campoAdicional = dtrDetalleNC.GetString(8);
                                        }
                                    }
                                    else
                                    {
                                        if (dtrDetalleNC.IsDBNull(9) == false)
                                        {
                                            //NCdetalle.descuento = dtrDetalleNC.GetDecimal(8);
                                            campoAdicional = dtrDetalleNC.GetString(9);
                                        }
                                    }

                                }


                                // campos adicionales 

                                fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();
                                if (campoAdicional != null)
                                {
                                    if (datosAdc.email_bien_escrito(campoAdicional) == true)
                                    {
                                        notaCreditoCampoAdicional compoadicional = new notaCreditoCampoAdicional();
                                        compoadicional.nombre = "MAIL";
                                        compoadicional.Value = campoAdicional;
                                        myObject.infoAdicional = new List<notaCreditoCampoAdicional>();
                                        myObject.infoAdicional.Add(compoadicional);

                                    }
                                }

                                lista.Add(myObject);
                                dtrDetalleNC.Close();
                                conexion1.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                           
                        }
                    }
                    dtrNC.Close();
                    conexion.Close();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return new List<Info.class_sri.NotaCredito.notaCredito>();
            }
        }
    }
}
