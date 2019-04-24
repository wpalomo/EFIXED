namespace Efirm
{
    partial class frmseg_usuario_mant
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chk_seleccionar_visibles = new DevExpress.XtraEditors.CheckEdit();
            this.lbl_anulado = new DevExpress.XtraEditors.LabelControl();
            this.txt_nombre = new DevExpress.XtraEditors.TextEdit();
            this.txt_contrasenia = new DevExpress.XtraEditors.TextEdit();
            this.txt_usuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_empresas = new DevExpress.XtraGrid.GridControl();
            this.gridView_empresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_seleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menu = new Efirms.ucge_menu_superior_mant();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_seleccionar_visibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contrasenia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_empresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chk_seleccionar_visibles);
            this.panelControl1.Controls.Add(this.lbl_anulado);
            this.panelControl1.Controls.Add(this.txt_nombre);
            this.panelControl1.Controls.Add(this.txt_contrasenia);
            this.panelControl1.Controls.Add(this.txt_usuario);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(910, 162);
            this.panelControl1.TabIndex = 0;
            // 
            // chk_seleccionar_visibles
            // 
            this.chk_seleccionar_visibles.Location = new System.Drawing.Point(50, 133);
            this.chk_seleccionar_visibles.Name = "chk_seleccionar_visibles";
            this.chk_seleccionar_visibles.Properties.Caption = "Seleccionar visibles";
            this.chk_seleccionar_visibles.Size = new System.Drawing.Size(275, 21);
            this.chk_seleccionar_visibles.TabIndex = 7;
            this.chk_seleccionar_visibles.CheckedChanged += new System.EventHandler(this.chk_seleccionar_visibles_CheckedChanged);
            // 
            // lbl_anulado
            // 
            this.lbl_anulado.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_anulado.Location = new System.Drawing.Point(278, 8);
            this.lbl_anulado.Name = "lbl_anulado";
            this.lbl_anulado.Size = new System.Drawing.Size(133, 33);
            this.lbl_anulado.TabIndex = 6;
            this.lbl_anulado.Text = "ANULADO";
            this.lbl_anulado.Visible = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(164, 103);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(374, 22);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.Location = new System.Drawing.Point(164, 75);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(374, 22);
            this.txt_contrasenia.TabIndex = 4;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(164, 47);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(374, 22);
            this.txt_usuario.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(48, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nombre *";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Contraseña *";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuario *";
            // 
            // gridControl_empresas
            // 
            this.gridControl_empresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_empresas.Location = new System.Drawing.Point(0, 192);
            this.gridControl_empresas.MainView = this.gridView_empresas;
            this.gridControl_empresas.Name = "gridControl_empresas";
            this.gridControl_empresas.Size = new System.Drawing.Size(910, 290);
            this.gridControl_empresas.TabIndex = 1;
            this.gridControl_empresas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_empresas});
            // 
            // gridView_empresas
            // 
            this.gridView_empresas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_seleccionado,
            this.gridColumn2});
            this.gridView_empresas.GridControl = this.gridControl_empresas;
            this.gridView_empresas.Name = "gridView_empresas";
            this.gridView_empresas.OptionsView.ShowGroupPanel = false;
            // 
            // col_seleccionado
            // 
            this.col_seleccionado.Caption = "*";
            this.col_seleccionado.FieldName = "seleccionado";
            this.col_seleccionado.Name = "col_seleccionado";
            this.col_seleccionado.Visible = true;
            this.col_seleccionado.VisibleIndex = 0;
            this.col_seleccionado.Width = 89;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Empresa";
            this.gridColumn2.FieldName = "em_razon_social";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1645;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(910, 30);
            this.menu.TabIndex = 2;
            this.menu.event_delegate_btn_salir_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_salir_ItemClick(this.menu_event_delegate_btn_salir_ItemClick);
            this.menu.event_delegate_btn_anular_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_anular_ItemClick(this.menu_event_delegate_btn_anular_ItemClick);
            this.menu.event_delegate_btn_limpiar_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_limpiar_ItemClick(this.menu_event_delegate_btn_limpiar_ItemClick);
            this.menu.event_delegate_btn_guardar_salir_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_guardar_salir_ItemClick(this.menu_event_delegate_btn_guardar_salir_ItemClick);
            this.menu.event_delegate_btn_guardar_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_guardar_ItemClick(this.menu_event_delegate_btn_guardar_ItemClick);
            // 
            // frmseg_usuario_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 482);
            this.Controls.Add(this.gridControl_empresas);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.menu);
            this.Name = "frmseg_usuario_mant";
            this.Text = "Mantenimiento de usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmseg_usuario_mant_FormClosed);
            this.Load += new System.EventHandler(this.frmseg_usuario_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_seleccionar_visibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contrasenia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_empresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_empresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl_empresas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_empresas;
        private Efirms.ucge_menu_superior_mant menu;
        private DevExpress.XtraEditors.TextEdit txt_nombre;
        private DevExpress.XtraEditors.TextEdit txt_contrasenia;
        private DevExpress.XtraEditors.TextEdit txt_usuario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_anulado;
        private DevExpress.XtraEditors.CheckEdit chk_seleccionar_visibles;
        private DevExpress.XtraGrid.Columns.GridColumn col_seleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}