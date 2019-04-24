using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
namespace FirmElect.Data
{
  public  interface fx_IComprobanteId_Data
  {
      void GuardarIdComprobante(fx_Comprobante_generados_Info compro, string conexion);
      List<fx_Comprobante_generados_Info> Listacomprobantes(String conexion);
      bool Eliminar_Comprobantes_Generados_Base_Cliente(List<fx_Comprobante_generados_Info> lista_comp, string Conexion);
    }
}
