//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmElect.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_Mensaje_x_Contribuyente
    {
        public decimal IdMensaje { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Para { get; set; }
        public string Asunto { get; set; }
        public string Asunto_texto_mostrado { get; set; }
        public bool Tiene_Adjunto { get; set; }
        public int Prioridad { get; set; }
        public bool Leido { get; set; }
        public bool Respondido { get; set; }
        public bool No_Leido { get; set; }
        public string Texto_mensaje { get; set; }
        public string IdTipo_Mensaje { get; set; }
        public bool Eliminado { get; set; }
        public Nullable<decimal> IdContribuyente { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public string cedulaRuc_contri { get; set; }
        public string Nom_Contribuyente { get; set; }
        public string Mail { get; set; }
        public string Mail_secundario { get; set; }
        public Nullable<bool> EsCliente { get; set; }
        public Nullable<bool> EsProveedor { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string Observacion { get; set; }
        public string TipoContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string RazonSocial_Emisor { get; set; }
        public string RUC_Emisor { get; set; }
        public string mail_remitente { get; set; }
        public string Para_CC { get; set; }
        public string codMensajeId { get; set; }
        public string IdCuenta { get; set; }
        public byte[] Archivo_correo { get; set; }
        public string Para_CCO { get; set; }
    }
}
