/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.controller;
import firmaelectronica.clases.*;
public class EFirm
{
    // *****************************************************************************
    // PARAMETROS
    // *****************************************************************************
    
    static public String setParametroAmbiente( String strAmbiente )
    {
        firmaelectronica.config.Config.SRI_setAmbiente( strAmbiente );
        
        ResponseWS responseWS = new ResponseWS();
        responseWS.setIsSuccess(true);
        
        return responseWS.getResponse();
    }
    
    static public String setParametroUrlWSRecepcion( String strUrlWs )
    {
        firmaelectronica.config.Config.SRI_setUrlWsdlRecepcion(strUrlWs);
        
        ResponseWS responseWS = new ResponseWS();
        responseWS.setIsSuccess(true);
        return responseWS.getResponse();
    }
    
    static public String setParametroUrlWSAutorizacion( String strUrlWs )
    {
        firmaelectronica.config.Config.SRI_setUrlWsdlAutorizacion(strUrlWs);
        
        ResponseWS responseWS = new ResponseWS();
        responseWS.setIsSuccess(true);
        
        return responseWS.getResponse();
    }
    
    static public String setParametroProxyUrl( String strProxyUrl )
    {
        firmaelectronica.config.Config.PROXY_setUrl(strProxyUrl);
        
        ResponseWS responseWS = new ResponseWS();
        responseWS.setIsSuccess(true);
        
        return responseWS.getResponse();
    }
    
    static public String setParametroProxyPort( String strProxyPort )
    {
        firmaelectronica.config.Config.PROXY_setPort(strProxyPort);
        
        ResponseWS responseWS = new ResponseWS();
        responseWS.setIsSuccess(true);
        
        return responseWS.getResponse();
    }
    
    static public String setParametroProxyUser( String strProxyUser )
    {
        firmaelectronica.config.Config.PROXY_setUser(strProxyUser);
        
        ResponseWS responseWS = new ResponseWS();
        responseWS.setIsSuccess(true);
        
        return responseWS.getResponse();
    }
    
    static public String setParametroProxyPass( String strProxyPass )
    {
        firmaelectronica.config.Config.PROXY_setPass(strProxyPass);
        
        ResponseWS responseWS = new ResponseWS();
        responseWS.setIsSuccess(true);
        
        return responseWS.getResponse();
    }
    
    // *****************************************************************************
    // *****************************************************************************
    
    static public String getTokens()
    {
        ResponseWS responseWS = new ResponseWS();
        
        try
        {
            firmaelectronica.business.ePassToken tk = new firmaelectronica.business.ePassToken();
            java.util.ArrayList<eToken> lToken = tk.listTokens();
            
            if( lToken.size() > 0 )
            {
                for( eToken token : lToken )
                {
                    responseWS.addDataReturn("tokens", "<token>\n<id>"+token.getSlot()+"</id>\n<descripcion>"+token.getAlias().trim()+"</descripcion>\n<serie>"+token.getSerie().trim()+"</serie>\n</token>\n");
                }
            }
            else
            {
                responseWS.addDataReturn("token", "-1,SIN TOKEN");
            }
            
            responseWS.setIsSuccess(true);
        }
        catch( java.io.IOException | sun.security.pkcs11.wrapper.PKCS11Exception e )
        {
            responseWS.setIsSuccess(false);
            responseWS.setMsgError( e.getMessage() );
        }
        
        return responseWS.getResponse();
    }
    
    static public String getTiposAutentificacion()
    {
        ResponseWS responseWS = new ResponseWS();
        
        responseWS.addDataReturn("certificado", String.valueOf(firmaelectronica.business.AutenticacionFirma.AUTH_CERTIFICADO) );
        responseWS.addDataReturn("token",       String.valueOf(firmaelectronica.business.AutenticacionFirma.AUTH_TOKEN) );
        responseWS.addDataReturn("epass",       String.valueOf(firmaelectronica.business.AutenticacionFirma.AUTH_EPASS) );
        
        return responseWS.getResponse();
    }
    
    static public String login(int AUTH_TYPE, String strResourceValue, String strContrasenia)
    {
        System.out.println("LOGIN" );
        System.out.println("> tipo : " + AUTH_TYPE );
        System.out.println("> entrada string : " + strResourceValue );
        System.out.println("> contraseña : " + strContrasenia );
        
        ResponseWS responseWS = new ResponseWS();
        
        try
        {
            firmaelectronica.business.AutenticacionFirma.init(AUTH_TYPE, strResourceValue, strContrasenia);
            
            responseWS.setIsSuccess(true);
        }
        catch( java.io.IOException | java.security.KeyStoreException | java.security.NoSuchAlgorithmException | java.security.cert.CertificateException  ex)
        {
            responseWS.setIsSuccess(false);
            responseWS.setMsgError( ex.getMessage() );
        }
        catch( java.lang.Exception ex )
        {
            responseWS.setIsSuccess(false);
            responseWS.setMsgError( ex.getMessage() );
        }
        
        return responseWS.getResponse();
    }
    
    static public String firmar(String strXmlPathOrContent)
    {
        ResponseWS responseWS = new ResponseWS();
        
        try
        {
            String resSRI = firmaelectronica.business.ServicioFirma.FirmarYEnviar(strXmlPathOrContent);
            
            responseWS.setIsSuccess(true);
            responseWS.addDataReturn("sri", resSRI);
        }
        catch( java.lang.Exception e )
        {
            responseWS.setIsSuccess(false);
            responseWS.setMsgError( e.getLocalizedMessage() );
        }
        
        return responseWS.getResponse();
    }
    
    static public String getAutorizacionWS( String strClaveAcceso )
    {
        System.out.println("AUTORIZACION" );
        System.out.println("> path / content : " + strClaveAcceso );
        
        ResponseWS responseWS = new ResponseWS();
        
        try
        {
            String strAutorizacion = firmaelectronica.business.AutorizacionComprobante.getAutorizacion( strClaveAcceso );
            //firmaelectronica.helper.Log.writeXML(strAutorizacion);
            
            responseWS.setIsSuccess(true);
            responseWS.addDataReturn("autorizacion", strAutorizacion );
        }
        catch( java.lang.Exception ex )
        {
            responseWS.setIsSuccess(false);
            responseWS.setMsgError( ex.getLocalizedMessage());
        }
        
        //firmaelectronica.helper.Log.writeXML( responseWS.getResponse() );
        return responseWS.getResponse();
    }
    
    static public String getDatosUsuario()
    {
        String strRes;
        
        ResponseWS responseWS = new ResponseWS();
        
        try
        {
            strRes = firmaelectronica.business.ServicioFirma.Obtener_Datos();
            
            responseWS.setIsSuccess(true);
            responseWS.addDataReturn("sri", strRes);
        }
        catch( java.io.FileNotFoundException | java.security.KeyStoreException | java.security.NoSuchAlgorithmException | java.security.UnrecoverableKeyException ex )
        {
            responseWS.setIsSuccess(false);
            responseWS.setMsgError( ex.getMessage() );
        }
        
        return responseWS.getResponse();
    }
}
