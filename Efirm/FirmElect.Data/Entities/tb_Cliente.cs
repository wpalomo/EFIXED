//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmElect.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Cliente
    {
        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public string Razon_Social { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula_RUC { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string EsEmpresa { get; set; }
        public bool Estado { get; set; }
    }
}
