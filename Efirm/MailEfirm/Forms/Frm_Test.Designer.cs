namespace MailEfirm.Forms
{
    partial class Frm_Test
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
            this.uC_Menu_cuentas_mail1 = new MailEfirm.Controls.UC_Menu_cuentas_mail();
            this.SuspendLayout();
            // 
            // uC_Menu_cuentas_mail1
            // 
            this.uC_Menu_cuentas_mail1.Location = new System.Drawing.Point(3, 1);
            this.uC_Menu_cuentas_mail1.Name = "uC_Menu_cuentas_mail1";
            this.uC_Menu_cuentas_mail1.Size = new System.Drawing.Size(341, 409);
            this.uC_Menu_cuentas_mail1.TabIndex = 0;
            // 
            // Frm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 438);
            this.Controls.Add(this.uC_Menu_cuentas_mail1);
            this.Name = "Frm_Test";
            this.Text = "Frm_Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UC_Menu_cuentas_mail uC_Menu_cuentas_mail1;
    }
}