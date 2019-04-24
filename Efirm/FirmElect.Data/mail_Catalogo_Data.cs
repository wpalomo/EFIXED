using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;



namespace FirmElect.Data
{
    public class mail_Catalogo_Data
    {

        public List<mail_Catalogo_Info> consultarCatalogo(string estado, string tipoCatalogo, ref string mensajeErrorOut)
        {
            try
            {
                List<mail_Catalogo_Info> catalogoInfo = new List<mail_Catalogo_Info>();
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    var mail = from C in conexion.mail_Catalogo
                               where C.IdTipoCatalogo == tipoCatalogo && C.estado == estado
                            select C;
                    foreach (var item in mail)
                    {
                        mail_Catalogo_Info mailInfo = new mail_Catalogo_Info();
                        mailInfo.IdCatalogo = item.IdCatalogo;
                        mailInfo.nom_catalogo = item.nom_catalogo;
                        mailInfo.IdTipoCatalogo = item.IdTipoCatalogo;
                        mailInfo.estado = item.estado;
                        catalogoInfo.Add(mailInfo);  
                    }

                }
                return catalogoInfo;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.InnerException + " " + ex.Message;

                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensaje, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

                return new List<mail_Catalogo_Info>();
    
            }
        }
    }
}
