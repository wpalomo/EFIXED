/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;

import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.io.PrintStream;
import java.lang.reflect.Constructor;
import java.lang.reflect.InvocationTargetException;
import java.security.AuthProvider;
import java.security.KeyStore;
import java.security.KeyStore.Builder;
import java.security.KeyStore.CallbackHandlerProtection;
import java.security.KeyStoreException;
import java.security.Provider;
import java.security.Security;
import java.util.HashMap;
import java.util.Map;
import javax.security.auth.login.LoginException;
import org.apache.log4j.Logger;

public class WindowsJDK5KeyStoreProvider_iKey
  //implements KeyStoreProvider
{
  private Logger log = Logger.getLogger(WindowsJDK5KeyStoreProvider_iKey.class);
  private static String libraryName = System.getenv("WINDIR") + 
    "\\SYSTEM32\\DKCK201.DLL";
  private static String windowsDir_iKey = "name = SmartCard\nlibrary = " + 
    System.getenv("WINDIR") + 
    "\\SYSTEM32\\DKCK201.DLL \ndisabledMechanisms = { CKM_SHA1_RSA_PKCS  } \n showInfo = true";
  private static final byte[] PKCS11_CONFIG_IKEY = windowsDir_iKey.getBytes();
  private static final String SUN_PKCS11_PROVIDER_CLASS = "sun.security.pkcs11.SunPKCS11";
  private AuthProvider aprov;
  private Map<String, Provider> providers;
  
  public WindowsJDK5KeyStoreProvider_iKey()
  {
    this.providers = new HashMap();
  }
  
  public KeyStore getKeystore(char[] password, String slot)
    throws KeyStoreException
  {
    try
    {
      InputStream configStream = new ByteArrayInputStream(
        PKCS11_CONFIG_IKEY);
      
      Provider sunPKCS11Provider = null;
      
      sunPKCS11Provider = (Provider)this.providers.get("slotIKEY=" + slot);
      if (sunPKCS11Provider != null)
      {
        this.log.info("First Remove Provider: " + 
          sunPKCS11Provider.getName());
        Security.removeProvider(sunPKCS11Provider.getName());
      }
      else
      {
        sunPKCS11Provider = createSunPKCS11Provider(configStream);
        this.providers.put("slotIKEY=" + slot, sunPKCS11Provider);
      }
      Security.addProvider(sunPKCS11Provider);
      
      KeyStore.Builder ksBuilder = KeyStore.Builder.newInstance("PKCS11", 
        null, new KeyStore.CallbackHandlerProtection(
        new SimpleCallbackHandler(null, password)));
      
      KeyStore ks = ksBuilder.getKeyStore();
      


      this.aprov = ((AuthProvider)Security.getProvider(sunPKCS11Provider
        .getName()));
      this.aprov.setCallbackHandler(new SimpleCallbackHandler(null, password));
      try
      {
        this.aprov.login(null, null);
      }
      catch (LoginException ex)
      {
        throw new LoginException();
      }
      return ks;
    }
    catch (LoginException ex)
    {
      System.out.println("error en el loginExcep" + ex);
    }
    catch (KeyStoreException e)
    {
      System.out.println("e:" + e.getCause().toString().length());
      throw new KeyStoreException(e);
    }
    return null;
  }
  
  public void logout()
    throws LoginException
  {
    this.aprov.logout();
  }
  
  private Provider createSunPKCS11Provider(InputStream configStream)
    throws KeyStoreException
  {
    try
    {
      Class sunPkcs11Class = Class.forName("sun.security.pkcs11.SunPKCS11");
      Constructor pkcs11Constr = sunPkcs11Class
        .getConstructor(new Class[] {InputStream.class });
      return 
        (Provider)pkcs11Constr.newInstance(new Object[] {configStream });
    }
    catch (ClassNotFoundException e)
    {
      throw new KeyStoreException(e);
    }
    catch (NoSuchMethodException e)
    {
      throw new KeyStoreException(e);
    }
    catch (InvocationTargetException e)
    {
      throw new KeyStoreException(e);
    }
    catch (IllegalAccessException e)
    {
      throw new KeyStoreException(e);
    }
    catch (InstantiationException e)
    {
      throw new KeyStoreException(e);
    }
  }
  
  public String getLibraryName()
  {
    return libraryName;
  }
}
