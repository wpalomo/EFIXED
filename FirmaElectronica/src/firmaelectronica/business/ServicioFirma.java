/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;
public class ServicioFirma
{
    private static java.security.cert.X509Certificate x509Cert;
    private static java.security.PrivateKey privateKey ;
    
    /*public static String TipoDocument(String tipoDocumen)
    {
        try {
            
            if(tipoDocumen == "01")
                return "factura";
            if(tipoDocumen=="04")
                return "notaCredito";
            if(tipoDocumen=="05")
                return "notaDebito";
            if(tipoDocumen=="06")
                return "guiaRemision";
            if(tipoDocumen=="07")
                return "comprobanteRetencion"; 
            else
                return "";
            
        } catch (Exception e) {
            return "";
        }
    }*/
    
    public static String FirmarYEnviar( String strXmlPathOrContent )
        throws java.lang.Exception
    {
        String strRandom = java.util.UUID.randomUUID().toString();
        
        java.io.File fileXML       = new java.io.File(strXmlPathOrContent);
        java.io.File fileXMLSigned = new java.io.File("resources\\tmp\\signed_" +( strRandom )+ ".xml");
        fileXMLSigned.setReadable(true);
        fileXMLSigned.setWritable(true);
        fileXMLSigned.createNewFile();

        boolean isXmlPath = fileXML.isFile();
        boolean isXmlStr  = strXmlPathOrContent.substring(0,5).compareTo("<?xml") == 0;
        
        boolean isXmlContent = !fileXML.isFile();
        
        if( isXmlStr )
        {
            String strXmlPathTmp = "resources\\tmp\\original_" +( strRandom )+ ".xml";
            String strXmlContent = strXmlPathOrContent;
            
            fileXML = new java.io.File(strXmlPathTmp);
            fileXML.setReadable(true);
            fileXML.setWritable(true);
            fileXML.createNewFile();
            
            java.io.PrintWriter writer;
            writer = new java.io.PrintWriter( fileXML.getPath(), "UTF-8");
            writer.println(strXmlContent);
            writer.close();
        }
        else if( isXmlPath )
        {
            // none
        }
        else
        {
            throw new Exception("Cadena XML o Ruta Inválidos");
        }
        
        java.security.KeyStore keyStore = firmaelectronica.business.AutenticacionFirma.getKeyStore();
        String contrasena = firmaelectronica.business.AutenticacionFirma.getContrasena();
        
        java.util.Enumeration<String> enumeration = keyStore.aliases();
        String alias = (String)enumeration.nextElement();

        privateKey = (java.security.PrivateKey)keyStore.getKey(alias, contrasena.toCharArray());
        java.security.cert.Certificate[] certs = keyStore.getCertificateChain(alias);
        x509Cert = (java.security.cert.X509Certificate)certs[0];

        //Document documentoFirmado = null;
        es.mityc.firmaJava.libreria.xades.FirmaXML firma = new es.mityc.firmaJava.libreria.xades.FirmaXML();

        java.security.Provider PKCS11Provider = keyStore.getProvider();
        es.mityc.firmaJava.libreria.xades.DataToSign datosAFirmar = GetDatosFirma();
        datosAFirmar.setDocument( firmaelectronica.business.ServicioFirma.GetDocument( fileXML ) );
        System.out.println("PATH archivo : " + fileXML.getAbsolutePath() );
        System.out.println("PATH existe : " + ( fileXML.exists() ? "SI" : "NO" ) );
        
        java.lang.Object[] res;
        
        long time_start, time_end;
        time_start = System.currentTimeMillis();
        System.out.println("FIRMA : iniciada, "+( isXmlStr ? "contenido" : "ruta" )+" xml" );
        res = firma.signFile(x509Cert, datosAFirmar, privateKey, PKCS11Provider);
        time_end = System.currentTimeMillis();
        System.out.println("FIRMA : finalizado, "+ ( time_end - time_start ) +" milliseconds.");
        
        System.out.println("DOCUMENTO FIRMADO");
        //System.out.println( java.util.Arrays.toString(res) );
        //System.out.println( res[0] );

        org.w3c.dom.Document documentoFirmado = (org.w3c.dom.Document)res[0];
        //System.out.println( documentoFirmado );
        //org.w3c.dom.Document xmlDocument = javax.xml.parsers.DocumentBuilderFactory.newInstance().newDocumentBuilder().parse( fileXML );
        //javax.xml.xpath.XPath xPath = javax.xml.xpath.XPathFactory.newInstance().newXPath();

        //String TipoDocumento = "01";
        
        //javax.xml.xpath.XPathExpression xPathExpression = xPath.compile("/"+TipoDocument(TipoDocumento)+"/infoTributaria/claveAcceso");
        //String CLAVEACCESO = (String)xPathExpression.evaluate( xmlDocument,  javax.xml.xpath.XPathConstants.STRING);
        
        //xPathExpression =  xPath.compile("/"+TipoDocument(TipoDocumento)+"/infoTributaria/estab");
        //String PuntoEmision=(String)xPathExpression.evaluate( xmlDocument,  javax.xml.xpath.XPathConstants.STRING);
        
        //xPathExpression =  xPath.compile("/"+TipoDocument(TipoDocumento)+"/infoTributaria/ptoEmi");
        //String Establecimiento =(String)xPathExpression.evaluate( xmlDocument,  javax.xml.xpath.XPathConstants.STRING);
        
        //xPathExpression =  xPath.compile("/"+TipoDocument(TipoDocumento)+"/infoTributaria/secuencial");
        //String Secuencial =(String)xPathExpression.evaluate( xmlDocument,  javax.xml.xpath.XPathConstants.STRING);
        
        //System.out.println("Firmado Con exito el comprobante \""+TipoDocument(TipoDocumento)+"\", "+ Establecimiento+"-"+PuntoEmision+"-"+Secuencial);
        //System.out.println("Con Clave de acceso: "+ CLAVEACCESO);
        
        java.io.FileOutputStream fos;
        System.out.println("GUARDANDO " + fileXMLSigned.getAbsolutePath());
        fos = new java.io.FileOutputStream( fileXMLSigned );
        es.mityc.firmaJava.libreria.utilidades.UtilidadTratarNodo.saveDocumentToOutputStream(documentoFirmado, fos, true);
        fos.close();
        System.out.println("GUARDADO");
        
        //System.out.println(fileXMLSigned.getPath());
        
        firmaelectronica.business.RecepcionComprobante rComp = new firmaelectronica.business.RecepcionComprobante();
        
        String response = "";
        
        time_start = System.currentTimeMillis();
        System.out.println("ENVIO : iniciado" );
        System.out.println("ENVIO : ruta " + fileXMLSigned.getPath() );
        response = rComp.RecepcionAutorizacion( fileXMLSigned.getPath() );
        time_end = System.currentTimeMillis();
        System.out.println("ENVIO : finalizado, "+ ( time_end - time_start ) +" milliseconds.");
        
        if( isXmlContent )
        {
            if( !firmaelectronica.config.Config.App_isDebug() )
            {
                fileXML.delete();
            }
        }

        if( !firmaelectronica.config.Config.App_isDebug() )
        {
            fileXMLSigned.delete();
        }
        
        return response;
    }
    
