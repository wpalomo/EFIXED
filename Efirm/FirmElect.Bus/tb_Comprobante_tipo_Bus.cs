using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
   public  class tb_Comprobante_tipo_Bus
    {
       tb_Comprobante_tipo_Data Odata = new tb_Comprobante_tipo_Data();

       public List<tb_Comprobante_tipo_Info> consultar(int IdEmpresa, ref string mensajeErrorOut)
       {
           try
           {

               return Odata.consultar(IdEmpresa,ref mensajeErrorOut);
           }
           catch (Exception ex)
           {

               return new List<tb_Comprobante_tipo_Info>();
           }

       }

       public List<tb_Comprobante_tipo_Info> consultar(ref string mensajeErrorOut)
       {
           try
           {

               return Odata.consultar(ref mensajeErrorOut);
           }
           catch (Exception ex)
           {

               return new List<tb_Comprobante_tipo_Info>();
           }

       }
      
       public List<tb_Comprobante_tipo_Info> consultar_solo_comprobantes(ref string mensajeErrorOut)
       {
           try
           {

               return Odata.consultar_solo_comprobantes(ref mensajeErrorOut);
           }
           catch (Exception ex)
           {

               return new List<tb_Comprobante_tipo_Info>();
           }
       }

       public Boolean ModificarDB(tb_Comprobante_tipo_Info info, ref string MensajeErrorOut)
       {
           try
           {
               return Odata.ModificarDB(info, ref MensajeErrorOut);

           }
           catch (Exception ex)
           {
               return false;
           }
       }

    }
}
