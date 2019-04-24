using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using FirmElect.Info;
using FirmElect.Bus;


namespace WS_Efirm
{
    //nuevo
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ws_Contribuyente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ws_Contribuyente.svc o Ws_Contribuyente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Ws_Contribuyente : IWs_Contribuyente
    {
        tb_Contribuyente_Bus busContri = new tb_Contribuyente_Bus();


        public List<tb_Contribuyente_Info> GetContribuyente(int IdEmpresa, string cedulaRuc, string password, ref string MensajeErrorOut)
        {
            try
            {
                return busContri.GetContribuyente(IdEmpresa, cedulaRuc, password, ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                return new List<tb_Contribuyente_Info>();
            }

        }

        public tb_Contribuyente_Info GetContribuyente_Info(int IdEmpresa, string cedulaRuc, ref string MensajeErrorOut)
        {
            try
            {
                return busContri.GetContribuyente_Info(IdEmpresa, cedulaRuc, ref MensajeErrorOut);
            }
            catch (Exception ex)
            {

                return new tb_Contribuyente_Info();
            }
        }


        public Boolean Modificar_GetContribuyente_Info(int IdEmpresa, string cedulaRuc, string mail, string password, ref string MensajeErrorOut)
        {
            try
            {
                return busContri.Modificar_GetContribuyente_Info(IdEmpresa, cedulaRuc, mail, password, ref MensajeErrorOut);
            }
            catch (Exception ex)
            {

                return false;
            }
        }             
                     
        //public void DoWork()
        //{
        //}


        public sp_Registro_Contribuyente_Info Registrar_Contribuyente(int IdEmpresa, string CedulaRUc, string TipoComprobantes, string NumComprobante, string Correo, string Contrasenia, string Link, ref string mensajeErrorOut)
        {
            try
            {
                return busContri.Registrar_Contribuyente(IdEmpresa, CedulaRUc, TipoComprobantes, NumComprobante, Correo, Contrasenia, Link, ref mensajeErrorOut);
            }
            catch (Exception)
            {

                return new sp_Registro_Contribuyente_Info();
            }
        }


        public sp_ValidarRegistros_Info sp_ValidarRegistros(int IdEmpresa, string HashText, ref string mensajeErrorOut)
        {
            try
            {
                return busContri.sp_ValidarRegistros(IdEmpresa ,HashText, ref mensajeErrorOut);
            }
            catch (Exception)
            {

                return new sp_ValidarRegistros_Info();
            }
        }


        public sp_RecuperaciondeContraseña_Info sp_RecuperaciondeContraseña(int IdEmpresa, string CedulaRuc, string Link, ref string mensajeErrorOut)
        {
            try
            {
                return busContri. sp_RecuperaciondeContraseña(IdEmpresa, CedulaRuc, Link, ref mensajeErrorOut);
            }
            catch (Exception)
            {

                return new sp_RecuperaciondeContraseña_Info();
            }
        }

        public tb_Contribuyente_Info sp_VerificarRecuperaciondeContrasenia(int IdEmpresa, string HashText, ref string mensajeErrorOut)
        {
            try
            {
                return busContri.sp_VerificarRecuperaciondeContrasenia(IdEmpresa, HashText, ref mensajeErrorOut);
            }
            catch (Exception)
            {

                return new tb_Contribuyente_Info();
            }
        }


        public tb_Contribuyente_Info Test_Efirm(ref string mensajeErrorOut)
        {
            return new tb_Contribuyente_Info(0, 0, "", "prueba", "", "");
        }
    }
}
