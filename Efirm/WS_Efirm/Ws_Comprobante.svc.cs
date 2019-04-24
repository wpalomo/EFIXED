using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using FirmElect.Info;
using FirmElect.Bus;
using System.IO;
using FirmElect.Reports;

using DevExpress.XtraReports.UI;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using DevExpress.XtraPrinting;




namespace WS_Efirm
{
    //nuevo
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ws_Comprobante" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ws_Comprobante.svc o Ws_Comprobante.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Ws_Comprobante : IWs_Comprobante
    {
        tb_Comprobante_Bus busCbte = new tb_Comprobante_Bus();
        tb_Catalogo_Bus busCatalogo = new tb_Catalogo_Bus();

        public List<tb_Catalogo_Info> Lista_TipoComprobantes(ref string MensajeErrorOut)
        {
            try
            {
                

                
                return busCatalogo.Lista_TipoComprobantes(ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                return new List<tb_Catalogo_Info>();
            }
        }

        public List<tb_Comprobante_Info> consultar_listado_comprobantes(int IdEmpresa, string cedulaRuc, string TipoComprobante, DateTime FecIni, DateTime FecFin
            , string buscar
            ,int Indice_Pagina, int Tamanio_Pagina, ref string mensajeErrorOut)
        {
            try
            {
                return busCbte.consultar_listado_comprobantes_x_web (IdEmpresa, cedulaRuc, TipoComprobante, FecIni, FecFin, buscar,Indice_Pagina,Tamanio_Pagina, ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                return new List<tb_Comprobante_Info>();
            }
        }

        public string getXML(int IdEmpresa, string cedulaRuc, string IdComprobante, ref string mensajeErrorOut)
        {
            try
            {
                return busCbte.getXML(IdEmpresa, cedulaRuc, IdComprobante, ref mensajeErrorOut);
            }
            catch (Exception ex)
            {

                return null;
            }
        }
                       
        //public void DoWork()
        //{
        //}

        public byte[] getRide_Pdf(int IdEmpresa, string cedulaRuc, string IdComprobante)       
        {
            try
            {

                XtraReport Reporte = new XtraReport();
                string msg = "";
                string RutaFile = Path.GetTempPath();

                tb_Comprobante_Info InfoCbteT = new tb_Comprobante_Info();
                tb_Comprobante_Bus BuscCbte = new tb_Comprobante_Bus();
                List<tb_Empresa_Info> listEmpres= new List<tb_Empresa_Info>();
                listEmpres = new tb_Empresa_Bus().GetEmpresas(ref msg);


                Rpt_Ride_bus Rpt_Ride_Bus = new Rpt_Ride_bus(listEmpres);

                //hacer consulta
                InfoCbteT = BuscCbte.consulta_PDF_info(IdEmpresa, cedulaRuc, IdComprobante, ref msg);

                Reporte = Rpt_Ride_Bus.Optener_reporte(InfoCbteT, ref msg); //FAct Imporpoint
                
                Stream FileBinary;

                RutaFile = RutaFile + "\\"+ InfoCbteT.IdComprobante + ".pdf";

                FileBinary = new FileStream(RutaFile, FileMode.Create);
               
                Reporte.ExportToPdf(FileBinary);
                FileBinary.Close();

               /// leer pdf en memoria 
               /// 

                byte[] bytes;

                using (FileStream fsSource = new FileStream(RutaFile,
           FileMode.Open, FileAccess.Read))
                {

                    // Read the source file into a byte array.
                    bytes = new byte[fsSource.Length];
                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;

                    
                }



                return bytes;
               
            }
            catch (Exception ex)
            {

                return null;
                    
            }

        }


     



    }
}
