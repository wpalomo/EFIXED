using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;
namespace FirmElect.Data
{
  public  interface fx_GeneradorXML_IComprobantes_No_Generados_Data
    {

      void Guardar_Comprobantes_Generaron_Error_Carga(fx_GeneradorXML_Comprobantes_No_Generados_Info compNoGenerados_info, string conexio);
      List<fx_GeneradorXML_Comprobantes_No_Generados_Info> Listados_ComprobantesNo_Generados(string conexio);
        bool Eliminar_ComprobantesNo_Generados(List<fx_GeneradorXML_Comprobantes_No_Generados_Info> lista_comp, string conexio);
    }
}
