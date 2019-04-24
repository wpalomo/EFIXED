using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FirmElect.Info;

using EAGetMail;



namespace FirmElect.Info
{
   public class mail_Mensaje_Info
    {

       public mail_Mensaje_Info()
       {
           InfoContribuyente = new tb_Contribuyente_Info();
           list_Archivos_Adjuntos = new List<mail_Mensaje_Archi_Adjunto_Info>();
          // Attachments = new List<Attachment>();
       }

       


public decimal IdMensaje { get; set; }
public DateTime Fecha { get; set; }
public string sFecha { get; set; }
public string Para { get; set; }
public string Para_CC { get; set; }
public string Para_CCO { get; set; }
public string Asunto { get; set; }
public string Asunto_texto_mostrado { get; set; }
public bool Tiene_Adjunto { get; set; }
public int Prioridad { get; set; }
public bool Leido { get; set; }
public bool Respondido { get; set; }
public bool No_Leido { get; set; }
public string Texto_mensaje { get; set; }
public eTipoMail IdTipo_Mensaje { get; set; }
public bool Eliminado { get; set; }
public decimal? IdContribuyente { get; set; }
public string mail_remitente { get; set; }
public string codMensajeId { get; set; }
public string IdCuenta { get; set; }


public tb_Contribuyente_Info InfoContribuyente { get; set; }
public List<mail_Mensaje_Archi_Adjunto_Info> list_Archivos_Adjuntos = new List<mail_Mensaje_Archi_Adjunto_Info>();

public bool Checked { get; set; }
public string RazonSocial_Emisor { get; set; }
public string RUC_Emisor { get; set; }
public Boolean Mostrar_col_Eliminar { get; set; }


public Boolean MosTrar_icono_Ride { get; set; }

public Boolean MosTrar_icono_xml { get; set; }


public string fileName { get; set; }
//public List<Attachment> Attachments { get; set; }
public byte[] Archivo_correo { get; set; }

      
         
    }
}
