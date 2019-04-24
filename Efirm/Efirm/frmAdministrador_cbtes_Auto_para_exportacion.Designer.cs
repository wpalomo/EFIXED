namespace Efirm
{
    partial class frmAdministrador_cbtes_Auto_para_exportacion
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
            this.uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1 = new Efirm.UC_Comprobantes_Autorizados_para_exportacion_Base_Exter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 421);
            this.panel1.TabIndex = 1;
            // 
            // uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1
            // 
            this.uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1.Location = new System.Drawing.Point(0, 0);
            this.uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1.Name = "uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1";
            this.uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1.Size = new System.Drawing.Size(952, 421);
            this.uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1.TabIndex = 0;
            // 
            // frmAdministrador_cbtes_Auto_para_exportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmAdministrador_cbtes_Auto_para_exportacion";
            this.Text = "Administrador de Comprobantes para exportacion a Base externa ";
            this.Load += new System.EventHandler(this.frmAdministrador_cbtes_Auto_para_exportacion_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private UC_Comprobantes_Autorizados_para_exportacion_Base_Exter uC_Comprobantes_Autorizados_para_exportacion_Base_Exter1;

    }
}