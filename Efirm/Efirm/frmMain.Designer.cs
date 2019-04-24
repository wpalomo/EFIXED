namespace Efirm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnConfDirectorios = new DevExpress.XtraBars.BarButtonItem();
            this.btnParametros = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmisor = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdministradorCbtes = new DevExpress.XtraBars.BarButtonItem();
            this.btn_token = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cbtes_Auto_noAuto = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ImportarClaveConting = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Mail = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Procesos_En_Lotes = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCbteRe = new DevExpress.XtraBars.BarButtonItem();
            this.btnCbtes_para_exportacion = new DevExpress.XtraBars.BarButtonItem();
            this.barConsultaReporte = new DevExpress.XtraBars.BarButtonItem();
            this.barMsjValidez = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPageEfirm = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupConfiguraciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupTransacciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupReportes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupMail = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnClaves_Contingencia = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManagerMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.lblNomEjecucion = new DevExpress.XtraEditors.LabelControl();
            this.xafBarManager1 = new DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.timerValidarFecha = new System.Windows.Forms.Timer(this.components);
            this.notMsjValidezCerti = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnConfDirectorios,
            this.btnParametros,
            this.btnEmisor,
            this.btnAdministradorCbtes,
            this.btn_token,
            this.btn_Cbtes_Auto_noAuto,
            this.btn_ImportarClaveConting,
            this.btn_Mail,
            this.btn_Procesos_En_Lotes,
            this.barbtnCbteRe,
            this.btnCbtes_para_exportacion,
            this.barConsultaReporte,
            this.barMsjValidez});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 26;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageEfirm});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.ribbon.Size = new System.Drawing.Size(1219, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnConfDirectorios
            // 
            this.btnConfDirectorios.Caption = "Directorios";
            this.btnConfDirectorios.Glyph = global::Efirm.Properties.Resources.Directory;
            this.btnConfDirectorios.Id = 3;
            this.btnConfDirectorios.LargeGlyph = global::Efirm.Properties.Resources.Directory;
            this.btnConfDirectorios.Name = "btnConfDirectorios";
            this.btnConfDirectorios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConfDirectorios_ItemClick);
            // 
            // btnParametros
            // 
            this.btnParametros.Caption = "Paramentros";
            this.btnParametros.Glyph = ((System.Drawing.Image)(resources.GetObject("btnParametros.Glyph")));
            this.btnParametros.Id = 6;
            this.btnParametros.LargeGlyph = global::Efirm.Properties.Resources._1415237036_mypc_config;
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnParametros_ItemClick);
            // 
            // btnEmisor
            // 
            this.btnEmisor.Caption = "Emisor";
            this.btnEmisor.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEmisor.Glyph")));
            this.btnEmisor.Id = 7;
            this.btnEmisor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEmisor.LargeGlyph")));
            this.btnEmisor.Name = "btnEmisor";
            this.btnEmisor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmisor_ItemClick);
            // 
            // btnAdministradorCbtes
            // 
            this.btnAdministradorCbtes.Caption = "Administrador /Cbtes Electronicos Enviados";
            this.btnAdministradorCbtes.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAdministradorCbtes.Glyph")));
            this.btnAdministradorCbtes.Id = 9;
            this.btnAdministradorCbtes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAdministradorCbtes.LargeGlyph")));
            this.btnAdministradorCbtes.Name = "btnAdministradorCbtes";
            this.btnAdministradorCbtes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdministradorCbtes_ItemClick);
            // 
            // btn_token
            // 
            this.btn_token.Caption = "Token";
            this.btn_token.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_token.Glyph")));
            this.btn_token.Id = 11;
            this.btn_token.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_token.LargeGlyph")));
            this.btn_token.Name = "btn_token";
            this.btn_token.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_token_ItemClick);
            // 
            // btn_Cbtes_Auto_noAuto
            // 
            this.btn_Cbtes_Auto_noAuto.Caption = "Cbtes. Autorizados y No Autorizados";
            this.btn_Cbtes_Auto_noAuto.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Cbtes_Auto_noAuto.Glyph")));
            this.btn_Cbtes_Auto_noAuto.Id = 12;
            this.btn_Cbtes_Auto_noAuto.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Cbtes_Auto_noAuto.LargeGlyph")));
            this.btn_Cbtes_Auto_noAuto.Name = "btn_Cbtes_Auto_noAuto";
            this.btn_Cbtes_Auto_noAuto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cbtes_Auto_noAuto_ItemClick);
            // 
            // btn_ImportarClaveConting
            // 
            this.btn_ImportarClaveConting.Caption = "Importar Claves Conting.";
            this.btn_ImportarClaveConting.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_ImportarClaveConting.Glyph")));
            this.btn_ImportarClaveConting.Id = 13;
            this.btn_ImportarClaveConting.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_ImportarClaveConting.LargeGlyph")));
            this.btn_ImportarClaveConting.Name = "btn_ImportarClaveConting";
            this.btn_ImportarClaveConting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ImportarClaveConting_ItemClick);
            // 
            // btn_Mail
            // 
            this.btn_Mail.Caption = "Mail Efirm";
            this.btn_Mail.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Mail.Glyph")));
            this.btn_Mail.Id = 14;
            this.btn_Mail.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Mail.LargeGlyph")));
            this.btn_Mail.Name = "btn_Mail";
            this.btn_Mail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Mail_ItemClick);
            // 
            // btn_Procesos_En_Lotes
            // 
            this.btn_Procesos_En_Lotes.Caption = "Descarga/Exportacion RIDE";
            this.btn_Procesos_En_Lotes.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Procesos_En_Lotes.Glyph")));
            this.btn_Procesos_En_Lotes.Id = 15;
            this.btn_Procesos_En_Lotes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Procesos_En_Lotes.LargeGlyph")));
            this.btn_Procesos_En_Lotes.Name = "btn_Procesos_En_Lotes";
            this.btn_Procesos_En_Lotes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Procesos_En_Lotes_ItemClick);
            // 
            // barbtnCbteRe
            // 
            this.barbtnCbteRe.Caption = "Comprobantes Recibidos (EBIZ)";
            this.barbtnCbteRe.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnCbteRe.Glyph")));
            this.barbtnCbteRe.Id = 16;
            this.barbtnCbteRe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnCbteRe.LargeGlyph")));
            this.barbtnCbteRe.Name = "barbtnCbteRe";
            this.barbtnCbteRe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCbteRe_ItemClick);
            // 
            // btnCbtes_para_exportacion
            // 
            this.btnCbtes_para_exportacion.Caption = "Comprobantes/Exportacion";
            this.btnCbtes_para_exportacion.Glyph = global::Efirm.Properties.Resources.application_xml;
            this.btnCbtes_para_exportacion.Id = 17;
            this.btnCbtes_para_exportacion.LargeGlyph = global::Efirm.Properties.Resources.application_xml;
            this.btnCbtes_para_exportacion.Name = "btnCbtes_para_exportacion";
            this.btnCbtes_para_exportacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCbtes_para_exportacion_ItemClick);
            // 
            // barConsultaReporte
            // 
            this.barConsultaReporte.Caption = "Diseñador de Ride x Emisor";
            this.barConsultaReporte.Glyph = global::Efirm.Properties.Resources.custom_reports_icon1;
            this.barConsultaReporte.Id = 20;
            this.barConsultaReporte.LargeGlyph = global::Efirm.Properties.Resources.custom_reports_icon2;
            this.barConsultaReporte.Name = "barConsultaReporte";
            this.barConsultaReporte.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barConsultaReporte_ItemClick);
            // 
            // barMsjValidez
            // 
            this.barMsjValidez.Id = 22;
            this.barMsjValidez.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barMsjValidez.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.barMsjValidez.ItemAppearance.Normal.Options.UseFont = true;
            this.barMsjValidez.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barMsjValidez.Name = "barMsjValidez";
            this.barMsjValidez.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPageEfirm
            // 
            this.ribbonPageEfirm.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupConfiguraciones,
            this.ribbonPageGroupTransacciones,
            this.ribbonPageGroupReportes,
            this.ribbonPageGroupMail});
            this.ribbonPageEfirm.Name = "ribbonPageEfirm";
            this.ribbonPageEfirm.Text = "Sistema";
            // 
            // ribbonPageGroupConfiguraciones
            // 
            this.ribbonPageGroupConfiguraciones.ItemLinks.Add(this.btnParametros, "P");
            this.ribbonPageGroupConfiguraciones.ItemLinks.Add(this.btnConfDirectorios, "DI");
            this.ribbonPageGroupConfiguraciones.ItemLinks.Add(this.btn_token, "TO");
            this.ribbonPageGroupConfiguraciones.ItemLinks.Add(this.btn_ImportarClaveConting, "I");
            this.ribbonPageGroupConfiguraciones.ItemLinks.Add(this.btnEmisor, "EM");
            this.ribbonPageGroupConfiguraciones.ItemLinks.Add(this.barConsultaReporte, "DS");
            this.ribbonPageGroupConfiguraciones.KeyTip = "CO";
            this.ribbonPageGroupConfiguraciones.Name = "ribbonPageGroupConfiguraciones";
            this.ribbonPageGroupConfiguraciones.Text = "Configuraciones";
            // 
            // ribbonPageGroupTransacciones
            // 
            this.ribbonPageGroupTransacciones.ItemLinks.Add(this.btnAdministradorCbtes, "A");
            this.ribbonPageGroupTransacciones.ItemLinks.Add(this.btn_Procesos_En_Lotes, "DE");
            this.ribbonPageGroupTransacciones.ItemLinks.Add(this.barbtnCbteRe, "CM");
            this.ribbonPageGroupTransacciones.ItemLinks.Add(this.btnCbtes_para_exportacion, "CP");
            this.ribbonPageGroupTransacciones.KeyTip = "TR";
            this.ribbonPageGroupTransacciones.Name = "ribbonPageGroupTransacciones";
            this.ribbonPageGroupTransacciones.Text = "Transacciones";
            // 
            // ribbonPageGroupReportes
            // 
            this.ribbonPageGroupReportes.ItemLinks.Add(this.btn_Cbtes_Auto_noAuto, "CB");
            this.ribbonPageGroupReportes.KeyTip = "R";
            this.ribbonPageGroupReportes.Name = "ribbonPageGroupReportes";
            this.ribbonPageGroupReportes.Text = "Reportes";
            // 
            // ribbonPageGroupMail
            // 
            this.ribbonPageGroupMail.ItemLinks.Add(this.btn_Mail, "M");
            this.ribbonPageGroupMail.KeyTip = "EF";
            this.ribbonPageGroupMail.Name = "ribbonPageGroupMail";
            this.ribbonPageGroupMail.Text = "Efirm Mail";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barMsjValidez);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 461);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1219, 31);
            // 
            // btnClaves_Contingencia
            // 
            this.btnClaves_Contingencia.Caption = "Importar Claves";
            this.btnClaves_Contingencia.Description = "Import. Claves";
            this.btnClaves_Contingencia.Id = 1;
            this.btnClaves_Contingencia.Name = "btnClaves_Contingencia";
            // 
            // xtraTabbedMdiManagerMain
            // 
            this.xtraTabbedMdiManagerMain.MdiParent = this;
            // 
            // lblNomEjecucion
            // 
            this.lblNomEjecucion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEjecucion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNomEjecucion.Location = new System.Drawing.Point(0, 445);
            this.lblNomEjecucion.Name = "lblNomEjecucion";
            this.lblNomEjecucion.Size = new System.Drawing.Size(0, 16);
            this.lblNomEjecucion.TabIndex = 3;
            // 
            // xafBarManager1
            // 
            this.xafBarManager1.DockControls.Add(this.barDockControlTop);
            this.xafBarManager1.DockControls.Add(this.barDockControlBottom);
            this.xafBarManager1.DockControls.Add(this.barDockControlLeft);
            this.xafBarManager1.DockControls.Add(this.barDockControlRight);
            this.xafBarManager1.Form = this;
            this.xafBarManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1219, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 492);
            this.barDockControlBottom.Size = new System.Drawing.Size(1219, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1219, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 492);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(1219, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 492);
            this.barDockControl2.Size = new System.Drawing.Size(1219, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1219, 0);
            this.barDockControl4.Size = new System.Drawing.Size(0, 492);
            // 
            // timerValidarFecha
            // 
            this.timerValidarFecha.Interval = 3600000;
            this.timerValidarFecha.Tick += new System.EventHandler(this.timerValidarFecha_Tick);
            // 
            // notMsjValidezCerti
            // 
            this.notMsjValidezCerti.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notMsjValidezCerti.BalloonTipText = "Alerta";
            this.notMsjValidezCerti.BalloonTipTitle = "Mensaje";
            this.notMsjValidezCerti.Text = "Alerta2";
            this.notMsjValidezCerti.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 492);
            this.Controls.Add(this.lblNomEjecucion);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Efirm  Ver.  21_01_2015_1157";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageEfirm;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupConfiguraciones;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnClaves_Contingencia;
        private DevExpress.XtraBars.BarButtonItem btnConfDirectorios;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupTransacciones;
        private DevExpress.XtraBars.BarButtonItem btnParametros;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManagerMain;
        private DevExpress.XtraBars.BarButtonItem btnEmisor;
        private DevExpress.XtraBars.BarButtonItem btnAdministradorCbtes;
        private DevExpress.XtraBars.BarButtonItem btn_token;
        private DevExpress.XtraBars.BarButtonItem btn_Cbtes_Auto_noAuto;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupReportes;
        private DevExpress.XtraBars.BarButtonItem btn_ImportarClaveConting;
        private DevExpress.XtraBars.BarButtonItem btn_Mail;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMail;
        private DevExpress.XtraBars.BarButtonItem btn_Procesos_En_Lotes;
        private DevExpress.XtraBars.BarButtonItem barbtnCbteRe;
        private DevExpress.XtraBars.BarButtonItem btnCbtes_para_exportacion;
        private DevExpress.XtraBars.BarButtonItem barConsultaReporte;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.LabelControl lblNomEjecucion;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager xafBarManager1;
        private DevExpress.XtraBars.BarManager barManager1;
        private System.Windows.Forms.Timer timerValidarFecha;
        private DevExpress.XtraBars.BarStaticItem barMsjValidez;
        private System.Windows.Forms.NotifyIcon notMsjValidezCerti;
    }
}