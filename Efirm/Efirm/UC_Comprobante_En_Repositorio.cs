using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using System.IO;
using DevExpress.XtraEditors.Repository;
using System.Diagnostics;
using FirmElect.Info;
using FirmElect.Bus;
using System.Xml;
using DevExpress.XtraSplashForm;
using DevExpress.XtraSplashScreen;
using System.Globalization;
using System.Threading;





namespace Efirm
{
    public partial class UC_Comprobante_En_Repositorio : DevExpress.XtraEditors.XtraUserControl, IDisposable 
    {

        static cl_parametrosGenerales_Info param = cl_parametrosGenerales_Info.Instance;
        fx_funciones_files_Bus BusFx_Files = new fx_funciones_files_Bus();
        BindingList<Archivo_Info> listArchivos = new BindingList<Archivo_Info>();

        tb_Empresa_Info InfoEmpresa;

        public delegate void delegate_fileSystemWatcherRepositorio_Created(object sender, FileSystemEventArgs e,string mensajeOut);
        public event delegate_fileSystemWatcherRepositorio_Created Event_fileSystemWatcherRepositorio_Created;

        List<tb_Empresa_Info> listadoEmpresa = new List<tb_Empresa_Info>();


        tb_sis_Log_Error_Vzen_Bus BusSisLog = new tb_sis_Log_Error_Vzen_Bus();

        Thread HiloValidar;

        tb_comprobante_x_valor_Info info_comprobante_x_valor ;
        tb_comprobante_x_valor_Bus bus_comprobante_valor = new tb_comprobante_x_valor_Bus();

        private void Optener_list_empresa()
        {

            try
            {
                string mensajeErrorOut = "";
                tb_Empresa_Bus EmprBus = new tb_Empresa_Bus();
                listadoEmpresa = EmprBus.GetEmpresas(ref mensajeErrorOut);


            }
            catch (Exception ex)
            {

                BusSisLog.Log_Error(ex.Message.ToString() , eTipoError.ERROR, this.ToString());                
            }
        
        }

