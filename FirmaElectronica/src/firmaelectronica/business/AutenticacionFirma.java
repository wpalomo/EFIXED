/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;
import sun.security.pkcs11.wrapper.PKCS11Exception;
import firmaelectronica.config.*;
import  firmaelectronica.clases.*;
import  firmaelectronica.controller.*;
import  firmaelectronica.helper.*;
import  firmaelectronica.test.*;
public class AutenticacionFirma
{
    public static final int AUTH_CERTIFICADO = 1;
    public static final int AUTH_TOKEN = 2;
    public static final int AUTH_EPASS = 3;
    
    private static java.security.KeyStore keyStore = null;
    private static String strContrasena = "";
    private static int AUTH_TYPE = 0;
    
    //private static String libraryName = System.getenv("WINDIR") + "\\SYSTEM32\\DKCK201.DLL";
    //private static String windowsDir_iKey = "name = SmartCard\nlibrary = " +  System.getenv("WINDIR") + "\\SYSTEM32\\DKCK201.DLL \ndisabledMechanisms = { CKM_SHA1_RSA_PKCS  } \n showInfo = true";
    //private static final byte[] PKCS11_CONFIG_IKEY = windowsDir_iKey.getBytes();
    //private static final String SUN_PKCS11_PROVIDER_CLASS = "sun.security.pkcs11.SunPKCS11";

    public static java.security.KeyStore getKeyStore()
    {
        return firmaelectronica.business.AutenticacionFirma.keyStore;
    }
    
    public static String getContrasena()
    {
        return firmaelectronica.business.AutenticacionFirma.strContrasena;
    }
    
    public static int getAuthType()
    {
        return firmaelectronica.business.AutenticacionFirma.AUTH_TYPE;
    }
    
    // **********************************************************************
    // **********************************************************************
    
    public static void init( int AUTH_TYPE, String strResourceValue, String strContrasena )
        throws java.io.IOException, java.security.KeyStoreException, java.security.NoSuchAlgorithmException,
               java.security.cert.CertificateException, java.lang.Exception
    {
        if( !firmaelectronica.config.Config.SRI_isConfigValido() )
        {
            throw new java.lang.Exception("Parametros SRI incompletos");
        }
        
        switch( AUTH_TYPE )
        {
            case AUTH_CERTIFICADO:
                // strResourceValue -> path file .p12
                firmaelectronica.business.AutenticacionFirma.initCertificado(strResourceValue, strContrasena);
                break;
            case AUTH_TOKEN:
                firmaelectronica.business.AutenticacionFirma.initToken(strContrasena);
                break;
            case AUTH_EPASS:
                // strResourceValue -> slot token
                firmaelectronica.business.AutenticacionFirma.initEPass(strResourceValue, strContrasena);
                break;
        }
        
        firmaelectronica.business.AutenticacionFirma.strContrasena = strContrasena;
        firmaelectronica.business.AutenticacionFirma.AUTH_TYPE = AUTH_TYPE;
    }
    
    public static void initCertificado(String strPathCertificado, String strContrasenia)
        throws java.io.IOException, java.security.KeyStoreException, java.security.NoSuchAlgorithmException, java.security.cert.CertificateException
    {
        System.out.println("Login con CERTIFICADO");
        System.out.println("> path : " + strPathCertificado);
        System.out.println("> contraseña : " + strContrasenia);
        
        firmaelectronica.business.AutenticacionFirma.keyStore = java.security.KeyStore.getInstance("PKCS12");
        firmaelectronica.business.AutenticacionFirma.keyStore.load( new java.io.FileInputStream(strPathCertificado), strContrasenia.toCharArray() );
    }
    
    public static void initToken( String strContrasenia ) throws java.security.KeyStoreException, java.lang.Exception
    {
        System.out.println("Login con TOKEN");
        System.out.println("> path : " + strContrasenia);
        
        char[] pin = strContrasenia.toCharArray();
        
        String configDir="";
        String os = System.getProperty("os.name");

        if( os.contains("Windows") )
        {
            if( os.contains("Windows 9") )
            {
                configDir = System.getenv("WinDir");
            }
            else
            {
                configDir = System.getenv("SystemRoot");
            }
        }

        String content = "name=eToken"+"\n"+"library="+configDir+"\\system32\\eTPKCS11.dll";
        System.out.println("content: "+content);
        sun.security.pkcs11.SunPKCS11  PKCS11Provider = new sun.security.pkcs11.SunPKCS11(new java.io.ByteArrayInputStream(content.getBytes()));

        //String eIDProviderName = PKCS11Provider.getName();
        java.security.Security.addProvider(PKCS11Provider);

        java.security.KeyStore.ProtectionParameter pp = new java.security.KeyStore.PasswordProtection(pin);
        java.security.KeyStore.Builder builder = java.security.KeyStore.Builder.newInstance("PKCS11", PKCS11Provider, pp);
        AutenticacionFirma.keyStore = builder.getKeyStore();        
        AutenticacionFirma.keyStore.load(null, pin);
    }
    
    public static void initEPass(String strTokenSerie, String strContrasenia)
        throws java.security.KeyStoreException, java.io.IOException, sun.security.pkcs11.wrapper.PKCS11Exception, java.lang.Exception
    {
        System.out.println("Login con EPASS");
        System.out.println("> serie : " + strTokenSerie);
        System.out.println("> contraseña : " + strContrasenia);
        
        firmaelectronica.business.ePassToken tk = new firmaelectronica.business.ePassToken();
        java.util.ArrayList<firmaelectronica.clases.eToken> lToken = tk.listTokens();
        
        String strSlot = null;
        if( lToken.size() > 0 )
        {
            for(firmaelectronica.clases.eToken token : lToken )
            {
                if( strTokenSerie.compareTo( token.getSerie().trim() ) == 0 )
                {
                    strSlot = String.valueOf( token.getSlot() );
                    break;
                }
            }
        }
        
        if( strSlot == null )
        {
            throw new Exception( "Token Inválido: " + strTokenSerie );
        }
        
        System.out.println("> slot : " + strSlot);
        
        char[] PIn = strContrasenia.toCharArray();
        
        EPass3003Auto kstpro = new EPass3003Auto();
       AutenticacionFirma.keyStore = kstpro.getKeystore(PIn, strSlot);
    }
}
