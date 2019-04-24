using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using FirmElect.Info;


namespace FirmElect.Data
{
  public  class tb_Catalogo_Data
    
    {

      public List<tb_Catalogo_Info> Consulta_Catalogo_x_IdTipoCatalogo(int IdTipoCatalogo)
      {
          try
          {
              List<tb_Catalogo_Info> lista = new List<tb_Catalogo_Info>();

              EntitiesFactElectronica OEselecCatalogo = new EntitiesFactElectronica();

              var selectCatalogo = from C in OEselecCatalogo.tb_Catalogo
                                  where C.IdTIpoCatalogo == IdTipoCatalogo
                                  select C;

              foreach (var item in selectCatalogo)
              {
                  tb_Catalogo_Info Cbt = new tb_Catalogo_Info();


                  Cbt.IdCatalogo = item.IdCatalogo;
                  Cbt.IdTIpoCatalogo = item.IdTIpoCatalogo; 
                  Cbt.Codigo = item.Codigo;
                  Cbt.Descripcion = item.Descripcion;
                          
                  lista.Add(Cbt);
              }
              return lista;
          }
          catch (Exception ex)
          {
              string MensajeErrorOut = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
              MensajeErrorOut = ex.InnerException + " " + ex.Message;

              return new List<tb_Catalogo_Info>();
          }
      }


      public List<tb_Catalogo_Info> Lista_TipoComprobantes(ref string MensajeErrorOut)
      {
          try
          {
              List<tb_Catalogo_Info> lista = new List<tb_Catalogo_Info>();

              EntitiesFactElectronica OEselecCatalogo = new EntitiesFactElectronica();

              var selectCatalogo = from C in OEselecCatalogo.tb_Catalogo
                                   where C.IdTIpoCatalogo == 1
                                   select C;

              foreach (var item in selectCatalogo)
              {
                  tb_Catalogo_Info Cbt = new tb_Catalogo_Info();

                  Cbt.IdCatalogo = item.IdCatalogo;
                  Cbt.Descripcion = item.Descripcion;
                  //Cbt.IdTIpoCatalogo = item.IdTIpoCatalogo;
                  //Cbt.Codigo = item.Codigo;
                  
                  lista.Add(Cbt);
              }
              return lista;
          }
          catch (Exception ex)
          {
             // string MensajeErrorOut = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
              MensajeErrorOut = ex.InnerException + " " + ex.Message;

              return new List<tb_Catalogo_Info>();
          }
      }


    }
}
