using FirmElect.Bus;
using FirmElect.Info;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info.class_sri.Retencion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;

namespace FirmaElect.GenerarXML
{
    class prueba
    {

        #region variables


        string msg = "";
        StreamWriter myWriter;
        DirectoryInfo DirIn;
        eCliente Cliente;
        // instancias de clases
        string ConexionDbcliente = "";
        string ClienteFuente = "";
        string formatoFechaDB = "";
        string FormatoFechaSRI = "";

        BindingList<fx_GeneradorXML_Comprobante_Info> listado_cbtes_info = null;

        List<factura> listadoFaactura = null;
        List<comprobanteRetencion> listadoRetencion = null;
        List<notaCredito> listadoNC = null;
        List<notaDebito> listadoND = null;
        List<guiaRemision> listadoGR = null;

        //instanacia de clase para obtener la configuracion del horario
        fx_horario_Info horario = new fx_horario_Info();

        fx_Factura_Bus OBusFac = null;
        fx_NotaCredito_Bus OBusNC = null;
        fx_Retencion_Bus OBusRet = null;
        fx_Comprobantes_generados_Bus ObuscComp = null;
        fx_GuiaRemision_Bus OBusGuia = null;
        fx_NotaDebito_Bus OBusND = null;


        int countSegundosSensor_firmar = 0;
        int countSegundosRefrescarFiles = 0;
        int TiempoEspera_Proceso1 = 0;
        int TiempoEspera_Proceso2 = 0;
        string CadenaBusqueda = "";
        string mensajeError = "";
        #endregion

      public  void CargarDatos()
        {
            string OconEfirm = Efirm.Properties.Settings.Default.Ocon_Efirm;
            try
            {

                ClienteFuente = Efirm.Properties.Settings.Default.Cliente_Fuente;
                Cliente = (eCliente)Enum.Parse(typeof(eCliente), ClienteFuente);

                ConexionDbcliente = Efirm.Properties.Settings.Default.Conexioncliente;
                formatoFechaDB = Efirm.Properties.Settings.Default.Formato_fecha;

                FormatoFechaSRI = Efirm.Properties.Settings.Default.Formato_fecha_xml_sri;

            }
            catch (Exception ex)
            {


                return;
            }



            DateTime fechaI, fchaF;
            fechaI = Convert.ToDateTime(DateTime.Now.AddMonths(-1));
            fchaF = Convert.ToDateTime(DateTime.Now.AddDays(1));
            listado_cbtes_info = new BindingList<fx_GeneradorXML_Comprobante_Info>();


            try
            {


                #region listados de facturas
                OBusFac = new fx_Factura_Bus();
                listadoFaactura = new List<factura>();
                listadoFaactura = OBusFac.GenerarXmlFactura(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);
                foreach (var item in listadoFaactura)
                {
                    DateTime fecha;
                    try
                    {
                        fecha = Convert.ToDateTime(item.infoFactura.fechaEmision);
                        listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                            , Convert.ToDateTime(fecha), eTipoComprobante.Factura
                            , item.infoFactura.razonSocialComprador, item)
                            );
                    }
                    catch (Exception ex)
                    {
                    }
                }
                #endregion

