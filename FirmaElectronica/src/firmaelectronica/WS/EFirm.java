/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.WS;


import javax.jws.WebService;

@WebService(endpointInterface="firmaelectronica.WS.EFirm")
public class EFirm implements EFirm_Interface
{
    // *****************************************************************************
    // PARAMETROS
    // *****************************************************************************
    
    @Override
    public String SetParametroAmbiente( String strAmbiente )
    {
        return firmaelectronica.controller.EFirm.setParametroAmbiente(strAmbiente);
    }
    
    @Override
    public String SetParametroUrlWSRecepcion( String strUrlWs )
    {
        String s=firmaelectronica.controller.EFirm.setParametroUrlWSRecepcion(strUrlWs);
        return firmaelectronica.controller.EFirm.setParametroUrlWSRecepcion(strUrlWs);
    }
    
    @Override
    public String SetParametroUrlWSAutorizacion( String strUrlWs )
    {
        return firmaelectronica.controller.EFirm.setParametroUrlWSAutorizacion(strUrlWs);
    }
    
    @Override
    public String SetParametroProxyUrl( String strProxyUrl )
    {
        return firmaelectronica.controller.EFirm.setParametroProxyUrl(strProxyUrl);
    }
    
    @Override
    public String SetParametroProxyPort( String strProxyPort )
    {
        return firmaelectronica.controller.EFirm.setParametroProxyPort(strProxyPort);
    }
    
    @Override
    public String SetParametroProxyUser( String strProxyUser )
    {
        return firmaelectronica.controller.EFirm.setParametroProxyUser(strProxyUser);
    }
    
    @Override
    public String SetParametroProxyPass( String strProxyPass )
    {
        return firmaelectronica.controller.EFirm.setParametroProxyPass(strProxyPass);
    }
    
    // *****************************************************************************
    // *****************************************************************************
    
    @Override
    public String GetTokens()
    {
        return firmaelectronica.controller.EFirm.getTokens();
    }
    
    @Override
    public String GetTiposAutentificacion()
    {
        return firmaelectronica.controller.EFirm.getTiposAutentificacion();
    }
    
    @Override
    public String Login(int AUTH_TYPE, String strResourceValue, String strContrasenia)
    {
        return firmaelectronica.controller.EFirm.login(AUTH_TYPE, strResourceValue, strContrasenia);
    }

    @Override
    public String Firmar(String strPathArchivo)
    {
        return firmaelectronica.controller.EFirm.firmar(strPathArchivo);
    }

    @Override
    public String GetDatosUsuario()
    {
        return firmaelectronica.controller.EFirm.getDatosUsuario();
    }

    @Override
    public String GetAutorizacionWS( String strClaveAcceso )
    {
        return firmaelectronica.controller.EFirm.getAutorizacionWS(strClaveAcceso);
    }
}
