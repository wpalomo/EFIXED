using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
namespace FirmElect.Data
{
    /// <summary>
    /// dffndhdhdh
    /// </summary>
     public  interface Imail_Mensaje_Archi_Adjunto_Data
    {
         bool EmailGuardarArchivoAdjunto(mail_Mensaje_Archi_Adjunto_Info infoAdjunto, ref string mensajeError);
         List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto_Mensaje_x_comprobante(Decimal idMensaje, ref string mensajeError);
          bool Tiene_Adjunto_Null_x_Comprobante(Decimal idMensaje, ref string mensajeError);
          bool Actualizar_Archivo_Adjuno(List<mail_Mensaje_Archi_Adjunto_Info> ArchivoAdjunto, ref string mensajeError);
          int SecuenciaArchivoAdjunto();
          bool Verificar_Correo_Existe_x_cbte_Autorizado(int IdEmpresa,string IdComprobante, ref string mensajeError);
           List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto_x_IdMensaje(Decimal idMensaje, ref string mensajeError);
             List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto(ref string mensajeError);   
    }
}
