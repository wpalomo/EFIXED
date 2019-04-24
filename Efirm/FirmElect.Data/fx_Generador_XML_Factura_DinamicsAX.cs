using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.Factura_V2;
using System.Data.SqlClient;
using FirmElect.Info;
namespace FirmElect.Data
{
   public class fx_Generador_XML_Factura_DinamicsAX:fx_GeneradorXML_IFacturas_Data
    {
       List<tb_Empresa_Info> lista_empresas_fx = new List<tb_Empresa_Info>();
       tb_Empresa_Data data_empresa = new tb_Empresa_Data();
       string campoAdicional = null; string secuencia = null;
       string ruc = "", Rz = "", Nomcom = "", contspecia = "", direccion = "", IdComprobanteError = "";
       string OconEfirm = "";
       string sql = ""; string Ocon = "";
        public List<factura> GenerarXmlFactura(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB)
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


          
            DateTime Fi = Convert.ToDateTime(FechaIni.ToShortDateString());
            DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());
            string sFi, sFf;
            sFi = string.Format(formatoFechaDB, Fi);
            sFf = string.Format(formatoFechaDB, Ff);
            List<factura> facAux0 = new List<factura>();
           
            //Generación de la Factura de Expoguayaquil.
            try
            {
                List<factura> lista = new List<factura>();
                using (SqlConnection conexion = new SqlConnection(ConexionDBCliente))
                {
                    conexion.Open();
                    string sqlcabFact = "select * from ELECTRONICA_FAC_CABECERA_NEW where fechaEmision between '" + sFi + "' and '" + sFf + "'";
                    SqlCommand cmdcabFact = new SqlCommand(sqlcabFact, conexion);
                    SqlDataReader dtrcabFact = cmdcabFact.ExecuteReader();

                    while (dtrcabFact.Read())
                    {
                        try
                        {

                            string Ruc = "";

                            factura myObject = new factura();
                            myObject.version = "1.1.0";
                            myObject.id = facturaID.comprobante;
                            myObject.idSpecified = true;
                            infoTributaria info = new infoTributaria();
                            myObject.infoFactura = new facturaInfoFactura();
                            myObject.infoFactura.totalConImpuestos = new List<facturaInfoFacturaTotalImpuesto>();
                            myObject.infoFactura.pagos = new List<pagosPago>();
                            pagosPago Pago = new pagosPago();

                            myObject.infoTributaria = info;
                            myObject.detalles = new List<facturaDetalle>();
                            facturaInfoFacturaTotalImpuesto impuesto = null;
                            info.ambiente = "1";
                            myObject.infoTributaria.tipoEmision = "1";
                            myObject.infoTributaria.razonSocial =Rz;
                            myObject.infoTributaria.nombreComercial = Nomcom;
                            myObject.infoTributaria.ruc =ruc;
                            myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                            //*********************************************************************************
                            myObject.infoTributaria.codDoc = "01";
                            myObject.infoTributaria.estab = dtrcabFact.GetString(4);
                            myObject.infoTributaria.ptoEmi = dtrcabFact.GetString(5);
                            myObject.infoTributaria.secuencial = dtrcabFact.GetString(3).PadLeft(9, '0');
                            myObject.infoTributaria.dirMatriz = direccion;
                            myObject.infoFactura.fechaEmision = string.Format("{0:dd/MM/yyyy}", dtrcabFact.GetDateTime(0));
                            myObject.infoFactura.dirEstablecimiento = direccion;
                            myObject.infoFactura.contribuyenteEspecial = contspecia;
                            myObject.infoFactura.obligadoContabilidadSpecified = true;
                            myObject.infoFactura.obligadoContabilidad = obligadoContabilidad.SI;
                            myObject.infoFactura.tipoIdentificacionComprador = dtrcabFact.GetString(1);
                            myObject.infoFactura.razonSocialComprador = dtrcabFact.GetString(2);
                            myObject.infoFactura.identificacionComprador = Convert.ToString(dtrcabFact.GetString(10));
                            myObject.infoFactura.direccionComprador = Convert.ToString(dtrcabFact.GetString(12));
                            myObject.infoFactura.totalSinImpuestos = dtrcabFact.GetDecimal(7);
                            myObject.infoFactura.totalDescuento = dtrcabFact.GetDecimal(9);

                            //campos de propina
                            myObject.infoFactura.propinaSpecified = true;
                            myObject.infoFactura.propina = 0;

                            //valor total de la factura
                            myObject.infoFactura.importeTotal = Convert.ToDecimal(dtrcabFact.GetDecimal(6));
                            myObject.infoFactura.moneda = "DOLAR";

                            //forma de pago quemada por decisión del cliente, siempre va a usar esta forma de pago
                            Pago.formaPago = (dtrcabFact.IsDBNull(13) == true) ? "01" : dtrcabFact.GetString(13);
                            Pago.total = Convert.ToDecimal(dtrcabFact.GetDecimal(6));
                            Pago.plazoSpecified = true;
                            Pago.plazo = (dtrcabFact.IsDBNull(14) == true) ? 1 : (Convert.ToDecimal(dtrcabFact.GetInt32(14)));
                            Pago.unidadTiempo = (dtrcabFact.IsDBNull(15) == true) ? "día" : dtrcabFact.GetString(15);

                            myObject.infoFactura.pagos.Add(Pago);

                            using (SqlConnection conexion2 = new SqlConnection(ConexionDBCliente))
                            {
                                string SFecha_busqueda = string.Format(formatoFechaDB, dtrcabFact.GetDateTime(0));
                                conexion2.Open();
                                string SQLTot_impuesto = "select * from ELECTRONICA_FAC_TOT_IMPUESTOS  where secuencial='" + dtrcabFact.GetString(16) + "'";
                                SqlCommand cmdTotImpuesto = new SqlCommand(SQLTot_impuesto, conexion2);
                                SqlDataReader dtrTotImpuesto = cmdTotImpuesto.ExecuteReader();
                                while (dtrTotImpuesto.Read())
                                {
                                    impuesto = new facturaInfoFacturaTotalImpuesto();

                                    impuesto.codigo = dtrTotImpuesto.GetString(1);
                                    impuesto.codigoPorcentaje = dtrTotImpuesto.GetString(2);
                                    if (dtrTotImpuesto.GetString(2) == "0")
                                    {
                                        impuesto.baseImponible = dtrTotImpuesto.GetDecimal(5);
                                    }
                                    else
                                    {
                                        if (dtrTotImpuesto.GetString(2) == "2")
                                            impuesto.baseImponible = dtrTotImpuesto.GetDecimal(4);
                                        else
                                            if (dtrTotImpuesto.GetString(2) == "3")
                                                impuesto.baseImponible = dtrTotImpuesto.GetDecimal(3);
                                    }

                                    impuesto.valor = dtrTotImpuesto.GetDecimal(6);
                                    myObject.infoFactura.totalConImpuestos.Add(impuesto);
                                }
                            }

                            using (SqlConnection conexion1 = new SqlConnection(ConexionDBCliente))
                            {
                                string sqlDetalleFac = "";
                                conexion1.Open();
                                // sentencia para extraer detalle de factura

                                if (dtrcabFact.GetInt32(11) == 0)
                                {
                                    sqlDetalleFac = "select * from ELECTRONICA_FAC_DETALLE where secuencial='" + dtrcabFact.GetString(16) + "' ";

                                }
                                else
                                {
                                    sqlDetalleFac = "select * from ELECTRONICA_FAC_DETALLE_S where secuencial='"+dtrcabFact.GetString(16)+"' ";
                                }
                                SqlCommand cmdDetalleFac = new SqlCommand(sqlDetalleFac, conexion1);
                                SqlDataReader dtrDetalleFac = cmdDetalleFac.ExecuteReader();
                                while (dtrDetalleFac.Read())
                                {
                                    impuesto imp = new impuesto();
                                    facturaDetalle fDetalle = new facturaDetalle();
                                    fDetalle.codigoPrincipal = dtrDetalleFac.GetString(1);
                                    fDetalle.codigoAuxiliar = dtrDetalleFac.GetString(1);
                                    fDetalle.descripcion = dtrDetalleFac.GetString(5);
                                    fDetalle.cantidad = Convert.ToDecimal(dtrDetalleFac.GetDecimal(2));
                                    fDetalle.precioUnitario = Convert.ToDecimal(dtrDetalleFac.GetDecimal(3));

                                    fDetalle.descuento = dtrDetalleFac.GetDecimal(8);

                                    fDetalle.precioTotalSinImpuesto = Convert.ToDecimal(dtrDetalleFac.GetDecimal(4));
                                    if (dtrDetalleFac.GetString(6) == "VS-12%")
                                    {
                                        imp.codigo = "2";
                                        imp.codigoPorcentaje = "2";
                                        imp.tarifa = 12;
                                        imp.baseImponible = dtrDetalleFac.GetDecimal(4);
                                        imp.valor = dtrDetalleFac.GetDecimal(7);

                                    }
                                    else
                                        if (dtrDetalleFac.GetString(6) == "VS-14%")
                                        {
                                            imp.codigo = "2";
                                            imp.codigoPorcentaje = "3";
                                            imp.tarifa = 14;
                                            imp.baseImponible = dtrDetalleFac.GetDecimal(4);
                                            imp.valor = dtrDetalleFac.GetDecimal(7);

                                        }
                                        else
                                        {
                                            imp.codigo = "2";
                                            imp.codigoPorcentaje = "0";
                                            imp.tarifa = 0;
                                            imp.baseImponible = dtrDetalleFac.GetDecimal(4);
                                            imp.valor = dtrDetalleFac.GetDecimal(7);
                                        }
                                    if (dtrDetalleFac.IsDBNull(9) == false)
                                    {
                                        campoAdicional = dtrDetalleFac.GetString(9);
                                    }

                                    fDetalle.impuestos = new List<impuesto>();
                                    fDetalle.impuestos.Add(imp);
                                    myObject.detalles.Add(fDetalle);
                                }


                                // campos adicionales 

                                fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();
                                if (campoAdicional != null)
                                {
                                    if (datosAdc.email_bien_escrito(campoAdicional) == true)
                                    {
                                        facturaCampoAdicional compoadicional = new facturaCampoAdicional();
                                        compoadicional.nombre = "MAIL";
                                        compoadicional.Value = campoAdicional;
                                        myObject.infoAdicional = new List<facturaCampoAdicional>();
                                        myObject.infoAdicional.Add(compoadicional);
                                    }
                                }
                                dtrDetalleFac.Close();
                                conexion1.Close();
                                lista.Add(myObject);
                                facAux0 = lista;
                            }
                        }
                        catch (Exception ex)
                        {
                            
                        }
                    }
                    dtrcabFact.Close();
                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                return facAux0;
            }
        
           
        }
    }
}
