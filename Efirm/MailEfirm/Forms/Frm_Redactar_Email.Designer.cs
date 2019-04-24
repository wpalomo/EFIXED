namespace MailEfirm.Forms
{
    partial class Frm_Redactar_Email
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
            this.uC_Menu_Redactar_Email1 = new MailEfirm.Controls.UC_Menu_Redactar_Email();
            this.SuspendLayout();
            // 
            // uC_Menu_Redactar_Email1
            // 
            this.uC_Menu_Redactar_Email1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Menu_Redactar_Email1.Location = new System.Drawing.Point(0, 0);
            this.uC_Menu_Redactar_Email1.Name = "uC_Menu_Redactar_Email1";
            this.uC_Menu_Redactar_Email1.Size = new System.Drawing.Size(844, 475);
            this.uC_Menu_Redactar_Email1.TabIndex = 0;
            // 
            // Frm_Redactar_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 475);
            this.Controls.Add(this.uC_Menu_Redactar_Email1);
            this.Name = "Frm_Redactar_Email";
            this.Text = "Redactar Correo";
            this.Load += new System.EventHandler(this.Frm_Redactar_Email_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UC_Menu_Redactar_Email uC_Menu_Redactar_Email1;
    }
}