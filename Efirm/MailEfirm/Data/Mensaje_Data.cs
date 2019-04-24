using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailEfirm.Info;


namespace MailEfirm.Data
{
   public class Mensaje_Data
    {


       public List<Mensaje_Info> consultar(eTipoMail TipoCorreo, ref string mensajeErrorOut)
       {
           try
           {
               List<Mensaje_Info> lista = new List<Mensaje_Info>();

               using (Entities_Mail_Efirm conexion = new Entities_Mail_Efirm())
               {

                   var q = from C in conexion.mail_Mensaje
                           where C.IdTipo_Mensaje == TipoCorreo.ToString()
                           select C;


                   foreach (var item in q)
                   {
                       Mensaje_Info infoC = new Mensaje_Info();

                       infoC.IdMensaje = item.IdMensaje;
                       infoC.Fecha = item.Fecha;
                       infoC.Para = item.Para;
                       infoC.Asunto = item.Asunto;
                       //infoC.Asunto_texto_mostrado = item.Asunto_texto_mostrado;
                       //infoC.Tiene_Adjunto = item.Tiene_Adjunto;
                       infoC.Prioridad = item.Prioridad;
                       //infoC.Leido = item.Leido;
                       infoC.Respondido = item.Respondido;
                       //infoC.No_Leido = item.No_Leido;
                       infoC.Texto_mensaje = item.Texto_mensaje;
                       infoC.Tipo_Mail =(eTipoMail)Enum.Parse(typeof(eTipoMail), item.IdTipo_Mensaje);
                       //infoC.Carpeta_Mensaje = item.Carpeta_Mensaje;
                       infoC.Eliminado = item.Eliminado;
                     

                       lista.Add(infoC);

                   }



               }

               return lista;


           }
           catch (Exception ex)
           {

              


               return new List<Mensaje_Info>();
           }

       }


    }
}
