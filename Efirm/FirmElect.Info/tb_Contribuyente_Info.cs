using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace FirmElect.Info
{

    [DataContract]
    public class tb_Contribuyente_Info
    {
       [DataMember]
       public int IdEmpresa { get; set; }
        [DataMember]
       public decimal IdContribuyente { get; set; }
        [DataMember]
       public string cedulaRuc_contri { get; set; }
       [DataMember]
       public string Nom_Contribuyente { get; set; }

       public string Nom_Contribuyente2 { get; set; }


        [DataMember]
       public string Mail { get; set; }
        [DataMember]
       public bool EsCliente { get; set; }
        [DataMember]
       public bool EsProveedor { get; set; }
        [DataMember]
       public string Password { get; set; }
        [DataMember]
       public bool Estado { get; set; }
        [DataMember]
       public DateTime ? Fecha_transaccion { get; set; }
        [DataMember]
       public DateTime ? Fecha_Registro_web { get; set; }
        [DataMember]
       public DateTime ? Fecha_Actualizacion_datos { get; set; }
        [DataMember]
       public bool Registrado_web { get; set; }
        [DataMember]
       public string Observacion { get; set; }

        [DataMember]
        public eTipo_Contacto TipoContacto { get; set; }

        [DataMember]
        public string TipoContacto_ { get; set; }

        [DataMember]
        public byte[] Foto { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Telefono { get; set; }

        [DataMember]
        public string Mail_secundario { get; set; }

        [DataMember]
        public string RazonSocial { get; set; }

        public string Mail_secundario2 { get; set; }




        [DataMember]
        public string Mail_de_Registro_x_WEB { get; set; }

        public string Nom_Emisor { get; set; }


        public tb_Contribuyente_Info()
        {
        }

        public tb_Contribuyente_Info(int IdEmpresa_, decimal IdContribuyente_, string cedulaRuc_contri_, string Nom_Contribuyente_, string Mail_, string Observacion_)
        {
            IdEmpresa=IdEmpresa_;
            IdContribuyente=IdContribuyente_;
            cedulaRuc_contri =cedulaRuc_contri_;
            Nom_Contribuyente=Nom_Contribuyente_;
            Mail=Mail_;
            Observacion = Observacion_;
        }

    }
}
