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
   public  class comprobanteRetencion_Bus
    {


       public Boolean Validar_xml_vs_sxd(XmlDocument xmlCbteRetencionDoc, ref string MensajeOut)
       {
           Boolean isValid = true;

           try
           {

               string xsdString = "";
               xsdString = FirmElect.Info.Properties.Resources.comprobanteRetencion;

               XmlSchemaSet schemas = new XmlSchemaSet();
               schemas.Add("", XmlReader.Create(new StringReader(xsdString)));


               //esquema
               XmlReaderSettings settings = new XmlReaderSettings();
               //settings.Schemas.Add( null, patchxsd);
               settings.Schemas.Add(schemas);
               settings.ValidationType = ValidationType.Schema;

               //xml
               //--------------
               ///
               XmlReader rdr = XmlReader.Create(new StringReader(xmlCbteRetencionDoc.InnerXml), settings);
               while (rdr.Read()) { }

               MensajeOut = "";

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