        public UC_Comprobante_En_Repositorio()
        {
            try
            {
                InitializeComponent();

                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-EC");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-EC");

                //CultureInfo.CurrentCulture
                
                Event_fileSystemWatcherRepositorio_Created += UC_Comprobante_recibido_Event_fileSystemWatcherRepositorio_Created;
                Optener_list_empresa();
                set_directorio_repositorio();
                uC_Horario_Actividades1.event_Disparador_horario+=uC_Horario_Actividades1_event_Disparador_horario;
                gridControlDirectorio.DataSource = listArchivos;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString() + " public UC_Comprobante_recibido()", eTipoError.ERROR, this.ToString());
                
            }

            

        }

        private void set_directorio_repositorio()
        {
            try
            {

                string PathComprobantesRepositorio = param.RutaComprobantesRepositorio;

                txt_ruta.Text = PathComprobantesRepositorio;
               // fileSystemWatcherRepositorio.Path = PathComprobantesRepositorio;


                

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
               
            }
        }

        void UC_Comprobante_recibido_Event_fileSystemWatcherRepositorio_Created(object sender, FileSystemEventArgs e, string mensajeOut)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int countSegundosSensor_archivo_nuevo = 0;

        private void timerSensor_archivos_nuevos_Tick(object sender, EventArgs e)
        {
            try
            {

                // detengo el orquestador de procesos
                //countSegundosSensor_archivo_nuevo  ya esta inicicado con el evento
                
                btn_refrescar_direc.Text = "Refrescar Directorio(" + countSegundosSensor_archivo_nuevo + ")";

                if (countSegundosSensor_archivo_nuevo <= 0)
                {
                    //TiempoEspera_Proceso1 viene del evento
                    countSegundosSensor_archivo_nuevo = TiempoEspera_Proceso1;
                    timerSensor_archivos_nuevos.Enabled = false;// apago este proceso 
                    cargar_file_desde_directorio();
                    timerContadorValidarArchivo.Enabled = true; // prendo el sigueinte proceso
                    gridControlDirectorio.RefreshDataSource();

            //        DisparoWatcher = true; // poder volver a disparar 

                }
                countSegundosSensor_archivo_nuevo = countSegundosSensor_archivo_nuevo - 1;


            }
            catch (Exception ex)
            {
                timerSensor_archivos_nuevos.Enabled = false;
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
            
        }

        private void btn_refrescar_direc_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_file_desde_directorio();
                gridControlDirectorio.RefreshDataSource();

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }
            
        }

        private void btn_buscar_directorio_Click(object sender, EventArgs e)
        {
            try
            {

                FolderBrowserDialog FolderDia = new FolderBrowserDialog();
                FolderDia.ShowDialog();

                txt_ruta.Text = FolderDia.SelectedPath;


                //fileSystemWatcherRepositorio.Path = txt_ruta.Text;

                //cargar_file_desde_directorio(txt_ruta.Text);
                cargar_file_desde_directorio();

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }

        }



        void cargar_file_desde_directorio()
        {

            try
            {

                //splashEsperar.ShowWaitForm();
                string Patch = "";

                Patch = txt_ruta.Text;

                listArchivos.Clear();
                


                // System.IO.DriveInfo di = new System.IO.DriveInfo(@Patch);

                // Get the root directory and print out some information about it.
                System.IO.DirectoryInfo dirInfo = new DirectoryInfo(Patch);


                // Get the files in the directory and print out some information about them.
                System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.xml");



                // linea datasource q carga

                decimal cReg = 0;

                foreach (var itemFile in fileNames)
                {
                    Archivo_Info itemAr = new Archivo_Info();

                    itemAr.Checked = true;
                    itemAr.CreationTime = itemFile.CreationTime;
                    itemAr.Estado_Valicion = "";
                    itemAr.Extension = itemFile.Extension;
                    itemAr.FullName = itemFile.FullName;
                    itemAr.LastAccessTime = itemFile.LastAccessTime;
                    itemAr.Length = itemFile.Length;
                    itemAr.mensaje_error_validacion = "";
                    itemAr.Name = itemFile.Name;
                    cReg = cReg + 1;
                    itemAr.NumRegistro = cReg;
                    itemAr.EsSoloLectura = itemFile.IsReadOnly;
                    
                    

                    listArchivos.Add(itemAr);

                }




            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

                
            }
            



        }

        private void gridControlFiles_Click(object sender, EventArgs e)
        {

        }


        void validar()
        {
            Boolean FileValido = false;

            try
            {
                foreach (var item in listArchivos)
                {
                    //Application.DoEvents();

                    otras_Validaciones_Quitando_Tildes_y_Caracteres_Especiales(item);

                    // cargando el file y leyendo el tag de tipo de documento
                    XmlDocument xmlcomprobante = new XmlDocument();

                    try
                    {
                        xmlcomprobante.Load(item.FullName);
                    }
                    catch (Exception ex)
                    {
                        FileValido = false;
                        item.mensaje_error_validacion = "no se puede convertir a file xml " + ex.Message;
                        continue;

                    }

                    Validar_tag_basicos_xml(xmlcomprobante, item);
                    Arreglar_archivos(xmlcomprobante, item);
                    validar_archivos_con_xsd(xmlcomprobante, item);
                    otras_Validaciones_antes_subir_efirm(xmlcomprobante, item);
                    
                }
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
        }

        private void btn_validar_xml_Click(object sender, EventArgs e)
        {
            try
            {



                #region Opteniendo los files chequeados

                filesCount = 0;
                foreach (var item in listArchivos)
                {
                    if (item.Checked == true)
                        filesCount = filesCount + 1;
                }
                #endregion

                validar();

                
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
                
            }
        
        }

        void validar_archivos_con_xsd(XmlDocument xmlcomprobante,Archivo_Info item)
        {
            try
            {
            string tipocomp = "";
            tb_Comprobante_Bus ComproBus = new tb_Comprobante_Bus();
            string mensajeError = "";
            Boolean FileValido=true;


            //foreach (var item in listArchivos)
            //{
                Application.DoEvents();

                // cargando el file y leyendo el tag de tipo de documento
               // XmlDocument xmlcomprobante = new XmlDocument();
                //xmlcomprobante.Load(item.FullName);

                try
                {

                   
                    tipocomp = xmlcomprobante.GetElementsByTagName("codDoc")[0].InnerText.Trim();



                }
                catch (Exception ex)
                {

                    item.Estado_Valicion = "ERROR";
                    item.mensaje_error_validacion = ex.Message;
                    tipocomp = "";
                    FileValido=false;
                }

                string mensaje = "";


                switch (tipocomp)
                {
                    case "01":
                        factura_Bus factBus = new factura_Bus();
                        if (factBus.Validar_xml_vs_sxd(xmlcomprobante, ref mensaje))
                        {
                            item.Estado_Valicion = (item.Estado_Valicion == "ERROR") ? "ERROR" : "VALIDO";
                            FileValido=true;
                        }
                        else
                        {
                            item.Estado_Valicion = "ERROR";
                            FileValido=false;
                        }


                        item.mensaje_error_validacion = item.mensaje_error_validacion  + mensaje;

                        break;
                    case "04":

                        notaCredito_Bus Bus_nota_cred = new notaCredito_Bus();
                        if (Bus_nota_cred.Validar_xml_vs_sxd(xmlcomprobante, ref mensaje))
                        {
                            item.Estado_Valicion = (item.Estado_Valicion == "ERROR") ? "ERROR" : "VALIDO";
                            FileValido=true;
                        }
                        else
                        {
                            item.Estado_Valicion = "ERROR";
                            FileValido=false;
                        }
                        
                        item.mensaje_error_validacion = item.mensaje_error_validacion + mensaje;
                        break;
                    case "05":

                        notaDebito_Bus Bus_nota_deb = new notaDebito_Bus();
                        if (Bus_nota_deb.Validar_xml_vs_sxd(xmlcomprobante, ref mensaje))
                        {
                            item.Estado_Valicion = (item.Estado_Valicion == "ERROR") ? "ERROR" : "VALIDO";
                            FileValido=true;
                        }
                        else
                        {
                            item.Estado_Valicion = "ERROR";
                            FileValido=false;
                        }
                        item.mensaje_error_validacion = item.mensaje_error_validacion + mensaje;
                        break;
                    case "06":
                        fx_GuiaRemision_Bus Bus_guia = new fx_GuiaRemision_Bus();
                        if (Bus_guia.Validar_xml_vs_sxd(xmlcomprobante, ref mensaje))
                        {
                            item.Estado_Valicion = (item.Estado_Valicion == "ERROR") ? "ERROR" : "VALIDO";
                            FileValido=true;
                        }
                        else
                        {
                            item.Estado_Valicion = "ERROR";
                            FileValido=false;

                        }
                        item.mensaje_error_validacion = item.mensaje_error_validacion + mensaje;
                        break;
                    case "07":

                        comprobanteRetencion_Bus Bus_ret = new comprobanteRetencion_Bus();
                        if (Bus_ret.Validar_xml_vs_sxd(xmlcomprobante, ref mensaje))
                        {
                            item.Estado_Valicion = (item.Estado_Valicion == "ERROR") ? "ERROR" : "VALIDO";
                            FileValido=true;
                        }
                        else
                        {
                            item.Estado_Valicion = "ERROR";
                            FileValido=false;
                        }
                        item.mensaje_error_validacion = item.mensaje_error_validacion + mensaje;
                        break;
                    default:
                        item.Estado_Valicion = "ERROR";
                        mensaje = "Archivo no  tiene el tag codDoc o no es un xml valido del SRI";
                        item.mensaje_error_validacion = item.mensaje_error_validacion + mensaje;
                        FileValido=false;
                        break;
                }

            //}

           

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }

        }

        void Arreglar_archivos(XmlDocument xmlcomprobante, Archivo_Info item)
        {

            try
            {


            

            string tipocomp = "";
            tb_Comprobante_Bus ComproBus = new tb_Comprobante_Bus();

            DateTime FechaEmision;
            string sFechaEmision;
            string RucEmisor = "";
            string serie = "";
            string numcbte = "";
            string ptoEmi = "";
            string estable = "";
            string codNumerico = "";
            string ambiente = "";
            string tipoemision = "";
            string claveAcceso = "";
            int digitoVer = 0;
            string sMail = "";

            string mensajeError = "";
            Boolean FileValido = true;


            InfoEmpresa = new tb_Empresa_Info();
            RucEmisor = xmlcomprobante.GetElementsByTagName("ruc")[0].InnerText.Trim();
            InfoEmpresa = listadoEmpresa.Find(v => v.RUC.Trim() == RucEmisor.Trim());

            if (InfoEmpresa == null)
            {
                mensajeError = "Ruc de Emisor de este XML no coincide con la base de Emisores de EFIRM: Ruc Emisor xml:" + RucEmisor;

                item.mensaje_error_validacion = mensajeError;
                item.Estado_Valicion = "ERROR";
                FileValido = false;
                //continue;
            }      


            //foreach (var item in listArchivos)
            //{

                Application.DoEvents();

                if (item.Checked == true)
                {

                    //// cargando el file y leyendo el tag de tipo de documento
                    //XmlDocument xmlcomprobante = new XmlDocument();
                    //xmlcomprobante.Load(item.FullName);
                    FileValido = true;


                    

                    try
                    {

                        if (item.EsSoloLectura)
                        {
                            mensajeError = "Este Archivo esta de SOLO LECTURA .. no se puede sobreescribir las variables de Emision y clave de acceso  ";
                            item.mensaje_error_validacion = mensajeError;
                            item.Estado_Valicion = "ERROR";
                            FileValido = false;
                            //continue;
                        }

                        


                        string String=xmlcomprobante.InnerXml;
                        // quitando los enter 
                        String = String.Replace(System.Environment.NewLine, "");

                        xmlcomprobante.InnerXml = String;
                        

                        try
                        {
                            // arreglando para ponerle Utf y version si no hay lo agrega sino no
                            XmlDeclaration xmldecl;
                            xmldecl = xmlcomprobante.CreateXmlDeclaration("1.1", "utf-8", null);

                            //Add the new node to the document.
                            XmlElement root = xmlcomprobante.DocumentElement;
                            xmlcomprobante.InsertBefore(xmldecl, root);
                        }
                        catch (Exception ex)
                        {
                            
                            
                        }
                        
                        
                        // arreglando para ponerle Utf y version

                        tipocomp = xmlcomprobante.GetElementsByTagName("codDoc")[0].InnerText.Trim();
                      

                        //TipoCbte


                        

                        if (tipocomp == "06")//diferente de guia no tienen este tag 
                        {
                            FechaEmision = DateTime.Parse(xmlcomprobante.GetElementsByTagName("fechaIniTransporte")[0].InnerText.Trim(),new CultureInfo("es-EC"));



                            
                        }
                        else
                        {
                            FechaEmision = DateTime.Parse(xmlcomprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                        }


                       



                        RucEmisor = xmlcomprobante.GetElementsByTagName("ruc")[0].InnerText.Trim();
                        numcbte = xmlcomprobante.GetElementsByTagName("secuencial")[0].InnerText.Trim();
                        ptoEmi = xmlcomprobante.GetElementsByTagName("ptoEmi")[0].InnerText.Trim();
                        estable = xmlcomprobante.GetElementsByTagName("estab")[0].InnerText.Trim();

                        serie = xmlcomprobante.GetElementsByTagName("estab")[0].InnerText.Trim() + xmlcomprobante.GetElementsByTagName("ptoEmi")[0].InnerText.Trim();



                        



                        ambiente = (InfoEmpresa.cod_Ambiente == "PRUE") ? "1" : "2";
                        tipoemision = "1";// (InfoEmpresa.cod_TipoEmision == "NORMAL") ? "1" : "2";


                        codNumerico = "12345678";

                        /// asigando valores de ambiente y tipo emision y clave de acceso
                        xmlcomprobante.GetElementsByTagName("ambiente")[0].InnerText = ambiente;
                        xmlcomprobante.GetElementsByTagName("tipoEmision")[0].InnerText = tipoemision;

                        item.Ambiente = (ambiente=="1")?"PRUEBAS":"PRODUCCION";



                        //FechaEmision = sFechaEmision;


                        claveAcceso = ComproBus.GeneraClaveAcceso(FechaEmision, tipocomp, RucEmisor, ambiente, serie, numcbte, codNumerico, tipoemision);
                        digitoVer = ComproBus.GeneraDigitoVerificadorModulo11(claveAcceso);

                        var clave = xmlcomprobante.GetElementsByTagName("claveAcceso")[0].InnerText;

                        xmlcomprobante.GetElementsByTagName("claveAcceso")[0].InnerText = claveAcceso + digitoVer;
                        if (xmlcomprobante.GetElementsByTagName("claveAcceso")[0].InnerText == "0000000000000000000000000000000000000000000000000")
                        {
                            
                        }
                                    


                    }
                    catch (Exception ex)
                    {
                        if (InfoEmpresa == null)
                        {
                            item.mensaje_error_validacion = mensajeError;
                           
                        }
                        else
                        {
                            item.mensaje_error_validacion = mensajeError = ex.Message; 
                        }
                       
                        item.Estado_Valicion = "ERROR";
                        FileValido = false;
                        tipocomp = "";
                        //continue;
                        
                    }

                    



                   
                     

                    if (FileValido == true)
                    {
                        xmlcomprobante.Save(item.FullName);
                    }


                }

           // }//finfor



            


            }
            catch (Exception ex)
            {
               // gridControlDirectorio.RefreshDataSource();
                //MessageBox.Show(ex.Message);
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

                
            }

        }

        void Validar_tag_basicos_xml(XmlDocument xmlcomprobante, Archivo_Info item)
        {
           
            try
            {


                string tipocomp = "";
                tb_Comprobante_Bus ComproBus = new tb_Comprobante_Bus();

                DateTime FechaEmision;
                string RucEmisor = "";
                string serie = "";
                string numcbte = "";
                string ptoEmi = "";
                string estab = "";
                string codNumerico = "";
                string ambiente = "";
                string tipoemision = "";
                string claveAcceso = "";
                int digitoVer = 0;
                string TagFacturaCab = "";
                string IdComprobante = "";
                string Secuencial_doc="";


                string mensajeError = "";
                Boolean FileValido = true;


                


                

                //foreach (var item in listArchivos)
                //{

                    Application.DoEvents();

                    if (item.Checked == true)
                    {

                           

                            try
                            {

                                string SXmlVa = Funciones.Formating_xml(xmlcomprobante.InnerXml);
                                XmlDocument xmlOrigen = new XmlDocument();
                                xmlOrigen.Load(new StringReader(SXmlVa));
                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "Error en el XML Revise Caracteres Espciales  " + ex.Message;
                                item.Estado_Valicion = "ERROR";
                                //continue;
                            }

                        ///================================================================================================


                            try
                            {
                                int h = xmlcomprobante.InnerXml.IndexOf("id=\"comprobante\"");

                                if (h <0)
                                {
                                    FileValido = false;
                                    item.mensaje_error_validacion = "el nodo Raiz : <factura id=comprobante>";
                                  //  continue;
                                }

                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "el nodo Raiz : <factura id=comprobante>" + ex.Message;
                                item.Estado_Valicion = "ERROR";
                                //continue;
                                
                            }

                            

                            

                            try
                            {


                                


                                tipocomp = xmlcomprobante.GetElementsByTagName("codDoc")[0].InnerText.Trim();

                                if (tipocomp == "")
                                {
                                    FileValido = false;
                                    item.mensaje_error_validacion = "No el tag codDoc es en blanco";
                                    item.Estado_Valicion = "ERROR";
                                  //  continue;
                                }

                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "No tiene el tag codDoc" + ex.Message;
                                //continue;
                            }



                            if (tipocomp != "06")//diferente de guia no tienen este tag 
                            {

                                try
                                {
                                    

                                    FechaEmision = DateTime.Parse(xmlcomprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));



                                    

                                    if (xmlcomprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim() == "")
                                    {
                                        FileValido = false;
                                        item.mensaje_error_validacion = "El tag FechaEmision es en blanco";
                                        //continue;
                                    }

                                }
                                catch (Exception ex)
                                {
                                    FileValido = false;
                                    item.mensaje_error_validacion = "No tiene el tag fechaEmision" + ex.Message;
                                    item.Estado_Valicion = "ERROR";
                                  //  continue;
                                }
                            }






                          

                        


                        ///
                            try
                            {
                                RucEmisor = xmlcomprobante.GetElementsByTagName("ruc")[0].InnerText.Trim();

                                if (RucEmisor == "")
                                {
                                    FileValido = false;
                                    item.mensaje_error_validacion = "El RucEmisor  es en blanco";
                                    item.Estado_Valicion = "ERROR";
                                    //continue;
                                }

                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "No tiene el tag ruc" + ex.Message;
                                item.Estado_Valicion = "ERROR";
                                //continue;
                            }

                            try
                            {
                                numcbte = xmlcomprobante.GetElementsByTagName("secuencial")[0].InnerText.Trim();


                                if (numcbte.Length != 9)
                                {
                                    FileValido = false;
                                    item.mensaje_error_validacion = "el valor del secuencial debe tener 9 digitos";
                                    item.Estado_Valicion = "ERROR";
                                }

                                int i = 0;
                                bool result = int.TryParse(numcbte, out i); //i now = 108

                                if (result == false)
                                {
                                    FileValido = false;
                                    item.mensaje_error_validacion = "el valor del secuencial no es un numero no puede contener caracteres especiales";
                                    item.Estado_Valicion = "ERROR";
                                }


                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "No tiene el tag secuencial" + ex.Message;
                                item.Estado_Valicion = "ERROR";
                                //continue;
                            }


                            try
                            {
                                ptoEmi = xmlcomprobante.GetElementsByTagName("ptoEmi")[0].InnerText.Trim();

                                if (ptoEmi == "")
                                {
                                    FileValido = false;
                                    item.mensaje_error_validacion = "El ptoEmi  es en blanco";
                                    item.Estado_Valicion = "ERROR";
                                    //continue;
                                }

                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "No tiene el tag ptoEmi" + ex.Message;
                                item.Estado_Valicion = "ERROR";
                                //continue;
                            }

                            try
                            {
                                estab = xmlcomprobante.GetElementsByTagName("estab")[0].InnerText.Trim();

                                if (estab == "")
                                {
                                    FileValido = false;
                                    item.mensaje_error_validacion = "El estable  es en blanco";
                                    item.Estado_Valicion = "ERROR";
                                    //continue;
                                }

                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "No tiene el tag estab" + ex.Message;
                                item.Estado_Valicion = "ERROR";
                                //continue;
                            }


                            try
                            {
                                ambiente=xmlcomprobante.GetElementsByTagName("ambiente")[0].InnerText ;
                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "No tiene el tag ambiente" + ex.Message;
                                item.Estado_Valicion = "ERROR";
                                //continue;
                            }


                            try
                            {
                                tipoemision=xmlcomprobante.GetElementsByTagName("tipoEmision")[0].InnerText ;
                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "No tiene el tag tipoEmision" + ex.Message;
                                item.Estado_Valicion = "ERROR";
                                //continue;
                            }

                            try
                            {
                                claveAcceso=xmlcomprobante.GetElementsByTagName("claveAcceso")[0].InnerText;
                              
                            }
                            catch (Exception ex)
                            {
                                FileValido = false;
                                item.mensaje_error_validacion = "No tiene el tag claveAcceso" + ex.Message;
                                item.Estado_Valicion = "ERROR";
                                //continue;
                            }



                            estab = xmlcomprobante.GetElementsByTagName("estab")[0].InnerText.Trim();
                            ptoEmi = xmlcomprobante.GetElementsByTagName("ptoEmi")[0].InnerText.Trim();
                            Secuencial_doc = xmlcomprobante.GetElementsByTagName("secuencial")[0].InnerText.Trim();


                            switch (tipocomp)
                            {
                                case "01"://factura
                                    IdComprobante = "FA-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                    break;
                                case "04"://nota cred
                                    IdComprobante = "NC-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                    break;
                                case "05"://nota dev
                                    IdComprobante = "ND-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                    break;
                                case "06"://guia
                                    IdComprobante = "GUI-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                    break;
                                case "07"://retencion
                                    IdComprobante = "RT-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                    break;
                            }

                            item.TipoCbte = IdComprobante;

                            

                          
                    }

                //}//finfor

                
               

            

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }

        }

        private void UC_Comprobante_recibido_Load(object sender, EventArgs e)
        {
            try
            {
                //cargar_file_desde_directorio(param.PathComprobantesRepositorio);
                cargar_file_desde_directorio();
                xtraTabPageHorariosActividades.Show();
                xtraTabControlXMLRecibidos.Show();

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }
        }

        private Boolean DisparoWatcher=true;

        private void fileSystemWatcherRepositorio_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                

                if (DisparoWatcher == true)
                {
                    Event_fileSystemWatcherRepositorio_Created(sender, e, "Nuevo xml en repositorio: ");
                    btn_validarArchivoXml.Text = "Validar Archivos Xml (0)";
                    btn_refrescar_direc.Text = "Refrescar Directorio(0)";
                    btn_subir_file_efirm.Text = "Subir a Efirm (0)";
                    timerSensor_archivos_nuevos.Enabled = true;

                    TiempoEspera_Proceso1 = 10;
                    TiempoEspera_Proceso2 = 10;
                    TiempoEspera_Proceso3 = 10;
                    DisparoWatcher = false;
                }
                

                


            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void gridControlDirectorio_Click(object sender, EventArgs e)
        {

        }

        private void gridViewDirectorio_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewDirectorio.GetRow(e.RowHandle) as Archivo_Info;
                if (data == null)
                    return;
                if (data.Estado_Valicion.ToString() == "ERROR")
                {
                    e.Appearance.ForeColor = Color.Red;
                }

                if (data.Estado_Valicion.ToString() == "WARNING")
                {
                    e.Appearance.ForeColor = Color.Orange;
                }

                


            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
        }

        private void gridViewDirectorio_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

                string mensaje = "";


                switch (e.Column.Name)
                {
                    case "colName":



                        // cargando el file y leyendo el tag de tipo de documento
                        string fulname = (string)gridViewDirectorio.GetFocusedRowCellValue(colFullName);
                        XmlDocument comprobante = new XmlDocument();

                        try
                        {
                            comprobante.Load(fulname);

                            if (comprobante.InnerXml != "")
                            {

                                frmMensaje frmsg = new frmMensaje();
                                frmsg.richTextBoxMensaje.Text = Funciones.Formating_xml(comprobante.InnerXml);
                                frmsg.ShowDialog();




                            }


                        }
                        catch (Exception ex)
                        {

                           // BusSisLog.Log_Error(ex.Message.ToString() + " comprobante.Load(fulname);", eTipoError.ERROR_VALIDACION, this.ToString());

                            mensaje = ex.Message;

                             mensaje =mensaje + " " + (string)gridViewDirectorio.GetFocusedRowCellValue(e.Column);


                            if (mensaje != "")
                            {

                                frmMensaje frmsg = new frmMensaje();
                                frmsg.richTextBoxMensaje.Text = mensaje;
                                frmsg.ShowDialog();
                            }

                        }



                        break;

                    default:

                         mensaje = (string)gridViewDirectorio.GetFocusedRowCellValue(e.Column);


                    if (mensaje != "")
                    {

                        frmMensaje frmsg = new frmMensaje();
                        frmsg.richTextBoxMensaje.Text = mensaje;
                        frmsg.ShowDialog();
                    }

                        break;

                }

               
               




            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }



        }

        private void btn_subir_file_efirm_Click(object sender, EventArgs e)
        {
            try
            {
                #region Opteniendo los files chequeados

                txt_ruta.Focus();

                filesCount = 0;
                foreach (var item in listArchivos)
                {
                    if (item.Checked == true)
                        filesCount = filesCount + 1;
                }
                #endregion
                if (filesCount > 0)
                {
                   
                    Subir_archivos_a_efirm();
                }



            }
            catch (Exception ex)
            {
                
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }


        }

        void Subir_archivos_a_efirm()
        {
            try
            {
                string tipocomp = "";
                string mensajeError = "";
                DateTime? fechaEmision_Docu = null;

                string estab = "";
                string ptoEmi = "";
                string IdComprobante = "";
                string IdTipoDocumento = "";
                string IdEstado_cbte = "";
                string Secuencial_doc = "";
                string Clave_Acceso = "";
                string ruc_emisor = "";
                string cedula_ruc_cliente_prov = "";
                int IdEmisor = 0;
                string RasonSocial_Comprador = "";
                bool EsCliente=false;
                bool EsProveedor=false;
                string sMail="";
                string sMail1 = "";
                string sMail2 = "";
                string Observacion="";
                double total = 0;


                tb_Comprobante_Bus factBus = new tb_Comprobante_Bus();
                tb_Comprobante_Info Comprobante_Info = new tb_Comprobante_Info();
                string sEstadoXmlFile = "";
                
                foreach (var item in listArchivos)
                {
                    Application.DoEvents();

                    if (item.Checked == true)
                    {

                        sMail = "";
                        sMail1 = "";
                        sMail2 = "";


                        if (item.Estado_Valicion.Trim() == "ERROR")//PASAR ESTOS FILES A CARPTA DE ERRORES
                        {

                            mover_file_desde_repositorio_x_errores(item, ref mensajeError);
                        }

                        if (item.Estado_Valicion.Trim() == "VALIDO")//SOLO CARGO LOS FILES VALIDOS 
                        {
                            //cargando el xml 
                            try
                            {
                                XmlDocument comprobante = new XmlDocument();

                                comprobante.Load(item.FullName);


                                ruc_emisor = comprobante.GetElementsByTagName("ruc")[0].InnerText.Trim();
                                tipocomp = comprobante.GetElementsByTagName("codDoc")[0].InnerText.Trim();
                                estab = comprobante.GetElementsByTagName("estab")[0].InnerText.Trim();
                                ptoEmi = comprobante.GetElementsByTagName("ptoEmi")[0].InnerText.Trim();
                                Secuencial_doc = comprobante.GetElementsByTagName("secuencial")[0].InnerText.Trim();
                                Clave_Acceso = comprobante.GetElementsByTagName("claveAcceso")[0].InnerText.Trim();
                                //total = Convert.ToDouble(comprobante.GetElementsByTagName("importeTotal")[0].InnerText.Trim());
                                

                                if (tipocomp == "04")
                                    total = Convert.ToDouble(comprobante.GetElementsByTagName("valorModificacion")[0].InnerText.Trim());

                                //traigo el mail del xml si no esta no se enviara el correo 
                                try
                                {
                                    //ENCONTRANDO EL NODO mail1
                                    XmlNode oldCd;
                                    XmlElement root = comprobante.DocumentElement;
                                    //if (root.SelectSingleNode("//campoAdicional[@nombre='" + "MAIL" + "']") == "")
                                    oldCd = root.SelectSingleNode("//campoAdicional[@nombre='" + "MAIL" + "']");
                                    if(oldCd == null)
                                        oldCd = root.SelectSingleNode("//campoAdicional[@nombre='" + "CliEmail" + "']");
                                    sMail = oldCd.FirstChild.Value;
                                    
                                }
                                catch (Exception ex)
                                {
                                }


                                try
                                {
                                   //ENCONTRANDO EL NODO mail1
                                    XmlNode oldCd;
                                    XmlElement root = comprobante.DocumentElement;
                                    oldCd = root.SelectSingleNode("//campoAdicional[@nombre='" + "MAIL1" + "']");
                                    sMail1 = oldCd.FirstChild.Value;
                                }
                                catch (Exception ex)
                                {
                                }

                                try
                                {
                                    //ENCONTRANDO EL NODO mail1
                                    XmlNode oldCd;
                                    XmlElement root = comprobante.DocumentElement;
                                    oldCd = root.SelectSingleNode("//campoAdicional[@nombre='" + "MAIL2" + "']");
                                    sMail2 = oldCd.FirstChild.Value;
                                }
                                catch (Exception )
                                {
                                }
                                
                                /// buscando el idemisor

                                InfoEmpresa = new tb_Empresa_Info();

                                InfoEmpresa = listadoEmpresa.Find(v => v.RUC == ruc_emisor);

                                if (InfoEmpresa == null)
                                {
                                    mensajeError = "Ruc de Emisor de este XML no coincide con la base de Emisores de EFIRM: Ruc Emisor xml:" + ruc_emisor;

                                    item.mensaje_error_validacion = mensajeError;
                                    item.Estado_Valicion = "ERROR";
                                }
                                else
                                {
                                    switch (tipocomp)
                                    {
                                        case "01"://factura
                                            IdComprobante = "FA-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                            total = Convert.ToDouble(comprobante.GetElementsByTagName("importeTotal")[0].InnerText);
                                            

                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                            
                                            cedula_ruc_cliente_prov = comprobante.GetElementsByTagName("identificacionComprador")[0].InnerText.Trim();
                                            RasonSocial_Comprador = comprobante.GetElementsByTagName("razonSocialComprador")[0].InnerText.Trim();
                                            EsCliente = true;
                                            break;
                                        case "04"://nota cred
                                            IdComprobante = "NC-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                            total = Convert.ToDouble(comprobante.GetElementsByTagName("valorModificacion")[0].InnerText);
                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                            cedula_ruc_cliente_prov = comprobante.GetElementsByTagName("identificacionComprador")[0].InnerText.Trim();
                                            RasonSocial_Comprador = comprobante.GetElementsByTagName("razonSocialComprador")[0].InnerText.Trim();
                                            EsCliente = true;
                                            break;
                                        case "05"://nota dev
                                            IdComprobante = "ND-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                            total = Convert.ToDouble(comprobante.GetElementsByTagName("valorTotal")[0].InnerText);
                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                            cedula_ruc_cliente_prov = comprobante.GetElementsByTagName("identificacionComprador")[0].InnerText.Trim();
                                            RasonSocial_Comprador = comprobante.GetElementsByTagName("razonSocialComprador")[0].InnerText.Trim();
                                            EsCliente = true;
                                            break;
                                        case "06"://guia
                                            IdComprobante = "GUI-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                            RasonSocial_Comprador = comprobante.GetElementsByTagName("razonSocialDestinatario")[0].InnerText.Trim();
                                            cedula_ruc_cliente_prov = comprobante.GetElementsByTagName("identificacionDestinatario")[0].InnerText.Trim();
                                            EsCliente = true;
                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaIniTransporte")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                            break;
                                        case "07"://retencion
                                            IdComprobante = "RT-" + estab + "-" + ptoEmi + "-" + Secuencial_doc;
                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                            cedula_ruc_cliente_prov = comprobante.GetElementsByTagName("identificacionSujetoRetenido")[0].InnerText.Trim();
                                            RasonSocial_Comprador = comprobante.GetElementsByTagName("razonSocialSujetoRetenido")[0].InnerText.Trim();
                                            EsProveedor = true;
                                            break;
                                    }
                                    
                                    IdEstado_cbte = "VALI";
                                    IdEmisor = InfoEmpresa.IdEmpresa;

                                    #region Armando el info de comprobante con los datos del xml
                                    Comprobante_Info.IdEmpresa = IdEmisor;
                                    Comprobante_Info.IdComprobante = IdComprobante;
                                    Comprobante_Info.IdTipoDocumento = tipocomp;
                                    Comprobante_Info.IdEstado_cbte = IdEstado_cbte;
                                    Comprobante_Info.Cedula_Ruc = cedula_ruc_cliente_prov;
                                    Comprobante_Info.Numero_Autorizacion = null;
                                    Comprobante_Info.s_XML = Funciones.Formating_xml(comprobante.InnerXml);
                                    Comprobante_Info.Fecha_Emi_Fact = fechaEmision_Docu;
                                    Comprobante_Info.Fecha_transaccion = DateTime.Now;
                                    Comprobante_Info.FechaAutorizacion = null;
                                    Comprobante_Info.ClaveContingencia = null;
                                    Comprobante_Info.EstadoDoc = null;
                                    Comprobante_Info.Error = null;
                                    Comprobante_Info.IdEstadoProceso = "PEND";
                                    Comprobante_Info.IdError_Sri = null;
                                    Comprobante_Info.Nombre_file = item.Name;
                                    Comprobante_Info.RutaArchivo = "";// param.PathComprobantesValidos;
                                    Comprobante_Info.Ambiente = item.Ambiente;
                                    Comprobante_Info.Clave_Acceso = Clave_Acceso;
                                    Comprobante_Info.Total = total;
                                    #endregion

                                    if (factBus.GrabarDB(Comprobante_Info, ref mensajeError))
                                    {
                                        try
                                        {
                                         info_comprobante_x_valor = new tb_comprobante_x_valor_Info();
                                        info_comprobante_x_valor.IdEmpresa = Comprobante_Info.IdEmpresa;
                                        info_comprobante_x_valor.IdComprobante = Comprobante_Info.IdComprobante;
                                        info_comprobante_x_valor.Total = Comprobante_Info.Total;

                                        if (!bus_comprobante_valor.si_existe_comprobante(info_comprobante_x_valor))
                                        {
                                            bus_comprobante_valor.GrabarDB(info_comprobante_x_valor);
                                        }
                                        }
                                        catch (Exception)
                                        {
                                            
                                            
                                        }
                                        string PathFuente = param.RutaComprobantesRepositorio;
                                        string PathDestino = param.RutaComprobantesValidos;

                                        BusFx_Files.copiar_mover_eliminar_archivos_x_cbtes(PathFuente, PathDestino, item.Name,ref mensajeError);
                                        item.MensajeSubida = "Archivo Subido a Base EFIRM y copiado a Carpeta Valido";

                                        gridViewDirectorio.SetRowCellValue(Convert.ToInt32(item.NumRegistro - 1), colMensajeSubida, item.MensajeSubida);


                                        Observacion = "cbte origen:" + IdComprobante + " file:" + item.FullName;


                                        tb_Contribuyente_Bus BusContribuyente = new tb_Contribuyente_Bus();
                                        tb_Contribuyente_Info InfoContribuyente = new tb_Contribuyente_Info();

                                        InfoContribuyente.IdEmpresa = Comprobante_Info.IdEmpresa;
                                        InfoContribuyente.IdContribuyente = 0;
                                        InfoContribuyente.cedulaRuc_contri = cedula_ruc_cliente_prov;
                                        InfoContribuyente.Nom_Contribuyente = RasonSocial_Comprador;
                                        InfoContribuyente.Mail = sMail;
                                        InfoContribuyente.EsCliente = EsCliente;
                                        InfoContribuyente.EsProveedor = EsProveedor;
                                        InfoContribuyente.Password = "";
                                        InfoContribuyente.Estado = true;
                                        InfoContribuyente.Fecha_transaccion = DateTime.Now;
                                        InfoContribuyente.Observacion = Observacion;
                                        InfoContribuyente.Mail_secundario = sMail1;
                                        InfoContribuyente.Mail_secundario2 = sMail2;


                                        BusContribuyente.GuardarDB(InfoContribuyente, ref mensajeError);
                                        item.MensajeSubida = item.MensajeSubida + " se registro el contribuyente : " + cedula_ruc_cliente_prov;
                                    }
                                    else
                                    {
                                        item.mensaje_error_validacion = "ESTE COMPROBANTE YA EXISTE EN LA BASE O NO SE PUDO GUARDAR PARA MAS INFO REVISE LOG ERROR" + mensajeError;
                                        item.Estado_Valicion = "ERROR";
                                        item.MensajeSubida = "ESTE COMPROBANTE YA EXISTE EN LA BASE O NO SE PUDO GUARDAR PARA MAS INFO REVISE LOG ERROR";

                                        mover_file_desde_repositorio_x_errores(item, ref mensajeError);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                                mensajeError = ex.Message;
                                //BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.LOG, this.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
        }


        void mover_file_desde_repositorio_x_errores(Archivo_Info item,ref  string mensajeError)
        {
            try
            {
                string PathFuente = param.RutaComprobantesRepositorio;
                string PathDestino = param.RutaComprobantes_con_Errores;
                string sFecha_tras = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                string sNom_file = "";

                BusFx_Files.copiar_mover_eliminar_archivos_x_cbtes(PathFuente, PathDestino, item.Name, ref mensajeError);
                //creando file de log de errores

                sNom_file = item.Name.Substring(0, item.Name.Length - 4);
                sNom_file = sNom_file + "_LOG_ERRORES_" + sFecha_tras + ".txt";
                BusFx_Files.Crear_file(PathDestino, sNom_file, item.mensaje_error_validacion, ref mensajeError);

            }
            catch (Exception ex)
            {
                
            }
        }

        void otras_Validaciones_antes_subir_efirm(XmlDocument xmlcomprobante, Archivo_Info item)
        {
            try
            {
                string tipocomp = "";
                string mensajeError = "";
                DateTime fechaEmision_Docu = DateTime.Now;
                DateTime Hoy = DateTime.Now;

                string estab = "";
                string ptoEmi = "";
                string Secuencial_doc = "";
                string ruc_emisor = "";
                Boolean FileValido = true;
                string sEstadoXmlFile = "";
                
                //foreach (var item in listArchivos)
                //{

                    Application.DoEvents();

                    if (item.Checked == true)
                    {

                        

                            //cargando el xml 
                            try
                            {


                                XmlDocument comprobante = new XmlDocument();

                                comprobante.Load(item.FullName);

                                


                                ruc_emisor = comprobante.GetElementsByTagName("ruc")[0].InnerText.Trim();
                                tipocomp = comprobante.GetElementsByTagName("codDoc")[0].InnerText.Trim();
                                estab = comprobante.GetElementsByTagName("estab")[0].InnerText.Trim();
                                ptoEmi = comprobante.GetElementsByTagName("ptoEmi")[0].InnerText.Trim();
                                Secuencial_doc = comprobante.GetElementsByTagName("secuencial")[0].InnerText.Trim();

                                    switch (tipocomp)
                                    {
                                        case "01"://factura

                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));

                                            break;
                                        case "04"://nota cred

                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                            
                                            break;
                                        case "05"://nota dev

                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                            
                                            break;
                                        case "06"://guia


                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaIniTransporte")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                            break;
                                        case "07"://retencion

                                            fechaEmision_Docu = DateTime.Parse(comprobante.GetElementsByTagName("fechaEmision")[0].InnerText.Trim(), new CultureInfo("es-EC"));
                                            
                                            break;
                                    }


                                    // Difference in days, hours, and minutes.
                                    TimeSpan ts = Hoy - fechaEmision_Docu;
                                    // Difference in days.
                                    int diferencia_en_minutos = ts.Days;

                                    if (diferencia_en_minutos > 30)
                                    {
                                        item.Estado_Valicion = "ERROR";// (item.Estado_Valicion == "ERROR") ? "ERROR" : "VALIDO";
                                        FileValido = true;
                                        item.mensaje_error_validacion = item.mensaje_error_validacion + " La fecha de Emision esta fuera del Rango de Tolerancia [30] DIAS *** FECHA EMISION EXTEMPORANEA***";
                                    }
                                   if (diferencia_en_minutos < 0)
                                   {
                                       item.Estado_Valicion = "ERROR";// (item.Estado_Valicion == "ERROR") ? "ERROR" : "VALIDO";
                                       FileValido = true;
                                       item.mensaje_error_validacion = item.mensaje_error_validacion + "LA FECHA DE EMISION ES MAYOR A LA DEL SERVIDOR " + Hoy;
                                   }

                                    if (diferencia_en_minutos <- 30)
                                    {
                                        item.Estado_Valicion = "ERROR";// (item.Estado_Valicion == "ERROR") ? "ERROR" : "VALIDO";
                                        FileValido = true;
                                        item.mensaje_error_validacion = item.mensaje_error_validacion + " La fecha de Emision es mayor a la fecha actual del Servidor " + Hoy;
                                    }

                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                                mensajeError = ex.Message;
                                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.LOG, this.ToString());
                            }

                        
                    }


                //}




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }




        }


        void otras_Validaciones_Quitando_Tildes_y_Caracteres_Especiales( Archivo_Info InfoFileXML)
        {
            try
            {
                string strline;

                string File_Temporal = Path.GetTempPath() + "Temp.xml";
                string File_Origen = InfoFileXML.FullName;

                try
                {
                    System.IO.File.Copy(File_Origen, File_Temporal, true);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }

                StreamWriter StreamWriter_File_Origen = new StreamWriter(File_Origen);
                StreamWriter_File_Origen.AutoFlush = true;


                StreamReader_File_Temporal = new StreamReader(File_Temporal);
                strline = StreamReader_File_Temporal.ReadToEnd();

                
                //leer recurso de Reemplazo de Caracteres

                string sXML_Base = Efirm.Properties.Resources.XML_Caracteres_Especiales;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(sXML_Base);

                
                XmlNodeList personas = xmlDoc.GetElementsByTagName("Caracteres_Especiales");

                XmlNodeList lista = ((XmlElement)personas[0]).GetElementsByTagName("Caracter"); 

                foreach (XmlElement nodo in lista)
                {
                    int i=0;
                    string schar_Caracter_a_Buscar = "";
                    string schar_Caracter_de_reemplazo = "";

                    XmlNodeList sCaracter_a_Buscar = nodo.GetElementsByTagName("Caracter_a_Buscar");

                    XmlNodeList sCaracter_de_reemplazo = nodo.GetElementsByTagName("Caracter_de_reemplazo");

                    schar_Caracter_a_Buscar = sCaracter_a_Buscar[0].InnerText;
                    schar_Caracter_de_reemplazo = sCaracter_de_reemplazo[0].InnerText;

                    strline = strline.Replace(schar_Caracter_a_Buscar, schar_Caracter_de_reemplazo);
                }

                StreamWriter_File_Origen.WriteLine(strline);

                strline = StreamReader_File_Temporal.ReadToEnd();
                StreamWriter_File_Origen.WriteLine(strline);

                StreamReader_File_Temporal.Close();

                StreamWriter_File_Origen.Flush();
                StreamWriter_File_Origen.Close();
                StreamWriter_File_Origen = null;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());
            }




        }



             

        int contador_procesos = 0;


        private void timerOrquestadorFlujoProcesos_Tick(object sender, EventArgs e)
        {
            try
            {
                contador_procesos = contador_procesos + 1;

                switch (contador_procesos)
                { 
                    case 1:
                        timerSensor_archivos_nuevos.Enabled = true;
                        //cargar_file_desde_directorio(txt_ruta.Text);

                        break;
                    case 2:
                        timerContadorValidarArchivo.Enabled = true;
                        //validar_archivos();
                        break;
                    case 3:
                        timerContadorSubirEfirm.Enabled = true;
                        //Subir_archivos_a_efirm();
                        //cargar_file_desde_directorio(txt_ruta.Text);
                        contador_procesos = 0;
                        break;
                }

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
        }

        private void toolStrip1_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {

        }

        int countSegundosValidarArchivo = 0;

        private void timerContadorValidarArchivo_Tick(object sender, EventArgs e)
        {
            try
            {

                
                

                btn_validarArchivoXml.Text = "Validar Archivos Xml (" + countSegundosValidarArchivo + ")";

                if (countSegundosValidarArchivo <= 0)
                {
                    countSegundosValidarArchivo = TiempoEspera_Proceso2;
                    timerContadorValidarArchivo.Enabled = false;// apago este proceso
                    timerContadorSubirEfirm.Enabled = true;// prendo el sigueinte proceso 
                    validar();
                    gridControlDirectorio.RefreshDataSource();

                }
                countSegundosValidarArchivo = countSegundosValidarArchivo - 1;
            }
            catch (Exception ex)
            {
                //BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }

            
        }


        int countSegundosSubirEfirm = 0;


        private void timerContadorSubirEfirm_Tick(object sender, EventArgs e)
        {
            try
            {

                

            

                btn_subir_file_efirm.Text = "Subir a Efirm (" + countSegundosSubirEfirm + ")";


                if (countSegundosSubirEfirm <= 0)// 5 segundo
                {
                    countSegundosSubirEfirm = TiempoEspera_Proceso3;
                    // se detine este contador
                    timerContadorSubirEfirm.Enabled = false; // apago este proceso y finaliza el ciclo 
                    Subir_archivos_a_efirm();
                    gridControlDirectorio.RefreshDataSource();
                    
                }

                countSegundosSubirEfirm = countSegundosSubirEfirm - 1;

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
                
            }
            
        }

       


        private void fileSystemWatcherRepositorio_Changed(object sender, FileSystemEventArgs e)
        {

        }



        tb_Actividades_Horario_Bus BusActividad = new tb_Actividades_Horario_Bus();
        tb_Actividades_Horario_Info InfoHorariosYActividases = new tb_Actividades_Horario_Info();

        void cargar_horarios_y_actividades()
        {
            try
            {

               string msg="";
               InfoHorariosYActividases= BusActividad.consultar("CBTE_RECIBIDOS",ref msg);
            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                
            }
        
        }

        

        

        
        int TiempoEspera_Proceso1=0;
        int TiempoEspera_Proceso2=0;
        int TiempoEspera_Proceso3=0;
        

              
       
        private void uC_Horario_Actividades1_event_Disparador_horario(int _TiempoEspera_Proceso1
            , int _TiempoEspera_Proceso2, int _TiempoEspera_Proceso3, int _TiempoEspera_Proceso4
            , int _TiempoEspera_Proceso5, int _TiempoEspera_Proceso6
            , TimeSpan HoraDisparo, tb_Actividades_Horario_Info InfoActividad_en_proceso)
        {

            try
            {


                TiempoEspera_Proceso1 = _TiempoEspera_Proceso1;
                TiempoEspera_Proceso2 = _TiempoEspera_Proceso2;


                countSegundosSensor_archivo_nuevo = _TiempoEspera_Proceso1;
                countSegundosValidarArchivo = _TiempoEspera_Proceso2;
                countSegundosSubirEfirm =  _TiempoEspera_Proceso3;


                if (timerSensor_archivos_nuevos.Enabled == false && timerSensorHiloValidador.Enabled == false && timerContadorSubirEfirm.Enabled==false)
                {
                    timerSensor_archivos_nuevos.Enabled = true;
                    timerContadorValidarArchivo.Enabled = false;
                    timerContadorSubirEfirm.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                BusSisLog.Log_Error(ex.Message.ToString(), eTipoError.ERROR, this.ToString());                

            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                DateTime start = DateTime.Now;
                e.Result = "";

                for (int i = 0; i <= 200; i++)
                {

                    int percentage = i;

                    System.Threading.Thread.Sleep(1000); //simulamos trabajo

                    backgroundWorker.ReportProgress(percentage, DateTime.Now);

                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                TimeSpan duration = DateTime.Now - start;

                e.Result = "Duration: " + duration.TotalMilliseconds.ToString() + " ms.";
            

            }
            catch (Exception ex)
            {
                
            }

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {

                prb_barra_proceso.Value = e.ProgressPercentage; //actualizamos la barra de progreso
                DateTime time = Convert.ToDateTime(e.UserState); //obtenemos información adicional si procede
            }
            catch (Exception ex)
            {
               
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {

                }
                else if (e.Error != null)
                {
                    //MessageBox.Show("Detalle Error: " + (e.Error as Exception).ToString());
                }
                else
                {
                    //MessageBox.Show("Proceso completado satisfactoriamente: " + e.Result.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                prb_barra_proceso.Value = 100;
            }
            catch (Exception ex)
            { 
                
            
            }

            
        }

        int filesCount = 0;

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            gridControlDirectorio.RefreshDataSource();
        }

        private void timerSensorHiloValidador_Tick(object sender, EventArgs e)
        {
            try
            {
                if (HiloValidar.IsAlive == false) //esta ejecutandoce
                {
                    backgroundWorker.CancelAsync();
                    timerSensorHiloValidador.Enabled = false;
                    prb_barra_proceso.Value = 100;
                    gridControlDirectorio.RefreshDataSource();
                }
            }
            catch (Exception ex)
            { }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in listArchivos)
                {
                    item.Checked = chkTodos.Checked;
                }
                gridControlDirectorio.RefreshDataSource();

            }
            catch (Exception ex)
            {


            }
        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
           
        }

        private void gridControlDirectorio_Click_1(object sender, EventArgs e)
        {

        }

        
        void IDisposable.Dispose()
        {
          
        }

        ~ UC_Comprobante_En_Repositorio()
        {
            Dispose();
        }

        public void Dispose()
        {
            //aqui realizas las operaciones ante la destruccion del user control
        }



        public StreamReader strm_File_Temporal { get; set; }

        public StreamReader StreamReader_File_Temporal { get; set; }

        private void btn_imprimir__Click(object sender, EventArgs e)
        {
            try
            {
                gridViewDirectorio.ShowPrintPreview();

            }
            catch (Exception ex)
            {


            }
        }
    }
}
