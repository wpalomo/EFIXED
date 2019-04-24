namespace Efirm
{
    partial class frmComprobantes_autorizados_no_autorizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobantes_autorizados_no_autorizados));
            this.TopSuperior = new System.Windows.Forms.ToolStrip();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.uC_Comprobante_Autoriz_No_Autoriz_x_SRI1 = new Efirm.UC_Comprobante_Autoriz_No_Autoriz_x_SRI();
            this.splashScreenManager_buscar = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Efirm.frmEsperar), true, true);
            this.TopSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopSuperior
            // 
            this.TopSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_buscar,
            this.btn_salir,
            this.btn_imprimir});
            this.TopSuperior.Location = new System.Drawing.Point(0, 0);
            this.TopSuperior.Name = "TopSuperior";
            this.TopSuperior.Size = new System.Drawing.Size(1108, 25);
            this.TopSuperior.TabIndex = 8;
            this.TopSuperior.Text = "toolStrip1";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(62, 22);
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(73, 22);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // uC_Comprobante_Autoriz_No_Autoriz_x_SRI1
            // 
            this.uC_Comprobante_Autoriz_No_Autoriz_x_SRI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Comprobante_Autoriz_No_Autoriz_x_SRI1.Location = new System.Drawing.Point(0, 25);
            this.uC_Comprobante_Autoriz_No_Autoriz_x_SRI1.Name = "uC_Comprobante_Autoriz_No_Autoriz_x_SRI1";
            this.uC_Comprobante_Autoriz_No_Autoriz_x_SRI1.Size = new System.Drawing.Size(1108, 435);
            this.uC_Comprobante_Autoriz_No_Autoriz_x_SRI1.TabIndex = 9;
            // 
            // frmComprobantes_autorizados_no_autorizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 460);
            this.Controls.Add(this.uC_Comprobante_Autoriz_No_Autoriz_x_SRI1);
            this.Controls.Add(this.TopSuperior);
            this.Name = "frmComprobantes_autorizados_no_autorizados";
            this.Text = "frmComprobantes_autorizados_no_autorizados";
            this.TopSuperior.ResumeLayout(false);
            this.TopSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TopSuperior;
        public System.Windows.Forms.ToolStripButton btn_salir;
        private UC_Comprobante_Autoriz_No_Autoriz_x_SRI uC_Comprobante_Autoriz_No_Autoriz_x_SRI1;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager_buscar;
    }
}