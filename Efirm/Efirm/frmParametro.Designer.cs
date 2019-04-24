namespace Efirm
{
    partial class frmParametro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametro));
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.lbl_espacio = new System.Windows.Forms.ToolStripLabel();
            this.statusStripBarraEstado = new System.Windows.Forms.StatusStrip();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridControlParametro = new DevExpress.XtraGrid.GridControl();
            this.gridViewParametro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colurl_ws_sri_Recep_cbte_Prueba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurl_ws_sri_Recep_cbte_Produc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurl_ws_sri_Autorizacion_cbte_Prueba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurl_ws_sri_Autorizacion_cbte_Produc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurl_ws_firma_efirm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsa_Proxy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrl_Proxy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPort_Proxy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario_Proxy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword_Proxy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menu.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParametro)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.lbl_espacio});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1166, 25);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(69, 22);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_espacio
            // 
            this.lbl_espacio.Name = "lbl_espacio";
            this.lbl_espacio.Size = new System.Drawing.Size(0, 22);
            // 
            // statusStripBarraEstado
            // 
            this.statusStripBarraEstado.Location = new System.Drawing.Point(0, 286);
            this.statusStripBarraEstado.Name = "statusStripBarraEstado";
            this.statusStripBarraEstado.Size = new System.Drawing.Size(1166, 22);
            this.statusStripBarraEstado.TabIndex = 1;
            this.statusStripBarraEstado.Text = "statusStrip1";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControlParametro);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1166, 261);
            this.panelMain.TabIndex = 2;
            // 
            // gridControlParametro
            // 
            this.gridControlParametro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlParametro.Location = new System.Drawing.Point(0, 0);
            this.gridControlParametro.MainView = this.gridViewParametro;
            this.gridControlParametro.Name = "gridControlParametro";
            this.gridControlParametro.Size = new System.Drawing.Size(1166, 261);
            this.gridControlParametro.TabIndex = 0;
            this.gridControlParametro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParametro});
            this.gridControlParametro.Click += new System.EventHandler(this.gridControlParametro_Click);
            // 
            // gridViewParametro
            // 
            this.gridViewParametro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colurl_ws_sri_Recep_cbte_Prueba,
            this.colurl_ws_sri_Recep_cbte_Produc,
            this.colurl_ws_sri_Autorizacion_cbte_Prueba,
            this.colurl_ws_sri_Autorizacion_cbte_Produc,
            this.colurl_ws_firma_efirm,
            this.colUsa_Proxy,
            this.colUrl_Proxy,
            this.colPort_Proxy,
            this.colUsuario_Proxy,
            this.colPassword_Proxy});
            this.gridViewParametro.GridControl = this.gridControlParametro;
            this.gridViewParametro.Name = "gridViewParametro";
            this.gridViewParametro.OptionsView.ShowAutoFilterRow = true;
            this.gridViewParametro.OptionsView.ShowGroupPanel = false;
            // 
            // colurl_ws_sri_Recep_cbte_Prueba
            // 
            this.colurl_ws_sri_Recep_cbte_Prueba.Caption = "Web Service Recepcion cbte Prueba";
            this.colurl_ws_sri_Recep_cbte_Prueba.FieldName = "url_ws_sri_Recep_cbte_Prueba";
            this.colurl_ws_sri_Recep_cbte_Prueba.Name = "colurl_ws_sri_Recep_cbte_Prueba";
            this.colurl_ws_sri_Recep_cbte_Prueba.Visible = true;
            this.colurl_ws_sri_Recep_cbte_Prueba.VisibleIndex = 0;
            this.colurl_ws_sri_Recep_cbte_Prueba.Width = 186;
            // 
            // colurl_ws_sri_Recep_cbte_Produc
            // 
            this.colurl_ws_sri_Recep_cbte_Produc.Caption = "Web Service Recep cbte Produc";
            this.colurl_ws_sri_Recep_cbte_Produc.FieldName = "url_ws_sri_Recep_cbte_Produc";
            this.colurl_ws_sri_Recep_cbte_Produc.Name = "colurl_ws_sri_Recep_cbte_Produc";
            this.colurl_ws_sri_Recep_cbte_Produc.Visible = true;
            this.colurl_ws_sri_Recep_cbte_Produc.VisibleIndex = 1;
            this.colurl_ws_sri_Recep_cbte_Produc.Width = 210;
            // 
            // colurl_ws_sri_Autorizacion_cbte_Prueba
            // 
            this.colurl_ws_sri_Autorizacion_cbte_Prueba.Caption = "Web Service Autorizacion cbte Prueba";
            this.colurl_ws_sri_Autorizacion_cbte_Prueba.FieldName = "url_ws_sri_Autorizacion_cbte_Prueba";
            this.colurl_ws_sri_Autorizacion_cbte_Prueba.Name = "colurl_ws_sri_Autorizacion_cbte_Prueba";
            this.colurl_ws_sri_Autorizacion_cbte_Prueba.Visible = true;
            this.colurl_ws_sri_Autorizacion_cbte_Prueba.VisibleIndex = 2;
            this.colurl_ws_sri_Autorizacion_cbte_Prueba.Width = 183;
            // 
            // colurl_ws_sri_Autorizacion_cbte_Produc
            // 
            this.colurl_ws_sri_Autorizacion_cbte_Produc.Caption = "Web Service Autorizacion cbte Produc";
            this.colurl_ws_sri_Autorizacion_cbte_Produc.FieldName = "url_ws_sri_Autorizacion_cbte_Produc";
            this.colurl_ws_sri_Autorizacion_cbte_Produc.Name = "colurl_ws_sri_Autorizacion_cbte_Produc";
            this.colurl_ws_sri_Autorizacion_cbte_Produc.Visible = true;
            this.colurl_ws_sri_Autorizacion_cbte_Produc.VisibleIndex = 3;
            this.colurl_ws_sri_Autorizacion_cbte_Produc.Width = 160;
            // 
            // colurl_ws_firma_efirm
            // 
            this.colurl_ws_firma_efirm.Caption = "Web Serive Efirm";
            this.colurl_ws_firma_efirm.FieldName = "url_ws_firma_efirm";
            this.colurl_ws_firma_efirm.Name = "colurl_ws_firma_efirm";
            this.colurl_ws_firma_efirm.Visible = true;
            this.colurl_ws_firma_efirm.VisibleIndex = 4;
            this.colurl_ws_firma_efirm.Width = 83;
            // 
            // colUsa_Proxy
            // 
            this.colUsa_Proxy.FieldName = "Usa_Proxy";
            this.colUsa_Proxy.Name = "colUsa_Proxy";
            this.colUsa_Proxy.Visible = true;
            this.colUsa_Proxy.VisibleIndex = 5;
            this.colUsa_Proxy.Width = 61;
            // 
            // colUrl_Proxy
            // 
            this.colUrl_Proxy.FieldName = "Url_Proxy";
            this.colUrl_Proxy.Name = "colUrl_Proxy";
            this.colUrl_Proxy.Visible = true;
            this.colUrl_Proxy.VisibleIndex = 6;
            this.colUrl_Proxy.Width = 61;
            // 
            // colPort_Proxy
            // 
            this.colPort_Proxy.FieldName = "Port_Proxy";
            this.colPort_Proxy.Name = "colPort_Proxy";
            this.colPort_Proxy.Visible = true;
            this.colPort_Proxy.VisibleIndex = 7;
            this.colPort_Proxy.Width = 61;
            // 
            // colUsuario_Proxy
            // 
            this.colUsuario_Proxy.FieldName = "Usuario_Proxy";
            this.colUsuario_Proxy.Name = "colUsuario_Proxy";
            this.colUsuario_Proxy.Visible = true;
            this.colUsuario_Proxy.VisibleIndex = 8;
            this.colUsuario_Proxy.Width = 61;
            // 
            // colPassword_Proxy
            // 
            this.colPassword_Proxy.FieldName = "Password_Proxy";
            this.colPassword_Proxy.Name = "colPassword_Proxy";
            this.colPassword_Proxy.Visible = true;
            this.colPassword_Proxy.VisibleIndex = 9;
            this.colPassword_Proxy.Width = 82;
            // 
            // frmParametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 308);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusStripBarraEstado);
            this.Controls.Add(this.Menu);
            this.Name = "frmParametro";
            this.Text = "frmParametro";
            this.Load += new System.EventHandler(this.frmParametro_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParametro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.StatusStrip statusStripBarraEstado;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlParametro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParametro;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private DevExpress.XtraGrid.Columns.GridColumn colurl_ws_sri_Recep_cbte_Prueba;
        private DevExpress.XtraGrid.Columns.GridColumn colurl_ws_sri_Recep_cbte_Produc;
        private DevExpress.XtraGrid.Columns.GridColumn colurl_ws_sri_Autorizacion_cbte_Prueba;
        private DevExpress.XtraGrid.Columns.GridColumn colurl_ws_sri_Autorizacion_cbte_Produc;
        private DevExpress.XtraGrid.Columns.GridColumn colurl_ws_firma_efirm;
        private System.Windows.Forms.ToolStripLabel lbl_espacio;
        private DevExpress.XtraGrid.Columns.GridColumn colUsa_Proxy;
        private DevExpress.XtraGrid.Columns.GridColumn colUrl_Proxy;
        private DevExpress.XtraGrid.Columns.GridColumn colPort_Proxy;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario_Proxy;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword_Proxy;
    }
}