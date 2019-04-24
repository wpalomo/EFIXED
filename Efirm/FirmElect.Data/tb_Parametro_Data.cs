using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
  public  class tb_Parametro_Data
    {

      string mensaje = "";

      public tb_Parametro_Info consultar(ref string MensajeErrorOut)
      {
          try
          {
              tb_Parametro_Info InfoParametro = new tb_Parametro_Info();

              using (EntitiesFactElectronica DBfact = new EntitiesFactElectronica())
              {
                  var querry = from C in DBfact.tb_Parametro
                               select C;

                  foreach (var item in querry)
                  {
                    InfoParametro.IdParametro =item.IdParametro;
                    InfoParametro.url_ws_sri_Recep_cbte_Prueba=item.url_ws_sri_Recep_cbte_Prueba;
                    InfoParametro.url_ws_sri_Recep_cbte_Produc=item.url_ws_sri_Recep_cbte_Produc;
                    InfoParametro.url_ws_sri_Autorizacion_cbte_Prueba=item.url_ws_sri_Autorizacion_cbte_Prueba;
                    InfoParametro.url_ws_sri_Autorizacion_cbte_Produc = item.url_ws_sri_Autorizacion_cbte_Produc;
                    InfoParametro.url_ws_firma_efirm = item.url_ws_firma_efirm;
                    InfoParametro.offline_online = item.offline_online;

                    InfoParametro.Usa_Proxy = item.Usa_Proxy;
                    InfoParametro.Url_Proxy = item.Url_Proxy;
                    InfoParametro.Port_Proxy = item.Port_Proxy;
                    InfoParametro.Usuario_Proxy = item.Usuario_Proxy;
                    InfoParametro.Password_Proxy = item.Password_Proxy;

                    InfoParametro.Registra_Log = item.Registra_Log;
                    InfoParametro.Version = item.Version;

                      
                  }
              
              }

              return InfoParametro;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
              MensajeErrorOut = ex.InnerException + " " + ex.Message;
              return  new tb_Parametro_Info();
          }
      }

      public Boolean GrabarDB(tb_Parametro_Info Info, ref string MensajeErrorOut)
      {
          try
          {
              using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
              {

                  var Address = new tb_Parametro();
                  Address.IdParametro = Info.IdParametro;
                  Address.url_ws_sri_Recep_cbte_Prueba = Info.url_ws_sri_Recep_cbte_Prueba;
                  Address.url_ws_sri_Recep_cbte_Produc = Info.url_ws_sri_Recep_cbte_Produc;
                  Address.url_ws_sri_Autorizacion_cbte_Prueba = Info.url_ws_sri_Autorizacion_cbte_Prueba;
                  Address.url_ws_sri_Autorizacion_cbte_Produc = Info.url_ws_sri_Autorizacion_cbte_Produc;
                  Address.url_ws_firma_efirm = Info.url_ws_firma_efirm;
                  Address.Usa_Proxy = Info.Usa_Proxy;
                  Address.Url_Proxy = Info.Url_Proxy;
                  Address.Port_Proxy = Info.Port_Proxy;
                  Address.Usuario_Proxy = Info.Usuario_Proxy;
                  Address.Password_Proxy = Info.Password_Proxy;
                  Address.Registra_Log = Info.Registra_Log;
                  Address.Version = Info.Version;
                  Address.offline_online = Info.offline_online;
                  Context.tb_Parametro.Add(Address);
                  Context.SaveChanges();

              }

              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
              MensajeErrorOut = ex.InnerException + " " + ex.Message;

              return false;
          }

      }

      public Boolean ModificarDB(tb_Parametro_Info Info, ref string mensajeOut)
      {
          try
          {
              using (EntitiesFactElectronica DbFactElec = new EntitiesFactElectronica())
              {
                  var resultado = DbFactElec.tb_Parametro.First(v => v.IdParametro == Info.IdParametro);

                  resultado.url_ws_sri_Recep_cbte_Prueba = Info.url_ws_sri_Recep_cbte_Prueba;
                  resultado.url_ws_sri_Recep_cbte_Produc = Info.url_ws_sri_Recep_cbte_Produc;
                  resultado.url_ws_sri_Autorizacion_cbte_Prueba = Info.url_ws_sri_Autorizacion_cbte_Prueba;
                  resultado.url_ws_sri_Autorizacion_cbte_Produc = Info.url_ws_sri_Autorizacion_cbte_Produc;
                  resultado.url_ws_firma_efirm = Info.url_ws_firma_efirm;

                   resultado.offline_online = Info.offline_online;

                  resultado.Usa_Proxy = Info.Usa_Proxy;
                  resultado.Url_Proxy = Info.Url_Proxy;
                  resultado.Port_Proxy = Info.Port_Proxy;
                  resultado.Usuario_Proxy = Info.Usuario_Proxy;
                  resultado.Password_Proxy = Info.Password_Proxy;


                  resultado.Registra_Log = Info.Registra_Log;
                 // resultado.Version = Info.Version;


                  DbFactElec.SaveChanges();

              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;

              return false;
          }
      }



    }
}
