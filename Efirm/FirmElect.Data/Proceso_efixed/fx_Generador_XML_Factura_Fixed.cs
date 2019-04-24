﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.Factura_V2;
using System.Data.SqlClient;
using FirmElect.Info;
namespace FirmElect.Data.Proceso_efixed
{
    public class fx_Generador_XML_Factura_Fixed : fx_GeneradorXML_IFacturas_Data
    {
      
        List<factura> fx_GeneradorXML_IFacturas_Data.GenerarXmlFactura(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente, string OconEfirm, string FormatoFechaSRI, string formatoFechaDB)
        {
            DateTime Fi = Convert.ToDateTime(FechaIni.ToShortDateString());
            DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());
            //string sFi, sFf;
            //sFi = string.Format(formatoFechaDB, Fi);
            //sFf = string.Format(formatoFechaDB, Ff);


            try
            {
                List<factura> lista = new List<factura>();
                using (Entity_conexion_efixed context = new Entity_conexion_efixed())
                {
                    var facturas = context.vwfe_factura.Where(v => v.vt_fecha >= Fi && v.vt_fecha <= Ff);
                    foreach (var item in facturas)
                    {


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
                        myObject.infoTributaria.razonSocial = item.RazonSocial;
                        myObject.infoTributaria.nombreComercial = item.NombreComercial;
                        myObject.infoTributaria.ruc = item.em_ruc;
                        myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                        //*********************************************************************************
                        myObject.infoTributaria.codDoc = "01";
                        myObject.infoTributaria.estab = item.vt_serie1;
                        myObject.infoTributaria.ptoEmi = item.vt_serie2;
                        myObject.infoTributaria.secuencial = item.vt_NumFactura;
                        myObject.infoTributaria.dirMatriz = item.em_direccion;
                        myObject.infoFactura.fechaEmision = string.Format("{0:dd/MM/yyyy}", item.vt_fecha);
                        myObject.infoFactura.dirEstablecimiento = item.em_direccion;
                        //if (item.ContribuyenteEspecial == "S")
                        //{
                        //    myObject.infoFactura.contribuyenteEspecial = "1234";
                        //}
                       
                        myObject.infoFactura.obligadoContabilidadSpecified = true;
                        myObject.infoFactura.obligadoContabilidad = obligadoContabilidad.SI;
                        if (item.IdTipoDocumento == "RUC")
                            myObject.infoFactura.tipoIdentificacionComprador = "04";

                        if (item.IdTipoDocumento == "PAS")
                            myObject.infoFactura.tipoIdentificacionComprador = "06";

                        if (item.IdTipoDocumento == "CED")
                            myObject.infoFactura.tipoIdentificacionComprador = "05";

                        myObject.infoFactura.razonSocialComprador = (item.Nombres.ToString().Replace("S.A","")).Trim();
                        myObject.infoFactura.identificacionComprador = item.pe_cedulaRuc;
                        myObject.infoFactura.direccionComprador = item.Direccion;
                        myObject.infoFactura.totalSinImpuestos = Convert.ToDecimal(item.total_sin_impuesto);
                        myObject.infoFactura.totalDescuento = Convert.ToDecimal(item.totalDescuento);

                        //campos de propina
                        myObject.infoFactura.propinaSpecified = true;
                        myObject.infoFactura.propina = 0;

                        //valor total de la factura
                        myObject.infoFactura.importeTotal = Convert.ToDecimal(item.importeTotal);
                        myObject.infoFactura.moneda = "DOLAR";

                        //forma de pago quemada por decisión del cliente, siempre va a usar esta forma de pago
                        Pago.formaPago = item.IdFormaPago;
                        Pago.total = Convert.ToDecimal(item.importeTotal);
                        Pago.plazoSpecified = true;
                        Pago.plazo = item.Dias_Vct;
                        Pago.unidadTiempo = "Días";
                        myObject.infoFactura.pagos.Add(Pago);
                        if (item.vt_NumFactura == "000017003")
                        {
                        }
                        var facturas_imuestos = context.vwfe_factura_impuestos.Where(v => v.IdEmpresa == item.IdEmpresa && v.IdSucursal == item.IdSucursal && v.IdBodega == item.IdBodega && v.IdCbteVta == item.IdCbteVta);
                        foreach (var item_imp in facturas_imuestos)
                        {
                            impuesto = new facturaInfoFacturaTotalImpuesto();
                            impuesto.codigo = "2";
                            if (item_imp.vt_por_iva == 0)
                            {
                                impuesto.baseImponible =Convert.ToDecimal("0.00") ;
                                impuesto.codigoPorcentaje = "1";
                            }
                            if (item_imp.vt_por_iva == 12)
                            {
                                impuesto.baseImponible = Convert.ToDecimal(item_imp.Base_imponible);
                                impuesto.codigoPorcentaje = "2";
                            }
                            if (item_imp.vt_por_iva == 14)
                            {
                                impuesto.codigoPorcentaje = "3";
                                impuesto.baseImponible = Convert.ToDecimal(item_imp.Base_imponible);
                            }
                            impuesto.valor = Convert.ToDecimal(item_imp.impuesto);
                            myObject.infoFactura.totalConImpuestos.Add(impuesto);
                        }


                        var facturas_detalle = context.vwfe_factura_detalle.Where(v => v.IdEmpresa == item.IdEmpresa && v.IdSucursal == item.IdSucursal && v.IdBodega == item.IdBodega && v.IdCbteVta == item.IdCbteVta );
                        decimal totalDescuento = 0;
                        foreach (var item_det in facturas_detalle)
                        {

                            impuesto imp = new impuesto();
                            facturaDetalle fDetalle = new facturaDetalle();
                            fDetalle.codigoPrincipal = item_det.pr_codigo;
                            fDetalle.codigoAuxiliar = item_det.pr_codigo;
                            fDetalle.descripcion = item_det.pr_descripcion;
                            fDetalle.cantidad = Convert.ToDecimal(item_det.vt_cantidad);
                            fDetalle.precioUnitario = Convert.ToDecimal(item_det.vt_Precio);
                            fDetalle.descuento = Convert.ToDecimal(Convert.ToDecimal( item_det.vt_cantidad)*item_det.vt_DescUnitario);
                            totalDescuento = totalDescuento + fDetalle.descuento;
                            fDetalle.precioTotalSinImpuesto = Convert.ToDecimal(item_det.vt_Subtotal);
                            if (item_det.vt_por_iva == 12)
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "2";
                                imp.tarifa = Convert.ToDecimal(item_det.vt_por_iva);
                                imp.baseImponible = Convert.ToDecimal(item_det.vt_Subtotal);
                                imp.valor = Convert.ToDecimal(item_det.vt_iva);

                            }

                            if (item_det.vt_por_iva == 14)
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "3";
                                imp.tarifa = Convert.ToDecimal(item_det.vt_por_iva);
                                imp.baseImponible = Convert.ToDecimal(item_det.vt_Subtotal);
                                imp.valor = Convert.ToDecimal(item_det.vt_iva);

                            }
                            if (item_det.vt_por_iva == 0)
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "0";
                                imp.tarifa = Convert.ToDecimal(item_det.vt_por_iva);
                                imp.baseImponible = Convert.ToDecimal(item_det.vt_Subtotal);
                                imp.valor = Convert.ToDecimal(item_det.vt_iva);

                            }

                            fDetalle.impuestos = new List<impuesto>();
                            fDetalle.impuestos.Add(imp);
                            myObject.detalles.Add(fDetalle);
                        }

