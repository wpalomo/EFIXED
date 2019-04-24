/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;


public class SimpleCallbackHandler implements javax.security.auth.callback.CallbackHandler
{
    private String username;
    private char[] password;
  
    public SimpleCallbackHandler(String username, char[] password)
    {
        this.username = username;
        this.password = password;
    }
    
    public SimpleCallbackHandler(String username, String password)
    {
        this.username = username;
        this.password = password.toCharArray();
    }
    
    @Override
    public void handle( javax.security.auth.callback.Callback[] callbacks )
    {
        for( javax.security.auth.callback.Callback callback : callbacks )
        {
            if( callback instanceof javax.security.auth.callback.NameCallback )
            {
                ( (javax.security.auth.callback.NameCallback)callback ).setName(this.username);
            }
            else if( callback instanceof javax.security.auth.callback.PasswordCallback )
            {
                ( (javax.security.auth.callback.PasswordCallback)callback ).setPassword(this.password);
            }
        }
    }
}
