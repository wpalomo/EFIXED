namespace MailEfirm
{
    partial class Frm_Main_Mail
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.uC_Menu_Main = new MailEfirm.Controls.UC_Menu_Main();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.uC_Menu_Main);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(922, 520);
            this.panelMain.TabIndex = 0;
            // 
            // uC_Menu_Main
            // 
            this.uC_Menu_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.uC_Menu_Main.Name = "uC_Menu_Main";
            this.uC_Menu_Main.Size = new System.Drawing.Size(922, 520);
            this.uC_Menu_Main.TabIndex = 0;
            this.uC_Menu_Main.Load += new System.EventHandler(this.uC_Menu_Main_Load);
            // 
            // Frm_Main_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 520);
            this.Controls.Add(this.panelMain);
            this.Name = "Frm_Main_Mail";
            this.Text = "Mail Efirm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Main_Mail_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private Controls.UC_Menu_Main uC_Menu_Main;
    }
}