using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;


namespace FirmElect.Data
{
  public  interface Itb_Contribuyente_Data
    {

      Boolean GuardarDB(tb_Contribuyente_Info InfoContribuyente, ref string MensajeErrorOut);
      Boolean ModificarDB_x_WEB(int IdEmpresa, string cedulaRuc, string Password, string mail, ref string mensajeErrorOut);
      List<tb_Contribuyente_Info> GetContribuyente(int IdEmpresa, string cedulaRuc, string password, ref string MensajeErrorOut);
      tb_Contribuyente_Info GetContribuyente_Info(int IdEmpresa, string cedulaRuc, ref string MensajeErrorOut);
      Boolean Modificar_GetContribuyente_Info(int IdEmpresa, string cedulaRuc, string mail, string password, ref string MensajeErrorOut);
      List<tb_Contribuyente_Info> GetListContribuyente(ref string MensajeErrorOut);
      bool ModificarDB(tb_Contribuyente_Info infoContribuyente, ref string mensajeErrorOut);
      sp_Registro_Contribuyente_Info Registrar_Contribuyente(int IdEmpresa, String CedulaRUc, String TipoComprobantes, String NumComprobante, String Correo, String Contrasenia, String HashText, ref String mensajeErrorOut);
      sp_ValidarRegistros_Info sp_ValidarRegistros(int IdEmpresa, String HashText, ref String mensajeErrorOut);
      sp_RecuperaciondeContraseña_Info sp_RecuperaciondeContraseña(int IdEmpresa, string CedulaRuc, ref String mensajeErrorOut);
      tb_Contribuyente_Info sp_VerificarRecuperaciondeContrasenia(int IdEmpresa, string @HashText, ref String mensajeErrorOut);
  }
}
