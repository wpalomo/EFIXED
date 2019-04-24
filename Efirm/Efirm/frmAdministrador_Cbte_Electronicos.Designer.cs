namespace Efirm
{
    partial class frmAdministrador_Cbte_Electronicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador_Cbte_Electronicos));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnRecibidoRepositorio = new DevExpress.XtraNavBar.NavBarItem();
            this.btnValidosPendFirmaryEnviarSri = new DevExpress.XtraNavBar.NavBarItem();
            this.btnCbtesRecibidos_ = new DevExpress.XtraNavBar.NavBarItem();
            this.btnFirmadosYRecibido_Aut_no_auto = new DevExpress.XtraNavBar.NavBarItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto = new Efirm.UC_Comprobante_Pendientes_Autorizacion();
            this.uC_Comprobante_Recibidos_Aut_x_SRI = new Efirm.UC_Comprobante_Autoriz_No_Autoriz_x_SRI();
            this.uC_Comprobante_Valido_Firmado_efirm = new Efirm.UC_Comprobante_x_Enviar_firmar_al_SRI_efirm();
            this.uC_Comprobante_recibido = new Efirm.UC_Comprobante_En_Repositorio();
            this.notifyIconAdmin = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnRecibidoRepositorio,
            this.btnValidosPendFirmaryEnviarSri,
            this.btnFirmadosYRecibido_Aut_no_auto,
            this.btnCbtesRecibidos_});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 286;
            this.navBarControl1.Size = new System.Drawing.Size(286, 569);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Comprobantes";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnRecibidoRepositorio),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnValidosPendFirmaryEnviarSri),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCbtesRecibidos_),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnFirmadosYRecibido_Aut_no_auto)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btnRecibidoRepositorio
            // 
            this.btnRecibidoRepositorio.Caption = "xml Recibidos en Repositorio";
            this.btnRecibidoRepositorio.Name = "btnRecibidoRepositorio";
            this.btnRecibidoRepositorio.SmallImage = global::Efirm.Properties.Resources.xml_recibido_32x32;
            this.btnRecibidoRepositorio.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemRecibido_LinkClicked);
            // 
            // btnValidosPendFirmaryEnviarSri
            // 
            this.btnValidosPendFirmaryEnviarSri.Caption = "Validos Pendientes de Firmar y Enviar al SRI";
            this.btnValidosPendFirmaryEnviarSri.Name = "btnValidosPendFirmaryEnviarSri";
            this.btnValidosPendFirmaryEnviarSri.SmallImage = global::Efirm.Properties.Resources.xml_firmado_32x32;
            this.btnValidosPendFirmaryEnviarSri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // btnCbtesRecibidos_
            // 
            this.btnCbtesRecibidos_.Caption = "Cbtes.RECIBIDO(SRI) sin Respuesta AUTO.";
            this.btnCbtesRecibidos_.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCbtesRecibidos_.LargeImage")));
            this.btnCbtesRecibidos_.Name = "btnCbtesRecibidos_";
            this.btnCbtesRecibidos_.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCbtesRecibidos_.SmallImage")));
            this.btnCbtesRecibidos_.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnCbtesRecibidos__LinkClicked);
            // 
            // btnFirmadosYRecibido_Aut_no_auto
            // 
            this.btnFirmadosYRecibido_Aut_no_auto.Caption = "Firmados y Recibidos Por SRI (Auto/No Auto)";
            this.btnFirmadosYRecibido_Aut_no_auto.Name = "btnFirmadosYRecibido_Aut_no_auto";
            this.btnFirmadosYRecibido_Aut_no_auto.SmallImage = global::Efirm.Properties.Resources.xml_firmado_autorizado_32x32;
            this.btnFirmadosYRecibido_Aut_no_auto.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnFirmadosYAutorizadosxSRI_LinkClicked);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto);
            this.panelMain.Controls.Add(this.uC_Comprobante_Recibidos_Aut_x_SRI);
            this.panelMain.Controls.Add(this.uC_Comprobante_Valido_Firmado_efirm);
            this.panelMain.Controls.Add(this.uC_Comprobante_recibido);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(286, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(850, 569);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto
            // 
            this.uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto.Location = new System.Drawing.Point(6, 229);
            this.uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto.Name = "uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto";
            this.uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto.Size = new System.Drawing.Size(667, 337);
            this.uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto.TabIndex = 4;
            // 
            // uC_Comprobante_Recibidos_Aut_x_SRI
            // 
            this.uC_Comprobante_Recibidos_Aut_x_SRI.Location = new System.Drawing.Point(91, 340);
            this.uC_Comprobante_Recibidos_Aut_x_SRI.Name = "uC_Comprobante_Recibidos_Aut_x_SRI";
            this.uC_Comprobante_Recibidos_Aut_x_SRI.Size = new System.Drawing.Size(259, 61);
            this.uC_Comprobante_Recibidos_Aut_x_SRI.TabIndex = 3;
            // 
            // uC_Comprobante_Valido_Firmado_efirm
            // 
            this.uC_Comprobante_Valido_Firmado_efirm.Location = new System.Drawing.Point(47, 3);
            this.uC_Comprobante_Valido_Firmado_efirm.Name = "uC_Comprobante_Valido_Firmado_efirm";
            this.uC_Comprobante_Valido_Firmado_efirm.Size = new System.Drawing.Size(514, 228);
            this.uC_Comprobante_Valido_Firmado_efirm.TabIndex = 2;
            this.uC_Comprobante_Valido_Firmado_efirm.Load += new System.EventHandler(this.uC_Comprobante_Valido_Firmado_efirm_Load);
            // 
            // uC_Comprobante_recibido
            // 
            this.uC_Comprobante_recibido.Location = new System.Drawing.Point(91, 37);
            this.uC_Comprobante_recibido.Name = "uC_Comprobante_recibido";
            this.uC_Comprobante_recibido.Size = new System.Drawing.Size(227, 73);
            this.uC_Comprobante_recibido.StreamReader_File_Temporal = null;
            this.uC_Comprobante_recibido.strm_File_Temporal = null;
            this.uC_Comprobante_recibido.TabIndex = 1;
            // 
            // notifyIconAdmin
            // 
            this.notifyIconAdmin.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconAdmin.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconAdmin.Icon")));
            // 
            // frmAdministrador_Cbte_Electronicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 569);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.navBarControl1);
            this.Name = "frmAdministrador_Cbte_Electronicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Comprobantes XML";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdministrador_Cbte_Electronicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem btnRecibidoRepositorio;
        private DevExpress.XtraNavBar.NavBarItem btnValidosPendFirmaryEnviarSri;
        private DevExpress.XtraNavBar.NavBarItem btnFirmadosYRecibido_Aut_no_auto;
        private System.Windows.Forms.Panel panelMain;
        private UC_Comprobante_En_Repositorio uC_Comprobante_recibido;
        public System.Windows.Forms.NotifyIcon notifyIconAdmin;
        private UC_Comprobante_x_Enviar_firmar_al_SRI_efirm uC_Comprobante_Valido_Firmado_efirm;
        private UC_Comprobante_Autoriz_No_Autoriz_x_SRI uC_Comprobante_Recibidos_Aut_x_SRI;
        private DevExpress.XtraNavBar.NavBarItem btnCbtesRecibidos_;
        private UC_Comprobante_Pendientes_Autorizacion uC_Comprobante_Enviado_al_SRI_y_Recibido_Sin_Resp_Auto;
    }
}