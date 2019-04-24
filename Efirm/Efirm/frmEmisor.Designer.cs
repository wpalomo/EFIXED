namespace Efirm
{
    partial class frmEmisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmisor));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlEmisor = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmisor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContribuyenteEspecial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Contribuyente = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colObligadoAllevarConta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_ObligConta = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colNombreCertificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave_Certificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaValidez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdToquenAFirmar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbgrid_Tocken = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion_tock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo_tock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_Ambiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbgrid_Ambiente = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_TipoEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbgrid_TipoEmision = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo_tipEmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresAUX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colValidaImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnRefresca = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Contribuyente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ObligConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgrid_Tocken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgrid_Ambiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgrid_TipoEmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1209, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnConsultar,
            this.btnRefresca,
            this.toolStripLabel2,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1209, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 22);
            this.btnNuevo.Text = "Nuevo Registro";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel2.Text = "                           ";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlEmisor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 348);
            this.panel1.TabIndex = 2;
            // 
            // gridControlEmisor
            // 
            this.gridControlEmisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmisor.Location = new System.Drawing.Point(0, 0);
            this.gridControlEmisor.MainView = this.gridViewEmisor;
            this.gridControlEmisor.Name = "gridControlEmisor";
            this.gridControlEmisor.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbgrid_Ambiente,
            this.repositoryItemDateEdit1,
            this.cmbgrid_TipoEmision,
            this.cmbgrid_Tocken,
            this.cmb_Contribuyente,
            this.cmb_ObligConta,
            this.repositoryItemPictureEdit1,
            this.repositoryItemPictureEdit2});
            this.gridControlEmisor.Size = new System.Drawing.Size(1209, 348);
            this.gridControlEmisor.TabIndex = 0;
            this.gridControlEmisor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmisor});
            this.gridControlEmisor.Click += new System.EventHandler(this.gridControlEmisor_Click);
            // 
            // gridViewEmisor
            // 
            this.gridViewEmisor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colRazonSocial,
            this.colNombreComercial,
            this.colRUC,
            this.colDirMatriz,
            this.colContribuyenteEspecial,
            this.colObligadoAllevarConta,
            this.colNombreCertificado,
            this.colClave_Certificado,
            this.colIdAmbiente,
            this.colTipoEmision,
            this.colFechaValidez,
            this.colEstado,
            this.colIdToquenAFirmar,
            this.colAlias,
            this.colcod_Ambiente,
            this.colcod_TipoEmision,
            this.colIdEmpresAUX,
            this.collogo,
            this.colimagen,
            this.colValidaImagen});
            this.gridViewEmisor.GridControl = this.gridControlEmisor;
            this.gridViewEmisor.Name = "gridViewEmisor";
            this.gridViewEmisor.OptionsBehavior.Editable = false;
            this.gridViewEmisor.OptionsView.ShowAutoFilterRow = true;
            this.gridViewEmisor.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewEmisor_RowClick);
            this.gridViewEmisor.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewEmisor_RowCellClick);
            this.gridViewEmisor.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewEmisor_RowCellStyle);
            this.gridViewEmisor.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewEmisor_CellValueChanged);
            this.gridViewEmisor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewEmisor_KeyDown);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "Empresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 0;
            this.colIdEmpresa.Width = 50;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razón Social";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 1;
            this.colRazonSocial.Width = 61;
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.Caption = "Nombre Comercial";
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 2;
            this.colNombreComercial.Width = 89;
            // 
            // colRUC
            // 
            this.colRUC.Caption = "RUC";
            this.colRUC.FieldName = "RUC";
            this.colRUC.Name = "colRUC";
            this.colRUC.Visible = true;
            this.colRUC.VisibleIndex = 3;
            this.colRUC.Width = 60;
            // 
            // colDirMatriz
            // 
            this.colDirMatriz.Caption = "Dir. Matriz";
            this.colDirMatriz.FieldName = "DirMatriz";
            this.colDirMatriz.Name = "colDirMatriz";
            this.colDirMatriz.Visible = true;
            this.colDirMatriz.VisibleIndex = 4;
            this.colDirMatriz.Width = 60;
            // 
            // colContribuyenteEspecial
            // 
            this.colContribuyenteEspecial.Caption = "Contrib. Especial";
            this.colContribuyenteEspecial.ColumnEdit = this.cmb_Contribuyente;
            this.colContribuyenteEspecial.FieldName = "ContribuyenteEspecial";
            this.colContribuyenteEspecial.Name = "colContribuyenteEspecial";
            this.colContribuyenteEspecial.Visible = true;
            this.colContribuyenteEspecial.VisibleIndex = 5;
            this.colContribuyenteEspecial.Width = 88;
            // 
            // cmb_Contribuyente
            // 
            this.cmb_Contribuyente.AutoHeight = false;
            this.cmb_Contribuyente.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Contribuyente.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmb_Contribuyente.Name = "cmb_Contribuyente";
            // 
            // colObligadoAllevarConta
            // 
            this.colObligadoAllevarConta.Caption = "ObligadoAllevarConta";
            this.colObligadoAllevarConta.ColumnEdit = this.cmb_ObligConta;
            this.colObligadoAllevarConta.FieldName = "ObligadoAllevarConta";
            this.colObligadoAllevarConta.Name = "colObligadoAllevarConta";
            this.colObligadoAllevarConta.Visible = true;
            this.colObligadoAllevarConta.VisibleIndex = 6;
            this.colObligadoAllevarConta.Width = 100;
            // 
            // cmb_ObligConta
            // 
            this.cmb_ObligConta.AutoHeight = false;
            this.cmb_ObligConta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ObligConta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmb_ObligConta.Name = "cmb_ObligConta";
            // 
            // colNombreCertificado
            // 
            this.colNombreCertificado.Caption = "Certificado";
            this.colNombreCertificado.FieldName = "NombreCertificado";
            this.colNombreCertificado.Name = "colNombreCertificado";
            this.colNombreCertificado.Visible = true;
            this.colNombreCertificado.VisibleIndex = 7;
            this.colNombreCertificado.Width = 63;
            // 
            // colClave_Certificado
            // 
            this.colClave_Certificado.Caption = "Clave Certificado";
            this.colClave_Certificado.FieldName = "Clave_Certificado";
            this.colClave_Certificado.Name = "colClave_Certificado";
            this.colClave_Certificado.Visible = true;
            this.colClave_Certificado.VisibleIndex = 8;
            this.colClave_Certificado.Width = 86;
            // 
            // colIdAmbiente
            // 
            this.colIdAmbiente.Caption = "Ambiente";
            this.colIdAmbiente.FieldName = "IdAmbiente";
            this.colIdAmbiente.Name = "colIdAmbiente";
            this.colIdAmbiente.Width = 52;
            // 
            // colTipoEmision
            // 
            this.colTipoEmision.Caption = "Tipo Emisión";
            this.colTipoEmision.FieldName = "TipoEmision";
            this.colTipoEmision.Name = "colTipoEmision";
            this.colTipoEmision.Width = 60;
            // 
            // colFechaValidez
            // 
            this.colFechaValidez.Caption = "Fecha Validez";
            this.colFechaValidez.ColumnEdit = this.repositoryItemDateEdit1;
            this.colFechaValidez.FieldName = "FechaValidez";
            this.colFechaValidez.Name = "colFechaValidez";
            this.colFechaValidez.Visible = true;
            this.colFechaValidez.VisibleIndex = 9;
            this.colFechaValidez.Width = 60;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 10;
            this.colEstado.Width = 40;
            // 
            // colIdToquenAFirmar
            // 
            this.colIdToquenAFirmar.Caption = "IdToquenAFirmar";
            this.colIdToquenAFirmar.ColumnEdit = this.cmbgrid_Tocken;
            this.colIdToquenAFirmar.FieldName = "IdToquenAFirmar";
            this.colIdToquenAFirmar.Name = "colIdToquenAFirmar";
            this.colIdToquenAFirmar.Visible = true;
            this.colIdToquenAFirmar.VisibleIndex = 11;
            this.colIdToquenAFirmar.Width = 77;
            // 
            // cmbgrid_Tocken
            // 
            this.cmbgrid_Tocken.AutoHeight = false;
            this.cmbgrid_Tocken.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbgrid_Tocken.Name = "cmbgrid_Tocken";
            this.cmbgrid_Tocken.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion_tock,
            this.colIdCatalogo_tock});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion_tock
            // 
            this.colDescripcion_tock.Caption = "Descripción";
            this.colDescripcion_tock.FieldName = "Descripcion";
            this.colDescripcion_tock.Name = "colDescripcion_tock";
            this.colDescripcion_tock.Visible = true;
            this.colDescripcion_tock.VisibleIndex = 0;
            this.colDescripcion_tock.Width = 844;
            // 
            // colIdCatalogo_tock
            // 
            this.colIdCatalogo_tock.Caption = "IdCatalogo";
            this.colIdCatalogo_tock.FieldName = "IdCatalogo";
            this.colIdCatalogo_tock.Name = "colIdCatalogo_tock";
            this.colIdCatalogo_tock.Visible = true;
            this.colIdCatalogo_tock.VisibleIndex = 1;
            this.colIdCatalogo_tock.Width = 317;
            // 
            // colAlias
            // 
            this.colAlias.Caption = "Alias";
            this.colAlias.FieldName = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 12;
            this.colAlias.Width = 40;
            // 
            // colcod_Ambiente
            // 
            this.colcod_Ambiente.Caption = "Ambiente";
            this.colcod_Ambiente.ColumnEdit = this.cmbgrid_Ambiente;
            this.colcod_Ambiente.FieldName = "cod_Ambiente";
            this.colcod_Ambiente.Name = "colcod_Ambiente";
            this.colcod_Ambiente.Visible = true;
            this.colcod_Ambiente.VisibleIndex = 13;
            this.colcod_Ambiente.Width = 48;
            // 
            // cmbgrid_Ambiente
            // 
            this.cmbgrid_Ambiente.AutoHeight = false;
            this.cmbgrid_Ambiente.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbgrid_Ambiente.Name = "cmbgrid_Ambiente";
            this.cmbgrid_Ambiente.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo,
            this.colDescripcion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.Caption = "IdCatalogo";
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            this.colIdCatalogo.Visible = true;
            this.colIdCatalogo.VisibleIndex = 1;
            this.colIdCatalogo.Width = 272;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 889;
            // 
            // colcod_TipoEmision
            // 
            this.colcod_TipoEmision.Caption = "Tipo Emisión";
            this.colcod_TipoEmision.ColumnEdit = this.cmbgrid_TipoEmision;
            this.colcod_TipoEmision.FieldName = "cod_TipoEmision";
            this.colcod_TipoEmision.Name = "colcod_TipoEmision";
            this.colcod_TipoEmision.Visible = true;
            this.colcod_TipoEmision.VisibleIndex = 14;
            this.colcod_TipoEmision.Width = 78;
            // 
            // cmbgrid_TipoEmision
            // 
            this.cmbgrid_TipoEmision.AutoHeight = false;
            this.cmbgrid_TipoEmision.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbgrid_TipoEmision.Name = "cmbgrid_TipoEmision";
            this.cmbgrid_TipoEmision.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion_2,
            this.colIdCatalogo_tipEmi});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion_2
            // 
            this.colDescripcion_2.Caption = "Descripción";
            this.colDescripcion_2.FieldName = "Descripcion";
            this.colDescripcion_2.Name = "colDescripcion_2";
            this.colDescripcion_2.Visible = true;
            this.colDescripcion_2.VisibleIndex = 0;
            // 
            // colIdCatalogo_tipEmi
            // 
            this.colIdCatalogo_tipEmi.Caption = "IdCatalogo";
            this.colIdCatalogo_tipEmi.FieldName = "IdCatalogo";
            this.colIdCatalogo_tipEmi.Name = "colIdCatalogo_tipEmi";
            this.colIdCatalogo_tipEmi.Visible = true;
            this.colIdCatalogo_tipEmi.VisibleIndex = 1;
            // 
            // colIdEmpresAUX
            // 
            this.colIdEmpresAUX.FieldName = "IdEmpresAUX";
            this.colIdEmpresAUX.Name = "colIdEmpresAUX";
            // 
            // collogo
            // 
            this.collogo.Caption = "Logo";
            this.collogo.FieldName = "logo";
            this.collogo.Name = "collogo";
            this.collogo.OptionsColumn.AllowEdit = false;
            // 
            // colimagen
            // 
            this.colimagen.Caption = "Imagen";
            this.colimagen.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colimagen.FieldName = "imagen";
            this.colimagen.Name = "colimagen";
            this.colimagen.OptionsColumn.AllowEdit = false;
            this.colimagen.Visible = true;
            this.colimagen.VisibleIndex = 15;
            this.colimagen.Width = 79;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // colValidaImagen
            // 
            this.colValidaImagen.FieldName = "ValidaImagen";
            this.colValidaImagen.Name = "colValidaImagen";
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // btnRefresca
            // 
            this.btnRefresca.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresca.Image")));
            this.btnRefresca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresca.Name = "btnRefresca";
            this.btnRefresca.Size = new System.Drawing.Size(75, 22);
            this.btnRefresca.Text = "Refrescar";
            this.btnRefresca.Click += new System.EventHandler(this.btnRefresca_Click);
            // 
            // frmEmisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmEmisor";
            this.Text = "Emisor";
            this.Load += new System.EventHandler(this.frmEmisor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Contribuyente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ObligConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgrid_Tocken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgrid_Ambiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgrid_TipoEmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlEmisor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmisor;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colRUC;
        private DevExpress.XtraGrid.Columns.GridColumn colDirMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colContribuyenteEspecial;
        private DevExpress.XtraGrid.Columns.GridColumn colObligadoAllevarConta;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCertificado;
        private DevExpress.XtraGrid.Columns.GridColumn colClave_Certificado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAmbiente;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoEmision;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaValidez;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdToquenAFirmar;
        private DevExpress.XtraGrid.Columns.GridColumn colAlias;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbgrid_Ambiente;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbgrid_TipoEmision;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo_tipEmi;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_Ambiente;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_TipoEmision;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbgrid_Tocken;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_tock;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo_tock;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmb_Contribuyente;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmb_ObligConta;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresAUX;
        private DevExpress.XtraGrid.Columns.GridColumn collogo;
        private DevExpress.XtraGrid.Columns.GridColumn colimagen;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colValidaImagen;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripButton btnRefresca;
    }
}