/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.config;

public class Config
{
    static private org.ini4j.Ini ini = null;
    static private String strInitException = "";
    
    static private String SRI_ambiente = "";
    static private String SRI_urlWsdlRecepcion = "";
    static private String SRI_urlWsdlAutorizacion = "";
    
    static private String PROXY_URL  = "";
    static private String PROXY_PORT = "";
    static private String PROXY_USER = "";
    static private String PROXY_PASS = "";
    
    static public boolean init()
    {
        boolean isInit = true;
        
        // READ CONFIG
        
        try
        {
            ini = new org.ini4j.Ini( new java.io.File("resources/config.ini") );
        }
        catch( java.io.IOException ex )
        {
            isInit = false;
            strInitException = ex.getMessage() + "\n";
            strInitException += "Archivo no encontrado: resources/config.ini";
        }
        
        // CHECK FOLDERS
        
        firmaelectronica.helper.Folder.create("resources");
        firmaelectronica.helper.Folder.create("resources/log");
        firmaelectronica.helper.Folder.create("resources/tmp");
        
        return isInit;
    }
    
    static public org.ini4j.Ini getIni()
    {
        return ini;
    }
    
    static public String initException()
    {
        return strInitException;
    }
    
    // ==============================================================
    // ==============================================================
    
    static public String get( String strHeader, String strKey )
    {
        return ini.get("header", "key");
    }
    
    // ==============================================================
    //  S R I
    // ==============================================================
    
    static public boolean SRI_isConfigValido()
    {
        return !( SRI_getUrlWsdlRecepcion().isEmpty() || SRI_getUrlWsdlAutorizacion().isEmpty() );
    }
    
    static public void SRI_setAmbiente( String strAmbiente )
    {
        SRI_ambiente = strAmbiente;
        System.out.println("SRI Ambiente : " + SRI_ambiente);
    }
    
    static public String SRI_getAmbiente()
    {
        return SRI_ambiente;
    }
    
    static public void SRI_setUrlWsdlRecepcion( String strUrlWsdl )
    {
        SRI_urlWsdlRecepcion = strUrlWsdl;
        System.out.println("SRI Wsdl Recepcion : " + SRI_urlWsdlRecepcion);
    }
    
    static public String SRI_getUrlWsdlRecepcion()
    {
        return SRI_urlWsdlRecepcion;
    }
    
    static public void SRI_setUrlWsdlAutorizacion( String strUrlWsdl )
    {
        SRI_urlWsdlAutorizacion = strUrlWsdl;
        System.out.println("SRI Wsdl Autorizacion : " + SRI_urlWsdlAutorizacion);
    }
    
    static public String SRI_getUrlWsdlAutorizacion()
    {
        return SRI_urlWsdlAutorizacion;
    }
    
    static public String SRI_getRecepcionWsdlNamespace()
    {
        return "http://ec.gob.sri.ws.recepcion";
    }
    
    static public String SRI_getRecepcionWsdlLocalPart()
    {
        return "RecepcionComprobantesOfflineService";
    }
    
    // ==============================================================
    //  P R O X Y
    // ==============================================================
    
    static public void PROXY_setUrl( String strUrl )
    {
        PROXY_URL = strUrl;
        
        System.out.println("PROXY URL : " + PROXY_URL);
        PROXY_init();
    }
    
    static public String PROXY_getUrl()
    {
        return PROXY_URL;
    }
    
    static public void PROXY_setPort( String strPort )
    {
        PROXY_PORT = strPort;
        
        System.out.println("PROXY PORT : " + PROXY_PORT);
        PROXY_init();
    }
    
    static public String PROXY_getPort()
    {
        return PROXY_PORT;
    }
    
    static public void PROXY_setUser( String strUser )
    {
        PROXY_USER = strUser;
        
        System.out.println("PROXY USER : " + PROXY_USER);
        PROXY_init();
    }
    
    static public String PROXY_getUser()
    {
        return PROXY_USER;
    }
    
    static public void PROXY_setPass( String strPass )
    {
        PROXY_PASS = strPass;
        
        System.out.println("PROXY PASS : " + PROXY_PASS);
        PROXY_init();
    }
    
    static public String PROXY_getPass()
    {
        return PROXY_PASS;
    }
    
    static public void PROXY_init()
    {
        String url  = PROXY_getUrl();
        String port = PROXY_getPort();
        String user = PROXY_getUser();
        String pass = PROXY_getPass();
        
        System.setProperty("java.net.useSystemProxies", url.isEmpty() ? "false" : "true" );
        System.setProperty("proxySet", url.isEmpty() ? "false" : "true");

        System.setProperty("http.proxyHost", url);
        System.setProperty("https.proxyHost", url);
        System.setProperty("http.proxyPort", port);
        System.setProperty("https.proxyPort", port);
        System.setProperty("http.proxyUser", user);
        System.setProperty("http.proxyPassword", pass);
    }
    
    // ==============================================================
    // ==============================================================
    
    static public String App_getUrlWS()
    {
        return ini.get("APP","url_ws");
    }
    
    static public String App_getPathLog()
    {
        return ini.get("APP","path_log");
    }
    
    static public String App_getPathP12()
    {
        return ini.get("APP","path_p12");
    }
    
    static public String App_getPathEPass3003AutoDLL()
    {
        return ini.get("APP","path_epass3003auto_dll");
    }
    
    static public boolean App_isDebug()
    {
        return ini.get("APP","debug").compareTo("1") == 0;
    }
}
