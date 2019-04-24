/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.WS;


import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;

@WebService
@SOAPBinding(style=SOAPBinding.Style.RPC)
public interface EFirm_Interface
{
    public String SetParametroAmbiente( String strAmbiente );
    public String SetParametroUrlWSRecepcion( String strUrlWs );
    public String SetParametroUrlWSAutorizacion( String strUrlWs );
    
    public String SetParametroProxyUrl( String strProxyUrl );
    public String SetParametroProxyPort( String strProxyPort );
    public String SetParametroProxyUser( String strProxyUser );
    public String SetParametroProxyPass( String strProxyPass );
    
    public String GetTokens();
    public String GetTiposAutentificacion();
    public String Login(int AUTH_TYPE, String strResourceValue, String Contrasenia);
    public String Firmar(String PathArchivo);
    public String GetDatosUsuario();
    public String GetAutorizacionWS(String ClaveAcceso);
}
