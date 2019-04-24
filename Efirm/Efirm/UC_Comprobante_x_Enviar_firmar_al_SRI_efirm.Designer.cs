namespace Efirm
{
    partial class UC_Comprobante_x_Enviar_firmar_al_SRI_efirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Comprobante_x_Enviar_firmar_al_SRI_efirm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageFileValidos = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.chkTodos = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlFiles = new DevExpress.XtraGrid.GridControl();
            this.gridViewFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNom_emisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado_cbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsecuencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cols_XML = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_file = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_estado_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRespuestaSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Emi_Fact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_eliminar = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollectionCbtesFirma = new DevExpress.Utils.ImageCollection(this.components);
            this.colAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uC_ContenedorHilos = new Efirm.UC_ContenedorHilos();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_firmar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_refresh_listado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_test_ws_sri = new System.Windows.Forms.ToolStripButton();
            this.xtraTabPageHorario = new DevExpress.XtraTab.XtraTabPage();
            this.uC_Horario_Actividades = new Efirm.UC_Horario_Actividades();
            this.timerFirmarXML = new System.Windows.Forms.Timer(this.components);
            this.timerRefrescar = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageFileValidos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.xtraTabPageHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.xtraTabControlMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1024, 505);
            this.panelMain.TabIndex = 3;
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageFileValidos;
            this.xtraTabControlMain.Size = new System.Drawing.Size(1024, 505);
            this.xtraTabControlMain.TabIndex = 4;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageFileValidos,
            this.xtraTabPageHorario});
            this.xtraTabControlMain.Click += new System.EventHandler(this.xtraTabControlMain_Click);
            // 
            // xtraTabPageFileValidos
            // 
            this.xtraTabPageFileValidos.Controls.Add(this.groupBox1);
            this.xtraTabPageFileValidos.Name = "xtraTabPageFileValidos";
            this.xtraTabPageFileValidos.Size = new System.Drawing.Size(1018, 477);
            this.xtraTabPageFileValidos.Text = "Archivos xmls Validos Pendientes de Firmar y Autorizar por SRI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 477);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 433);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainerControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 433);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.chkTodos);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlFiles);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1012, 216);
            this.splitContainerControl1.SplitterPosition = 25;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // chkTodos
            // 
            this.chkTodos.Location = new System.Drawing.Point(1, 4);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Properties.Caption = "Todos";
            this.chkTodos.Size = new System.Drawing.Size(75, 19);
            this.chkTodos.TabIndex = 0;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // gridControlFiles
            // 
            this.gridControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFiles.Location = new System.Drawing.Point(0, 0);
            this.gridControlFiles.MainView = this.gridViewFiles;
            this.gridControlFiles.Name = "gridControlFiles";
            this.gridControlFiles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_eliminar,
            this.repositoryItemImageComboBox1});
            this.gridControlFiles.Size = new System.Drawing.Size(1012, 186);
            this.gridControlFiles.TabIndex = 1;
            this.gridControlFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFiles});
            // 
            // gridViewFiles
            // 
            this.gridViewFiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNom_emisor,
            this.colIdComprobante,
            this.colNomTipoDocumento,
            this.colIdEstado_cbte,
            this.colsecuencial,
            this.cols_XML,
            this.col_Total,
            this.colFecha_transaccion,
            this.colNombre_file,
            this.colnom_estado_doc,
            this.colChecked,
            this.colError,
            this.colRespuestaSRI,
            this.colFecha_Emi_Fact,
            this.colEliminar,
            this.colAmbiente,
            this.ColRide});
            this.gridViewFiles.GridControl = this.gridControlFiles;
            this.gridViewFiles.Name = "gridViewFiles";
            this.gridViewFiles.OptionsView.ColumnAutoWidth = false;
            this.gridViewFiles.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFiles.OptionsView.ShowFooter = true;
            this.gridViewFiles.OptionsView.ShowGroupPanel = false;
            this.gridViewFiles.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewFiles_RowCellClick);
            this.gridViewFiles.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewFiles_RowCellStyle);
            // 
            // colNom_emisor
            // 
            this.colNom_emisor.Caption = "Emisor";
            this.colNom_emisor.FieldName = "Nom_emisor";
            this.colNom_emisor.Name = "colNom_emisor";
            this.colNom_emisor.OptionsColumn.AllowEdit = false;
            this.colNom_emisor.Visible = true;
            this.colNom_emisor.VisibleIndex = 1;
            this.colNom_emisor.Width = 58;
            // 
            // colIdComprobante
            // 
            this.colIdComprobante.Caption = "IdComprobante";
            this.colIdComprobante.FieldName = "IdComprobante";
            this.colIdComprobante.Name = "colIdComprobante";
            this.colIdComprobante.OptionsColumn.AllowEdit = false;
            this.colIdComprobante.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colIdComprobante.Visible = true;
            this.colIdComprobante.VisibleIndex = 4;
            this.colIdComprobante.Width = 136;
            // 
            // colNomTipoDocumento
            // 
            this.colNomTipoDocumento.Caption = "Tipo de Documento";
            this.colNomTipoDocumento.FieldName = "Nom_TipoDocumento";
            this.colNomTipoDocumento.Name = "colNomTipoDocumento";
            this.colNomTipoDocumento.OptionsColumn.AllowEdit = false;
            this.colNomTipoDocumento.Width = 60;
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
            this.cols_XML.VisibleIndex = 8;
            this.cols_XML.Width = 118;
            // 
            // col_Total
            // 
            this.col_Total.Caption = "Total";
            this.col_Total.FieldName = "Total";
            this.col_Total.Name = "col_Total";
            this.col_Total.OptionsColumn.AllowEdit = false;
            this.col_Total.Visible = true;
            this.col_Total.VisibleIndex = 6;
            // 
            // colFecha_transaccion
            // 
            this.colFecha_transaccion.Caption = "Fecha_transaccion";
            this.colFecha_transaccion.FieldName = "sFecha_transaccion";
            this.colFecha_transaccion.Name = "colFecha_transaccion";
            this.colFecha_transaccion.OptionsColumn.AllowEdit = false;
            this.colFecha_transaccion.Visible = true;
            this.colFecha_transaccion.VisibleIndex = 9;
            this.colFecha_transaccion.Width = 118;
            // 
            // colNombre_file
            // 
            this.colNombre_file.Caption = "Archivo";
            this.colNombre_file.FieldName = "Nombre_file";
            this.colNombre_file.Name = "colNombre_file";
            this.colNombre_file.OptionsColumn.AllowEdit = false;
            this.colNombre_file.Visible = true;
            this.colNombre_file.VisibleIndex = 11;
            this.colNombre_file.Width = 79;
            // 
            // colnom_estado_doc
            // 
            this.colnom_estado_doc.Caption = "Estado Doc.";
            this.colnom_estado_doc.FieldName = "Nom_estado_doc";
            this.colnom_estado_doc.Name = "colnom_estado_doc";
            this.colnom_estado_doc.OptionsColumn.AllowEdit = false;
            this.colnom_estado_doc.Visible = true;
            this.colnom_estado_doc.VisibleIndex = 7;
            this.colnom_estado_doc.Width = 80;
            // 
            // colChecked
            // 
            this.colChecked.Caption = "*";
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            this.colChecked.Width = 20;
            // 
            // colError
            // 
            this.colError.Caption = "Error/Envio";
            this.colError.FieldName = "Error";
            this.colError.Name = "colError";
            this.colError.OptionsColumn.AllowEdit = false;
            this.colError.Visible = true;
            this.colError.VisibleIndex = 12;
            this.colError.Width = 72;
            // 
            // colRespuestaSRI
            // 
            this.colRespuestaSRI.Caption = "RespuestaSRI";
            this.colRespuestaSRI.FieldName = "RespuestaSRI";
            this.colRespuestaSRI.Name = "colRespuestaSRI";
            this.colRespuestaSRI.OptionsColumn.AllowEdit = false;
            this.colRespuestaSRI.Visible = true;
            this.colRespuestaSRI.VisibleIndex = 13;
            this.colRespuestaSRI.Width = 93;
            // 
            // colFecha_Emi_Fact
            // 
            this.colFecha_Emi_Fact.Caption = "Fecha Emision";
            this.colFecha_Emi_Fact.FieldName = "sFecha_Emi_Fact";
            this.colFecha_Emi_Fact.Name = "colFecha_Emi_Fact";
            this.colFecha_Emi_Fact.Visible = true;
            this.colFecha_Emi_Fact.VisibleIndex = 5;
            this.colFecha_Emi_Fact.Width = 68;
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "x";
            this.colEliminar.ColumnEdit = this.cmb_eliminar;
            this.colEliminar.FieldName = "Mostrar_Icon_Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.OptionsColumn.AllowEdit = false;
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 2;
            this.colEliminar.Width = 29;
            // 
            // cmb_eliminar
            // 
            this.cmb_eliminar.AutoHeight = false;
            this.cmb_eliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_eliminar.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 4)});
            this.cmb_eliminar.LargeImages = this.imageCollectionCbtesFirma;
            this.cmb_eliminar.Name = "cmb_eliminar";
            // 
            // imageCollectionCbtesFirma
            // 
            this.imageCollectionCbtesFirma.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionCbtesFirma.ImageStream")));
            this.imageCollectionCbtesFirma.Images.SetKeyName(0, "xml_firmado_32x32.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(1, "imprimir_32x32.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(2, "1417488454_pdf.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(3, "application-xml.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(4, "anular2_32.x32png.png");
            // 
            // colAmbiente
            // 
            this.colAmbiente.Caption = "Ambiente";
            this.colAmbiente.FieldName = "Ambiente";
            this.colAmbiente.Name = "colAmbiente";
            this.colAmbiente.OptionsColumn.AllowEdit = false;
            this.colAmbiente.Visible = true;
            this.colAmbiente.VisibleIndex = 3;
            this.colAmbiente.Width = 73;
            // 
            // ColRide
            // 
            this.ColRide.Caption = "Ride";
            this.ColRide.ColumnEdit = this.repositoryItemImageComboBox1;
            this.ColRide.FieldName = "MosTrar_icono_Ride";
            this.ColRide.Name = "ColRide";
            this.ColRide.OptionsColumn.AllowEdit = false;
            this.ColRide.Visible = true;
            this.ColRide.VisibleIndex = 10;
            this.ColRide.Width = 50;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2)});
            this.repositoryItemImageComboBox1.LargeImages = this.imageCollectionCbtesFirma;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uC_ContenedorHilos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1012, 213);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xml en Proceso de Firma";
            // 
            // uC_ContenedorHilos
            // 
            this.uC_ContenedorHilos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_ContenedorHilos.InfoParametros = null;
            this.uC_ContenedorHilos.listaEmpresa = null;
            this.uC_ContenedorHilos.listComprobanteAFirmar = null;
            this.uC_ContenedorHilos.listmail_cuentas_correo = null;
            this.uC_ContenedorHilos.listmail_cuentas_correo_x_empresa = null;
            this.uC_ContenedorHilos.listTocken = null;
            this.uC_ContenedorHilos.listUsuario_de_Tocken = null;
            this.uC_ContenedorHilos.Location = new System.Drawing.Point(3, 16);
            this.uC_ContenedorHilos.Name = "uC_ContenedorHilos";
            this.uC_ContenedorHilos.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.uC_ContenedorHilos.Size = new System.Drawing.Size(1006, 194);
            this.uC_ContenedorHilos.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_firmar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.btn_refresh_listado,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.btn_test_ws_sri});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1012, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_firmar
            // 
            this.btn_firmar.Image = ((System.Drawing.Image)(resources.GetObject("btn_firmar.Image")));
            this.btn_firmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_firmar.Name = "btn_firmar";
            this.btn_firmar.Size = new System.Drawing.Size(138, 22);
            this.btn_firmar.Text = "Firmarcomprobantes";
            this.btn_firmar.Click += new System.EventHandler(this.btn_firmar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(181, 22);
            this.toolStripLabel1.Text = "                                                          ";
            // 
            // btn_refresh_listado
            // 
            this.btn_refresh_listado.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh_listado.Image")));
            this.btn_refresh_listado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh_listado.Name = "btn_refresh_listado";
            this.btn_refresh_listado.Size = new System.Drawing.Size(75, 22);
            this.btn_refresh_listado.Text = "Refrescar";
            this.btn_refresh_listado.Click += new System.EventHandler(this.btn_refresh_listado_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel2.Text = "                            ";
            // 
            // btn_test_ws_sri
            // 
            this.btn_test_ws_sri.Image = ((System.Drawing.Image)(resources.GetObject("btn_test_ws_sri.Image")));
            this.btn_test_ws_sri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_test_ws_sri.Name = "btn_test_ws_sri";
            this.btn_test_ws_sri.Size = new System.Drawing.Size(136, 22);
            this.btn_test_ws_sri.Text = "Test WebServices SRI";
            this.btn_test_ws_sri.Click += new System.EventHandler(this.btn_test_ws_sri_Click);
            // 
            // xtraTabPageHorario
            // 
            this.xtraTabPageHorario.Controls.Add(this.uC_Horario_Actividades);
            this.xtraTabPageHorario.Name = "xtraTabPageHorario";
            this.xtraTabPageHorario.Size = new System.Drawing.Size(1018, 477);
            this.xtraTabPageHorario.Text = "Horario de Actividad";
            // 
            // uC_Horario_Actividades
            // 
            this.uC_Horario_Actividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Horario_Actividades.IdTransaccion = "CBTE_A_FIRMAR";
            this.uC_Horario_Actividades.Location = new System.Drawing.Point(0, 0);
            this.uC_Horario_Actividades.Name = "uC_Horario_Actividades";
            this.uC_Horario_Actividades.Size = new System.Drawing.Size(1018, 477);
            this.uC_Horario_Actividades.TabIndex = 0;
            this.uC_Horario_Actividades.event_Disparador_horario += new Efirm.UC_Horario_Actividades.delegate_Disparador_horario(this.uC_Horario_Actividades_event_Disparador_horario);
            // 
            // timerFirmarXML
            // 
            this.timerFirmarXML.Interval = 1000;
            this.timerFirmarXML.Tick += new System.EventHandler(this.timerFirmarXML_Tick);
            // 
            // timerRefrescar
            // 
            this.timerRefrescar.Interval = 1000;
            this.timerRefrescar.Tick += new System.EventHandler(this.timerRefrescar_Tick);
            // 
            // UC_Comprobante_x_Enviar_firmar_al_SRI_efirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "UC_Comprobante_x_Enviar_firmar_al_SRI_efirm";
            this.Size = new System.Drawing.Size(1024, 505);
            this.Load += new System.EventHandler(this.UC_Comprobante_Valido_Firmado_efirm_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageFileValidos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.xtraTabPageHorario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFiles;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_firmar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_refresh_listado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraGrid.Columns.GridColumn colError;
        private DevExpress.XtraGrid.Columns.GridColumn colRespuestaSRI;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFileValidos;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHorario;
        private UC_Horario_Actividades uC_Horario_Actividades;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private UC_ContenedorHilos uC_ContenedorHilos;
        private System.Windows.Forms.Timer timerFirmarXML;
        private System.Windows.Forms.Timer timerRefrescar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_test_ws_sri;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Emi_Fact;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_eliminar;
        private DevExpress.XtraGrid.Columns.GridColumn colAmbiente;
        private DevExpress.XtraGrid.Columns.GridColumn ColRide;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.Utils.ImageCollection imageCollectionCbtesFirma;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.CheckEdit chkTodos;
        private DevExpress.XtraGrid.Columns.GridColumn col_Total;
    }
}
