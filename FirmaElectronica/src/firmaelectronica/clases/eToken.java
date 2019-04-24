/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.clases;
public class eToken
{
    protected long slot;
    protected String alias;
    protected String serie;
    
    public eToken()
    {
        this.slot = 0;
        this.alias = "";
        this.serie = "";
    }
    
    public eToken( long slot, String alias, String serie )
    {
        this.slot = slot;
        this.alias = alias;
        this.serie = serie;
    }
    
    public long getSlot()
    {
        return this.slot;
    }
    
    public String getAlias()
    {
        return this.alias;
    }
    
    public String getSerie()
    {
        return this.serie;
    }
}

