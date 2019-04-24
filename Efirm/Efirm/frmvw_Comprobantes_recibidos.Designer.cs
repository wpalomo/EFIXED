namespace Efirm
{
    partial class frmvw_Comprobantes_recibidos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvw_Comprobantes_recibidos));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDescargaPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDescargaXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlFiles = new DevExpress.XtraGrid.GridControl();
            this.gridViewFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colunomTipoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRideXml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollectionCbtesFirma = new DevExpress.Utils.ImageCollection(this.components);
            this.colAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_archi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colextencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmail_emisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCed_Ruc_Emisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazon_Social_emisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsXml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_Mensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodMensajeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTexto_mensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArchivo_adjunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cols_Xml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluRazon_Social_emisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluclaveAcceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPdf = new System.Windows.Forms.CheckBox();
            this.chkXml = new System.Windows.Forms.CheckBox();
            this.dtp_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fechaIni = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDescargaPDF,
            this.toolStripSeparator1,
            this.btnDescargaXML,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(949, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDescargaPDF
            // 
            this.btnDescargaPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargaPDF.Image")));
            this.btnDescargaPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargaPDF.Name = "btnDescargaPDF";
            this.btnDescargaPDF.Size = new System.Drawing.Size(99, 22);
            this.btnDescargaPDF.Text = "Descarga PDF";
            this.btnDescargaPDF.Click += new System.EventHandler(this.btnDescargaPDF_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDescargaXML
            // 
            this.btnDescargaXML.Image = global::Efirm.Properties.Resources.application_xml;
            this.btnDescargaXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargaXML.Name = "btnDescargaXML";
            this.btnDescargaXML.Size = new System.Drawing.Size(102, 22);
            this.btnDescargaXML.Text = "Descarga XML";
            this.btnDescargaXML.Click += new System.EventHandler(this.btnDescargaXML_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 472);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 363);
            this.panel2.TabIndex = 8;
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
            this.repositoryItemImageEdit1});
            this.gridControlFiles.Size = new System.Drawing.Size(949, 363);
            this.gridControlFiles.TabIndex = 12;
            this.gridControlFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFiles});
            // 
            // gridViewFiles
            // 
            this.gridViewFiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colunomTipoDoc,
            this.colCheked,
            this.colRideXml,
            this.colAmbiente,
            this.coldescripcion_archi,
            this.colextencion,
            this.colFecha,
            this.colAsunto,
            this.colmail_emisor,
            this.colCed_Ruc_Emisor,
            this.colRazon_Social_emisor,
            this.colsXml,
            this.colIdTipo_Mensaje,
            this.colcodMensajeId,
            this.colIdCuenta,
            this.colTexto_mensaje,
            this.colSecuencia,
            this.colArchivo_adjunto,
            this.colPara,
            this.colIdMensaje,
            this.colTipoDocumento,
            this.cols_Xml,
            this.colcedula,
            this.coluFecha,
            this.coluAmbiente,
            this.coluRazon_Social_emisor,
            this.coluclaveAcceso,
            this.colEstado});
            this.gridViewFiles.GridControl = this.gridControlFiles;
            this.gridViewFiles.Name = "gridViewFiles";
            this.gridViewFiles.OptionsBehavior.Editable = false;
            this.gridViewFiles.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFiles.OptionsView.ShowGroupPanel = false;
            this.gridViewFiles.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewFiles_RowCellClick);
            // 
            // colunomTipoDoc
            // 
            this.colunomTipoDoc.Caption = "Tipo Documento";
            this.colunomTipoDoc.FieldName = "nomTipoDoc";
            this.colunomTipoDoc.Name = "colunomTipoDoc";
            this.colunomTipoDoc.Visible = true;
            this.colunomTipoDoc.VisibleIndex = 5;
            this.colunomTipoDoc.Width = 73;
            // 
            // colCheked
            // 
            this.colCheked.Caption = "*";
            this.colCheked.FieldName = "Checked";
            this.colCheked.Name = "colCheked";
            this.colCheked.OptionsColumn.AllowEdit = false;
            this.colCheked.OptionsColumn.AllowSize = false;
            this.colCheked.Visible = true;
            this.colCheked.VisibleIndex = 0;
            this.colCheked.Width = 22;
            // 
            // colRideXml
            // 
            this.colRideXml.Caption = "Ride/Xml";
            this.colRideXml.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colRideXml.FieldName = "MosTrar_icono";
            this.colRideXml.Name = "colRideXml";
            this.colRideXml.OptionsColumn.AllowEdit = false;
            this.colRideXml.Width = 68;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", ".pdf", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", ".Xml", 3)});
            this.repositoryItemImageComboBox1.LargeImages = this.imageCollectionCbtesFirma;
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
            // 
            // colAmbiente
            // 
            this.colAmbiente.Caption = "Ambiente";
            this.colAmbiente.FieldName = "Ambiente";
            this.colAmbiente.Name = "colAmbiente";
            this.colAmbiente.Width = 42;
            // 
            // coldescripcion_archi
            // 
            this.coldescripcion_archi.Caption = "Descripción Archivo";
            this.coldescripcion_archi.FieldName = "descripcion_archi";
            this.coldescripcion_archi.Name = "coldescripcion_archi";
            this.coldescripcion_archi.Visible = true;
            this.coldescripcion_archi.VisibleIndex = 1;
            this.coldescripcion_archi.Width = 137;
            // 
            // colextencion
            // 
            this.colextencion.Caption = "Extencion";
            this.colextencion.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colextencion.FieldName = "extencion";
            this.colextencion.Name = "colextencion";
            this.colextencion.Visible = true;
            this.colextencion.VisibleIndex = 3;
            this.colextencion.Width = 44;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 42;
            // 
            // colAsunto
            // 
            this.colAsunto.Caption = "Asunto";
            this.colAsunto.FieldName = "Asunto";
            this.colAsunto.Name = "colAsunto";
            this.colAsunto.Visible = true;
            this.colAsunto.VisibleIndex = 4;
            this.colAsunto.Width = 70;
            // 
            // colmail_emisor
            // 
            this.colmail_emisor.Caption = "mail_emisor";
            this.colmail_emisor.FieldName = "mail_emisor";
            this.colmail_emisor.Name = "colmail_emisor";
            this.colmail_emisor.Width = 148;
            // 
            // colCed_Ruc_Emisor
            // 
            this.colCed_Ruc_Emisor.Caption = "Cedula/Ruc ";
            this.colCed_Ruc_Emisor.FieldName = "Ced_Ruc_Emisor";
            this.colCed_Ruc_Emisor.Name = "colCed_Ruc_Emisor";
            this.colCed_Ruc_Emisor.Width = 62;
            // 
            // colRazon_Social_emisor
            // 
            this.colRazon_Social_emisor.Caption = "Razon Social";
            this.colRazon_Social_emisor.FieldName = "Razon_Social_emisor";
            this.colRazon_Social_emisor.Name = "colRazon_Social_emisor";
            this.colRazon_Social_emisor.Width = 40;
            // 
            // colsXml
            // 
            this.colsXml.Caption = "sXml";
            this.colsXml.FieldName = "sXml";
            this.colsXml.Name = "colsXml";
            this.colsXml.Width = 31;
            // 
            // colIdTipo_Mensaje
            // 
            this.colIdTipo_Mensaje.Caption = "Tipo Mensaje";
            this.colIdTipo_Mensaje.FieldName = "IdTipo_Mensaje";
            this.colIdTipo_Mensaje.Name = "colIdTipo_Mensaje";
            this.colIdTipo_Mensaje.Width = 134;
            // 
            // colcodMensajeId
            // 
            this.colcodMensajeId.Caption = "Código Mensaje";
            this.colcodMensajeId.FieldName = "codMensajeId";
            this.colcodMensajeId.Name = "colcodMensajeId";
            this.colcodMensajeId.Width = 122;
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.Caption = "Id Cuenta";
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.Width = 73;
            // 
            // colTexto_mensaje
            // 
            this.colTexto_mensaje.Caption = "Texto";
            this.colTexto_mensaje.FieldName = "Texto_mensaje";
            this.colTexto_mensaje.Name = "colTexto_mensaje";
            this.colTexto_mensaje.Width = 114;
            // 
            // colSecuencia
            // 
            this.colSecuencia.Caption = "Secuencia";
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.Width = 115;
            // 
            // colArchivo_adjunto
            // 
            this.colArchivo_adjunto.Caption = "Archivo Adjunto";
            this.colArchivo_adjunto.FieldName = "Archivo_adjunto";
            this.colArchivo_adjunto.Name = "colArchivo_adjunto";
            this.colArchivo_adjunto.Width = 96;
            // 
            // colPara
            // 
            this.colPara.Caption = "Para";
            this.colPara.FieldName = "Para";
            this.colPara.Name = "colPara";
            this.colPara.Width = 56;
            // 
            // colIdMensaje
            // 
            this.colIdMensaje.Caption = "Id Mensaje";
            this.colIdMensaje.FieldName = "IdMensaje";
            this.colIdMensaje.Name = "colIdMensaje";
            this.colIdMensaje.Width = 96;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.Caption = "Tipo Documento";
            this.colTipoDocumento.FieldName = "TipoDocumento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.Width = 66;
            // 
            // cols_Xml
            // 
            this.cols_Xml.Caption = "XML";
            this.cols_Xml.FieldName = "s_Xml";
            this.cols_Xml.Name = "cols_Xml";
            this.cols_Xml.Visible = true;
            this.cols_Xml.VisibleIndex = 6;
            this.cols_Xml.Width = 74;
            // 
            // colcedula
            // 
            this.colcedula.Caption = "Cedula/Ruc";
            this.colcedula.FieldName = "Ced_Ruc_Emisor";
            this.colcedula.Name = "colcedula";
            this.colcedula.Visible = true;
            this.colcedula.VisibleIndex = 7;
            this.colcedula.Width = 104;
            // 
            // coluFecha
            // 
            this.coluFecha.Caption = "Fecha";
            this.coluFecha.FieldName = "Fecha";
            this.coluFecha.Name = "coluFecha";
            this.coluFecha.Visible = true;
            this.coluFecha.VisibleIndex = 2;
            this.coluFecha.Width = 110;
            // 
            // coluAmbiente
            // 
            this.coluAmbiente.Caption = "Ambiente";
            this.coluAmbiente.FieldName = "Ambiente";
            this.coluAmbiente.Name = "coluAmbiente";
            this.coluAmbiente.Visible = true;
            this.coluAmbiente.VisibleIndex = 8;
            this.coluAmbiente.Width = 50;
            // 
            // coluRazon_Social_emisor
            // 
            this.coluRazon_Social_emisor.Caption = "Razon Social";
            this.coluRazon_Social_emisor.FieldName = "Razon_Social_emisor";
            this.coluRazon_Social_emisor.Name = "coluRazon_Social_emisor";
            this.coluRazon_Social_emisor.Visible = true;
            this.coluRazon_Social_emisor.VisibleIndex = 9;
            this.coluRazon_Social_emisor.Width = 55;
            // 
            // coluclaveAcceso
            // 
            this.coluclaveAcceso.Caption = "claveAcceso";
            this.coluclaveAcceso.FieldName = "ClaveAcceso";
            this.coluclaveAcceso.Name = "coluclaveAcceso";
            this.coluclaveAcceso.Visible = true;
            this.coluclaveAcceso.VisibleIndex = 10;
            this.coluclaveAcceso.Width = 192;
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 3)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPdf);
            this.groupBox1.Controls.Add(this.chkXml);
            this.groupBox1.Controls.Add(this.dtp_fechaFin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_fechaIni);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chkPdf
            // 
            this.chkPdf.AutoSize = true;
            this.chkPdf.Location = new System.Drawing.Point(12, 41);
            this.chkPdf.Name = "chkPdf";
            this.chkPdf.Size = new System.Drawing.Size(47, 17);
            this.chkPdf.TabIndex = 9;
            this.chkPdf.Text = "PDF";
            this.chkPdf.UseVisualStyleBackColor = true;
            this.chkPdf.CheckedChanged += new System.EventHandler(this.chkPdf_CheckedChanged);
            // 
            // chkXml
            // 
            this.chkXml.AutoSize = true;
            this.chkXml.Location = new System.Drawing.Point(12, 64);
            this.chkXml.Name = "chkXml";
            this.chkXml.Size = new System.Drawing.Size(48, 17);
            this.chkXml.TabIndex = 7;
            this.chkXml.Text = "XML";
            this.chkXml.UseVisualStyleBackColor = true;
            this.chkXml.CheckedChanged += new System.EventHandler(this.chkXml_CheckedChanged);
            // 
            // dtp_fechaFin
            // 
            this.dtp_fechaFin.Location = new System.Drawing.Point(152, 45);
            this.dtp_fechaFin.Name = "dtp_fechaFin";
            this.dtp_fechaFin.Size = new System.Drawing.Size(220, 20);
            this.dtp_fechaFin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(423, 22);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(175, 25);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // dtp_fechaIni
            // 
            this.dtp_fechaIni.Location = new System.Drawing.Point(152, 19);
            this.dtp_fechaIni.Name = "dtp_fechaIni";
            this.dtp_fechaIni.Size = new System.Drawing.Size(220, 20);
            this.dtp_fechaIni.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado_SRI";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 11;
            // 
            // frmvw_Comprobantes_recibidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmvw_Comprobantes_recibidos";
            this.Text = "Comprobantes Recibidos";
            this.Load += new System.EventHandler(this.frmvw_Comprobantes_recibidos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnDescargaPDF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDescargaXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_fechaFin;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fechaIni;
        private System.Windows.Forms.CheckBox chkXml;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.Utils.ImageCollection imageCollectionCbtesFirma;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.GridControl gridControlFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFiles;
        private DevExpress.XtraGrid.Columns.GridColumn colCheked;
        private DevExpress.XtraGrid.Columns.GridColumn colRideXml;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmbiente;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_archi;
        private DevExpress.XtraGrid.Columns.GridColumn colextencion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colAsunto;
        private DevExpress.XtraGrid.Columns.GridColumn colmail_emisor;
        private DevExpress.XtraGrid.Columns.GridColumn colCed_Ruc_Emisor;
        private DevExpress.XtraGrid.Columns.GridColumn colRazon_Social_emisor;
        private DevExpress.XtraGrid.Columns.GridColumn colsXml;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_Mensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colcodMensajeId;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colTexto_mensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colArchivo_adjunto;
        private DevExpress.XtraGrid.Columns.GridColumn colPara;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDocumento;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn cols_Xml;
        private DevExpress.XtraGrid.Columns.GridColumn colcedula;
        private DevExpress.XtraGrid.Columns.GridColumn coluFecha;
        private DevExpress.XtraGrid.Columns.GridColumn coluAmbiente;
        private DevExpress.XtraGrid.Columns.GridColumn coluRazon_Social_emisor;
        private DevExpress.XtraGrid.Columns.GridColumn coluclaveAcceso;
        private DevExpress.XtraGrid.Columns.GridColumn colunomTipoDoc;
        private System.Windows.Forms.CheckBox chkPdf;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}