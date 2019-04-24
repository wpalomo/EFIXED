using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FirmElect.Info
{
   public class mail_Mensaje_Archi_Adjunto_Info
    {
       public decimal IdMensaje { get; set; }
       public int Secuencia { get; set; }
       public  byte[] Archivo_adjunto { get; set; }
       public string descripcion_archi { get; set; }
       public string extensionArchivo { get; set; }
       public MemoryStream Archivo_adjunto_stream { get; set; }
       public string IdComprobante { get; set; }
       public int  IdEmpresa { get; set; }

       public Boolean MosTrar_icono_Imprimir { get; set; }

       public Boolean MosTrar_icono_Descargar { get; set; }

       public Boolean Checked { get; set; }

    








    }
}
