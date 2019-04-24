/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;


import java.io.ByteArrayInputStream;
import java.io.InputStream;
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
//import org.apache.log4j.Logger;

public class EPass3003Auto
    implements EPass3003AutoImplement
{
    //Logger log = Logger.getLogger(EPass3003Auto.class);
    //private static String libraryName = System.getenv("WINDIR") + "\\SYSTEM32\\SecurityDataCsp11_3003.dll";
    private static String libraryName = firmaelectronica.config.Config.App_getPathEPass3003AutoDLL();
    private static String windowsDir_SD = "name = ePass3003\nlibrary = " + libraryName;
    //private static final String SUN_PKCS11_PROVIDER_CLASS = "sun.security.pkcs11.SunPKCS11";
    private AuthProvider aprov;
    private Map<String, Provider> providers;
  
    public EPass3003Auto()
    {
        this.providers = new HashMap();
    }
  
    @Override
    public KeyStore getKeystore(char[] password, String slot)
        throws KeyStoreException
    {
        //String windowsDir_SD = "name = "+slot+"\nlibrary = " + libraryName;
        String libraryQuery = windowsDir_SD + "\nslot = " + slot;
        //String libraryQuery = windowsDir_SD;
        //System.out.println( libraryQuery );
        //String libraryQuery = windowsDir_SD + "\ntoken = \"" + slot + "\"";
        //this.log.info(libraryQuery);
        byte[] PKCS11_CONFIG_SD = libraryQuery.getBytes();
        Provider sunPKCS11Provider = null;
        boolean remove = false;
        try
        {
            sunPKCS11Provider = (Provider)this.providers.get("slot_SD=" + slot);
            if (sunPKCS11Provider != null)
            {
                //System.out.println("sunPKCS11Provider != null");
                //this.log.info("First Remove Provider: " + sunPKCS11Provider.getName());
                Security.removeProvider(sunPKCS11Provider.getName());
            }
            else
            {
                //System.out.println("sunPKCS11Provider == null");
                
                InputStream configStream = new ByteArrayInputStream(PKCS11_CONFIG_SD);
                sunPKCS11Provider = createSunPKCS11Provider(configStream);
                this.providers.put("slot_SD=" + slot, sunPKCS11Provider);
            }
            
            //System.out.println(sunPKCS11Provider.getName());
            //this.log.info("Add Provider: " + sunPKCS11Provider.getName());
            Security.addProvider(sunPKCS11Provider);
            remove = true;
            KeyStore.Builder ksBuilder = KeyStore.Builder.newInstance("PKCS11", sunPKCS11Provider, 
                new KeyStore.CallbackHandlerProtection(new SimpleCallbackHandler(null, password)));
            KeyStore ks = ksBuilder.getKeyStore();

            this.aprov = ((AuthProvider)Security.getProvider(sunPKCS11Provider.getName()));
            this.aprov.setCallbackHandler(new SimpleCallbackHandler(null, password));
            try
            {
                this.aprov.login(null, null);
            }
            catch (LoginException ex)
            {
                if (remove) {
                    Security.removeProvider(sunPKCS11Provider.getName());
                }
                //this.log.error(ex.getMessage(), ex);
                throw ex;
            }
            return ks;
        }
        catch (LoginException ex)
        {
          //this.log.error("LoginException: " + ex.getMessage(), ex);
        }
        catch (KeyStoreException e)
        {
          //this.log.error("KeyStoreException: " + e.getMessage(), e);
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
            Constructor pkcs11Constr = sunPkcs11Class.getConstructor(new Class[] { InputStream.class });
            return (Provider)pkcs11Constr.newInstance(new Object[] { configStream });
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
  
    @Override
    public String getLibraryName()
    {
        return libraryName;
    }
}

