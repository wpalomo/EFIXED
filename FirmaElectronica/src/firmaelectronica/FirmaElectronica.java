package firmaelectronica;
import firmaelectronica.WS.*;
public class FirmaElectronica
{
    public static void main(String[] args)
    {
        System.out.println("Versión: 0.03");
        System.setProperty("javax.net.ssl.trustStore", "resources/jssecacerts");
        System.setProperty("javax.net.ssl.trustStorePassword", "changeit");
        
        boolean isInit = firmaelectronica.config.Config.init();
        boolean isTest = false;
        //boolean isGUI = false;
        
        for( String arg : args )
        {
            if( arg.compareTo("-test") == 0 )
            {
                isTest = true;
            }
        }
        
        if( !isInit )
        {
            System.out.println("No se pudo leer archivo de configuración");
            firmaelectronica.helper.Log.writeTXT( firmaelectronica.config.Config.initException() );
            System.exit(0);
        }
        
        if( isTest ) // for test
        {
            firmaelectronica.test.Test.execute();
        }
        else // for webservice
        {
            // in browser http://localhost:8094/Cal?wsdl
            String strUrlWS = firmaelectronica.config.Config.App_getUrlWS();
            System.out.println( strUrlWS+"?wsdl" );

            javax.xml.ws.Endpoint endpoint = javax.xml.ws.Endpoint.publish(strUrlWS, new EFirm());
            System.out.println( endpoint.isPublished() );
        }
    }
}
