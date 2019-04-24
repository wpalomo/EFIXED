namespace Core.Erp.Winform.seguridad_acceso
{
    partial class frmseg_usuario_cons
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
            this.menu = new Core.Erp.Winform.controles.ucge_menu_superior_cons();
            this.gridControl_usuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView_usuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1088, 103);
            this.menu.TabIndex = 0;
            this.menu.Visible_grupo_filtros = false;
            this.menu.Visible_grupo_imprimir = true;
            this.menu.event_delegate_btn_nuevo_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_cons.delegate_btn_nuevo_ItemClick(this.menu_event_delegate_btn_nuevo_ItemClick);
            this.menu.event_delegate_btn_modificar_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_cons.delegate_btn_modificar_ItemClick(this.menu_event_delegate_btn_modificar_ItemClick);
            this.menu.event_delegate_btn_consultar_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_cons.delegate_btn_consultar_ItemClick(this.menu_event_delegate_btn_consultar_ItemClick);
            this.menu.event_delegate_btn_anular_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_cons.delegate_btn_anular_ItemClick(this.menu_event_delegate_btn_anular_ItemClick);
            this.menu.event_delegate_btn_imprimir_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_cons.delegate_btn_imprimir_ItemClick(this.menu_event_delegate_btn_imprimir_ItemClick);
            this.menu.event_delegate_btn_salir_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_cons.delegate_btn_salir_ItemClick(this.menu_event_delegate_btn_salir_ItemClick);
            // 
            // gridControl_usuarios
            // 
            this.gridControl_usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_usuarios.Location = new System.Drawing.Point(0, 103);
            this.gridControl_usuarios.MainView = this.gridView_usuarios;
            this.gridControl_usuarios.Name = "gridControl_usuarios";
            this.gridControl_usuarios.Size = new System.Drawing.Size(1088, 442);
            this.gridControl_usuarios.TabIndex = 1;
            this.gridControl_usuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_usuarios});
            // 
            // gridView_usuarios
            // 
            this.gridView_usuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView_usuarios.GridControl = this.gridControl_usuarios;
            this.gridView_usuarios.Name = "gridView_usuarios";
            this.gridView_usuarios.OptionsBehavior.ReadOnly = true;
            this.gridView_usuarios.OptionsView.ShowAutoFilterRow = true;
            this.gridView_usuarios.OptionsView.ShowGroupPanel = false;
            this.gridView_usuarios.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView_usuarios_RowStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Usuario";
            this.gridColumn1.FieldName = "IdUsuario";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 300;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "us_nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 679;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Estado";
            this.gridColumn3.FieldName = "estado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 91;
            // 
            // frmseg_usuario_cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 545);
            this.Controls.Add(this.gridControl_usuarios);
            this.Controls.Add(this.menu);
            this.Name = "frmseg_usuario_cons";
            this.Text = "Consulta usuarios";
            this.Load += new System.EventHandler(this.frmseg_usuario_cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private controles.ucge_menu_superior_cons menu;
        private DevExpress.XtraGrid.GridControl gridControl_usuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_usuarios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}