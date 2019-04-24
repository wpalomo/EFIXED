using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;


namespace FirmElect.Bus
{
  public   class tb_Clave_Conting_Bus
    {

      tb_Clave_Conting_Data Odata;

      public tb_Clave_Conting_Bus()
      {
          try
          {
              Odata = new tb_Clave_Conting_Data();
          }
          catch (Exception ex)
          {
              
              
          }
          
      }

      public decimal getId(ref string MensajeErrorOut)
      {
          try
          {
              return Odata.getId(ref MensajeErrorOut);
          }
          catch (Exception ex)
          {

              return 0;
          }

      }

      public  tb_Clave_Conting_Info consultar_ult_clave_no_usada(int IdEmpresa,int idAmbiente, ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_ult_clave_no_usada(IdEmpresa, idAmbiente,ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new tb_Clave_Conting_Info();
          }

      }
      
      public Boolean Guardar_Clave_Contigencia(List<tb_Clave_Conting_Info> Claves)
      {
          try
          {

              return Odata.Guardar_Clave_Contigencia(Claves);
          }
          catch (Exception)
          {

              return false;
          }
      }

      public List<tb_Clave_Conting_Info> consultar(ref string mensajeErrorOut)
      {
          try
          {
              return Odata.Consultar(ref mensajeErrorOut);
          }
          catch (Exception ex)
          {
              return new List<tb_Clave_Conting_Info>();

          }
      }

      

    }
}
