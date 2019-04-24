using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirmElect.Info
{
    public class vw_Comprobantes_recibidos_Info
    {
        public string descripcion_archi { get; set; }
        public string extencion { get; set; }
        public DateTime Fecha { get; set; }
        public string Asunto { get; set; }
        public string mail_emisor { get; set; }
        public string IdTipo_Mensaje { get; set; }
        public string codMensajeId { get; set; }
        public string IdCuenta { get; set; }
        public string Texto_mensaje { get; set; }
        public int Secuencia { get; set; }
        public byte[] Archivo_adjunto { get; set; }
        public string Para { get; set; }
        public decimal IdMensaje { get; set; }
     
        public Boolean MosTrar_icono { get; set; }
        public Boolean Checked { get; set; }

        public string s_Xml { get; set; }
        public string Ced_Ruc_Emisor { get; set; }
        public string Ambiente { get; set; }
        public string TipoDocumento { get; set; }
        public string nomTipoDoc { get; set; }
        public string Razon_Social_emisor { get; set; }
        public string ClaveAcceso { get; set; }
        public string Estado_SRI { get; set; }
        public string fecha_aut { get; set; }
        public string num_auto { get; set; }
        public string Error { get; set; }
        

        

    }
}
