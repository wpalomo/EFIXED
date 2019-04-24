using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FirmElect.Info;

using System.ComponentModel;



namespace FirmElect.Data
{
    public class tb_Empresa_Data
    {      
        //static cl_parametrosGenerales param = cl_parametrosGenerales.Instance;

        public int getId(ref string MensajeErrorOut)
        {
            int Id = 0;
            try
            {
                EntitiesFactElectronica contex = new EntitiesFactElectronica();
                var selecte = contex.tb_Empresa.Count();

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.tb_Empresa                                   
                                     select q.IdEmpresa).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {            
   
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return 0;
            }
        }

        public Boolean GuardarDB(List<tb_Empresa_Info> lista, ref string MensajeErrorOut) 
        {
            try
            {
                using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                {
                    tb_Empresa_Data odata = new tb_Empresa_Data();
                    foreach (var item in lista)
                    {                                        
                        if (item.IdEmpresAUX==null || item.IdEmpresAUX==0)
                        {
                          if (odata.GuardarDB(item, ref MensajeErrorOut))
                          {
                          }                       
                        }
                        else
                        {
                            //Actualiza                         
                            if (odata.ModificarDB(item, ref  MensajeErrorOut))
                            { }
                        }                       
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                //string MensajeErrorOut = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
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
                 using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
                 {                 
                             var Address = new tb_Empresa();
                            
                             Address.IdEmpresa = getId(ref MensajeErrorOut);
                             Address.RazonSocial = InfoEmpresa.RazonSocial;
                             Address.NombreComercial = InfoEmpresa.NombreComercial;
                             Address.RUC = InfoEmpresa.RUC;
                             Address.DirMatriz = InfoEmpresa.DirMatriz == null ? "" : InfoEmpresa.DirMatriz;
                             Address.ContribuyenteEspecial = InfoEmpresa.ContribuyenteEspecial;
                             Address.ObligadoAllevarConta = InfoEmpresa.ObligadoAllevarConta;
                             Address.NombreCertificado = InfoEmpresa.NombreCertificado == null ? "" : InfoEmpresa.NombreCertificado;
                             Address.Clave_Certificado = InfoEmpresa.Clave_Certificado == null ? "" : InfoEmpresa.Clave_Certificado;
                             //Address.IdAmbiente = InfoEmpresa.IdAmbiente;
                             //Address.TipoEmision = InfoEmpresa.TipoEmision;
                             Address.FechaValidez = InfoEmpresa.FechaValidez;
                             Address.Estado = true;
                             Address.logo = InfoEmpresa.logo;
                             Address.IdToquenAFirmar = InfoEmpresa.IdToquenAFirmar;
                             Address.Alias = InfoEmpresa.Alias;
                             Address.cod_Ambiente = InfoEmpresa.cod_Ambiente;
                             Address.cod_TipoEmision = InfoEmpresa.cod_TipoEmision;

                             Address.Nemonico_RIDE = InfoEmpresa.Nemonico_RIDE;

                             Address.Tipo_Notificacion_a_cliente = InfoEmpresa.Tipo_Notificacion_a_cliente;
                             Address.Cod_Empresa_Para_DB_Ext = InfoEmpresa.Cod_Empresa_Para_DB_Ext;
                             Address.cadena_conexion_Exterior = InfoEmpresa.cadena_conexion_Exterior;
                             Address.Tipo_Base_Exterior = InfoEmpresa.Tipo_Base_Exterior;

                             Address.Formato_fecha_Base_ext = InfoEmpresa.Formato_fecha_Base_ext;
                             Address.Formato_hora_Base_ext = InfoEmpresa.Formato_hora_Base_ext;

                             Address.url = InfoEmpresa.url;


                             Address.Nombre_tabla_Base_ext = InfoEmpresa.Nombre_tabla_Base_ext;

                             oEnti.tb_Empresa.Add(Address);
                             oEnti.SaveChanges();                       
                     }                
                 return true;
             }
             catch (Exception ex)
             {
                 //string MensajeErrorOut = "";
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
              using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
              {
                  var contact = oEnti.tb_Empresa.First(var => var.IdEmpresa == info.IdEmpresa );
              
                  contact.RazonSocial = info.RazonSocial;
                  contact.NombreComercial = info.NombreComercial;
                  contact.RUC = info.RUC;
                  contact.DirMatriz = info.DirMatriz ;
                  contact.ContribuyenteEspecial = info.ContribuyenteEspecial;
                  contact.ObligadoAllevarConta = info.ObligadoAllevarConta;
                  contact.NombreCertificado = info.NombreCertificado ;
                  contact.Clave_Certificado = info.Clave_Certificado;
                  //contact.IdAmbiente = info.IdAmbiente;
                  //contact.TipoEmision = info.TipoEmision;
                  contact.FechaValidez = info.FechaValidez;
                  contact.Estado = info.Estado;
                  contact.logo = info.logo;
                  contact.IdToquenAFirmar = info.IdToquenAFirmar;
                  contact.Alias = info.Alias;
                  contact.cod_Ambiente = info.cod_Ambiente;
                  contact.cod_TipoEmision = info.cod_TipoEmision;

                  contact.url = info.url;

                  contact.Nemonico_RIDE = info.Nemonico_RIDE;
                  contact.Tipo_Base_Exterior = info.Tipo_Base_Exterior;
                  contact.cadena_conexion_Exterior = info.cadena_conexion_Exterior;

                  contact.Formato_fecha_Base_ext = info.Formato_fecha_Base_ext;
                  contact.Formato_hora_Base_ext = info.Formato_hora_Base_ext;

                  contact.Nombre_tabla_Base_ext = info.Nombre_tabla_Base_ext;

              
                  oEnti.SaveChanges();               
              }
              return true;
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
              using (EntitiesFactElectronica oEnti = new EntitiesFactElectronica())
              {
                  var contact = oEnti.tb_Empresa.First(var => var.IdEmpresa == info.IdEmpresa);          
                  contact.Estado = false;
                 
                  oEnti.SaveChanges();
              }
              return true;
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
                using (EntitiesFactElectronica OEnti = new EntitiesFactElectronica())
                {
                    string queryDet = "delete from tb_Empresa";
                    OEnti.Database.ExecuteSqlCommand(queryDet);
                }

                return true;
            }
            catch (Exception ex)
            {

                string MensajeErrorOut = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
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
                 List<tb_Empresa_Info> Empresas= new List<tb_Empresa_Info>();
                 EntitiesFactElectronica OEselecEmpresa = new EntitiesFactElectronica();
                
                
var selectEmpresa = from C in OEselecEmpresa.tb_Empresa
                                     select C;

                 foreach (var item in selectEmpresa)
                 {
                     tb_Empresa_Info Cbt = new tb_Empresa_Info();

                     Cbt.IdEmpresa = item.IdEmpresa;
                     Cbt.RazonSocial = item.RazonSocial;
                     Cbt.NombreComercial = item.NombreComercial;
                     Cbt.RUC = item.RUC.Trim();
                     Cbt.DirMatriz = item.DirMatriz;
                     Cbt.ContribuyenteEspecial = item.ContribuyenteEspecial;
                     Cbt.ObligadoAllevarConta = item.ObligadoAllevarConta;
                     Cbt.NombreCertificado = item.NombreCertificado;
                     Cbt.Clave_Certificado = item.Clave_Certificado;
                     Cbt.FechaValidez = item.FechaValidez;
                     Cbt.Estado = item.Estado;
                     Cbt.logo = item.logo;
                     //Cbt.IdAmbiente = item.IdAmbiente;
                     //Cbt.TipoEmision = item.TipoEmision;
                     Cbt.IdToquenAFirmar = item.IdToquenAFirmar;
                     Cbt.cod_Ambiente = item.cod_Ambiente;
                     Cbt.cod_TipoEmision = item.cod_TipoEmision;
                     Cbt.Alias = item.Alias;
                     Cbt.IdEmpresAUX = item.IdEmpresa;
                     Cbt.Nemonico_RIDE=item.Nemonico_RIDE;
                     Cbt.url = item.url;
                     Cbt.Tipo_Base_Exterior = item.Tipo_Base_Exterior ;
                     Cbt.cadena_conexion_Exterior  = item.cadena_conexion_Exterior ;
                     Cbt.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;

                     Cbt.Formato_fecha_Base_ext = item.Formato_fecha_Base_ext;
                     Cbt.Formato_hora_Base_ext = item.Formato_hora_Base_ext;
                     Cbt.Nombre_tabla_Base_ext = item.Nombre_tabla_Base_ext;

                     Empresas.Add(Cbt);
                 }                       
                     return Empresas;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return new List<tb_Empresa_Info>();
            }
        }


        public List<tb_Empresa_Info> GetEmpresas_x_Alias(string alias,ref string MensajeErrorOut)
        {
            try
            {
                List<tb_Empresa_Info> Empresas = new List<tb_Empresa_Info>();
                EntitiesFactElectronica OEselecEmpresa = new EntitiesFactElectronica();
                var selectEmpresa = from C in OEselecEmpresa.tb_Empresa
                                    where C.Alias == alias
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Empresa_Info Cbt = new tb_Empresa_Info();

                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.RazonSocial = item.RazonSocial;
                    Cbt.logo = item.logo;
                    Cbt.Alias = item.Alias;
                    //Cbt.NombreComercial = item.NombreComercial;
                    //Cbt.RUC = item.RUC.Trim();
                    //Cbt.DirMatriz = item.DirMatriz;
                    //Cbt.ContribuyenteEspecial = item.ContribuyenteEspecial;
                    //Cbt.ObligadoAllevarConta = item.ObligadoAllevarConta;
                    //Cbt.NombreCertificado = item.NombreCertificado;
                    //Cbt.Clave_Certificado = item.Clave_Certificado;
                    //Cbt.FechaValidez = item.FechaValidez;
                    //Cbt.Estado = item.Estado;                   
                    //Cbt.IdAmbiente = item.IdAmbiente;
                    //Cbt.TipoEmision = item.TipoEmision;
                    //Cbt.IdToquenAFirmar = item.IdToquenAFirmar;
                    //Cbt.cod_Ambiente = item.cod_Ambiente;
                    //Cbt.cod_TipoEmision = item.cod_TipoEmision;
                    //Cbt.Alias = item.Alias;
                    //Cbt.IdEmpresAUX = item.IdEmpresa;
                    //Cbt.url = item.url;

                    Empresas.Add(Cbt);
                }
                return Empresas;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return new List<tb_Empresa_Info>();
            }
        }


        public List<tb_Empresa_Info> GetEmpresas_x_Url(string url, ref string MensajeErrorOut)
        {
            try
            {
                List<tb_Empresa_Info> Empresas = new List<tb_Empresa_Info>();
                EntitiesFactElectronica OEselecEmpresa = new EntitiesFactElectronica();
                var selectEmpresa = from C in OEselecEmpresa.tb_Empresa
                                    where C.url == url
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Empresa_Info Cbt = new tb_Empresa_Info();

                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.RazonSocial = item.RazonSocial;
                    Cbt.logo = item.logo;
                    //Cbt.NombreComercial = item.NombreComercial;
                    //Cbt.RUC = item.RUC.Trim();
                    //Cbt.DirMatriz = item.DirMatriz;
                    //Cbt.ContribuyenteEspecial = item.ContribuyenteEspecial;
                    //Cbt.ObligadoAllevarConta = item.ObligadoAllevarConta;
                    //Cbt.NombreCertificado = item.NombreCertificado;
                    //Cbt.Clave_Certificado = item.Clave_Certificado;
                    //Cbt.FechaValidez = item.FechaValidez;
                    //Cbt.Estado = item.Estado;                  
                    //Cbt.IdAmbiente = item.IdAmbiente;
                    //Cbt.TipoEmision = item.TipoEmision;
                    //Cbt.IdToquenAFirmar = item.IdToquenAFirmar;
                    //Cbt.cod_Ambiente = item.cod_Ambiente;
                    //Cbt.cod_TipoEmision = item.cod_TipoEmision;
                    //Cbt.Alias = item.Alias;
                    //Cbt.IdEmpresAUX = item.IdEmpresa;
                    //Cbt.url = item.url;

                    Empresas.Add(Cbt);
                }
                return Empresas;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return new List<tb_Empresa_Info>();
            }
        }


