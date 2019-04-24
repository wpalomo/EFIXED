using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirmElect.Info;
using FirmElect.Data;




namespace FirmElect.Bus
{
   public class tb_Cliente_Bus
    {
       tb_Cliente_Data odata = new tb_Cliente_Data();
       
       public List<tb_Cliente_Info> Consulta_Clientes(ref string MensajeErrorOut)
       {
           try
           {
               return odata.Consulta_Clientes(ref MensajeErrorOut);
           }
           catch (Exception ex)
           {
               #region Log de Errores
               MensajeErrorOut = ex.Message.ToString();
               tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(MensajeErrorOut, eTipoError.ERROR, this.ToString(), "",
                   "", "", "", "", DateTime.Now);
               oData.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               #endregion

               return new List<tb_Cliente_Info>();
           }
       
       }

       public Boolean Modificar_Cliente(List<tb_Cliente_Info> lista, ref  string MensajeErrorOut)
       {
           try
           {
               return odata.Modificar_Cliente(lista, ref  MensajeErrorOut);
           }
           catch (Exception ex)
           {
               #region Log de Errores
                   MensajeErrorOut = ex.Message.ToString();
                   tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                   tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(MensajeErrorOut, eTipoError.ERROR, this.ToString(), "",
                       "", "", "", "", DateTime.Now);
                   oData.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               #endregion

               return false;
           }
       }



        public tb_Cliente_Bus(){}
    }
}
