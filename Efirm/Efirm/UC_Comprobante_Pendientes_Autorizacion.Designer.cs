namespace Efirm
{
    partial class UC_Comprobante_Pendientes_Autorizacion
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Comprobante_Pendientes_Autorizacion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOptenerAutoSri = new System.Windows.Forms.ToolStripButton();
            this.lblEstado = new System.Windows.Forms.ToolStripLabel();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.txt_focus = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlCbtes = new DevExpress.XtraGrid.GridControl();
            this.gridViewCbtes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNom_emisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado_cbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsecuencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cols_XML = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_file = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_estado_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRespuestaSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Emi_Fact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_imagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.colAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_col_eliminar = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.prb_barra_proceso = new System.Windows.Forms.ToolStripProgressBar();
            this.lblMensajeError = new System.Windows.Forms.ToolStripLabel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageCbtes = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageHorarioActividades = new DevExpress.XtraTab.XtraTabPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.uC_Horario_Actividades1 = new Efirm.UC_Horario_Actividades();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timerSensorHiloValidador = new System.Windows.Forms.Timer(this.components);
            this.timerRefrescar = new System.Windows.Forms.Timer(this.components);
            this.timerFirmarXML = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbtes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbtes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_col_eliminar)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageCbtes.SuspendLayout();
            this.xtraTabPageHorarioActividades.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOptenerAutoSri,
            this.lblEstado,
            this.btnRefrescar,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.btn_Imprimir,
            this.txt_focus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(873, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnOptenerAutoSri
            // 
            this.btnOptenerAutoSri.Image = ((System.Drawing.Image)(resources.GetObject("btnOptenerAutoSri.Image")));
            this.btnOptenerAutoSri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptenerAutoSri.Name = "btnOptenerAutoSri";
            this.btnOptenerAutoSri.Size = new System.Drawing.Size(140, 22);
            this.btnOptenerAutoSri.Text = "Obtener Autorizacion";
            this.btnOptenerAutoSri.Click += new System.EventHandler(this.btnOptenerAutoSri_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(124, 22);
            this.lblEstado.Text = "                                       ";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(66, 22);
            this.btnRefrescar.Text = "Refresh";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel2.Text = "                       ";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imprimir.Image")));
            this.btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(23, 22);
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // txt_focus
            // 
            this.txt_focus.Name = "txt_focus";
            this.txt_focus.Size = new System.Drawing.Size(0, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 315);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlCbtes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 237);
            this.panel1.TabIndex = 2;
            // 
            // gridControlCbtes
            // 
            this.gridControlCbtes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCbtes.Location = new System.Drawing.Point(0, 0);
            this.gridControlCbtes.MainView = this.gridViewCbtes;
            this.gridControlCbtes.Name = "gridControlCbtes";
            this.gridControlCbtes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_col_eliminar,
            this.cmb_imagen});
            this.gridControlCbtes.Size = new System.Drawing.Size(873, 237);
            this.gridControlCbtes.TabIndex = 2;
            this.gridControlCbtes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCbtes});
            this.gridControlCbtes.Click += new System.EventHandler(this.gridControlFiles_Click);
            // 
            // gridViewCbtes
            // 
            this.gridViewCbtes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNom_emisor,
            this.colIdComprobante,
            this.colNomTipoDocumento,
            this.colIdEstado_cbte,
            this.colsecuencial,
            this.cols_XML,
            this.colFecha_transaccion,
            this.colNombre_file,
            this.colnom_estado_doc,
            this.colChecked,
            this.colError,
            this.colRespuestaSRI,
            this.colEstadoDoc,
            this.colFecha_Emi_Fact,
            this.colEliminar,
            this.colAmbiente});
            this.gridViewCbtes.GridControl = this.gridControlCbtes;
            this.gridViewCbtes.Name = "gridViewCbtes";
            this.gridViewCbtes.OptionsView.ColumnAutoWidth = false;
            this.gridViewCbtes.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCbtes.OptionsView.ShowGroupPanel = false;
            this.gridViewCbtes.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewFiles_RowCellClick);
            // 
            // colNom_emisor
            // 
            this.colNom_emisor.Caption = "Emisor";
            this.colNom_emisor.FieldName = "Nom_emisor";
            this.colNom_emisor.Name = "colNom_emisor";
            this.colNom_emisor.OptionsColumn.AllowEdit = false;
            this.colNom_emisor.Visible = true;
            this.colNom_emisor.VisibleIndex = 1;
            this.colNom_emisor.Width = 87;
            // 
            // colIdComprobante
            // 
            this.colIdComprobante.Caption = "IdComprobante";
            this.colIdComprobante.FieldName = "IdComprobante";
            this.colIdComprobante.Name = "colIdComprobante";
            this.colIdComprobante.OptionsColumn.AllowEdit = false;
            this.colIdComprobante.Visible = true;
            this.colIdComprobante.VisibleIndex = 3;
            this.colIdComprobante.Width = 230;
            // 
            // colNomTipoDocumento
            // 
            this.colNomTipoDocumento.Caption = "Tipo de Documento";
            this.colNomTipoDocumento.FieldName = "Nom_TipoDocumento";
            this.colNomTipoDocumento.Name = "colNomTipoDocumento";
            this.colNomTipoDocumento.OptionsColumn.AllowEdit = false;
            this.colNomTipoDocumento.Width = 192;
            // 
            // colIdEstado_cbte
            // 
            this.colIdEstado_cbte.Caption = "Estado";
            this.colIdEstado_cbte.FieldName = "IdEstado_cbte";
            this.colIdEstado_cbte.Name = "colIdEstado_cbte";
            this.colIdEstado_cbte.OptionsColumn.AllowEdit = false;
            this.colIdEstado_cbte.Width = 104;
            // 
            // colsecuencial
            // 
            this.colsecuencial.Caption = "secuencial";
            this.colsecuencial.FieldName = "secuencial";
            this.colsecuencial.Name = "colsecuencial";
            this.colsecuencial.OptionsColumn.AllowEdit = false;
            this.colsecuencial.Width = 95;
            // 
            // cols_XML
            // 
            this.cols_XML.Caption = "s_XML";
            this.cols_XML.FieldName = "s_XML";
            this.cols_XML.Name = "cols_XML";
            this.cols_XML.OptionsColumn.AllowEdit = false;
            this.cols_XML.Visible = true;
            this.cols_XML.VisibleIndex = 7;
            this.cols_XML.Width = 183;
            // 
            // colFecha_transaccion
            // 
            this.colFecha_transaccion.Caption = "Fecha_transaccion";
            this.colFecha_transaccion.FieldName = "sFecha_transaccion";
            this.colFecha_transaccion.Name = "colFecha_transaccion";
            this.colFecha_transaccion.OptionsColumn.AllowEdit = false;
            this.colFecha_transaccion.Visible = true;
            this.colFecha_transaccion.VisibleIndex = 8;
            this.colFecha_transaccion.Width = 183;
            // 
            // colNombre_file
            // 
            this.colNombre_file.Caption = "Archivo";
            this.colNombre_file.FieldName = "Nombre_file";
            this.colNombre_file.Name = "colNombre_file";
            this.colNombre_file.OptionsColumn.AllowEdit = false;
            this.colNombre_file.Width = 98;
            // 
            // colnom_estado_doc
            // 
            this.colnom_estado_doc.Caption = "Estado Doc.";
            this.colnom_estado_doc.FieldName = "Nom_estado_doc";
            this.colnom_estado_doc.Name = "colnom_estado_doc";
            this.colnom_estado_doc.OptionsColumn.AllowEdit = false;
            this.colnom_estado_doc.Visible = true;
            this.colnom_estado_doc.VisibleIndex = 6;
            this.colnom_estado_doc.Width = 118;
            // 
            // colChecked
            // 
            this.colChecked.Caption = "*";
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            this.colChecked.Width = 25;
            // 
            // colError
            // 
            this.colError.Caption = "Error/Envio";
            this.colError.FieldName = "Error";
            this.colError.Name = "colError";
            this.colError.OptionsColumn.AllowEdit = false;
            this.colError.Width = 90;
            // 
            // colRespuestaSRI
            // 
            this.colRespuestaSRI.Caption = "RespuestaSRI";
            this.colRespuestaSRI.FieldName = "RespuestaSRI";
            this.colRespuestaSRI.Name = "colRespuestaSRI";
            this.colRespuestaSRI.OptionsColumn.AllowEdit = false;
            this.colRespuestaSRI.Visible = true;
            this.colRespuestaSRI.VisibleIndex = 9;
            this.colRespuestaSRI.Width = 151;
            // 
            // colEstadoDoc
            // 
            this.colEstadoDoc.Caption = "EstadoDoc";
            this.colEstadoDoc.FieldName = "EstadoDoc";
            this.colEstadoDoc.Name = "colEstadoDoc";
            // 
            // colFecha_Emi_Fact
            // 
            this.colFecha_Emi_Fact.Caption = "Fecha Emision";
            this.colFecha_Emi_Fact.FieldName = "Fecha_Emi_Fact";
            this.colFecha_Emi_Fact.Name = "colFecha_Emi_Fact";
            this.colFecha_Emi_Fact.Visible = true;
            this.colFecha_Emi_Fact.VisibleIndex = 5;
            this.colFecha_Emi_Fact.Width = 171;
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "x";
            this.colEliminar.ColumnEdit = this.cmb_imagen;
            this.colEliminar.FieldName = "Mostrar_Icon_Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.OptionsColumn.AllowEdit = false;
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 4;
            this.colEliminar.Width = 32;
            // 
            // cmb_imagen
            // 
            this.cmb_imagen.AutoHeight = false;
            this.cmb_imagen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_imagen.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmb_imagen.LargeImages = this.imageCollection;
            this.cmb_imagen.Name = "cmb_imagen";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "anular2_32.x32png.png");
            // 
            // colAmbiente
            // 
            this.colAmbiente.Caption = "Ambiente";
            this.colAmbiente.FieldName = "Ambiente";
            this.colAmbiente.Name = "colAmbiente";
            this.colAmbiente.Visible = true;
            this.colAmbiente.VisibleIndex = 2;
            // 
            // cmb_col_eliminar
            // 
            this.cmb_col_eliminar.AutoHeight = false;
            this.cmb_col_eliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_col_eliminar.HtmlImages = this.imageCollection;
            this.cmb_col_eliminar.Name = "cmb_col_eliminar";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.prb_barra_proceso,
            this.lblMensajeError});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(873, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel3.Text = "Estado";
            // 
            // prb_barra_proceso
            // 
            this.prb_barra_proceso.Name = "prb_barra_proceso";
            this.prb_barra_proceso.Size = new System.Drawing.Size(500, 22);
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(42, 22);
            this.lblMensajeError.Text = "estado";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageCbtes;
            this.xtraTabControl1.Size = new System.Drawing.Size(879, 315);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageCbtes,
            this.xtraTabPageHorarioActividades});
            // 
            // xtraTabPageCbtes
            // 
            this.xtraTabPageCbtes.Controls.Add(this.panel1);
            this.xtraTabPageCbtes.Controls.Add(this.toolStrip2);
            this.xtraTabPageCbtes.Controls.Add(this.toolStrip1);
            this.xtraTabPageCbtes.Name = "xtraTabPageCbtes";
            this.xtraTabPageCbtes.Size = new System.Drawing.Size(873, 287);
            this.xtraTabPageCbtes.Text = "Cbtes Pendientes de Autorizar";
            // 
            // xtraTabPageHorarioActividades
            // 
            this.xtraTabPageHorarioActividades.Controls.Add(this.xtraScrollableControl1);
            this.xtraTabPageHorarioActividades.Name = "xtraTabPageHorarioActividades";
            this.xtraTabPageHorarioActividades.Size = new System.Drawing.Size(873, 287);
            this.xtraTabPageHorarioActividades.Text = "Horario de Actividades";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.uC_Horario_Actividades1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(873, 287);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // uC_Horario_Actividades1
            // 
            this.uC_Horario_Actividades1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Horario_Actividades1.IdTransaccion = "CBTE_PEN_AUTO";
            this.uC_Horario_Actividades1.Location = new System.Drawing.Point(0, 0);
            this.uC_Horario_Actividades1.Name = "uC_Horario_Actividades1";
            this.uC_Horario_Actividades1.Size = new System.Drawing.Size(873, 287);
            this.uC_Horario_Actividades1.TabIndex = 0;
            this.uC_Horario_Actividades1.event_Disparador_horario += new Efirm.UC_Horario_Actividades.delegate_Disparador_horario(this.uC_Horario_Actividades1_event_Disparador_horario);
            this.uC_Horario_Actividades1.event_btn_guardar_Click += new Efirm.UC_Horario_Actividades.delegate_btn_guardar_Click(this.uC_Horario_Actividades1_event_btn_guardar_Click);
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
            // timerRefrescar
            // 
            this.timerRefrescar.Interval = 1000;
            this.timerRefrescar.Tick += new System.EventHandler(this.timerRefrescar_Tick);
            // 
            // timerFirmarXML
            // 
            this.timerFirmarXML.Interval = 1000;
            this.timerFirmarXML.Tick += new System.EventHandler(this.timerFirmarXML_Tick);
            // 
            // UC_Comprobante_Pendientes_Autorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "UC_Comprobante_Pendientes_Autorizacion";
            this.Size = new System.Drawing.Size(879, 337);
            this.Load += new System.EventHandler(this.UC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbtes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbtes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_col_eliminar)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageCbtes.ResumeLayout(false);
            this.xtraTabPageCbtes.PerformLayout();
            this.xtraTabPageHorarioActividades.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlCbtes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCbtes;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_emisor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colNomTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado_cbte;
        private DevExpress.XtraGrid.Columns.GridColumn colsecuencial;
        private DevExpress.XtraGrid.Columns.GridColumn cols_XML;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_file;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_estado_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
        private DevExpress.XtraGrid.Columns.GridColumn colError;
        private DevExpress.XtraGrid.Columns.GridColumn colRespuestaSRI;
        private System.Windows.Forms.ToolStripLabel lblEstado;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripProgressBar prb_barra_proceso;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCbtes;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHorarioActividades;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private UC_Horario_Actividades uC_Horario_Actividades1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Timer timerSensorHiloValidador;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Emi_Fact;
        private System.Windows.Forms.Timer timerRefrescar;
        private System.Windows.Forms.Timer timerFirmarXML;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmb_col_eliminar;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imagen;
        private DevExpress.XtraGrid.Columns.GridColumn colAmbiente;
        private System.Windows.Forms.ToolStripButton btn_Imprimir;
        private System.Windows.Forms.ToolStripLabel lblMensajeError;
        private System.Windows.Forms.ToolStripTextBox txt_focus;
        private System.Windows.Forms.ToolStripButton btnOptenerAutoSri;
    }
}
