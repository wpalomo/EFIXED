/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;
import firmaelectronica.clases.*;
/**
 *
 * @author Web Developer
 */
public class ePassToken
{
    final String pathDLL = System.getenv("WINDIR") + "\\SYSTEM32\\SecurityDataCsp11_3003.dll";
 
    public ePassToken()
    {
        
    }
    
    public java.util.ArrayList<eToken> listTokens()
        throws java.io.IOException, sun.security.pkcs11.wrapper.PKCS11Exception
    {
        java.util.ArrayList<eToken> list = new java.util.ArrayList();
        
        sun.security.pkcs11.wrapper.PKCS11 p11;
        
        p11 = sun.security.pkcs11.wrapper.PKCS11.getInstance( this.pathDLL, "C_GetFunctionList", null, false);

        long[] slots = p11.C_GetSlotList(true);

        for( int i=0; i<slots.length; i++ )
        {
            sun.security.pkcs11.wrapper.CK_TOKEN_INFO info = p11.C_GetTokenInfo( slots[i] );

            //System.out.println( String.valueOf( info.serialNumber ) );
            
            long slot = slots[i];
            String alias = String.copyValueOf( info.label );
            String serie = String.valueOf( info.serialNumber );
            
            eToken token = new eToken( slot, alias, serie );

            list.add( token );
        }
        
        return list;
    }
}
