namespace MailEfirm.Forms
{
    partial class Frm_Nuevo_Usuario
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
            this.uC_Registro_Contacto = new MailEfirm.Controls.UC_Contacto_mant();
            this.SuspendLayout();
            // 
            // uC_Registro_Contacto
            // 
            this.uC_Registro_Contacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Registro_Contacto.Location = new System.Drawing.Point(0, 0);
            this.uC_Registro_Contacto.Name = "uC_Registro_Contacto";
            this.uC_Registro_Contacto.Size = new System.Drawing.Size(829, 321);
            this.uC_Registro_Contacto.TabIndex = 0;
            this.uC_Registro_Contacto.Load += new System.EventHandler(this.uC_Registro_Contacto1_Load_2);
            // 
            // Frm_Nuevo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 321);
            this.Controls.Add(this.uC_Registro_Contacto);
            this.MaximizeBox = false;
            this.Name = "Frm_Nuevo_Usuario";
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.Frm_Nuevo_Usuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Controls.UC_Contacto_mant uC_Registro_Contacto;










    }
}