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
    
    public partial class vw_comprobante_pendiente_de_Autorizacion_sri
    {
        public int IdEmpresa { get; set; }
        public string IdComprobante { get; set; }
        public string IdTipoDocumento { get; set; }
        public string IdEstado_cbte { get; set; }
        public string Cedula_Ruc { get; set; }
        public string Numero_Autorizacion { get; set; }
        public string RutaArchivo { get; set; }
        public string Nombre_file { get; set; }
        public string s_XML { get; set; }
        public Nullable<System.DateTime> Fecha_Emi_Fact { get; set; }
        public Nullable<System.DateTime> Fecha_transaccion { get; set; }
        public Nullable<System.DateTime> FechaAutorizacion { get; set; }
        public string ClaveContingencia { get; set; }
        public string EstadoDoc { get; set; }
        public string Error { get; set; }
        public string IdError_Sri { get; set; }
        public string Nom_emisor { get; set; }
        public string Nom_Tipo_doc { get; set; }
        public string Nom_estado_doc { get; set; }
        public string IdEstadoProceso { get; set; }
        public string RespuestaSRI { get; set; }
        public string Ambiente { get; set; }
        public string Clave_Acceso { get; set; }
        public string Nom_Contribuyente { get; set; }
    }
}