                        myObject.infoFactura.totalDescuento = totalDescuento;
                        // campos adicionales 

                        fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();
                        if (item.Correo != null)
                        {
                            if (datosAdc.email_bien_escrito(item.Correo) == true)
                            {
                                myObject.infoAdicional = new List<facturaCampoAdicional>();
                                facturaCampoAdicional compoadicional = new facturaCampoAdicional();
                                compoadicional.nombre = "MAIL";
                                compoadicional.Value = item.Correo;
                                myObject.infoAdicional.Add(compoadicional);
                            }
                        }
                      
                        lista.Add(myObject);

                    }

                    var lsr = get_facturas_eventos(FechaIni, FechaFin);
                    if (lsr.Count() != 0)
                        lista.AddRange(lsr);
                }

                return lista;
            }
            catch (Exception ex)
            {
                return new List<factura>();
            }
        
           


        }

        public List<factura> get_facturas_eventos (DateTime FechaIni, DateTime FechaFin)
        {
            tb_Empresa info_empresa = new tb_Empresa();
            tb_facturas_eventos info_factura_evento = new tb_facturas_eventos();
            decimal? vt_NumFactura = 1;
            try
            {
            using (EntitiesFactElectronica Context_fac=new EntitiesFactElectronica())
            {
                info_empresa = Context_fac.tb_Empresa.Where(v => v.RUC == "0991435786001").FirstOrDefault();
                 vt_NumFactura  = Context_fac.tb_facturas_eventos.Where(v => v.IdEmpresa == info_empresa.IdEmpresa).Max(v => v.NumFactura) + 1;

            }
            }
            catch (Exception)
            {
                return new List<factura>();
                
            }

           

            DateTime Fi = Convert.ToDateTime(FechaIni.ToShortDateString());
            DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());
            //string sFi, sFf;
            //sFi = string.Format(formatoFechaDB, Fi);
            //sFf = string.Format(formatoFechaDB, Ff);


            try
            {
                List<factura> lista = new List<factura>();
                using (Entity_eventos context = new Entity_eventos())
                {
                    var facturas = context.vwFacturas_fac_electronica.Where(v => v.fecha >= Fi && v.fecha <= Ff && v.estado_aprobacion == "APRO" && v.bd_est==1 );
                    foreach (var item in facturas)
                    {
                        item.nu_ced_clte = item.nu_ced_clte.Trim();

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
                        myObject.infoTributaria.razonSocial = info_empresa.RazonSocial;
                        myObject.infoTributaria.nombreComercial = info_empresa.NombreComercial;
                        myObject.infoTributaria.ruc = info_empresa.RUC;
                        myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                        //*********************************************************************************
                        myObject.infoTributaria.codDoc = "01";
                        myObject.infoTributaria.estab = "001";
                        myObject.infoTributaria.ptoEmi = "003";
                        myObject.infoTributaria.secuencial = vt_NumFactura.ToString().PadLeft(9,'0');
                        myObject.infoTributaria.dirMatriz = info_empresa.DirMatriz;
                        myObject.infoFactura.fechaEmision = string.Format("{0:dd/MM/yyyy}", item.fecha);
                        myObject.infoFactura.dirEstablecimiento = info_empresa.DirMatriz;
                        //if (item.ContribuyenteEspecial == "S")
                        //{
                        //    myObject.infoFactura.contribuyenteEspecial = "1234";
                        //}

                        myObject.infoFactura.obligadoContabilidadSpecified = true;
                        myObject.infoFactura.obligadoContabilidad = obligadoContabilidad.SI;
                        if (item.nu_ced_clte.Length == 13)
                            myObject.infoFactura.tipoIdentificacionComprador = "04";

                        else
                            myObject.infoFactura.tipoIdentificacionComprador = "05";
                        string nombre = item.nombres.Trim() + " " + item.apellidos.Trim();
                        myObject.infoFactura.razonSocialComprador = (nombre.ToString().Replace("S.A", "")).Trim();
                        myObject.infoFactura.identificacionComprador = item.nu_ced_ruc.Trim();
                        myObject.infoFactura.direccionComprador = item.direccion.Trim();
                        myObject.infoFactura.totalSinImpuestos = Convert.ToDecimal(item.subtotal);
                        myObject.infoFactura.totalDescuento = Convert.ToDecimal(0.00);

                        //campos de propina
                        myObject.infoFactura.propinaSpecified = true;
                        myObject.infoFactura.propina = 0;

                        //valor total de la factura
                        myObject.infoFactura.importeTotal = Convert.ToDecimal(item.total);
                        myObject.infoFactura.moneda = "DOLAR";

                        //forma de pago quemada por decisión del cliente, siempre va a usar esta forma de pago
                        Pago.formaPago = "20";
                        Pago.total = Convert.ToDecimal(item.total);
                        Pago.plazoSpecified = true;
                        Pago.plazo = 0;
                        Pago.unidadTiempo = "Días";
                        myObject.infoFactura.pagos.Add(Pago);
                       
                        
                            impuesto = new facturaInfoFacturaTotalImpuesto();
                            impuesto.codigo = "2";
                            if (item.v_iva == 0)
                            {
                                impuesto.baseImponible = Convert.ToDecimal("0.00");
                                impuesto.codigoPorcentaje = "1";
                            }
                            if (item.v_iva > 0)
                            {
                                impuesto.baseImponible = Convert.ToDecimal(item.subtotal);
                                impuesto.codigoPorcentaje = "2";
                            }
                            
                            impuesto.valor = Convert.ToDecimal(item.v_iva);
                            myObject.infoFactura.totalConImpuestos.Add(impuesto);
                        


                        decimal totalDescuento = 0;
                            impuesto imp = new impuesto();
                            facturaDetalle fDetalle = new facturaDetalle();
                            fDetalle.codigoPrincipal = item.cod_evento.ToString();
                            fDetalle.codigoAuxiliar = item.cod_evento.ToString();
                            fDetalle.descripcion = item.descrip;
                            fDetalle.cantidad = Convert.ToDecimal(item.cant);
                            fDetalle.precioUnitario = Convert.ToDecimal(item.v_unit);
                            fDetalle.descuento = Convert.ToDecimal("0.00");
                            totalDescuento = totalDescuento + fDetalle.descuento;
                            fDetalle.precioTotalSinImpuesto = Convert.ToDecimal(item.subtotal);
                            if (item.v_iva >0)
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "2";
                                imp.tarifa = Convert.ToDecimal(12);
                                imp.baseImponible = Convert.ToDecimal(item.subtotal);
                                imp.valor = Convert.ToDecimal(item.v_iva);

                            }
                        else
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "0";
                                imp.tarifa = Convert.ToDecimal(0);
                                imp.baseImponible = Convert.ToDecimal(item.subtotal);
                                imp.valor = Convert.ToDecimal(item.v_iva);
                            }

                            fDetalle.impuestos = new List<impuesto>();
                            fDetalle.impuestos.Add(imp);
                            myObject.detalles.Add(fDetalle);
                        

                        myObject.infoFactura.totalDescuento = Math.Round(totalDescuento, 2);
                        // campos adicionales 
                        fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();
                        if (item.email != null)
                        {
                            if (datosAdc.email_bien_escrito(item.email) == true)
                            {
                                myObject.infoAdicional = new List<facturaCampoAdicional>();
                                facturaCampoAdicional compoadicional = new facturaCampoAdicional();
                                compoadicional.nombre = "MAIL";
                                compoadicional.Value = item.email;
                                myObject.infoAdicional.Add(compoadicional);
                            }
                        }

                       
                       


                        #region Actualizar


                        try
                        {
                            using (Entity_eventos Context_fac_sis_ext = new Entity_eventos())
                            {
                                var entity_modificar = Context_fac_sis_ext.Facturas.Where(v => v.cod_evento == item.cod_evento && v.cod_fact == item.cod_fact).FirstOrDefault();
                                entity_modificar.estado_aprobacion = "GENE";
                                Context_fac_sis_ext.SaveChanges();


                            }
                        }
                        catch (Exception)
                        {


                        }
                        #endregion

                        #region Actualizando secuancia
                        try
                        {
                            using (EntitiesFactElectronica Context_fac = new EntitiesFactElectronica())
                            {

                                var entity_modificar = Context_fac.tb_facturas_eventos.Where(v => v.Evento == item.cod_evento && v.Factura == item.cod_fact).FirstOrDefault();

                                if (entity_modificar == null)
                                {
                                    tb_facturas_eventos evento = new tb_facturas_eventos()
                                    {
                                        IdEmpresa = info_empresa.IdEmpresa,
                                        Establecimiento = "001",
                                        Puntoemision = "003",
                                        NumFactura = Convert.ToDecimal(vt_NumFactura),
                                        Cantidad = item.cant,
                                        ValorUnitario = item.v_unit,
                                        Subtotal = item.subtotal,
                                        Iva = item.v_iva,
                                        Total = item.total,
                                        Evento = item.cod_evento,
                                        Factura = Convert.ToInt32(item.cod_fact),
                                        Nombre_Evento = item.descrip
                                    };
                                    if (item.nu_ced_ruc.Trim().Contains("9999999999"))
                                        evento.Observacion = item.observacion;
                                        
                                    Context_fac.tb_facturas_eventos.Add(evento);
                                    Context_fac.SaveChanges();
                                    vt_NumFactura = vt_NumFactura + 1;
                                }
                                else
                                {
                                    myObject.infoTributaria.secuencial = entity_modificar.NumFactura.ToString().PadLeft(9,'0');
                                }
                            }
                        }
                        catch (Exception)
                        {


                        }
                        #endregion

                        lista.Add(myObject);
                      
                    }

                }


                return lista;
            }
            catch (Exception ex)
            {
                return new List<factura>();
            }




        }

    }
}