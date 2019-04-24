using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;
namespace FirmElect.Bus
{
   public class fx_Comprobantes_generados_Bus
    {
       fx_Comprobante_generados_Data data = new fx_Comprobante_generados_Data();
       eCliente Cliente;
       public void GuardarComprobantes_generados_AX(fx_Comprobante_generados_Info compro, string conexion)
        {
           
            try
            {
                 data.GuardarComprobantes_generados_AX(compro, conexion);
            }
            catch (Exception ex)
            {
            }
        }

       public void GuardarComprobantes_generados_FX(fx_Comprobante_generados_Info compro)
       {

           try
           {
               data.GuardarComprobantes_generados_FX(compro);
           }
           catch (Exception ex)
           {
           }
       }
       public List<fx_Comprobante_generados_Info> Listacomprobantes_generados_AX(string conexion, string Cliente)
        {
            try
            {
                List<fx_Comprobante_generados_Info> lista=null;
               if(Cliente==eCliente.EXPOGYE.ToString())
                lista= data.Listacomprobantes_generados_AX(conexion);
               if (Cliente == eCliente.FIXED.ToString())
                   lista = data.Listacomprobantes_generados_FX();
               return lista;

            }
            catch (Exception ex)
            {
                return new List<fx_Comprobante_generados_Info>();
            }
        }


       public bool Eliminar_Comprobantes_Generados_FX(fx_Comprobante_generados_Info info,string conexion, string Cliente)
       {
           try
           {
               bool bandera = false;
               if (Cliente == eCliente.EXPOGYE.ToString())
                   bandera = data.Eliminar_Comprobantes_Generados_AX(info, conexion);
               if (Cliente == eCliente.FIXED.ToString())
                   bandera = data.Eliminar_Comprobantes_Generados_FX(info);
               return bandera;
           }
           catch (Exception)
           {

               return false;
           }
       }
    }
}
