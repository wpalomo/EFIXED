using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.Utils;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using DevExpress.XtraExport;
using System.Xml;
using MailEfirm.Info;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;
using MailEfirm;
namespace MailEfirm.Info
{
   public class Contribuyente_Info
    {
    public decimal IdContribuyente { get; set; }
    public int IdEmpresa { get; set; }
       public string cedulaRuc_contri { get; set; }
       public string Nom_Contribuyente { get; set; }
       public string Mail { get; set; }
       public string Mail_secundario { get; set; }
       public bool EsCliente { get; set; }
       public bool EsProveedor { get; set; }
       public string Password { get; set; }
       public bool Estado { get; set; }
       public DateTime ? Fecha_transaccion { get; set; }
       public DateTime ? Fecha_Registro_web { get; set; }
       public DateTime ? Fecha_Actualizacion_datos { get; set; }
       public bool Registrado_web { get; set; }
       public string Observacion { get; set; }
       public eTipo_Contacto TipoContacto { get; set; }
       public string Direccion { get; set; }
       public string Telefono { get; set; }
       public byte[] Foto { get; set; }

       public string RazonSocial { get; set; }


    }
}
