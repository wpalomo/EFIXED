﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesFactElectronica : DbContext
    {
        public EntitiesFactElectronica()
            : base("name=EntitiesFactElectronica")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tb_Cliente> tb_Cliente { get; set; }
        public DbSet<tb_Comprobante> tb_Comprobante { get; set; }
        public DbSet<tb_Empresa> tb_Empresa { get; set; }
        public DbSet<tb_sis_Log_Error_Vzen> tb_sis_Log_Error_Vzen { get; set; }
    }
}
