
namespace Efirm
{
    partial class frmseg_menu_cons
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
            this.ucge_menu_superior_cons1 = new Efirms.ucge_menu_superior_cons();
            this.treeListMenu = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ucge_menu_superior_cons1
            // 
            this.ucge_menu_superior_cons1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucge_menu_superior_cons1.Location = new System.Drawing.Point(0, 0);
            this.ucge_menu_superior_cons1.Name = "ucge_menu_superior_cons1";
            this.ucge_menu_superior_cons1.Size = new System.Drawing.Size(995, 103);
            this.ucge_menu_superior_cons1.TabIndex = 0;
            this.ucge_menu_superior_cons1.Visible_grupo_filtros = false;
            this.ucge_menu_superior_cons1.Visible_grupo_imprimir = true;
            this.ucge_menu_superior_cons1.event_delegate_btn_nuevo_ItemClick += new Efirms.ucge_menu_superior_cons.delegate_btn_nuevo_ItemClick(this.ucge_menu_superior_cons1_event_delegate_btn_nuevo_ItemClick);
            this.ucge_menu_superior_cons1.event_delegate_btn_modificar_ItemClick += new Efirms.ucge_menu_superior_cons.delegate_btn_modificar_ItemClick(this.ucge_menu_superior_cons1_event_delegate_btn_modificar_ItemClick);
            this.ucge_menu_superior_cons1.event_delegate_btn_consultar_ItemClick += new Efirms.ucge_menu_superior_cons.delegate_btn_consultar_ItemClick(this.ucge_menu_superior_cons1_event_delegate_btn_consultar_ItemClick);
            this.ucge_menu_superior_cons1.event_delegate_btn_anular_ItemClick += new Efirms.ucge_menu_superior_cons.delegate_btn_anular_ItemClick(this.ucge_menu_superior_cons1_event_delegate_btn_anular_ItemClick);
            this.ucge_menu_superior_cons1.event_delegate_btn_imprimir_ItemClick += new Efirms.ucge_menu_superior_cons.delegate_btn_imprimir_ItemClick(this.ucge_menu_superior_cons1_event_delegate_btn_imprimir_ItemClick);
            this.ucge_menu_superior_cons1.event_delegate_btn_salir_ItemClick += new Efirms.ucge_menu_superior_cons.delegate_btn_salir_ItemClick(this.ucge_menu_superior_cons1_event_delegate_btn_salir_ItemClick);
            // 
            // treeListMenu
            // 
            this.treeListMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7});
            this.treeListMenu.CustomizationFormBounds = new System.Drawing.Rectangle(1693, 733, 218, 212);
            this.treeListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenu.KeyFieldName = "IdMenu";
            this.treeListMenu.Location = new System.Drawing.Point(0, 103);
            this.treeListMenu.Name = "treeListMenu";
            this.treeListMenu.OptionsBehavior.Editable = false;
            this.treeListMenu.OptionsBehavior.EnableFiltering = true;
            this.treeListMenu.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListMenu.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListMenu.OptionsPrint.UsePrintStyles = true;
            this.treeListMenu.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenu.ParentFieldName = "IdMenu_padre";
            this.treeListMenu.Size = new System.Drawing.Size(995, 493);
            this.treeListMenu.TabIndex = 1;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "ID";
            this.treeListColumn1.FieldName = "IdMenu";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 4;
            this.treeListColumn1.Width = 81;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Descripción";
            this.treeListColumn2.FieldName = "me_nombre";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 297;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "treeListColumn3";
            this.treeListColumn3.FieldName = "IdMenu_padre";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Assembly";
            this.treeListColumn4.FieldName = "me_nom_assembly";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 1;
            this.treeListColumn4.Width = 137;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Formulario";
            this.treeListColumn5.FieldName = "me_nom_formulario";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 2;
            this.treeListColumn5.Width = 177;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Estado";
            this.treeListColumn6.FieldName = "me_estado";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 3;
            this.treeListColumn6.Width = 80;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "treeListColumn7";
            this.treeListColumn7.FieldName = "me_nivel";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.SortOrder = System.Windows.Forms.SortOrder.Descending;
            // 
            // frmseg_menu_cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 596);
            this.Controls.Add(this.treeListMenu);
            this.Controls.Add(this.ucge_menu_superior_cons1);
            this.Name = "frmseg_menu_cons";
            this.Text = "frmseg_menu_cons";
            this.Load += new System.EventHandler(this.frmseg_menu_cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Efirms.ucge_menu_superior_cons ucge_menu_superior_cons1;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
    }
}