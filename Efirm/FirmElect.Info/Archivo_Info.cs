using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirmElect.Info
{
   public  class Archivo_Info
    {
       public Boolean Checked { get; set; }
       public string Name { get; set; }
       public DateTime LastAccessTime { get; set; }
       public string FullName { get; set; }
       public string Attributes { get; set; }
       public long Length { get; set; }
       public DateTime CreationTime { get; set; }
       public string Extension { get; set; }
       public string Estado_Valicion { get; set; }
       public string mensaje_error_validacion { get; set; }
       public decimal NumRegistro { get; set; }
       public string MensajeSubida { get; set; }
       public string TipoCbte { get; set; }
       public Boolean EsSoloLectura { get; set; }
       public string Ambiente { get; set; }
    }
}
