using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailEfirm.Info;
namespace MailEfirm.Data
{
  public  class Cotribuyente_Data
    {
      public List<Contribuyente_Info> CargarContribuyente()
      {

        try
        {
            List<Contribuyente_Info> lista_contribuyente = new List<Contribuyente_Info>();

            using (Entities_Mail_Efirm conexion = new Entities_Mail_Efirm())
            {

                var q = from C in conexion.tb_Contribuyente
                        join E in conexion.tb_Empresa on new { C.IdEmpresa } equals new { E.IdEmpresa }
                        select new
                        {
                            C.IdContribuyente,C.IdEmpresa,C.cedulaRuc_contri,C.Nom_Contribuyente                        ,
                            C.Mail
                         ,
                            C.Mail_secundario
                         ,
                            C.EsCliente
                         ,
                            C.EsProveedor
                         ,
                            C.Password
                         ,
                            C.Estado
                         ,
                            C.Fecha_transaccion
                         ,
                            C.Fecha_Registro_web
                         ,
                            C.Fecha_Actualizacion_datos
                         ,
                            C.Registrado_web
                         ,
                            C.Observacion
                         ,
                            C.TipoContacto
                         ,
                            C.Foto
                         ,
                            C.Direccion
                         ,
                            C.Telefono
                            ,E.RazonSocial
                        };



                foreach (var item in q)
                {
                    Contribuyente_Info infoContribuyente = new Contribuyente_Info();

                    infoContribuyente.IdContribuyente =Convert.ToInt32( item.IdContribuyente);
                    infoContribuyente.IdEmpresa =Convert.ToInt32(item.IdEmpresa);
                    infoContribuyente.cedulaRuc_contri = item.cedulaRuc_contri;
                    infoContribuyente.Nom_Contribuyente = item.Nom_Contribuyente;
                    infoContribuyente.Mail = item.Mail;
                    infoContribuyente.Mail_secundario = item.Mail_secundario;
                    infoContribuyente.EsCliente = item.EsCliente;
                    infoContribuyente.EsProveedor = item.EsProveedor;
                    infoContribuyente.Password = item.Password;
                    infoContribuyente.Estado = item.Estado;
                    infoContribuyente.Fecha_transaccion =item.Fecha_transaccion;
                    infoContribuyente.Fecha_Registro_web = item.Fecha_Registro_web;
                    infoContribuyente.Fecha_Actualizacion_datos=item.Fecha_Actualizacion_datos;
                    infoContribuyente.Registrado_web = item.Registrado_web;
                    infoContribuyente.Observacion = item.Observacion;
                    infoContribuyente.RazonSocial = item.RazonSocial;

                    eTipo_Contacto TipoContacto ;
                    if (item.TipoContacto == null)
                    {
                        TipoContacto = eTipo_Contacto.Sr;
                    }
                    else
                    {
                        TipoContacto = (eTipo_Contacto)Enum.Parse(typeof(eTipo_Contacto), item.TipoContacto);                        
                    }


                    infoContribuyente.TipoContacto = TipoContacto;
                    //infoContribuyente.Foto=
                    infoContribuyente.Direccion = item.Direccion;
                    infoContribuyente.Telefono = item.Telefono;

                    lista_contribuyente.Add(infoContribuyente);

                }



            }

            return lista_contribuyente;


        }
        catch (Exception ex)
        {




            return new List<Contribuyente_Info>();
        }
      }

      public bool ModificarDB(Contribuyente_Info contribuyente,ref string mensajeErrorOut)
      {

          try
          {

              using (Entities_Mail_Efirm conexion = new Entities_Mail_Efirm())
              {

                  var q = from C in conexion.tb_Contribuyente
                         // where C.TipoContacto == tipoContaccto.ToString()
                          select C;


                  foreach (var item in q)
                  {
                      Contribuyente_Info infoContribuyente = new Contribuyente_Info();

                      item.IdContribuyente = Convert.ToInt32(infoContribuyente.IdContribuyente);
                      item.IdEmpresa=  infoContribuyente.IdEmpresa;
                      item.cedulaRuc_contri=infoContribuyente.cedulaRuc_contri ;
                      item.Nom_Contribuyente=infoContribuyente.Nom_Contribuyente;
                      item.Mail=infoContribuyente.Mail ;
                      item.Mail_secundario=infoContribuyente.Mail_secundario;
                      item.EsCliente=infoContribuyente.EsCliente ;
                      item.EsProveedor=infoContribuyente.EsProveedor;
                      item.Password=infoContribuyente.Password;
                      item.Estado= infoContribuyente.Estado;
                      item.Fecha_transaccion=  Convert.ToDateTime(infoContribuyente.Fecha_transaccion);
                      item.Fecha_Registro_web= Convert.ToDateTime(infoContribuyente.Fecha_Registro_web) ;
                      item.Fecha_Actualizacion_datos= infoContribuyente.Fecha_Actualizacion_datos;
                      item.Registrado_web=infoContribuyente.Registrado_web;
                       item.Observacion=infoContribuyente.Observacion;
                       //item.TipoContacto= = (eTipo_Contacto)Enum.Parse(typeof(eTipo_Contacto), contribuyente.EipoContacto);
                       item.Direccion=infoContribuyente.Direccion;
                       item.Telefono=infoContribuyente.Telefono;
                      
                  }



              }
            
              return true;
          }
          catch (Exception ex)
          {
              return false;
          }

      }
    
    }
}
