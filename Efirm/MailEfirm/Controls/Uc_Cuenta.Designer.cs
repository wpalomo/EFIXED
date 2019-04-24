namespace MailEfirm.Controls
{
    partial class Uc_Cuenta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelPrincipalconfigCta = new System.Windows.Forms.Panel();
            this.PanelInferio = new System.Windows.Forms.Panel();
            this.Panelsuperio = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConfiguracionCuenta = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbNobreusuario = new System.Windows.Forms.Label();
            this.lbDireccionCorreo = new System.Windows.Forms.Label();
            this.txtnombreUsuario = new System.Windows.Forms.TextBox();
            this.txtDireccioncorreo = new System.Windows.Forms.TextBox();
            this.grpInfoUsuario = new System.Windows.Forms.GroupBox();
            this.grpInformaciondeServidor = new System.Windows.Forms.GroupBox();
            this.txtServidorCorreoEntrante = new System.Windows.Forms.TextBox();
            this.txtServidorCorreosaliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTipoCuenta = new System.Windows.Forms.Label();
            this.CmbtipoCuenta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.grpInformacioninicioSesion = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lnNomUsuario = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelPrincipalconfigCta.SuspendLayout();
            this.PanelInferio.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConfiguracionCuenta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpInfoUsuario.SuspendLayout();
            this.grpInformaciondeServidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbtipoCuenta.Properties)).BeginInit();
            this.grpInformacioninicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipalconfigCta
            // 
            this.PanelPrincipalconfigCta.Controls.Add(this.PanelInferio);
            this.PanelPrincipalconfigCta.Controls.Add(this.Panelsuperio);
            this.PanelPrincipalconfigCta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipalconfigCta.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipalconfigCta.Name = "PanelPrincipalconfigCta";
            this.PanelPrincipalconfigCta.Size = new System.Drawing.Size(768, 417);
            this.PanelPrincipalconfigCta.TabIndex = 0;
            // 
            // PanelInferio
            // 
            this.PanelInferio.Controls.Add(this.tabControl1);
            this.PanelInferio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInferio.Location = new System.Drawing.Point(0, 48);
            this.PanelInferio.Name = "PanelInferio";
            this.PanelInferio.Size = new System.Drawing.Size(768, 369);
            this.PanelInferio.TabIndex = 1;
            // 
            // Panelsuperio
            // 
            this.Panelsuperio.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelsuperio.Location = new System.Drawing.Point(0, 0);
            this.Panelsuperio.Name = "Panelsuperio";
            this.Panelsuperio.Size = new System.Drawing.Size(768, 48);
            this.Panelsuperio.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConfiguracionCuenta);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageConfiguracionCuenta
            // 
            this.tabPageConfiguracionCuenta.Controls.Add(this.gridControl1);
            this.tabPageConfiguracionCuenta.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguracionCuenta.Name = "tabPageConfiguracionCuenta";
            this.tabPageConfiguracionCuenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguracionCuenta.Size = new System.Drawing.Size(760, 343);
            this.tabPageConfiguracionCuenta.TabIndex = 0;
            this.tabPageConfiguracionCuenta.Text = "Cuentas";
            this.tabPageConfiguracionCuenta.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpInformacioninicioSesion);
            this.tabPage2.Controls.Add(this.grpInformaciondeServidor);
            this.tabPage2.Controls.Add(this.grpInfoUsuario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuracion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbNobreusuario
            // 
            this.lbNobreusuario.AutoSize = true;
            this.lbNobreusuario.Location = new System.Drawing.Point(2, 23);
            this.lbNobreusuario.Name = "lbNobreusuario";
            this.lbNobreusuario.Size = new System.Drawing.Size(59, 13);
            this.lbNobreusuario.TabIndex = 0;
            this.lbNobreusuario.Text = "Su Nombre";
            // 
            // lbDireccionCorreo
            // 
            this.lbDireccionCorreo.AutoSize = true;
            this.lbDireccionCorreo.Location = new System.Drawing.Point(2, 48);
            this.lbDireccionCorreo.Name = "lbDireccionCorreo";
            this.lbDireccionCorreo.Size = new System.Drawing.Size(156, 13);
            this.lbDireccionCorreo.TabIndex = 1;
            this.lbDireccionCorreo.Text = "Direccion de Correo Electronico";
            // 
            // txtnombreUsuario
            // 
            this.txtnombreUsuario.Location = new System.Drawing.Point(210, 20);
            this.txtnombreUsuario.Name = "txtnombreUsuario";
            this.txtnombreUsuario.Size = new System.Drawing.Size(517, 21);
            this.txtnombreUsuario.TabIndex = 2;
            // 
            // txtDireccioncorreo
            // 
            this.txtDireccioncorreo.Location = new System.Drawing.Point(210, 47);
            this.txtDireccioncorreo.Name = "txtDireccioncorreo";
            this.txtDireccioncorreo.Size = new System.Drawing.Size(517, 21);
            this.txtDireccioncorreo.TabIndex = 3;
            // 
            // grpInfoUsuario
            // 
            this.grpInfoUsuario.Controls.Add(this.txtnombreUsuario);
            this.grpInfoUsuario.Controls.Add(this.txtDireccioncorreo);
            this.grpInfoUsuario.Controls.Add(this.lbNobreusuario);
            this.grpInfoUsuario.Controls.Add(this.lbDireccionCorreo);
            this.grpInfoUsuario.Location = new System.Drawing.Point(3, 6);
            this.grpInfoUsuario.Name = "grpInfoUsuario";
            this.grpInfoUsuario.Size = new System.Drawing.Size(751, 82);
            this.grpInfoUsuario.TabIndex = 4;
            this.grpInfoUsuario.TabStop = false;
            this.grpInfoUsuario.Text = "Informacion Sobre Usuario";
            // 
            // grpInformaciondeServidor
            // 
            this.grpInformaciondeServidor.Controls.Add(this.CmbtipoCuenta);
            this.grpInformaciondeServidor.Controls.Add(this.lbTipoCuenta);
            this.grpInformaciondeServidor.Controls.Add(this.txtServidorCorreoEntrante);
            this.grpInformaciondeServidor.Controls.Add(this.txtServidorCorreosaliente);
            this.grpInformaciondeServidor.Controls.Add(this.label1);
            this.grpInformaciondeServidor.Controls.Add(this.label2);
            this.grpInformaciondeServidor.Location = new System.Drawing.Point(3, 94);
            this.grpInformaciondeServidor.Name = "grpInformaciondeServidor";
            this.grpInformaciondeServidor.Size = new System.Drawing.Size(751, 105);
            this.grpInformaciondeServidor.TabIndex = 5;
            this.grpInformaciondeServidor.TabStop = false;
            this.grpInformaciondeServidor.Text = "Informacion del Servidor";
            // 
            // txtServidorCorreoEntrante
            // 
            this.txtServidorCorreoEntrante.Location = new System.Drawing.Point(208, 45);
            this.txtServidorCorreoEntrante.Name = "txtServidorCorreoEntrante";
            this.txtServidorCorreoEntrante.Size = new System.Drawing.Size(517, 21);
            this.txtServidorCorreoEntrante.TabIndex = 2;
            // 
            // txtServidorCorreosaliente
            // 
            this.txtServidorCorreosaliente.Location = new System.Drawing.Point(208, 72);
            this.txtServidorCorreosaliente.Name = "txtServidorCorreosaliente";
            this.txtServidorCorreosaliente.Size = new System.Drawing.Size(517, 21);
            this.txtServidorCorreosaliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor de correo entrante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servidor de Correo Saliente [SMTP]";
            // 
            // lbTipoCuenta
            // 
            this.lbTipoCuenta.AutoSize = true;
            this.lbTipoCuenta.Location = new System.Drawing.Point(6, 27);
            this.lbTipoCuenta.Name = "lbTipoCuenta";
            this.lbTipoCuenta.Size = new System.Drawing.Size(80, 13);
            this.lbTipoCuenta.TabIndex = 4;
            this.lbTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // CmbtipoCuenta
            // 
            this.CmbtipoCuenta.Location = new System.Drawing.Point(208, 20);
            this.CmbtipoCuenta.Name = "CmbtipoCuenta";
            this.CmbtipoCuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbtipoCuenta.Size = new System.Drawing.Size(276, 20);
            this.CmbtipoCuenta.TabIndex = 5;
            // 
            // grpInformacioninicioSesion
            // 
            this.grpInformacioninicioSesion.Controls.Add(this.textBox1);
            this.grpInformacioninicioSesion.Controls.Add(this.textBox2);
            this.grpInformacioninicioSesion.Controls.Add(this.lnNomUsuario);
            this.grpInformacioninicioSesion.Controls.Add(this.lbContraseña);
            this.grpInformacioninicioSesion.Location = new System.Drawing.Point(6, 205);
            this.grpInformacioninicioSesion.Name = "grpInformacioninicioSesion";
            this.grpInformacioninicioSesion.Size = new System.Drawing.Size(751, 79);
            this.grpInformacioninicioSesion.TabIndex = 6;
            this.grpInformacioninicioSesion.TabStop = false;
            this.grpInformacioninicioSesion.Text = "Informacion de Inicio de Sesion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(517, 21);
            this.textBox2.TabIndex = 3;
            // 
            // lnNomUsuario
            // 
            this.lnNomUsuario.AutoSize = true;
            this.lnNomUsuario.Location = new System.Drawing.Point(3, 23);
            this.lnNomUsuario.Name = "lnNomUsuario";
            this.lnNomUsuario.Size = new System.Drawing.Size(98, 13);
            this.lnNomUsuario.TabIndex = 0;
            this.lnNomUsuario.Text = "Nombre de Usuario";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Location = new System.Drawing.Point(3, 50);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(63, 13);
            this.lbContraseña.TabIndex = 1;
            this.lbContraseña.Text = "Contraseña";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(754, 337);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Uc_Configuracion_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelPrincipalconfigCta);
            this.Name = "Uc_Configuracion_Cuenta";
            this.Size = new System.Drawing.Size(768, 417);
            this.PanelPrincipalconfigCta.ResumeLayout(false);
            this.PanelInferio.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfiguracionCuenta.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpInfoUsuario.ResumeLayout(false);
            this.grpInfoUsuario.PerformLayout();
            this.grpInformaciondeServidor.ResumeLayout(false);
            this.grpInformaciondeServidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbtipoCuenta.Properties)).EndInit();
            this.grpInformacioninicioSesion.ResumeLayout(false);
            this.grpInformacioninicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipalconfigCta;
        private System.Windows.Forms.Panel PanelInferio;
        private System.Windows.Forms.Panel Panelsuperio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConfiguracionCuenta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpInformacioninicioSesion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lnNomUsuario;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.GroupBox grpInformaciondeServidor;
        private DevExpress.XtraEditors.ComboBoxEdit CmbtipoCuenta;
        private System.Windows.Forms.Label lbTipoCuenta;
        private System.Windows.Forms.TextBox txtServidorCorreoEntrante;
        private System.Windows.Forms.TextBox txtServidorCorreosaliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpInfoUsuario;
        private System.Windows.Forms.TextBox txtnombreUsuario;
        private System.Windows.Forms.TextBox txtDireccioncorreo;
        private System.Windows.Forms.Label lbNobreusuario;
        private System.Windows.Forms.Label lbDireccionCorreo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
