namespace MailEfirm.Forms
{
    partial class Frm_Menu_Cuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu_Cuentas));
            this.topOpciones = new System.Windows.Forms.ToolStrip();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.uC_Cuentas1 = new MailEfirm.Controls.UC_Cuentas();
            this.topOpciones.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // topOpciones
            // 
            this.topOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_salir});
            this.topOpciones.Location = new System.Drawing.Point(0, 0);
            this.topOpciones.Name = "topOpciones";
            this.topOpciones.Size = new System.Drawing.Size(829, 25);
            this.topOpciones.TabIndex = 0;
            this.topOpciones.Text = "toolStrip1";
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
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.uC_Cuentas1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 25);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(829, 462);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // uC_Cuentas1
            // 
            this.uC_Cuentas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Cuentas1.Location = new System.Drawing.Point(0, 0);
            this.uC_Cuentas1.Name = "uC_Cuentas1";
            this.uC_Cuentas1.Size = new System.Drawing.Size(829, 462);
            this.uC_Cuentas1.TabIndex = 0;
            this.uC_Cuentas1.Load += new System.EventHandler(this.uC_Cuentas1_Load);
            // 
            // Frm_Menu_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 487);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.topOpciones);
            this.Name = "Frm_Menu_Cuentas";
            this.Text = "Cuentas de correo";
            this.Load += new System.EventHandler(this.Frm_Menu_Cuentas_Load);
            this.topOpciones.ResumeLayout(false);
            this.topOpciones.PerformLayout();
            this.PanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip topOpciones;
        private System.Windows.Forms.Panel PanelPrincipal;
        private Controls.UC_Cuentas uC_Cuentas1;
        private System.Windows.Forms.ToolStripButton btn_salir;
    }
}