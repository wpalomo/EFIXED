namespace Efirm
{
    partial class UC_Comprobante_Autoriz_No_Autoriz_x_SRI
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Comprobante_Autoriz_No_Autoriz_x_SRI));
            this.gridControlFiles = new DevExpress.XtraGrid.GridControl();
            this.gridViewFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_emisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado_cbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cols_XML = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_estado_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRespuestaSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero_Autorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollectionCbtesFirma = new DevExpress.Utils.ImageCollection(this.components);
            this.colXml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colFecha_Emi_Fact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_eliminar = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Cedula_Ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Clave_Acceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Nom_Contribuyente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFila = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoDoc = new Efirm.UC_TipoDocumento();
            this.cmbEmisor = new Efirm.UC_Emisor();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tipo_Autorizacion = new System.Windows.Forms.ComboBox();
            this.dtp_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fechaIni = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.uC_Botones_Paginas1 = new Efirm.UC_Botones_Paginas();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlFiles
            // 
            this.gridControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlFiles.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlFiles.Location = new System.Drawing.Point(0, 0);
            this.gridControlFiles.MainView = this.gridViewFiles;
            this.gridControlFiles.Name = "gridControlFiles";
            this.gridControlFiles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageEdit1,
            this.cmb_eliminar});
            this.gridControlFiles.Size = new System.Drawing.Size(1015, 287);
            this.gridControlFiles.TabIndex = 2;
            this.gridControlFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFiles});
            this.gridControlFiles.Click += new System.EventHandler(this.gridControlFiles_Click);
            // 
            // gridViewFiles
            // 
            this.gridViewFiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheked,
            this.colNom_emisor,
            this.colIdComprobante,
            this.colNomTipoDocumento,
            this.colIdEstado_cbte,
            this.cols_XML,
            this.colFecha_transaccion,
            this.colnom_estado_doc,
            this.colFechaAutorizacion,
            this.colEstadoDoc,
            this.colRespuestaSRI,
            this.colNumero_Autorizacion,
            this.colTotal,
            this.colRide,
            this.colXml,
            this.colFecha_Emi_Fact,
            this.colEliminar,
            this.colAmbiente,
            this.colError,
            this.col_Cedula_Ruc,
            this.col_Clave_Acceso,
            this.col_Nom_Contribuyente,
            this.colNumFila});
            this.gridViewFiles.CustomizationFormBounds = new System.Drawing.Rectangle(1020, 347, 216, 178);
            this.gridViewFiles.GridControl = this.gridControlFiles;
            this.gridViewFiles.Name = "gridViewFiles";
            this.gridViewFiles.OptionsView.ColumnAutoWidth = false;
            this.gridViewFiles.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFiles.OptionsView.ShowGroupPanel = false;
            this.gridViewFiles.OptionsView.ShowViewCaption = true;
            this.gridViewFiles.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewFiles_RowCellClick);
            this.gridViewFiles.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewFiles_RowCellStyle);
            // 
            // colCheked
            // 
            this.colCheked.Caption = "*";
            this.colCheked.FieldName = "Checked";
            this.colCheked.Name = "colCheked";
            this.colCheked.Visible = true;
            this.colCheked.VisibleIndex = 0;
            this.colCheked.Width = 20;
            // 
            // colNom_emisor
            // 
            this.colNom_emisor.Caption = "Emisor";
            this.colNom_emisor.FieldName = "Nom_emisor";
            this.colNom_emisor.Name = "colNom_emisor";
            this.colNom_emisor.OptionsColumn.AllowEdit = false;
            this.colNom_emisor.Visible = true;
            this.colNom_emisor.VisibleIndex = 2;
            this.colNom_emisor.Width = 71;
            // 
            // colIdComprobante
            // 
            this.colIdComprobante.Caption = "IdComprobante";
            this.colIdComprobante.FieldName = "IdComprobante";
            this.colIdComprobante.Name = "colIdComprobante";
            this.colIdComprobante.OptionsColumn.AllowEdit = false;
            this.colIdComprobante.Visible = true;
            this.colIdComprobante.VisibleIndex = 5;
            this.colIdComprobante.Width = 112;
            // 
            // colNomTipoDocumento
            // 
            this.colNomTipoDocumento.Caption = "Tipo de Documento";
            this.colNomTipoDocumento.FieldName = "Nom_TipoDocumento";
            this.colNomTipoDocumento.Name = "colNomTipoDocumento";
            this.colNomTipoDocumento.OptionsColumn.AllowEdit = false;
            // 
            // colIdEstado_cbte
            // 
            this.colIdEstado_cbte.Caption = "Estado";
            this.colIdEstado_cbte.FieldName = "IdEstado_cbte";
            this.colIdEstado_cbte.Name = "colIdEstado_cbte";
            this.colIdEstado_cbte.OptionsColumn.AllowEdit = false;
            this.colIdEstado_cbte.Width = 104;
            // 
            // cols_XML
            // 
            this.cols_XML.Caption = "s_XML";
            this.cols_XML.FieldName = "s_XML";
            this.cols_XML.Name = "cols_XML";
            this.cols_XML.OptionsColumn.AllowEdit = false;
            this.cols_XML.Visible = true;
            this.cols_XML.VisibleIndex = 9;
            this.cols_XML.Width = 47;
            // 
            // colFecha_transaccion
            // 
            this.colFecha_transaccion.Caption = "Fecha_transaccion";
            this.colFecha_transaccion.FieldName = "sFecha_transaccion";
            this.colFecha_transaccion.Name = "colFecha_transaccion";
            this.colFecha_transaccion.OptionsColumn.AllowEdit = false;
            this.colFecha_transaccion.Visible = true;
            this.colFecha_transaccion.VisibleIndex = 14;
            this.colFecha_transaccion.Width = 70;
            // 
            // colnom_estado_doc
            // 
            this.colnom_estado_doc.Caption = "Estado ";
            this.colnom_estado_doc.FieldName = "Nom_estado_doc";
            this.colnom_estado_doc.Name = "colnom_estado_doc";
            this.colnom_estado_doc.OptionsColumn.AllowEdit = false;
            this.colnom_estado_doc.Width = 184;
            // 
            // colFechaAutorizacion
            // 
            this.colFechaAutorizacion.Caption = "FechaAutorizacion";
            this.colFechaAutorizacion.FieldName = "sFechaAutorizacion";
            this.colFechaAutorizacion.Name = "colFechaAutorizacion";
            this.colFechaAutorizacion.OptionsColumn.AllowEdit = false;
            this.colFechaAutorizacion.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colFechaAutorizacion.Visible = true;
            this.colFechaAutorizacion.VisibleIndex = 8;
            this.colFechaAutorizacion.Width = 85;
            // 
            // colEstadoDoc
            // 
            this.colEstadoDoc.Caption = "Estado SRI";
            this.colEstadoDoc.FieldName = "EstadoDoc";
            this.colEstadoDoc.Name = "colEstadoDoc";
            this.colEstadoDoc.OptionsColumn.AllowEdit = false;
            this.colEstadoDoc.Visible = true;
            this.colEstadoDoc.VisibleIndex = 6;
            this.colEstadoDoc.Width = 79;
            // 
            // colRespuestaSRI
            // 
            this.colRespuestaSRI.Caption = "RespuestaSRI";
            this.colRespuestaSRI.FieldName = "RespuestaSRI";
            this.colRespuestaSRI.Name = "colRespuestaSRI";
            this.colRespuestaSRI.OptionsColumn.AllowEdit = false;
            this.colRespuestaSRI.Width = 86;
            // 
            // colNumero_Autorizacion
            // 
            this.colNumero_Autorizacion.Caption = "#Autorizacion";
            this.colNumero_Autorizacion.FieldName = "Numero_Autorizacion";
            this.colNumero_Autorizacion.Name = "colNumero_Autorizacion";
            this.colNumero_Autorizacion.OptionsColumn.AllowEdit = false;
            this.colNumero_Autorizacion.Visible = true;
            this.colNumero_Autorizacion.VisibleIndex = 10;
            this.colNumero_Autorizacion.Width = 63;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 12;
            // 
            // colRide
            // 
            this.colRide.Caption = "Ride";
            this.colRide.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colRide.FieldName = "MosTrar_icono_Ride";
            this.colRide.Name = "colRide";
            this.colRide.OptionsColumn.AllowEdit = false;
            this.colRide.Visible = true;
            this.colRide.VisibleIndex = 11;
            this.colRide.Width = 45;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollectionCbtesFirma;
            // 
            // imageCollectionCbtesFirma
            // 
            this.imageCollectionCbtesFirma.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionCbtesFirma.ImageStream")));
            this.imageCollectionCbtesFirma.Images.SetKeyName(0, "xml_firmado_32x32.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(1, "imprimir_32x32.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(2, "1417488454_pdf.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(3, "application-xml.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(4, "anular2_32.x32png.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(5, "anular1_128x128.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(6, "anular1_64x64.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(7, "anular1_128x128.png");
            // 
            // colXml
            // 
            this.colXml.Caption = "File XML";
            this.colXml.ColumnEdit = this.repositoryItemImageComboBox2;
            this.colXml.FieldName = "MosTrar_icono_xml";
            this.colXml.Name = "colXml";
            this.colXml.OptionsColumn.AllowEdit = false;
            this.colXml.Visible = true;
            this.colXml.VisibleIndex = 13;
            this.colXml.Width = 60;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 3)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.imageCollectionCbtesFirma;
            // 
            // colFecha_Emi_Fact
            // 
            this.colFecha_Emi_Fact.Caption = "Fecha_Emi";
            this.colFecha_Emi_Fact.FieldName = "Fecha_Emi_Fact";
            this.colFecha_Emi_Fact.Name = "colFecha_Emi_Fact";
            this.colFecha_Emi_Fact.OptionsColumn.AllowEdit = false;
            this.colFecha_Emi_Fact.Visible = true;
            this.colFecha_Emi_Fact.VisibleIndex = 7;
            this.colFecha_Emi_Fact.Width = 81;
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "x";
            this.colEliminar.ColumnEdit = this.cmb_eliminar;
            this.colEliminar.FieldName = "Mostrar_Icon_Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.OptionsColumn.AllowEdit = false;
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 4;
            this.colEliminar.Width = 24;
            // 
            // cmb_eliminar
            // 
            this.cmb_eliminar.AutoHeight = false;
            this.cmb_eliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_eliminar.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 5)});
            this.cmb_eliminar.LargeImages = this.imageCollectionCbtesFirma;
            this.cmb_eliminar.Name = "cmb_eliminar";
            // 
            // colAmbiente
            // 
            this.colAmbiente.Caption = "Ambiente";
            this.colAmbiente.FieldName = "Ambiente";
            this.colAmbiente.Name = "colAmbiente";
            this.colAmbiente.Visible = true;
            this.colAmbiente.VisibleIndex = 3;
            this.colAmbiente.Width = 55;
            // 
            // colError
            // 
            this.colError.Caption = "Error";
            this.colError.FieldName = "Error";
            this.colError.Name = "colError";
            this.colError.OptionsColumn.AllowEdit = false;
            this.colError.Visible = true;
            this.colError.VisibleIndex = 15;
            this.colError.Width = 63;
            // 
            // col_Cedula_Ruc
            // 
            this.col_Cedula_Ruc.Caption = "Cedula/Ruc";
            this.col_Cedula_Ruc.FieldName = "Cedula_Ruc";
            this.col_Cedula_Ruc.Name = "col_Cedula_Ruc";
            this.col_Cedula_Ruc.Visible = true;
            this.col_Cedula_Ruc.VisibleIndex = 16;
            this.col_Cedula_Ruc.Width = 77;
            // 
            // col_Clave_Acceso
            // 
            this.col_Clave_Acceso.Caption = "Clave Acceso";
            this.col_Clave_Acceso.FieldName = "Clave_Acceso";
            this.col_Clave_Acceso.Name = "col_Clave_Acceso";
            this.col_Clave_Acceso.Visible = true;
            this.col_Clave_Acceso.VisibleIndex = 18;
            this.col_Clave_Acceso.Width = 68;
            // 
            // col_Nom_Contribuyente
            // 
            this.col_Nom_Contribuyente.Caption = "Razon Social /Contribuyente";
            this.col_Nom_Contribuyente.FieldName = "Nom_Contribuyente";
            this.col_Nom_Contribuyente.Name = "col_Nom_Contribuyente";
            this.col_Nom_Contribuyente.Visible = true;
            this.col_Nom_Contribuyente.VisibleIndex = 17;
            this.col_Nom_Contribuyente.Width = 112;
            // 
            // colNumFila
            // 
            this.colNumFila.Caption = "#Registro";
            this.colNumFila.FieldName = "NumFila";
            this.colNumFila.Name = "colNumFila";
            this.colNumFila.Visible = true;
            this.colNumFila.VisibleIndex = 1;
            this.colNumFila.Width = 48;
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            this.repositoryItemImageComboBox3.SmallImages = this.imageCollectionCbtesFirma;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Images = this.imageCollectionCbtesFirma;
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1015, 92);
            this.panelTop.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoDoc);
            this.groupBox1.Controls.Add(this.cmbEmisor);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_tipo_Autorizacion);
            this.groupBox1.Controls.Add(this.dtp_fechaFin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_fechaIni);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.Location = new System.Drawing.Point(131, 37);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(498, 23);
            this.cmbTipoDoc.TabIndex = 14;
            // 
            // cmbEmisor
            // 
            this.cmbEmisor.Location = new System.Drawing.Point(131, 15);
            this.cmbEmisor.Name = "cmbEmisor";
            this.cmbEmisor.Size = new System.Drawing.Size(498, 23);
            this.cmbEmisor.TabIndex = 13;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(131, 61);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(498, 20);
            this.txtBusqueda.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Buscar por esta palabra :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Comprobante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Emisor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Autorizacion(SRI):";
            // 
            // cmb_tipo_Autorizacion
            // 
            this.cmb_tipo_Autorizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_Autorizacion.FormattingEnabled = true;
            this.cmb_tipo_Autorizacion.Items.AddRange(new object[] {
            "TODOS",
            "AUTORIZADO",
            "NO AUTORIZADO"});
            this.cmb_tipo_Autorizacion.Location = new System.Drawing.Point(800, 13);
            this.cmb_tipo_Autorizacion.Name = "cmb_tipo_Autorizacion";
            this.cmb_tipo_Autorizacion.Size = new System.Drawing.Size(197, 21);
            this.cmb_tipo_Autorizacion.TabIndex = 4;
            this.cmb_tipo_Autorizacion.SelectedValueChanged += new System.EventHandler(this.cmb_tipo_Autorizacion_SelectedValueChanged);
            // 
            // dtp_fechaFin
            // 
            this.dtp_fechaFin.Location = new System.Drawing.Point(800, 63);
            this.dtp_fechaFin.Name = "dtp_fechaFin";
            this.dtp_fechaFin.Size = new System.Drawing.Size(197, 20);
            this.dtp_fechaFin.TabIndex = 3;
            this.dtp_fechaFin.ValueChanged += new System.EventHandler(this.dtp_fechaFin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // dtp_fechaIni
            // 
            this.dtp_fechaIni.Location = new System.Drawing.Point(800, 40);
            this.dtp_fechaIni.Name = "dtp_fechaIni";
            this.dtp_fechaIni.Size = new System.Drawing.Size(197, 20);
            this.dtp_fechaIni.TabIndex = 1;
            this.dtp_fechaIni.ValueChanged += new System.EventHandler(this.dtp_fechaIni_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 312);
            this.panel1.TabIndex = 5;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.uC_Botones_Paginas1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlFiles);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1015, 312);
            this.splitContainerControl1.SplitterPosition = 20;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // uC_Botones_Paginas1
            // 
            this.uC_Botones_Paginas1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_Botones_Paginas1.IndicePagina = 1;
            this.uC_Botones_Paginas1.Location = new System.Drawing.Point(0, 0);
            this.uC_Botones_Paginas1.Name = "uC_Botones_Paginas1";
            this.uC_Botones_Paginas1.NumeroPaginas = 0;
            this.uC_Botones_Paginas1.Size = new System.Drawing.Size(1015, 28);
            this.uC_Botones_Paginas1.TabIndex = 1;
            this.uC_Botones_Paginas1.event_click_buttons += new Efirm.UC_Botones_Paginas.delegate_btn_Click(this.uC_Botones_Paginas1_event_click_buttons);
            this.uC_Botones_Paginas1.Load += new System.EventHandler(this.uC_Botones_Paginas1_Load);
            // 
            // UC_Comprobante_Autoriz_No_Autoriz_x_SRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_Comprobante_Autoriz_No_Autoriz_x_SRI";
            this.Size = new System.Drawing.Size(1015, 404);
            this.Load += new System.EventHandler(this.UC_Comprobante_Recibidos_Aut_x_SRI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFiles;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_emisor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colNomTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado_cbte;
        private DevExpress.XtraGrid.Columns.GridColumn cols_XML;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_estado_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colRespuestaSRI;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero_Autorizacion;
        private DevExpress.Utils.ImageCollection imageCollectionCbtesFirma;
        private DevExpress.XtraGrid.Columns.GridColumn colRide;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colXml;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_fechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Emi_Fact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_tipo_Autorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCheked;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_eliminar;
        private DevExpress.XtraGrid.Columns.GridColumn colAmbiente;
        private DevExpress.XtraGrid.Columns.GridColumn colError;
        private DevExpress.XtraGrid.Columns.GridColumn col_Cedula_Ruc;
        private DevExpress.XtraGrid.Columns.GridColumn col_Clave_Acceso;
        private DevExpress.XtraGrid.Columns.GridColumn col_Nom_Contribuyente;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private UC_Botones_Paginas uC_Botones_Paginas1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label6;
        private UC_TipoDocumento cmbTipoDoc;
        private UC_Emisor cmbEmisor;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFila;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
    }
}
