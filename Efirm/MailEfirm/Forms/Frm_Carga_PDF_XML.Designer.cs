namespace MailEfirm.Forms
{
    partial class Frm_Carga_PDF_XML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Carga_PDF_XML));
            this.gridControl_PDF_XML = new DevExpress.XtraGrid.GridControl();
            this.gridView_PDF_XML = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_archi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colextensionArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMosTrar_icono_Imprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImagen_Imprimir = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection_PDF_XML = new DevExpress.Utils.ImageCollection();
            this.colMosTrar_icono_Descargar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImagen_Descargar = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCheked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDescargar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PDF_XML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PDF_XML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_PDF_XML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Descargar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_PDF_XML
            // 
            this.gridControl_PDF_XML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_PDF_XML.Location = new System.Drawing.Point(0, 0);
            this.gridControl_PDF_XML.MainView = this.gridView_PDF_XML;
            this.gridControl_PDF_XML.Name = "gridControl_PDF_XML";
            this.gridControl_PDF_XML.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbImagen_Imprimir,
            this.cmbImagen_Descargar});
            this.gridControl_PDF_XML.Size = new System.Drawing.Size(654, 259);
            this.gridControl_PDF_XML.TabIndex = 0;
            this.gridControl_PDF_XML.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PDF_XML});
            // 
            // gridView_PDF_XML
            // 
            this.gridView_PDF_XML.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMensaje,
            this.coldescripcion_archi,
            this.colextensionArchivo,
            this.colMosTrar_icono_Imprimir,
            this.colMosTrar_icono_Descargar,
            this.colCheked});
            this.gridView_PDF_XML.GridControl = this.gridControl_PDF_XML;
            this.gridView_PDF_XML.Name = "gridView_PDF_XML";
            this.gridView_PDF_XML.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_PDF_XML_RowCellClick);
            // 
            // colIdMensaje
            // 
            this.colIdMensaje.Caption = "IdMensaje";
            this.colIdMensaje.FieldName = "IdMensaje";
            this.colIdMensaje.Name = "colIdMensaje";
            // 
            // coldescripcion_archi
            // 
            this.coldescripcion_archi.Caption = "Archivo";
            this.coldescripcion_archi.FieldName = "descripcion_archi";
            this.coldescripcion_archi.Name = "coldescripcion_archi";
            this.coldescripcion_archi.OptionsColumn.AllowEdit = false;
            this.coldescripcion_archi.Visible = true;
            this.coldescripcion_archi.VisibleIndex = 1;
            this.coldescripcion_archi.Width = 1068;
            // 
            // colextensionArchivo
            // 
            this.colextensionArchivo.Caption = "Extensión";
            this.colextensionArchivo.FieldName = "extensionArchivo";
            this.colextensionArchivo.Name = "colextensionArchivo";
            this.colextensionArchivo.OptionsColumn.AllowEdit = false;
            this.colextensionArchivo.Width = 165;
            // 
            // colMosTrar_icono_Imprimir
            // 
            this.colMosTrar_icono_Imprimir.Caption = "Imprimir";
            this.colMosTrar_icono_Imprimir.ColumnEdit = this.cmbImagen_Imprimir;
            this.colMosTrar_icono_Imprimir.FieldName = "MosTrar_icono_Imprimir";
            this.colMosTrar_icono_Imprimir.Name = "colMosTrar_icono_Imprimir";
            this.colMosTrar_icono_Imprimir.OptionsColumn.AllowEdit = false;
            this.colMosTrar_icono_Imprimir.OptionsColumn.AllowSize = false;
            this.colMosTrar_icono_Imprimir.Visible = true;
            this.colMosTrar_icono_Imprimir.VisibleIndex = 2;
            this.colMosTrar_icono_Imprimir.Width = 29;
            // 
            // cmbImagen_Imprimir
            // 
            this.cmbImagen_Imprimir.AutoHeight = false;
            this.cmbImagen_Imprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_Imprimir.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmbImagen_Imprimir.LargeImages = this.imageCollection_PDF_XML;
            this.cmbImagen_Imprimir.Name = "cmbImagen_Imprimir";
            // 
            // imageCollection_PDF_XML
            // 
            this.imageCollection_PDF_XML.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection_PDF_XML.ImageStream")));
            this.imageCollection_PDF_XML.Images.SetKeyName(0, "Imprimir_64x64.png");
            this.imageCollection_PDF_XML.Images.SetKeyName(1, "folder_downloads.png");
            // 
            // colMosTrar_icono_Descargar
            // 
            this.colMosTrar_icono_Descargar.Caption = "Descargar";
            this.colMosTrar_icono_Descargar.ColumnEdit = this.cmbImagen_Descargar;
            this.colMosTrar_icono_Descargar.FieldName = "MosTrar_icono_Descargar";
            this.colMosTrar_icono_Descargar.Name = "colMosTrar_icono_Descargar";
            this.colMosTrar_icono_Descargar.OptionsColumn.AllowEdit = false;
            this.colMosTrar_icono_Descargar.OptionsColumn.AllowSize = false;
            this.colMosTrar_icono_Descargar.Visible = true;
            this.colMosTrar_icono_Descargar.VisibleIndex = 3;
            this.colMosTrar_icono_Descargar.Width = 45;
            // 
            // cmbImagen_Descargar
            // 
            this.cmbImagen_Descargar.AutoHeight = false;
            this.cmbImagen_Descargar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_Descargar.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 1)});
            this.cmbImagen_Descargar.LargeImages = this.imageCollection_PDF_XML;
            this.cmbImagen_Descargar.Name = "cmbImagen_Descargar";
            // 
            // colCheked
            // 
            this.colCheked.FieldName = "Checked";
            this.colCheked.Name = "colCheked";
            this.colCheked.OptionsColumn.AllowEdit = false;
            this.colCheked.OptionsColumn.AllowSize = false;
            this.colCheked.Visible = true;
            this.colCheked.VisibleIndex = 0;
            this.colCheked.Width = 22;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(654, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDescargar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(654, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.Image")));
            this.btnDescargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(79, 22);
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.checkTodos);
            this.panel1.Controls.Add(this.gridControl_PDF_XML);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 259);
            this.panel1.TabIndex = 3;
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.Location = new System.Drawing.Point(12, 13);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(56, 17);
            this.checkTodos.TabIndex = 1;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // Frm_Carga_PDF_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 306);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Frm_Carga_PDF_XML";
            this.Text = "Carga_PDF_XML";
            this.Load += new System.EventHandler(this.Frm_Carga_PDF_XML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PDF_XML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PDF_XML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_PDF_XML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Descargar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_PDF_XML;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_PDF_XML;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.Utils.ImageCollection imageCollection_PDF_XML;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMensaje;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_archi;
        private DevExpress.XtraGrid.Columns.GridColumn colextensionArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn colMosTrar_icono_Imprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_Imprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colMosTrar_icono_Descargar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_Descargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnDescargar;
        private DevExpress.XtraGrid.Columns.GridColumn colCheked;
        private System.Windows.Forms.CheckBox checkTodos;
    }
}