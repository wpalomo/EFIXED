namespace Efirm
{
    partial class frmComprobantes_en_repocitorio
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
            this.uC_Comprobante_En_Repositorio1 = new Efirm.UC_Comprobante_En_Repositorio();
            this.SuspendLayout();
            // 
            // uC_Comprobante_En_Repositorio1
            // 
            this.uC_Comprobante_En_Repositorio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Comprobante_En_Repositorio1.Location = new System.Drawing.Point(0, 0);
            this.uC_Comprobante_En_Repositorio1.Name = "uC_Comprobante_En_Repositorio1";
            this.uC_Comprobante_En_Repositorio1.Size = new System.Drawing.Size(1214, 553);
            this.uC_Comprobante_En_Repositorio1.StreamReader_File_Temporal = null;
            this.uC_Comprobante_En_Repositorio1.strm_File_Temporal = null;
            this.uC_Comprobante_En_Repositorio1.TabIndex = 9;
            // 
            // frmComprobantes_en_repocitorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 553);
            this.Controls.Add(this.uC_Comprobante_En_Repositorio1);
            this.Name = "frmComprobantes_en_repocitorio";
            this.Text = "frmComprobantes_en_repocitorio";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Comprobante_En_Repositorio uC_Comprobante_En_Repositorio1;


    }
}