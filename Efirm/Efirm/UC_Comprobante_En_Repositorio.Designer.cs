namespace Efirm
{
    partial class UC_Comprobante_En_Repositorio
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Comprobante_En_Repositorio));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_refrescar_direc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_validarArchivoXml = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_subir_file_efirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblmsg_proceso = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_imprimir_ = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerSensor_archivos_nuevos = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_ruta = new System.Windows.Forms.ToolStripTextBox();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.timerContadorValidarArchivo = new System.Windows.Forms.Timer(this.components);
            this.timerContadorSubirEfirm = new System.Windows.Forms.Timer(this.components);
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.lbl_estado_proceso = new System.Windows.Forms.ToolStripLabel();
            this.prb_barra_proceso = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xtraTabControlXMLRecibidos = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageXml = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlDirectorio = new DevExpress.XtraGrid.GridControl();
            this.gridViewDirectorio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastAccessTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_Valicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmensaje_error_validacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMensajeSubida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMainTop = new System.Windows.Forms.Panel();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.xtraTabPageHorariosActividades = new DevExpress.XtraTab.XtraTabPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.uC_Horario_Actividades1 = new Efirm.UC_Horario_Actividades();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timerSensorHiloValidador = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlXMLRecibidos)).BeginInit();
            this.xtraTabControlXMLRecibidos.SuspendLayout();
            this.xtraTabPageXml.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDirectorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDirectorio)).BeginInit();
            this.panelMainTop.SuspendLayout();
            this.xtraTabPageHorariosActividades.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_refrescar_direc,
            this.toolStripSeparator3,
            this.btn_validarArchivoXml,
            this.toolStripSeparator1,
            this.btn_subir_file_efirm,
            this.toolStripSeparator2,
            this.lblmsg_proceso,
            this.toolStripSeparator4,
            this.btn_imprimir_,
            this.toolStripSeparator5,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1006, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_refrescar_direc
            // 
            this.btn_refrescar_direc.Image = ((System.Drawing.Image)(resources.GetObject("btn_refrescar_direc.Image")));
            this.btn_refrescar_direc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refrescar_direc.Name = "btn_refrescar_direc";
            this.btn_refrescar_direc.Size = new System.Drawing.Size(75, 22);
            this.btn_refrescar_direc.Text = "Refrescar";
            this.btn_refrescar_direc.Click += new System.EventHandler(this.btn_refrescar_direc_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_validarArchivoXml
            // 
            this.btn_validarArchivoXml.Image = ((System.Drawing.Image)(resources.GetObject("btn_validarArchivoXml.Image")));
            this.btn_validarArchivoXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_validarArchivoXml.Name = "btn_validarArchivoXml";
            this.btn_validarArchivoXml.Size = new System.Drawing.Size(109, 22);
            this.btn_validarArchivoXml.Text = "Validar archivos";
            this.btn_validarArchivoXml.Click += new System.EventHandler(this.btn_validar_xml_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_subir_file_efirm
            // 
            this.btn_subir_file_efirm.Image = ((System.Drawing.Image)(resources.GetObject("btn_subir_file_efirm.Image")));
            this.btn_subir_file_efirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_subir_file_efirm.Name = "btn_subir_file_efirm";
            this.btn_subir_file_efirm.Size = new System.Drawing.Size(80, 22);
            this.btn_subir_file_efirm.Text = "Grabar DB";
            this.btn_subir_file_efirm.Click += new System.EventHandler(this.btn_subir_file_efirm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblmsg_proceso
            // 
            this.lblmsg_proceso.Name = "lblmsg_proceso";
            this.lblmsg_proceso.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_imprimir_
            // 
            this.btn_imprimir_.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir_.Image")));
            this.btn_imprimir_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir_.Name = "btn_imprimir_";
            this.btn_imprimir_.Size = new System.Drawing.Size(73, 22);
            this.btn_imprimir_.Text = "Imprimir";
            this.btn_imprimir_.Click += new System.EventHandler(this.btn_imprimir__Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerSensor_archivos_nuevos
            // 
            this.timerSensor_archivos_nuevos.Interval = 1000;
            this.timerSensor_archivos_nuevos.Tick += new System.EventHandler(this.timerSensor_archivos_nuevos_Tick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txt_ruta,
            this.btn_buscar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1006, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(207, 22);
            this.toolStripLabel1.Text = "Directorio Repositorio Comprobantes:";
            // 
            // txt_ruta
            // 
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(350, 25);
            this.txt_ruta.Text = "C:\\Comprobantes electronicos\\Documentos Electronicos Generados\\";
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(23, 22);
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_directorio_Click);
            // 
            // timerContadorValidarArchivo
            // 
            this.timerContadorValidarArchivo.Interval = 1000;
            this.timerContadorValidarArchivo.Tick += new System.EventHandler(this.timerContadorValidarArchivo_Tick);
            // 
            // timerContadorSubirEfirm
            // 
            this.timerContadorSubirEfirm.Interval = 1000;
            this.timerContadorSubirEfirm.Tick += new System.EventHandler(this.timerContadorSubirEfirm_Tick);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_estado_proceso,
            this.prb_barra_proceso});
            this.toolStrip3.Location = new System.Drawing.Point(0, 50);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1006, 25);
            this.toolStrip3.TabIndex = 5;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip3_ItemClicked);
            // 
            // lbl_estado_proceso
            // 
            this.lbl_estado_proceso.Name = "lbl_estado_proceso";
            this.lbl_estado_proceso.Size = new System.Drawing.Size(58, 22);
            this.lbl_estado_proceso.Text = "Proceso...";
            // 
            // prb_barra_proceso
            // 
            this.prb_barra_proceso.Maximum = 200;
            this.prb_barra_proceso.Name = "prb_barra_proceso";
            this.prb_barra_proceso.Size = new System.Drawing.Size(600, 22);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xtraTabControlXMLRecibidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 351);
            this.panel1.TabIndex = 6;
            // 
            // xtraTabControlXMLRecibidos
            // 
            this.xtraTabControlXMLRecibidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlXMLRecibidos.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlXMLRecibidos.Name = "xtraTabControlXMLRecibidos";
            this.xtraTabControlXMLRecibidos.SelectedTabPage = this.xtraTabPageXml;
            this.xtraTabControlXMLRecibidos.Size = new System.Drawing.Size(1006, 351);
            this.xtraTabControlXMLRecibidos.TabIndex = 1;
            this.xtraTabControlXMLRecibidos.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageXml,
            this.xtraTabPageHorariosActividades});
            // 
            // xtraTabPageXml
            // 
            this.xtraTabPageXml.Controls.Add(this.panel2);
            this.xtraTabPageXml.Controls.Add(this.panelMainTop);
            this.xtraTabPageXml.Name = "xtraTabPageXml";
            this.xtraTabPageXml.Size = new System.Drawing.Size(1000, 323);
            this.xtraTabPageXml.Text = "Archivos XML a Validar y subir";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlDirectorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 302);
            this.panel2.TabIndex = 3;
            // 
            // gridControlDirectorio
            // 
            this.gridControlDirectorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDirectorio.Location = new System.Drawing.Point(0, 0);
            this.gridControlDirectorio.MainView = this.gridViewDirectorio;
            this.gridControlDirectorio.Name = "gridControlDirectorio";
            this.gridControlDirectorio.Size = new System.Drawing.Size(1000, 302);
            this.gridControlDirectorio.TabIndex = 1;
            this.gridControlDirectorio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDirectorio});
            this.gridControlDirectorio.Click += new System.EventHandler(this.gridControlDirectorio_Click_1);
            // 
            // gridViewDirectorio
            // 
            this.gridViewDirectorio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colName,
            this.colLastAccessTime,
            this.colLength,
            this.colCreationTime,
            this.colExtension,
            this.colEstado_Valicion,
            this.colmensaje_error_validacion,
            this.colFullName,
            this.colNumRegistro,
            this.colMensajeSubida,
            this.colTipoCbte,
            this.colAmbiente});
            this.gridViewDirectorio.GridControl = this.gridControlDirectorio;
            this.gridViewDirectorio.Name = "gridViewDirectorio";
            this.gridViewDirectorio.OptionsView.ColumnAutoWidth = false;
            this.gridViewDirectorio.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDirectorio.OptionsView.ShowFooter = true;
            this.gridViewDirectorio.OptionsView.ShowGroupPanel = false;
            this.gridViewDirectorio.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewDirectorio_RowCellClick);
            this.gridViewDirectorio.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewDirectorio_RowCellStyle);
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "Checked";
            this.colCheck.Name = "colCheck";
            this.colCheck.OptionsColumn.AllowSize = false;
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 1;
            this.colCheck.Width = 20;
            // 
            // colName
            // 
            this.colName.Caption = "Nombre";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 4;
            this.colName.Width = 201;
            // 
            // colLastAccessTime
            // 
            this.colLastAccessTime.Caption = "Ultima Modificion";
            this.colLastAccessTime.FieldName = "LastAccessTime";
            this.colLastAccessTime.Name = "colLastAccessTime";
            this.colLastAccessTime.OptionsColumn.AllowEdit = false;
            this.colLastAccessTime.Visible = true;
            this.colLastAccessTime.VisibleIndex = 6;
            this.colLastAccessTime.Width = 50;
            // 
            // colLength
            // 
            this.colLength.Caption = "Tamaño";
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            this.colLength.OptionsColumn.AllowEdit = false;
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 7;
            this.colLength.Width = 54;
            // 
            // colCreationTime
            // 
            this.colCreationTime.Caption = "CreationTime";
            this.colCreationTime.FieldName = "CreationTime";
            this.colCreationTime.Name = "colCreationTime";
            this.colCreationTime.OptionsColumn.AllowEdit = false;
            this.colCreationTime.Visible = true;
            this.colCreationTime.VisibleIndex = 5;
            this.colCreationTime.Width = 58;
            // 
            // colExtension
            // 
            this.colExtension.Caption = "Extension";
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            this.colExtension.OptionsColumn.AllowEdit = false;
            this.colExtension.Visible = true;
            this.colExtension.VisibleIndex = 8;
            this.colExtension.Width = 23;
            // 
            // colEstado_Valicion
            // 
            this.colEstado_Valicion.Caption = "Estado_Valicion";
            this.colEstado_Valicion.FieldName = "Estado_Valicion";
            this.colEstado_Valicion.Name = "colEstado_Valicion";
            this.colEstado_Valicion.OptionsColumn.AllowEdit = false;
            this.colEstado_Valicion.Visible = true;
            this.colEstado_Valicion.VisibleIndex = 9;
            this.colEstado_Valicion.Width = 63;
            // 
            // colmensaje_error_validacion
            // 
            this.colmensaje_error_validacion.Caption = "Mensaje Error";
            this.colmensaje_error_validacion.FieldName = "mensaje_error_validacion";
            this.colmensaje_error_validacion.Name = "colmensaje_error_validacion";
            this.colmensaje_error_validacion.OptionsColumn.AllowEdit = false;
            this.colmensaje_error_validacion.Visible = true;
            this.colmensaje_error_validacion.VisibleIndex = 10;
            this.colmensaje_error_validacion.Width = 94;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "FullName";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 11;
            this.colFullName.Width = 50;
            // 
            // colNumRegistro
            // 
            this.colNumRegistro.Caption = "#";
            this.colNumRegistro.FieldName = "NumRegistro";
            this.colNumRegistro.Name = "colNumRegistro";
            this.colNumRegistro.OptionsColumn.AllowEdit = false;
            this.colNumRegistro.Visible = true;
            this.colNumRegistro.VisibleIndex = 0;
            this.colNumRegistro.Width = 22;
            // 
            // colMensajeSubida
            // 
            this.colMensajeSubida.Caption = "Subida/Copia Validacion";
            this.colMensajeSubida.FieldName = "MensajeSubida";
            this.colMensajeSubida.Name = "colMensajeSubida";
            this.colMensajeSubida.OptionsColumn.AllowEdit = false;
            this.colMensajeSubida.Visible = true;
            this.colMensajeSubida.VisibleIndex = 12;
            this.colMensajeSubida.Width = 195;
            // 
            // colTipoCbte
            // 
            this.colTipoCbte.Caption = "IdComprobante";
            this.colTipoCbte.FieldName = "TipoCbte";
            this.colTipoCbte.Name = "colTipoCbte";
            this.colTipoCbte.OptionsColumn.AllowEdit = false;
            this.colTipoCbte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colTipoCbte.Visible = true;
            this.colTipoCbte.VisibleIndex = 3;
            this.colTipoCbte.Width = 52;
            // 
            // colAmbiente
            // 
            this.colAmbiente.Caption = "Ambiente";
            this.colAmbiente.FieldName = "Ambiente";
            this.colAmbiente.Name = "colAmbiente";
            this.colAmbiente.Visible = true;
            this.colAmbiente.VisibleIndex = 2;
            this.colAmbiente.Width = 100;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.chkTodos);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Size = new System.Drawing.Size(1000, 21);
            this.panelMainTop.TabIndex = 2;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Checked = true;
            this.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTodos.Location = new System.Drawing.Point(14, 3);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(55, 17);
            this.chkTodos.TabIndex = 0;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // xtraTabPageHorariosActividades
            // 
            this.xtraTabPageHorariosActividades.Controls.Add(this.xtraScrollableControl1);
            this.xtraTabPageHorariosActividades.Name = "xtraTabPageHorariosActividades";
            this.xtraTabPageHorariosActividades.Size = new System.Drawing.Size(1000, 323);
            this.xtraTabPageHorariosActividades.Text = "Horario de Actividad";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.uC_Horario_Actividades1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1000, 323);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // uC_Horario_Actividades1
            // 
            this.uC_Horario_Actividades1.AutoScroll = true;
            this.uC_Horario_Actividades1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_Horario_Actividades1.IdTransaccion = "CBTE_RECIBIDOS";
            this.uC_Horario_Actividades1.Location = new System.Drawing.Point(0, 0);
            this.uC_Horario_Actividades1.Name = "uC_Horario_Actividades1";
            this.uC_Horario_Actividades1.Size = new System.Drawing.Size(983, 441);
            this.uC_Horario_Actividades1.TabIndex = 0;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // timerSensorHiloValidador
            // 
            this.timerSensorHiloValidador.Tick += new System.EventHandler(this.timerSensorHiloValidador_Tick);
            // 
            // UC_Comprobante_En_Repositorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_Comprobante_En_Repositorio";
            this.Size = new System.Drawing.Size(1006, 448);
            this.Load += new System.EventHandler(this.UC_Comprobante_recibido_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlXMLRecibidos)).EndInit();
            this.xtraTabControlXMLRecibidos.ResumeLayout(false);
            this.xtraTabPageXml.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDirectorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDirectorio)).EndInit();
            this.panelMainTop.ResumeLayout(false);
            this.panelMainTop.PerformLayout();
            this.xtraTabPageHorariosActividades.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_refrescar_direc;
        private System.Windows.Forms.ToolStripButton btn_validarArchivoXml;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerSensor_archivos_nuevos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_ruta;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripButton btn_subir_file_efirm;
        private System.Windows.Forms.Timer timerContadorValidarArchivo;
        private System.Windows.Forms.Timer timerContadorSubirEfirm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlXMLRecibidos;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageXml;
        private DevExpress.XtraGrid.GridControl gridControlDirectorio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDirectorio;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastAccessTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationTime;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_Valicion;
        private DevExpress.XtraGrid.Columns.GridColumn colmensaje_error_validacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colNumRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colMensajeSubida;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCbte;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHorariosActividades;
        private UC_Horario_Actividades uC_Horario_Actividades1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel lbl_estado_proceso;
        private System.Windows.Forms.ToolStripProgressBar prb_barra_proceso;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Timer timerSensorHiloValidador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMainTop;
        private System.Windows.Forms.CheckBox chkTodos;
        private DevExpress.XtraGrid.Columns.GridColumn colAmbiente;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblmsg_proceso;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_imprimir_;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton btn_salir;
        

    }
}
