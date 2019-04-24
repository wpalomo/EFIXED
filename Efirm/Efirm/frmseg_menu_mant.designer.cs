using FirmElect.Bus;
using FirmElect.Info;


namespace Efirm
{
    partial class frmseg_menu_mant
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_IdMenu = new DevExpress.XtraEditors.TextEdit();
            this.txt_nombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_nom_formulario = new DevExpress.XtraEditors.TextEdit();
            this.lbl_nom_formulario = new DevExpress.XtraEditors.LabelControl();
            this.txt_nom_assembly = new DevExpress.XtraEditors.TextEdit();
            this.lbl_nom_assembly = new DevExpress.XtraEditors.LabelControl();
            this.chk_tiene_formulario = new DevExpress.XtraEditors.CheckEdit();
            this.txt_nivel = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_anulado = new DevExpress.XtraEditors.LabelControl();
            this.treeListMenu = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.chk_tiene_padre = new DevExpress.XtraEditors.CheckEdit();
            this.menu = new Efirms.ucge_menu_superior_mant();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nom_formulario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nom_assembly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_tiene_formulario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nivel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_tiene_padre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // txt_IdMenu
            // 
            this.txt_IdMenu.Location = new System.Drawing.Point(182, 83);
            this.txt_IdMenu.Name = "txt_IdMenu";
            this.txt_IdMenu.Properties.ReadOnly = true;
            this.txt_IdMenu.Size = new System.Drawing.Size(222, 22);
            this.txt_IdMenu.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(182, 111);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(222, 22);
            this.txt_nombre.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nombre *";
            // 
            // txt_nom_formulario
            // 
            this.txt_nom_formulario.Location = new System.Drawing.Point(182, 221);
            this.txt_nom_formulario.Name = "txt_nom_formulario";
            this.txt_nom_formulario.Size = new System.Drawing.Size(222, 22);
            this.txt_nom_formulario.TabIndex = 5;
            this.txt_nom_formulario.Visible = false;
            // 
            // lbl_nom_formulario
            // 
            this.lbl_nom_formulario.Location = new System.Drawing.Point(24, 224);
            this.lbl_nom_formulario.Name = "lbl_nom_formulario";
            this.lbl_nom_formulario.Size = new System.Drawing.Size(108, 16);
            this.lbl_nom_formulario.TabIndex = 4;
            this.lbl_nom_formulario.Text = "Nombre formulario";
            this.lbl_nom_formulario.Visible = false;
            // 
            // txt_nom_assembly
            // 
            this.txt_nom_assembly.Location = new System.Drawing.Point(182, 249);
            this.txt_nom_assembly.Name = "txt_nom_assembly";
            this.txt_nom_assembly.Size = new System.Drawing.Size(222, 22);
            this.txt_nom_assembly.TabIndex = 7;
            this.txt_nom_assembly.Visible = false;
            // 
            // lbl_nom_assembly
            // 
            this.lbl_nom_assembly.Location = new System.Drawing.Point(24, 252);
            this.lbl_nom_assembly.Name = "lbl_nom_assembly";
            this.lbl_nom_assembly.Size = new System.Drawing.Size(102, 16);
            this.lbl_nom_assembly.TabIndex = 6;
            this.lbl_nom_assembly.Text = "Nombre assembly";
            this.lbl_nom_assembly.Visible = false;
            // 
            // chk_tiene_formulario
            // 
            this.chk_tiene_formulario.Location = new System.Drawing.Point(22, 194);
            this.chk_tiene_formulario.Name = "chk_tiene_formulario";
            this.chk_tiene_formulario.Properties.Caption = "Tiene formulario asociado";
            this.chk_tiene_formulario.Size = new System.Drawing.Size(213, 21);
            this.chk_tiene_formulario.TabIndex = 8;
            this.chk_tiene_formulario.CheckedChanged += new System.EventHandler(this.chk_tiene_formulario_CheckedChanged);
            // 
            // txt_nivel
            // 
            this.txt_nivel.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_nivel.Location = new System.Drawing.Point(182, 139);
            this.txt_nivel.Name = "txt_nivel";
            this.txt_nivel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_nivel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_nivel.Size = new System.Drawing.Size(100, 22);
            this.txt_nivel.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 142);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Nivel *";
            // 
            // lbl_anulado
            // 
            this.lbl_anulado.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_anulado.Location = new System.Drawing.Point(234, 41);
            this.lbl_anulado.Name = "lbl_anulado";
            this.lbl_anulado.Size = new System.Drawing.Size(133, 33);
            this.lbl_anulado.TabIndex = 11;
            this.lbl_anulado.Text = "ANULADO";
            this.lbl_anulado.Visible = false;
            // 
            // treeListMenu
            // 
            this.treeListMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeListMenu.KeyFieldName = "IdMenu";
            this.treeListMenu.Location = new System.Drawing.Point(421, 30);
            this.treeListMenu.Name = "treeListMenu";
            this.treeListMenu.OptionsBehavior.Editable = false;
            this.treeListMenu.OptionsBehavior.EnableFiltering = true;
            this.treeListMenu.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListMenu.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListMenu.OptionsPrint.UsePrintStyles = true;
            this.treeListMenu.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenu.OptionsView.ShowCheckBoxes = true;
            this.treeListMenu.ParentFieldName = "IdMenu_padre";
            this.treeListMenu.Size = new System.Drawing.Size(340, 556);
            this.treeListMenu.TabIndex = 12;
            this.treeListMenu.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeListMenu_BeforeCheckNode);
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Descripción";
            this.treeListColumn2.FieldName = "me_nombre";
            this.treeListColumn2.MinWidth = 32;
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
            // chk_tiene_padre
            // 
            this.chk_tiene_padre.EditValue = true;
            this.chk_tiene_padre.Location = new System.Drawing.Point(22, 167);
            this.chk_tiene_padre.Name = "chk_tiene_padre";
            this.chk_tiene_padre.Properties.Caption = "Tiene padre";
            this.chk_tiene_padre.Size = new System.Drawing.Size(213, 21);
            this.chk_tiene_padre.TabIndex = 13;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(761, 30);
            this.menu.TabIndex = 14;
            this.menu.event_delegate_btn_salir_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_salir_ItemClick(this.menu_event_delegate_btn_salir_ItemClick);
            this.menu.event_delegate_btn_anular_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_anular_ItemClick(this.menu_event_delegate_btn_anular_ItemClick);
            this.menu.event_delegate_btn_limpiar_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_limpiar_ItemClick(this.menu_event_delegate_btn_limpiar_ItemClick);
            this.menu.event_delegate_btn_guardar_salir_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_guardar_salir_ItemClick(this.menu_event_delegate_btn_guardar_salir_ItemClick);
            this.menu.event_delegate_btn_guardar_ItemClick += new Efirms.ucge_menu_superior_mant.delegate_btn_guardar_ItemClick(this.menu_event_delegate_btn_guardar_ItemClick);
            // 
            // frmseg_menu_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 586);
            this.Controls.Add(this.chk_tiene_padre);
            this.Controls.Add(this.treeListMenu);
            this.Controls.Add(this.lbl_anulado);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_nivel);
            this.Controls.Add(this.chk_tiene_formulario);
            this.Controls.Add(this.txt_nom_assembly);
            this.Controls.Add(this.lbl_nom_assembly);
            this.Controls.Add(this.txt_nom_formulario);
            this.Controls.Add(this.lbl_nom_formulario);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_IdMenu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.menu);
            this.Name = "frmseg_menu_mant";
            this.Text = "frmseg_menu_mant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmseg_menu_mant_FormClosed);
            this.Load += new System.EventHandler(this.frmseg_menu_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nom_formulario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nom_assembly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_tiene_formulario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nivel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_tiene_padre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_IdMenu;
        private DevExpress.XtraEditors.TextEdit txt_nombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_nom_formulario;
        private DevExpress.XtraEditors.LabelControl lbl_nom_formulario;
        private DevExpress.XtraEditors.TextEdit txt_nom_assembly;
        private DevExpress.XtraEditors.LabelControl lbl_nom_assembly;
        private DevExpress.XtraEditors.CheckEdit chk_tiene_formulario;
        private DevExpress.XtraEditors.SpinEdit txt_nivel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbl_anulado;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.CheckEdit chk_tiene_padre;
        private Efirms.ucge_menu_superior_mant menu;
    }
}