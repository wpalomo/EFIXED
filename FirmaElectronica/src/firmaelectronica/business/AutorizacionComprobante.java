/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;


/**
 *
 * @author roberto
 */
public class AutorizacionComprobante
{
    public  static String getAutorizacion(String strClaveAcceso)
        throws java.lang.Exception
    {
        long time_start, time_end;
        time_start = System.currentTimeMillis();
        
        System.out.println("Clave acceso : " + strClaveAcceso);
        
        javax.xml.soap.SOAPConnectionFactory soapConnectionFactory = javax.xml.soap.SOAPConnectionFactory.newInstance();
        javax.xml.soap.SOAPConnection connection = soapConnectionFactory.createConnection();
        javax.xml.soap.MessageFactory factory = javax.xml.soap.MessageFactory.newInstance();
        javax.xml.soap.SOAPMessage message = factory.createMessage();
        javax.xml.soap.SOAPPart sp = message.getSOAPPart();
        javax.xml.soap.SOAPEnvelope se = sp.getEnvelope();

        se.addNamespaceDeclaration("ec", "http://ec.gob.sri.ws.autorizacion");
        javax.xml.soap.SOAPHeader header = message.getSOAPHeader();
        javax.xml.soap.SOAPBody body = message.getSOAPBody();
        header.detachNode();
        
        javax.xml.namespace.QName bodyName = new javax.xml.namespace.QName(null, "autorizacionComprobante","ec");
        javax.xml.soap.SOAPBodyElement bodyElement = body.addBodyElement(bodyName);
        
        javax.xml.namespace.QName name = new javax.xml.namespace.QName("claveAccesoComprobante");
        javax.xml.soap.SOAPElement symbol = bodyElement.addChildElement(name);
        symbol.addTextNode(strClaveAcceso);
        //message.writeTo(System.out);
        
        java.net.URL endpoint = new java.net.URL( firmaelectronica.config.Config.SRI_getUrlWsdlAutorizacion() );
        javax.xml.soap.SOAPMessage response = connection.call(message, endpoint);
        java.io.ByteArrayOutputStream out = new java.io.ByteArrayOutputStream();
        response.writeTo(out);
        String strMsg = new String( out.toByteArray() );
        //application.helper.Log.writeXML(strMsg);

        byte ptext[] = strMsg.getBytes();
        strMsg = new String(ptext, "UTF-8");
        
        firmaelectronica.helper.Log.writeXML(strMsg);
        strMsg = strMsg.replace("&lt;?xml version=\"1.0\" encoding=\"UTF-8\"?&gt;","");
        
        //strMsg = strMsg.replace("&lt;?xml version=\"1.0\" encoding=\"UTF-8\"?&gt;","");
        //strMsg = strMsg.replace("&lt;","<");
        //strMsg = strMsg.replace("&gt;",">");
        //strMsg = "<![CDATA[" + strMsg + "]]";
        
        connection.close();

        time_end = System.currentTimeMillis();
        System.out.println("AUTORIZACION : "+ ( time_end - time_start ) + " milliseconds." );
        
        return strMsg;
    }
}

