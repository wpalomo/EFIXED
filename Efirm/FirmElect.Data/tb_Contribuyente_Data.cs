using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
    public class tb_Contribuyente_Data : Itb_Contribuyente_Data
    {

        public bool GuardarDB(Info.tb_Contribuyente_Info InfoContribuyente, ref string MensajeErrorOut)
        {
            try
            {

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {

                    var Address = new tb_Contribuyente();
                    

                    var Q = from per in Context.tb_Contribuyente
                            where  per.IdEmpresa == InfoContribuyente.IdEmpresa
                               &&  per.cedulaRuc_contri == InfoContribuyente.cedulaRuc_contri
                           select per;
                    if (Q.ToList().Count == 0)// no esta en la base
                    {
                        Address.IdEmpresa = InfoContribuyente.IdEmpresa;
                        Address.IdContribuyente = InfoContribuyente.IdContribuyente = getIdContribuyente( ref MensajeErrorOut);
                        Address.cedulaRuc_contri = InfoContribuyente.cedulaRuc_contri.Trim();
                        Address.Nom_Contribuyente = InfoContribuyente.Nom_Contribuyente.Trim();
                        Address.Mail = InfoContribuyente.Mail;
                        Address.EsCliente = InfoContribuyente.EsCliente;
                        Address.EsProveedor = InfoContribuyente.EsProveedor;
                        Address.Password = InfoContribuyente.Password;
                        Address.Estado = InfoContribuyente.Estado;
                        Address.Fecha_transaccion = InfoContribuyente.Fecha_transaccion;
                        Address.Fecha_Registro_web = InfoContribuyente.Fecha_Registro_web;
                        Address.Fecha_Actualizacion_datos = InfoContribuyente.Fecha_Actualizacion_datos;
                        Address.Registrado_web = InfoContribuyente.Registrado_web;
                        Address.Observacion = InfoContribuyente.Observacion;
                        Address.Mail_secundario = InfoContribuyente.Mail_secundario;

                        Address.TipoContacto = InfoContribuyente.TipoContacto.ToString();
                        Address.Foto = InfoContribuyente.Foto;
                        Address.Direccion = InfoContribuyente.Direccion;
                        Address.Telefono = InfoContribuyente.Telefono;

                        Context.tb_Contribuyente.Add(Address);
                        Context.SaveChanges();
                    }
                    else
                    {

                        try
                        {
                            var contact = Context.tb_Contribuyente.First(var => var.cedulaRuc_contri == InfoContribuyente.cedulaRuc_contri && (var.Mail == "" || var.Mail==null || var.Mail!=InfoContribuyente.Mail));
                            contact.Mail = InfoContribuyente.Mail;
                            contact.Mail_secundario = InfoContribuyente.Mail_secundario;
                            contact.Mail_secundario2 = InfoContribuyente.Mail_secundario2;
                            Context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            
                        }
                        




                        //Context.SaveChanges();



                        MensajeErrorOut = "Contribuyente ya esta en la base";
                        return false;
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

        public Boolean ModificarDB_x_WEB(int IdEmpresa, string cedulaRuc, string Password
           , string mail, ref string mensajeErrorOutm)
        {
            try
            {
                using (EntitiesFactElectronica DbFactElec = new EntitiesFactElectronica())
                {

                    var resultado = DbFactElec.tb_Contribuyente.First(v => v.IdEmpresa == IdEmpresa
                        && v.cedulaRuc_contri == cedulaRuc);


                    resultado.Mail = mail;
                    resultado.Password = Password;
                    resultado.Fecha_Actualizacion_datos = DateTime.Now;
                    resultado.Fecha_Registro_web = DateTime.Now;
                    resultado.Registrado_web = true;

                    DbFactElec.SaveChanges();

                }


                return true;
            }
            catch (Exception ex)
            {
                
                string mensaje = "";
                mensaje = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                


                return false;
            }
        }

        
        public decimal getIdContribuyente(ref string MensajeErrorOut)
        {
            try
            {
                decimal IdcbteCble = 0;
                EntitiesFactElectronica OECbtecble = new EntitiesFactElectronica();


                
                    OECbtecble = new EntitiesFactElectronica();

                    var selectCbtecble1 = (from CbtCble in OECbtecble.tb_Contribuyente
                                          select CbtCble.IdContribuyente).Count();

                    if (Convert.ToDecimal(selectCbtecble1) == 0)
                    {
                        IdcbteCble = 1;
                    }
                    else
                    {
                        var selectCbtecble = (from CbtCble in OECbtecble.tb_Contribuyente
                                              select CbtCble.IdContribuyente).Max();


                        IdcbteCble = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                       
                    }


                    
                
                return IdcbteCble;
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
                return -1;
            }
        }

        public List<tb_Contribuyente_Info> GetContribuyente(int IdEmpresa, string cedulaRuc, string password, ref string MensajeErrorOut)
        {
            try
            {
                List<tb_Contribuyente_Info> lista = new List<tb_Contribuyente_Info>();
                EntitiesFactElectronica Context = new EntitiesFactElectronica();
                var selectContri = from C in Context.tb_Contribuyente
                                   where C.IdEmpresa == IdEmpresa && 
                                   C.cedulaRuc_contri == cedulaRuc && C.Password == password && C.Registrado_web == true
                                   select C;

                foreach (var item in selectContri)
                {
                    tb_Contribuyente_Info Cbt = new tb_Contribuyente_Info();

                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdContribuyente = item.IdContribuyente;
                    Cbt.cedulaRuc_contri = item.cedulaRuc_contri.Trim();
                    Cbt.Nom_Contribuyente = item.Nom_Contribuyente.Trim();
                   

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

                return new List<tb_Contribuyente_Info>();
            }
        }

        public tb_Contribuyente_Info GetContribuyente_Info(int IdEmpresa, string cedulaRuc, ref string MensajeErrorOut)
        {
            try
            {
                tb_Contribuyente_Info InfoContri = new tb_Contribuyente_Info();

                EntitiesFactElectronica Context = new EntitiesFactElectronica();
                var selectContri = from C in Context.tb_Contribuyente
                                   where C.IdEmpresa == IdEmpresa && 
                                   C.cedulaRuc_contri == cedulaRuc
                                   select C;

                foreach (var item in selectContri)
                {

                    InfoContri.Nom_Contribuyente = item.Nom_Contribuyente;
                    InfoContri.cedulaRuc_contri = item.cedulaRuc_contri;
                    InfoContri.Mail = item.Mail;
                    InfoContri.Mail_secundario = item.Mail_secundario;
                    InfoContri.Mail_secundario2 = item.Mail_secundario2;
                    InfoContri.IdContribuyente = item.IdContribuyente;
                    InfoContri.IdEmpresa = item.IdEmpresa;

                    InfoContri.Mail = item.Mail;
                    InfoContri.Mail_secundario = item.Mail_secundario;
                    InfoContri.Mail_secundario2 = item.Mail_secundario2;
                    InfoContri.EsCliente = item.EsCliente;
                    InfoContri.EsProveedor = item.EsProveedor;
                    InfoContri.Estado = item.Estado;
                    InfoContri.Observacion = item.Observacion;
                    InfoContri.RazonSocial = item.Nom_Contribuyente;
                    InfoContri.Mail_de_Registro_x_WEB = item.Mail_de_Registro_x_WEB;

                }
                return InfoContri;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return new tb_Contribuyente_Info();
            }
        }

        public Boolean Modificar_GetContribuyente_Info(int IdEmpresa, string cedulaRuc, string mail, string password, ref string MensajeErrorOut)
        {
            try
            {
                if (password != null || password != "")
                {
                    using (EntitiesFactElectronica context = new EntitiesFactElectronica())
                    {
                        tb_Contribuyente contact = context.tb_Contribuyente.First(var => var.IdEmpresa == IdEmpresa && var.cedulaRuc_contri == cedulaRuc);
                        if(!string.IsNullOrEmpty(password))
                            contact.Password = password;
                        contact.Mail_de_Registro_x_WEB = mail;

                        context.SaveChanges();
                    }

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

        public List<tb_Contribuyente_Info> GetListContribuyente(ref string MensajeErrorOut)
        {

            try
            {
                List<tb_Contribuyente_Info> lista_contribuyente = new List<tb_Contribuyente_Info>();

                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    
                    var q = from C in conexion.tb_Contribuyente
                            join E in conexion.tb_Empresa on new { C.IdEmpresa } equals new { E.IdEmpresa }
                            select new
                            {
                                C.IdContribuyente,
                                C.IdEmpresa,
                                C.cedulaRuc_contri,
                                C.Nom_Contribuyente,
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
                                ,
                                E.RazonSocial
                            };



                    foreach (var item in q)
                    {
                        tb_Contribuyente_Info infoContribuyente = new tb_Contribuyente_Info();

                        infoContribuyente.IdContribuyente = Convert.ToInt32(item.IdContribuyente);
                        infoContribuyente.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        infoContribuyente.cedulaRuc_contri = item.cedulaRuc_contri;
                        infoContribuyente.Nom_Contribuyente = item.Nom_Contribuyente;
                        infoContribuyente.Nom_Contribuyente2 = item.Nom_Contribuyente + " [" + item.RazonSocial + "]";

                        infoContribuyente.Mail = item.Mail;
                        infoContribuyente.Mail_secundario = item.Mail_secundario;
                        infoContribuyente.EsCliente = item.EsCliente;
                        infoContribuyente.EsProveedor = item.EsProveedor;
                        infoContribuyente.Password = item.Password;
                        infoContribuyente.Estado = item.Estado;
                        infoContribuyente.Fecha_transaccion = item.Fecha_transaccion;
                        infoContribuyente.Fecha_Registro_web = item.Fecha_Registro_web;
                        infoContribuyente.Fecha_Actualizacion_datos = item.Fecha_Actualizacion_datos;
                        infoContribuyente.Registrado_web = item.Registrado_web;
                        infoContribuyente.Observacion = item.Observacion;
                        infoContribuyente.RazonSocial = item.RazonSocial;
                        infoContribuyente.Nom_Emisor = item.RazonSocial;

                        eTipo_Contacto TipoContacto;
                        if (item.TipoContacto == null)
                        {
                            TipoContacto = eTipo_Contacto.Sr;
                        }
                        else
                        {
                            TipoContacto = (eTipo_Contacto)Enum.Parse(typeof(eTipo_Contacto), item.TipoContacto);
                        }


                        infoContribuyente.TipoContacto = TipoContacto;
                        infoContribuyente.Foto = item.Foto;
                        infoContribuyente.Direccion = item.Direccion;
                        infoContribuyente.Telefono = item.Telefono;
                        lista_contribuyente.Add(infoContribuyente);

                    }



                }

                return lista_contribuyente;


            }
            catch (Exception ex)
            {


                string mensaje = "";
                mensaje = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

                return new List<tb_Contribuyente_Info>();
            }
        }

        public bool ModificarDB(tb_Contribuyente_Info infoContribuyente, ref string mensajeErrorOut)
        {


            try
            {


                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    var Reg_a_Modificar = oEnti.tb_Contribuyente.First(var => var.IdContribuyente == infoContribuyente.IdContribuyente);                
                        Reg_a_Modificar.IdContribuyente = infoContribuyente.IdContribuyente;
                        Reg_a_Modificar.IdEmpresa = infoContribuyente.IdEmpresa;
                        Reg_a_Modificar.cedulaRuc_contri = infoContribuyente.cedulaRuc_contri;
                        Reg_a_Modificar.Nom_Contribuyente = infoContribuyente.Nom_Contribuyente;
                        Reg_a_Modificar.Mail = infoContribuyente.Mail;
                        Reg_a_Modificar.Mail_secundario = infoContribuyente.Mail_secundario;
                        Reg_a_Modificar.EsCliente = infoContribuyente.EsCliente;
                        Reg_a_Modificar.EsProveedor = infoContribuyente.EsProveedor;
                        Reg_a_Modificar.Password = infoContribuyente.Password;
                        Reg_a_Modificar.Estado = infoContribuyente.Estado;
                        Reg_a_Modificar.Fecha_transaccion = DateTime.Now;
                        //Reg_a_Modificar.Fecha_Registro_web = Convert.ToDateTime(infoContribuyente.Fecha_Registro_web);
                        Reg_a_Modificar.Fecha_Actualizacion_datos = infoContribuyente.Fecha_Actualizacion_datos;
                        //Reg_a_Modificar.Registrado_web = infoContribuyente.Registrado_web;
                        Reg_a_Modificar.Observacion = infoContribuyente.Observacion;
                        
                        eTipo_Contacto TipoContacto;
                        if (infoContribuyente.TipoContacto == null)
                        {
                            TipoContacto = eTipo_Contacto.Sr;
                        }
                        else
                        {
                            TipoContacto = infoContribuyente.TipoContacto;
                        }

                        Reg_a_Modificar.TipoContacto = TipoContacto.ToString();
                        Reg_a_Modificar.Direccion = infoContribuyente.Direccion;
                        Reg_a_Modificar.Telefono = infoContribuyente.Telefono;
                        Reg_a_Modificar.Foto = infoContribuyente.Foto;

                    oEnti.SaveChanges();
                }
                return true;

                               

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public sp_Registro_Contribuyente_Info Registrar_Contribuyente(int IdEmpresa, String CedulaRUc, String TipoComprobantes, String NumComprobante, String Correo, String Contrasenia, String Link, ref String mensajeErrorOut)
        {
            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    String Sql = string.Format("exec sp_Registro_Contribuyente {0},'{1}','{2}','{3}','{4}','{5}','{6}'",IdEmpresa,CedulaRUc,TipoComprobantes,NumComprobante,Correo,Contrasenia,Link);
                    sp_Registro_Contribuyente_Info Respuesta = conexion.Database.SqlQuery<sp_Registro_Contribuyente_Info>(Sql).First();
                    return Respuesta;
                }
            }
            catch (Exception ex)
            {
                mensajeErrorOut = ex.Message;
                return new sp_Registro_Contribuyente_Info();
            }
        }

        public sp_ValidarRegistros_Info sp_ValidarRegistros(int IdEmpresa, String HashText, ref String mensajeErrorOut)
        {
            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    String Sql = string.Format("exec sp_ValidarRegistros {0},'{1}'", IdEmpresa, HashText);
                    sp_ValidarRegistros_Info Respuesta = conexion.Database.SqlQuery<sp_ValidarRegistros_Info>(Sql).First();


                    return Respuesta;
                }
            }
            catch (Exception ex )
            {
                mensajeErrorOut = ex.Message;
                return new sp_ValidarRegistros_Info();
            }
        
        }

        public sp_RecuperaciondeContraseña_Info sp_RecuperaciondeContraseña(int IdEmpresa, string CedulaRuc, ref String mensajeErrorOut) 
        {
            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    String Sql = string.Format("exec sp_RecuperaciondeContraseña {0},'{1}'", IdEmpresa, CedulaRuc);
                    sp_RecuperaciondeContraseña_Info Respuesta = conexion.Database.SqlQuery<sp_RecuperaciondeContraseña_Info>(Sql).First();
                    return Respuesta;
                }
            }
            catch (Exception ex)
            {
                mensajeErrorOut = ex.Message;
                return new sp_RecuperaciondeContraseña_Info();
            }
        
        }

        public tb_Contribuyente_Info sp_VerificarRecuperaciondeContrasenia(int IdEmpresa, string @HashText, ref String mensajeErrorOut) 
        {
            try
            {
                tb_Contribuyente_Info Respuesta = new tb_Contribuyente_Info();

                using (EntitiesFactElectronica DB_Fact = new EntitiesFactElectronica())
                {

                    foreach (var item in DB_Fact.sp_VerificarRecuperaciondeContrasenia(IdEmpresa, @HashText))
                    {
                        Respuesta.IdEmpresa = item.IdEmpresa;
                        Respuesta.cedulaRuc_contri = item.cedulaRuc_contri;
                        Respuesta.Direccion = item.Direccion;
                        Respuesta.EsCliente = item.EsCliente;
                        Respuesta.EsProveedor = item.EsProveedor;
                        Respuesta.Estado = item.Estado;
                        Respuesta.Fecha_Actualizacion_datos = item.Fecha_Actualizacion_datos;
                        Respuesta.Fecha_Registro_web = item.Fecha_Registro_web;
                        Respuesta.Fecha_transaccion = item.Fecha_transaccion;
                        Respuesta.IdContribuyente = item.IdContribuyente;
                        Respuesta.Mail = item.Mail;
                        Respuesta.Mail_de_Registro_x_WEB = item.Mail_de_Registro_x_WEB;
                        Respuesta.Mail_secundario = item.Mail_secundario;
                        Respuesta.Nom_Contribuyente = item.Nom_Contribuyente;
                        Respuesta.Password = item.Password;
                        Respuesta.Registrado_web = item.Registrado_web;
                        Respuesta.Telefono = item.Telefono;
                        //Respuesta.TipoContacto = item.TipoContacto;
                        Respuesta.TipoContacto_ = item.TipoContacto_;
                    } 


                    //String Sql = string.Format("exec sp_VerificarRecuperaciondeContrasenia {0},'{1}'", IdEmpresa, @HashText);
                    //tb_Contribuyente_Info Respuesta = conexion.Database.SqlQuery<tb_Contribuyente_Info>(Sql).First();
                                       


                    return Respuesta;
                }
            }
            catch (Exception ex)
            {
                mensajeErrorOut = ex.Message;
                
                tb_Contribuyente_Info obj= new tb_Contribuyente_Info();
                obj.Nom_Contribuyente = mensajeErrorOut;

                return obj;
            }
        }





        
    }
}
