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
    
    public partial class seg_menu_x_tb_empresa
    {
        public int IdEmpresa { get; set; }
        public int IdMenu { get; set; }
        public bool estado { get; set; }
    
        public virtual seg_menu seg_menu { get; set; }
        public virtual tb_Empresa tb_Empresa { get; set; }
    }
}
