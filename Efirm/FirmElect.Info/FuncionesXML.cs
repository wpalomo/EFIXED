using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Serialization;
using System.Web;
using FirmElect.Info;
using System.Net;
using System.Web;
using System.Text.RegularExpressions;







namespace FirmElect.Info
{
   public  class Funciones
    {

       
       public static string Formating_xml(string xmlstring)
       {

           try
           {

               
               XmlDocument xmldo = new XmlDocument();
               xmldo.LoadXml(xmlstring);
               MemoryStream w = new MemoryStream();
               XmlTextWriter writer = new XmlTextWriter(w, null);


               writer.Formatting = Formatting.Indented;
               xmldo.WriteContentTo(writer);

               writer.Flush();
               w.Seek(0L, SeekOrigin.Begin);

               StreamReader reader = new StreamReader(w);
               return HttpUtility.HtmlDecode(reader.ReadToEnd());
           }
           catch (Exception ex)
           {

               return "";
           }
       }




       public static bool Correo_Valido(string string_a_Validar)
       {
           try
           {
               //expresion para correo 
               Regex Val = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
               if (Val.IsMatch(string_a_Validar) )
               {
                   return true;
               }
               else
               {
                   return false;
               }

           }
           catch (Exception ex)
           {
               return false;
               
           }
       }
       

    }
}
