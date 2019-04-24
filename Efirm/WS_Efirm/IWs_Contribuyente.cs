using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using FirmElect.Info;

namespace WS_Efirm
{
  // nuevo
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWs_Contribuyente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWs_Contribuyente
    {
        
        [OperationContract]
        List<tb_Contribuyente_Info> GetContribuyente(int IdEmpresa, string cedulaRuc, string password, ref string MensajeErrorOut);

        [OperationContract]
        tb_Contribuyente_Info GetContribuyente_Info(int IdEmpresa, string cedulaRuc, ref string MensajeErrorOut);


        [OperationContract]
        Boolean Modificar_GetContribuyente_Info(int IdEmpresa, string cedulaRuc, string mail, string password, ref string MensajeErrorOut);
        
        [OperationContract]
        sp_Registro_Contribuyente_Info Registrar_Contribuyente(int IdEmpresa, String CedulaRUc, String TipoComprobantes, String NumComprobante, String Correo, String Contrasenia, String Link, ref String mensajeErrorOut);

        [OperationContract]
        sp_ValidarRegistros_Info sp_ValidarRegistros(int IdEmpresa, String HashText, ref String mensajeErrorOut);

        [OperationContract]
        sp_RecuperaciondeContraseña_Info sp_RecuperaciondeContraseña(int IdEmpresa, string CedulaRuc, string Link, ref String mensajeErrorOut);

        [OperationContract]
        tb_Contribuyente_Info sp_VerificarRecuperaciondeContrasenia(int IdEmpresa, string @HashText, ref String mensajeErrorOut);

        [OperationContract]
        tb_Contribuyente_Info Test_Efirm(ref String mensajeErrorOut);


    }
}
