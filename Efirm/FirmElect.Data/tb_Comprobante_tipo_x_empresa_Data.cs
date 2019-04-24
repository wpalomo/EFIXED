using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;

namespace FirmElect.Data
{
    public class tb_Comprobante_tipo_x_empresa_Data
    {
        public List<tb_Comprobante_tipo_x_empresa_Info> consultar(ref string mensajeErrorOut)
        {

            try
            {
                List<tb_Comprobante_tipo_x_empresa_Info> lista_cuentas = new List<tb_Comprobante_tipo_x_empresa_Info>();

                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {

                    var q = from C in conexion.tb_Comprobante_tipo_x_empresa
                            select C;


                    foreach (var item in q)
                    {
                        tb_Comprobante_tipo_x_empresa_Info infoCuentaMail = new tb_Comprobante_tipo_x_empresa_Info();

                        infoCuentaMail.IdEmpresa = item.IdEmpresa;
                        infoCuentaMail.idComprobante_tipo = item.IdComprobante_tipo;
                        infoCuentaMail.File_disenio_rpt = item.File_disenio_rpt;

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

                return new List<tb_Comprobante_tipo_x_empresa_Info>();
            }
        }

        public Boolean ModificarDB(tb_Comprobante_tipo_x_empresa_Info info, ref string MensajeErrorOut)
        
        
        
        
        {
            try
            {
                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    EntitiesFactElectronica param = new EntitiesFactElectronica();
                    var select = (from C in param.tb_Comprobante_tipo_x_empresa
                                  where C.IdComprobante_tipo == info.idComprobante_tipo
                                  && C.IdEmpresa==info.IdEmpresa
                                  select C).Count();

                    if (select == 0)
                    {

                        tb_Comprobante_tipo_x_empresa addressG = new tb_Comprobante_tipo_x_empresa();
                        addressG.IdEmpresa = info.IdEmpresa;
                        addressG.IdComprobante_tipo = info.idComprobante_tipo;
                        addressG.File_disenio_rpt = info.File_disenio_rpt;

                        oEnti.tb_Comprobante_tipo_x_empresa.Add(addressG);
                        oEnti.SaveChanges();
                    }
                    else
                    {
                        var contact = oEnti.tb_Comprobante_tipo_x_empresa.First(var => var.IdComprobante_tipo == info.idComprobante_tipo && var.IdEmpresa == info.IdEmpresa);
                        contact.File_disenio_rpt = info.File_disenio_rpt;

                        oEnti.SaveChanges();
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

    }
}
