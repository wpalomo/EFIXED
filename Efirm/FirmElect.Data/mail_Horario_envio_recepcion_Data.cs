using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
   public class mail_Horario_envio_recepcion_Data
    {

       public mail_Horario_envio_recepcion_Info consultar(ref string mensajeErrorOut)
       {
           try
           {


               mail_Horario_envio_recepcion_Info InfoClaveContg = new mail_Horario_envio_recepcion_Info();

           

               using (EntitiesFactElectronica DBFactElec = new EntitiesFactElectronica())
               {




                   var querry2 = from clavecon in DBFactElec.mail_Horario_envio_recepcion
                                 select clavecon;


                   foreach (var item in querry2)
                   {
                     

                    InfoClaveContg.IdHorario_Envio_Recep= item.IdHorario_Envio_Recep;
                    InfoClaveContg.Nombre= item.Nombre;
                    InfoClaveContg.Descripcion_a_mostrar= item.Descripcion_a_mostrar;
                    InfoClaveContg.Valor= item.Valor;
                    InfoClaveContg.Chequeado= item.Chequeado;
                    InfoClaveContg.IdTipoTiempo = item.IdTipoTiempo;


                   }


               }



               return InfoClaveContg;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
               mensajeErrorOut = ex.InnerException + " " + ex.Message;

               return new mail_Horario_envio_recepcion_Info();
           }

       }


    }
}
