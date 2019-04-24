using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirmElect.Info;
using FirmElect.Data;

namespace FirmElect.Data
{
  public  class tb_tocken_x_usuario_tocken_Data
    {

      public List<tb_tocken_x_usuario_tocken_Info> ConsultaTockenUsuario()
      {
          List<tb_tocken_x_usuario_tocken_Info> lista = new List<tb_tocken_x_usuario_tocken_Info>();
          try
          {
              EntitiesFactElectronica oEnti = new EntitiesFactElectronica();
              var Query = from q in oEnti.tb_Tocken_x_Usuario_Tocken
                          select q;
              foreach (var item in Query)
              {
                  tb_tocken_x_usuario_tocken_Info Obj = new tb_tocken_x_usuario_tocken_Info();

                  Obj.IdTocken = item.IdTocken;
                  Obj.IdUsuario_Tocken = item.IdUsuario_Tocken;
                  Obj.Observacion = item.Observacion;


                  lista.Add(Obj);
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

              return new List<tb_tocken_x_usuario_tocken_Info>();
          }
      }

    }
}
