/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.test;

public class Test
{
    static public void execute()
    {
        // PARAMETROS
        firmaelectronica.controller.EFirm.setParametroAmbiente("1");
        firmaelectronica.controller.EFirm.setParametroUrlWSRecepcion("https://celcer.sri.gob.ec/comprobantes-electronicos-ws/RecepcionComprobantes?wsdl");
        firmaelectronica.controller.EFirm.setParametroUrlWSAutorizacion("https://celcer.sri.gob.ec/comprobantes-electronicos-ws/AutorizacionComprobantes?wsdl");
        
        //test01();
        //text02();
        test03();
    }
    
    static private void test01()
    {
        String strXML;
                
        //strXML = firmaelectronica.controller.EFirm.getTokens();
        //System.out.println( strXML );

        // LOGIN
        
        strXML = firmaelectronica.controller.EFirm.login(
            firmaelectronica.business.AutenticacionFirma.AUTH_CERTIFICADO,
            "E:\\Netbeans8\\firma_electronica\\_files\\clientes\\basquiat\\roberto_constantino_ramos_villacis.p12",
            "T0mm1h3c14"
        );
        System.out.println( strXML );
        
        
        // FIRMA Y ENVIO
        
        //String strXmlPath = "E:\\Netbeans8\\firma_electronica\\_files\\clientes\\basquiat\\BAS-FAC-002-002-000086187.xml";
        String strXmlStr = ""+
            "<?xml version = \"1.0\" encoding = \"UTF-8\"?>\n" +
            "<factura id=\"comprobante\" version=\"1.0.0\">\n" +
            "	<infoTributaria>\n" +
            "		<ambiente>1</ambiente>\n" +
            "		<tipoEmision>1</tipoEmision>\n" +
            "		<razonSocial>BASQUIAT S.A.</razonSocial>\n" +
            "		<nombreComercial>BASQUIAT S.A.</nombreComercial>\n" +
            "		<ruc>0992627557001</ruc>\n" +
            "		<claveAcceso>2911201401099262755700110020020000861871234567810</claveAcceso>\n" +
            "		<codDoc>01</codDoc>\n" +
            "		<estab>002</estab>\n" +
            "		<ptoEmi>002</ptoEmi>\n" +
            "		<secuencial>000086187</secuencial>\n" +
            "		<dirMatriz>EDIFICIO WORLD TRADE PISO 12 OF. 1204</dirMatriz>\n" +
            "	</infoTributaria>\n" +
            "	<infoFactura>\n" +
            "		<fechaEmision>29/11/2014</fechaEmision>\n" +
            "		<dirEstablecimiento>AV. NACIONES UNIDAS INTERSECCION: CALLE 6 DE DICIEMBRE JUNTO AL LOCAL BURBUJAS CENTRO COMERCIAL QUICENTRO SHOPPING OFICINA: P1-81-83</dirEstablecimiento>\n" +
            "		<contribuyenteEspecial>616</contribuyenteEspecial>\n" +
            "		<obligadoContabilidad>SI</obligadoContabilidad>\n" +
            "		<tipoIdentificacionComprador>05</tipoIdentificacionComprador>\n" +
            "		<razonSocialComprador>CATELLANOS MARTINEZ RAUL</razonSocialComprador>\n" +
            "		<identificacionComprador>1750861716</identificacionComprador>\n" +
            "		<totalSinImpuestos>129.00</totalSinImpuestos>\n" +
            "		<totalDescuento>86.00</totalDescuento>\n" +
            "		<totalConImpuestos>\n" +
            "			<totalImpuesto>\n" +
            "				<codigo>2</codigo>\n" +
            "				<codigoPorcentaje>2</codigoPorcentaje>\n" +
            "				<baseImponible>129.00</baseImponible>\n" +
            "				<valor>15.48</valor>\n" +
            "			</totalImpuesto>\n" +
            "		</totalConImpuestos>\n" +
            "		<propina>0.00</propina>\n" +
            "		<importeTotal>144.48</importeTotal>\n" +
            "		<moneda>DOLAR</moneda>\n" +
            "	</infoFactura>\n" +
            "	<detalles>\n" +
            "		<detalle>\n" +
            "			<codigoPrincipal>95784695786WMED</codigoPrincipal>\n" +
            "			<codigoAuxiliar>95784695786WMED</codigoAuxiliar>\n" +
            "			<descripcion>957846957_MHD_CAMISAS M/L_FASHION_ORANGE OCH_MEDIUM</descripcion>\n" +
            "			<cantidad>1.00</cantidad>\n" +
            "			<precioUnitario>92.00</precioUnitario>\n" +
            "			<descuento>36.80</descuento>\n" +
            "			<precioTotalSinImpuesto>55.20</precioTotalSinImpuesto>\n" +
            "			<impuestos>\n" +
            "				<impuesto>\n" +
            "					<codigo>2</codigo>\n" +
            "					<codigoPorcentaje>2</codigoPorcentaje>\n" +
            "					<tarifa>12</tarifa>\n" +
            "					<baseImponible>55.20</baseImponible>\n" +
            "					<valor>6.62</valor>\n" +
            "				</impuesto>\n" +
            "			</impuestos>\n" +
            "		</detalle>\n" +
            "		<detalle>\n" +
            "			<codigoPrincipal>887849451MA4MED</codigoPrincipal>\n" +
            "			<codigoAuxiliar>887849451MA4MED</codigoAuxiliar>\n" +
            "			<descripcion>887849451_MES_CAMISAS M/L_FASHION_MALIBU BLU_MEDIUM</descripcion>\n" +
            "			<cantidad>1.00</cantidad>\n" +
            "			<precioUnitario>123.00</precioUnitario>\n" +
            "			<descuento>49.20</descuento>\n" +
            "			<precioTotalSinImpuesto>73.80</precioTotalSinImpuesto>\n" +
            "			<impuestos>\n" +
            "				<impuesto>\n" +
            "					<codigo>2</codigo>\n" +
            "					<codigoPorcentaje>2</codigoPorcentaje>\n" +
            "					<tarifa>12</tarifa>\n" +
            "					<baseImponible>73.80</baseImponible>\n" +
            "					<valor>8.86</valor>\n" +
            "				</impuesto>\n" +
            "			</impuestos>\n" +
            "		</detalle>\n" +
            "	</detalles>\n" +
            "	<infoAdicional>\n" +
            "		<campoAdicional nombre=\"Direccion Cliente\">EL BATAN</campoAdicional>\n" +
            "		<campoAdicional nombre=\"Telefono Cliente\">0997458771</campoAdicional>\n" +
            "		<campoAdicional nombre=\"Vendedor\">ZUÑIGA ROMERO VICTOR MAURICIO</campoAdicional>\n" +
            "		<campoAdicional nombre=\"Caja\">QC - CAJA 2</campoAdicional>\n" +
            "		<campoAdicional nombre=\"Cajero\">BVILLACIS</campoAdicional>\n" +
            "		<campoAdicional nombre=\"No. Interno\">020459</campoAdicional>\n" +
            "		<campoAdicional nombre=\"Forma de Pago\">EXPERTA-PICHINCHA 144.48|</campoAdicional>\n" +
            "	</infoAdicional>\n" +
            "</factura>";
        
        //strXML = firmaelectronica.controller.EFirm.firmar(strXmlPath);
        strXML = firmaelectronica.controller.EFirm.firmar(strXmlStr);
        System.out.println( strXML );

        /*
        strXML = firmaelectronica.controller.EFirm.getAutorizacionWS("2911201401099262755700110020020000861871234567810");
        System.out.println( strXML );
        */

        //firmaelectronica.helper.Log.write(strXMLResponse1 + "\n\n" + strXMLResponse2);

        //java.util.UUID idOne = java.util.UUID.randomUUID();
        //java.util.UUID idTwo = java.util.UUID.randomUUID();

        //System.out.println( idOne.toString() );
        //System.out.println( idTwo );

        /*strXML = firmaelectronica.controller.EFirm.GetAutorizacionWS("2111201401099027171200110010020000039431234567811");
        System.out.println( strXML );*/

        /*strXML = firmaelectronica.controller.EFirm.Login(
            firmaelectronica.business.efirm.AutenticacionFirma.AUTH_CERTIFICADO,
            "E:\\Netbeans8\\firma_electronica\\_files\\Certificados\\marlon_ruperto_jines_lucin.p12",
            "Itcorp2014"
        );*/
        //strXML = firmaelectronica.controller.EFirm.GetTokens();
        /*strXML = firmaelectronica.controller.EFirm.Login(
            firmaelectronica.business.efirm.AutenticacionFirma.AUTH_EPASS,
            "1",
            "Ncn2014"
        );*/
        /*strXML = firmaelectronica.controller.EFirm.Login(
            firmaelectronica.business.efirm.AutenticacionFirma.AUTH_EPASS,
            "2",
            "Ncn2014"
        );*/


        /*
        String strXML = firmaelectronica.controller.EFirm.GetTokens();
        System.out.println( strXML );
        */

        /*
        String strPathCert = "D:\\Projects\\Netbeans-8.0.1\\firma_electronica\\_files\\Certificados\\melky_antonio_pena_ramos_Mapr2001DACAR.p12";
        String strContrasena = "Mapr2001";
        strXML = firmaelectronica.controller.EFirm.login(
            firmaelectronica.business.efirm.AutenticacionFirma.AUTH_CERTIFICADO, strPathCert, strContrasena
        );
        System.out.println( strXML );
        */

        /*
        String strPathArchivo = "D:\\Projects\\Netbeans-8.0.1\\firma_electronica\\_files\\test\\comprobantes\\FA2014112117450-5206.xml";
        String strFilePath = "D:\\Projects\\Netbeans-8.0.1\\firma_electronica\\_files\\test\\firmados\\firmado001.xml";
        String strTipoDocumento = "01";

        String strXML2 = firmaelectronica.controller.EFirm.firmar(strPathArchivo);

        System.out.println( strXML2 );
        */

        /*
        firmaelectronica.business.efirm.ePassToken tk = new firmaelectronica.business.efirm.ePassToken();
        java.util.ArrayList<firmaelectronica.classes.eToken> lToken = tk.listTokens();

        for( firmaelectronica.classes.eToken token : lToken ) {
            System.out.println( token.getSlot() + " , " + token.getAlias() );
        }
        */
    }
    
