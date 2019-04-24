namespace Efirm
{
    partial class frmComprobantes_validos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobantes_validos));
            this.TopSuperior = new System.Windows.Forms.ToolStrip();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1 = new Efirm.UC_Comprobante_x_Enviar_firmar_al_SRI_efirm();
            this.TopSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopSuperior
            // 
            this.TopSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_salir});
            this.TopSuperior.Location = new System.Drawing.Point(0, 0);
            this.TopSuperior.Name = "TopSuperior";
            this.TopSuperior.Size = new System.Drawing.Size(1025, 25);
            this.TopSuperior.TabIndex = 8;
            this.TopSuperior.Text = "toolStrip1";
            // 
            // btn_salir
            // 
            this.btn_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(23, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1
            // 
            this.uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1.Location = new System.Drawing.Point(0, 25);
            this.uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1.Name = "uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1";
            this.uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1.Size = new System.Drawing.Size(1025, 453);
            this.uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1.TabIndex = 9;
            // 
            // frmComprobantes_validos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 478);
            this.Controls.Add(this.uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1);
            this.Controls.Add(this.TopSuperior);
            this.Name = "frmComprobantes_validos";
            this.Text = "frmComprobantes_validos";
            this.TopSuperior.ResumeLayout(false);
            this.TopSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TopSuperior;
        public System.Windows.Forms.ToolStripButton btn_salir;
        private UC_Comprobante_x_Enviar_firmar_al_SRI_efirm uC_Comprobante_x_Enviar_firmar_al_SRI_efirm1;
    }
}