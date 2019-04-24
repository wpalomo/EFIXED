
namespace Efirm
{
    partial class frmTestMail
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
            this.uC_Menu_Main1 = new MailEfirm.Controls.UC_Menu_Main();
            this.SuspendLayout();
            // 
            // uC_Menu_Main1
            // 
            this.uC_Menu_Main1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Menu_Main1.Location = new System.Drawing.Point(0, 0);
            this.uC_Menu_Main1.Name = "uC_Menu_Main1";
            this.uC_Menu_Main1.Size = new System.Drawing.Size(843, 458);
            this.uC_Menu_Main1.TabIndex = 0;
            this.uC_Menu_Main1.Load += new System.EventHandler(this.uC_Menu_Main1_Load);
            // 
            // frmTestMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 458);
            this.Controls.Add(this.uC_Menu_Main1);
            this.Name = "frmTestMail";
            this.Text = "frmTestMail";
            this.ResumeLayout(false);

        }

        #endregion

      private MailEfirm.Controls.UC_Menu_Main uC_Menu_Main1;
    }
}