        public tb_Empresa_Info GetEmpresa(int IdEmpresa, ref string MensajeErrorOut)
        {
            try
            {
                tb_Empresa_Info Cbt = new tb_Empresa_Info();
                EntitiesFactElectronica OEselecEmpresa = new EntitiesFactElectronica();
                var selectEmpresa = from C in OEselecEmpresa.tb_Empresa
                                    where C.IdEmpresa == IdEmpresa
                                    select C;

                foreach (var item in selectEmpresa)
                {


                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.RazonSocial = item.RazonSocial;
                    Cbt.NombreComercial = item.NombreComercial;
                    Cbt.RUC = item.RUC.Trim();
                    Cbt.DirMatriz = item.DirMatriz;
                    Cbt.ContribuyenteEspecial = item.ContribuyenteEspecial;
                    Cbt.ObligadoAllevarConta = item.ObligadoAllevarConta;
                    Cbt.NombreCertificado = item.NombreCertificado;
                    Cbt.Clave_Certificado = item.Clave_Certificado;
                    Cbt.FechaValidez = item.FechaValidez;
                    Cbt.Estado = item.Estado;
                    Cbt.logo = item.logo;
                    Cbt.IdToquenAFirmar = item.IdToquenAFirmar;
                    Cbt.cod_Ambiente = item.cod_Ambiente;
                    Cbt.cod_TipoEmision = item.cod_TipoEmision;
                    Cbt.Alias = item.Alias;
                    Cbt.IdEmpresAUX = item.IdEmpresa;
                    Cbt.Nemonico_RIDE = item.Nemonico_RIDE;
                    Cbt.url = item.url;
                    Cbt.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                    Cbt.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                    Cbt.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;

                    Cbt.Formato_fecha_Base_ext = item.Formato_fecha_Base_ext;
                    Cbt.Formato_hora_Base_ext = item.Formato_hora_Base_ext;

                    Cbt.Nombre_tabla_Base_ext = item.Nombre_tabla_Base_ext;

                    
                }
                return Cbt;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeErrorOut);
                MensajeErrorOut = ex.InnerException + " " + ex.Message;

                return new Info.tb_Empresa_Info();
            }
        }


