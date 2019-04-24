/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;

public class RecepcionComprobante
{
    public RecepcionComprobante()
    {
    }

    public String RecepcionAutorizacion(String pathComprobante)
        throws java.lang.Exception
    {
        String strXML;
        
        java.io.File archivo = new java.io.File(pathComprobante);
        
        ec.gob.sri.comprobantes.ws.RespuestaSolicitud res = this.enviarComprobante(archivo);

        com.thoughtworks.xstream.XStream xStream = new com.thoughtworks.xstream.XStream();

        strXML = xStream.toXML( res);

        return strXML;
    }
     
    public ec.gob.sri.comprobantes.ws.RespuestaSolicitud enviarComprobante( java.io.File xmlFile )
        throws java.lang.Exception
    {
        ec.gob.sri.comprobantes.ws.RespuestaSolicitud response;
        
        javax.xml.namespace.QName qname;
        java.net.URL url;
        ec.gob.sri.comprobantes.ws.RecepcionComprobantesOfflineService service;
        ec.gob.sri.comprobantes.ws.RecepcionComprobantesOffline port;
        
        url = new java.net.URL( firmaelectronica.config.Config.SRI_getUrlWsdlRecepcion() );
        //qname = new javax.xml.namespace.QName(firmaelectronica.config.Config.SRI_getRecepcionWsdlNamespace(), firmaelectronica.config.Config.SRI_getRecepcionWsdlLocalPart());
          qname = new javax.xml.namespace.QName("http://ec.gob.sri.ws.recepcion", "RecepcionComprobantesOfflineService");

        
        service = new ec.gob.sri.comprobantes.ws.RecepcionComprobantesOfflineService(url, qname);
        
        
        
        
        try
        {
            port = service.getRecepcionComprobantesOfflinePort();
            response = port.validarComprobante( firmaelectronica.helper.File.toByte(xmlFile) );
        }
        catch( java.io.IOException e )
        {
            response = new ec.gob.sri.comprobantes.ws.RespuestaSolicitud();
            response.setEstado( e.getMessage() );
        }
        
        return response;
    }
}

