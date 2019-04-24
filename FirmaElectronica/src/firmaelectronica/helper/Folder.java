/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.helper;

public class Folder
{
    static public void create( String strPathFolder )
    {
        java.io.File file = new java.io.File( strPathFolder );
        
        if( file.mkdirs() )
        {
            file.setReadable(true);
            file.setWritable(true);
        }
    }
}
