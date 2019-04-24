using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
using FirmElect.Info;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Web;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info.class_sri.Retencion;
using FirmElect.Info.class_sri.GuiaRemision;
using DevExpress.XtraReports.UI;



using System.Drawing;


namespace FirmElect.Bus
{
  public  class tb_Comprobante_Bus
    {
      tb_Comprobante_Data Odata;
      tb_Clave_Conting_Bus Bus_Clave_Con = new tb_Clave_Conting_Bus();
      tb_Clave_Conting_Info InfoClaveCont = new tb_Clave_Conting_Info();
      tb_sis_Log_Error_Vzen_Bus BusLogError = new tb_sis_Log_Error_Vzen_Bus();

      static cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;


      public tb_Comprobante_Bus()
      {
          try
          {
              Odata = new tb_Comprobante_Data();
          }
          catch (Exception ex)
          {
                           
          }
      }

      public Boolean GrabarDB(tb_Comprobante_Info Comprobante_info, ref string mensajeOut)
      {
          try
          {
              return Odata.GrabarDB(Comprobante_info, ref mensajeOut);

          }
          catch (Exception ex)
          {

              #region Log de Errores
                  mensajeOut = ex.Message.ToString();
                  tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                  tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR, this.ToString(), "",
                      "", "", "", "", DateTime.Now);
                  oData.Guardar_Log_Error(Log_Error_sis, ref mensajeOut);
              #endregion

              return false;
          }
      }

     
      public Boolean ModificarErrorDB(int IdEmpresa,string IdComprobante,string IdTipoDocumento
          , string IdEstado_cbte , string IdError_sri,string Error,string sRespuestaWs_Sri, ref string mensajeOut)
      {
            try 
            {
                return Odata.ModificarErrorDB(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, IdError_sri, Error,sRespuestaWs_Sri, ref mensajeOut);
		
            }
            catch (Exception ex)
            {
                #region Log de Errores
                    mensajeOut = ex.Message.ToString();
                    tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR, this.ToString(), "",
                        "", "", "", "", DateTime.Now);
                    oData.Guardar_Log_Error(Log_Error_sis, ref mensajeOut);
                #endregion

                return false;
            }
      }


      public Boolean ModificarDB(int IdEmpresa, string IdComprobante, string IdTipoDocumento
          , string IdEstado_cbte, string sRespuestaSRI, string EstadoDoc, eIdEstadoProceso IdEstadoProceso, ref string mensajeOut)
      {
            try 
            {
                return Odata.ModificarDB(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte,sRespuestaSRI,EstadoDoc,IdEstadoProceso,ref mensajeOut);
		
            }
            catch (Exception ex)
            {

                #region Log de Errores
                mensajeOut = ex.Message.ToString();
                tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR, this.ToString(), "",
                    "", "", "", "", DateTime.Now);
                oData.Guardar_Log_Error(Log_Error_sis, ref mensajeOut);
                #endregion

                return false;
            }
      }


      public List<tb_Comprobante_Info> consultar_listado_cbte(int IdEmpresaIni, int IdEmpresaFin, string IdTipoDocIni,string IdTipoDocFin, int Pagina, int Reg_X_Pag, DateTime FechaIni, DateTime FechaFin, List<string> ListadoEstadoCbte
          , string Stipo_Autorizacion, string IdEstadoProceso, string CadenaBusqueda,ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_listado_cbte(IdEmpresaIni, IdEmpresaFin, IdTipoDocIni, IdTipoDocFin,Pagina, Reg_X_Pag, FechaIni, FechaFin, ListadoEstadoCbte, Stipo_Autorizacion, IdEstadoProceso, CadenaBusqueda, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              #region Log de Errores
                  mensajeErrorOut = ex.Message.ToString();
                  tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
                  tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR, this.ToString(), "",
                      "", "", "", "", DateTime.Now);
                  oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
              #endregion

              return new List<tb_Comprobante_Info>();
          }
      }

       public List<tb_Comprobante_Info> consultar_listado_cbte_Pendientes_x_Autoriza(DateTime FechaIni, DateTime FechaFin, List<string> ListadoEstadoCbte,
          string Stipo_Autorizacion, string IdEstadoProceso, string CadenaBusqueda, ref string mensajeErrorOut)
       {


           try
           {

               return Odata.consultar_listado_cbte_Pendientes_x_Autoriza(FechaIni, FechaFin, ListadoEstadoCbte, Stipo_Autorizacion, IdEstadoProceso, CadenaBusqueda, ref mensajeErrorOut);
           }
           catch (Exception ex)
           {

               #region Log de Errores
               mensajeErrorOut = ex.Message.ToString();
               tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "",
                   "", "", "", "", DateTime.Now);
               oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
               #endregion

               return new List<tb_Comprobante_Info>();
           }
       }

       public int ObtenerNumPag(int IdEmpresaIni, int IdEmpresaFin, string IdTipoDocumento, int Registro_x_Pag, DateTime FechaIni, DateTime FechaFin, string Stipo_Autorizacion, string IdEstadoProceso, string cadena_busqueda, string IdEstado_cbte, ref string MensajeErrorOut)
      {
          try
          {
              return Odata.ObtenerNumPagina(IdEmpresaIni, IdEmpresaFin, IdTipoDocumento, Registro_x_Pag, FechaIni, FechaFin, Stipo_Autorizacion, IdEstadoProceso, cadena_busqueda,IdEstado_cbte, ref MensajeErrorOut);
          }
          catch (Exception)
          {
              return 1;
          }
      }

      public List<tb_Comprobante_Info> consultar_listado_cbte_para_exportar(DateTime FechaIni,DateTime FechaFin,eTipoExportacion TipoExportacion,
           ref string mensajeErrorOut)
      {

          try
          {
              return Odata.consultar_listado_cbte_para_exportar(FechaIni, FechaFin, TipoExportacion,ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              #region Log de Errores
              mensajeErrorOut = ex.Message.ToString();
              tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "",
                  "", "", "", "", DateTime.Now);
              oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
              #endregion

              return new List<tb_Comprobante_Info>();
          }
      }
    

      public String GeneraClaveAcceso(DateTime fechaEmision, String tipoComprobante, String ruc, String ambiente, String serie
          , String numeroComprobante, String codigoNumerico, String tipoEmision)
      {
          try
          {
              if ((ruc != null) && (ruc.Length < 13))
              {
                  ruc = String.Format("%013d", new Object[] { ruc });
              }
              String fecha = fechaEmision.ToString("ddMMyyyy");
              StringBuilder clave = new StringBuilder(fecha);
              clave.Append(tipoComprobante);
              clave.Append(ruc);
              clave.Append(ambiente);
              clave.Append(serie);
              clave.Append(numeroComprobante);
              clave.Append(codigoNumerico);
              clave.Append(tipoEmision);
              return clave.ToString();
          }
          catch (Exception ex)
          {
              string mensajeErrorOut = "";
              #region Log de Errores
              mensajeErrorOut = ex.Message.ToString();
              tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "",
                  "", "", "", "", DateTime.Now);
              oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
              #endregion

              return "";
          }
      }


      public String GeneraClaveAcceso_x_Contingencia(int IdEmpresa, DateTime fechaEmision, String tipoComprobante,String Ambiente,string Emision,  ref string mensajeErrorOut)
      {
          try
          {
              
              InfoClaveCont = Bus_Clave_Con.consultar_ult_clave_no_usada(IdEmpresa,Convert.ToInt32(Ambiente), ref mensajeErrorOut);

              //no tiene clave de contingencia
              if (InfoClaveCont == null || InfoClaveCont.ClaveContingencia == null)
              {

                  mensajeErrorOut = @"no existe claves de contingencia disponibles y no se pudo conectar al webEfirm";
                  #region Log de Errores
                  BusLogError.Log_Error(mensajeErrorOut, eTipoError.ERROR_VALIDACION, this.ToString());
                  #endregion
                  return "";
              }

              String fecha = fechaEmision.ToString("ddMMyyyy");
              StringBuilder clave = new StringBuilder(fecha); //fecha
              clave.Append(tipoComprobante);                    //tipo cbte tabla 4
              clave.Append(InfoClaveCont.ClaveContingencia);
              clave.Append(Emision);


              return clave.ToString();
          }
          catch (Exception ex)
          {
              //string mensajeErrorOut = "";
              #region Log de Errores
              mensajeErrorOut = ex.Message.ToString();
              tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "",
                  "", "", "", "", DateTime.Now);
              oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
              #endregion

              return "";
          }
      }


      public int GeneraDigitoVerificadorModulo11(String cadena)
      {
          try
          {
              int baseMultiplicador = 7;

              int[] aux = new int[cadena.Length];
              int multiplicador = 2;
              int total = 0;
              int verificador = 0;
              for (int i = aux.Length - 1; i >= 0; i--)
              {
                  aux[i] = Convert.ToInt32(cadena[i].ToString());
                  aux[i] *= multiplicador;
                  multiplicador++;
                  if (multiplicador > baseMultiplicador)
                  {
                      multiplicador = 2;
                  }
                  total += aux[i];
              }
              if ((total == 0) || (total == 1))
              {
                  verificador = 0;
              }
              else
              {
                  verificador = 11 - total % 11 == 11 ? 0 : 11 - total % 11;
              }
              if (verificador == 10)
              {
                  verificador = 1;
              }
              return verificador;
          }
          catch (Exception ex)
          {
              string mensajeErrorOut = "";

              #region Log de Errores
              mensajeErrorOut = ex.Message.ToString();
              tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(),eTipoError.ERROR, this.ToString(), "",
                  "", "", "", "", DateTime.Now);
              oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
              #endregion

              return -1;
          }          
      }

      public tb_Comprobante_Info consultar(int IdEmpresa, string IdComprobante, string IdTipoDocumento
          , string IdEstado_cbte,ref string mensajeErrorOut)
      {

          try
          {
              return Odata.consultar(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new tb_Comprobante_Info();
          }
      }


      public tb_Comprobante_Info consulta_PDF_info(int IdEmpresa, string cedulaRuc, string IdComprobante
       , ref string mensajeErrorOut)
      {

          try
          {
               return Odata.consulta_PDF_info(IdEmpresa, cedulaRuc, IdComprobante, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {
              
               return new tb_Comprobante_Info();
          }
      
      }

      public List<tb_Comprobante_Info> consultar_listado_cbte_pendiente_de_autorizar(ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_listado_cbte_pendiente_de_autorizar(ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new List<tb_Comprobante_Info>();
          }
      }

      #region funciones de Ride
      
      

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


      public FirmElect.Info.class_sri.Factura_V2.factura_Ride_Info consultar_Factura_ride(int IdEmpresa, string IdComprobante, string IdTipoDocumento
  , string IdEstado_cbte, ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_Factura_ride(IdEmpresa, IdComprobante, IdTipoDocumento,IdEstado_cbte,ref mensajeErrorOut);
          }
          catch (Exception ex)
          {
              return new factura_Ride_Info();
              
          }
      }



      public FirmElect.Info.class_sri.NotaCredito.notaCredito_Ride_Info consultar_NotaCredito_Ride(int IdEmpresa, string IdComprobante, string IdTipoDocumento
, string IdEstado_cbte, ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_NotaCredito_Ride(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new notaCredito_Ride_Info();
          }
      }


      public FirmElect.Info.class_sri.NotaDebito.notaDebito_Ride_Info consultar_NotaDebito(
          int IdEmpresa, string IdComprobante, string IdTipoDocumento
      , string IdEstado_cbte, ref string mensajeErrorOut)
      {

          try
          {
              return Odata.consultar_NotaDebito(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new notaDebito_Ride_Info();
          }
      }

      public FirmElect.Info.class_sri.GuiaRemision.guiaRemision_Ride_Info consultar_Guia(int IdEmpresa, string IdComprobante, string IdTipoDocumento
      , string IdEstado_cbte, ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_Guia(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new guiaRemision_Ride_Info();
          }
      }

      public FirmElect.Info.class_sri.Retencion.comprobanteRetencion_Ride_Info consultar_Retencion(int IdEmpresa, string IdComprobante, string IdTipoDocumento
      , string IdEstado_cbte, ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_Retencion(IdEmpresa, IdComprobante, IdTipoDocumento, IdEstado_cbte, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new comprobanteRetencion_Ride_Info();
          }
      }


      #endregion


      public string Quitar_a_xml_CDATA_y_Signature(string InnerXml_Cbte,ref string msgError)
      {
          try
          {
              return Odata.Quitar_a_xml_CDATA_y_Signature(InnerXml_Cbte,ref  msgError);
          }
          catch (Exception ex)
          {
              return "";

          }

      }


      public List<tb_Comprobante_Info> consultar_listado_comprobantes_x_web(int IdEmpresa,
      string cedulaRuc, string TipoComprobante, DateTime FecIni, DateTime FecFin,string buscar
          , int Indice_Pagina, int Tamanio_Pagina, ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_listado_comprobantes_x_web(IdEmpresa,
       cedulaRuc, TipoComprobante, FecIni, FecFin,buscar,Indice_Pagina,Tamanio_Pagina,ref mensajeErrorOut);
          }
          catch (Exception ex)
          {
              //string mensajeErrorOut = "";
              #region Log de Errores
              mensajeErrorOut = ex.Message.ToString();
              tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "",
                  "", "", "", "", DateTime.Now);
              oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
              #endregion
              return new List<tb_Comprobante_Info>();
          }
      }

      public string getXML(int IdEmpresa, string cedulaRuc, string IdComprobante, ref string mensajeErrorOut)
      {

          try
          {
              return Odata.getXML(IdEmpresa, cedulaRuc, IdComprobante, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {          
              #region Log de Errores
              mensajeErrorOut = ex.Message.ToString();
              tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "",
                  "", "", "", "", DateTime.Now);
              oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
              #endregion
              return null;
          }
          
      }


      public string Get_XML(int IdEmpresa, string IdComprobante, ref string mensajeErrorOut)
      {
          try
          {
              return Odata.Get_XML(IdEmpresa, IdComprobante, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {
              #region Log de Errores
              mensajeErrorOut = ex.Message.ToString();
              tb_sis_Log_Error_Vzen_Data oData = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), eTipoError.ERROR, this.ToString(), "",
                  "", "", "", "", DateTime.Now);
              oData.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorOut);
              #endregion
              return null;
          }
      
      }

      public List<tb_Comprobante_Info> consultar_cbte_a_Eliminar(int IdEmpresa, string IdComprobante, ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_hist_de_cbte_a_Eliminar(IdEmpresa, IdComprobante, ref mensajeErrorOut);
          }
          catch (Exception ex)
          {

              return new List<tb_Comprobante_Info>();
          }
      }


      public Boolean Eliminar_Cbte(int IdEmpresa, string IdComprobante,string UsuarioAnulo, string MotivoAnulacion, ref string mensajeErrorOut)
      {
          try
          {
              List<tb_Comprobante_Info> list_a_Eliminar = new List<tb_Comprobante_Info>();
              list_a_Eliminar =consultar_cbte_a_Eliminar(IdEmpresa, IdComprobante, ref mensajeErrorOut);

              tb_Comprobante_Hist_Eliminado_Bus BusCbte_His = new tb_Comprobante_Hist_Eliminado_Bus();
              List<tb_Comprobante_Hist_Eliminado_Info> list_a_Guardar = new List<tb_Comprobante_Hist_Eliminado_Info>();

                foreach (var item in list_a_Eliminar)
                {
                    tb_Comprobante_Hist_Eliminado_Info ItemHis= new tb_Comprobante_Hist_Eliminado_Info();

                    ItemHis.IdEmpresa = item.IdEmpresa;
                    ItemHis.IdComprobante = item.IdComprobante;
                    ItemHis.IdTipoDocumento = item.IdTipoDocumento;
                    ItemHis.IdEstado_cbte = item.IdEstado_cbte;
                    ItemHis.Secuencial = 0;
                    ItemHis.Cedula_Ruc = item.Cedula_Ruc;
                    ItemHis.Numero_Autorizacion = item.Numero_Autorizacion;
                    ItemHis.RutaArchivo = item.RutaArchivo;
                    ItemHis.Nombre_file = item.Nombre_file;
                    ItemHis.s_XML = item.s_XML;
                    ItemHis.Fecha_Emi_Fact = item.Fecha_Emi_Fact;
                    ItemHis.Fecha_transaccion = item.Fecha_transaccion;
                    ItemHis.FechaAutorizacion = item.FechaAutorizacion;
                    ItemHis.ClaveContingencia = item.ClaveContingencia;
                    ItemHis.EstadoDoc = item.EstadoDoc;
                    ItemHis.Error = item.Error;
                    ItemHis.IdEstadoProceso = item.IdEstadoProceso;
                    ItemHis.IdError_Sri = item.IdError_Sri;
                    ItemHis.RespuestaSRI = item.RespuestaSRI;
                    ItemHis.Total = item.Total;
                    ItemHis.Motivo_Anulacion=MotivoAnulacion;
		            list_a_Guardar.Add(ItemHis);
                }

              //grabando en el historico las transacciones a eliminar
                if (BusCbte_His.GrabarDB(list_a_Guardar, UsuarioAnulo,  MotivoAnulacion,ref mensajeErrorOut))
                {
                    Odata.Eliminar_cbte(IdEmpresa, IdComprobante, ref mensajeErrorOut);
                }



              return true;
          }
          catch (Exception ex)
          {

              return false;
          }
      }


      public List<tb_Comprobante_Info> ComprobantesPorEmisor(string RucDestinatario, ref string mensajeError)
      {
          try
          {
              return Odata.ComprobantesPorEmisor(RucDestinatario, ref mensajeError);
          }
          catch (Exception)
          {

              return new List<tb_Comprobante_Info>();
          }
      }

      public tb_Comprobante_Info Comprobante_consulta_Id_Comprobante(int IdEmpresa, string IdComprobante, ref string mensajeError)
      {
          try
          {
              return Odata.Comprobante_consulta_Id_Comprobante(IdEmpresa,IdComprobante, ref mensajeError);

          }
          catch (Exception)
          {

              return new tb_Comprobante_Info();
          }
      }


      public string Get_XML(int IdEmpresa, string IdComprobante, string Estado, ref string mensajeErrorOut)
      {
          try
          {
              return Odata.Get_XML(IdEmpresa, IdComprobante, Estado, ref mensajeErrorOut);

          }
          catch (Exception)
          {

              return "";
          }
      }


      public List<tb_Comprobante_Info> consultar_listado_cbte_Autorizados_Enviado_o_NOenviados_x_mail(
           DateTime FechaIni, DateTime FechaFin, int mail_enviado  ,ref string mensajeErrorOut)
      {
          try
          {
              return Odata.consultar_listado_cbte_Autorizados_Enviado_o_NOenviados_x_mail(FechaIni, FechaFin,mail_enviado  , ref mensajeErrorOut);


          }
          catch (Exception)
          {

              return new List<tb_Comprobante_Info>();
          }
      }

    }

}

