namespace MailEfirm.Forms
{
    partial class Frm_Correo_POP_IMAP
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkLeaveCopy = new System.Windows.Forms.CheckBox();
            this.lstProtocol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstAuthType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl_Correo = new DevExpress.XtraGrid.GridControl();
            this.gridView_Correo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAsunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.lblTotal = new System.Windows.Forms.Label();
            this.webMail = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.colArchivo_correo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodMensajeId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Correo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Correo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(132, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(36, 239);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 24);
            this.btnStart.TabIndex = 26;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkLeaveCopy
            // 
            this.chkLeaveCopy.Location = new System.Drawing.Point(12, 207);
            this.chkLeaveCopy.Name = "chkLeaveCopy";
            this.chkLeaveCopy.Size = new System.Drawing.Size(208, 16);
            this.chkLeaveCopy.TabIndex = 25;
            this.chkLeaveCopy.Text = "Leave a copy of message on server";
            // 
            // lstProtocol
            // 
            this.lstProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProtocol.Location = new System.Drawing.Point(84, 175);
            this.lstProtocol.Name = "lstProtocol";
            this.lstProtocol.Size = new System.Drawing.Size(136, 21);
            this.lstProtocol.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Protocol";
            // 
            // lstAuthType
            // 
            this.lstAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstAuthType.Location = new System.Drawing.Point(84, 143);
            this.lstAuthType.Name = "lstAuthType";
            this.lstAuthType.Size = new System.Drawing.Size(136, 21);
            this.lstAuthType.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Auth Type";
            // 
            // chkSSL
            // 
            this.chkSSL.Location = new System.Drawing.Point(12, 119);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(208, 16);
            this.chkSSL.TabIndex = 20;
            this.chkSSL.Text = "SSL connection";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(84, 85);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(136, 20);
            this.textPassword.TabIndex = 19;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(84, 53);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(136, 20);
            this.textUser.TabIndex = 18;
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(84, 21);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(136, 20);
            this.textServer.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Servidor:";
            // 
            // gridControl_Correo
            // 
            this.gridControl_Correo.Location = new System.Drawing.Point(252, 23);
            this.gridControl_Correo.MainView = this.gridView_Correo;
            this.gridControl_Correo.Name = "gridControl_Correo";
            this.gridControl_Correo.Size = new System.Drawing.Size(646, 240);
            this.gridControl_Correo.TabIndex = 28;
            this.gridControl_Correo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Correo});
            this.gridControl_Correo.DoubleClick += new System.EventHandler(this.gridControl_Correo_DoubleClick);
            // 
            // gridView_Correo
            // 
            this.gridView_Correo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAsunto,
            this.colFecha,
            this.colfileName,
            this.colArchivo_correo,
            this.colcodMensajeId});
            this.gridView_Correo.GridControl = this.gridControl_Correo;
            this.gridView_Correo.Name = "gridView_Correo";
            // 
            // colAsunto
            // 
            this.colAsunto.Caption = "Asunto";
            this.colAsunto.FieldName = "Asunto";
            this.colAsunto.Name = "colAsunto";
            this.colAsunto.OptionsColumn.AllowEdit = false;
            this.colAsunto.Visible = true;
            this.colAsunto.VisibleIndex = 0;
            this.colAsunto.Width = 664;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 250;
            // 
            // colfileName
            // 
            this.colfileName.FieldName = "fileName";
            this.colfileName.Name = "colfileName";
            this.colfileName.Width = 250;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 431);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 29;
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(15, 285);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(216, 8);
            this.pgBar.TabIndex = 30;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(249, 266);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "label6";
            // 
            // webMail
            // 
            this.webMail.Location = new System.Drawing.Point(252, 282);
            this.webMail.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMail.Name = "webMail";
            this.webMail.Size = new System.Drawing.Size(643, 226);
            this.webMail.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Grabar en Base";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colArchivo_correo
            // 
            this.colArchivo_correo.FieldName = "Archivo_correo";
            this.colArchivo_correo.Name = "colArchivo_correo";
            // 
            // colcodMensajeId
            // 
            this.colcodMensajeId.FieldName = "codMensajeId";
            this.colcodMensajeId.Name = "colcodMensajeId";
            // 
            // Frm_Correo_POP_IMAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webMail);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gridControl_Correo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkLeaveCopy);
            this.Controls.Add(this.lstProtocol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstAuthType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkSSL);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Correo_POP_IMAP";
            this.Text = "Frm_Correo_POP_IMAP";
            this.Load += new System.EventHandler(this.Frm_Correo_POP_IMAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Correo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Correo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkLeaveCopy;
        private System.Windows.Forms.ComboBox lstProtocol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lstAuthType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl_Correo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Correo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.WebBrowser webMail;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colAsunto;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colfileName;
        private DevExpress.XtraGrid.Columns.GridColumn colArchivo_correo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodMensajeId;
    }
}