namespace Efirm
{
    partial class frmseg_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmseg_main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_mostrar_menu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_formularios = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.btn_temas = new DevExpress.XtraBars.BarLinkContainerItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucseg_menu_x_empresa_x_usuario1 = new Efirms.ucseg_menu_x_empresa_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = global::Efirm.Properties.Resources.fx_ico;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_mostrar_menu,
            this.btn_formularios,
            this.btn_temas});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1166, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_mostrar_menu
            // 
            this.btn_mostrar_menu.Caption = "Menú";
            this.btn_mostrar_menu.Id = 1;
            this.btn_mostrar_menu.LargeGlyph = global::Efirm.Properties.Resources.menu_128x128;
            this.btn_mostrar_menu.Name = "btn_mostrar_menu";
            // 
            // btn_formularios
            // 
            this.btn_formularios.Caption = "Formularios";
            this.btn_formularios.Id = 5;
            this.btn_formularios.LargeGlyph = global::Efirm.Properties.Resources.Formularios_128x128;
            this.btn_formularios.Name = "btn_formularios";
            // 
            // btn_temas
            // 
            this.btn_temas.Caption = "Temas";
            this.btn_temas.Id = 6;
            this.btn_temas.LargeGlyph = global::Efirm.Properties.Resources.temas_128x128;
            this.btn_temas.Name = "btn_temas";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_mostrar_menu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_formularios);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_temas);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1166, 31);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("04ef1c5e-9763-4182-9562-d638efbe4405");
            this.dockPanel1.Location = new System.Drawing.Point(0, 144);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(259, 200);
            this.dockPanel1.Size = new System.Drawing.Size(259, 424);
            this.dockPanel1.Text = "Menú";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ucseg_menu_x_empresa_x_usuario1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(251, 397);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ucseg_menu_x_empresa_x_usuario1
            // 
            this.ucseg_menu_x_empresa_x_usuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucseg_menu_x_empresa_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucseg_menu_x_empresa_x_usuario1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucseg_menu_x_empresa_x_usuario1.Name = "ucseg_menu_x_empresa_x_usuario1";
            this.ucseg_menu_x_empresa_x_usuario1.Size = new System.Drawing.Size(251, 397);
            this.ucseg_menu_x_empresa_x_usuario1.TabIndex = 0;
            this.ucseg_menu_x_empresa_x_usuario1.event_delegate_treeList_menu_KeyUp += new Efirms.ucseg_menu_x_empresa_x_usuario.delegate_treeList_menu_KeyUp(this.ucseg_menu_x_empresa_x_usuario1_event_delegate_treeList_menu_KeyUp);
            this.ucseg_menu_x_empresa_x_usuario1.event_delegate_treeList_menu_MouseDown += new Efirms.ucseg_menu_x_empresa_x_usuario.delegate_treeList_menu_MouseDown(this.ucseg_menu_x_empresa_x_usuario1_event_delegate_treeList_menu_MouseDown);
            this.ucseg_menu_x_empresa_x_usuario1.event_delegate_treeList_menu_NodeCellStyle += new Efirms.ucseg_menu_x_empresa_x_usuario.delegate_treeList_menu_NodeCellStyle(this.ucseg_menu_x_empresa_x_usuario1_event_delegate_treeList_menu_NodeCellStyle);
            this.ucseg_menu_x_empresa_x_usuario1.event_delegate_treeList_menu_SelectImageClick += new Efirms.ucseg_menu_x_empresa_x_usuario.delegate_treeList_menu_SelectImageClick(this.ucseg_menu_x_empresa_x_usuario1_event_delegate_treeList_menu_SelectImageClick);
            this.ucseg_menu_x_empresa_x_usuario1.event_delegate_btn_refrescar_ItemClick += new Efirms.ucseg_menu_x_empresa_x_usuario.delegate_btn_refrescar_ItemClick(this.ucseg_menu_x_empresa_x_usuario1_event_delegate_btn_refrescar_ItemClick);
            // 
            // frmseg_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 599);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmseg_main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmseg_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarButtonItem btn_mostrar_menu;
        private DevExpress.XtraBars.BarMdiChildrenListItem btn_formularios;
        private DevExpress.XtraBars.BarLinkContainerItem btn_temas;
        private Efirms.ucseg_menu_x_empresa_x_usuario ucseg_menu_x_empresa_x_usuario1;
    }
}