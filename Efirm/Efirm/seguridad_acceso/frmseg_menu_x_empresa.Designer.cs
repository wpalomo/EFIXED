
namespace Efirm
{
    partial class frmseg_menu_x_empresa
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
            this.ucge_menu_superior_mant1 = new Core.Erp.Winform.controles.ucge_menu_superior_mant();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_empresa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeListMenu = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ucge_menu_superior_mant1
            // 
            this.ucge_menu_superior_mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucge_menu_superior_mant1.Location = new System.Drawing.Point(0, 0);
            this.ucge_menu_superior_mant1.Name = "ucge_menu_superior_mant1";
            this.ucge_menu_superior_mant1.Size = new System.Drawing.Size(905, 30);
            this.ucge_menu_superior_mant1.TabIndex = 0;
            this.ucge_menu_superior_mant1.event_delegate_btn_salir_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_mant.delegate_btn_salir_ItemClick(this.ucge_menu_superior_mant1_event_delegate_btn_salir_ItemClick);
            this.ucge_menu_superior_mant1.event_delegate_btn_limpiar_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_mant.delegate_btn_limpiar_ItemClick(this.ucge_menu_superior_mant1_event_delegate_btn_limpiar_ItemClick);
            this.ucge_menu_superior_mant1.event_delegate_btn_guardar_salir_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_mant.delegate_btn_guardar_salir_ItemClick(this.ucge_menu_superior_mant1_event_delegate_btn_guardar_salir_ItemClick);
            this.ucge_menu_superior_mant1.event_delegate_btn_guardar_ItemClick += new Core.Erp.Winform.controles.ucge_menu_superior_mant.delegate_btn_guardar_ItemClick(this.ucge_menu_superior_mant1_event_delegate_btn_guardar_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cmb_empresa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(905, 58);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Empresa";
            // 
            // cmb_empresa
            // 
            this.cmb_empresa.Location = new System.Drawing.Point(101, 18);
            this.cmb_empresa.Name = "cmb_empresa";
            this.cmb_empresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_empresa.Properties.DisplayMember = "em_razon_social";
            this.cmb_empresa.Properties.NullText = "-- Seleccione un registro --";
            this.cmb_empresa.Properties.ValueMember = "IdEmpresa";
            this.cmb_empresa.Properties.View = this.searchLookUpEdit1View;
            this.cmb_empresa.Size = new System.Drawing.Size(401, 22);
            this.cmb_empresa.TabIndex = 0;
            this.cmb_empresa.EditValueChanged += new System.EventHandler(this.cmb_empresa_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 198;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Empresa";
            this.gridColumn2.FieldName = "em_razon_social";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 1536;
            // 
            // treeListMenu
            // 
            this.treeListMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn1});
            this.treeListMenu.CustomizationFormBounds = new System.Drawing.Rectangle(1693, 733, 218, 212);
            this.treeListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenu.KeyFieldName = "IdMenu";
            this.treeListMenu.Location = new System.Drawing.Point(0, 88);
            this.treeListMenu.Name = "treeListMenu";
            this.treeListMenu.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeListMenu.OptionsBehavior.Editable = false;
            this.treeListMenu.OptionsBehavior.EnableFiltering = true;
            this.treeListMenu.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListMenu.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListMenu.OptionsPrint.UsePrintStyles = true;
            this.treeListMenu.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenu.OptionsView.ShowCheckBoxes = true;
            this.treeListMenu.ParentFieldName = "info_menu.IdMenu_padre";
            this.treeListMenu.Size = new System.Drawing.Size(905, 511);
            this.treeListMenu.TabIndex = 13;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Descripción";
            this.treeListColumn2.FieldName = "info_menu.me_nombre";
            this.treeListColumn2.MinWidth = 32;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 297;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "treeListColumn3";
            this.treeListColumn3.FieldName = "info_menu.IdMenu_padre";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "info_menu.me_nivel";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            // 
            // frmseg_menu_x_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 599);
            this.Controls.Add(this.treeListMenu);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucge_menu_superior_mant1);
            this.Name = "frmseg_menu_x_empresa";
            this.Text = "frmseg_menu_x_empresa";
            this.Load += new System.EventHandler(this.frmseg_menu_x_empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private controles.ucge_menu_superior_mant ucge_menu_superior_mant1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_empresa;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}