using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace FirmElect.Info
{
   public class mail_Validar_Correo_Info
    {
       public Boolean email_bien_escrito(String email)
       {
           try
           {
               String expresion;
                             
               expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
               if (Regex.IsMatch(email, expresion.Trim()))
               {
                   if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
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
