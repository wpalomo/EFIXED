namespace Efirms
{
    partial class ucge_menu_superior_cons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_nuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_modificar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_consultar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_anular = new DevExpress.XtraBars.BarButtonItem();
            this.btn_salir = new DevExpress.XtraBars.BarButtonItem();
            this.btn_imprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bei_fecha_ini = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.bei_fecha_fin = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btn_buscar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grupo_general = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grupo_filtros = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grupo_imprimir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grupo_salir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_nuevo,
            this.btn_modificar,
            this.btn_consultar,
            this.btn_anular,
            this.btn_salir,
            this.btn_imprimir,
            this.bei_fecha_ini,
            this.bei_fecha_fin,
            this.btn_buscar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1020, 96);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Caption = "Nuevo";
            this.btn_nuevo.Glyph = global::Efirm.Properties.Resources.if_plus_1646001;
            this.btn_nuevo.Id = 1;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nuevo_ItemClick);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Caption = "Modificar";
            this.btn_modificar.Glyph = global::Efirm.Properties.Resources.if_system_software_update_28709;
            this.btn_modificar.Id = 2;
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_modificar_ItemClick);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Caption = "Consultar";
            this.btn_consultar.Glyph = global::Efirm.Properties.Resources._24___Eye_128;
            this.btn_consultar.Id = 3;
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_consultar_ItemClick);
            // 
            // btn_anular
            // 
            this.btn_anular.Caption = "Anular";
            this.btn_anular.Glyph = global::Efirm.Properties.Resources.if_Artboard_1_1790656;
            this.btn_anular.Id = 4;
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_anular_ItemClick);
            // 
            // btn_salir
            // 
            this.btn_salir.Caption = "Salir";
            this.btn_salir.Glyph = global::Efirm.Properties.Resources.if_Document_file_export_sending_exit_send_1886950;
            this.btn_salir.Id = 5;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_salir_ItemClick);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Caption = "Imprimir";
            this.btn_imprimir.Glyph = global::Efirm.Properties.Resources.if_fax_318578__1_;
            this.btn_imprimir.Id = 6;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_imprimir_ItemClick);
            // 
            // bei_fecha_ini
            // 
            this.bei_fecha_ini.Caption = "Desde   ";
            this.bei_fecha_ini.Edit = this.repositoryItemDateEdit1;
            this.bei_fecha_ini.Id = 7;
            this.bei_fecha_ini.Name = "bei_fecha_ini";
            this.bei_fecha_ini.Width = 100;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // bei_fecha_fin
            // 
            this.bei_fecha_fin.Caption = "Hasta    ";
            this.bei_fecha_fin.Edit = this.repositoryItemDateEdit2;
            this.bei_fecha_fin.Id = 8;
            this.bei_fecha_fin.Name = "bei_fecha_fin";
            this.bei_fecha_fin.Width = 100;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // btn_buscar
            // 
            this.btn_buscar.Caption = "Buscar";
            this.btn_buscar.Glyph = global::Efirm.Properties.Resources.if_icon_74_document_search_315198;
            this.btn_buscar.Id = 9;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_buscar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grupo_general,
            this.grupo_filtros,
            this.grupo_imprimir,
            this.grupo_salir});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // grupo_general
            // 
            this.grupo_general.ItemLinks.Add(this.btn_nuevo);
            this.grupo_general.ItemLinks.Add(this.btn_modificar);
            this.grupo_general.ItemLinks.Add(this.btn_consultar);
            this.grupo_general.ItemLinks.Add(this.btn_anular);
            this.grupo_general.Name = "grupo_general";
            // 
            // grupo_filtros
            // 
            this.grupo_filtros.ItemLinks.Add(this.bei_fecha_ini);
            this.grupo_filtros.ItemLinks.Add(this.bei_fecha_fin);
            this.grupo_filtros.ItemLinks.Add(this.btn_buscar);
            this.grupo_filtros.Name = "grupo_filtros";
            // 
            // grupo_imprimir
            // 
            this.grupo_imprimir.ItemLinks.Add(this.btn_imprimir);
            this.grupo_imprimir.Name = "grupo_imprimir";
            // 
            // grupo_salir
            // 
            this.grupo_salir.ItemLinks.Add(this.btn_salir);
            this.grupo_salir.Name = "grupo_salir";
            // 
            // ucge_menu_superior_cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucge_menu_superior_cons";
            this.Size = new System.Drawing.Size(1020, 84);
            this.Load += new System.EventHandler(this.ucge_menu_superior_cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grupo_general;
        private DevExpress.XtraBars.BarButtonItem btn_nuevo;
        private DevExpress.XtraBars.BarButtonItem btn_modificar;
        private DevExpress.XtraBars.BarButtonItem btn_consultar;
        private DevExpress.XtraBars.BarButtonItem btn_anular;
        private DevExpress.XtraBars.BarButtonItem btn_salir;
        private DevExpress.XtraBars.BarButtonItem btn_imprimir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grupo_filtros;
        public DevExpress.XtraBars.BarEditItem bei_fecha_ini;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        public DevExpress.XtraBars.BarEditItem bei_fecha_fin;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grupo_salir;
        private DevExpress.XtraBars.BarButtonItem btn_buscar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grupo_imprimir;
    }
}
