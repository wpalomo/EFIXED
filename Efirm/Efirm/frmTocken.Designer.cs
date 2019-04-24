namespace Efirm
{
    partial class frmTocken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTocken));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.gridControlTocken = new DevExpress.XtraGrid.GridControl();
            this.gridViewTocken = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTocken = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_tocken = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colIdTockenAUX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTocken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTocken)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGrabar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 22);
            this.btnNuevo.Text = "Nuevo Registro";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::Efirm.Properties.Resources._1400809061_126734;
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
            // gridControlTocken
            // 
            this.gridControlTocken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTocken.Location = new System.Drawing.Point(0, 0);
            this.gridControlTocken.MainView = this.gridViewTocken;
            this.gridControlTocken.Name = "gridControlTocken";
            this.gridControlTocken.Size = new System.Drawing.Size(736, 260);
            this.gridControlTocken.TabIndex = 2;
            this.gridControlTocken.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTocken});
           
            // 
            // gridViewTocken
            // 
            this.gridViewTocken.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTocken,
            this.colnom_tocken,
            this.colPassword,
            this.colSerie,
            this.colModelo,
            this.colIdTipo,
            this.colEstado,
            this.colIdTockenAUX});
            this.gridViewTocken.GridControl = this.gridControlTocken;
            this.gridViewTocken.Name = "gridViewTocken";
            this.gridViewTocken.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTocken.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewTocken_RowCellStyle);
            this.gridViewTocken.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewTocken_CellValueChanged);
            this.gridViewTocken.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewTocken_KeyDown);
            // 
            // colIdTocken
            // 
            this.colIdTocken.Caption = "IdTocken";
            this.colIdTocken.FieldName = "IdTocken";
            this.colIdTocken.Name = "colIdTocken";
            this.colIdTocken.Visible = true;
            this.colIdTocken.VisibleIndex = 0;
            // 
            // colnom_tocken
            // 
            this.colnom_tocken.Caption = "Nombre";
            this.colnom_tocken.FieldName = "nom_tocken";
            this.colnom_tocken.Name = "colnom_tocken";
            this.colnom_tocken.Visible = true;
            this.colnom_tocken.VisibleIndex = 1;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Password";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "Serie";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 3;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 4;
            // 
            // colIdTipo
            // 
            this.colIdTipo.Caption = "IdTipo";
            this.colIdTipo.FieldName = "IdTipo";
            this.colIdTipo.Name = "colIdTipo";
            this.colIdTipo.Visible = true;
            this.colIdTipo.VisibleIndex = 5;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlTocken);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 260);
            this.panel1.TabIndex = 3;
            // 
            // colIdTockenAUX
            // 
            this.colIdTockenAUX.FieldName = "IdTockenAUX";
            this.colIdTockenAUX.Name = "colIdTockenAUX";
            // 
            // frmTocken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmTocken";
            this.Text = "Tocken";
            this.Load += new System.EventHandler(this.frmTocken_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTocken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTocken)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl gridControlTocken;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTocken;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTocken;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_tocken;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTockenAUX;
    }
}