    /*public static DataToSign createDataToSign() 
    {
        DataToSign datosAFirmar = new DataToSign();
        datosAFirmar.setXadesFormat(EnumFormatoFirma.XAdES_BES);
        datosAFirmar.setEsquema(XAdESSchemas.XAdES_132);
        datosAFirmar.setXMLEncoding("UTF-8");
        datosAFirmar.setEnveloped(true);
        datosAFirmar.addObject(new ObjectToSign(new InternObjectToSign("comprobante"), "contenido comprobante", null, "text/xml", null));
        datosAFirmar.setParentSignNode("comprobante");

        Document docToSign = GetDocument(new File("C:\\Users\\roberto\\Music\\No Firmados\\0805201401099260424700110010010000000011234567812.xml"));
        datosAFirmar.setDocument(docToSign);
        return datosAFirmar;
    }*/
    
    /*private static void saveDocumentToFile(Document document, String pathfile) throws FileNotFoundException
    {
        FileOutputStream fos = new FileOutputStream(pathfile);
        UtilidadTratarNodo.saveDocumentToOutputStream(document, fos, true);
    }*/
    
    public static es.mityc.firmaJava.libreria.xades.DataToSign GetDatosFirma()
        throws java.lang.Exception
    {
        es.mityc.firmaJava.libreria.xades.DataToSign datosAFirmar = new es.mityc.firmaJava.libreria.xades.DataToSign();

        datosAFirmar.setXadesFormat( es.mityc.firmaJava.libreria.xades.EnumFormatoFirma.XAdES_BES );
        datosAFirmar.setEsquema( es.mityc.firmaJava.libreria.xades.XAdESSchemas.XAdES_132 );
        datosAFirmar.setXMLEncoding("UTF-8");
        datosAFirmar.setEnveloped(true);
        datosAFirmar.addObject(
            new es.mityc.javasign.xml.refs.ObjectToSign(
                new es.mityc.javasign.xml.refs.InternObjectToSign("comprobante"), "contenido comprobante", null, "text/xml", null));

        datosAFirmar.setParentSignNode("comprobante");
        datosAFirmar.setAlgDigestXmlDSig("http://www.w3.org/2001/04/xmlenc#sha256");
        datosAFirmar.setAlgDigestTSA("http://www.w3.org/2001/04/xmlenc#sha256");

        System.out.println("GetDatosFirma");
        System.out.println( datosAFirmar.getSigningCert() );

        return datosAFirmar;
    }
    
