namespace Efirm
{
    partial class frmRpt_Cbtes_Auto_NoAuto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Comprobante_Recibidos_Aut_x_SRI1 = new Efirm.UC_Comprobante_Autoriz_No_Autoriz_x_SRI();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Comprobante_Recibidos_Aut_x_SRI1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 407);
            this.panel1.TabIndex = 0;
            // 
            // uC_Comprobante_Recibidos_Aut_x_SRI1
            // 
            this.uC_Comprobante_Recibidos_Aut_x_SRI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Comprobante_Recibidos_Aut_x_SRI1.Location = new System.Drawing.Point(0, 0);
            this.uC_Comprobante_Recibidos_Aut_x_SRI1.Name = "uC_Comprobante_Recibidos_Aut_x_SRI1";
            this.uC_Comprobante_Recibidos_Aut_x_SRI1.Size = new System.Drawing.Size(975, 407);
            this.uC_Comprobante_Recibidos_Aut_x_SRI1.TabIndex = 0;
            this.uC_Comprobante_Recibidos_Aut_x_SRI1.Load += new System.EventHandler(this.uC_Comprobante_Recibidos_Aut_x_SRI1_Load);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmRpt_Cbtes_Auto_NoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 407);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmRpt_Cbtes_Auto_NoAuto";
            this.Text = "Comprobantes Autorizados y No Autorizados";
            this.Load += new System.EventHandler(this.frmRpt_Cbtes_Auto_NoAuto_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UC_Comprobante_Autoriz_No_Autoriz_x_SRI uC_Comprobante_Recibidos_Aut_x_SRI1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}