using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Info.class_sri.Retencion;
using DevExpress.XtraReports.UI;
using System.Drawing;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using FirmElect.Reports;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraReports.UserDesigner;
namespace FirmElect.Reports
{
    public class Rpt_Ride_bus
    {
        String RootReporte = Ruta_Temporal + @"saveComprobante.repx";

        IRpt_Ride_Factura OBusReporteFactura;
        IRpt_Ride_Retencion OBusReporteRetencion;
        IRpt_Ride_Guia_Remis OBusReporteGuia_Remi;
        IRpt_Ride_NotaCred OBusReporteNotaCred;
        IRpt_Ride_NotaDeb OBusReporteNotaDeb;

        tb_Comprobante_tipo_Data data_ = new Data.tb_Comprobante_tipo_Data();
        List<tb_Empresa_Info> listEmpresa = new List<tb_Empresa_Info>();
        tb_Comprobante_tipo_Info Info = new tb_Comprobante_tipo_Info();
        tb_Comprobante_tipo_x_empresa_Info InfoComprobanteem = new Info.tb_Comprobante_tipo_x_empresa_Info();
        tb_Comprobante_tipo_x_empresa_Data IBusComprobanteem = new tb_Comprobante_tipo_x_empresa_Data();

        static string Ruta_Temporal = Path.GetTempPath();
        String Ruta_Reporte_Fac = Ruta_Temporal + @"Comprobante_Fac.repx";
        String Ruta_Reporte_Guia = Ruta_Temporal + @"Comprobante_Gui.repx";
        String Ruta_Reporte_Ret = Ruta_Temporal + @"Comprobante_Ret.repx";
        String Ruta_Reporte_NC = Ruta_Temporal + @"Comprobante_NC.repx";
        String Ruta_Reporte_ND = Ruta_Temporal + @"Comprobante_ND.repx";
        Funciones funciones = new Funciones();



        public Rpt_Ride_bus(List<tb_Empresa_Info> _listEmpresa )
        {

         
            listEmpresa = _listEmpresa;
        }


        private void Instanciando_clases_reporte(int IdEmpresa, ref string mensajeErrorOut)
        {
            try
            {

                string SNemonico_RIDE = "";

                try
                {
                    //si no hay nemonico tomo los reportes generales
                    SNemonico_RIDE = listEmpresa.Find(v => v.IdEmpresa == IdEmpresa).Nemonico_RIDE;
                }
                catch (Exception )
                {
                }

                if (SNemonico_RIDE == "" || SNemonico_RIDE==null)
                {
                    OBusReporteFactura = new Rpt_Ride_GEN_Factura();
                    OBusReporteRetencion = new Rpt_Ride_GEN_Retencion();
                    OBusReporteGuia_Remi = new Rpt_Ride_GEN_Guia_Remis();
                    OBusReporteNotaCred = new Rpt_Ride_GEN_NotaCred();
                    OBusReporteNotaDeb = new Rpt_Ride_GEN_NotaDeb();
                }
                else// instancio por string las clases 
                {
                    #region Instancia de Factura
                    
                        try
                        {
                            var laClase = "FirmElect.Reports.Rpt_Ride_" + SNemonico_RIDE + "_Factura";
                            Type elTipo = Type.GetType(laClase);

                            IRpt_Ride_Factura obj = ((IRpt_Ride_Factura)Activator.CreateInstance(elTipo));
                            OBusReporteFactura = obj;
                        }
                        catch (Exception ex)
                        {
                            OBusReporteFactura = new Rpt_Ride_ERROR_Factura();
                        }

                    #endregion

                    #region Instancia de Guia

                        try
                        {
                            var laClase = "FirmElect.Reports.Rpt_Ride_" + SNemonico_RIDE + "_Guia_Remis";
                            Type elTipo = Type.GetType(laClase);

                            IRpt_Ride_Guia_Remis obj = ((IRpt_Ride_Guia_Remis)Activator.CreateInstance(elTipo));
                            OBusReporteGuia_Remi = obj;
                        }
                        catch (Exception ex)
                        {
                            OBusReporteGuia_Remi = new Rpt_Ride_ERROR_Guia_Remis();
                        }

                    #endregion


                        #region Nota Cred

                        try
                        {
                            var laClase = "FirmElect.Reports.Rpt_Ride_" + SNemonico_RIDE + "_NotaCred";
                            Type elTipo = Type.GetType(laClase);

                            IRpt_Ride_NotaCred obj = ((IRpt_Ride_NotaCred)Activator.CreateInstance(elTipo));
                            OBusReporteNotaCred= obj;
                        }
                        catch (Exception ex)
                        {
                            OBusReporteNotaCred = new Rpt_Ride_ERROR_NotaCred();
                        }

                        #endregion


                        #region Nota Deb

                        try
                        {
                            var laClase = "FirmElect.Reports.Rpt_Ride_" + SNemonico_RIDE + "_NotaDeb";
                            Type elTipo = Type.GetType(laClase);

                            IRpt_Ride_NotaDeb obj = ((IRpt_Ride_NotaDeb)Activator.CreateInstance(elTipo));
                            OBusReporteNotaDeb = obj;
                        }
                        catch (Exception ex)
                        {
                            OBusReporteNotaDeb = new Rpt_Ride_ERROR_NotaDeb();
                        }

                        #endregion

                        #region Retencion

                        try
                        {
                            var laClase = "FirmElect.Reports.Rpt_Ride_" + SNemonico_RIDE + "_Retencion";
                            Type elTipo = Type.GetType(laClase);

                            IRpt_Ride_Retencion obj = ((IRpt_Ride_Retencion)Activator.CreateInstance(elTipo));
                            OBusReporteRetencion = obj;
                        }
                        catch (Exception ex)
                        {
                            OBusReporteRetencion = new Rpt_Ride_ERROR_Retencion();
                        }

                        #endregion




                }


            }
            catch (Exception ex )
            {
                mensajeErrorOut = mensajeErrorOut + ex.Message;

                
            }
        }



