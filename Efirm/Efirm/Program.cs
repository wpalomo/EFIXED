using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmElect.Info;
using FirmElect.Bus;
using System.Diagnostics;
using MailEfirm.Forms;
using MailEfirm;
using System.Runtime.InteropServices;
using System.Security;

namespace Efirm
{
    static class Program
    {



        [System.Diagnostics.CodeAnalysis.SuppressMessage(
"Microsoft.Security",
"CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"),
SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
          "Microsoft.Security",
          "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"),
          SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        public static int AsignarConsola()
        {
            return AllocConsole() ? 0 : Marshal.GetLastWin32Error();
        }

        public static int LiberarConsola()
        {
            return FreeConsole() ? 0 : Marshal.GetLastWin32Error();
        }


        [STAThread]
        static void Main()
        {

            tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();
            try
            {


                // launch the WinForms application like normal
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);





                try
                {
                    cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;

                    cl_parametrosGenerales_Bus BusPara = new cl_parametrosGenerales_Bus();
                    string MensajeError = "";
                    BusPara.Cargar_Variables_Globales(ref MensajeError);

                    try
                    {
                        param.AUTORIZADO_ENVIO_CORREO = (Efirm.Properties.Settings.Default.AUTORIZADO_ENVIO_CORREO == "S") ? true : false;
                    }
                    catch (Exception EX)
                    {
                        param.AUTORIZADO_ENVIO_CORREO = false;
                        MessageBox.Show("No existe en el APP confign el parametro:   AUTORIZADO_ENVIO_CORREO  ");
                    }






                }
                catch (Exception ex)
                {

                }






                try
                {
                    if (Efirm.Properties.Settings.Default.MOSTRAR_CONSOLA == "S")
                    {
                        AsignarConsola();
                    }
                }
                catch (Exception ex)
                {


                }



                Application.Run(new frmseg_main());
               // Application.Run(new frmBuscar_comprobantes());

                try
                {
                    if (Efirm.Properties.Settings.Default.MOSTRAR_CONSOLA == "S")
                    {
                        LiberarConsola();
                    }
                }
                catch (Exception ex)
                {


                }
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message, eTipoError.ERROR_TRY, "");
            }
        }


      
    }
}
