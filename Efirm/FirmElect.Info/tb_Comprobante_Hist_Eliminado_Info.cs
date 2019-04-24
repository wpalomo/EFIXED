using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public class tb_Comprobante_Hist_Eliminado_Info
    {
       public int IdEmpresa { get; set; }
       public string IdComprobante { get; set; }
       public string IdTipoDocumento { get; set; }
       public string IdEstado_cbte { get; set; }
       public decimal Secuencial { get; set; }
       public string Cedula_Ruc { get; set; }
       public string Numero_Autorizacion { get; set; }
       public string RutaArchivo { get; set; }
       public string Nombre_file { get; set; }
       public string s_XML { get; set; }
       public DateTime ? Fecha_Emi_Fact { get; set; }
       public DateTime ? Fecha_transaccion { get; set; }
       public DateTime ? FechaAutorizacion { get; set; }
       public string ClaveContingencia { get; set; }
       public string EstadoDoc { get; set; }
       public string Error { get; set; }
       public string IdEstadoProceso { get; set; }
       public string IdError_Sri { get; set; }
       public string RespuestaSRI { get; set; }
       public double ? Total { get; set; }
       public Boolean Checked { get; set; }
       public string Usuario_Anulo { get; set; }
       public DateTime Fecha_hora_anulacion { get; set; }
       public string IpAnulacion { get; set; }
       public string Motivo_Anulacion { get; set; }
       public string Clave_Acceso { get; set; }
       public string Ambiente { get; set; }




    }
}
