/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.helper;


import java.io.IOException;

/**
 *
 * @author Jonathan
 */
public class File
{
    static public byte[] toByte( java.io.File file )
        throws java.io.IOException
    {
        byte[] buffer = new byte[(int)file.length()];
        java.io.InputStream ios = new java.io.FileInputStream(file);
        
        ios.read(buffer);
        ios.close();
        
        return buffer;
    }
    
    static public java.io.File createTemp( String strContent )
        throws IOException
    {
        String strRandom = java.util.UUID.randomUUID().toString();
        String strXmlPathTmp = "resources\\tmp\\original_" +( strRandom )+ ".txt";

        java.io.File fileXML = new java.io.File(strXmlPathTmp);
        fileXML.createNewFile();

        //true = append file
        java.io.FileWriter fileWritter = new java.io.FileWriter(fileXML, true);
        java.io.BufferedWriter bufferWritter;
        bufferWritter = new java.io.BufferedWriter(fileWritter);
        bufferWritter.write(strContent);
        bufferWritter.close();
        
        return fileXML;
    }
}
