using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirmElect.Info;


namespace FirmElect.Data
{
  public  class tb_Cliente_Data
    {
      public List<tb_Cliente_Info> Consulta_Clientes(ref string mensajeErrorOut)
       {
           try
           {
               List<tb_Cliente_Info> Lst = new List<tb_Cliente_Info>();
               //EntitiesFactElectronica oEnti = new EntitiesFactElectronica();
               // var Query = from q in oEnti.tb_Cliente               select q;
               //foreach (var item in Query)
               //{
               //    tb_Cliente_Info Obj = new tb_Cliente_Info();
               //    Obj.IdEmpresa = item.IdEmpresa;
               //    Obj.IdCliente = item.IdCliente;
               //    Obj.Razon_Social = item.Razon_Social;
               //    Obj.Nombre = item.Nombre;
               //    Obj.Apellido = item.Apellido;
               //    Obj.Cedula_RUC = item.Cedula_RUC;
               //    Obj.Direccion = item.Direccion;
               //    Obj.Telefono = item.Telefono;
               //    Obj.Correo = item.Correo;
               //    Obj.EsEmpresa = item.EsEmpresa;
               //    Obj.Estado = item.Estado;  

               //    Lst.Add(Obj);
               //}

               return Lst;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
               mensajeErrorOut = ex.InnerException + " " + ex.Message;


               return new List<tb_Cliente_Info>();
           }              
       }

      public Boolean Modificar_Cliente(List<tb_Cliente_Info> lista, ref string mensajeErrorOut)
      {
          try
          {
              using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
              {

                  //foreach (var item in lista)
                  //{
                  //    var contact = oEnti.tb_Cliente.First(obj => obj.IdEmpresa == item.IdEmpresa &&
                  //    obj.IdCliente == item.IdCliente);

                  //    contact.Razon_Social = item.Razon_Social;
                  //    contact.Nombre = item.Nombre;
                  //    contact.Apellido = item.Apellido;
                  //    contact.Cedula_RUC = item.Cedula_RUC;
                  //    contact.Direccion = item.Direccion;
                  //    contact.Telefono = item.Telefono;
                  //    contact.Correo = item.Correo;
                  //    contact.EsEmpresa = item.EsEmpresa;
                  //    contact.Estado = item.Estado;

                  //    oEnti.SaveChanges();
                  //}

                  mensajeErrorOut = "Clientes Actualizados Exitosamente";
              }

              return true;
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);

              return false;
          }
      }

       public tb_Cliente_Data(){}
    }
}
