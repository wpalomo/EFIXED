namespace MailEfirm.Forms
{
    partial class Frm_Enviar_Cbtes_Auto_Mail
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Envio_Cbtes_Autorizados_Masivo1 = new MailEfirm.Controls.UC_Envio_Cbtes_Autorizados_Masivo();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1025, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Envio_Cbtes_Autorizados_Masivo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 437);
            this.panel1.TabIndex = 1;
            // 
            // uC_Envio_Cbtes_Autorizados_Masivo1
            // 
            this.uC_Envio_Cbtes_Autorizados_Masivo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Envio_Cbtes_Autorizados_Masivo1.Location = new System.Drawing.Point(0, 0);
            this.uC_Envio_Cbtes_Autorizados_Masivo1.Name = "uC_Envio_Cbtes_Autorizados_Masivo1";
            this.uC_Envio_Cbtes_Autorizados_Masivo1.Size = new System.Drawing.Size(1025, 437);
            this.uC_Envio_Cbtes_Autorizados_Masivo1.TabIndex = 0;
            // 
            // Frm_Enviar_Cbtes_Auto_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Frm_Enviar_Cbtes_Auto_Mail";
            this.Text = "Enviar Comprobantes Autorizados por Mail Masivamente";
            this.Load += new System.EventHandler(this.Frm_Enviar_Cbtes_Auto_Mail_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controls.UC_Envio_Cbtes_Autorizados_Masivo uC_Envio_Cbtes_Autorizados_Masivo1;
    }
}