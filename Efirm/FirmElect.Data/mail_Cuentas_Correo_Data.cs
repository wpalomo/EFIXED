using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
    public class mail_Cuentas_Correo_Data : Imail_Cuentas_Correo_Data
    {

       
        public List<Info.mail_Cuentas_Correo_Info> consultar(ref string mensajeErrorOut)
        {

            try
            {
                List<mail_Cuentas_Correo_Info> lista_cuentas = new List<mail_Cuentas_Correo_Info>();

                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {

                    var q = from C in conexion.mail_Cuentas_Correo                        
                           select C;
                    foreach (var item in q)
                    {
                        mail_Cuentas_Correo_Info infoCuentaMail = new mail_Cuentas_Correo_Info();

                        infoCuentaMail.IdCuenta = item.IdCuenta;
                        infoCuentaMail.Nombre_cuenta = item.Nombre_cuenta;
                        infoCuentaMail.direccion_correo = item.direccion_correo;
                        infoCuentaMail.Usuario = item.Usuario;
                        infoCuentaMail.Password = item.Password;
                        infoCuentaMail.TipoCuenta = item.TipoCuenta;
                        infoCuentaMail.ServidorCorreoEntrante = item.ServidorCorreoEntrante;
                        infoCuentaMail.ServidorCorreoSaliente = item.ServidorCorreoSaliente;
                        infoCuentaMail.port_entrada =Convert.ToInt32( item.port_entrada);
                        infoCuentaMail.Port_salida =Convert.ToInt32( item.Port_salida);
                        infoCuentaMail.cta_predeterminada = item.cta_predeterminada;
                        infoCuentaMail.precisa_conexion_cifrada =Convert.ToBoolean( item.precisa_conexion_cifrada);
                        infoCuentaMail.tipo_Seguridad = item.tipo_Seguridad;
                        infoCuentaMail.enviar_copia_x_cada_mail_enviado = item.enviar_copia_x_cada_mail_enviado;
                        infoCuentaMail.cta_mail_para_envio_x_cbte_enviado = item.cta_mail_para_envio_x_cbte_enviado;
                        infoCuentaMail.cta_mail_para_envio_x_cbte_no_auto = item.cta_mail_para_envio_x_cbte_no_auto;
                        infoCuentaMail.enviar_mail_x_cada_cbte_no_auto = item.enviar_mail_x_cada_cbte_no_auto;
                        infoCuentaMail.Usar_Credenciales_x_default_SMTP = item.Usar_Credenciales_x_default_SMTP;
                        infoCuentaMail.Usa_SSL_Conexion_para_Descarga_correo = item.Usa_SSL_Conexion_para_Descarga_correo;
                        infoCuentaMail.Guardar_1_copia_de_corre_en_server_mail = item.Guardar_1_copia_de_corre_en_server_mail;
                        infoCuentaMail.Borra_server_mail_cada_dias = Convert.ToInt32(item.Borra_server_mail_cada_dias);
                        infoCuentaMail.Tipo_Authenticacion = item.Tipo_Authenticacion;
                        infoCuentaMail.Confirmacion_de_Entrega = (item.Confirmacion_de_Entrega == null) ? true : item.Confirmacion_de_Entrega;
                        infoCuentaMail.Confirmacion_de_Lectura = (item.Confirmacion_de_Lectura == null) ? true : item.Confirmacion_de_Lectura;

                        lista_cuentas.Add(infoCuentaMail);
                    }

                }

                return lista_cuentas;


            }
            catch (Exception ex)
            {


                string mensaje = "";
                mensaje = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

                return new List<mail_Cuentas_Correo_Info>();
            }
        }


        public bool Consulta_Si_CuentaExiste(string idCuenta, ref string mensaje)
        {
            try
            {

                Boolean  Existe;
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                     int consulta = (from q in conexion.mail_Cuentas_Correo
                                     where q.IdCuenta == idCuenta
                                     select q).Count();

                     if (consulta > 0)
                     {
                         Existe = true;

                     }
                     else
                     {
                         Existe = false;
                     }
                     return Existe;
                }              
            }
            catch (Exception ex)
            {

                mensaje = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);  

               return false;
            }
        }


        public bool ModificarCuentaBD(mail_Cuentas_Correo_Info infoCuentas, ref string mensajeErrorOut)
        {
            try
            {


                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    var Reg_a_Modificar = oEnti.mail_Cuentas_Correo.First(var => var.IdCuenta == infoCuentas.IdCuenta);
                   
                    Reg_a_Modificar.Nombre_cuenta = infoCuentas.Nombre_cuenta;
                    Reg_a_Modificar.direccion_correo = infoCuentas.direccion_correo;
                    Reg_a_Modificar.Usuario = infoCuentas.Usuario;
                    Reg_a_Modificar.Password = infoCuentas.Password;
                    Reg_a_Modificar.TipoCuenta = infoCuentas.TipoCuenta;
                    Reg_a_Modificar.ServidorCorreoEntrante = infoCuentas.ServidorCorreoEntrante;
                    Reg_a_Modificar.ServidorCorreoSaliente = infoCuentas.ServidorCorreoSaliente;
                    Reg_a_Modificar.Port_salida = infoCuentas.Port_salida;
                    Reg_a_Modificar.port_entrada = infoCuentas.port_entrada;
                    Reg_a_Modificar.cta_predeterminada = infoCuentas.cta_predeterminada;
                    Reg_a_Modificar.precisa_conexion_cifrada = infoCuentas.precisa_conexion_cifrada;
                    Reg_a_Modificar.tipo_Seguridad = infoCuentas.tipo_Seguridad;

                    Reg_a_Modificar.enviar_copia_x_cada_mail_enviado = infoCuentas.enviar_copia_x_cada_mail_enviado;
                    Reg_a_Modificar.enviar_mail_x_cada_cbte_no_auto = infoCuentas.enviar_mail_x_cada_cbte_no_auto;
                    Reg_a_Modificar.cta_mail_para_envio_x_cbte_enviado = infoCuentas.cta_mail_para_envio_x_cbte_enviado;
                    Reg_a_Modificar.cta_mail_para_envio_x_cbte_no_auto = infoCuentas.cta_mail_para_envio_x_cbte_no_auto;


                    Reg_a_Modificar.Usar_Credenciales_x_default_SMTP = (infoCuentas.Usar_Credenciales_x_default_SMTP == null) ? false : infoCuentas.Usar_Credenciales_x_default_SMTP;
                    Reg_a_Modificar.Usa_SSL_Conexion_para_Descarga_correo = (infoCuentas.Usa_SSL_Conexion_para_Descarga_correo == null) ? false : infoCuentas.Usa_SSL_Conexion_para_Descarga_correo;
                    Reg_a_Modificar.Guardar_1_copia_de_corre_en_server_mail = (infoCuentas.Guardar_1_copia_de_corre_en_server_mail == null) ? false : infoCuentas.Guardar_1_copia_de_corre_en_server_mail;
                    Reg_a_Modificar.Borra_server_mail_cada_dias = Convert.ToInt32(infoCuentas.Borra_server_mail_cada_dias);
                    Reg_a_Modificar.Tipo_Authenticacion = infoCuentas.Tipo_Authenticacion;

                    Reg_a_Modificar.Confirmacion_de_Entrega = (infoCuentas.Confirmacion_de_Entrega == null) ? false : infoCuentas.Confirmacion_de_Entrega;
                    Reg_a_Modificar.Confirmacion_de_Lectura = (infoCuentas.Confirmacion_de_Lectura == null) ? false : infoCuentas.Confirmacion_de_Lectura;  


                    oEnti.SaveChanges();
                    
                }
                return true;
            }
            catch (Exception ex)
            {

                mensajeErrorOut = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeErrorOut, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);  

                return false;
            }

        }


        public bool GuardarCuentaBD(mail_Cuentas_Correo_Info infoCuentas, ref string mensajeErrorOut)
        {
            try
            {


                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    var Reg_a_Modificar = new mail_Cuentas_Correo();

                    Reg_a_Modificar.IdCuenta = infoCuentas.IdCuenta;
                    Reg_a_Modificar.Nombre_cuenta = infoCuentas.Nombre_cuenta;
                    Reg_a_Modificar.direccion_correo = infoCuentas.direccion_correo;
                    Reg_a_Modificar.Usuario = infoCuentas.Usuario;
                    Reg_a_Modificar.Password = infoCuentas.Password;
                    Reg_a_Modificar.TipoCuenta = infoCuentas.TipoCuenta;
                    Reg_a_Modificar.ServidorCorreoEntrante = infoCuentas.ServidorCorreoEntrante;
                    Reg_a_Modificar.ServidorCorreoSaliente = infoCuentas.ServidorCorreoSaliente;
                    Reg_a_Modificar.Port_salida = infoCuentas.Port_salida;
                    Reg_a_Modificar.port_entrada = infoCuentas.port_entrada;
                    Reg_a_Modificar.cta_predeterminada = infoCuentas.cta_predeterminada;
                    Reg_a_Modificar.precisa_conexion_cifrada = infoCuentas.precisa_conexion_cifrada;
                    Reg_a_Modificar.tipo_Seguridad = infoCuentas.tipo_Seguridad;
                    Reg_a_Modificar.enviar_copia_x_cada_mail_enviado = infoCuentas.enviar_copia_x_cada_mail_enviado;
                    Reg_a_Modificar.cta_mail_para_envio_x_cbte_enviado = infoCuentas.cta_mail_para_envio_x_cbte_enviado;
                    Reg_a_Modificar.cta_mail_para_envio_x_cbte_no_auto = infoCuentas.cta_mail_para_envio_x_cbte_no_auto;
                    Reg_a_Modificar.enviar_mail_x_cada_cbte_no_auto = infoCuentas.enviar_mail_x_cada_cbte_no_auto;
                    Reg_a_Modificar.Usar_Credenciales_x_default_SMTP = infoCuentas.Usar_Credenciales_x_default_SMTP;
                    Reg_a_Modificar.Usa_SSL_Conexion_para_Descarga_correo = infoCuentas.Usa_SSL_Conexion_para_Descarga_correo;
                    Reg_a_Modificar.Guardar_1_copia_de_corre_en_server_mail = infoCuentas.Guardar_1_copia_de_corre_en_server_mail;
                    Reg_a_Modificar.Borra_server_mail_cada_dias = infoCuentas.Borra_server_mail_cada_dias;
                    Reg_a_Modificar.Tipo_Authenticacion = infoCuentas.Tipo_Authenticacion;

                    Reg_a_Modificar.Confirmacion_de_Lectura = infoCuentas.Confirmacion_de_Lectura;
                    Reg_a_Modificar.Confirmacion_de_Entrega = infoCuentas.Confirmacion_de_Entrega;
                    
                    oEnti.mail_Cuentas_Correo.Add(Reg_a_Modificar);


                    oEnti.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {

                mensajeErrorOut = ex.InnerException + " " + ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeErrorOut, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);  

                return false;
            }

        }

    }
}
