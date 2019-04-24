using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
   public  class factura_Bus
    {


       public factura_Bus()
       {
       }


       string sMensajeOutErrorXSD = "";


       public Boolean Validar_xml_vs_sxd(XmlDocument xmlCbteFactura, ref string MensajeOut)
       {
           Boolean isValid = true;

           try
           {
               
              string xsdString="";
              xsdString = FirmElect.Info.Properties.Resources.Factura_V_2_1_0;

               XmlSchemaSet schemas = new XmlSchemaSet();
               schemas.Add("", XmlReader.Create(new StringReader(xsdString)));


               //esquema
               XmlReaderSettings settings = new XmlReaderSettings();
               //settings.Schemas.Add( null, patchxsd);
               settings.Schemas.Add(schemas);
               settings.ValidationType = ValidationType.Schema;
               //settings.ValidationEventHandler += settings_ValidationEventHandler;

               //xml
               //--------------
               

               ///
               XmlReader rdr = XmlReader.Create(new StringReader(xmlCbteFactura.InnerXml), settings);
               while (rdr.Read()) { }

               MensajeOut = MensajeOut + sMensajeOutErrorXSD;

               return isValid;
           }
           catch (XmlSchemaException schemaEx)
           {
               MensajeOut = schemaEx.Message + " Documento no es valido con el xsd :" + " linea:" + schemaEx.LineNumber + " posicion " + schemaEx.LinePosition;
               isValid = false;
               return isValid;
           }
           catch (Exception ex)
           {
               MensajeOut = ex.Message + " Error en la validacion Schema XSD";
               isValid = false;
               return isValid;
           }
       }

      

       

    }
}