        public DevExpress.XtraReports.UI.XtraReport Optener_reporte(tb_Comprobante_Info InfoCbte, ref string mensajeErrorOut)
        {
            try
            { // consulto si hay reporte guardado para esa empresa por documento
                Info = data_.consultar_tipo(InfoCbte.IdEmpresa, Convert.ToString(InfoCbte.IdTipoDocumento), ref mensajeErrorOut);
               //********************** 
                
                tb_Comprobante_Data DataCbte = new tb_Comprobante_Data();
                XtraReport Reporte = new XtraReport();
                Image Logo = null;

                Instanciando_clases_reporte(InfoCbte.IdEmpresa, ref  mensajeErrorOut);


                #region Opteniendo Logo

                var q = from c in listEmpresa
                        where c.IdEmpresa == InfoCbte.IdEmpresa
                        select c;


                foreach (var item in q)
                {
                    Logo = Funciones.ArrayAImage(item.logo);
                    
                }

                #endregion


                switch (InfoCbte.IdTipoDocumento)
                {
                    case "01":
                        factura_Ride_Info InfoFactura = new factura_Ride_Info();
    
                    //  si no esta guardado el reporte en la bd
                        if (Info.ReporteBy == null)
                        {
                            InfoFactura = DataCbte.consultar_Factura_ride(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoFactura.Logo = Logo;
                            InfoFactura.numeros_en_letras = funciones.NumeroALetras(InfoFactura.factura.infoFactura.importeTotal.ToString());

                            Reporte = OBusReporteFactura.Optener_reporte(InfoFactura);
                            using (MemoryStream stream = new MemoryStream())
                            {
                                byte[] data;
                                Reporte.SaveLayout(stream);
                                data = stream.ToArray();


                  

                                // grabar bd
                                InfoComprobanteem.IdEmpresa = InfoCbte.IdEmpresa;
                                InfoComprobanteem.idComprobante_tipo = InfoCbte.IdTipoDocumento;
                                InfoComprobanteem.File_disenio_rpt = data;
                                IBusComprobanteem.ModificarDB(InfoComprobanteem, ref mensajeErrorOut);
                               
                            }
                        }
                        else
                        {
                            InfoFactura = DataCbte.consultar_Factura_ride(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoFactura.Logo = Logo;
                            InfoFactura.numeros_en_letras = funciones.NumeroALetras(InfoFactura.factura.infoFactura.importeTotal.ToString());
                            File.WriteAllBytes(Ruta_Reporte_Fac, Info.ReporteBy);                         
                            Reporte= OBusReporteFactura.Optener_reporte(InfoFactura);
                            Reporte.LoadLayout(Ruta_Reporte_Fac);

                        }




                       
                       
                        break;

                    case "04":
                        notaCredito_Ride_Info InfoNotaCred = new notaCredito_Ride_Info();
                    //  si no esta guardado el reporte en la bd
                        if (Info.ReporteBy == null)
                        {
                            InfoNotaCred = DataCbte.consultar_NotaCredito_Ride(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoNotaCred.numeros_en_letras = funciones.NumeroALetras(InfoNotaCred.notaCredito.infoNotaCredito.valorModificacion.ToString());
                            InfoNotaCred.Logo = Logo;
                            Reporte = OBusReporteNotaCred.Optener_reporte(InfoNotaCred);
                            using (MemoryStream stream = new MemoryStream())
                            {
                                byte[] data;
                                Reporte.SaveLayout(stream);
                                data = stream.ToArray();
                                // grabar bd
                                InfoComprobanteem.IdEmpresa = InfoCbte.IdEmpresa;
                                InfoComprobanteem.idComprobante_tipo = InfoCbte.IdTipoDocumento;
                                InfoComprobanteem.File_disenio_rpt = data;
                                IBusComprobanteem.ModificarDB(InfoComprobanteem, ref mensajeErrorOut);

                            }
                        }
                        else
                        {
                            InfoNotaCred = DataCbte.consultar_NotaCredito_Ride(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoNotaCred.Logo = Logo;
                            InfoNotaCred.numeros_en_letras = funciones.NumeroALetras(InfoNotaCred.notaCredito.infoNotaCredito.valorModificacion.ToString());

                            File.WriteAllBytes(Ruta_Reporte_NC, Info.ReporteBy);
                            Reporte = OBusReporteNotaCred.Optener_reporte(InfoNotaCred);
                            Reporte.LoadLayout(Ruta_Reporte_NC);

                        }

                        break;

                    case "05":
                        notaDebito_Ride_Info InfoNotaDeb = new notaDebito_Ride_Info();

                        //  si no esta guardado el reporte en la bd
                        if (Info.ReporteBy == null)
                        {
                            InfoNotaDeb = DataCbte.consultar_NotaDebito(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoNotaDeb.numeros_en_letras = funciones.NumeroALetras(InfoNotaDeb.notaDebito.infoNotaDebito.valorTotal.ToString());

                            InfoNotaDeb.Logo = Logo;
                            Reporte = OBusReporteNotaDeb.Optener_reporte(InfoNotaDeb);
                            using (MemoryStream stream = new MemoryStream())
                            {
                                byte[] data;
                                Reporte.SaveLayout(stream);
                                data = stream.ToArray();
                                // grabar bd
                                InfoComprobanteem.IdEmpresa = InfoCbte.IdEmpresa;
                                InfoComprobanteem.idComprobante_tipo = InfoCbte.IdTipoDocumento;
                                InfoComprobanteem.File_disenio_rpt = data;
                                IBusComprobanteem.ModificarDB(InfoComprobanteem, ref mensajeErrorOut);

                            }
                        }
                        else
                        {
                            InfoNotaDeb = DataCbte.consultar_NotaDebito(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoNotaDeb.Logo = Logo;
                            InfoNotaDeb.numeros_en_letras = funciones.NumeroALetras(InfoNotaDeb.notaDebito.infoNotaDebito.valorTotal.ToString());

                            File.WriteAllBytes(Ruta_Reporte_ND, Info.ReporteBy);
                            Reporte = OBusReporteNotaDeb.Optener_reporte(InfoNotaDeb);
                            Reporte.LoadLayout(Ruta_Reporte_ND);

                        }
                        


                        break;

                    case "06":
                        guiaRemision_Ride_Info InfoGuia = new guiaRemision_Ride_Info();


                        //  si no esta guardado el reporte en la bd
                        if (Info.ReporteBy == null)
                        {
                            InfoGuia = DataCbte.consultar_Guia(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoGuia.Logo = Logo;
                            Reporte = OBusReporteGuia_Remi.Optener_reporte(InfoGuia);
                            using (MemoryStream stream = new MemoryStream())
                            {
                                byte[] data;
                                Reporte.SaveLayout(stream);
                                data = stream.ToArray();
                                // grabar bd
                                InfoComprobanteem.IdEmpresa = InfoCbte.IdEmpresa;
                                InfoComprobanteem.idComprobante_tipo = InfoCbte.IdTipoDocumento;
                                InfoComprobanteem.File_disenio_rpt = data;
                                IBusComprobanteem.ModificarDB(InfoComprobanteem, ref mensajeErrorOut);

                            }
                        }
                        else
                        {
                            InfoGuia = DataCbte.consultar_Guia(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoGuia.Logo = Logo;
                            File.WriteAllBytes(Ruta_Reporte_Guia, Info.ReporteBy);
                            Reporte = OBusReporteGuia_Remi.Optener_reporte(InfoGuia);
                            Reporte.LoadLayout(Ruta_Reporte_Guia);

                        }
                        


                        break;

                    case "07":
                        comprobanteRetencion_Ride_Info InfoCbteRet = new comprobanteRetencion_Ride_Info();

                        //  si no esta guardado el reporte en la bd
                        if (Info.ReporteBy == null)
                        {
                            InfoCbteRet = DataCbte.consultar_Retencion(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoCbteRet.Logo = Logo;
                            Reporte = OBusReporteRetencion.Optener_reporte(InfoCbteRet);
                            using (MemoryStream stream = new MemoryStream())
                            {
                                byte[] data;
                                Reporte.SaveLayout(stream);
                                data = stream.ToArray();
                                // grabar bd
                                InfoComprobanteem.IdEmpresa = InfoCbte.IdEmpresa;
                                InfoComprobanteem.idComprobante_tipo = InfoCbte.IdTipoDocumento;
                                InfoComprobanteem.File_disenio_rpt = data;
                                IBusComprobanteem.ModificarDB(InfoComprobanteem, ref mensajeErrorOut);

                            }
                        }
                        else
                        {
                            InfoCbteRet = DataCbte.consultar_Retencion(InfoCbte.IdEmpresa, InfoCbte.IdComprobante, InfoCbte.IdTipoDocumento, InfoCbte.IdEstado_cbte, ref mensajeErrorOut);
                            InfoCbteRet.Logo = Logo;
                            File.WriteAllBytes(Ruta_Reporte_Ret, Info.ReporteBy);
                            Reporte = OBusReporteRetencion.Optener_reporte(InfoCbteRet);
                            Reporte.LoadLayout(Ruta_Reporte_Ret);

                        }


                        break;



                }

            return Reporte;

            }
            catch (Exception ex)
            {
                return new XtraReport();

            }

        }

        
    }
}
