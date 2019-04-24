using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailEfirm.Info;
namespace MailEfirm.Data
{
  public  class Empresa_Data
    {
      public List<Empresa_Info> listarEmpresas()
      {
          List<Empresa_Info> Lista_empresa = new List<Empresa_Info>();
          try
          {
              using (Entities_Mail_Efirm conexion = new Entities_Mail_Efirm())
              {
                  var q = from C in conexion.tb_Empresa select C;
                  foreach (var item in q)
                  {
                      Empresa_Info empr = new Empresa_Info();
                      empr.empresa = item.RazonSocial;
                      Lista_empresa.Add(empr);
                  }

              }
              return Lista_empresa;
          }
          catch (Exception ex)
          {
              return new List<Empresa_Info>();
          }

      }
    }
}
