
namespace Efirm
{
    partial class frmCargaDatos
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDatos));
            this.chkSelecTodos = new System.Windows.Forms.CheckBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gridControlCbtes = new DevExpress.XtraGrid.GridControl();
            this.gridViewCNG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollectionCbtesFirma = new DevExpress.Utils.ImageCollection(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_tipo_doc = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btn_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridControlXml = new DevExpress.XtraGrid.GridControl();
            this.colNomArch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColNomFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTmamaño = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.txtRuta = new DevExpress.XtraEditors.ButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_generar = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager_espera = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Efirm.frmEsperar), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbtes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_doc.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNomArch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSelecTodos
            // 
            this.chkSelecTodos.AutoSize = true;
            this.chkSelecTodos.Location = new System.Drawing.Point(6, 13);
            this.chkSelecTodos.Name = "chkSelecTodos";
            this.chkSelecTodos.Size = new System.Drawing.Size(115, 17);
            this.chkSelecTodos.TabIndex = 11;
            this.chkSelecTodos.Text = "Seleccionar Todos";
            this.chkSelecTodos.UseVisualStyleBackColor = true;
            this.chkSelecTodos.CheckedChanged += new System.EventHandler(this.chkSelecTodos_CheckedChanged_1);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(325, 12);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaFin.TabIndex = 9;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(187, 12);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaInicio.TabIndex = 8;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1237, 456);
            this.splitContainer1.SplitterDistance = 758;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridControlCbtes);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(758, 417);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Registros Disponibles";
            // 
            // gridControlCbtes
            // 
            this.gridControlCbtes.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlCbtes.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlCbtes.Location = new System.Drawing.Point(3, 16);
            this.gridControlCbtes.MainView = this.gridViewCNG;
            this.gridControlCbtes.Name = "gridControlCbtes";
            this.gridControlCbtes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageComboBox4});
            this.gridControlCbtes.Size = new System.Drawing.Size(752, 398);
            this.gridControlCbtes.TabIndex = 3;
            this.gridControlCbtes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCNG});
            // 
            // gridViewCNG
            // 
            this.gridViewCNG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collChecked,
            this.collIdComprobante,
            this.gridColumn3,
            this.collTipoCbte,
            this.collObservacion});
            this.gridViewCNG.GridControl = this.gridControlCbtes;
            this.gridViewCNG.Name = "gridViewCNG";
            this.gridViewCNG.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCNG.OptionsView.ShowFooter = true;
            this.gridViewCNG.OptionsView.ShowGroupPanel = false;
            this.gridViewCNG.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewCNG_RowCellClick);
            // 
            // collChecked
            // 
            this.collChecked.Caption = "*";
            this.collChecked.FieldName = "Checked";
            this.collChecked.Name = "collChecked";
            this.collChecked.Visible = true;
            this.collChecked.VisibleIndex = 0;
            this.collChecked.Width = 33;
            // 
            // collIdComprobante
            // 
            this.collIdComprobante.Caption = "Nº comprobante";
            this.collIdComprobante.FieldName = "IdComprobante";
            this.collIdComprobante.Name = "collIdComprobante";
            this.collIdComprobante.OptionsColumn.AllowEdit = false;
            this.collIdComprobante.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.collIdComprobante.Visible = true;
            this.collIdComprobante.VisibleIndex = 1;
            this.collIdComprobante.Width = 93;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha comprobante";
            this.gridColumn3.FieldName = "Fecha";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 89;
            // 
            // collTipoCbte
            // 
            this.collTipoCbte.Caption = "Tipo Comprobante";
            this.collTipoCbte.FieldName = "TipoCbte";
            this.collTipoCbte.Name = "collTipoCbte";
            this.collTipoCbte.OptionsColumn.AllowEdit = false;
            this.collTipoCbte.Visible = true;
            this.collTipoCbte.VisibleIndex = 3;
            this.collTipoCbte.Width = 102;
            // 
            // collObservacion
            // 
            this.collObservacion.Caption = "Proveedor";
            this.collObservacion.FieldName = "Observacion";
            this.collObservacion.Name = "collObservacion";
            this.collObservacion.OptionsColumn.AllowEdit = false;
            this.collObservacion.Visible = true;
            this.collObservacion.VisibleIndex = 4;
            this.collObservacion.Width = 337;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", false, 3)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // repositoryItemImageComboBox4
            // 
            this.repositoryItemImageComboBox4.AutoHeight = false;
            this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox4.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.repositoryItemImageComboBox4.LargeImages = this.imageCollectionCbtesFirma;
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            // 
            // imageCollectionCbtesFirma
            // 
            this.imageCollectionCbtesFirma.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionCbtesFirma.ImageStream")));
            this.imageCollectionCbtesFirma.Images.SetKeyName(0, "xml_ok.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.cmb_tipo_doc);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Controls.Add(this.chkSelecTodos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 39);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(440, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Tipo Comp.";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.EditValue = "";
            this.cmb_tipo_doc.Location = new System.Drawing.Point(500, 11);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_doc.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Factura", "Factura"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Retención", "Retención"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nota crédito", "Nota crédito"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nota Débito", "Nota Débito"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Guia Remisión", "Guia Remisión")});
            this.cmb_tipo_doc.Size = new System.Drawing.Size(114, 20);
            this.cmb_tipo_doc.TabIndex = 13;
            // 
            // btn_buscar
            // 
            this.btn_buscar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_buscar.Image = global::Efirm.Properties.Resources.if_kde_folder_saved_search_25195__1_;
            this.btn_buscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(630, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(72, 23);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridControlXml);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(52, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 389);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Archivos Xml Generados";
            // 
            // gridControlXml
            // 
            this.gridControlXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlXml.Location = new System.Drawing.Point(3, 16);
            this.gridControlXml.MainView = this.colNomArch;
            this.gridControlXml.Name = "gridControlXml";
            this.gridControlXml.Size = new System.Drawing.Size(417, 370);
            this.gridControlXml.TabIndex = 2;
            this.gridControlXml.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.colNomArch,
            this.gridView3,
            this.gridView5,
            this.gridView7,
            this.gridView10,
            this.gridView1});
            // 
            // colNomArch
            // 
            this.colNomArch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColNomFile,
            this.ColRuta,
            this.ColTmamaño,
            this.ColDoc});
            this.colNomArch.GridControl = this.gridControlXml;
            this.colNomArch.Name = "colNomArch";
            this.colNomArch.OptionsView.ShowGroupPanel = false;
            // 
            // ColNomFile
            // 
            this.ColNomFile.Caption = "Nombre";
            this.ColNomFile.FieldName = "Name";
            this.ColNomFile.Name = "ColNomFile";
            this.ColNomFile.Visible = true;
            this.ColNomFile.VisibleIndex = 0;
            this.ColNomFile.Width = 237;
            // 
            // ColRuta
            // 
            this.ColRuta.Caption = "Ruta";
            this.ColRuta.FieldName = "Directory";
            this.ColRuta.Name = "ColRuta";
            this.ColRuta.Visible = true;
            this.ColRuta.VisibleIndex = 1;
            this.ColRuta.Width = 219;
            // 
            // ColTmamaño
            // 
            this.ColTmamaño.Caption = "Tamaño";
            this.ColTmamaño.FieldName = "Length";
            this.ColTmamaño.Name = "ColTmamaño";
            this.ColTmamaño.Width = 112;
            // 
            // ColDoc
            // 
            this.ColDoc.Caption = "Existe";
            this.ColDoc.FieldName = "Exists";
            this.ColDoc.Name = "ColDoc";
            this.ColDoc.Width = 114;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlXml;
            this.gridView3.Name = "gridView3";
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridControlXml;
            this.gridView5.Name = "gridView5";
            // 
            // gridView7
            // 
            this.gridView7.GridControl = this.gridControlXml;
            this.gridView7.Name = "gridView7";
            // 
            // gridView10
            // 
            this.gridView10.GridControl = this.gridControlXml;
            this.gridView10.Name = "gridView10";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlXml;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_refrescar);
            this.groupBox3.Controls.Add(this.txtRuta);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(52, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 67);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rutas para los Xml en el Servidor";
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_refrescar.Image = global::Efirm.Properties.Resources.if_Synchronize_27883;
            this.btn_refrescar.Location = new System.Drawing.Point(375, 36);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(45, 28);
            this.btn_refrescar.TabIndex = 19;
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRuta.EditValue = "";
            this.txtRuta.Location = new System.Drawing.Point(3, 16);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtRuta.Size = new System.Drawing.Size(417, 20);
            this.txtRuta.TabIndex = 17;
            this.txtRuta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtRuta_ButtonClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(52, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_generar
            // 
            this.btn_generar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_generar.Image = global::Efirm.Properties.Resources.folder_next_321;
            this.btn_generar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_generar.Location = new System.Drawing.Point(3, 196);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(44, 38);
            this.btn_generar.TabIndex = 13;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // frmCargaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 456);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCargaDatos";
            this.Text = "Generador de Xml";
            this.Load += new System.EventHandler(this.frmCargaDatos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbtes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_doc.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNomArch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSelecTodos;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gridControlXml;
        private DevExpress.XtraGrid.Views.Grid.GridView colNomArch;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomFile;
        private DevExpress.XtraGrid.Columns.GridColumn ColRuta;
        private DevExpress.XtraGrid.Columns.GridColumn ColTmamaño;
        private DevExpress.XtraGrid.Columns.GridColumn ColDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.ButtonEdit txtRuta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_refrescar;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.GridControl gridControlCbtes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCNG;
        private DevExpress.XtraGrid.Columns.GridColumn collChecked;
        private DevExpress.XtraGrid.Columns.GridColumn collIdComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn collTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn collObservacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private DevExpress.Utils.ImageCollection imageCollectionCbtesFirma;
        private DevExpress.XtraEditors.SimpleButton btn_buscar;
        private DevExpress.XtraEditors.SimpleButton btn_generar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmb_tipo_doc;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager_espera;
    }
}