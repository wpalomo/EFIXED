using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
   public class tb_Empresa_externa_Data
    {

       public List<tb_Empresa_externa_Info> consultar(ref string mensajeErrorOut)
       {
           try
           {
               List<tb_Empresa_externa_Info> lista = new List<tb_Empresa_externa_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   conexion.Database.CommandTimeout = 3000;


                   var q = from C in conexion.tb_Empresa_externa
                           select C;

                   foreach (var item in q)
                   {
                       tb_Empresa_externa_Info infoC = new tb_Empresa_externa_Info();

                       infoC.Cod_Empresa_exte = item.Cod_Empresa_exte;
                       infoC.nom_empresa_ext = item.nom_empresa_ext;
                   
                       lista.Add(infoC);

                       mensajeErrorOut = "Proceso OK";
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {

               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return new List<tb_Empresa_externa_Info>();
           }

       }


    }
}
