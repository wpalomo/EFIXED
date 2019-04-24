using FirmElect.Data;
using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;


namespace FirmElect.Bus
{
    public class tb_Empresa_Bus
    {
        tb_Empresa_Data Data = new tb_Empresa_Data();

        public Boolean GuardarDB(List<tb_Empresa_Info> lista, ref string MensajeErrorOut)
        {
            try
            {
                return Data.GuardarDB(lista, ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                //string MensajeErrorOut = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),  eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return false;
            }
        }

        public Boolean GuardarDB(tb_Empresa_Info InfoEmpresa, ref string MensajeErrorOut)
       {
           try
           {
               return Data.GuardarDB(InfoEmpresa, ref MensajeErrorOut);
           }
           catch (Exception ex)
           {
               
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;

               return false;
           }
       }
        
        public Boolean ModificarDB(tb_Empresa_Info info, ref string MensajeErrorOut)
       {
           try
           {
               return Data.ModificarDB(info,ref MensajeErrorOut);
           }
           catch (Exception ex)
           {
              // string MensajeErrorOut = "";
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;
               return false;
           }
       }

        public Boolean AnularDB(tb_Empresa_Info info, ref string MensajeErrorOut)
       {
           try
           {
               return Data.AnularDB(info,ref  MensajeErrorOut);
           }
           catch (Exception ex)
           {
              // string MensajeErrorOut = "";
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
               MensajeErrorOut = ex.InnerException + " " + ex.Message;
               return false;
           }
       }

        public Boolean EliminarDB()
        {
            try
            {
                return Data.EliminarDB();
            }
            catch (Exception ex)
            {

                string MensajeErrorOut = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),  eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return false;
            }
        }

        public List<tb_Empresa_Info> GetEmpresas(ref string MensajeErrorOut)
        {
            try
            {
                return Data.GetEmpresas(ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                string mensajeErrorOut = "";
                #region Log de Errores
                mensajeErrorOut = ex.Message.ToString();
                tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensajeErrorOut,eTipoError.ERROR, this.ToString(), "",
                    "", "", "", "", DateTime.Now);
                oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                #endregion

                return new List<tb_Empresa_Info>();
            }            
        }

        public List<tb_Empresa_Info> GetEmpresas_x_Alias(string alias, ref string MensajeErrorOut)
        {
            try
            {
                return Data.GetEmpresas_x_Alias(alias,ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                string mensajeErrorOut = "";
                #region Log de Errores
                mensajeErrorOut = ex.Message.ToString();
                tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensajeErrorOut, eTipoError.ERROR, this.ToString(), "",
                    "", "", "", "", DateTime.Now);
                oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                #endregion

                return new List<tb_Empresa_Info>();
            }             
        }

        public List<tb_Empresa_Info> GetEmpresas_x_Url(string url, ref string MensajeErrorOut)
        {
            try
            {
                return Data.GetEmpresas_x_Url(url, ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                string mensajeErrorOut = "";
                #region Log de Errores
                mensajeErrorOut = ex.Message.ToString();
                tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensajeErrorOut, eTipoError.ERROR, this.ToString(), "",
                    "", "", "", "", DateTime.Now);
                oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                #endregion

                return new List<tb_Empresa_Info>();
            }      
        }

        public tb_Empresa_Info GetEmpresa(int IdEmpresa, ref string MensajeErrorOut)
        {
            try
            {
                return Data.GetEmpresa(IdEmpresa, ref MensajeErrorOut);
            }
            catch (Exception ex)
            {
                string mensajeErrorOut = "";
                #region Log de Errores
                mensajeErrorOut = ex.Message.ToString();
                tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensajeErrorOut, eTipoError.ERROR, this.ToString(), "",
                    "", "", "", "", DateTime.Now);
                oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                #endregion

                return new tb_Empresa_Info();
            }      
        
        }


        public List<tb_Empresa_Info> ValidarFechaCertificado()
        {
            try
            {
                string MensajeErrorOut = "";
                DateTime FechaActual = Convert.ToDateTime(DateTime.Now.ToShortDateString());                
                int DiasExpirar = 0;
                List<tb_Empresa_Info> lstEmpresa = new List<tb_Empresa_Info>();
                lstEmpresa = Data.GetEmpresas(ref MensajeErrorOut);

                foreach (var item in lstEmpresa)
                {
                    tb_Empresa_Info Info = new tb_Empresa_Info();
                    DiasExpirar = 0;
                    DateTime FechaValidez = Convert.ToDateTime(Convert.ToDateTime(item.FechaValidez).ToShortDateString());
                    DiasExpirar = (FechaValidez - FechaActual).Days;
                    
                    if (DiasExpirar <= 30)
                    {
                        Info = item;
                        Info.DiasExpirar = item.DiasExpirar;
                        lstEmpresa.Add(Info);
                    }
                }

                return lstEmpresa;
            }
            catch (Exception ex)
            {
                string mensajeErrorOut = "";
                #region Log de Errores
                mensajeErrorOut = ex.Message.ToString();
                tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensajeErrorOut, eTipoError.ERROR, this.ToString(), "",
                    "", "", "", "", DateTime.Now);
                oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                #endregion

                return new List<tb_Empresa_Info>();
            }
        }

        //
        public List<tb_Empresa_Info> get_list()
        {
            try
            {
                return Data.get_list();
            }
            catch (Exception ex)
            {
                string mensajeErrorOut = "";
                #region Log de Errores
                mensajeErrorOut = ex.Message.ToString();
                tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensajeErrorOut, eTipoError.ERROR, this.ToString(), "",
                    "", "", "", "", DateTime.Now);
                oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
                #endregion

                return new List<tb_Empresa_Info>();
            }
        }

    }
}
