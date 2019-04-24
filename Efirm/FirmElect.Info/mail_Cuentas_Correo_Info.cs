using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
  public  class mail_Cuentas_Correo_Info
    {
      public string IdCuenta { get; set; }
      public string Nombre_cuenta { get; set; }
      public string direccion_correo { get; set; }
      public string Usuario { get; set; }
      public string Password { get; set; }
      public string TipoCuenta { get; set; }
      public string ServidorCorreoEntrante { get; set; }
      public string ServidorCorreoSaliente { get; set; }
      public int Port_salida { get; set; }
      public int port_entrada { get; set; }
      public bool cta_predeterminada { get; set; }
      public string tipo_Seguridad { get; set; }
      public bool precisa_conexion_cifrada { get; set; }
      public bool ? enviar_copia_x_cada_mail_enviado { get; set; }
      public bool ? enviar_mail_x_cada_cbte_no_auto{ get; set; }
      public string cta_mail_para_envio_x_cbte_enviado { get; set; }
      public string cta_mail_para_envio_x_cbte_no_auto { get; set; }
      public bool ?  Usar_Credenciales_x_default_SMTP { get; set; }
      public bool? Usa_SSL_Conexion_para_Descarga_correo { get; set; }
      public bool? Guardar_1_copia_de_corre_en_server_mail { get; set; }
      public int Borra_server_mail_cada_dias { get; set; }
      public string Tipo_Authenticacion { get; set; }
      public string Usuario_smtp { get; set; }
      public string Password_smtp { get; set; }
      public bool ? Confirmacion_de_Entrega { get; set; }
      public bool ? Confirmacion_de_Lectura { get; set; }

    }
}
