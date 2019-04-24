using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
   public  class tb_usuario_Bus
    {

       tb_usuario_Data odata;

       public tb_usuario_Bus()
       {
           odata = new tb_usuario_Data();

       }

       public Boolean Login(string IdUsuario, string Password, ref string msg)
       {
           try
           {
            return   odata.Login(IdUsuario, Password, ref msg);
           }
           catch (Exception ex)
           {

               msg = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(msg,eTipoError.ERROR,this.ToString(), "",
                   "", "", "", "", DateTime.Now);
               oData.Guardar_Log_Error(Log_Error_sis, ref msg);


               return false;
               
           }

       }

    }
}
