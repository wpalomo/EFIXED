using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using System.Data.SqlClient;
using System.Data;
using System.Data.Objects;
using FirmElect.Data;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info.class_sri.Retencion;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FirmElect.Data
{
   public class tb_Comprobante_Data
    {

       string mensaje = "";
       //static cl_parametrosGenerales param = cl_parametrosGenerales.Instance;

       public tb_Comprobante_Data()
       {

       }

       public Boolean GrabarDB(tb_Comprobante_Info Comprobante_info, ref string mensajeErrorOut)
       {
           try
           {               
               using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
               {

                   var Address = new tb_Comprobante();

                   Address.IdEmpresa = Comprobante_info.IdEmpresa;
                   Address.IdComprobante = Comprobante_info.IdComprobante;
                   Address.IdTipoDocumento = Comprobante_info.IdTipoDocumento;
                   Address.IdEstado_cbte = Comprobante_info.IdEstado_cbte;
                   Address.Cedula_Ruc = Comprobante_info.Cedula_Ruc;
                   Address.s_XML = Comprobante_info.s_XML;
                   Address.Fecha_Emi_Fact = Comprobante_info.Fecha_Emi_Fact;
                   Address.Fecha_transaccion = DateTime.Now;
                   Address.ClaveContingencia = Comprobante_info.ClaveContingencia;
                   Address.RutaArchivo = Comprobante_info.RutaArchivo;
                   Address.EstadoDoc = Comprobante_info.EstadoDoc;
                   Address.Error = Comprobante_info.Error;
                   Address.IdEstadoProceso = Comprobante_info.IdEstadoProceso;
                   Address.IdError_Sri = Comprobante_info.IdError_Sri;
                   Address.Nombre_file = Comprobante_info.Nombre_file;
                   Address.RespuestaSRI = Comprobante_info.RespuestaSRI;
                   Address.Total = Comprobante_info.Total;
                   Address.Ambiente = Comprobante_info.Ambiente;
                   Address.Clave_Acceso = Comprobante_info.Clave_Acceso;

                   Address.Numero_Autorizacion = Comprobante_info.Numero_Autorizacion;
                   Address.FechaAutorizacion = Comprobante_info.FechaAutorizacion;

                   Context.tb_Comprobante.Add(Address);
                   Context.SaveChanges();
                   mensajeErrorOut = "Proceso OK";


                   if (Comprobante_info.IdEstado_cbte == "")
                   { 
                   
                   }


               }

               return true;
           }
           catch (Exception ex)
           {
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, mensajeErrorOut, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);            
               return false;
           }
       
       }

       public Boolean ModificarErrorDB(int IdEmpresa,string IdComprobante,string IdTipoDocumento
           , string IdEstado_cbte, string IdError_sri, string Error, string sRespuestaWS_sri, ref string mensajeErrorOut)
       {
           try
           {
               using (EntitiesFactElectronica DbFactElec = new EntitiesFactElectronica())
               {

                   var resultado = DbFactElec.tb_Comprobante.First(v => v.IdEmpresa == IdEmpresa
                       && v.IdComprobante == IdComprobante
                       && v.IdTipoDocumento == IdTipoDocumento
                       && v.IdEstado_cbte == IdEstado_cbte);

                   long IdErrornumber = 0;
                   bool SIdError = long.TryParse(IdError_sri, out IdErrornumber);

                   resultado.IdError_Sri = (SIdError == true) ? IdError_sri : null;
                   resultado.Error = Error;
                   resultado.RespuestaSRI = sRespuestaWS_sri;

                   DbFactElec.SaveChanges();
                   mensajeErrorOut = "Proceso OK";
                   
               }
               return true;               
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;

               mensajeErrorOut = mensaje;

               return false;               
           }
       }

       public Boolean ModificarDB(int IdEmpresa, string IdComprobante, string IdTipoDocumento
           , string IdEstado_cbte, string sRespuestaXmlSRI, string EstadoDoc, eIdEstadoProceso IdEstadoProceso, ref string mensajeErrorOut)
       {
           try
           {
               using (EntitiesFactElectronica DbFactElec = new EntitiesFactElectronica())
               {

                   var resultado = DbFactElec.tb_Comprobante.First(v => v.IdEmpresa == IdEmpresa
                       && v.IdComprobante == IdComprobante
                       && v.IdTipoDocumento == IdTipoDocumento
                       && v.IdEstado_cbte == IdEstado_cbte
                       && v.IdEstadoProceso == "PEND");

                       resultado.RespuestaSRI = sRespuestaXmlSRI;
                       resultado.EstadoDoc = EstadoDoc;
                       resultado.IdEstadoProceso = IdEstadoProceso.ToString();
                       //DbFactElec.tb_Comprobante.Remove(resultado);
                       DbFactElec.SaveChanges();
                       mensajeErrorOut = "Proceso OK";

               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = mensaje;
               return false;
           }
       }

       public int getSecuencial(int idempresa, string IdComprobante, string IdTipoDocumento, string IdEstado_cbte)
       {
           try
           {
               int Id=0;

               EntitiesFactElectronica OECompras = new EntitiesFactElectronica();
               var select = from q in OECompras.tb_Comprobante
                            where q.IdEmpresa == idempresa
                                    && q.IdComprobante == IdComprobante
                                    && q.IdTipoDocumento == IdTipoDocumento
                                    && q.IdEstado_cbte == IdEstado_cbte
                            select q;

               if (select.ToList().Count < 1)
               {
                   Id = 1;
               }
               else
               {
                   var select_pv = (from q in OECompras.tb_Comprobante
                                    where q.IdEmpresa == idempresa
                                    && q.IdComprobante == IdComprobante
                                    && q.IdTipoDocumento == IdTipoDocumento
                                    && q.IdEstado_cbte == IdEstado_cbte
                                    select q.IdEmpresa).Count();
                   Id = Convert.ToInt32(select_pv.ToString()) + 1;
                   Id = (Id == 0) ? 1 : Id;
               }
               return Id;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;

               return 1;
           }

       }


       public List<tb_Comprobante_Info> consultar_listado_cbte(int IdEmpresaIni,int IdEmpresaFin,string IdTipoDocIni,string IdTipoDocFin, int Pagina, int Reg_X_Pag, DateTime FechaIni,DateTime FechaFin,List<string> ListadoEstadoCbte,
           string Stipo_Autorizacion, string IdEstadoProceso, string CadenaBusqueda, ref string mensajeErrorOut)
       {

           try
           {

               List<tb_Comprobante_Info> lista= new List<tb_Comprobante_Info>();

               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

             
                   using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                   {

                       string sql="exec actualizar_valores";
                       conexion.Database.ExecuteSqlCommand(sql);

                       //var q = from C in conexion.sp_consulta_x_CbteVALI_FIRM_REC_x_Pagina(IdEmpresaIni, IdEmpresaFin, IdTipoDocIni, IdTipoDocFin, Pagina, Reg_X_Pag, FechaIni, FechaFin, "VALI_&_FIRM_&_REC", Stipo_Autorizacion, "PROCE", CadenaBusqueda)
                       //        select
                       //        C;


                       lista = ( from q in conexion.sp_consulta_x_CbteVALI_FIRM_REC_x_Pagina(IdEmpresaIni,IdEmpresaFin,IdTipoDocIni,IdTipoDocFin, Pagina, Reg_X_Pag, FechaIni, FechaFin, "VALI_&_FIRM_&_REC", Stipo_Autorizacion, "PROCE", CadenaBusqueda)
                            select new tb_Comprobante_Info
                            {

                           NumFila = q.RowNum,
                           IdEmpresa = q.IdEmpresa,
                           IdComprobante = q.IdComprobante,
                           IdTipoDocumento = q.IdTipoDocumento,
                           IdEstado_cbte = q.IdEstado_cbte,
                           Cedula_Ruc = q.Cedula_Ruc,
                           Numero_Autorizacion = q.Numero_Autorizacion,
                           RutaArchivo = q.RutaArchivo,
                           Nombre_file = q.Nombre_file,
                           s_XML = "xml",//NO LLENAR ESTE CAMPO PUES ES MUY GRANDE Y COLAPSA LA BASE
                           Fecha_Emi_Fact = q.Fecha_Emi_Fact,
                           Fecha_transaccion = q.Fecha_transaccion,
                           sFecha_transaccion = (q.Fecha_transaccion == null) ? "" : q.Fecha_transaccion.ToString(),
                           FechaAutorizacion = q.FechaAutorizacion,
                           //IdEstadoDeEnvio = q.IdEstadoDeEnvio,
                           ClaveContingencia = q.ClaveContingencia,
                           EstadoDoc = q.EstadoDoc,
                           Error = q.Error,
                           IdEstadoProceso = q.IdEstadoProceso,
                           IdError_Sri = q.IdError_Sri,
                           Nom_emisor = q.Nom_emisor,
                           Nom_TipoDocumento = q.Nom_Tipo_doc,
                           Nom_estado_doc = q.Nom_estado_doc,
                           RespuestaSRI = q.RespuestaSRI,
                           sFechaAutorizacion = (q.FechaAutorizacion == null) ? "" : q.FechaAutorizacion.ToString(),

                           MosTrar_icono_Ride = true,
                           MosTrar_icono_xml = true,
                           Mostrar_Icon_Eliminar = true,
                           Ambiente = q.Ambiente,
                           Clave_Acceso = q.Clave_Acceso,
                           Nom_Contribuyente = q.Nom_Contribuyente,
                           //Total=q.
                           Tipo_Base_Exterior = q.Tipo_Base_Exterior,
                           cadena_conexion_Exterior = q.cadena_conexion_Exterior,
                           Cod_Empresa_Para_DB_Ext = q.Cod_Empresa_Para_DB_Ext,
                           Total = q.Total,

                       }).ToList();
                   }

               mensajeErrorOut = "Proceso OK";

               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = mensaje;
               
               return new List<tb_Comprobante_Info>();
           }      
       }



       public List<tb_Comprobante_Info> consultar_listado_cbte_Pendientes_x_Autoriza( DateTime FechaIni, DateTime FechaFin, List<string> ListadoEstadoCbte,
          string Stipo_Autorizacion, string IdEstadoProceso, string CadenaBusqueda, ref string mensajeErrorOut)
       {

           try
           {
               List<tb_Comprobante_Info> lista = new List<tb_Comprobante_Info>();

               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


               #region "Cuando && C.EstadoDoc== Stipo_Autorizacion"

               if (Stipo_Autorizacion.Length > 0)
               {

                   using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                   {


                              var q = from C in conexion.vw_Comprobante
                               where ListadoEstadoCbte.Contains(C.IdEstado_cbte)
                               && C.IdEstadoProceso.Contains(IdEstadoProceso)
                               && C.Fecha_Emi_Fact >= FechaIni && C.Fecha_Emi_Fact <= FechaFin
                               && C.EstadoDoc == Stipo_Autorizacion
                               select new
                               {
                                   C.IdEmpresa,
                                   C.IdComprobante,
                                   C.IdTipoDocumento,
                                   C.IdEstado_cbte,
                                   C.Cedula_Ruc,
                                   C.Numero_Autorizacion,
                                   C.RutaArchivo,
                                   C.Nombre_file,
                                   C.Fecha_Emi_Fact,
                                   C.Fecha_transaccion,
                                   C.FechaAutorizacion,
                                   C.ClaveContingencia,
                                   C.EstadoDoc,
                                   C.Error,
                                   C.IdError_Sri,
                                   C.Nom_emisor,
                                   C.Nom_Tipo_doc,
                                   C.Nom_estado_doc,
                                   C.IdEstadoProceso,
                                   C.RespuestaSRI,
                                   C.Ambiente,
                                   C.Clave_Acceso,
                                   C.Nom_Contribuyente,
                                   C.Tipo_Base_Exterior,
                                   C.cadena_conexion_Exterior,
                                   C.Cod_Empresa_Para_DB_Ext,
                                   C.Total
                               };




                       foreach (var item in q)
                       {
                           tb_Comprobante_Info infoC = new tb_Comprobante_Info();

                           infoC.IdEmpresa = item.IdEmpresa;
                           infoC.IdComprobante = item.IdComprobante;
                           infoC.IdTipoDocumento = item.IdTipoDocumento;
                           infoC.IdEstado_cbte = item.IdEstado_cbte;
                           infoC.Cedula_Ruc = item.Cedula_Ruc;
                           infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                           infoC.RutaArchivo = item.RutaArchivo;
                           infoC.Nombre_file = item.Nombre_file;
                           infoC.s_XML = "xml";//NO LLENAR ESTE CAMPO PUES ES MUY GRANDE Y COLAPSA LA BASE
                           infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                           infoC.Fecha_transaccion = item.Fecha_transaccion;
                           infoC.sFecha_transaccion = (item.Fecha_transaccion == null) ? "" : item.Fecha_transaccion.ToString();
                           infoC.FechaAutorizacion = item.FechaAutorizacion;
                           //infoC.IdEstadoDeEnvio = item.IdEstadoDeEnvio;
                           infoC.ClaveContingencia = item.ClaveContingencia;
                           infoC.EstadoDoc = item.EstadoDoc;
                           infoC.Error = item.Error;
                           infoC.IdEstadoProceso = item.IdEstadoProceso;
                           infoC.IdError_Sri = item.IdError_Sri;
                           infoC.Nom_emisor = item.Nom_emisor;
                           infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                           infoC.Nom_estado_doc = item.Nom_estado_doc;
                           infoC.RespuestaSRI = item.RespuestaSRI;
                           infoC.sFechaAutorizacion = (item.FechaAutorizacion == null) ? "" : item.FechaAutorizacion.ToString();

                           infoC.MosTrar_icono_Ride = true;
                           infoC.MosTrar_icono_xml = true;
                           infoC.Mostrar_Icon_Eliminar = true;
                           infoC.Ambiente = item.Ambiente;
                           infoC.Clave_Acceso = item.Clave_Acceso;
                           infoC.Nom_Contribuyente = item.Nom_Contribuyente;

                           infoC.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                           infoC.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                           infoC.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;
                           infoC.Total=item.Total;

                           lista.Add(infoC);
                       }

                       //traigo los cbtes cuya fecha de emision sea null

                       var q2 = from C in conexion.vw_Comprobante
                                where ListadoEstadoCbte.Contains(C.IdEstado_cbte)
                                && C.EstadoDoc == Stipo_Autorizacion
                                && C.Fecha_Emi_Fact == null
                                select new
                                {
                                    C.IdEmpresa,
                                    C.IdComprobante,
                                    C.IdTipoDocumento,
                                    C.IdEstado_cbte,
                                    C.Cedula_Ruc,
                                    C.Numero_Autorizacion,
                                    C.RutaArchivo,
                                    C.Nombre_file,
                                    C.Fecha_Emi_Fact,
                                    C.Fecha_transaccion,
                                    C.FechaAutorizacion,
                                    C.ClaveContingencia,
                                    C.EstadoDoc,
                                    C.Error,
                                    C.IdError_Sri,
                                    C.Nom_emisor,
                                    C.Nom_Tipo_doc,
                                    C.Nom_estado_doc,
                                    C.IdEstadoProceso,
                                    C.RespuestaSRI,
                                    C.Ambiente,
                                    C.Clave_Acceso,
                                    C.Nom_Contribuyente,
                                    C.Tipo_Base_Exterior,
                                    C.cadena_conexion_Exterior,
                                    C.Cod_Empresa_Para_DB_Ext,
                                    C.Total
                                };


                       foreach (var item in q2)
                       {
                           tb_Comprobante_Info infoC = new tb_Comprobante_Info();

                           infoC.IdEmpresa = item.IdEmpresa;
                           infoC.IdComprobante = item.IdComprobante;
                           infoC.IdTipoDocumento = item.IdTipoDocumento;
                           infoC.IdEstado_cbte = item.IdEstado_cbte;
                           //infoC.secuencial = item.secuencial;
                           infoC.Cedula_Ruc = item.Cedula_Ruc;
                           infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                           infoC.RutaArchivo = item.RutaArchivo;
                           infoC.Nombre_file = item.Nombre_file;
                           infoC.s_XML = "xml";
                           infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                           infoC.Fecha_transaccion = item.Fecha_transaccion;
                           infoC.FechaAutorizacion = item.FechaAutorizacion;
                           //infoC.IdEstadoDeEnvio = item.IdEstadoDeEnvio;
                           infoC.ClaveContingencia = item.ClaveContingencia;
                           infoC.EstadoDoc = item.EstadoDoc;
                           infoC.Error = item.Error;
                           infoC.IdEstadoProceso = item.IdEstadoProceso;
                           infoC.IdError_Sri = item.IdError_Sri;
                           infoC.Nom_emisor = item.Nom_emisor;
                           infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                           infoC.Nom_estado_doc = item.Nom_estado_doc;
                           infoC.RespuestaSRI = item.RespuestaSRI;

                           infoC.MosTrar_icono_Ride = true;
                           infoC.MosTrar_icono_xml = true;
                           infoC.Mostrar_Icon_Eliminar = true;

                           infoC.Clave_Acceso = item.Clave_Acceso;

                           infoC.Ambiente = item.Ambiente;
                           infoC.Nom_Contribuyente = item.Nom_Contribuyente;

                           infoC.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                           infoC.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                           infoC.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;
                           infoC.Total=item.Total;

                           lista.Add(infoC);
                       }

                   }

               }

               #endregion

               #region cuando Stipo_Autorizacion="" osea todos

               if (Stipo_Autorizacion.Length == 0)
               {

                   using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                   {



                       var q = from C in conexion.vw_Comprobante
                               where ListadoEstadoCbte.Contains(C.IdEstado_cbte)
                               && C.IdEstadoProceso.Contains(IdEstadoProceso)
                               && C.Fecha_Emi_Fact >= FechaIni && C.Fecha_Emi_Fact <= FechaFin
                               select new
                               {
                                   C.IdEmpresa,
                                   C.IdComprobante,
                                   C.IdTipoDocumento,
                                   C.IdEstado_cbte,
                                   C.Cedula_Ruc,
                                   C.Numero_Autorizacion,
                                   C.RutaArchivo,
                                   C.Nombre_file,
                                   C.Fecha_Emi_Fact,
                                   C.Fecha_transaccion,
                                   C.FechaAutorizacion,
                                   C.ClaveContingencia,
                                   C.EstadoDoc,
                                   C.Error,
                                   C.IdError_Sri,
                                   C.Nom_emisor,
                                   C.Nom_Tipo_doc,
                                   C.Nom_estado_doc,
                                   C.IdEstadoProceso,
                                   C.RespuestaSRI,
                                   C.Ambiente,
                                   C.Clave_Acceso,
                                   C.Nom_Contribuyente,
                                   C.Tipo_Base_Exterior,
                                   C.cadena_conexion_Exterior,
                                   C.Cod_Empresa_Para_DB_Ext,
                                   C.Total
                               };



                       foreach (var item in q)
                       {
                           tb_Comprobante_Info infoC = new tb_Comprobante_Info();

                           infoC.IdEmpresa = item.IdEmpresa;
                           infoC.IdComprobante = item.IdComprobante;
                           infoC.IdTipoDocumento = item.IdTipoDocumento;
                           infoC.IdEstado_cbte = item.IdEstado_cbte;
                           //infoC.secuencial = item.secuencial;
                           infoC.Cedula_Ruc = item.Cedula_Ruc;
                           infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                           infoC.RutaArchivo = item.RutaArchivo;
                           infoC.Nombre_file = item.Nombre_file;
                           infoC.s_XML = "xml";
                           infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                           infoC.Fecha_transaccion = item.Fecha_transaccion;
                           infoC.sFecha_transaccion = (item.Fecha_transaccion == null) ? "" : item.Fecha_transaccion.ToString();
                           infoC.FechaAutorizacion = item.FechaAutorizacion;
                           //infoC.IdEstadoDeEnvio = item.IdEstadoDeEnvio;
                           infoC.ClaveContingencia = item.ClaveContingencia;
                           infoC.EstadoDoc = item.EstadoDoc;
                           infoC.Error = item.Error;
                           infoC.IdEstadoProceso = item.IdEstadoProceso;
                           infoC.IdError_Sri = item.IdError_Sri;
                           infoC.Nom_emisor = item.Nom_emisor;
                           infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                           infoC.Nom_estado_doc = item.Nom_estado_doc;
                           infoC.RespuestaSRI = item.RespuestaSRI;
                           infoC.sFechaAutorizacion = (item.FechaAutorizacion == null) ? "" : item.FechaAutorizacion.ToString();

                           infoC.MosTrar_icono_Ride = true;
                           infoC.MosTrar_icono_xml = true;
                           infoC.Mostrar_Icon_Eliminar = true;

                           infoC.Ambiente = item.Ambiente;
                           infoC.Nom_Contribuyente = item.Nom_Contribuyente;

                           infoC.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                           infoC.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                           infoC.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;
                           infoC.Total = item.Total;
                           lista.Add(infoC);
                       }

                       //traigo los cbtes cuya fecha de emision sea null

                       var q2 = from C in conexion.vw_Comprobante
                                where ListadoEstadoCbte.Contains(C.IdEstado_cbte)
                                && C.Fecha_Emi_Fact == null
                                select C;


                       foreach (var item in q2)
                       {
                           tb_Comprobante_Info infoC = new tb_Comprobante_Info();

                           infoC.IdEmpresa = item.IdEmpresa;
                           infoC.IdComprobante = item.IdComprobante;
                           infoC.IdTipoDocumento = item.IdTipoDocumento;
                           infoC.IdEstado_cbte = item.IdEstado_cbte;
                           //infoC.secuencial = item.secuencial;
                           infoC.Cedula_Ruc = item.Cedula_Ruc;
                           infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                           infoC.RutaArchivo = item.RutaArchivo;
                           infoC.Nombre_file = item.Nombre_file;
                           infoC.s_XML = item.s_XML;
                           infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                           infoC.Fecha_transaccion = item.Fecha_transaccion;
                           infoC.FechaAutorizacion = item.FechaAutorizacion;
                           //infoC.IdEstadoDeEnvio = item.IdEstadoDeEnvio;
                           infoC.ClaveContingencia = item.ClaveContingencia;
                           infoC.EstadoDoc = item.EstadoDoc;
                           infoC.Error = item.Error;
                           infoC.IdEstadoProceso = item.IdEstadoProceso;
                           infoC.IdError_Sri = item.IdError_Sri;
                           infoC.Nom_emisor = item.Nom_emisor;
                           infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                           infoC.Nom_estado_doc = item.Nom_estado_doc;
                           infoC.RespuestaSRI = item.RespuestaSRI;

                           infoC.MosTrar_icono_Ride = true;
                           infoC.MosTrar_icono_xml = true;
                           infoC.Ambiente = item.Ambiente;
                           infoC.Nom_Contribuyente = item.Nom_Contribuyente;
                           infoC.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                           infoC.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                           infoC.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;
                           infoC.Total = item.Total;
                           lista.Add(infoC);
                       }

                   }

               }

               #endregion


               mensajeErrorOut = "Proceso OK";

               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = mensaje;

               return new List<tb_Comprobante_Info>();
           }
       }
       
       public List<tb_Comprobante_Info> consultar_listado_cbte_pendiente_de_autorizar(ref string mensajeErrorOut)
       {
           try
           {
               List<tb_Comprobante_Info> lista = new List<tb_Comprobante_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   conexion.Database.CommandTimeout = 3000;


                   var q = from C in conexion.vw_comprobante_pendiente_de_Autorizacion_sri
                           select C;
                   foreach (var item in q)
                   {
                       tb_Comprobante_Info infoC = new tb_Comprobante_Info();

                       infoC.IdEmpresa = item.IdEmpresa;
                       infoC.IdComprobante = item.IdComprobante;
                       infoC.IdTipoDocumento = item.IdTipoDocumento;
                       infoC.IdEstado_cbte = item.IdEstado_cbte;
                       infoC.Cedula_Ruc = item.Cedula_Ruc;
                       infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                       infoC.RutaArchivo = item.RutaArchivo;
                       infoC.Nombre_file = item.Nombre_file;
                       infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                       infoC.Fecha_transaccion = item.Fecha_transaccion;
                       infoC.FechaAutorizacion = item.FechaAutorizacion;
                       infoC.sFechaAutorizacion = (item.FechaAutorizacion == null) ? "" : item.FechaAutorizacion.ToString();
                       infoC.ClaveContingencia = item.ClaveContingencia;
                       infoC.EstadoDoc = item.EstadoDoc;
                       infoC.Error = item.Error;
                       infoC.IdEstadoProceso = item.IdEstadoProceso;
                       infoC.IdError_Sri = item.IdError_Sri;
                       infoC.Nom_emisor = item.Nom_emisor;
                       infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                       infoC.Nom_estado_doc = item.Nom_estado_doc;
                       infoC.RespuestaSRI = item.RespuestaSRI;
                       infoC.MosTrar_icono_Ride = true;
                       infoC.MosTrar_icono_xml = true;
                       infoC.Ambiente = item.Ambiente;

                       infoC.Clave_Acceso = item.Clave_Acceso;

                       infoC.Mostrar_Icon_Eliminar = true;
                       infoC.Nom_Contribuyente = item.Nom_Contribuyente;
                       infoC.Checked = true;

                      

                       lista.Add(infoC);

                       mensajeErrorOut = "Proceso OK";
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = mensaje;

               return new List<tb_Comprobante_Info>();
           }

       }



       public List<tb_Comprobante_Info> consultar_listado_cbte_para_exportar(DateTime FechaIni,DateTime FechaFin,eTipoExportacion TipoExportacion,
           ref string mensajeErrorOut)
       {
           try
           {
               List<tb_Comprobante_Info> lista = new List<tb_Comprobante_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   conexion.Database.CommandTimeout = 3000;

                   if (TipoExportacion == eTipoExportacion.EXPORTADOS)
                   {
                       var q = from C in conexion.vwtb_Comprobante_para_exportar
                               where C.Fecha_Emi_Fact >= FechaIni && C.Fecha_Emi_Fact <= FechaFin
                               && C.fecha_hora_exportacion != null
                               select C;


                       foreach (var item in q)
                       {
                           tb_Comprobante_Info infoC = new tb_Comprobante_Info();

                           infoC.IdEmpresa = item.IdEmpresa;
                           infoC.IdComprobante = item.IdComprobante;
                           infoC.IdTipoDocumento = item.IdTipoDocumento;
                           infoC.IdEstado_cbte = item.IdEstado_cbte;
                           infoC.Cedula_Ruc = item.Cedula_Ruc;
                           infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                           infoC.RutaArchivo = item.RutaArchivo;
                           infoC.Nombre_file = item.Nombre_file;
                           infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                           infoC.FechaAutorizacion = item.FechaAutorizacion;
                           infoC.sFechaAutorizacion = (item.FechaAutorizacion == null) ? "" : item.FechaAutorizacion.ToString();
                           infoC.ClaveContingencia = item.ClaveContingencia;
                           infoC.EstadoDoc = item.EstadoDoc;
                           infoC.Nom_emisor = item.Nom_emisor;
                           //infoC.MosTrar_icono_Ride = true;
                           //infoC.MosTrar_icono_xml = true;
                           infoC.Ambiente = item.Ambiente;
                           infoC.Clave_Acceso = item.Clave_Acceso;
                           infoC.Nom_Contribuyente = item.Nom_Contribuyente;

                           infoC.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                           infoC.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                           infoC.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;
                           infoC.Mostrar_IconoExportar = true;
                           infoC.Exportado = true;
                           infoC.Mostrar_IconoGuardar = false;


                           

                           lista.Add(infoC);

                           mensajeErrorOut = "Proceso OK";
                       }
                   }


                   if (TipoExportacion == eTipoExportacion.X_EXPORTAR)
                   {
                       var q = from C in conexion.vwtb_Comprobante_para_exportar
                               where C.Fecha_Emi_Fact >= FechaIni && C.Fecha_Emi_Fact <= FechaFin
                               && C.fecha_hora_exportacion == null
                               select C;


                       foreach (var item in q)
                       {
                           tb_Comprobante_Info infoC = new tb_Comprobante_Info();

                           infoC.IdEmpresa = item.IdEmpresa;
                           infoC.IdComprobante = item.IdComprobante;
                           infoC.IdTipoDocumento = item.IdTipoDocumento;
                           infoC.IdEstado_cbte = item.IdEstado_cbte;
                           infoC.Cedula_Ruc = item.Cedula_Ruc;
                           infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                           infoC.RutaArchivo = item.RutaArchivo;
                           infoC.Nombre_file = item.Nombre_file;
                           infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                           infoC.FechaAutorizacion = item.FechaAutorizacion;
                           infoC.Fecha_transaccion = item.Fecha_transaccion;
                           infoC.sFechaAutorizacion = (item.FechaAutorizacion == null) ? "" : item.FechaAutorizacion.ToString();
                           infoC.ClaveContingencia = item.ClaveContingencia;
                           infoC.EstadoDoc = item.EstadoDoc;
                           infoC.Nom_emisor = item.Nom_emisor;
                           //infoC.MosTrar_icono_Ride = true;
                           //infoC.MosTrar_icono_xml = true;
                           infoC.Ambiente = item.Ambiente;
                           infoC.Clave_Acceso = item.Clave_Acceso;
                           infoC.Nom_Contribuyente = item.Nom_Contribuyente;

                           infoC.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                           infoC.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                           infoC.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;
                           infoC.Mostrar_IconoExportar = false;
                           infoC.Exportado = false;
                           infoC.Mostrar_IconoGuardar = true;


                           lista.Add(infoC);

                           mensajeErrorOut = "Proceso OK";
                       }
                   }


               }
               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = mensaje;

               return new List<tb_Comprobante_Info>();
           }

       }


       public int ObtenerNumPagina(int IdEmpresaIni, int IdEmpresaFin, string IdTipoDocumento, int Registro_x_Pag, DateTime FechaIni, DateTime FechaFin, string Stipo_Autorizacion, string IdEstadoProceso, string cadena_busqueda, string IdEstado_cbte, ref string MensajeErrorOut)
       {
           try
           {
               int NumPag = 0;
               decimal t = 0;
               List<string> ListTipoDocumento = new List<string>();
               EntitiesFactElectronica contex = new EntitiesFactElectronica();




               if (IdTipoDocumento == "00")
               {
                   var VarTDoc = from C in contex.tb_Comprobante_tipo                                 
                                 select C;

                   foreach (var item in VarTDoc)
                   {
                       ListTipoDocumento.Add(item.IdComprobante_tipo);    
                   }

               }
               else
               {
                   ListTipoDocumento.Add(IdTipoDocumento);
               }

                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

               
               var q = (from C in contex.vw_Comprobante
                        where C.Fecha_Emi_Fact >= FechaIni
                            && C.Fecha_Emi_Fact <= FechaFin
                            && C.IdEstado_cbte == IdEstado_cbte
                            && C.EstadoDoc.Contains(Stipo_Autorizacion)
                            && C.IdEstadoProceso == IdEstadoProceso
                            && (C.IdComprobante + C.Nom_Contribuyente + C.Cedula_Ruc + C.Nom_emisor).Contains(cadena_busqueda)
                            && C.IdEmpresa >= IdEmpresaIni && C.IdEmpresa <= IdEmpresaFin
                            && (ListTipoDocumento.Contains(C.IdTipoDocumento) )
                        select C.IdEmpresa).Count();

               if (q == 0)                  
               {
                   NumPag = 1;
               }
               else
               {
                   t = q / Registro_x_Pag;
                   if ((t % 10) == 1)
                       NumPag = Convert.ToInt32(t);
                   else
                       NumPag = Convert.ToInt32(t + 1);
                  
               }

               return NumPag;
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


       public tb_Comprobante_Info consultar(int IdEmpresa, string IdComprobante, string IdTipoDocumento
          , string IdEstado_cbte, ref string mensajeErrorOut)
       {
           try
           {
               tb_Comprobante_Info infoC = new tb_Comprobante_Info();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   conexion.Database.CommandTimeout = 3000;

                   var q = from C in conexion.vw_Comprobante
                           where C.IdEmpresa == IdEmpresa
                           && C.IdComprobante == IdComprobante
                           && C.IdTipoDocumento == IdTipoDocumento
                           && C.IdEstado_cbte == IdEstado_cbte
                           select C;
                   foreach (var item in q)
                   {
               
                       infoC.IdEmpresa = item.IdEmpresa;
                       infoC.IdComprobante = item.IdComprobante;
                       infoC.IdTipoDocumento = item.IdTipoDocumento;
                       infoC.IdEstado_cbte = item.IdEstado_cbte;                       
                       infoC.Cedula_Ruc = item.Cedula_Ruc;
                       infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                       infoC.RutaArchivo = item.RutaArchivo;
                       infoC.Nombre_file = item.Nombre_file;
                       infoC.s_XML = item.s_XML;
                       infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                       infoC.Fecha_transaccion = item.Fecha_transaccion;
                       infoC.FechaAutorizacion = item.FechaAutorizacion;                       
                       infoC.ClaveContingencia = item.ClaveContingencia;
                       infoC.EstadoDoc = item.EstadoDoc;
                       infoC.Error = item.Error;
                       infoC.IdEstadoProceso = item.IdEstadoProceso;
                       infoC.IdError_Sri = item.IdError_Sri;
                       infoC.Nom_emisor = item.Nom_emisor;
                       infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                       infoC.Nom_estado_doc = item.Nom_estado_doc;
                       infoC.RespuestaSRI = item.RespuestaSRI;
                       infoC.Clave_Acceso = item.Clave_Acceso;
                       infoC.Nom_Contribuyente = item.Nom_Contribuyente;
                       infoC.Ambiente = item.Ambiente;
                       infoC.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                       infoC.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                       infoC.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;
                       infoC.Total = item.Total;
                   }
               }

               mensajeErrorOut = "Proceso OK";

               return infoC;
           }
           catch (Exception ex)
           {
               mensajeErrorOut = ex.Message;
               return new tb_Comprobante_Info();
           }
       }

       public tb_Comprobante_Info consulta_PDF_info(int IdEmpresa, string cedulaRuc, string IdComprobante
        , ref string mensajeErrorOut)
       {
           try
           {
               tb_Comprobante_Info infoC = new tb_Comprobante_Info();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   conexion.Database.CommandTimeout = 2000;

                   var q = from C in conexion.vw_Comprobante
                           where C.IdEmpresa == IdEmpresa
                           && C.IdComprobante == IdComprobante
                           && C.Cedula_Ruc == cedulaRuc
                           
                           select C;
                   foreach (var item in q)
                   {

                       infoC.IdEmpresa = item.IdEmpresa;
                       infoC.IdComprobante = item.IdComprobante;
                       infoC.IdTipoDocumento = item.IdTipoDocumento;
                       infoC.IdEstado_cbte = item.IdEstado_cbte;
                       infoC.Cedula_Ruc = item.Cedula_Ruc;
                       infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                       infoC.RutaArchivo = item.RutaArchivo;
                       infoC.Nombre_file = item.Nombre_file;
                       infoC.s_XML = item.s_XML;
                       infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                       infoC.Fecha_transaccion = item.Fecha_transaccion;
                       infoC.FechaAutorizacion = item.FechaAutorizacion;
                       infoC.ClaveContingencia = item.ClaveContingencia;
                       infoC.EstadoDoc = item.EstadoDoc;
                       infoC.Error = item.Error;
                       infoC.IdEstadoProceso = item.IdEstadoProceso;
                       infoC.IdError_Sri = item.IdError_Sri;
                       infoC.Nom_emisor = item.Nom_emisor;
                       infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                       infoC.Nom_estado_doc = item.Nom_estado_doc;
                       infoC.RespuestaSRI = item.RespuestaSRI;
                       infoC.Ambiente = item.Ambiente;
                       infoC.Clave_Acceso = item.Clave_Acceso;
                       infoC.Nom_Contribuyente = item.Nom_Contribuyente;
                       infoC.Total = item.Total;
                       //infoC.LogoEmpresa=item.lo

                   }
               }
               mensajeErrorOut = "Proceso OK";

               return infoC;
           }
           catch (Exception ex)
           {
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               
               return new tb_Comprobante_Info();
           }
       }

       public List<tb_Comprobante_Info> consultar_listado_comprobantes_x_web(int IdEmpresa,string cedulaRuc, string TipoComprobante
           , DateTime FecIni, DateTime FecFin,string buscar
           ,int Indice_Pagina, int Tamanio_Pagina,ref string mensajeErrorOut)
       {
           try
           {
               FecIni = Convert.ToDateTime(FecIni.ToShortDateString());
               FecFin = Convert.ToDateTime(FecFin.ToShortDateString());
               ObjectParameter TotalRegistros = null;

               
               List<tb_Comprobante_Info> lista = new List<tb_Comprobante_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {
                   conexion.Database.CommandTimeout = 2000;

                   String s = conexion.Database.Connection.ConnectionString;

                   System.Data.Entity.Core.Objects.ObjectResult<sp_consulta_x_cbtes_x_paginas_Result> Result2 = conexion.sp_consulta_x_cbtes_x_paginas(IdEmpresa, Tamanio_Pagina, Indice_Pagina, cedulaRuc, TipoComprobante, buscar, FecIni, FecFin);

                   ///List<tb_Comprobante_Info> Result2 = new List<tb_Comprobante_Info>(Result).ToList();


                 //  string SQL = string.Format("exec  DBFacturacion_Electronica.dbo.sp_consulta_x_cbtes_x_paginas {0},{1},{2},'{3}','{4}','{5}','{6}','{7}'", IdEmpresa, Tamanio_Pagina, Indice_Pagina, cedulaRuc, TipoComprobante, buscar, FecIni.ToString("yyyy-MM-dd"), FecFin.ToString("yyyy-MM-dd"));

                 //List<tb_Comprobante_Info> Result = conexion.Database.SqlQuery<tb_Comprobante_Info>(SQL).ToList();

                  // List<tb_Comprobante_Info> Result = new List<tb_Comprobante_Info>();

                   foreach (var item in Result2)
                   {
                       tb_Comprobante_Info ItemResul= new tb_Comprobante_Info();

                       ItemResul.IdEmpresa = item.IdEmpresa;
                       ItemResul.IdComprobante = item.IdComprobante;
                       ItemResul.IdTipoDocumento = item.IdTipoDocumento;
                       ItemResul.IdEstado_cbte = item.IdEstado_cbte;
                       ItemResul.Cedula_Ruc = item.Cedula_Ruc;
                       ItemResul.Numero_Autorizacion = item.Numero_Autorizacion;
                       ItemResul.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                       ItemResul.Nombre_file = item.Nombre_file;
                       ItemResul.nom_Tipo_doc = item.nom_Tipo_doc;
                       ItemResul.ClaveContingencia = item.ClaveContingencia;
                       ItemResul.FechaAutorizacion = item.FechaAutorizacion;
                       ItemResul.Total = item.Total;
                       ItemResul.NumFila = item.NumFila ;
                       ItemResul.TotalRegistros = item.TotalRegistros;
                       ItemResul.IdContribuyente = item.IdContribuyente;
                       ItemResul.Nom_Contribuyente = item.Nom_Contribuyente;
                       
                       

                       lista.Add(ItemResul);
                       
                   }


                                                                                                         
               }

               mensajeErrorOut = "Proceso OK";

               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = mensaje;
               return new List<tb_Comprobante_Info>();
           }
       }

       public string getXML(int IdEmpresa, string cedulaRuc, string IdComprobante, ref string mensajeErrorOut)
       {
           try
           {
               string xml = "";
               tb_Comprobante_Info infoXML = new tb_Comprobante_Info();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   var q = from C in conexion.vwSerWeb_Comprobante
                           where C.IdEmpresa == IdEmpresa
                           && C.IdComprobante == IdComprobante
                           && C.Cedula_Ruc == cedulaRuc                          
                           select C;

                   foreach (var item in q)
                   {
                       infoXML.s_XML = item.s_XML;                   
                   }                             
               }
               mensajeErrorOut = "Proceso OK";

               return xml = infoXML.s_XML;
           }
           catch (Exception ex )
           {
               
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return null;
           }                   
       }



       public string Get_XML(int IdEmpresa, string IdComprobante, ref string mensajeErrorOut)
       {
           try
           {
               string xml = "";
               tb_Comprobante_Info infoXML = new tb_Comprobante_Info();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   var q = from C in conexion.vwSerWeb_Comprobante
                           where C.IdEmpresa == IdEmpresa
                           && C.IdComprobante == IdComprobante
                           select C;

                   foreach (var item in q)
                   {
                       infoXML.s_XML = item.s_XML;
                   }
               }
               mensajeErrorOut = "Proceso OK";

               return xml = infoXML.s_XML;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return null;
           }
       }

       public List<tb_Comprobante_Info> consultar_hist_de_cbte_a_Eliminar(int IdEmpresa, string IdComprobante, ref string mensajeErrorOut)
       {
           try
           {
               List<tb_Comprobante_Info> ListinfoC = new List<tb_Comprobante_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {
                   conexion.Database.CommandTimeout = 2000;

                   var q = from C in conexion.vw_Comprobante
                           where C.IdEmpresa == IdEmpresa
                           && C.IdComprobante == IdComprobante
                           select C;
                   foreach (var item in q)
                   {
                       tb_Comprobante_Info infoC = new tb_Comprobante_Info();
                       infoC.IdEmpresa = item.IdEmpresa;
                       infoC.IdComprobante = item.IdComprobante;
                       infoC.IdTipoDocumento = item.IdTipoDocumento;
                       infoC.IdEstado_cbte = item.IdEstado_cbte;
                       infoC.Cedula_Ruc = item.Cedula_Ruc;
                       infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                       infoC.RutaArchivo = item.RutaArchivo;
                       infoC.Nombre_file = item.Nombre_file;
                       infoC.s_XML = item.s_XML;
                       infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                       infoC.Fecha_transaccion = item.Fecha_transaccion;
                       infoC.FechaAutorizacion = item.FechaAutorizacion;
                       infoC.ClaveContingencia = item.ClaveContingencia;
                       infoC.EstadoDoc = item.EstadoDoc;
                       infoC.Error = item.Error;
                       infoC.IdEstadoProceso = item.IdEstadoProceso;
                       infoC.IdError_Sri = item.IdError_Sri;
                       infoC.Nom_emisor = item.Nom_emisor;
                       infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                       infoC.Nom_estado_doc = item.Nom_estado_doc;
                       infoC.RespuestaSRI = item.RespuestaSRI;
                       infoC.Ambiente = item.Ambiente;
                       infoC.Clave_Acceso = item.Clave_Acceso;

                       infoC.Nom_Contribuyente= item.Nom_Contribuyente;


                       infoC.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                       infoC.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                       infoC.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;


                       ListinfoC.Add(infoC);

                   }
               }

               mensajeErrorOut = "Proceso OK";

               return ListinfoC;
           }
           catch (Exception ex)
           {
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return new List<tb_Comprobante_Info>();
           }
       
       }

       /// <summary>
       /// Borra todos los registros concernientes a esta transaccion
       /// </summary>
       /// <param name="IdEmpresa"></param>
       /// <param name="IdComprobante"></param>
       /// <param name="mensajeErrorOut"></param>
       /// <returns></returns>
       public Boolean Eliminar_cbte(int IdEmpresa, string IdComprobante, ref string mensajeErrorOut)
       {
           try
           {
               using (EntitiesFactElectronica DbFactElec = new EntitiesFactElectronica())
               {

                   var resultado = DbFactElec.tb_Comprobante.First(v => v.IdEmpresa == IdEmpresa
                       && v.IdComprobante == IdComprobante);

                   DbFactElec.Database.ExecuteSqlCommand("delete tb_Comprobante where idempresa=" + IdEmpresa + " and IdComprobante='" + IdComprobante + "'" );

               }


               mensajeErrorOut = "Proceso OK";
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return false;
           }
           
       }


       // fun cion para extraer los comprobantes por emisor para enviar por correo

       public List<tb_Comprobante_Info> ComprobantesPorEmisor(string RucDestinatario, ref string mensajeErrorOut)
       {
           try
           {
               List<tb_Comprobante_Info> ListinfoC = new List<tb_Comprobante_Info>();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {
                   conexion.Database.CommandTimeout = 2000;

                   var q = from C in conexion.vw_Comprobante
                           where C.Cedula_Ruc == RucDestinatario
                           && C.IdEstado_cbte == "VALI_&_FIRM_&_REC"
                           && C.EstadoDoc.Trim()=="AUTORIZADO"
                           select C;
                   foreach (var item in q)
                   {
                       tb_Comprobante_Info infoC = new tb_Comprobante_Info();
                       infoC.IdEmpresa = item.IdEmpresa;
                       infoC.IdComprobante = item.IdComprobante;
                       infoC.IdTipoDocumento = item.IdTipoDocumento;
                       infoC.IdEstado_cbte = item.IdEstado_cbte;
                       infoC.Cedula_Ruc = item.Cedula_Ruc;
                       infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                       infoC.RutaArchivo = item.RutaArchivo;
                       infoC.Nombre_file = item.Nombre_file;
                       infoC.s_XML = item.s_XML;
                       infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                       infoC.Fecha_transaccion = item.Fecha_transaccion;
                       infoC.FechaAutorizacion = item.FechaAutorizacion;
                       infoC.ClaveContingencia = item.ClaveContingencia;
                       infoC.EstadoDoc = item.EstadoDoc;
                       infoC.Error = item.Error;
                       infoC.IdEstadoProceso = item.IdEstadoProceso;
                       infoC.IdError_Sri = item.IdError_Sri;
                       infoC.Nom_emisor = item.Nom_emisor;
                       infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                       infoC.Nom_estado_doc = item.Nom_estado_doc;
                       infoC.RespuestaSRI = item.RespuestaSRI;
                       infoC.Ambiente = item.Ambiente;
                       infoC.Clave_Acceso = item.Clave_Acceso;
                       infoC.Nom_Contribuyente = item.Nom_Contribuyente;

                       infoC.Tipo_Base_Exterior = item.Tipo_Base_Exterior;
                       infoC.cadena_conexion_Exterior = item.cadena_conexion_Exterior;
                       infoC.Cod_Empresa_Para_DB_Ext = item.Cod_Empresa_Para_DB_Ext;


                       ListinfoC.Add(infoC);

                   }
               }

               mensajeErrorOut = "Proceso OK";
               return ListinfoC;
           }
           catch (Exception ex)
           {
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return new List<tb_Comprobante_Info>();
           }

       }


       // consulta de comprobante por idComprobante, para generar enviar los correos

       public tb_Comprobante_Info Comprobante_consulta_Id_Comprobante(int IdEmpresa, string IdComprobante, ref string mensajeErrorOut)
       {
           try
           {
               tb_Comprobante_Info infoC = new tb_Comprobante_Info();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {
                   conexion.Database.CommandTimeout = 2000;

                   var q = from C in conexion.vw_Comprobante
                           where C.IdComprobante == IdComprobante
                           && C.IdEstado_cbte == "VALI_&_FIRM_&_REC"
                           && C.IdEmpresa == IdEmpresa
                           select C;
                   foreach (var item in q)
                   {
                       infoC.IdEmpresa = item.IdEmpresa;
                       infoC.IdComprobante = item.IdComprobante;
                       infoC.IdTipoDocumento = item.IdTipoDocumento;
                       infoC.IdEstado_cbte = item.IdEstado_cbte;
                       infoC.Cedula_Ruc = item.Cedula_Ruc;
                       infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                       infoC.RutaArchivo = item.RutaArchivo;
                       infoC.Nombre_file = item.Nombre_file;
                       infoC.s_XML = item.s_XML;
                       infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                       infoC.Fecha_transaccion = item.Fecha_transaccion;
                       infoC.FechaAutorizacion = item.FechaAutorizacion;
                       infoC.ClaveContingencia = item.ClaveContingencia;
                       infoC.EstadoDoc = item.EstadoDoc;
                       infoC.Error = item.Error;
                       infoC.IdEstadoProceso = item.IdEstadoProceso;
                       infoC.IdError_Sri = item.IdError_Sri;
                       infoC.Nom_emisor = item.Nom_emisor;
                       infoC.Nom_TipoDocumento = item.Nom_Tipo_doc;
                       infoC.Nom_estado_doc = item.Nom_estado_doc;
                       infoC.RespuestaSRI = item.RespuestaSRI;
                       infoC.Ambiente = item.Ambiente;
                       infoC.Clave_Acceso = item.Clave_Acceso;
                       infoC.Nom_Contribuyente = item.Nom_Contribuyente;
                       infoC.Total = item.Total;
                   }
               }
               mensajeErrorOut = "Proceso OK";
               return infoC;
           }
           catch (Exception ex)
           {
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return new tb_Comprobante_Info();
           }

       }


       public FirmElect.Info.class_sri.Factura_V2.factura_Ride_Info consultar_Factura_ride(int IdEmpresa, string IdComprobante, string IdTipoDocumento
  , string IdEstado_cbte, ref string mensajeErrorOut)
       {

           try
           {
               DateTime sFechaAuto = DateTime.Now;
               string sNum_Autorizacion = "";


               tb_Comprobante_Info InfoCbte = new tb_Comprobante_Info();
               tb_FormaPago_Data oData_FormaPago = new tb_FormaPago_Data();
               Info.class_sri.Factura_V2.factura_Ride_Info InfoFactura_SRI_Ride = new factura_Ride_Info();
               factura InfoFactura_SRI = new factura();

               InfoCbte = this.consultar(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);

               //leyendo el xml de la base 
               XmlDocument xmlComprobanteOrigen = new XmlDocument();
               xmlComprobanteOrigen.Load(new StringReader(InfoCbte.s_XML));


               //ENCONTRANDO EL NODO TOKEN CON ESTE SE FIRMARA

               XmlNode xmlNode_f;
               XmlNode xmlNode_N_Auto;


               XmlElement root = xmlComprobanteOrigen.DocumentElement;
               xmlNode_f = root.SelectSingleNode("//fechaAutorizacion");

               if (xmlNode_f != null)// es un xml q fue recibido y tiene soap
               {
                   sFechaAuto = Convert.ToDateTime(xmlNode_f.FirstChild.Value);

                   xmlNode_N_Auto = root.SelectSingleNode("//numeroAutorizacion");
                   if (xmlNode_N_Auto == null) // no esta autorizado
                   {
                       sNum_Autorizacion = "NO AUTORIZADO";
                   }
                   else
                   {
                       sNum_Autorizacion = xmlNode_N_Auto.FirstChild.Value;
                   }

                   string sXml_a_descerializar;
                   sXml_a_descerializar = Quitar_a_xml_CDATA_y_Signature(xmlComprobanteOrigen.GetElementsByTagName("comprobante")[0].InnerXml,ref mensajeErrorOut);

                   XmlDocument xmlCbte_a_descr = new XmlDocument();
                   xmlCbte_a_descr.Load(new StringReader(sXml_a_descerializar));

                   InfoFactura_SRI = (factura)Deserialize(xmlCbte_a_descr, InfoFactura_SRI.GetType());

               }
               else
               {
                   InfoFactura_SRI = (factura)Deserialize(xmlComprobanteOrigen, InfoFactura_SRI.GetType());
               }


               InfoFactura_SRI_Ride.factura = InfoFactura_SRI;
               InfoFactura_SRI_Ride.Fecha_Autorizacion = sFechaAuto;

               if (InfoFactura_SRI_Ride.factura.infoAdicional.Count !=0)
               {
                   foreach (var item in InfoFactura_SRI_Ride.factura.infoAdicional)
                   {
                       if (item.nombre == "REFERENCIA")
                       {
                           InfoFactura_SRI_Ride.REFERENCIA = item.Value;
                       }
                       if (item.nombre == "MAIL")
                       {
                           InfoFactura_SRI_Ride.MAIL = item.Value;
                       }
                       if (item.nombre == "OBRA")
                       {
                           InfoFactura_SRI_Ride.OBRA = item.Value;
                       }
                       if (item.nombre == "FORMA_PAGO")
                       {
                           InfoFactura_SRI_Ride.FORMA_PAGO = item.Value;
                       }
                       if (item.nombre == "FECHA_VENCI")
                       {
                           InfoFactura_SRI_Ride.FECHA_VENCI = item.Value;
                       }
                       if (item.nombre == "observaciones")
                       {
                           InfoFactura_SRI_Ride.observaciones = item.Value;
                       }
                       if (item.nombre == "DIRECCION_CLIENTE")
                       {
                           InfoFactura_SRI_Ride.DIRECCION_CLIENTE = item.Value;
                       }
                   }              
               }
               if (InfoFactura_SRI_Ride.factura.infoFactura.pagos.Count != 0)
               {

                   List<pagosPago> lista = new List<pagosPago>();
                   foreach (var item in InfoFactura_SRI_Ride.factura.infoFactura.pagos)
                   {
                       tb_FormaPago_info InfoFormaPago = new tb_FormaPago_info();
                       pagosPago_info Info_FormaPago = new pagosPago_info();
                       InfoFormaPago = oData_FormaPago.Get_Info_FormaPago(item.formaPago, ref mensaje);
                       Info_FormaPago.formaPago.formaPago = item.formaPago;
                       Info_FormaPago.formaPago.total = item.total;
                       Info_FormaPago.formaPago.plazo = item.plazo;
                       Info_FormaPago.formaPago.unidadTiempo = item.unidadTiempo;
                       Info_FormaPago.Tipo_Forma_Pago.IdFormaPago = InfoFormaPago.IdFormaPago;
                       Info_FormaPago.Tipo_Forma_Pago.nombre = InfoFormaPago.nombre;

                       InfoFactura_SRI_Ride.List_FormaPago.Add(Info_FormaPago);
                   }
               }
               InfoFactura_SRI_Ride.Num_Autorizacion = sNum_Autorizacion;

               mensajeErrorOut = "Proceso OK";

               return InfoFactura_SRI_Ride;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return new factura_Ride_Info();
           }
       }


       public FirmElect.Info.class_sri.NotaCredito.notaCredito_Ride_Info consultar_NotaCredito_Ride(int IdEmpresa, string IdComprobante, string IdTipoDocumento
 , string IdEstado_cbte, ref string mensajeErrorOut)
       {
           try
           {

               DateTime sFechaAuto = DateTime.Now;
               string sNum_Autorizacion = "";


               tb_Comprobante_Info InfoCbte = new tb_Comprobante_Info();
               Info.class_sri.NotaCredito.notaCredito_Ride_Info InfoFactura_SRI_Ride = new notaCredito_Ride_Info();
               notaCredito InfoNotaCred_SRI = new notaCredito();

               InfoCbte = this.consultar(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);

               //leyendo el xml de la base 
               XmlDocument xmlComprobanteOrigen = new XmlDocument();
               xmlComprobanteOrigen.Load(new StringReader(InfoCbte.s_XML));


               //ENCONTRANDO EL NODO TOKEN CON ESTE SE FIRMARA

               XmlNode xmlNode_f;
               XmlNode xmlNode_N_Auto;


               XmlElement root = xmlComprobanteOrigen.DocumentElement;
               xmlNode_f = root.SelectSingleNode("//fechaAutorizacion");

               if (xmlNode_f != null)// es un xml q fue recibido y tiene soap
               {
                   sFechaAuto = Convert.ToDateTime(xmlNode_f.FirstChild.Value);

                   xmlNode_N_Auto = root.SelectSingleNode("//numeroAutorizacion");
                   if (xmlNode_N_Auto == null) // no esta autorizado
                   {
                       sNum_Autorizacion = "NO AUTORIZADO";
                   }
                   else
                   {
                       sNum_Autorizacion = xmlNode_N_Auto.FirstChild.Value;
                   }

                   string sXml_a_descerializar;
                   sXml_a_descerializar = Quitar_a_xml_CDATA_y_Signature(xmlComprobanteOrigen.GetElementsByTagName("comprobante")[0].InnerXml, ref mensajeErrorOut);
                   XmlDocument xmlCbte_a_descr = new XmlDocument();
                   xmlCbte_a_descr.Load(new StringReader(sXml_a_descerializar));
                   InfoNotaCred_SRI = (notaCredito)Deserialize(xmlCbte_a_descr, InfoNotaCred_SRI.GetType());
               }
               else
               {
                   InfoNotaCred_SRI = (notaCredito)Deserialize(xmlComprobanteOrigen, InfoNotaCred_SRI.GetType());
               }


               InfoFactura_SRI_Ride.notaCredito = InfoNotaCred_SRI;
               InfoFactura_SRI_Ride.Fecha_Autorizacion = sFechaAuto; 
               
               if (InfoFactura_SRI_Ride.notaCredito.infoAdicional.Count != 0)
               {
                   foreach (var item in InfoFactura_SRI_Ride.notaCredito.infoAdicional)
                   {
                       if (item.nombre == "REFERENCIA")
                       {
                           InfoFactura_SRI_Ride.REFERENCIA = item.Value;
                       }
                       if (item.nombre == "MAIL")
                       {
                           InfoFactura_SRI_Ride.MAIL = item.Value;
                       }
                       if (item.nombre == "OBRA")
                       {
                           InfoFactura_SRI_Ride.OBRA = item.Value;
                       }
                       if (item.nombre == "FORMA_PAGO")
                       {
                           InfoFactura_SRI_Ride.FORMA_PAGO = item.Value;
                       }
                       if (item.nombre == "FECHA_VENCI")
                       {
                           InfoFactura_SRI_Ride.FECHA_VENCI = item.Value;
                       }
                       if (item.nombre == "observaciones")
                       {
                           InfoFactura_SRI_Ride.observaciones = item.Value;
                       }
                       if (item.nombre == "DIRECCION_CLIENTE")
                       {
                           InfoFactura_SRI_Ride.DIRECCION_CLIENTE = item.Value;
                       }
                   }
               }
               InfoFactura_SRI_Ride.Num_Autorizacion = sNum_Autorizacion;


               mensajeErrorOut = "Proceso OK";

               return InfoFactura_SRI_Ride;

           }
           catch (Exception ex)
           {
               mensajeErrorOut = ex.InnerException + " " + ex.Message;

               return new notaCredito_Ride_Info();
           }
       }

       public FirmElect.Info.class_sri.NotaDebito.notaDebito_Ride_Info consultar_NotaDebito(
           int IdEmpresa, string IdComprobante, string IdTipoDocumento
       , string IdEstado_cbte, ref string mensajeErrorOut)
       {
           try
           {

               DateTime sFechaAuto = DateTime.Now;
               string sNum_Autorizacion = "";


               tb_Comprobante_Info InfoCbte = new tb_Comprobante_Info();
               Info.class_sri.NotaDebito.notaDebito_Ride_Info InfoNotaDebito_SRI_Ride = new Info.class_sri.NotaDebito.notaDebito_Ride_Info();
               notaDebito InfoNotaDebi_SRI = new notaDebito();

               InfoCbte = this.consultar(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);

               //leyendo el xml de la base 
               XmlDocument xmlComprobanteOrigen = new XmlDocument();
               xmlComprobanteOrigen.Load(new StringReader(InfoCbte.s_XML));


               //ENCONTRANDO EL NODO TOKEN CON ESTE SE FIRMARA

               XmlNode xmlNode_f;
               XmlNode xmlNode_N_Auto;


               XmlElement root = xmlComprobanteOrigen.DocumentElement;
               xmlNode_f = root.SelectSingleNode("//fechaAutorizacion");

               if (xmlNode_f != null)// es un xml q fue recibido y tiene soap
               {
                   sFechaAuto = Convert.ToDateTime(xmlNode_f.FirstChild.Value);

                   xmlNode_N_Auto = root.SelectSingleNode("//numeroAutorizacion");
                   if (xmlNode_N_Auto == null) // no esta autorizado
                   {
                       sNum_Autorizacion = "NO AUTORIZADO";
                   }
                   else
                   {
                       sNum_Autorizacion = xmlNode_N_Auto.FirstChild.Value;
                   }


                   string sXml_a_descerializar;
                   sXml_a_descerializar = Quitar_a_xml_CDATA_y_Signature(xmlComprobanteOrigen.GetElementsByTagName("comprobante")[0].InnerXml,ref mensajeErrorOut);



                   XmlDocument xmlCbte_a_descr = new XmlDocument();
                   xmlCbte_a_descr.Load(new StringReader(sXml_a_descerializar));



                   InfoNotaDebi_SRI = (notaDebito)Deserialize(xmlCbte_a_descr, InfoNotaDebi_SRI.GetType());

               }
               else
               {
                   InfoNotaDebi_SRI = (notaDebito)Deserialize(xmlComprobanteOrigen, InfoNotaDebi_SRI.GetType());
               }


               InfoNotaDebito_SRI_Ride.notaDebito = InfoNotaDebi_SRI;
               InfoNotaDebito_SRI_Ride.Fecha_Autorizacion = sFechaAuto;
               if (InfoNotaDebito_SRI_Ride.notaDebito.infoAdicional.Count != 0)
               {
                   foreach (var item in InfoNotaDebito_SRI_Ride.notaDebito.infoAdicional)
                   {
                       if (item.nombre == "REFERENCIA")
                       {
                           InfoNotaDebito_SRI_Ride.REFERENCIA = item.Value;
                       }
                       if (item.nombre == "MAIL")
                       {
                           InfoNotaDebito_SRI_Ride.MAIL = item.Value;
                       }
                       if (item.nombre == "OBRA")
                       {
                           InfoNotaDebito_SRI_Ride.OBRA = item.Value;
                       }
                       if (item.nombre == "FORMA_PAGO")
                       {
                           InfoNotaDebito_SRI_Ride.FORMA_PAGO = item.Value;
                       }
                       if (item.nombre == "FECHA_VENCI")
                       {
                           InfoNotaDebito_SRI_Ride.FECHA_VENCI = item.Value;
                       }
                       if (item.nombre == "observaciones")
                       {
                           InfoNotaDebito_SRI_Ride.observaciones = item.Value;
                       }
                       if (item.nombre == "DIRECCION_CLIENTE")
                       {
                           InfoNotaDebito_SRI_Ride.DIRECCION_CLIENTE = item.Value;
                       }
                   }
               }
               InfoNotaDebito_SRI_Ride.Num_Autorizacion = sNum_Autorizacion;


               mensajeErrorOut = "Proceso OK";

               return InfoNotaDebito_SRI_Ride;


           }
           catch (Exception ex)
           {

               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return new notaDebito_Ride_Info();
           }
       }

       public FirmElect.Info.class_sri.GuiaRemision.guiaRemision_Ride_Info consultar_Guia(int IdEmpresa, string IdComprobante, string IdTipoDocumento
       , string IdEstado_cbte, ref string mensajeErrorOut)
       {
           try
           {

               DateTime sFechaAuto = DateTime.Now;
               string sNum_Autorizacion = "";


               tb_Comprobante_Info InfoCbte = new tb_Comprobante_Info();
               Info.class_sri.GuiaRemision.guiaRemision_Ride_Info InfoGuiaRemision_SRI_Ride = new guiaRemision_Ride_Info();
               guiaRemision InfoGuiaRemision_SRI = new guiaRemision();

               InfoCbte = this.consultar(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);

               //leyendo el xml de la base 
               XmlDocument xmlComprobanteOrigen = new XmlDocument();
               xmlComprobanteOrigen.Load(new StringReader(InfoCbte.s_XML));


               //ENCONTRANDO EL NODO TOKEN CON ESTE SE FIRMARA

               XmlNode xmlNode_f;
               XmlNode xmlNode_N_Auto;


               XmlElement root = xmlComprobanteOrigen.DocumentElement;
               xmlNode_f = root.SelectSingleNode("//fechaAutorizacion");

               if (xmlNode_f != null)// es un xml q fue recibido y tiene soap
               {
                   sFechaAuto = Convert.ToDateTime(xmlNode_f.FirstChild.Value);

                   xmlNode_N_Auto = root.SelectSingleNode("//numeroAutorizacion");
                   if (xmlNode_N_Auto == null) // no esta autorizado
                   {
                       sNum_Autorizacion = "NO AUTORIZADO";
                   }
                   else
                   {
                       sNum_Autorizacion = xmlNode_N_Auto.FirstChild.Value;
                   }



                   string sXml_a_descerializar;
                   sXml_a_descerializar = Quitar_a_xml_CDATA_y_Signature(xmlComprobanteOrigen.GetElementsByTagName("comprobante")[0].InnerXml, ref mensajeErrorOut);



                   XmlDocument xmlCbte_a_descr = new XmlDocument();
                   xmlCbte_a_descr.Load(new StringReader(sXml_a_descerializar));




                   InfoGuiaRemision_SRI = (guiaRemision)Deserialize(xmlCbte_a_descr, InfoGuiaRemision_SRI.GetType());

               }
               else
               {
                   InfoGuiaRemision_SRI = (guiaRemision)Deserialize(xmlComprobanteOrigen, InfoGuiaRemision_SRI.GetType());
               }


               InfoGuiaRemision_SRI_Ride.guiaremision = InfoGuiaRemision_SRI;
               InfoGuiaRemision_SRI_Ride.Fecha_Autorizacion = sFechaAuto;
               if (InfoGuiaRemision_SRI_Ride.guiaremision.infoAdicional.Count != 0)
               {
                   foreach (var item in InfoGuiaRemision_SRI_Ride.guiaremision.infoAdicional)
                   {
                       if (item.nombre == "REFERENCIA")
                       {
                           InfoGuiaRemision_SRI_Ride.REFERENCIA = item.Value;
                       }
                       if (item.nombre == "MAIL")
                       {
                           InfoGuiaRemision_SRI_Ride.MAIL = item.Value;
                       }
                       if (item.nombre == "OBRA")
                       {
                           InfoGuiaRemision_SRI_Ride.OBRA = item.Value;
                       }
                       if (item.nombre == "FORMA_PAGO")
                       {
                           InfoGuiaRemision_SRI_Ride.FORMA_PAGO = item.Value;
                       }
                       if (item.nombre == "FECHA_VENCI")
                       {
                           InfoGuiaRemision_SRI_Ride.FECHA_VENCI = item.Value;
                       }
                       if (item.nombre == "observaciones")
                       {
                           InfoGuiaRemision_SRI_Ride.observaciones = item.Value;
                       }
                       if (item.nombre == "DESTINO")
                       {
                           InfoGuiaRemision_SRI_Ride.DESTINO = item.Value;
                       }
                   }
               }
               InfoGuiaRemision_SRI_Ride.Num_Autorizacion = sNum_Autorizacion;

               mensajeErrorOut = "Proceso OK";
               return InfoGuiaRemision_SRI_Ride;

           }
           catch (Exception ex)
           {
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return new guiaRemision_Ride_Info();
           }
       }

       public FirmElect.Info.class_sri.Retencion.comprobanteRetencion_Ride_Info consultar_Retencion(int IdEmpresa, string IdComprobante, string IdTipoDocumento
       , string IdEstado_cbte, ref string mensajeErrorOut)
       {
           try
           {

               DateTime sFechaAuto = DateTime.Now;
               string sNum_Autorizacion = "";


               tb_Comprobante_Info InfoCbte = new tb_Comprobante_Info();
               Info.class_sri.Retencion.comprobanteRetencion_Ride_Info InfoCbteReten_SRI_Ride = new comprobanteRetencion_Ride_Info();

               comprobanteRetencion InfoCbteReten_SRI = new comprobanteRetencion();

               InfoCbte = this.consultar(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);

               //leyendo el xml de la base 
               XmlDocument xmlComprobanteOrigen = new XmlDocument();
               xmlComprobanteOrigen.Load(new StringReader(InfoCbte.s_XML));


               //ENCONTRANDO EL NODO TOKEN CON ESTE SE FIRMARA

               XmlNode xmlNode_f;
               XmlNode xmlNode_N_Auto;


               XmlElement root = xmlComprobanteOrigen.DocumentElement;
               xmlNode_f = root.SelectSingleNode("//fechaAutorizacion");

               if (xmlNode_f != null)// es un xml q fue recibido y tiene soap
               {
                   sFechaAuto = Convert.ToDateTime(xmlNode_f.FirstChild.Value);

                   xmlNode_N_Auto = root.SelectSingleNode("//numeroAutorizacion");
                   if (xmlNode_N_Auto == null) // no esta autorizado
                   {
                       sNum_Autorizacion = "NO AUTORIZADO";
                   }
                   else
                   {
                       sNum_Autorizacion = xmlNode_N_Auto.FirstChild.Value;
                   }

                   string sXml_a_descerializar;
                   sXml_a_descerializar = Quitar_a_xml_CDATA_y_Signature(xmlComprobanteOrigen.GetElementsByTagName("comprobante")[0].InnerXml, ref mensajeErrorOut);



                   XmlDocument xmlCbte_a_descr = new XmlDocument();
                   xmlCbte_a_descr.Load(new StringReader(sXml_a_descerializar));


                   InfoCbteReten_SRI = (comprobanteRetencion)Deserialize(xmlCbte_a_descr, InfoCbteReten_SRI.GetType());

               }
               else
               {
                   InfoCbteReten_SRI = (comprobanteRetencion)Deserialize(xmlComprobanteOrigen, InfoCbteReten_SRI.GetType());
               }


               InfoCbteReten_SRI_Ride.cbteRetencion = InfoCbteReten_SRI;
               InfoCbteReten_SRI_Ride.Fecha_Autorizacion = sFechaAuto;
               if (InfoCbteReten_SRI_Ride.cbteRetencion.infoAdicional.Count != 0)
               {
                   foreach (var item in InfoCbteReten_SRI_Ride.cbteRetencion.infoAdicional)
                   {
                       if (item.nombre == "REFERENCIA")
                       {
                           InfoCbteReten_SRI_Ride.REFERENCIA = item.Value;
                       }
                       if (item.nombre == "MAIL")
                       {
                           InfoCbteReten_SRI_Ride.MAIL = item.Value;
                       }
                       if (item.nombre == "OBRA")
                       {
                           InfoCbteReten_SRI_Ride.OBRA = item.Value;
                       }
                       if (item.nombre == "FORMA_PAGO")
                       {
                           InfoCbteReten_SRI_Ride.FORMA_PAGO = item.Value;
                       }
                       if (item.nombre == "FECHA_VENCI")
                       {
                           InfoCbteReten_SRI_Ride.FECHA_VENCI = item.Value;
                       }
                       if (item.nombre == "observaciones")
                       {
                           InfoCbteReten_SRI_Ride.observaciones = item.Value;
                       }
                       if (item.nombre == "DIRECCION_CLIENTE")
                       {
                           InfoCbteReten_SRI_Ride.DIRECCION_CLIENTE = item.Value;
                       }
                   }
               }
               InfoCbteReten_SRI_Ride.Num_Autorizacion = sNum_Autorizacion;

               mensajeErrorOut = "Proceso OK";

               return InfoCbteReten_SRI_Ride;

           }
           catch (Exception ex)
           {
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return new comprobanteRetencion_Ride_Info();
           }
       }


       public string Quitar_a_xml_CDATA_y_Signature(string InnerXml_Cbte, ref string msgError)
       {
           try
           {

               string sXml_a_descerializar = InnerXml_Cbte;
               string sValor_a_Reemplezar_cdata = "<![CDATA[";

               sXml_a_descerializar = sXml_a_descerializar.Replace(sValor_a_Reemplezar_cdata, "");
               sValor_a_Reemplezar_cdata = "]]>";
               sXml_a_descerializar = sXml_a_descerializar.Replace(sValor_a_Reemplezar_cdata, "");

               XmlDocument xml_valido = new System.Xml.XmlDocument();
               xml_valido.LoadXml(sXml_a_descerializar);

               // removiendo los datos de la firma 
               XmlNodeList nodeFirma = xml_valido.GetElementsByTagName("ds:Signature");
               nodeFirma.Item(0).RemoveAll();

               string valorareem = "<ds:Signature xmlns:ds=\"http://www.w3.org/2000/09/xmldsig#\"></ds:Signature>";

               sXml_a_descerializar = xml_valido.InnerXml;
               sXml_a_descerializar = sXml_a_descerializar.Replace(valorareem, "");


               return sXml_a_descerializar;

           }
           catch (Exception ex)
           {
               msgError = ex.Message;
               return "";
           }
       }


       public static object Deserialize(XmlDocument xml, Type type)
       {
           XmlSerializer s = new XmlSerializer(type);
           string xmlString = xml.OuterXml.ToString();
           byte[] buffer = ASCIIEncoding.UTF8.GetBytes(xmlString);
           MemoryStream ms = new MemoryStream(buffer);
           XmlReader reader = new XmlTextReader(ms);
           Exception caught = null;

           try
           {
               object o = s.Deserialize(reader);
               return o;
           }

           catch (Exception e)
           {
               caught = e;
           }
           finally
           {
               reader.Close();

               if (caught != null)
                   throw caught;
           }
           return null;
       }




       public string Get_XML(int IdEmpresa, string IdComprobante,string Estado, ref string mensajeErrorOut)
       {
           try
           {
               string xml = "";
               tb_Comprobante_Info infoXML = new tb_Comprobante_Info();
               using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
               {

                   var q = from C in conexion.tb_Comprobante
                           where
                           C.IdEmpresa == IdEmpresa
                           && 
                           C.IdComprobante == IdComprobante 
                           && C.IdEstado_cbte==Estado
                           select C;

                   foreach (var item in q)
                   {
                       infoXML.s_XML = item.s_XML;
                   }
               }
               mensajeErrorOut = "Proceso OK";

               return xml = infoXML.s_XML;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = ex.InnerException + " " + ex.Message;
               return null;
           }
       }



       public List<tb_Comprobante_Info> consultar_listado_cbte_Autorizados_Enviado_o_NOenviados_x_mail(
           DateTime FechaIni, DateTime FechaFin,int mail_enviado  , ref string mensajeErrorOut)
       {

           try
           {
               List<tb_Comprobante_Info> lista = new List<tb_Comprobante_Info>();

               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                   using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                   {


                       var q = from C in conexion.vw_Comprobante_Autorizados_Enviados_NoEnviados_mail
                               where 
                                      C.Fecha_Emi_Fact >= FechaIni && C.Fecha_Emi_Fact <= FechaFin
                                      && C.mail_enviado == mail_enviado
                                      select C;
                              



                       foreach (var item in q)
                       {
                           tb_Comprobante_Info infoC = new tb_Comprobante_Info();

                           infoC.IdEmpresa = item.IdEmpresa;
                           infoC.IdComprobante = item.IdComprobante;
                           infoC.IdTipoDocumento = item.IdTipoDocumento;
                           infoC.IdEstado_cbte = item.IdEstado_cbte;
                           infoC.Cedula_Ruc = item.Cedula_Ruc;
                           infoC.Numero_Autorizacion = item.Numero_Autorizacion;
                           infoC.RutaArchivo = item.RutaArchivo;
                           infoC.Nombre_file = item.Nombre_file;
                           infoC.s_XML = "xml";
                           infoC.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                           infoC.Fecha_transaccion = item.Fecha_transaccion;
                           infoC.sFecha_transaccion = (item.Fecha_transaccion == null) ? "" : item.Fecha_transaccion.ToString();
                           infoC.FechaAutorizacion = item.FechaAutorizacion;
                           infoC.ClaveContingencia = item.ClaveContingencia;
                           infoC.EstadoDoc = item.EstadoDoc;
                           infoC.Error = item.Error;
                           infoC.IdEstadoProceso = item.IdEstadoProceso;
                           infoC.IdError_Sri = item.IdError_Sri;
                           infoC.Nom_emisor = item.Nom_emisor;
                           infoC.RespuestaSRI = item.RespuestaSRI;
                           infoC.sFechaAutorizacion = (item.FechaAutorizacion == null) ? "" : item.FechaAutorizacion.ToString();

                           infoC.MosTrar_icono_Ride = true;
                           infoC.MosTrar_icono_xml = true;
                           infoC.Mostrar_Icon_Eliminar = true;

                           infoC.Ambiente = item.Ambiente;
                           infoC.Nom_Contribuyente = item.Nom_Contribuyente;
                           infoC.Mostrar_Icono_EnviadoMail = (item.mail_enviado == 0) ? false : true;

                           lista.Add(infoC);
                       }

        
                   }

               

               mensajeErrorOut = "Proceso OK";

               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensajeErrorOut = mensaje;

               return new List<tb_Comprobante_Info>();
           }
       }

   }
}
