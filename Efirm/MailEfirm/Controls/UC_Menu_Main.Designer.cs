namespace MailEfirm.Controls
{
    partial class UC_Menu_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Menu_Main));
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanelMail = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupBuzonEnt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.xtraScrollableControlMail = new DevExpress.XtraEditors.XtraScrollableControl();
            this.uC_Menu_cuentas_mail = new MailEfirm.Controls.UC_Menu_cuentas_mail();
            this.navBarGroupCuentas = new DevExpress.XtraNavBar.NavBarGroup();
            this.btn_contactos = new DevExpress.XtraNavBar.NavBarItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btn_elementos_eliminados = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_elementos_enviados = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_buzon_salida = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_buzon_entrada = new DevExpress.XtraNavBar.NavBarItem();
            this.timerContadorEnvioRecepcion = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerEnvio_y_Recep = new System.ComponentModel.BackgroundWorker();
            this.timerSensorHiloEnviar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanelMail.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            this.xtraScrollableControlMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 471);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = null;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1148, 20);
            this.ribbonStatusBar1.Click += new System.EventHandler(this.ribbonStatusBar1_Click);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2});
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelMail});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel2.ID = new System.Guid("e0f15055-eb5a-4490-8e5a-41c4faa8161e");
            this.dockPanel2.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.SavedIndex = 1;
            this.dockPanel2.Size = new System.Drawing.Size(200, 200);
            this.dockPanel2.Text = "dockPanel2";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 22);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(194, 175);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanelMail
            // 
            this.dockPanelMail.Controls.Add(this.dockPanel1_Container);
            this.dockPanelMail.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelMail.ID = new System.Guid("7089fec2-52d5-4dd6-84fc-cfff063ed6ba");
            this.dockPanelMail.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMail.Name = "dockPanelMail";
            this.dockPanelMail.OriginalSize = new System.Drawing.Size(291, 200);
            this.dockPanelMail.Size = new System.Drawing.Size(291, 471);
            this.dockPanelMail.Text = "Mail";
            this.dockPanelMail.Click += new System.EventHandler(this.dockPanelMail_Click);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(283, 444);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroupBuzonEnt;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupCuentas});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btn_contactos});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 283;
            this.navBarControl1.Size = new System.Drawing.Size(283, 444);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroupBuzonEnt
            // 
            this.navBarGroupBuzonEnt.Caption = "Buzon";
            this.navBarGroupBuzonEnt.Expanded = true;
            this.navBarGroupBuzonEnt.Name = "navBarGroupBuzonEnt";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.xtraScrollableControlMail);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(275, 251);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // xtraScrollableControlMail
            // 
            this.xtraScrollableControlMail.Controls.Add(this.uC_Menu_cuentas_mail);
            this.xtraScrollableControlMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlMail.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControlMail.Name = "xtraScrollableControlMail";
            this.xtraScrollableControlMail.Size = new System.Drawing.Size(275, 251);
            this.xtraScrollableControlMail.TabIndex = 0;
            // 
            // uC_Menu_cuentas_mail
            // 
            this.uC_Menu_cuentas_mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Menu_cuentas_mail.Location = new System.Drawing.Point(0, 0);
            this.uC_Menu_cuentas_mail.Name = "uC_Menu_cuentas_mail";
            this.uC_Menu_cuentas_mail.Size = new System.Drawing.Size(275, 251);
            this.uC_Menu_cuentas_mail.TabIndex = 0;
            this.uC_Menu_cuentas_mail.event_treeListMenuMail_AfterFocusNode += new MailEfirm.Controls.UC_Menu_cuentas_mail.delegate_treeListMenuMail_AfterFocusNode(this.uC_Menu_cuentas_mail_event_treeListMenuMail_AfterFocusNode);
            this.uC_Menu_cuentas_mail.Load += new System.EventHandler(this.uC_Menu_cuentas_mail_Load);
            // 
            // navBarGroupCuentas
            // 
            this.navBarGroupCuentas.Caption = "Cuentas de Correo";
            this.navBarGroupCuentas.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroupCuentas.Expanded = true;
            this.navBarGroupCuentas.GroupClientHeight = 258;
            this.navBarGroupCuentas.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroupCuentas.Name = "navBarGroupCuentas";
            // 
            // btn_contactos
            // 
            this.btn_contactos.Caption = "Contacto";
            this.btn_contactos.LargeImage = global::MailEfirm.Properties.Resources.Contact_32x32;
            this.btn_contactos.Name = "btn_contactos";
            this.btn_contactos.SmallImage = global::MailEfirm.Properties.Resources.Contact_32x32;
            this.btn_contactos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(291, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(857, 471);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_elementos_eliminados
            // 
            this.btn_elementos_eliminados.Caption = "Elementos Eliminados";
            this.btn_elementos_eliminados.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_elementos_eliminados.LargeImage")));
            this.btn_elementos_eliminados.Name = "btn_elementos_eliminados";
            this.btn_elementos_eliminados.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_elementos_eliminados.SmallImage")));
            // 
            // btn_elementos_enviados
            // 
            this.btn_elementos_enviados.Caption = "Elementos enviados";
            this.btn_elementos_enviados.Name = "btn_elementos_enviados";
            this.btn_elementos_enviados.SmallImage = global::MailEfirm.Properties.Resources.sendE;
            this.btn_elementos_enviados.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSendItem_LinkClicked);
            // 
            // btn_buzon_salida
            // 
            this.btn_buzon_salida.Caption = "Buzon de Salida";
            this.btn_buzon_salida.LargeImage = global::MailEfirm.Properties.Resources.Sen1;
            this.btn_buzon_salida.Name = "btn_buzon_salida";
            this.btn_buzon_salida.SmallImage = global::MailEfirm.Properties.Resources.Mail_32x32;
            // 
            // btn_buzon_entrada
            // 
            this.btn_buzon_entrada.Caption = "Buzon de Entrada";
            this.btn_buzon_entrada.Name = "btn_buzon_entrada";
            this.btn_buzon_entrada.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_buzon_entrada.SmallImage")));
            // 
            // timerContadorEnvioRecepcion
            // 
            this.timerContadorEnvioRecepcion.Enabled = true;
            this.timerContadorEnvioRecepcion.Interval = 1000;
            this.timerContadorEnvioRecepcion.Tick += new System.EventHandler(this.timerContadorEnvioRecepcion_Tick);
            // 
            // backgroundWorkerEnvio_y_Recep
            // 
            this.backgroundWorkerEnvio_y_Recep.WorkerReportsProgress = true;
            this.backgroundWorkerEnvio_y_Recep.WorkerSupportsCancellation = true;
            this.backgroundWorkerEnvio_y_Recep.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerEnvio_y_Recep_DoWork);
            this.backgroundWorkerEnvio_y_Recep.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerEnvio_y_Recep_ProgressChanged);
            this.backgroundWorkerEnvio_y_Recep.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerEnvio_y_Recep_RunWorkerCompleted);
            // 
            // timerSensorHiloEnviar
            // 
            this.timerSensorHiloEnviar.Tick += new System.EventHandler(this.timerSensorHiloEnviar_Tick);
            // 
            // UC_Menu_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.dockPanelMail);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Name = "UC_Menu_Main";
            this.Size = new System.Drawing.Size(1148, 491);
            this.Load += new System.EventHandler(this.UC_Menu_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanelMail.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.xtraScrollableControlMail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelMail;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraNavBar.NavBarItem btn_contactos;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupCuentas;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlMail;
        private UC_Menu_cuentas_mail uC_Menu_cuentas_mail;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupBuzonEnt;
        private DevExpress.XtraNavBar.NavBarItem btn_elementos_eliminados;
        private DevExpress.XtraNavBar.NavBarItem btn_elementos_enviados;
        private DevExpress.XtraNavBar.NavBarItem btn_buzon_salida;
        private DevExpress.XtraNavBar.NavBarItem btn_buzon_entrada;
        private System.Windows.Forms.Timer timerContadorEnvioRecepcion;
        private System.ComponentModel.BackgroundWorker backgroundWorkerEnvio_y_Recep;
        private System.Windows.Forms.Timer timerSensorHiloEnviar;
    }
}
