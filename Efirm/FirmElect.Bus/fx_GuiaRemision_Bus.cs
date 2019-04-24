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
using FirmElect.Data;
using FirmElect.Data.Proceso_efixed;

using FirmElect.Info;
using FirmElect.Info.class_sri.GuiaRemision;

namespace FirmElect.Bus
{
  public   class fx_GuiaRemision_Bus
    {

        fx_GeneradorXML_IGuia data;
        public List<guiaRemision> GenerarXmlGuiaRemision(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente, string OconEfirm, string FormatoFechaSRI, string formatoFechaDB, eCliente cliente)
        {
            try
            {
                switch (cliente)
                {
                    
                    case eCliente.FIXED:
                        data = new fx_Generador_XML_Guia_Fixed();
                        break;
                    default:
                        break;
                }

                return data.GenerarXmlRetencion(FechaIni, FechaFin, ConexionDBCliente, OconEfirm, FormatoFechaSRI, formatoFechaDB);

            }
            catch (Exception)
            {

                return new List<guiaRemision>();
            }
        }

        public Boolean Validar_xml_vs_sxd(XmlDocument xmlCbteGuiaRemision, ref string MensajeOut)
        {
            Boolean isValid = true;

            try
            {
                int countCicloWhile = 0;

                string xsdString = "";
                xsdString = FirmElect.Info.Properties.Resources.guiaRemision;

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

                XmlReader rdr = null;
                rdr = XmlReader.Create(new StringReader(xmlCbteGuiaRemision.InnerXml), settings);

                while (rdr.Read())
                {
                    countCicloWhile = countCicloWhile + 1;

                    if (rdr.Name == "infoAdicional")
                    {
                        countCicloWhile = countCicloWhile + 1;
                    }

                    if (countCicloWhile == 1000)
                    {
                        break;
                    }

                }

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
