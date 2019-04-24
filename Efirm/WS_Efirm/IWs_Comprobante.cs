using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

using FirmElect.Info;

namespace WS_Efirm
{
    //nuevo
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWs_Comprobante" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWs_Comprobante
    {
       

        [OperationContract]
        List<tb_Catalogo_Info> Lista_TipoComprobantes(ref string MensajeErrorOut);


        [OperationContract]
        List<tb_Comprobante_Info> consultar_listado_comprobantes(int IdEmpresa,
        string cedulaRuc, string TipoComprobante, DateTime FecIni, DateTime FecFin, string buscar,int Indice_Pagina,int Tamanio_Pagina ,
            ref string mensajeErrorOut);

        [OperationContract]
        string getXML(int IdEmpresa, string cedulaRuc, string IdComprobante, ref string mensajeErrorOut);

        [OperationContract]
        byte[] getRide_Pdf(int IdEmpresa, string cedulaRuc, string IdComprobante);




    }
}
