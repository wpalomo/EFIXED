/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.helper;

public class ProxyConfig
{
    private static String host;
    private static int port;
    private static java.net.Proxy proxy;

    public static void init(String uri)
    {
        System.setProperty("java.net.useSystemProxies", "true");
        System.setProperty("javax.net.ssl.trustStore", "resources/jssecacerts");
        System.setProperty("javax.net.ssl.trustStorePassword", "changeit");

        proxy = getProxy(uri);
        if( (proxy != null) && (!proxy.type().toString().equals("DIRECT")) )
        {
            java.net.InetSocketAddress addr = (java.net.InetSocketAddress) proxy.address();
            host = addr.getHostName();
            port = addr.getPort();
        }
        else
        {
            System.setProperty("java.net.useSystemProxies", "true");
        }
    }

    private static java.net.Proxy getProxy(String uri)
    {
        java.util.List<java.net.Proxy> l = null;
        try
        {
            java.net.ProxySelector def = java.net.ProxySelector.getDefault();

            //l = def.select( new java.net.URI("http://proxy/test") );
            l = def.select( new java.net.URI(uri) );
            java.net.ProxySelector.setDefault( java.net.ProxySelector.getDefault() );
        }
        catch( java.lang.Exception e )
        {
            System.out.println( e.getMessage() );
        }

        if( l != null )
        {
            
            java.util.Iterator<java.net.Proxy> iter = l.iterator();
            if( iter.hasNext() )
            {
                java.net.Proxy proxy = (java.net.Proxy)iter.next();
                return proxy;
            }
        }

        return null;
    }

    public static class ProxyAuthenticator extends java.net.Authenticator
    {
        private String userName;
        private String password;

        @Override
        protected java.net.PasswordAuthentication getPasswordAuthentication()
        {
            return new java.net.PasswordAuthentication(this.userName, this.password.toCharArray());
        }

        public ProxyAuthenticator(String userName, String password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}