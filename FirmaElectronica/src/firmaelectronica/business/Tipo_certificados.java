/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;
public enum Tipo_certificados {

    
    Certificado("1","Certificado Digital"),eToken("2","Aladin eToken");
    
    String Id;
    String Descripcion;

    private Tipo_certificados(String Id, String Descripcion) {
        this.Id = Id;
        this.Descripcion = Descripcion;
    }

    public String getDescripcion() {
        return Descripcion;
    }

    public void setDescripcion(String Descripcion) {
        this.Descripcion = Descripcion;
    }
     
    public String getId()
    {
      return this.Id;
    }
    
    public void setId(String Tipo)
    {
       this.Id = Tipo;
    }
    
    
     
     
     
}
