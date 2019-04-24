using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using FirmElect.Info;

namespace WS_Efirm
{
   //nuevo
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWs_Empresa" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWs_Empresa
    {

        [OperationContract]
        List<tb_Empresa_Info> GetEmpresas(ref string MensajeErrorOut);

        [OperationContract]
        bool GrabarDB(tb_Empresa_Info InfoEmpresa, ref string MensajeErrorOut);


        //haac
        [OperationContract]
        List<tb_Empresa_Info> GetEmpresas_x_Alias(string alias, ref string MensajeErrorOut);


        [OperationContract]
        List<tb_Empresa_Info> GetEmpresas_x_Url(string url, ref string MensajeErrorOut);
              
        
        //[OperationContract]
        //void DoWork();
    }
}
