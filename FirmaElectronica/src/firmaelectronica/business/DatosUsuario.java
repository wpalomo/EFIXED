/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;

public class DatosUsuario
{
  private String cedula;
  private String nombre;
  private String apellido;
  private String institucion;
  private String cargo;
  private String serial;
  private String fechaFirmaArchivo;
  private String crl;
  private String ciudad;
  private String pais;
  private String direccion;
  
  public String getSerial()
  {
    return this.serial;
  }
  
  public void setSerial(String serial)
  {
    this.serial = serial;
  }
  
  public void setApellido(String apellido)
  {
    this.apellido = apellido;
  }
  
  public void setCargo(String cargo)
  {
    this.cargo = cargo;
  }
  
  public void setCedula(String cedula)
  {
    this.cedula = cedula;
  }
  
  public void setInstitucion(String institucion)
  {
    this.institucion = institucion;
  }
  
  public void setNombre(String nombre)
  {
    this.nombre = nombre;
  }
  
  public void setFechaFirmaArchivo(String fechaFirmaArchivo)
  {
    this.fechaFirmaArchivo = fechaFirmaArchivo;
  }
  
  public String getApellido()
  {
    return this.apellido;
  }
  
  public String getCargo()
  {
    return this.cargo;
  }
  
  public String getCedula()
  {
    return this.cedula;
  }
  
  public String getInstitucion()
  {
    return this.institucion;
  }
  
  public String getNombre()
  {
    return this.nombre;
  }
  
  public String getFechaFirmaArchivo()
  {
    return this.fechaFirmaArchivo;
  }
  
  public String getCrl()
  {
    return this.crl;
  }
  
  public void setCrl(String crl)
  {
    this.crl = crl;
  }
  
  public String toString()
  {
    return 
      "cedula=" + this.cedula + ",nombre=" + this.nombre + ",apellido=" + this.apellido + ",institucion=" + this.institucion + ",cargo=" + this.cargo + ",serial=" + this.serial;
  }
  
  public String getCiudad()
  {
    return this.ciudad;
  }
  
  public void setCiudad(String ciudad)
  {
    this.ciudad = ciudad;
  }
  
  public String getPais()
  {
    return this.pais;
  }
  
  public void setPais(String pais)
  {
    this.pais = pais;
  }
  
  public String getDireccion()
  {
    return this.direccion;
  }
  
  public void setDireccion(String direccion)
  {
    this.direccion = direccion;
  }
}
