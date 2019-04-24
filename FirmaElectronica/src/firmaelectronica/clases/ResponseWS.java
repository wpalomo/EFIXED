/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.clases;

/**
 *
 * @author Jerry
 */
public class ResponseWS
{
    protected boolean isSuccess;
    protected String msgError;
    protected java.util.ArrayList<String> dataName;
    protected java.util.ArrayList<String> dataValue;
    
    public ResponseWS()
    {
        this.isSuccess = false;
        this.msgError = "";
        this.dataName  = new java.util.ArrayList<>();
        this.dataValue = new java.util.ArrayList<>();
    }
    
    public void setIsSuccess( boolean isSuccess )
    {
        this.isSuccess = isSuccess;
    }
    
    public void setMsgError( String msgError )
    {
        this.msgError = msgError;
    }
    
    public void addDataReturn( String strDataName, String strDataValue )
    {
        this.dataName.add(strDataName);
        this.dataValue.add(strDataValue);
    }
    
    /*
    <?xml version="1.0" encoding="UTF-8"?>
    <response>
        <isSuccess>yong</isSuccess>
        <msgError>mook kim</msgError>
        <dataReturn>mkyong</dataReturn>
    </response>
    */
    
    public String getResponse()
    {
        String strXML = "" +
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
            "<response>\n" +
                "<isSuccess>"+( this.isSuccess ? "true" : "false" )+"</isSuccess>\n" +
                "<msgError>"+( this.msgError )+"</msgError>\n" +
                "<dataResponse>\n" +
                "";
        
        if( this.dataName.size() > 0 )
        {
            for( int i=0; i<this.dataName.size(); i++ )
            {
                String strName  = this.dataName.get(i);
                String strValue = this.dataValue.get(i);
                
                strXML += "" +
                    "<"+( strName )+">"+( strValue )+"</"+( strName )+">";
            }
        }
        
        strXML += "" +
                "</dataResponse>\n" +
            "</response>";
        
        if( firmaelectronica.config.Config.App_isDebug() )
        {
            firmaelectronica.helper.Log.writeTXT(strXML );
        }
        
        return strXML;
    }
}
