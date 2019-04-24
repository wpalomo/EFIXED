namespace Efirm
{
    partial class frmImportarClavesContin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportarClavesContin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.txtUrl = new DevExpress.XtraEditors.ButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbClaveContingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Trans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveContingencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Importacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAmbiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_ambiente = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Efirm.frmEsperar), true, true);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClaveContingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGrabar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(62, 22);
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(126, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtUrl.Size = new System.Drawing.Size(313, 20);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtUrl_ButtonClick);
            this.txtUrl.EditValueChanged += new System.EventHandler(this.txtUrl_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbClaveContingInfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(811, 361);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbClaveContingInfoBindingSource
            // 
            this.tbClaveContingInfoBindingSource.DataSource = typeof(FirmElect.Info.tb_Clave_Conting_Info);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdClave,
            this.colUsado,
            this.colFecha_Trans,
            this.colClaveContingencia,
            this.colFecha_Importacion,
            this.colEstado,
            this.colIdAmbiente});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 7;
            this.colIdEmpresa.Width = 69;
            // 
            // colIdClave
            // 
            this.colIdClave.FieldName = "IdClave";
            this.colIdClave.Name = "colIdClave";
            this.colIdClave.Visible = true;
            this.colIdClave.VisibleIndex = 0;
            this.colIdClave.Width = 79;
            // 
            // colUsado
            // 
            this.colUsado.FieldName = "Usado";
            this.colUsado.Name = "colUsado";
            this.colUsado.Visible = true;
            this.colUsado.VisibleIndex = 4;
            this.colUsado.Width = 186;
            // 
            // colFecha_Trans
            // 
            this.colFecha_Trans.FieldName = "Fecha_Trans";
            this.colFecha_Trans.Name = "colFecha_Trans";
            this.colFecha_Trans.Visible = true;
            this.colFecha_Trans.VisibleIndex = 1;
            this.colFecha_Trans.Width = 186;
            // 
            // colClaveContingencia
            // 
            this.colClaveContingencia.FieldName = "ClaveContingencia";
            this.colClaveContingencia.Name = "colClaveContingencia";
            this.colClaveContingencia.Visible = true;
            this.colClaveContingencia.VisibleIndex = 2;
            this.colClaveContingencia.Width = 186;
            // 
            // colFecha_Importacion
            // 
            this.colFecha_Importacion.FieldName = "Fecha_Importacion";
            this.colFecha_Importacion.Name = "colFecha_Importacion";
            this.colFecha_Importacion.Visible = true;
            this.colFecha_Importacion.VisibleIndex = 3;
            this.colFecha_Importacion.Width = 186;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            this.colEstado.Width = 214;
            // 
            // colIdAmbiente
            // 
            this.colIdAmbiente.Caption = "IdAmbiente";
            this.colIdAmbiente.FieldName = "IdAmbiente";
            this.colIdAmbiente.Name = "colIdAmbiente";
            this.colIdAmbiente.Visible = true;
            this.colIdAmbiente.VisibleIndex = 6;
            this.colIdAmbiente.Width = 74;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmb_ambiente});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(817, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 22);
            this.toolStripLabel1.Text = "Ambiente:";
            // 
            // cmb_ambiente
            // 
            this.cmb_ambiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ambiente.Items.AddRange(new object[] {
            "PRUEBAS",
            "PRODUCCION"});
            this.cmb_ambiente.Name = "cmb_ambiente";
            this.cmb_ambiente.Size = new System.Drawing.Size(121, 25);
            this.cmb_ambiente.SelectedIndexChanged += new System.EventHandler(this.cmb_ambiente_SelectedIndexChanged);
            this.cmb_ambiente.Click += new System.EventHandler(this.cmb_ambiente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 380);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // frmImportarClavesContin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmImportarClavesContin";
            this.Text = "frmImportarClavesContin";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClaveContingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.ButtonEdit txtUrl;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tbClaveContingInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClave;
        private DevExpress.XtraGrid.Columns.GridColumn colUsado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Trans;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveContingencia;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Importacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmb_ambiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAmbiente;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}