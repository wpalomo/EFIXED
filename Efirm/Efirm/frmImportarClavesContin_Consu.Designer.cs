namespace Efirm
{
    partial class frmImportarClavesContin_Consu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportarClavesContin_Consu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNueva = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlClaveCont = new DevExpress.XtraGrid.GridControl();
            this.gridViewClaveCont = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Trans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveContingencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Importacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClaveCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClaveCont)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNueva,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNueva
            // 
            this.btnNueva.Image = global::Efirm.Properties.Resources._1400809061_126734;
            this.btnNueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(189, 22);
            this.btnNueva.Text = "Nueva Importacion de Archivo";
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel1.Text = "                  ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.panel1.Controls.Add(this.gridControlClaveCont);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 237);
            this.panel1.TabIndex = 1;
            // 
            // gridControlClaveCont
            // 
            this.gridControlClaveCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClaveCont.Location = new System.Drawing.Point(0, 0);
            this.gridControlClaveCont.MainView = this.gridViewClaveCont;
            this.gridControlClaveCont.Name = "gridControlClaveCont";
            this.gridControlClaveCont.Size = new System.Drawing.Size(669, 237);
            this.gridControlClaveCont.TabIndex = 0;
            this.gridControlClaveCont.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClaveCont});
            this.gridControlClaveCont.Click += new System.EventHandler(this.gridControlClaveCont_Click);
            // 
            // gridViewClaveCont
            // 
            this.gridViewClaveCont.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdClave,
            this.colUsado,
            this.colFecha_Trans,
            this.colClaveContingencia,
            this.colFecha_Importacion,
            this.colEstado,
            this.colIdAmbiente,
            this.colnomAmbiente,
            this.colRazonSocial});
            this.gridViewClaveCont.GridControl = this.gridControlClaveCont;
            this.gridViewClaveCont.Name = "gridViewClaveCont";
            this.gridViewClaveCont.OptionsBehavior.Editable = false;
            this.gridViewClaveCont.OptionsView.ShowAutoFilterRow = true;
            this.gridViewClaveCont.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewClaveCont_RowClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "Id Empresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 114;
            // 
            // colIdClave
            // 
            this.colIdClave.Caption = "Id Clave";
            this.colIdClave.FieldName = "IdClave";
            this.colIdClave.Name = "colIdClave";
            this.colIdClave.Visible = true;
            this.colIdClave.VisibleIndex = 2;
            this.colIdClave.Width = 61;
            // 
            // colUsado
            // 
            this.colUsado.Caption = "Usado";
            this.colUsado.FieldName = "Usado";
            this.colUsado.Name = "colUsado";
            this.colUsado.Visible = true;
            this.colUsado.VisibleIndex = 3;
            this.colUsado.Width = 83;
            // 
            // colFecha_Trans
            // 
            this.colFecha_Trans.Caption = "Fecha Trans";
            this.colFecha_Trans.FieldName = "Fecha_Trans";
            this.colFecha_Trans.Name = "colFecha_Trans";
            this.colFecha_Trans.Visible = true;
            this.colFecha_Trans.VisibleIndex = 4;
            this.colFecha_Trans.Width = 137;
            // 
            // colClaveContingencia
            // 
            this.colClaveContingencia.Caption = "Clave Contingencia";
            this.colClaveContingencia.FieldName = "ClaveContingencia";
            this.colClaveContingencia.Name = "colClaveContingencia";
            this.colClaveContingencia.Visible = true;
            this.colClaveContingencia.VisibleIndex = 5;
            this.colClaveContingencia.Width = 203;
            // 
            // colFecha_Importacion
            // 
            this.colFecha_Importacion.Caption = "Fecha Importacion";
            this.colFecha_Importacion.FieldName = "Fecha_Importacion";
            this.colFecha_Importacion.Name = "colFecha_Importacion";
            this.colFecha_Importacion.Visible = true;
            this.colFecha_Importacion.VisibleIndex = 6;
            this.colFecha_Importacion.Width = 194;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 128;
            // 
            // colIdAmbiente
            // 
            this.colIdAmbiente.Caption = "Id Ambiente";
            this.colIdAmbiente.FieldName = "IdAmbiente";
            this.colIdAmbiente.Name = "colIdAmbiente";
            this.colIdAmbiente.Width = 142;
            // 
            // colnomAmbiente
            // 
            this.colnomAmbiente.Caption = "Ambiente";
            this.colnomAmbiente.FieldName = "nomAmbiente";
            this.colnomAmbiente.Name = "colnomAmbiente";
            this.colnomAmbiente.Visible = true;
            this.colnomAmbiente.VisibleIndex = 0;
            this.colnomAmbiente.Width = 76;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Empresa";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 1;
            this.colRazonSocial.Width = 162;
            // 
            // frmImportarClavesContin_Consu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmImportarClavesContin_Consu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Importar Claves de Contingencia";
            this.Load += new System.EventHandler(this.frmImportarClavesContin_Consu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClaveCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClaveCont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlClaveCont;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClaveCont;
        private System.Windows.Forms.ToolStripButton btnNueva;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClave;
        private DevExpress.XtraGrid.Columns.GridColumn colUsado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Trans;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveContingencia;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Importacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAmbiente;
        private DevExpress.XtraGrid.Columns.GridColumn colnomAmbiente;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
    }
}