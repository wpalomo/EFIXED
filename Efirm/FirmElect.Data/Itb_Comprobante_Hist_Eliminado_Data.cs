using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
  public   interface Itb_Comprobante_Hist_Eliminado_Data
    {
      Boolean GrabarDB(tb_Comprobante_Hist_Eliminado_Info Info,string usuarioAnulo,string MotivoAnulacion, ref string mensajeErrorOut);
      Boolean GrabarDB(List<tb_Comprobante_Hist_Eliminado_Info> ListInfo,string usuarioAnulo,string MotivoAnulacion, ref string mensajeErrorOut);


    }
}
