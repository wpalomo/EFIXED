using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;

namespace FirmElect.Data
{
   public class mail_Cuentas_Correo_x_Empresa_Data:Imail_Cuentas_Correo_x_Empresa_Data
    {

        public List<mail_Cuentas_Correo_x_Empresa_Info> Consulta_mail_Cuentas_Correo_x_Empresa(ref string mensaje)
        {
            try
            {
                List<mail_Cuentas_Correo_x_Empresa_Info> lista_cuentas_Emisor = new List<mail_Cuentas_Correo_x_Empresa_Info>();

                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {

                    var q = from C in conexion.wv_mail_Cuentas_Correo_x_Empresa
                            select new
                            {
                                C.IdEmpresa,
                                C.IdCuenta,
                                C.observacion,
                                C.RazonSocial,
                                C.Nombre_cuenta,
                                C.direccion_correo
                            };
                    foreach (var item in q)
                    {
                        mail_Cuentas_Correo_x_Empresa_Info InfoCuentaEmpresa = new mail_Cuentas_Correo_x_Empresa_Info();

                        InfoCuentaEmpresa.IdEmpresa = item.IdEmpresa;
                        InfoCuentaEmpresa.IdCuenta = item.IdCuenta;
                        InfoCuentaEmpresa.observacion = item.observacion;
                        InfoCuentaEmpresa.RazonSocial = item.RazonSocial;
                        InfoCuentaEmpresa.observacion = item.observacion;
                        InfoCuentaEmpresa.direccion_correo = item.direccion_correo;

                        lista_cuentas_Emisor.Add(InfoCuentaEmpresa);
                    }

                }

                return lista_cuentas_Emisor;


            }
            catch (Exception ex)
            {


               // string mensaje = "";
                mensaje = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

                return new List<mail_Cuentas_Correo_x_Empresa_Info>();
            }
        }



        public List<mail_Cuentas_Correo_x_Empresa_Info> Consulta_mail_Cuentas_Correo_x_Empresa(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<mail_Cuentas_Correo_x_Empresa_Info> lista_cuentas_Emisor = new List<mail_Cuentas_Correo_x_Empresa_Info>();

                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {

                    var q = from C in conexion.wv_mail_Cuentas_Correo_x_Empresa
                            where C.IdEmpresa == IdEmpresa
                            select new
                            {
                                C.IdEmpresa,
                                C.IdCuenta,
                                C.observacion,
                                C.RazonSocial,
                                C.Nombre_cuenta,
                            };
                    foreach (var item in q)
                    {
                        mail_Cuentas_Correo_x_Empresa_Info InfoCuentaEmpresa = new mail_Cuentas_Correo_x_Empresa_Info();

                        InfoCuentaEmpresa.IdEmpresa = item.IdEmpresa;
                        InfoCuentaEmpresa.IdCuenta = item.IdCuenta;
                        InfoCuentaEmpresa.observacion = item.observacion;
                        InfoCuentaEmpresa.RazonSocial = item.RazonSocial;
                        InfoCuentaEmpresa.observacion = item.observacion;

                        lista_cuentas_Emisor.Add(InfoCuentaEmpresa);
                    }

                }

                return lista_cuentas_Emisor;


            }
            catch (Exception ex)
            {


               // string mensaje = "";
                mensaje = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

                return new List<mail_Cuentas_Correo_x_Empresa_Info>();
            }
        }


       

        public bool GuardarRelacion(int IdEmisor, string IdCuenta, string Observacion, ref string mensaje)
        {

            try
            {

                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    var Reg_a_Modificar = new mail_Cuentas_Correo_x_Empresa();
                    Reg_a_Modificar.IdEmpresa = IdEmisor;
                    Reg_a_Modificar.IdCuenta = IdCuenta;
                    Reg_a_Modificar.observacion = Observacion;
                    oEnti.mail_Cuentas_Correo_x_Empresa.Add(Reg_a_Modificar);
                    oEnti.SaveChanges();
                }
                return true;
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
    }
}
