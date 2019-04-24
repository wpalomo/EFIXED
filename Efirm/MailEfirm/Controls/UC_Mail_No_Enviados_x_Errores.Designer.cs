namespace MailEfirm.Controls
{
    partial class UC_Mail_No_Enviados_x_Errores
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelCorreo = new System.Windows.Forms.ToolStripLabel();
            this.uC_Botones_Paginas1 = new MailEfirm.Controls.UC_Botones_Paginas();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlVisor_Mail = new DevExpress.XtraGrid.GridControl();
            this.gridViewVisorMail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColImportancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ColIcono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAdjunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ColAsunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColLeido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTexto_Mensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContribuyenye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdContribuyente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcedulaRuc_contri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colIdMensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVisor_Mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVisorMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Refresh,
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripLabelCorreo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(824, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::MailEfirm.Properties.Resources.Refresh_16x16;
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(102, 22);
            this.btn_Refresh.Text = "Refresh Buzon";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel3.Text = "                           ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel1.Text = "Mail:";
            // 
            // toolStripLabelCorreo
            // 
            this.toolStripLabelCorreo.Name = "toolStripLabelCorreo";
            this.toolStripLabelCorreo.Size = new System.Drawing.Size(0, 22);
            // 
            // uC_Botones_Paginas1
            // 
            this.uC_Botones_Paginas1.Cadena_Busqueda = null;
            this.uC_Botones_Paginas1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_Botones_Paginas1.IndicePagina = 1;
            this.uC_Botones_Paginas1.Location = new System.Drawing.Point(0, 25);
            this.uC_Botones_Paginas1.Name = "uC_Botones_Paginas1";
            this.uC_Botones_Paginas1.NumeroPaginas = 0;
            this.uC_Botones_Paginas1.Size = new System.Drawing.Size(824, 27);
            this.uC_Botones_Paginas1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlVisor_Mail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 378);
            this.panel1.TabIndex = 5;
            // 
            // gridControlVisor_Mail
            // 
            this.gridControlVisor_Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlVisor_Mail.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlVisor_Mail.Location = new System.Drawing.Point(0, 0);
            this.gridControlVisor_Mail.MainView = this.gridViewVisorMail;
            this.gridControlVisor_Mail.Name = "gridControlVisor_Mail";
            this.gridControlVisor_Mail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageComboBox4});
            this.gridControlVisor_Mail.Size = new System.Drawing.Size(824, 378);
            this.gridControlVisor_Mail.TabIndex = 4;
            this.gridControlVisor_Mail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVisorMail});
            // 
            // gridViewVisorMail
            // 
            this.gridViewVisorMail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColImportancia,
            this.ColIcono,
            this.ColAdjunto,
            this.ColAsunto,
            this.ColFrom,
            this.ColLeido,
            this.colcheck,
            this.colTexto_Mensaje,
            this.colEmisor,
            this.colFecha,
            this.colContribuyenye,
            this.colIdContribuyente,
            this.colcedulaRuc_contri,
            this.ColEliminar,
            this.colIdMensaje});
            this.gridViewVisorMail.GridControl = this.gridControlVisor_Mail;
            this.gridViewVisorMail.Name = "gridViewVisorMail";
            this.gridViewVisorMail.OptionsBehavior.Editable = false;
            this.gridViewVisorMail.OptionsView.ColumnAutoWidth = false;
            this.gridViewVisorMail.OptionsView.ShowAutoFilterRow = true;
            this.gridViewVisorMail.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewVisorMail_RowCellClick_1);
            this.gridViewVisorMail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewVisorMail_FocusedRowChanged_1);
            // 
            // ColImportancia
            // 
            this.ColImportancia.Caption = ".";
            this.ColImportancia.ColumnEdit = this.repositoryItemImageComboBox2;
            this.ColImportancia.FieldName = "Prioridad";
            this.ColImportancia.ImageIndex = 0;
            this.ColImportancia.Name = "ColImportancia";
            this.ColImportancia.Visible = true;
            this.ColImportancia.VisibleIndex = 1;
            this.ColImportancia.Width = 20;
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
            // ColIcono
            // 
            this.ColIcono.ImageIndex = 1;
            this.ColIcono.Name = "ColIcono";
            this.ColIcono.OptionsColumn.ShowCaption = false;
            this.ColIcono.Width = 34;
            // 
            // ColAdjunto
            // 
            this.ColAdjunto.ColumnEdit = this.repositoryItemImageComboBox1;
            this.ColAdjunto.FieldName = "Tiene_Adjunto";
            this.ColAdjunto.ImageIndex = 2;
            this.ColAdjunto.Name = "ColAdjunto";
            this.ColAdjunto.OptionsColumn.ShowCaption = false;
            this.ColAdjunto.Visible = true;
            this.ColAdjunto.VisibleIndex = 3;
            this.ColAdjunto.Width = 20;
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
            // ColAsunto
            // 
            this.ColAsunto.Caption = "Asunto";
            this.ColAsunto.FieldName = "Asunto";
            this.ColAsunto.Name = "ColAsunto";
            this.ColAsunto.Visible = true;
            this.ColAsunto.VisibleIndex = 7;
            this.ColAsunto.Width = 119;
            // 
            // ColFrom
            // 
            this.ColFrom.Caption = "Para";
            this.ColFrom.FieldName = "Para";
            this.ColFrom.Name = "ColFrom";
            this.ColFrom.Visible = true;
            this.ColFrom.VisibleIndex = 6;
            this.ColFrom.Width = 77;
            // 
            // ColLeido
            // 
            this.ColLeido.ColumnEdit = this.repositoryItemImageComboBox3;
            this.ColLeido.FieldName = "Leido";
            this.ColLeido.ImageIndex = 3;
            this.ColLeido.Name = "ColLeido";
            this.ColLeido.OptionsColumn.ShowCaption = false;
            this.ColLeido.Visible = true;
            this.ColLeido.VisibleIndex = 2;
            this.ColLeido.Width = 20;
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
            // colcheck
            // 
            this.colcheck.Caption = "*";
            this.colcheck.FieldName = "Checked";
            this.colcheck.Name = "colcheck";
            this.colcheck.OptionsColumn.ShowCaption = false;
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 0;
            this.colcheck.Width = 20;
            // 
            // colTexto_Mensaje
            // 
            this.colTexto_Mensaje.Caption = "Mensaje";
            this.colTexto_Mensaje.FieldName = "Texto_mensaje";
            this.colTexto_Mensaje.Name = "colTexto_Mensaje";
            this.colTexto_Mensaje.Visible = true;
            this.colTexto_Mensaje.VisibleIndex = 8;
            this.colTexto_Mensaje.Width = 243;
            // 
            // colEmisor
            // 
            this.colEmisor.Caption = "Emisor";
            this.colEmisor.FieldName = "RazonSocial_Emisor";
            this.colEmisor.Name = "colEmisor";
            this.colEmisor.Visible = true;
            this.colEmisor.VisibleIndex = 5;
            this.colEmisor.Width = 65;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "sFecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 9;
            this.colFecha.Width = 163;
            // 
            // colContribuyenye
            // 
            this.colContribuyenye.Caption = "Contribuyente";
            this.colContribuyenye.FieldName = "InfoContribuyente.Nom_Contribuyente";
            this.colContribuyenye.Name = "colContribuyenye";
            this.colContribuyenye.Visible = true;
            this.colContribuyenye.VisibleIndex = 10;
            this.colContribuyenye.Width = 61;
            // 
            // colIdContribuyente
            // 
            this.colIdContribuyente.Caption = "IdContribuyente";
            this.colIdContribuyente.FieldName = "InfoContribuyente.IdContribuyente";
            this.colIdContribuyente.Name = "colIdContribuyente";
            // 
            // colcedulaRuc_contri
            // 
            this.colcedulaRuc_contri.Caption = "cedulaRuc_contri";
            this.colcedulaRuc_contri.FieldName = "InfoContribuyente.cedulaRuc_contri";
            this.colcedulaRuc_contri.Name = "colcedulaRuc_contri";
            this.colcedulaRuc_contri.Visible = true;
            this.colcedulaRuc_contri.VisibleIndex = 11;
            this.colcedulaRuc_contri.Width = 69;
            // 
            // ColEliminar
            // 
            this.ColEliminar.Caption = "x";
            this.ColEliminar.ColumnEdit = this.repositoryItemImageComboBox4;
            this.ColEliminar.FieldName = "Mostrar_col_Eliminar";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.OptionsColumn.AllowEdit = false;
            this.ColEliminar.Visible = true;
            this.ColEliminar.VisibleIndex = 4;
            this.ColEliminar.Width = 26;
            // 
            // repositoryItemImageComboBox4
            // 
            this.repositoryItemImageComboBox4.AutoHeight = false;
            this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox4.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 7)});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            // 
            // colIdMensaje
            // 
            this.colIdMensaje.Caption = "IdMensaje";
            this.colIdMensaje.FieldName = "IdMensaje";
            this.colIdMensaje.Name = "colIdMensaje";
            // 
            // UC_Mail_No_Enviados_x_Errores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uC_Botones_Paginas1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_Mail_No_Enviados_x_Errores";
            this.Size = new System.Drawing.Size(824, 430);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVisor_Mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVisorMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCorreo;
        private UC_Botones_Paginas uC_Botones_Paginas1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlVisor_Mail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVisorMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColImportancia;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIcono;
        private DevExpress.XtraGrid.Columns.GridColumn ColAdjunto;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn ColAsunto;
        private DevExpress.XtraGrid.Columns.GridColumn ColFrom;
        private DevExpress.XtraGrid.Columns.GridColumn ColLeido;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private DevExpress.XtraGrid.Columns.GridColumn colTexto_Mensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colEmisor;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colContribuyenye;
        private DevExpress.XtraGrid.Columns.GridColumn colIdContribuyente;
        private DevExpress.XtraGrid.Columns.GridColumn colcedulaRuc_contri;
        private DevExpress.XtraGrid.Columns.GridColumn ColEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMensaje;
    }
}
