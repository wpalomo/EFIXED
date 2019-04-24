using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FirmElect.Info;


namespace FirmElect.Bus
{

    public class cl_parametrosGenerales_Bus
    {

        static cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;


        public cl_parametrosGenerales_Bus()
        {

        }
        

        public  bool Cargar_Variables_Globales(ref string MensajeError)
        {
            try 
	        {
                tb_directorio_Bus BusDirectorios = new tb_directorio_Bus();
                List<tb_directorio_Info> listDirectorios = new List<tb_directorio_Info>();
                tb_Parametro_Bus BusParametros = new tb_Parametro_Bus();
                tb_Parametro_Info InfoParametro = new tb_Parametro_Info();

                tb_Empresa_Bus EmpresBus= new tb_Empresa_Bus();



                //string mensajeErrorOut = "";

                

                InfoParametro = BusParametros.consultar(ref MensajeError);

                param.Parametro_Info = InfoParametro;


                param.G_listEmpresas = EmpresBus.GetEmpresas(ref MensajeError);

                mail_Parametro_Bus BusParamMail = new mail_Parametro_Bus();
                param.InfoParametrosMail = BusParamMail.consultar(ref MensajeError);


                listDirectorios = BusDirectorios.Consultar(ref MensajeError);

                param.RutaPrincipal = listDirectorios.FirstOrDefault(v => v.IdTipoDirectorio == "ROOT").Ruta_directorio;
                param.RutaCertificados = listDirectorios.FirstOrDefault(v => v.IdTipoDirectorio == "CERTI").Ruta_directorio;
                param.RutaComprobantesRepositorio = listDirectorios.FirstOrDefault(v => v.IdTipoDirectorio == "REPO").Ruta_directorio;
                param.RutaComprobantesValidos = listDirectorios.FirstOrDefault(v => v.IdTipoDirectorio == "CBTE_VALID").Ruta_directorio;
                param.RutaComprobantes_con_Errores = listDirectorios.FirstOrDefault(v => v.IdTipoDirectorio == "CBTES_CON_ERROR").Ruta_directorio;

                
               
                




                return true;
	        }
	        catch (Exception ex)
	        {
                MensajeError = MensajeError + " error al cargar parametros generale de carpetas" + ex.Message +  " " + ex.InnerException;
                return false;
	        }
        }

    }

}
