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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ws_Empresa" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ws_Empresa.svc o Ws_Empresa.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Ws_Empresa : IWs_Empresa
    {

        tb_Empresa_Bus ObusEmpresa = new tb_Empresa_Bus();

        public List<tb_Empresa_Info> GetEmpresas(ref string MensajeErrorOut)
        {
            try
            {
                return ObusEmpresa.GetEmpresas(ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                return new List<tb_Empresa_Info>();
            }

        }

        public bool GrabarDB(tb_Empresa_Info InfoEmpresa, ref string MensajeErrorOut)
        {
            try
            {
                return ObusEmpresa.GuardarDB(InfoEmpresa, ref MensajeErrorOut);

            }
            catch (Exception ex)
            {
                return false;

            }
        }

        //haac
        public List<tb_Empresa_Info> GetEmpresas_x_Alias(string alias, ref string MensajeErrorOut)
        {
            try
            {
                return ObusEmpresa.GetEmpresas_x_Alias(alias, ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                return new List<tb_Empresa_Info>();
            }

        }

        public List<tb_Empresa_Info> GetEmpresas_x_Url(string url, ref string MensajeErrorOut)
        {
            try
            {
                return ObusEmpresa.GetEmpresas_x_Url(url, ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                return new List<tb_Empresa_Info>();
            }

        }        
        //public void DoWork()
        //{
        //}
    }
}
