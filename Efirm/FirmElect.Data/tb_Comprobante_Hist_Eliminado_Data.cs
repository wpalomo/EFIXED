using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
   public class tb_Comprobante_Hist_Eliminado_Data : Itb_Comprobante_Hist_Eliminado_Data
    {

        public bool GrabarDB(Info.tb_Comprobante_Hist_Eliminado_Info Info,string usuarioAnulo,string MotivoAnulacion, ref string mensajeErrorOut)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {

                    var Address = new tb_Comprobante_Hist_Eliminado();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdComprobante = Info.IdComprobante;
                    Address.IdTipoDocumento = Info.IdTipoDocumento;
                    Address.IdEstado_cbte = Info.IdEstado_cbte;
                    Address.Secuencial = Info.Secuencial = getSecuencial(Info.IdEmpresa, Info.IdComprobante, ref mensajeErrorOut);
                    Address.Cedula_Ruc = Info.Cedula_Ruc;
                    Address.Numero_Autorizacion = Info.Numero_Autorizacion;
                    Address.s_XML = Info.s_XML;
                    Address.Fecha_Emi_Fact = Info.Fecha_Emi_Fact;
                    Address.Fecha_transaccion = Info.Fecha_transaccion;
                    Address.FechaAutorizacion = Info.FechaAutorizacion;
                    Address.ClaveContingencia = Info.ClaveContingencia;
                    Address.RutaArchivo = Info.RutaArchivo;
                    Address.EstadoDoc = Info.EstadoDoc;
                    Address.Error = Info.Error;
                    Address.IdEstadoProceso = Info.IdEstadoProceso;
                    Address.IdError_Sri = Info.IdError_Sri;
                    Address.Nombre_file = Info.Nombre_file;
                    Address.RespuestaSRI = Info.RespuestaSRI;
                    Address.Total = Info.Total;
                    Address.Usuario_Anulo = Info.Usuario_Anulo;
                    Address.Fecha_hora_anulacion = DateTime.Now;
                    Address.IpAnulacion = Info.IpAnulacion;
                    Address.Motivo_Anulacion = Info.Motivo_Anulacion;
                    Address.Clave_Acceso = Info.Clave_Acceso;
                    Address.Ambiente = Info.Ambiente;

                    Context.tb_Comprobante_Hist_Eliminado.Add(Address);
                    Context.SaveChanges();

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


        public bool GrabarDB(List<Info.tb_Comprobante_Hist_Eliminado_Info> ListInfo,string usuarioAnulo,string MotivoAnulacion, ref string mensajeErrorOut)
        {
            try
            {
                foreach (var item in ListInfo)
                {

                    GrabarDB(item, usuarioAnulo, MotivoAnulacion, ref mensajeErrorOut);
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



        public int getSecuencial(int idempresa, string IdComprobante,ref string mensajeErrorOut)
        {
            try
            {
                int Id = 0;

                EntitiesFactElectronica OECompras = new EntitiesFactElectronica();
                var select = from q in OECompras.tb_Comprobante_Hist_Eliminado
                             where q.IdEmpresa == idempresa
                                     && q.IdComprobante == IdComprobante
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OECompras.tb_Comprobante_Hist_Eliminado
                                     where q.IdEmpresa == idempresa
                                     && q.IdComprobante == IdComprobante
                                     select q.Secuencial).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                    Id = (Id == 0) ? 1 : Id;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                mensajeErrorOut = ex.InnerException + " " + ex.Message;

                return 1;
            }

        }
        

    }
}