                #region  listados de Retenciones
                OBusRet = new fx_Retencion_Bus();
                listadoRetencion = new List<comprobanteRetencion>();
                listadoRetencion = OBusRet.GenerarXmlRetencion(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);
                foreach (var item in listadoRetencion)
                {
                    try
                    {
                        listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                           , Convert.ToDateTime(item.infoCompRetencion.fechaEmision), eTipoComprobante.Retencion
                           , item.infoCompRetencion.razonSocialSujetoRetenido, item));
                    }
                    catch (Exception ex) { }
                }
                #endregion

                #region  LISTADOS DE NOTAS DE CREDITOS

                OBusNC = new fx_NotaCredito_Bus();
                listadoNC = new List<notaCredito>();
                listadoNC = OBusNC.GenerarXmlNC(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);
                foreach (var item in listadoNC)
                {
                    try
                    {
                        listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                             , Convert.ToDateTime(item.infoNotaCredito.fechaEmision), eTipoComprobante.NotaCred
                             , item.infoNotaCredito.razonSocialComprador, item));
                    }
                    catch (Exception ex) { }
                }
                #endregion

                #region  LISTADOS DE guias de remision
                OBusGuia = new fx_GuiaRemision_Bus();
                listadoGR = new List<guiaRemision>();
                listadoGR = OBusGuia.GenerarXmlGuiaRemision(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);

                foreach (var item in listadoGR)
                {
                    try
                    {
                        listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                             , Convert.ToDateTime(item.infoGuiaRemision.fechaIniTransporte), eTipoComprobante.Guia
                             , item.infoGuiaRemision.razonSocialTransportista, item));
                    }
                    catch (Exception ex) { }
                }

                #endregion


                #region  LISTADOS DE NOTA EBITO
                OBusND = new fx_NotaDebito_Bus();
                listadoND = new List<notaDebito>();
                listadoND = OBusND.GenerarXmlND(fechaI, fchaF, ConexionDbcliente, OconEfirm, FormatoFechaSRI, formatoFechaDB, Cliente);

                foreach (var item in listadoND)
                {
                    try
                    {
                        listado_cbtes_info.Add(new fx_GeneradorXML_Comprobante_Info(item.infoTributaria.secuencial
                             , Convert.ToDateTime(item.infoNotaDebito.fechaEmision), eTipoComprobante.NotaDeb
                             , item.infoNotaDebito.razonSocialComprador, item));
                    }
                    catch (Exception ex) { }
                }

                #endregion

                if (listado_cbtes_info == null)
                {

                }

            }
            catch (Exception ex)
            {
            }
            finally
            {

            }

        }


      public  void GenerarArchivosXml()
        {
            //splashScreenManager1.ShowWaitForm();
            try
            {

                foreach (var item in listado_cbtes_info)
                {
                    string sIdCbteFact = "";
                    //item.CbteFactura.infoTributaria = new infoTributaria();


                    // si es factura
                    if (item.TipoCbte == eTipoComprobante.Factura)
                    {
                        try
                        {

                            sIdCbteFact = item.CbteFactura.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.FAC + "-" + item.CbteFactura.infoTributaria.estab + "-" + item.CbteFactura.infoTributaria.ptoEmi + "-" + item.CbteFactura.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(factura));

                            myWriter = new StreamWriter(Efirm.Properties.Settings.Default.PatchXml + sIdCbteFact + ".xml");


                            mySerializer.Serialize(myWriter, item.CbteFactura, NamespaceObject);
                            myWriter.Close();
                            // GRABAR COMP
                            ObuscComp = new fx_Comprobantes_generados_Bus();
                            fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                            comprobante.IdRegistro = sIdCbteFact;
                            comprobante.Estado = "A";
                            ObuscComp.GuardarComprobantes_generados_FX(comprobante);

                        }
                        catch (Exception ex) { }

                    }
                    // si es retencion
                    else if (item.TipoCbte == eTipoComprobante.Retencion)
                    {
                        try
                        {
                            sIdCbteFact = item.cbteRet.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.RET + "-" + item.cbteRet.infoTributaria.estab + "-" + item.cbteRet.infoTributaria.ptoEmi + "-" + item.cbteRet.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(comprobanteRetencion));


                            myWriter = new StreamWriter(Efirm.Properties.Settings.Default.PatchXml + sIdCbteFact + ".xml");
                            mySerializer.Serialize(myWriter, item.cbteRet, NamespaceObject);
                            myWriter.Close();
                            // GRABAR COMP
                            ObuscComp = new fx_Comprobantes_generados_Bus();
                            fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                            comprobante.IdRegistro = sIdCbteFact;
                            comprobante.Estado = "A";
                            ObuscComp.GuardarComprobantes_generados_FX(comprobante);
                        }
                        catch (Exception ex) { }
                    }
                    // si es nota de credito
                    else if (item.TipoCbte == eTipoComprobante.NotaCred)
                    {
                        try
                        {
                            sIdCbteFact = item.cbteNC.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.NTC + "-" + item.cbteNC.infoTributaria.estab + "-" + item.cbteNC.infoTributaria.ptoEmi + "-" + item.cbteNC.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(notaCredito));


                            myWriter = new StreamWriter(Efirm.Properties.Settings.Default.PatchXml + sIdCbteFact + ".xml");

                            mySerializer.Serialize(myWriter, item.cbteNC, NamespaceObject);
                            myWriter.Close();
                            // GRABAR COMP
                            ObuscComp = new fx_Comprobantes_generados_Bus();
                            fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                            comprobante.IdRegistro = sIdCbteFact;
                            comprobante.Estado = "A";
                            ObuscComp.GuardarComprobantes_generados_FX(comprobante);

                        }
                        catch (Exception ex) { }
                    }

                    // si es guia de remision
                    else if (item.TipoCbte == eTipoComprobante.Guia)
                    {
                        try
                        {
                            sIdCbteFact = sIdCbteFact = item.cbtGR.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.GUI + "-" + item.cbtGR.infoTributaria.estab + "-" + item.cbtGR.infoTributaria.ptoEmi + "-" + item.cbtGR.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(guiaRemision));


                            myWriter = new StreamWriter(Efirm.Properties.Settings.Default.PatchXml + sIdCbteFact + ".xml");
                            mySerializer.Serialize(myWriter, item.cbtGR, NamespaceObject);
                            myWriter.Close();
                            // GRABAR COMP
                            ObuscComp = new fx_Comprobantes_generados_Bus();
                            fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                            comprobante.IdRegistro = sIdCbteFact;
                            comprobante.Estado = "A";
                            ObuscComp.GuardarComprobantes_generados_FX(comprobante);
                        }
                        catch (Exception ex) { }
                    }
                    // si es nota debito
                    else if (item.TipoCbte == eTipoComprobante.NotaDeb)
                    {
                        try
                        {
                            sIdCbteFact = sIdCbteFact = item.cbteDeb.infoTributaria.razonSocial.Substring(0, 3) + "-" + eTipoCodComprobante.NTD + "-" + item.cbteDeb.infoTributaria.estab + "-" + item.cbteDeb.infoTributaria.ptoEmi + "-" + item.cbteDeb.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(notaDebito));
                            myWriter = new StreamWriter(Efirm.Properties.Settings.Default.PatchXml + sIdCbteFact + ".xml");
                            mySerializer.Serialize(myWriter, item.cbteDeb, NamespaceObject);
                            myWriter.Close();
                            // GRABAR COMP
                            ObuscComp = new fx_Comprobantes_generados_Bus();
                            fx_Comprobante_generados_Info comprobante = new fx_Comprobante_generados_Info();
                            comprobante.IdRegistro = sIdCbteFact;
                            comprobante.Estado = "A";
                            ObuscComp.GuardarComprobantes_generados_FX(comprobante);
                        }
                        catch (Exception ex) { }
                    }
                }


            }
            catch (Exception ex)
            {


            }
            finally
            {

            }

        }
    }
}
