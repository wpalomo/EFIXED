using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FirmElect.Info.class_sri.Retencion;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info;
namespace FirmElect.Data.Proceso_efixed
{
    public class fx_GeneradorXML_Retencion_Fixed : fx_GeneradorXML_IRetencion
   {
      
       public List<comprobanteRetencion> GenerarXmlRetencion(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB)
       {
           //string sFi, sFf;
           //sFi = string.Format(formatoFechaDB, FechaIni);
           //sFf = string.Format(formatoFechaDB, FechaFin);
           DateTime Fi = Convert.ToDateTime(FechaIni.ToShortDateString());
           DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());
           List<comprobanteRetencion> lista = new List<comprobanteRetencion>();

           try
           {
               using (Entity_conexion_efixed Context = new Entity_conexion_efixed())
               {
                   var retenciones = Context.vwfe_retencion.Where(v => v.fecha >= Fi && v.fecha <= Ff);

                   foreach (var item in retenciones)
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
                           myObjectRete.infoTributaria.razonSocial = item.RazonSocial;
                           myObjectRete.infoTributaria.nombreComercial = item.NombreComercial;
                           myObjectRete.infoTributaria.ruc = item.em_ruc;
                           myObjectRete.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                           myObjectRete.infoTributaria.codDoc = "07";
                           myObjectRete.infoTributaria.estab = item.serie1;
                           myObjectRete.infoTributaria.ptoEmi = item.serie2;
                           myObjectRete.infoTributaria.secuencial = Convert.ToString(item.NumRetencion);
                           myObjectRete.infoTributaria.dirMatriz = item.em_direccion;
                           myObjectRete.infoCompRetencion.fechaEmision = string.Format("{0:dd/MM/yyyy}", item.fecha);//.Trim();
                           myObjectRete.infoCompRetencion.dirEstablecimiento = item.em_direccion;
                           //if (item.ContribuyenteEspecial != "0000")
                           //{
                           //    myObjectRete.infoCompRetencion.contribuyenteEspecial = item.ContribuyenteEspecial;
                           //} 
                           myObjectRete.infoCompRetencion.obligadoContabilidad = "SI";
                           if (item.IdTipoDocumento == "RUC")
                               myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "04";

                           if (item.IdTipoDocumento == "PAS")
                               myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "06";

                           if (item.IdTipoDocumento == "CED")
                               myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "05"; 
                           myObjectRete.infoCompRetencion.razonSocialSujetoRetenido =(item.pe_nombreCompleto.ToString().Replace("S.A","")).Trim();
                           myObjectRete.infoCompRetencion.identificacionSujetoRetenido = Convert.ToString(item.pe_cedulaRuc);
                           myObjectRete.infoCompRetencion.periodoFiscal = Convert.ToString(myObjectRete.infoCompRetencion.fechaEmision).Substring(3, 7);
                           // sentencia para extraer detalle de retencion
                           var retencion_det = Context.vwfe_retencion_detalle.Where(v => v.IdEmpresa ==item.IdEmpresa && v.IdRetencion == item.IdRetencion).ToList();

                           foreach (var item_det in retencion_det)
                           {
                                FirmElect.Info.class_sri.Retencion.impuesto imp = new FirmElect.Info.class_sri.Retencion.impuesto();
                                if (item_det.re_tipoRet == "RTF")
                                    imp.codigo = "1";
                                else
                                    imp.codigo = "2";
                                if (item_det.re_tipoRet != "RTF")
                                {
                                    if(item_det.re_Porcen_retencion==10)
                                        imp.codigoRetencion = "09";
                                    if (item_det.re_Porcen_retencion == 20)
                                        imp.codigoRetencion = "10";
                                    if (item_det.re_Porcen_retencion == 30)
                                        imp.codigoRetencion = "1";
                                    if (item_det.re_Porcen_retencion == 50)
                                        imp.codigoRetencion = "11";
                                    if (item_det.re_Porcen_retencion == 70)
                                        imp.codigoRetencion = "2";
                                    if (item_det.re_Porcen_retencion == 100)
                                        imp.codigoRetencion = "3";
                                }
                                else
                                {
                                    imp.codigoRetencion = item_det.re_Codigo_impuesto;
                                }
                                imp.baseImponible =Convert.ToDecimal( item_det.baseRetencion);
                                imp.porcentajeRetener = Convert.ToDecimal(item_det.re_Porcen_retencion);
                                imp.valorRetenido =Convert.ToDecimal(item_det.re_valor_retencion);
                                imp.codDocSustento = item.IdOrden_giro_Tipo.ToString();
                                imp.numDocSustento = item.co_serie.Substring(0, 3) + item.co_serie.Substring(4, 3) + item.co_factura;
                                imp.fechaEmisionDocSustento = string.Format("{0:dd/MM/yyyy}", item.co_fechaOg);//.Trim();
                               myObjectRete.impuestos.Add(imp);
                           }
                               // campos adicionales 
                           if (item.pe_correo == null)
                               item.pe_correo = "";
                               fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();

                               if (datosAdc.email_bien_escrito(item.pe_correo) == true)
                               {
                                   myObjectRete.infoAdicional = new List<comprobanteRetencionCampoAdicional>();
                                   comprobanteRetencionCampoAdicional compoadicional = new comprobanteRetencionCampoAdicional();
                                   compoadicional.nombre = "MAIL";
                                   compoadicional.Value = item.pe_correo;
                                   myObjectRete.infoAdicional.Add(compoadicional);
                               }

                              


                          
                               lista.Add(myObjectRete);
                           }
                       
                       catch (Exception ex)
                       {

                       }
                   }
                
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