    public static org.w3c.dom.Document GetDocument( java.io.File file )
        throws javax.xml.parsers.ParserConfigurationException, org.xml.sax.SAXException, java.io.IOException
    {
        javax.xml.parsers.DocumentBuilderFactory dbf = javax.xml.parsers.DocumentBuilderFactory.newInstance();
        dbf.setNamespaceAware(true);

        javax.xml.parsers.DocumentBuilder db = dbf.newDocumentBuilder();

        return db.parse( file );
    }
    /*
    public static org.w3c.dom.Document GetDocument( String strContentXML )
    {
        try
        {
            
            
            DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
            dbf.setNamespaceAware(true);

            DocumentBuilder db = dbf.newDocumentBuilder();
            
            return db.parse( file );
        }
        catch (ParserConfigurationException | SAXException | IOException e)
        {
            return null;
        }
    }
    */
    
    public static String Obtener_Datos()
        throws java.io.FileNotFoundException, java.security.KeyStoreException, java.security.NoSuchAlgorithmException, java.security.UnrecoverableKeyException
    {
        java.util.Enumeration<String> enumeration = firmaelectronica.business.AutenticacionFirma.getKeyStore().aliases();
        String alias;// = (String)enumeration.nextElement();
        alias = (String)enumeration.nextElement();
        privateKey = (java.security.PrivateKey)firmaelectronica.business.AutenticacionFirma.getKeyStore().getKey(alias, firmaelectronica.business.AutenticacionFirma.getContrasena().toCharArray());
        java.security.cert.Certificate[] certs = firmaelectronica.business.AutenticacionFirma.getKeyStore().getCertificateChain(alias);
        x509Cert = (java.security.cert.X509Certificate)certs[0];

        com.thoughtworks.xstream.XStream x = new com.thoughtworks.xstream.XStream();
        DatosUsuario O;
        //O = new firmaelectronica.business.sri.DatosUsuario();
        O = DatosBus.GetDatos(x509Cert);
        String DATOS = x.toXML(O);
        DATOS = DATOS.replaceAll("firmasri.", "");
        
        return DATOS;
    }
}
