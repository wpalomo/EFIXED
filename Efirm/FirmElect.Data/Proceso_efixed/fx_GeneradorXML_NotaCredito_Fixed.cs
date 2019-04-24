using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info;
using System.Data.SqlClient;
using FirmElect.Info.class_sri.Factura_V2;
namespace FirmElect.Data.Proceso_efixed
{
    public class fx_GeneradorXML_NotaCredito_Fixed : fx_GeneradorXML_INotaCredito
    {

        public List<notaCredito> GenerarXmlNotaCredito(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente, string OconEfirm, string FormatoFechaSRI, string formatoFechaDB)
        {
            DateTime Fi = Convert.ToDateTime(FechaIni.ToShortDateString());
            DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());
            //string sFi, sFf;
            //sFi = string.Format(formatoFechaDB, Fi);
            //sFf = string.Format(formatoFechaDB, Ff);


            try
            {
                List<notaCredito> lista = new List<notaCredito>();
                using (Entity_conexion_efixed context = new Entity_conexion_efixed())
                {
                    var nota_credito = context.vwfe_nota_credito.Where(v => v.no_fecha >= Fi && v.no_fecha <= Ff);
                    foreach (var item in nota_credito)
                    {


                        notaCredito myObject = new notaCredito();
                        totalConImpuestosTotalImpuesto impuesto = null;
                        myObject.version = "1.1.0";
                        myObject.id =new notaCreditoID();
                        infoTributaria info = new infoTributaria();
                        myObject.infoNotaCredito = new notaCreditoInfoNotaCredito();
                        myObject.infoNotaCredito.totalConImpuestos =new List<totalConImpuestosTotalImpuesto>();
                        myObject.infoTributaria = info;
                        myObject.detalles =new List<notaCreditoDetalle>();
                        info.ambiente = "1";
                        myObject.infoTributaria.tipoEmision = "1";
                        myObject.infoTributaria.razonSocial = item.NombreComercial.Trim().ToString().Replace("S.A", ""); ;
                        myObject.infoTributaria.nombreComercial = item.NombreComercial.Trim().ToString().Replace("S.A", ""); ;
                        myObject.infoTributaria.ruc = item.em_ruc;
                        myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                        //*********************************************************************************
                        myObject.infoTributaria.codDoc = "04";
                        myObject.infoTributaria.estab = item.Serie1;
                        myObject.infoTributaria.ptoEmi = item.Serie2;
                        myObject.infoTributaria.secuencial = item.NumNota_Impresa;
                        myObject.infoTributaria.dirMatriz = item.em_direccion;
                        myObject.infoNotaCredito.fechaEmision = string.Format("{0:dd/MM/yyyy}", item.no_fecha);
                        myObject.infoNotaCredito.dirEstablecimiento = item.em_direccion;
                        //if(item.ContribuyenteEspecial=="S")
                        //myObject.infoNotaCredito.contribuyenteEspecial = "00000";
                        myObject.infoNotaCredito.obligadoContabilidad = obligadoContabilidad.SI.ToString();
                        myObject.infoNotaCredito.codDocModificado = "01";
                        myObject.infoNotaCredito.numDocModificado = item.vt_serie1 + "-" + item.vt_serie2 + "-" + item.vt_NumFactura;
                        myObject.infoNotaCredito.fechaEmisionDocSustento = string.Format("{0:dd/MM/yyyy}", item.vt_fecha);
                        myObject.infoNotaCredito.motivo = item.sc_observacion;
                        if (item.IdTipoDocumento == "RUC")
                            myObject.infoNotaCredito.tipoIdentificacionComprador = "04";

                        if (item.IdTipoDocumento == "PAS")
                            myObject.infoNotaCredito.tipoIdentificacionComprador = "06";

                        if (item.IdTipoDocumento == "CED")
                            myObject.infoNotaCredito.tipoIdentificacionComprador = "05";

                        myObject.infoNotaCredito.razonSocialComprador = item.pe_nombreCompleto.ToString().Replace("S.A", "").Trim();
                        myObject.infoNotaCredito.identificacionComprador = item.pe_cedulaRuc;
                        myObject.infoNotaCredito.dirEstablecimiento = item.em_direccion;
                        myObject.infoNotaCredito.totalSinImpuestos = Convert.ToDecimal(item.total_sin_impuesto);
                        myObject.infoNotaCredito.valorModificacion = Convert.ToDecimal(item.importeTotal);
                     
                        //valor total de la factura
                        myObject.infoNotaCredito.valorModificacion = Convert.ToDecimal(item.importeTotal);
                        myObject.infoNotaCredito.moneda = "DOLAR";

                     
                        var facturas_imuestos = context.vwfe_nota_credito_impuestos.Where(v => v.IdEmpresa == item.IdEmpresa && v.IdSucursal == item.IdSucursal && v.IdBodega == item.IdBodega && v.IdNota == item.IdNota).ToList();
                        foreach (var item_imp in facturas_imuestos)
                        {
                            impuesto = new totalConImpuestosTotalImpuesto();
                            impuesto.codigo = "2";
                            if (item_imp.vt_por_iva == 0)
                                impuesto.codigoPorcentaje = "1";
                            if (item_imp.vt_por_iva == 12)
                                impuesto.codigoPorcentaje = "2";
                            if (item_imp.vt_por_iva == 14)
                                impuesto.codigoPorcentaje = "3";
                            impuesto.baseImponible = Convert.ToDecimal(item_imp.Base_imponible);
                            impuesto.valor = Convert.ToDecimal(item_imp.impuesto);
                            myObject.infoNotaCredito.totalConImpuestos.Add(impuesto);
                        }


                        var facturas_detalle = context.vwfe_nota_credito_detalle.Where(v => v.IdEmpresa == item.IdEmpresa && v.IdSucursal == item.IdSucursal && v.IdBodega == item.IdBodega && v.IdNota == item.IdNota).ToList();

                        foreach (var item_det in facturas_detalle)
                        {

                            impuesto imp = new impuesto();
                            notaCreditoDetalle fDetalle = new notaCreditoDetalle();
                            fDetalle.codigoInterno = item_det.pr_codigo;
                            fDetalle.codigoAdicional = item_det.pr_codigo;
                            fDetalle.descripcion = item_det.pr_descripcion;
                            fDetalle.cantidad = Convert.ToDecimal(item_det.sc_cantidad);
                            fDetalle.precioUnitario = Convert.ToDecimal(item_det.sc_Precio);
                            fDetalle.descuento = Convert.ToDecimal(item_det.sc_descUni*item_det.sc_cantidad);
                            fDetalle.descuentoSpecified=true;
                            fDetalle.precioTotalSinImpuesto = Convert.ToDecimal(item_det.sc_subtotal);
                            if (item_det.vt_por_iva == 12)
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "2";
                                imp.tarifa = Convert.ToDecimal(item_det.vt_por_iva);
                                imp.baseImponible = Convert.ToDecimal(item_det.sc_subtotal);
                                imp.valor = Convert.ToDecimal(item_det.sc_iva);

                            }

                            if (item_det.vt_por_iva == 14)
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "3";
                                imp.tarifa = Convert.ToDecimal(item_det.vt_por_iva);
                                imp.baseImponible = Convert.ToDecimal(item_det.sc_subtotal);
                                imp.valor = Convert.ToDecimal(item_det.sc_iva);

                            }
                            if (item_det.vt_por_iva == 0)
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "0";
                                imp.tarifa = Convert.ToDecimal(item_det.vt_por_iva);
                                imp.baseImponible = Convert.ToDecimal(item_det.sc_subtotal);
                                imp.valor = Convert.ToDecimal(item_det.sc_iva);

                            }

                            fDetalle.impuestos = new List<impuesto>();
                            fDetalle.impuestos.Add(imp);
                            myObject.detalles.Add(fDetalle);
                        }


                        // campos adicionales 

                        fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();
                        myObject.infoAdicional = new List<notaCreditoCampoAdicional>();
                        if (item.Correo != null)
                        {
                            if (datosAdc.email_bien_escrito(item.Correo) == true)
                            {
                                notaCreditoCampoAdicional compoadicional = new notaCreditoCampoAdicional();
                                compoadicional.nombre = "MAIL";
                                compoadicional.Value = item.Correo;
                                myObject.infoAdicional.Add(compoadicional);
                            }
                        }
                       
                        lista.Add(myObject);

                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                return new List<notaCredito>();
            }
        
           
        }
    }
}
