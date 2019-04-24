using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;




namespace FirmElect.Data
{
  public  class tb_Clave_Conting_Data
    {

      public tb_Clave_Conting_Info consultar_ult_clave_no_usada(int IdEmpresa,int idAmbiente, ref string mensajeErrorOut)
      {
          try
          {


              tb_Clave_Conting_Info InfoClaveContg = new tb_Clave_Conting_Info();

              decimal IdClaveContige_no_usado = 0;


              using (EntitiesFactElectronica DBFactElec = new EntitiesFactElectronica())
              {


                  var querry = (from claveCont in DBFactElec.tb_Clave_Conting
                               where claveCont.IdEmpresa==IdEmpresa
                               && claveCont.Usado==false
                               && claveCont.IdAmbiente == idAmbiente
                               select claveCont.IdClave).Min();

                  
                  IdClaveContige_no_usado = Convert.ToDecimal(querry.ToString());



                  var querry2 = from clavecon in DBFactElec.tb_Clave_Conting
                                where clavecon.IdEmpresa == IdEmpresa
                                && clavecon.IdClave == IdClaveContige_no_usado
                                && clavecon.IdAmbiente == idAmbiente
                                select clavecon;


                  foreach (var item in querry2)
                  {
                    InfoClaveContg.IdEmpresa= item.IdEmpresa;
                    InfoClaveContg.IdClave= item.IdClave;
                    InfoClaveContg.Usado= item.Usado;
                    InfoClaveContg.Fecha_Trans= item.Fecha_Trans;
                    InfoClaveContg.ClaveContingencia= item.ClaveContingencia;
                    InfoClaveContg.Fecha_Importacion= item.Fecha_Importacion;
                    InfoClaveContg.Estado = item.Estado;
                    InfoClaveContg.IdAmbiente = item.IdAmbiente;
                      
                  }
                 

              }


              Modificar_Clave_Acceso_UsadaDB(InfoClaveContg.IdEmpresa, InfoClaveContg.ClaveContingencia,idAmbiente, true, ref mensajeErrorOut);

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

              return new tb_Clave_Conting_Info();
          }
      
      }


      public Boolean Modificar_Clave_Acceso_UsadaDB(int IdEmpresa, string IdClaveAccesoUsada,int IdAmbiente, Boolean Usada, ref string mensajeErrorOut)
      {
          try
          {
              using (EntitiesFactElectronica DbFactElec = new EntitiesFactElectronica())
              {

                  var resultado = DbFactElec.tb_Clave_Conting.First(v => v.IdEmpresa == IdEmpresa
                      && v.ClaveContingencia == IdClaveAccesoUsada && v.IdAmbiente == IdAmbiente);


                  resultado.Usado = Usada;


                  DbFactElec.SaveChanges();

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


              return false;
          }
      }


      public Boolean Guardar_Clave_Contigencia(List<tb_Clave_Conting_Info> Claves) 
      {
          try
          {
              foreach (var item in Claves)
              {
                  using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                  {

                      var Address = new tb_Clave_Conting();

                      Address.IdEmpresa = item.IdEmpresa;
                      Address.ClaveContingencia = item.ClaveContingencia;
                      Address.IdClave = item.IdClave;
                      Address.Usado = item.Usado;
                      Address.Fecha_Trans = DateTime.Now;
                      Address.Fecha_Importacion = DateTime.Now;
                      Address.Estado = item.Estado;
                      Address.IdAmbiente = item.IdAmbiente;


                      conexion.tb_Clave_Conting.Add(Address);

                      conexion.SaveChanges();
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


              return false;
          }
      }

      public List<tb_Clave_Conting_Info> consultar_ult_clave_no_usada(int IdEmpresa) 
      {
          try
          {
              using (EntitiesFactElectronica conexio = new EntitiesFactElectronica())
              {
                  List<tb_Clave_Conting_Info> response = new List<tb_Clave_Conting_Info>();
                  List<tb_Clave_Conting> Claves = conexio.tb_Clave_Conting.Where(v => v.IdEmpresa == IdEmpresa).ToList();
                  foreach (var item in Claves)
                  {
                      response.Add(new tb_Clave_Conting_Info() { Usado = item.Usado, IdEmpresa = item.IdEmpresa, IdClave= item.IdClave, Fecha_Trans= item.Fecha_Trans, Fecha_Importacion = item.Fecha_Importacion, Estado = item.Estado, ClaveContingencia = item.ClaveContingencia });
                  }

                  return response;
              }
          }
          catch (Exception)
          {
              return new List<tb_Clave_Conting_Info>();

          }
      
      }


      public decimal getId(ref string MensajeErrorOut)
        {
            int Id = 0;
            try
            {
                EntitiesFactElectronica contex = new EntitiesFactElectronica();
                var selecte = contex.tb_Clave_Conting.Count();

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.tb_Clave_Conting                                   
                                     select q.IdClave).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {            
   
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return 0;
            }
        }

    


      public List<tb_Clave_Conting_Info> Consultar(ref string MensajeErrorOut)
      {
          try
          {
                                                  
              List<tb_Clave_Conting_Info> lista = new List<tb_Clave_Conting_Info>();
              EntitiesFactElectronica OEselecClaveCont = new EntitiesFactElectronica();
              var selectClaveCont = from C in OEselecClaveCont.tb_Clave_Conting
                                    join E in OEselecClaveCont.tb_Empresa on
                                    new { C.IdEmpresa } equals new { E.IdEmpresa }

                                    select new
                                    {
                                        C.IdEmpresa,
                                        C.IdClave,
                                        C.Usado,
                                        C.IdAmbiente,
                                        C.Fecha_Trans,
                                        C.Fecha_Importacion,
                                        C.ClaveContingencia,
                                        C.Estado,
                                        E.RazonSocial

                                    };
                                
              foreach (var item in selectClaveCont)
              {
                  tb_Clave_Conting_Info Cbt = new tb_Clave_Conting_Info();

                  Cbt.IdEmpresa = item.IdEmpresa;
                  Cbt.IdClave = item.IdClave;
                  Cbt.IdAmbiente = item.IdAmbiente;
                  Cbt.Usado = item.Usado;
                  Cbt.Fecha_Trans = item.Fecha_Trans;
                  Cbt.Fecha_Importacion = item.Fecha_Importacion;
                  Cbt.ClaveContingencia = item.ClaveContingencia;
                  Cbt.Estado = item.Estado;
                  Cbt.RazonSocial = item.RazonSocial;

                  lista.Add(Cbt);
              }
              return lista;
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
              MensajeErrorOut = ex.InnerException + " " + ex.Message;

              return new List<tb_Clave_Conting_Info>();
          }
      }


    }
}
