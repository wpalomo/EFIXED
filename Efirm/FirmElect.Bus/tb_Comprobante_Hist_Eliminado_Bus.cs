using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;


namespace FirmElect.Bus
{
   public class tb_Comprobante_Hist_Eliminado_Bus
    {

       Itb_Comprobante_Hist_Eliminado_Data Odata;

       public tb_Comprobante_Hist_Eliminado_Bus()
       {
           Odata = new tb_Comprobante_Hist_Eliminado_Data();
       }

        public bool GrabarDB(Info.tb_Comprobante_Hist_Eliminado_Info Info,string UsuarioAnulo,string MotivoAnulacion, ref string mensajeErrorOut)
        {
            try
            {
                return Odata.GrabarDB(Info,UsuarioAnulo,MotivoAnulacion,ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool GrabarDB(List<Info.tb_Comprobante_Hist_Eliminado_Info> ListInfo,string usuarioAnulo,string MotivoAnulacion,  ref string mensajeErrorOut)
        {
            try
            {
                return Odata.GrabarDB(ListInfo, usuarioAnulo,MotivoAnulacion,ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
