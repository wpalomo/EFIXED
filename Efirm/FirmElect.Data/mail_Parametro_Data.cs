using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
  public  class mail_Parametro_Data
    {

      public mail_Parametro_Info consultar(ref string mensajeErrorOut)
      {
          try
          {



              mail_Parametro_Info InfoClaveContg = new mail_Parametro_Info();

            

              using (EntitiesFactElectronica DBFactElec = new EntitiesFactElectronica())
              {

                  var querry2 = from clavecon in DBFactElec.mail_Parametro
                                select clavecon;


                  foreach (var item in querry2)
                  {
                      InfoClaveContg.IdParametro = item.IdParametro;
                      InfoClaveContg.valor_min_envi_recep_aut = item.valor_min_envi_recep_aut;
                      InfoClaveContg.envio_recep_aut_salir = item.envio_recep_aut_salir;
                      InfoClaveContg.enviar_solo_pdf_ride = item.enviar_solo_pdf_ride;
                      InfoClaveContg.enviar_solo_xml_ride = item.enviar_solo_xml_ride;

                  }


              }

              return InfoClaveContg;
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
              mensajeErrorOut = ex.InnerException + " " + ex.Message;

              return new mail_Parametro_Info();
          }

      }

      public Boolean Guardar(mail_Parametro_Info Info, ref string MensajeErrorOut)
      {
        try 
        {	        
		
	
           using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
           {

                    var Address = new mail_Parametro();


                    var Q = from per in Context.mail_Parametro
                            where  
                            per.IdParametro == Info.IdParametro
                           select per;

                    if (Q.ToList().Count == 0)// no esta en la base
                    {
                        Address.IdParametro = "PARA_MAIL";
                        Address.valor_min_envi_recep_aut = Info.valor_min_envi_recep_aut;
                        Address.envio_recep_aut_salir = Info.envio_recep_aut_salir;
                        Address.enviar_solo_pdf_ride = Info.enviar_solo_pdf_ride;
                        Address.enviar_solo_xml_ride = Info.enviar_solo_xml_ride;
                        Context.mail_Parametro.Add(Address);
                        Context.SaveChanges();
                    }
                    else
                    {
                      //modifcar

                        var resultado = Context.mail_Parametro.First(v => v.IdParametro == Info.IdParametro);


                        resultado.valor_min_envi_recep_aut = Info.valor_min_envi_recep_aut;
                        resultado.envio_recep_aut_salir = Info.envio_recep_aut_salir;
                        resultado.enviar_solo_pdf_ride = Info.enviar_solo_pdf_ride;
                        resultado.enviar_solo_xml_ride = Info.enviar_solo_xml_ride;

                        Context.SaveChanges();



                    }

                }

                return true;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
              string mensaje = "";
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;

              MensajeErrorOut = mensaje;
              return false;

                
            }
        

      }


    }
}
