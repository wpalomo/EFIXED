using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
   public interface Itb_Comprobante_Procesos_externos
    {
       Boolean GrabarDB(tb_Comprobante_Info InfoCbte, ref string MensajeErrorOut,string cadena);
       List<tb_Comprobante_Info> Consultar(int IdEmpresa, ref string MensajeErrorOut, string cadena);

    }
}
