using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using System.Data.SqlClient;
using System.Data;
using System.Data.Objects;



namespace FirmElect.Data
{
    public class vw_Comprobantes_recibidos_Data
    {

        string mensaje = "";

        public List<vw_Comprobantes_recibidos_Info> Consultar(int indicepagina, int RegistroxPag, DateTime FechaIni,DateTime FechaFin,string CadenaBusqueda, ref string MensajeErrorOut)
        {
            List<vw_Comprobantes_recibidos_Info> lista = new List<vw_Comprobantes_recibidos_Info>();

            try
            {
             

                using (EntitiesFactElectronica CbtRec = new EntitiesFactElectronica())
                {

                    var q = from C in CbtRec.sp_consulta_x_Cbte_Recibidos_x_Pagina(indicepagina, RegistroxPag, FechaIni, FechaFin, CadenaBusqueda)
                            select C;

                    foreach (var item in q)
                    {
                        vw_Comprobantes_recibidos_Info infocbtR = new vw_Comprobantes_recibidos_Info();

                        infocbtR.Ambiente = item.Ambiente;
                        infocbtR.Archivo_adjunto = item.Archivo_adjunto;
                        infocbtR.Asunto = item.Asunto;
                        infocbtR.Ced_Ruc_Emisor = item.Ced_Ruc_Emisor;
                        infocbtR.codMensajeId = item.codMensajeId;
                        infocbtR.descripcion_archi = item.descripcion_archi;
                        infocbtR.extencion = item.extencion.ToUpper();
                        infocbtR.Fecha = item.Fecha;
                        infocbtR.IdCuenta = item.IdCuenta;
                        infocbtR.IdMensaje = item.IdMensaje;
                        infocbtR.IdTipo_Mensaje = infocbtR.mail_emisor;
                        infocbtR.Para = item.Para;
                        infocbtR.Razon_Social_emisor = item.Razon_Social_emisor;
                        infocbtR.Secuencia = item.Secuencia;
                        infocbtR.s_Xml = item.sXml;
                        infocbtR.Texto_mensaje = item.Texto_mensaje;
                        infocbtR.TipoDocumento = item.TipoDocumento;
                        infocbtR.MosTrar_icono = true;
                        infocbtR.mail_emisor = item.mail_emisor;

                        lista.Add(infocbtR);
                    }

                }

                return lista;


            }
            catch (Exception ex)
            {


                string mensaje = "";
                mensaje = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

                return lista;
            }
        }

        public int ObtenerNumPagina(int Registro_x_Pag, DateTime FechaIni, DateTime FechaFin,string cadena_Busqueda, ref string MensajeErrorOut)
        {
            try
            {
                int NumPag = 0;
                decimal t = 0;

                EntitiesFactElectronica contex = new EntitiesFactElectronica();
                var q = (from C in contex.vw_Comprobantes_recibidos
                         where C.Fecha >= FechaIni
                             && C.Fecha <= FechaFin
                             && (C.Ced_Ruc_Emisor + C.Razon_Social_emisor  + C.descripcion_archi + C.IdCuenta + C.Para).Contains(cadena_Busqueda)
                         select C).Count();

                if (q == 0)
                {
                    NumPag = 1;
                }
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


    }
}
