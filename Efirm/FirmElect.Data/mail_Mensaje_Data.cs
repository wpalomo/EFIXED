using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{

    public class mail_Mensaje_Data
    {
        string mensajeError = ""; 
        public Boolean Verifica_codMensajeId(string codMensajeId)
        {
              
            try
            {

                Boolean validar = false;
                
                using (EntitiesFactElectronica oEnty= new EntitiesFactElectronica())
               {
               
                      var verifica= from q in oEnty.mail_Mensaje
                          where q.codMensajeId==codMensajeId
                           select q;

                    if (verifica.Count() >= 1)
                    {
                      validar = true;
                    }
                   else
                    {
                       validar = false;              
                    }              
               }
                return validar;
            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);


                return false;
            }
        
        
        }
        
        public List<mail_Mensaje_Info> consultar_Mail()
        {
            try
            {
                  List<mail_Mensaje_Info> lista = new List<mail_Mensaje_Info>();
                  using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                  {
                     

                     var q = (from C in conexion.mail_Mensaje                           
                             select C).ToList();


                      IQueryable<mail_Mensaje_Info>  lista1;
                     
 

                      

                      foreach (var item in q)
                      {
                          mail_Mensaje_Info infoC = new mail_Mensaje_Info();

                          infoC.IdMensaje =item.IdMensaje;
                          infoC.Fecha = item.Fecha;
                          infoC.Para = item.Para;
                          infoC.Para_CCO = item.Para_CCO;
                          infoC.Asunto = item.Asunto;
                          infoC.Asunto_texto_mostrado = item.Asunto_texto_mostrado;
                          infoC.Tiene_Adjunto = item.Tiene_Adjunto;
                          infoC.Prioridad = item.Prioridad;
                          infoC.Leido = item.Leido;
                          infoC.Respondido = item.Respondido;
                          infoC.IdTipo_Mensaje = (eTipoMail)Enum.Parse(typeof(eTipoMail), item.IdTipo_Mensaje);
                          infoC.Texto_mensaje = item.Texto_mensaje;
                          infoC.IdContribuyente = Convert.ToDecimal(item.IdContribuyente);
                          infoC.No_Leido = item.No_Leido;
                          infoC.Eliminado = item.Eliminado;
                          infoC.mail_remitente = item.mail_remitente;
                          infoC.Para_CC = item.Para_CC;
                          infoC.codMensajeId = item.codMensajeId;
                          infoC.IdCuenta = item.IdCuenta;


                          lista.Add(infoC);
                      
                      }                                                  
                  }

                  return lista;
            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);           
               return new List<mail_Mensaje_Info>();
            }               
        }

        public List<string> consultar_CodMail_Existentes_x_Buzon_Entrada()
        {
            try
            {
                List<string> lista = new List<string>();
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    var q = from C in conexion.mail_Mensaje
                            where C.IdTipo_Mensaje == "Buzon_Ent"
                            && C.codMensajeId.Length>0
                            select C.codMensajeId;

                    foreach (var item in q)
                    {

                        lista.Add(item);

                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
                return new List<string>();
            }
        }
             
        public List<mail_Mensaje_Info> consultar(eTipoMail TipoCorreo, string direccionCorreo,  int NumPag,int Registro_x_pagina,string CadenaBusqueda, ref string mensajeErrorOut)
        {
            List<mail_Mensaje_Info> lista = new List<mail_Mensaje_Info>();
            decimal Ultimoindice = 0;

            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {

                    var q = from C in conexion.sp_consulta_x_Mensaje_x_Pagina(NumPag, Registro_x_pagina, TipoCorreo.ToString(), direccionCorreo, CadenaBusqueda)
                            orderby C.Fecha descending
                            select new
                            {
                                C.IdEmpresa,
                                C.IdMensaje,
                                C.Fecha,
                                C.Para,
                                C.Para_CCO,
                                C.Asunto,
                                C.Mail,
                                C.Tiene_Adjunto,
                                C.Prioridad,
                                C.Leido
                                ,
                                C.Respondido,
                                C.Eliminado,
                                C.Para_CC,
                                C.codMensajeId,
                                C.IdTipo_Mensaje,
                                C.IdCuenta,
                                C.IdContribuyente,
                                C.Mail_secundario,
                                C.Password,
                                C.Nom_Contribuyente,
                                 C.Telefono,
                                C.cedulaRuc_contri,
                                C.RazonSocial_Emisor,
                                C.RUC_Emisor
                            };



                    foreach (var item in q)
                    {
                        mail_Mensaje_Info infoC = new mail_Mensaje_Info();
                        tb_Contribuyente_Info InfoContri = new tb_Contribuyente_Info();
                        Ultimoindice++;

                        infoC.IdMensaje = item.IdMensaje;
                        infoC.Fecha = item.Fecha;
                        infoC.sFecha = item.Fecha.ToString();
                        infoC.Para = item.Para;
                        infoC.Para_CCO = item.Para_CCO;
                        infoC.Asunto = item.Asunto;
                        infoC.mail_remitente = item.Mail;
                        infoC.Tiene_Adjunto = item.Tiene_Adjunto;
                        infoC.Prioridad = item.Prioridad;
                        infoC.Leido = item.Leido;
                        infoC.Respondido = item.Respondido;
                        infoC.IdTipo_Mensaje = (eTipoMail)Enum.Parse(typeof(eTipoMail), item.IdTipo_Mensaje);
                        infoC.Eliminado = item.Eliminado;
                        infoC.Para_CC = item.Para_CC;
                        infoC.Mostrar_col_Eliminar = true;
                        infoC.codMensajeId = item.codMensajeId;
                        infoC.IdCuenta = item.IdCuenta;
                        infoC.MosTrar_icono_Ride = false;
                        infoC.MosTrar_icono_xml = false;
                        if (item.IdContribuyente != null)
                        {
                            InfoContri.IdContribuyente = (item.IdContribuyente == null) ? 0 : Convert.ToDecimal(item.IdContribuyente);
                            InfoContri.Mail = item.Mail;
                            InfoContri.Mail_secundario = item.Mail_secundario;
                            InfoContri.Password = item.Password;
                            InfoContri.Nom_Contribuyente = item.Nom_Contribuyente;
                            InfoContri.IdEmpresa = (item.IdEmpresa == null) ? 0 : Convert.ToInt32(item.IdEmpresa);
            
                            InfoContri.Telefono = item.Telefono;
                            InfoContri.cedulaRuc_contri = item.cedulaRuc_contri;
                            infoC.Fecha = item.Fecha;
                            infoC.RUC_Emisor = item.RUC_Emisor;
                            infoC.RazonSocial_Emisor = item.RazonSocial_Emisor;
                        }
                        infoC.InfoContribuyente = InfoContri;

                        lista.Add(infoC);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
                Ultimoindice++;
                return lista;
            }

        }

        public int ObtenerNumPagina(int Registro_x_Pag, eTipoMail IdTipo_Mensaje, string mail_remitente, string CadenaBusqueda, ref string MensajeErrorOut)
        {
            try
            {
                int NumPag = 0; 
                decimal t = 0;

                EntitiesFactElectronica contex = new EntitiesFactElectronica();
                var q = (from C in contex.vw_Mensaje_x_Contribuyente
                         where C.IdTipo_Mensaje == IdTipo_Mensaje.ToString()
                             && C.mail_remitente == mail_remitente
                             && (C.Para + C.Nom_Contribuyente + C.cedulaRuc_contri + C.Mail + C.RazonSocial_Emisor + C.Asunto + C.Asunto_texto_mostrado ).Contains(CadenaBusqueda)
                         select C).Count();

                if (q == 0)
                {  NumPag = 1;  }
                else
                {
                    t = q / Registro_x_Pag;
                    if ((t % 10) == 1)
                        NumPag = Convert.ToInt32(t + 1);
                    else
                        NumPag = Convert.ToInt32(t + 1);
                }

                return NumPag;
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

        public List<mail_Mensaje_Info> consultar_mail_sin_correo_destino_x_contribuyente(decimal IdContribuyente, ref string mensajeErrorOut)
        {
            try
            {
                List<mail_Mensaje_Info> lista = new List<mail_Mensaje_Info>();

                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    var q = from C in conexion.vw_Mensaje_x_Contribuyente
                            where C.IdTipo_Mensaje == "Buzon_Sal"
                            && C.Para==""
                            && C.IdContribuyente == IdContribuyente
                            orderby C.Fecha descending
                            select C;
                    foreach (var item in q)
                    {
                        mail_Mensaje_Info infoC = new mail_Mensaje_Info();
                        tb_Contribuyente_Info InfoContri = new tb_Contribuyente_Info();

                        infoC.IdMensaje = item.IdMensaje;
                        infoC.Fecha = item.Fecha;
                        infoC.sFecha = item.Fecha.ToString();
                        infoC.Para = item.Para;
                        infoC.Para_CCO = item.Para_CCO;
                        infoC.Asunto = item.Asunto;
                        infoC.mail_remitente = item.Mail;
                        infoC.Tiene_Adjunto = item.Tiene_Adjunto;
                        infoC.Prioridad = item.Prioridad;
                        infoC.Leido = item.Leido;
                        infoC.Respondido = item.Respondido;
                        infoC.Texto_mensaje = item.Texto_mensaje;
                        infoC.IdTipo_Mensaje = (eTipoMail)Enum.Parse(typeof(eTipoMail), item.IdTipo_Mensaje);
                        infoC.Eliminado = item.Eliminado;
                        infoC.Para_CC = item.Para_CC;
                        infoC.Mostrar_col_Eliminar = true;
                        infoC.IdCuenta = item.IdCuenta;


                        /// lenar este objketo
                        /// 
                        if (item.IdContribuyente != null)
                        {
                            InfoContri.IdContribuyente = (item.IdContribuyente == null) ? 0 : Convert.ToDecimal(item.IdContribuyente);
                            InfoContri.Mail = item.Mail;
                            InfoContri.Mail_secundario = item.Mail_secundario;
                            InfoContri.Password = item.Password;
                            InfoContri.Nom_Contribuyente = item.Nom_Contribuyente;
                            InfoContri.IdEmpresa = (item.IdEmpresa == null) ? 0 : Convert.ToInt32(item.IdEmpresa);
                            infoC.Fecha = item.Fecha;
                            InfoContri.Observacion = item.Observacion;
                            InfoContri.Telefono = item.Telefono;
                            InfoContri.cedulaRuc_contri = item.cedulaRuc_contri;
                            infoC.RUC_Emisor = item.RUC_Emisor;
                            infoC.RazonSocial_Emisor = item.RazonSocial_Emisor;
                        }




                        infoC.InfoContribuyente = InfoContri;

                        lista.Add(infoC);
                    }
                }

                return lista;


            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError); 
                return new List<mail_Mensaje_Info>();
            }

        }

        public bool Actualizar_TipoMensaje(mail_Mensaje_Info correoInfo, ref string mensajeError)
        {

            try
            {

                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    var Reg_a_Modificar = oEnti.mail_Mensaje.First(var => var.IdMensaje == correoInfo.IdMensaje);

                    Reg_a_Modificar.IdTipo_Mensaje = correoInfo.IdTipo_Mensaje.ToString();

                    oEnti.SaveChanges();
                }

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Actualizar_Datos_Cuenta(mail_Mensaje_Info correoInfo, ref string mensajeError)
        {

            try
            {

                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    var Reg_a_Modificar = oEnti.mail_Mensaje.First(var => var.IdMensaje == correoInfo.IdMensaje);

                    Reg_a_Modificar.IdCuenta= correoInfo.IdCuenta;
                    Reg_a_Modificar.mail_remitente = correoInfo.mail_remitente;

                    oEnti.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError); 
                return false;
            }
        }

        public bool Actualizar_correo_destino(mail_Mensaje_Info correoInfo, ref string mensajeError)
        {

            try
            {

                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    var Reg_a_Modificar = oEnti.mail_Mensaje.First(var => var.IdMensaje == correoInfo.IdMensaje);

                    Reg_a_Modificar.Para = correoInfo.Para;

                    oEnti.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError); 
                return false;
            }
        }



        public bool Actualizar_Fecha_recepcion_x_correo(decimal IdMensaje, DateTime Fecha_recepcion, ref string mensajeError)
        {

            try
            {

                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    var Reg_a_Modificar = oEnti.mail_Mensaje.First(var => var.IdMensaje == IdMensaje);

                    Reg_a_Modificar.Fecha = Fecha_recepcion;

                    oEnti.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
                return false;
            }
        }

        public bool Eliminar_Mensaje(mail_Mensaje_Info correoInfo, ref string mensajeError)
        {

            try
            {

                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    var Reg_a_Modificar = oEnti.mail_Mensaje.First(var => var.IdMensaje == correoInfo.IdMensaje);
                    Reg_a_Modificar.IdTipo_Mensaje = "Eliminado";
                    Reg_a_Modificar.Eliminado = true;
                    oEnti.SaveChanges();
                }


                return true;

            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError); 
                return false;
            }
        }

        public bool GrabarMensajeDB(mail_Mensaje_Info infoC, ref string mensajeErrorOut)
        {
            try
            {
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    var Reg_a_Guardar = new mail_Mensaje();

                    Reg_a_Guardar.IdMensaje = infoC.IdMensaje = getId(ref mensajeErrorOut);
                    Reg_a_Guardar.Fecha = infoC.Fecha;
                    Reg_a_Guardar.Para = infoC.Para;
                    Reg_a_Guardar.Para_CC = infoC.Para_CC;
                    Reg_a_Guardar.Asunto = infoC.Asunto;
                    Reg_a_Guardar.Asunto_texto_mostrado = infoC.Asunto;
                    Reg_a_Guardar.Tiene_Adjunto = infoC.Tiene_Adjunto;
                    Reg_a_Guardar.Prioridad = infoC.Prioridad;
                    Reg_a_Guardar.Leido = infoC.Leido;
                    Reg_a_Guardar.Respondido = infoC.Respondido;
                    Reg_a_Guardar.IdTipo_Mensaje = infoC.IdTipo_Mensaje.ToString();
                    Reg_a_Guardar.Texto_mensaje = infoC.Texto_mensaje;

                    if (infoC.IdTipo_Mensaje == eTipoMail.Buzon_Ent)
                    {
                        if (infoC.InfoContribuyente.IdContribuyente == 0)
                        { Reg_a_Guardar.IdContribuyente = null; }
                        else
                        { Reg_a_Guardar.IdContribuyente = infoC.InfoContribuyente.IdContribuyente; }
                    }
                    else
                    { Reg_a_Guardar.IdContribuyente = infoC.InfoContribuyente.IdContribuyente; }

                    



                    Reg_a_Guardar.No_Leido = infoC.No_Leido;
                    Reg_a_Guardar.Eliminado = infoC.Eliminado;
                    
                    Reg_a_Guardar.mail_remitente = infoC.mail_remitente;
                    Reg_a_Guardar.IdCuenta = infoC.IdCuenta;
                    
                    Reg_a_Guardar.Para_CC = (infoC.Para_CC == null) ? "" : infoC.Para_CC;
                    Reg_a_Guardar.Para_CCO = (infoC.Para_CCO == null) ? "" : infoC.Para_CCO;
                    Reg_a_Guardar.codMensajeId =  infoC.codMensajeId;
                    Reg_a_Guardar.Archivo_correo = infoC.Archivo_correo;

                    conexion.mail_Mensaje.Add(Reg_a_Guardar);
                    conexion.SaveChanges();

                }

                return true;


            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError); 
                return false;
            }

        }

        public decimal getId(ref string MensajeErrorOut)
        {
            decimal Id = 0;
            try
            {
                EntitiesFactElectronica contex = new EntitiesFactElectronica();
                var selecte = contex.mail_Mensaje.Count();

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.mail_Mensaje
                                     select q.IdMensaje).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
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


        public byte[]  Get_File_x_Mensaje(decimal IdMensaje, string CodMensajeId, ref string mensajeErrorOut)
        {
            byte[] File_Mail = null;

            try
            {

                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    var q = from C in conexion.mail_Mensaje
                            where C.IdMensaje == IdMensaje
                            && C.codMensajeId == CodMensajeId
                            select C;
                    foreach (var item in q)
                    {
                        File_Mail = item.Archivo_correo;
                    }
                }

                return File_Mail;


            }
            catch (Exception ex)
            {
                mensajeError = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeError);
                return File_Mail;
            }

        }
    }

}
