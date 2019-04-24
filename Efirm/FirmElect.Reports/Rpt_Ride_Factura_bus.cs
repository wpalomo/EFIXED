using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Bus;
using FirmElect.Info.class_sri.Factura;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Info.class_sri.Retencion;
using DevExpress.XtraReports.UI;



namespace FirmElect.Reports
{
    public class Rpt_Ride_Factura_bus
    {

        IRpt_Ride_Factura OBusReporte;

        public Rpt_Ride_Factura_bus()
        {

            OBusReporte = new Rpt_Ride_Factura_Gen();

        }



        public DevExpress.XtraReports.UI.XtraReport Optener_reporte(int IdEmpresa, string IdComprobante, eTipoComprobante IdTipoDocumento
        , string IdEstado_cbte, ref string mensajeErrorOut)
        {
            try
            {
                tb_Comprobante_Bus BusCbte = new tb_Comprobante_Bus();
                XtraReport Reporte = new XtraReport();
                
                                    
            factura InfoFactura = new factura();
            InfoFactura = BusCbte.consultar_Factura(IdEmpresa, IdComprobante, "01", IdEstado_cbte, ref mensajeErrorOut);
            Reporte= OBusReporte.Optener_reporte(InfoFactura);

            return Reporte;



                //        break;

                //    case eTipoComprobante.NotaCredito:
                //                notaCredito InfoNotaCred = new notaCredito();
                //                InfoNotaCred = BusCbte.consultar_NotaCredito(IdEmpresa, IdComprobante, "04", IdEstado_cbte, ref mensajeErrorOut);
                                
                //        break;

                //    case eTipoComprobante.NotaDebito:
                //                notaDebito InfoNotaDeb = new notaDebito();
                //                InfoNotaDeb = BusCbte.consultar_NotaDebito(IdEmpresa, IdComprobante, "05", IdEstado_cbte, ref mensajeErrorOut);
                                
                //        break;

                //    case eTipoComprobante.Guia:
                //                guiaRemision InfoGuia = new guiaRemision();
                //                InfoGuia = BusCbte.consultar_Guia(IdEmpresa, IdComprobante, "06", IdEstado_cbte, ref mensajeErrorOut);
                        
                                
                //        break;

                //    case eTipoComprobante.Retencion:
                //        comprobanteRetencion InfoCbteRet = new comprobanteRetencion();
                //        InfoCbteRet = BusCbte.consultar_Retencion(IdEmpresa, IdComprobante, "06", IdEstado_cbte, ref mensajeErrorOut);


                //        break;
                
                //}




                

            }
            catch (Exception ex)
            {
                return new XtraReport();

            }

        }

        
    }
}
