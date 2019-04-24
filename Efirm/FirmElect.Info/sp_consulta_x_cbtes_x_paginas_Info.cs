using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
    public class sp_consulta_x_cbtes_x_paginas_Info
    {
        public int IdEmpresa { get; set; }
        public string IdComprobante { get; set; }
        public string IdTipoDocumento { get; set; }
        public string IdEstado_cbte { get; set; }
        public string Cedula_Ruc { get; set; }
        public string Numero_Autorizacion { get; set; }
        public Nullable<System.DateTime> Fecha_Emi_Fact { get; set; }
        public string Nombre_file { get; set; }
        public string nom_Tipo_doc { get; set; }
        public string ClaveContingencia { get; set; }
        public Nullable<System.DateTime> FechaAutorizacion { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<decimal> IdContribuyente { get; set; }
        public string Nom_Contribuyente { get; set; }
        public Nullable<long> NumFila { get; set; }
        public Nullable<decimal> TotalRegistros { get; set; }
    }
}
