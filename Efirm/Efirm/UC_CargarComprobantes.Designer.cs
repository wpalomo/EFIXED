namespace Efirm
{
    partial class UC_CargarComprobantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CargarComprobantes));
            this.panelMain = new System.Windows.Forms.Panel();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageFileValidos = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dtpFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.dtpFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.txtRuta = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSelecTodos = new System.Windows.Forms.CheckBox();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_refresh_listado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_firmar = new System.Windows.Forms.ToolStripButton();
            this.xtraTabPageHorario = new DevExpress.XtraTab.XtraTabPage();
            this.uC_Horario_Actividades = new Efirm.UC_Horario_Actividades();
            this.timerFirmarXML = new System.Windows.Forms.Timer(this.components);
            this.timerRefrescar = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageFileValidos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbtes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).BeginInit();
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
            // 
            // xtraTabPageFileValidos
            // 
            this.xtraTabPageFileValidos.Controls.Add(this.groupBox1);
            this.xtraTabPageFileValidos.Name = "xtraTabPageFileValidos";
            this.xtraTabPageFileValidos.Size = new System.Drawing.Size(1018, 477);
            this.xtraTabPageFileValidos.Text = "Comprobantes pendientes de enviar al SRI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainerControl1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 477);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 41);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.dtpFechaInicio);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtpFechaFin);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtRuta);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3);
            this.splitContainerControl1.Panel1.Controls.Add(this.chkSelecTodos);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.splitContainerControl1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1012, 433);
            this.splitContainerControl1.SplitterPosition = 32;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.EditValue = null;
            this.dtpFechaInicio.Location = new System.Drawing.Point(171, 4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaInicio.TabIndex = 25;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.EditValue = null;
            this.dtpFechaFin.Location = new System.Drawing.Point(318, 4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaFin.TabIndex = 24;
            // 
            // txtRuta
            // 
            this.txtRuta.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtRuta.EditValue = "";
            this.txtRuta.Location = new System.Drawing.Point(438, 0);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtRuta.Size = new System.Drawing.Size(574, 20);
            this.txtRuta.TabIndex = 23;
            this.txtRuta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtRuta_ButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hasta";
            // 
            // chkSelecTodos
            // 
            this.chkSelecTodos.AutoSize = true;
            this.chkSelecTodos.Location = new System.Drawing.Point(3, 7);
            this.chkSelecTodos.Name = "chkSelecTodos";
            this.chkSelecTodos.Size = new System.Drawing.Size(115, 17);
            this.chkSelecTodos.TabIndex = 19;
            this.chkSelecTodos.Text = "Seleccionar Todos";
            this.chkSelecTodos.UseVisualStyleBackColor = true;
            this.chkSelecTodos.CheckedChanged += new System.EventHandler(this.chkSelecTodos_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridControlCbtes);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1012, 396);
            this.groupBox5.TabIndex = 2;
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
            this.gridControlCbtes.Size = new System.Drawing.Size(1006, 377);
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
            this.collObservacion.Caption = "Bwnwficiario";
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
            this.imageCollectionCbtesFirma.Images.SetKeyName(0, "xml_firmado_32x32.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(1, "imprimir_32x32.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(2, "1417488454_pdf.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(3, "application-xml.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(4, "anular2_32.x32png.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btn_refresh_listado,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.btn_firmar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1012, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_refresh_listado
            // 
            this.btn_refresh_listado.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh_listado.Image")));
            this.btn_refresh_listado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh_listado.Name = "btn_refresh_listado";
            this.btn_refresh_listado.Size = new System.Drawing.Size(62, 22);
            this.btn_refresh_listado.Text = "Buscar";
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
            // btn_firmar
            // 
            this.btn_firmar.Image = ((System.Drawing.Image)(resources.GetObject("btn_firmar.Image")));
            this.btn_firmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_firmar.Name = "btn_firmar";
            this.btn_firmar.Size = new System.Drawing.Size(68, 22);
            this.btn_firmar.Text = "Generar";
            this.btn_firmar.Click += new System.EventHandler(this.btn_firmar_Click);
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
            // UC_CargarComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "UC_CargarComprobantes";
            this.Size = new System.Drawing.Size(1024, 505);
            this.Load += new System.EventHandler(this.UC_Comprobante_Valido_Firmado_efirm_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageFileValidos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbtes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.xtraTabPageHorario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_firmar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_refresh_listado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFileValidos;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHorario;
        private UC_Horario_Actividades uC_Horario_Actividades;
        private System.Windows.Forms.Timer timerFirmarXML;
        private System.Windows.Forms.Timer timerRefrescar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private DevExpress.Utils.ImageCollection imageCollectionCbtesFirma;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSelecTodos;
        private System.Windows.Forms.GroupBox groupBox5;
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
        private DevExpress.XtraEditors.ButtonEdit txtRuta;
        private DevExpress.XtraEditors.DateEdit dtpFechaInicio;
        private DevExpress.XtraEditors.DateEdit dtpFechaFin;
    }
}