    static public void test02()
    {
        String proxy_address = "192.168.1.248";
        int proxy_port = 3128;
        
        java.net.Socket socket = new java.net.Socket();
        java.net.SocketAddress sockaddr = new java.net.InetSocketAddress(proxy_address, proxy_port);

        try
        {
            socket.connect(sockaddr);
            System.out.println("Conectado");
        }
        catch( java.net.SocketTimeoutException e )
        {
            System.out.println( e.getMessage() );
            System.exit(0);
        }
        catch( java.io.IOException e )
        {
            System.out.println( e.getMessage() );
            System.exit(0);
        }
        
        java.net.Proxy proxy = new java.net.Proxy(
            java.net.Proxy.Type.HTTP,
            new java.net.InetSocketAddress( socket.getInetAddress(), proxy_port) );
        
        java.net.URL url;
        try
        {
            System.out.println( firmaelectronica.config.Config.SRI_getUrlWsdlAutorizacion() );
            url = new java.net.URL( firmaelectronica.config.Config.SRI_getUrlWsdlAutorizacion() );
            java.net.HttpURLConnection uc = (java.net.HttpURLConnection) url.openConnection(proxy);
            
            System.out.println("Content: " + uc.getContentType());
            uc.connect();
            
            socket.close();
        }
        catch(  java.net.MalformedURLException ex )
        {
            //Logger.getLogger(Test.class.getName()).log(Level.SEVERE, null, ex);
            System.out.println( ex.getMessage() );
        }
        catch( java.io.IOException ex )
        {
            //Logger.getLogger(Test.class.getName()).log(Level.SEVERE, null, ex);
            System.out.println( ex.getMessage() );
        }
        
        
        /*try
        {
            if( socket.getInetAddress().isReachable(10000) )
            {
                java.net.URL url = new java.net.URL( firmaelectronica.config.Config.SRI_getUrlWsdlAutorizacion() );
                java.net.HttpURLConnection uc = (java.net.HttpURLConnection) url.openConnection(proxy);
                uc.connect();
                
                System.out.println("connected");
            }
            else
            {
                System.out.println("no isReachable");
            }
        }
        catch( java.io.IOException e )
        {
            System.out.println( e.getMessage() );
            System.exit(0);
        }*/
    }
    
    static public void test03()
    {
        //firmaelectronica.controller.EFirm.setParametroProxyUrl("192.168.1.248");
        //firmaelectronica.controller.EFirm.setParametroProxyPort("3128");
        //firmaelectronica.controller.EFirm.setParametroProxyUser("");
        //firmaelectronica.controller.EFirm.setParametroProxyPass("");
        
        String strXML = firmaelectronica.controller.EFirm.getAutorizacionWS("3001201504099260424700110010010000033811234567817");
        System.out.println("========");
        System.out.println( strXML );
        //firmaelectronica.helper.Log.writeTXT(strXML);
    }
}
