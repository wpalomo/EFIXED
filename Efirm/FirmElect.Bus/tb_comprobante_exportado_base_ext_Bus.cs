using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
   public  class tb_comprobante_exportado_base_ext_Bus
    {
       tb_comprobante_exportado_base_ext_Data Odata = new tb_comprobante_exportado_base_ext_Data();


       public Boolean GrabarDB(tb_comprobante_exportado_base_ext_Info Comprobante_info, ref string MensajeError)
       {
           try
           {
               return Odata.GrabarDB(Comprobante_info, ref MensajeError);
           }
           catch (Exception ex)
           {

               return false;
           }
           
       }

    }
}
