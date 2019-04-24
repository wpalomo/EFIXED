using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;


namespace FirmElect.Bus
{
    public class tb_Comprobante_Procesos_externos_Bus
    {
        Itb_Comprobante_Procesos_externos Odata;

        tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
        List<tb_Empresa_Info> listEmpresas = new List<tb_Empresa_Info>();
        
        public tb_Comprobante_Procesos_externos_Bus(List<tb_Empresa_Info> _listEmpresas)
        {
            listEmpresas = _listEmpresas;
        }


        public bool GrabarDB(Info.tb_Comprobante_Info InfoCbte, ref string MensajeErrorOut)
        {

            try
            {
                var quer = from C in listEmpresas
                           where C.IdEmpresa == InfoCbte.IdEmpresa
                           select C;

                string Cod_Insercion = "";
                string cadena = "";
                foreach (var item in quer)
                {
                    Cod_Insercion = item.Cod_Empresa_Para_DB_Ext;
                    cadena = item.cadena_conexion_Exterior;
                }

                if ((Cod_Insercion != null) || (Cod_Insercion != ""))
                {

                    switch (Cod_Insercion)
                    {
                      
                        case "EXPOG":
                            Odata = new tb_Comprobante_Procesos_externos_ExpoGye();
                            return Odata.GrabarDB(InfoCbte, ref MensajeErrorOut, cadena);
                     
                       
                        case "ALEMA":
                            Odata = new tb_Comprobante_Procesos_externos_ALEMAN();
                            return Odata.GrabarDB(InfoCbte, ref MensajeErrorOut, cadena);
                       
                       
                        case "GRAFI":
                            Odata = new tb_Comprobante_Procesos_externos_GRAFINPREN();
                            return Odata.GrabarDB(InfoCbte, ref MensajeErrorOut, cadena);

                        case "FIXED":
                            Odata = new tb_Comprobante_Procesos_externos_GRAFINPREN();
                            return Odata.GrabarDB(InfoCbte, ref MensajeErrorOut, cadena);
                       
                    }
                    return true;
                }
                else
                {
                    MensajeErrorOut = "No hay parametros  en la tabla de empresa para configurar la insercion";
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;

            }
        }


        public List<tb_Comprobante_Info> Consultar(int IdEmpresa, ref string MensajeErrorOut)
        {
            try
            {
            
                var quer = from C in listEmpresas
                           where C.IdEmpresa == IdEmpresa
                           select C;

                string Cod_Insercion = "";
                string cadena_conexion = "";
                foreach (var item in quer)
                {
                    Cod_Insercion = item.Cod_Empresa_Para_DB_Ext;
                    cadena_conexion = item.cadena_conexion_Exterior;

                }


                if ((Cod_Insercion != null) || (Cod_Insercion != ""))
                {

                    switch (Cod_Insercion)
                    {
                       
                        case "EXPOG":
                            Odata = new tb_Comprobante_Procesos_externos_ExpoGye();
                            return Odata.Consultar(IdEmpresa, ref MensajeErrorOut, cadena_conexion);
                      
                        case "NATUR":
                            Odata = new tb_Comprobante_Procesos_externos_NATURISA();
                            return Odata.Consultar(IdEmpresa, ref MensajeErrorOut, cadena_conexion);
                        case "GRAFI":
                            Odata = new tb_Comprobante_Procesos_externos_GRAFINPREN();
                            return Odata.Consultar(IdEmpresa, ref MensajeErrorOut, cadena_conexion);
                        case "FIXED":
                            Odata = new tb_Comprobante_Procesos_externos_GRAFINPREN();
                            return Odata.Consultar(IdEmpresa, ref MensajeErrorOut, cadena_conexion);
                      
                        
                    }

                    return new List<tb_Comprobante_Info>();
                }
                else
                {
                    MensajeErrorOut = "No hay parametros  en la tabla de empresa para configurar la insercion";
                    return new List<tb_Comprobante_Info>();
                }

                

                }
                catch (Exception ex)
                {

                    return new List<tb_Comprobante_Info>();  
                }
        }

    }

}
