using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirmElect.Info;
using FirmElect.Data;

using System.ComponentModel;

namespace FirmElect.Data
{
 public class tb_Tocken_Data
    {

     public Boolean GuardarDB(List<tb_Tocken_Info> lista, ref string  MensajeErrorOut)
     {
         try
         {
             using (  EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
             {
                 tb_Tocken_Data odata = new tb_Tocken_Data();
                 foreach (var item in lista)
                 {
                     if (item.IdTockenAUX == null)
                     {                         
                         if (odata.GuardarDB(item,ref MensajeErrorOut))
                         {                                               
                         }
                     }
                     else
                     { 
                       // actualizar                        
                         if (odata.ModificarDB(item, ref MensajeErrorOut))
                         { }                      
                     }                    

                 }                                                                      
             }
             return true;
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
                return false;
         }
     }


     public Boolean GuardarDB(tb_Tocken_Info InfoTocken, ref string MensajeErrorOut)
     {
         try
         {
             using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
             {
                 var Address = new tb_Tocken();

                 Address.IdTocken = InfoTocken.IdTocken.Trim();
                 Address.nom_tocken = InfoTocken.nom_tocken == null ? "" : InfoTocken.nom_tocken;
                 Address.Password = InfoTocken.Password == null ? "" : InfoTocken.Password;
                 Address.Serie = InfoTocken.Serie == null ? "" : InfoTocken.Serie;
                 Address.Modelo = InfoTocken.Modelo == null ? "" : InfoTocken.Modelo;
                 Address.IdTipo = InfoTocken.IdTipo == null ? "" : InfoTocken.IdTipo;
                 Address.Estado = InfoTocken.Estado == null ? "" : InfoTocken.Estado;

                 oEnti.tb_Tocken.Add(Address);
                 oEnti.SaveChanges();

             }
             return true;
         }
         catch (Exception ex)
         {
             //string MensajeErrorOut = "";
             string arreglo = ToString();
             tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
             tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                 "", "", "", "", DateTime.Now);
             oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
             MensajeErrorOut = ex.InnerException + " " + ex.Message;

             return false;
         }
     }

     public Boolean ModificarDB(tb_Tocken_Info info, ref string MensajeErrorOut)
     {
         try
         {
             using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
             {
                 var contact = oEnti.tb_Tocken.First(var => var.IdTocken == info.IdTockenAUX);

                 contact.nom_tocken = info.nom_tocken;
                 contact.Password = info.Password;
                 contact.Serie = info.Serie;
                 contact.Modelo = info.Modelo;
                 contact.IdTipo = info.IdTipo;
                 contact.Estado = info.Estado;
                 
                 oEnti.SaveChanges();
             }
             return true;
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
             return false;
         }
     }

     public Boolean AnularDB(tb_Tocken_Info info, ref string MensajeErrorOut)
     {
         try
         {
             using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
             {
                 var contact = oEnti.tb_Tocken.First(var => var.IdTocken == info.IdTockenAUX);
               
                 contact.Estado ="I";

                 oEnti.SaveChanges();
             }
             return true;
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
             return false;
         }
     }

     public List<tb_Tocken_Info> ConsulTocken(ref string MensajeErrorOut)
     {
         List<tb_Tocken_Info> lista = new List<tb_Tocken_Info>();
         try
         {
             EntitiesFactElectronica oEnti = new EntitiesFactElectronica();
             var Query = from q in oEnti.tb_Tocken
                         select q;
             foreach (var item in Query)
             {
                 tb_Tocken_Info Obj = new tb_Tocken_Info();

                 Obj.IdTocken = item.IdTocken;
                 Obj.nom_tocken = item.nom_tocken;
                 Obj.Password = item.Password;
                 Obj.Serie = item.Serie;
                 Obj.Modelo = item.Modelo;
                 Obj.IdTipo = item.IdTipo;
                 Obj.Estado = item.Estado;

                 Obj.IdTockenAUX = item.IdTocken;
                
                 lista.Add(Obj);
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
             return new List<tb_Tocken_Info>();
         }
     }

     public Boolean EliminarDB()
     {
         try
         {
             using (EntitiesFactElectronica OEnti = new EntitiesFactElectronica())
             {
                 string queryDet = "delete from tb_Tocken";
                 OEnti.Database.ExecuteSqlCommand(queryDet);
             }
                                 
             return true;
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
             
             return false;
         }         
     }

    }
}