        public List<tb_Empresa_Info> get_list()
        {
            try
            {
                List<tb_Empresa_Info> Empresas = new List<tb_Empresa_Info>();
                EntitiesFactElectronica OEselecEmpresa = new EntitiesFactElectronica();


                var selectEmpresa = from C in OEselecEmpresa.tb_Empresa
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Empresa_Info Cbt = new tb_Empresa_Info();

                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.RazonSocial = item.RazonSocial;
                    Cbt.NombreComercial = item.NombreComercial;
                    Cbt.RUC = item.RUC.Trim();
                    Cbt.DirMatriz = item.DirMatriz;
                    Cbt.ContribuyenteEspecial = item.ContribuyenteEspecial;
                    Cbt.ObligadoAllevarConta = item.ObligadoAllevarConta;
                    Cbt.NombreCertificado = item.NombreCertificado;
                    Cbt.Clave_Certificado = item.Clave_Certificado;
                    Cbt.FechaValidez = item.FechaValidez;
                    Cbt.Estado = item.Estado;
                    Cbt.logo = item.logo;
                    //Cbt.IdAmbiente = item.IdAmbiente;
                    //Cbt.TipoEmision = item.TipoEmision;
                    Cbt.IdToquenAFirmar = item.IdToquenAFirmar;
                    Cbt.cod_Ambiente = item.cod_Ambiente;
                    Cbt.cod_TipoEmision = item.cod_TipoEmision;
                    Cbt.Alias = item.Alias;
                    Cbt.IdEmpresAUX = item.IdEmpresa;
                    Cbt.Nemonico_RIDE = item.Nemonico_RIDE;
                    Cbt.url = item.url;
                    Cbt.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                    Cbt.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                    Cbt.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;

                    Cbt.Formato_fecha_Base_ext = item.Formato_fecha_Base_ext;
                    Cbt.Formato_hora_Base_ext = item.Formato_hora_Base_ext;
                    Cbt.Nombre_tabla_Base_ext = item.Nombre_tabla_Base_ext;

                    Empresas.Add(Cbt);
                }
                return Empresas;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                    "", "", "", "", DateTime.Now);

                return new List<tb_Empresa_Info>();
            }
        }

    }
}
