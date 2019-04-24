using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Info.class_sri.Retencion;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;

namespace FirmElect.Info
{
  public  class fx_GeneradorXML_Comprobante_Info
    {
        public string IdComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public eTipoComprobante TipoCbte { get; set; }
        public string Observacion { get; set; }

        public factura CbteFactura { get; set; }
        public comprobanteRetencion cbteRet { get; set; }
        public notaCredito cbteNC { get; set; }
        public notaDebito cbteDeb { get; set; }
        public guiaRemision cbtGR { get; set; }
        public factura cbtFacruraR { get; set; }
        public Boolean Checked { get; set; }
        public string xml { get; set; }

        public fx_GeneradorXML_Comprobante_Info()
        {

        }

        public fx_GeneradorXML_Comprobante_Info(string _IdComprobante, DateTime _Fecha, eTipoComprobante _TipoCbte
            , string _Observacion, factura _CbteFactura)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            CbteFactura = _CbteFactura;
        }

        public fx_GeneradorXML_Comprobante_Info(string _IdComprobante, DateTime _Fecha, eTipoComprobante _TipoCbte
             , string _Observacion, guiaRemision _cbtGR)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbtGR = _cbtGR;
        }




        public fx_GeneradorXML_Comprobante_Info(string _IdComprobante, DateTime _Fecha, eTipoComprobante _TipoCbte
              , string _Observacion, notaCredito _cbteNC)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbteNC = _cbteNC;

        }




        public fx_GeneradorXML_Comprobante_Info(string _IdComprobante, DateTime _Fecha, eTipoComprobante _TipoCbte
               , string _Observacion, notaDebito _cbteDeb)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbteDeb = _cbteDeb;

        }

        public fx_GeneradorXML_Comprobante_Info(string _IdComprobante, DateTime _Fecha, eTipoComprobante _TipoCbte
                , string _Observacion, comprobanteRetencion _cbteRet)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbteRet = _cbteRet;

        }

    }
}
