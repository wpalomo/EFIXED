using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;



namespace FirmElect.Bus
{
   public class tb_Parametro_Bus
    {

       tb_Parametro_Data Odata;

       public tb_Parametro_Bus()
       {
           Odata = new tb_Parametro_Data();
       }


       public tb_Parametro_Info consultar(ref string mensajeErrorOut)
       {
           try
           {
               return Odata.consultar(ref mensajeErrorOut);

           }
           catch (Exception ex)
           {

               return new tb_Parametro_Info();
           }
       }


       public Boolean GrabarDB(tb_Parametro_Info Info, ref string mensajeOut)
       {
           try
           {
               return Odata.GrabarDB(Info, ref mensajeOut);
           }
           catch (Exception ex)
           {

               return false;
           }
       }


       public Boolean ModificarDB(tb_Parametro_Info Info, ref string mensajeOut)
       {
           try
           {
               return Odata.ModificarDB(Info, ref mensajeOut);

           }
           catch (Exception ex)
           {
               string mensajeErrorOut = "";
               #region Log de Errores
               mensajeErrorOut = ex.Message.ToString();
               tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensajeErrorOut,eTipoError.ERROR, this.ToString(), "",
                   "", "", "", "", DateTime.Now);
               oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
               #endregion

               return false;
               
           }

       }

    }
}
