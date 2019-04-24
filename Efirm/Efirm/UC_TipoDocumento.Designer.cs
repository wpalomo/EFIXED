namespace Efirm
{
    partial class UC_TipoDocumento
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
            this.cmb_tipo_documento = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdComprobante_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_documento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipo_documento
            // 
            this.cmb_tipo_documento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_tipo_documento.Location = new System.Drawing.Point(0, 0);
            this.cmb_tipo_documento.Name = "cmb_tipo_documento";
            this.cmb_tipo_documento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_documento.Properties.DisplayMember = "descripcion_tipo";
            this.cmb_tipo_documento.Properties.ValueMember = "IdComprobante_tipo";
            this.cmb_tipo_documento.Properties.View = this.searchLookUpEdit1View;
            this.cmb_tipo_documento.Size = new System.Drawing.Size(424, 20);
            this.cmb_tipo_documento.TabIndex = 0;
            this.cmb_tipo_documento.EditValueChanged += new System.EventHandler(this.cmb_tipo_documento_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdComprobante_tipo,
            this.colcod_tipo,
            this.coldescripcion_tipo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdComprobante_tipo
            // 
            this.colIdComprobante_tipo.Caption = "IdComprobante_tipo";
            this.colIdComprobante_tipo.FieldName = "IdComprobante_tipo";
            this.colIdComprobante_tipo.Name = "colIdComprobante_tipo";
            this.colIdComprobante_tipo.Visible = true;
            this.colIdComprobante_tipo.VisibleIndex = 0;
            this.colIdComprobante_tipo.Width = 116;
            // 
            // colcod_tipo
            // 
            this.colcod_tipo.Caption = "cod_tipo";
            this.colcod_tipo.FieldName = "cod_tipo";
            this.colcod_tipo.Name = "colcod_tipo";
            this.colcod_tipo.Visible = true;
            this.colcod_tipo.VisibleIndex = 2;
            this.colcod_tipo.Width = 132;
            // 
            // coldescripcion_tipo
            // 
            this.coldescripcion_tipo.Caption = "descripcion";
            this.coldescripcion_tipo.FieldName = "descripcion_tipo";
            this.coldescripcion_tipo.Name = "coldescripcion_tipo";
            this.coldescripcion_tipo.Visible = true;
            this.coldescripcion_tipo.VisibleIndex = 1;
            this.coldescripcion_tipo.Width = 932;
            // 
            // UC_TipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_tipo_documento);
            this.Name = "UC_TipoDocumento";
            this.Size = new System.Drawing.Size(424, 23);
            this.Load += new System.EventHandler(this.UC_TipoDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_documento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_tipo_documento;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComprobante_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_tipo;
    }
}
