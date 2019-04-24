using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;

namespace FirmElect.Info
{

    public sealed class cl_parametrosGenerales_Info
    {

        static readonly cl_parametrosGenerales_Info instance = new cl_parametrosGenerales_Info();


        public decimal Version = 201607151431;

        public string Nom_Sistema { get; set; }
        public tb_Parametro_Info Parametro_Info { get; set; }
        public string RutaPrincipal { get; set; }
        public string RutaComprobantesValidos  { get; set; }
        public string RutaComprobantes_con_Errores { get; set; }
        public string RutaComprobantesRepositorio  { get; set; }
        public string RutaCertificados  { get; set; }
        public bool AUTORIZADO_ENVIO_CORREO { get; set; }



        public mail_Parametro_Info InfoParametrosMail { get; set; }
        public  List<tb_Empresa_Info> G_listEmpresas{ get; set; }
    
       
        static cl_parametrosGenerales_Info() { }

        cl_parametrosGenerales_Info()
        {
        }

        public static cl_parametrosGenerales_Info Instance
        {
            get { return instance; }
        }

    }

}
