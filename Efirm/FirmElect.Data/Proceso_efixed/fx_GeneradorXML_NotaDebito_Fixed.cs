using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info;
using System.Data.SqlClient;
using FirmElect.Info.class_sri.Factura_V2;
namespace FirmElect.Data.Proceso_efixed
{
    public class fx_GeneradorXML_NotaDebito_Fixed : fx_GeneradorXML_INotaDebito
    {

        public List<notaDebito> GenerarXmlNotaDebito(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente, string FormatoFechaSRI, string formatoFechaDB)
        {
            DateTime Fi = Convert.ToDateTime(FechaIni.ToShortDateString());
            DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());
            //string sFi, sFf;
            //sFi = string.Format(formatoFechaDB, Fi);
            //sFf = string.Format(formatoFechaDB, Ff);


            try
            {
                List<notaDebito> lista = new List<notaDebito>();
                using (Entity_conexion_efixed context = new Entity_conexion_efixed())
                {
                    var nota_credito = context.vwfe_nota_debito.Where(v => v.no_fecha >= Fi && v.no_fecha <= Ff);
                    foreach (var item in nota_credito)
                    {
                        notaDebito myObject = new notaDebito();
                        myObject.version = "1.0.0";
                        myObject.id =new notaDebitoID();
                        infoTributaria info = new infoTributaria();
                        myObject.infoNotaDebito = new notaDebitoInfoNotaDebito();
                        myObject.infoNotaDebito.impuestos = new List<impuesto>();
                        myObject.infoTributaria = info;
                        info.ambiente = "1";
                        myObject.infoTributaria.tipoEmision = "1";
                        myObject.infoTributaria.razonSocial = item.NombreComercial;
                        myObject.infoTributaria.nombreComercial = item.NombreComercial;
                        myObject.infoTributaria.ruc = item.em_ruc;
                        myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                        myObject.idSpecified = true;
                        //*********************************************************************************
                        myObject.infoTributaria.codDoc = "05";
                        myObject.infoTributaria.estab = item.Serie1;
                        myObject.infoTributaria.ptoEmi = item.Serie2;
                        myObject.infoTributaria.secuencial = item.NumNota_Impresa;
                        myObject.infoTributaria.dirMatriz = item.em_direccion;
                        myObject.infoNotaDebito.fechaEmision = string.Format("{0:dd/MM/yyyy}", item.no_fecha);
                        myObject.infoNotaDebito.dirEstablecimiento = item.em_direccion;
                        //if(item.ContribuyenteEspecial=="S")
                        //myObject.infoNotaDebito.contribuyenteEspecial = "00000";
                        myObject.infoNotaDebito.obligadoContabilidad = obligadoContabilidad.SI.ToString();
                        myObject.infoNotaDebito.codDocModificado = "01";
                        myObject.infoNotaDebito.numDocModificado = item.vt_serie1 + "-" + item.vt_serie2 + "-" + item.vt_NumFactura;
                        myObject.infoNotaDebito.fechaEmisionDocSustento = string.Format("{0:dd/MM/yyyy}", item.vt_fecha);
                        if (item.IdTipoDocumento == "RUC")
                            myObject.infoNotaDebito.tipoIdentificacionComprador = "04";

                        if (item.IdTipoDocumento == "PAS")
                            myObject.infoNotaDebito.tipoIdentificacionComprador = "06";

                        if (item.IdTipoDocumento == "CED")
                            myObject.infoNotaDebito.tipoIdentificacionComprador = "05";

                        myObject.infoNotaDebito.razonSocialComprador = item.pe_nombreCompleto.ToString().Replace("S.A", "").Trim();
                        myObject.infoNotaDebito.identificacionComprador = item.pe_cedulaRuc;
                        myObject.infoNotaDebito.dirEstablecimiento = item.em_direccion;

                        decimal totalSinImpuestos = 0;
                        decimal total = 0;

                     
                        var facturas_imuestos = context.vwfe_nota_debito_impuestos.Where(v => v.IdEmpresa == item.IdEmpresa && v.IdSucursal == item.IdSucursal && v.IdBodega == item.IdBodega && v.IdNota == item.IdNota).ToList();
                        foreach (var item_imp in facturas_imuestos)
                        {
                            if(item_imp.vt_por_iva>0)
                            {
                            impuesto impuesto = new impuesto();
                            impuesto.codigo = "2";
                            if (item_imp.vt_por_iva == 0)
                                impuesto.codigoPorcentaje = "1";
                            if (item_imp.vt_por_iva == 12)
                                impuesto.codigoPorcentaje = "2";
                            if (item_imp.vt_por_iva == 14)
                                impuesto.codigoPorcentaje = "3";
                            impuesto.tarifa =Convert.ToDecimal( item_imp.vt_por_iva);
                            impuesto.baseImponible = Convert.ToDecimal(item_imp.Base_imponible);
                            totalSinImpuestos =totalSinImpuestos+ impuesto.baseImponible;
                            impuesto.valor = Convert.ToDecimal(item_imp.impuesto);
                            total =total+ impuesto.baseImponible + impuesto.valor;
                            myObject.infoNotaDebito.impuestos.Add(impuesto);
                            }
                        }
                        myObject.infoNotaDebito.totalSinImpuestos = Convert.ToDecimal(totalSinImpuestos);
                        myObject.infoNotaDebito.valorTotal = total;

                        myObject.motivos = new notaDebitoMotivos();
                        myObject.motivos.motivo = new List<notaDebitoMotivosMotivo>();
                        var facturas_detalle = context.vwfe_nota_debito_detalle.Where(v => v.IdEmpresa == item.IdEmpresa && v.IdSucursal == item.IdSucursal && v.IdBodega == item.IdBodega && v.IdNota == item.IdNota && v.sc_total>0).ToList();

                        foreach (var item_det in facturas_detalle)
                        {
                         notaDebitoMotivosMotivo motivos = new notaDebitoMotivosMotivo();
                         motivos.razon = item_det.pr_descripcion;
                         motivos.valor =Convert.ToDecimal( item_det.sc_subtotal);
                         myObject.motivos.motivo.Add(motivos);

                        }



                        fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();
                        myObject.infoAdicional = new List<notaDebitoCampoAdicional>();
                        if (item.Correo != null)
                        {
                            if (datosAdc.email_bien_escrito(item.Correo) == true)
                            {
                                notaDebitoCampoAdicional compoadicional = new notaDebitoCampoAdicional();
                                compoadicional.nombre = "MAIL";
                                compoadicional.Value = item.Correo;
                                myObject.infoAdicional.Add(compoadicional);
                            }
                        }
                        if (item.Telefono != null)
                        {
                            notaDebitoCampoAdicional compoadicional = new notaDebitoCampoAdicional();
                            compoadicional.nombre = "TELEFONO";
                            compoadicional.Value = item.Telefono;
                            myObject.infoAdicional.Add(compoadicional);
                        }
                        lista.Add(myObject);

                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                return new List<notaDebito>();
            }
        
           
        }

       
    }
}
