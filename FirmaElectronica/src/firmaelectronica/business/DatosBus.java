/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firmaelectronica.business;

import java.security.cert.X509Certificate;

/**
 *
 * @author roberto
 */
public class DatosBus {
    
    public static DatosUsuario GetDatos(X509Certificate signingCert)
    {
        DatosUsuario datosUsuario = new   DatosUsuario();
     if (signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.1") != null)
    {
    
      datosUsuario.setCedula(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.1")).trim());
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.2") != null) {
        datosUsuario.setNombre(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.2")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.3") != null)
      {
        String txtApellido = new String(signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.3")).trim();
        if (signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.4") != null) {
          txtApellido = txtApellido + " " + new String(signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.4")).trim();
        }
        datosUsuario.setApellido(txtApellido);
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.10") != null) {
        datosUsuario.setInstitucion(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.10")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.5") != null) {
        datosUsuario.setCargo(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.5")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.9") != null) {
        datosUsuario.setCiudad(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.9")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.12") != null) {
        datosUsuario.setPais(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.12")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.7") != null) {
        datosUsuario.setDireccion(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37947.3.7")).trim());
      }
      if (signingCert.getSerialNumber() != null) {
        datosUsuario.setSerial(signingCert.getSerialNumber().toString());
      }
    }
   
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.1") != null) {
        datosUsuario.setCedula(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.1")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.2") != null) {
        datosUsuario.setNombre(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.2")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.3") != null)
      {
        String txtApellido = new String(signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.3")).trim();
        if (signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.4") != null) {
          txtApellido = txtApellido + " " + new String(signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.4")).trim();
        }
        datosUsuario.setApellido(txtApellido);
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.10") != null) {
        datosUsuario.setInstitucion(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.10")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.5") != null) {
        datosUsuario.setCargo(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37746.3.5")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37946.3.9") != null) {
        datosUsuario.setCiudad(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37946.3.9")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37946.3.12") != null) {
        datosUsuario.setPais(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37946.3.12")).trim());
      }
      if (signingCert.getExtensionValue("1.3.6.1.4.1.37946.3.7") != null) {
        datosUsuario.setDireccion(new String(signingCert.getExtensionValue("1.3.6.1.4.1.37946.3.7")).trim());
      }
      if (signingCert.getSerialNumber() != null) {
        datosUsuario.setSerial(signingCert.getSerialNumber().toString());
      }
      
      if (signingCert.getSerialNumber() != null) {
        datosUsuario.setSerial(signingCert.getSerialNumber().toString());
      }
     
        return datosUsuario;
    }
}
