using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.GuiaRemision;
using System.Data.SqlClient;
using FirmElect.Info;
using FirmElect.Info.class_sri.Factura_V2;
namespace FirmElect.Data.Proceso_efixed
{
    public class fx_Generador_XML_Guia_Fixed : fx_GeneradorXML_IGuia
    {
      
      
        public List<Info.class_sri.GuiaRemision.guiaRemision> GenerarXmlRetencion(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente, string OconEfirm, string FormatoFechaSRI, string formatoFechaDB)
        {
            DateTime Fi = Convert.ToDateTime(FechaIni.ToShortDateString());
            DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());
            string sFi, sFf;
            sFi = string.Format(formatoFechaDB, Fi);
            sFf = string.Format(formatoFechaDB, Ff);


            try
            {
                List<guiaRemision> lista = new List<guiaRemision>();
                using (Entity_conexion_efixed context = new Entity_conexion_efixed())
                {
                    var guiaRemisions = context.vwfe_guia_remision.Where(v => v.gi_fecha >= Fi && v.gi_fecha <= Ff).ToList();
                    foreach (var item in guiaRemisions)
                    {


                        guiaRemision myObject = new guiaRemision();
                        myObject.version = "1.1.0";
                        myObject.id = guiaRemisionID.comprobante;
                        infoTributaria info = new infoTributaria();
                        myObject.infoGuiaRemision = new guiaRemisionInfoGuiaRemision();
                        destinatario destinatario = new Info.class_sri.GuiaRemision.destinatario();

                        myObject.infoTributaria = info;
                        myObject.destinatarios = new guiaRemisionDestinatarios();
                        info.ambiente = "1";
                        myObject.infoTributaria.tipoEmision = "1";
                        myObject.infoTributaria.razonSocial = item.RazonSocial;
                        myObject.infoTributaria.nombreComercial = item.NombreComercial;
                        myObject.infoTributaria.ruc = item.em_ruc;
                        myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                        //*********************************************************************************
                        myObject.infoTributaria.codDoc = "06";
                        myObject.infoTributaria.estab = item.Serie1;
                        myObject.infoTributaria.ptoEmi = item.Serie2;
                        myObject.infoTributaria.secuencial = item.NumGuia_Preimpresa;
                        myObject.infoTributaria.dirMatriz = item.em_direccion;
                        myObject.infoGuiaRemision.dirEstablecimiento = item.em_direccion;
                        myObject.infoGuiaRemision.dirPartida = item.Direccion_Origen;
                        myObject.infoGuiaRemision.razonSocialTransportista = item.Nombre;
                        myObject.infoGuiaRemision.rucTransportista = item.Cedula;
                        myObject.infoGuiaRemision.placa = item.placa;
                        if (item.Cedula.Length == 10)
                            myObject.infoGuiaRemision.tipoIdentificacionTransportista = "05";

                        if (item.Cedula.Length == 13)
                            myObject.infoGuiaRemision.tipoIdentificacionTransportista = "04";

                        myObject.infoGuiaRemision.fechaIniTransporte = string.Format("{0:dd/MM/yyyy}", item.gi_FechaInicioTraslado);
                        myObject.infoGuiaRemision.fechaFinTransporte = string.Format("{0:dd/MM/yyyy}", item.gi_FechaFinTraslado);
                        myObject.infoGuiaRemision.obligadoContabilidad = obligadoContabilidad.SI.ToString();
                        if (item.ContribuyenteEspecial == "S")
                        {
                            myObject.infoGuiaRemision.contribuyenteEspecial = "1234";
                        }
                       
                        var facturas_x_guias = context.vwfe_guia_remision_x_factura.Where(v =>v.IdEmpresa == item.IdEmpresa && v.IdGuiaRemision == item.IdGuiaRemision).ToList();
                        myObject.destinatarios.destinatario = new List<destinatario>();
                        foreach (var item_fac in facturas_x_guias)
                        {
                            destinatario.identificacionDestinatario = item.pe_cedulaRuc;
                            destinatario.razonSocialDestinatario = item.pe_nombreCompleto;
                            destinatario.dirDestinatario = item.Direccion;
                            destinatario.motivoTraslado = item.gi_Observacion;
                            destinatario.codEstabDestino = item_fac.vt_serie1;
                            destinatario.ruta = item.ruta;
                            destinatario.codDocSustento = "01";
                            destinatario.numDocSustento = item_fac.vt_serie1 + "-" + item_fac.vt_serie2 + "-" + item_fac.vt_NumFactura;
                            destinatario.numAutDocSustento = item_fac.vt_autorizacion;
                            destinatario.fechaEmisionDocSustento = string.Format("{0:dd/MM/yyyy}", item.gi_fecha);
                            myObject.destinatarios.destinatario.Add(destinatario);
                        }

                        var guia_detalle = context.vwfe_guia_remision_detalle.Where(v => v.IdEmpresa == item.IdEmpresa && v.IdGuiaRemision == item.IdGuiaRemision).ToList();
                        destinatario.detalles = new destinatarioDetalles();
                        destinatario.detalles.detalle = new List<detalle>();
                        foreach (var item_det in guia_detalle)
                        {
                            destinatario.detalles.detalle.Add(new detalle
                            {
                                codigoAdicional=item_det.pr_codigo,
                                codigoInterno=item_det.pr_codigo,
                                descripcion=item_det.pr_descripcion,
                                cantidad=Convert.ToDecimal( item_det.gi_cantidad),
                                 

                            });
                        }
                        // campos adicionales 

                        fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();
                        myObject.infoAdicional = new List<guiaRemisionCampoAdicional>();
                        if (item.Correo != null)
                        {
                            if (datosAdc.email_bien_escrito(item.Correo) == true)
                            {
                                guiaRemisionCampoAdicional compoadicional = new guiaRemisionCampoAdicional();
                                compoadicional.nombre = "MAIL";
                                compoadicional.Value = item.Correo;
                                myObject.infoAdicional.Add(compoadicional);
                            }
                        }
                        if (item.Telefono != null)
                        {
                            guiaRemisionCampoAdicional compoadicional = new guiaRemisionCampoAdicional();
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
                return new List<guiaRemision>();
            }
        }
    }
}