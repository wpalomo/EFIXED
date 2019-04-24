using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;
namespace FirmElect.Bus
{
    public  class mail_Mensaje_Archi_Adjunto_Bus
    {
        mail_Mensaje_Archi_Adjunto_Data Odata;
        public mail_Mensaje_Archi_Adjunto_Bus()
        {
            Odata = new mail_Mensaje_Archi_Adjunto_Data();

        }
        public bool EmailGuardarArchivoAdjunto(mail_Mensaje_Archi_Adjunto_Info infoAdjunto, ref string mensajeError)
        {

            try
            {
                return Odata.EmailGuardarArchivoAdjunto(infoAdjunto, ref  mensajeError);
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public int SecuenciaArchivoAdjunto()
        {
            Int32 idSecuancia = 0;
            try
            {

                return idSecuancia = Odata.SecuenciaArchivoAdjunto();
            }
            catch (Exception)
            {

                return idSecuancia;
            }
        }
        
        public bool Tiene_Adjunto_Null_x_Comprobante(Decimal idMensaje, ref string mensajeError)
        {
            try
            {
                return Odata.Tiene_Adjunto_Null_x_Comprobante(idMensaje, ref mensajeError);

            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto_Mensaje_x_comprobante(Decimal idMensaje, ref string mensajeError)
        {
            try
            {
               return Odata.Lista_ArchivoAdjunto_Mensaje_x_comprobante(idMensaje,ref mensajeError);
            }
            catch (Exception)
            {

                return new List<mail_Mensaje_Archi_Adjunto_Info>();
            }
        }

        public List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto_x_IdMensaje(Decimal idMensaje, ref string mensajeError)
        {

            try
            {
                return Odata.Lista_ArchivoAdjunto_x_IdMensaje(idMensaje, ref mensajeError);
            }
            catch (Exception)
            {

                return new List<mail_Mensaje_Archi_Adjunto_Info>();
            }
        
        }

        public List<mail_Mensaje_Archi_Adjunto_Info> Lista_ArchivoAdjunto(ref string mensajeError)
        {
            try
            {
                return Odata.Lista_ArchivoAdjunto(ref mensajeError);
            }
            catch (Exception ex)
            {
                
               return new List<mail_Mensaje_Archi_Adjunto_Info>();
            }
        
        
        }

        public bool Actualizar_Archivo_Adjuno(List<mail_Mensaje_Archi_Adjunto_Info> ArchivoAdjunto, ref string mensajeError)
        {
            try
            {
                return Odata.Actualizar_Archivo_Adjuno(ArchivoAdjunto, ref mensajeError);

            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool Verificar_Correo_Existe(int IdEmpresa ,string IdComprobante, ref string mensajeError)
        {
            try
            {
                return Odata.Verificar_Correo_Existe_x_cbte_Autorizado(IdEmpresa,IdComprobante, ref mensajeError);

            }
            catch (Exception ex)
            {

                return false;
            }
        }



    }
}
