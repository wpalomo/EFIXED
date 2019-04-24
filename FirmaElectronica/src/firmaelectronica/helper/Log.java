/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.helper;

public class Log
{
    static public void writeTXT( String strContent )
    {
        write(strContent, "txt");
    }
    
    static public void writeXML( String strContent )
    {
        write(strContent, "xml");
    }
    
    static public void write( String strContent, String strExtension )
    {
        java.text.DateFormat dateFormat = new java.text.SimpleDateFormat("yyyy.MM.dd_HH.mm.ss");
        java.util.Date date = new java.util.Date();
       
        String log_name = ( dateFormat.format(date) ) + "." + strExtension;
        
        java.io.Writer writer = null;
        try
        {
            writer = new java.io.BufferedWriter(new java.io.OutputStreamWriter(
                  new java.io.FileOutputStream( "resources/log/" + log_name ), "utf-8"));
            
            writer.write( strContent );
        }
        catch( java.io.IOException ex )
        {
            //System.out.println( ex.getMessage() );
        }
        finally
        {
           try
           {
               writer.close();
           }
           catch( java.lang.Exception ex )
           {
               //System.out.println( ex.getMessage() );
           }
        }
    }
}
