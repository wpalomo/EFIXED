//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MailEfirm.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class mail_Mensaje
    {
        public mail_Mensaje()
        {
            this.mail_Mensaje_Archi_Adjunto = new HashSet<mail_Mensaje_Archi_Adjunto>();
        }
    
        public decimal IdMensaje { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Para { get; set; }
        public string Asunto { get; set; }
        public string Asunto_texto_mostrado { get; set; }
        public int Tiene_Adjunto { get; set; }
        public int Prioridad { get; set; }
        public int Leido { get; set; }
        public bool Respondido { get; set; }
        public bool No_Leido { get; set; }
        public string Texto_mensaje { get; set; }
        public string IdTipo_Mensaje { get; set; }
        public string Carpeta_Mensaje { get; set; }
        public bool Eliminado { get; set; }
        public Nullable<decimal> IdContribuyente { get; set; }
    
        public virtual ICollection<mail_Mensaje_Archi_Adjunto> mail_Mensaje_Archi_Adjunto { get; set; }
        public virtual mail_Mensaje_Tipo mail_Mensaje_Tipo { get; set; }
        public virtual tb_Contribuyente tb_Contribuyente { get; set; }
    }
}