/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;


import java.security.KeyStore;
import java.security.KeyStoreException;
import javax.security.auth.login.LoginException;

public abstract interface EPass3003AutoImplement
{
  public abstract KeyStore getKeystore(char[] paramArrayOfChar, String paramString)
    throws KeyStoreException;
  
  public abstract String getLibraryName();
  
  public abstract void logout()
    throws LoginException;
}
