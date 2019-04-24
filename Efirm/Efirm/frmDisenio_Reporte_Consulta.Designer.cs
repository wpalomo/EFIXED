namespace Efirm
{
    partial class frmDisenio_Reporte_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisenio_Reporte_Consulta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_disenio = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlTipoCbte = new DevExpress.XtraGrid.GridControl();
            this.gridViewTipoCbte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Colcod_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coldescripcion_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbemisor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoCbte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoCbte)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbemisor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_disenio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(618, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_disenio
            // 
            this.btn_disenio.Image = ((System.Drawing.Image)(resources.GetObject("btn_disenio.Image")));
            this.btn_disenio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_disenio.Name = "btn_disenio";
            this.btn_disenio.Size = new System.Drawing.Size(134, 22);
            this.btn_disenio.Text = "Personalizar Reporte";
            this.btn_disenio.Click += new System.EventHandler(this.btn_disenio_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(618, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlTipoCbte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 339);
            this.panel1.TabIndex = 2;
            // 
            // gridControlTipoCbte
            // 
            this.gridControlTipoCbte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTipoCbte.Location = new System.Drawing.Point(0, 0);
            this.gridControlTipoCbte.MainView = this.gridViewTipoCbte;
            this.gridControlTipoCbte.Name = "gridControlTipoCbte";
            this.gridControlTipoCbte.Size = new System.Drawing.Size(618, 339);
            this.gridControlTipoCbte.TabIndex = 0;
            this.gridControlTipoCbte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipoCbte});
            // 
            // gridViewTipoCbte
            // 
            this.gridViewTipoCbte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColEmpresa,
            this.Colcod_tipo,
            this.Coldescripcion_tipo});
            this.gridViewTipoCbte.GridControl = this.gridControlTipoCbte;
            this.gridViewTipoCbte.Name = "gridViewTipoCbte";
            this.gridViewTipoCbte.OptionsBehavior.Editable = false;
            this.gridViewTipoCbte.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewTipoCbte_RowClick);
            // 
            // Colcod_tipo
            // 
            this.Colcod_tipo.Caption = "Tipo Doc";
            this.Colcod_tipo.FieldName = "cod_tipo";
            this.Colcod_tipo.Name = "Colcod_tipo";
            this.Colcod_tipo.Visible = true;
            this.Colcod_tipo.VisibleIndex = 1;
            this.Colcod_tipo.Width = 151;
            // 
            // Coldescripcion_tipo
            // 
            this.Coldescripcion_tipo.Caption = "Comprobante";
            this.Coldescripcion_tipo.FieldName = "descripcion_tipo";
            this.Coldescripcion_tipo.Name = "Coldescripcion_tipo";
            this.Coldescripcion_tipo.Visible = true;
            this.Coldescripcion_tipo.VisibleIndex = 2;
            this.Coldescripcion_tipo.Width = 856;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emisor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbemisor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 33);
            this.panel2.TabIndex = 3;
            // 
            // cmbemisor
            // 
            this.cmbemisor.Location = new System.Drawing.Point(57, 6);
            this.cmbemisor.Name = "cmbemisor";
            this.cmbemisor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbemisor.Properties.DisplayMember = "RazonSocial";
            this.cmbemisor.Properties.ValueMember = "IdEmpresa";
            this.cmbemisor.Properties.View = this.searchLookUpEdit1View;
            this.cmbemisor.Size = new System.Drawing.Size(317, 20);
            this.cmbemisor.TabIndex = 2;
            this.cmbemisor.EditValueChanged += new System.EventHandler(this.cmbemisor_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColId,
            this.ColRUC,
            this.ColNombreComercial,
            this.ColRazonSocial});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColId
            // 
            this.ColId.Caption = "Id";
            this.ColId.FieldName = "IdEmpresa";
            this.ColId.Name = "ColId";
            this.ColId.Visible = true;
            this.ColId.VisibleIndex = 0;
            this.ColId.Width = 51;
            // 
            // ColRUC
            // 
            this.ColRUC.Caption = "RUC";
            this.ColRUC.FieldName = "RUC";
            this.ColRUC.Name = "ColRUC";
            this.ColRUC.Visible = true;
            this.ColRUC.VisibleIndex = 1;
            this.ColRUC.Width = 142;
            // 
            // ColNombreComercial
            // 
            this.ColNombreComercial.Caption = "Nombre Comercial";
            this.ColNombreComercial.FieldName = "NombreComercial";
            this.ColNombreComercial.Name = "ColNombreComercial";
            this.ColNombreComercial.Visible = true;
            this.ColNombreComercial.VisibleIndex = 2;
            this.ColNombreComercial.Width = 398;
            // 
            // ColRazonSocial
            // 
            this.ColRazonSocial.Caption = "Razon Social";
            this.ColRazonSocial.FieldName = "RazonSocial";
            this.ColRazonSocial.Name = "ColRazonSocial";
            this.ColRazonSocial.Visible = true;
            this.ColRazonSocial.VisibleIndex = 3;
            this.ColRazonSocial.Width = 573;
            // 
            // ColEmpresa
            // 
            this.ColEmpresa.Caption = "Emisor";
            this.ColEmpresa.FieldName = "Empresa";
            this.ColEmpresa.Name = "ColEmpresa";
            this.ColEmpresa.Visible = true;
            this.ColEmpresa.VisibleIndex = 0;
            this.ColEmpresa.Width = 157;
            // 
            // frmDisenio_Reporte_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 386);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDisenio_Reporte_Consulta";
            this.Text = "Diseño de Reporte";
            this.Load += new System.EventHandler(this.frmDisenio_Reporte_Consulta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoCbte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoCbte)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbemisor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_disenio;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlTipoCbte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoCbte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbemisor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColId;
        private DevExpress.XtraGrid.Columns.GridColumn ColRUC;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn ColRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn Colcod_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn Coldescripcion_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn ColEmpresa;
    }
}