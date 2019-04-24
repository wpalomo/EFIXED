namespace MailEfirm.Controls
{
    partial class UC_Cuenta_Configuracion
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.groupBoxInfosesion = new System.Windows.Forms.GroupBox();
            this.groupBoxServidor = new System.Windows.Forms.GroupBox();
            this.groupBoxInfoUsuario = new System.Windows.Forms.GroupBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtSuNombre = new System.Windows.Forms.TextBox();
            this.txtdirecioncorreoElectronico = new System.Windows.Forms.TextBox();
            this.labelDireccioncoreeo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTipoCenta = new System.Windows.Forms.Label();
            this.cmbtipoCuenta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelPrincipal.SuspendLayout();
            this.groupBoxServidor.SuspendLayout();
            this.groupBoxInfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtipoCuenta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(745, 25);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.groupBoxInfosesion);
            this.panelPrincipal.Controls.Add(this.groupBoxServidor);
            this.panelPrincipal.Controls.Add(this.groupBoxInfoUsuario);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 25);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(745, 445);
            this.panelPrincipal.TabIndex = 2;
            // 
            // groupBoxInfosesion
            // 
            this.groupBoxInfosesion.Location = new System.Drawing.Point(3, 262);
            this.groupBoxInfosesion.Name = "groupBoxInfosesion";
            this.groupBoxInfosesion.Size = new System.Drawing.Size(736, 100);
            this.groupBoxInfosesion.TabIndex = 5;
            this.groupBoxInfosesion.TabStop = false;
            this.groupBoxInfosesion.Text = "Informacion de Inicio de Sesion";
            // 
            // groupBoxServidor
            // 
            this.groupBoxServidor.Controls.Add(this.cmbtipoCuenta);
            this.groupBoxServidor.Controls.Add(this.lbTipoCenta);
            this.groupBoxServidor.Controls.Add(this.textBox1);
            this.groupBoxServidor.Controls.Add(this.label1);
            this.groupBoxServidor.Controls.Add(this.textBox2);
            this.groupBoxServidor.Controls.Add(this.label2);
            this.groupBoxServidor.Location = new System.Drawing.Point(6, 112);
            this.groupBoxServidor.Name = "groupBoxServidor";
            this.groupBoxServidor.Size = new System.Drawing.Size(739, 100);
            this.groupBoxServidor.TabIndex = 4;
            this.groupBoxServidor.TabStop = false;
            this.groupBoxServidor.Text = "Informacion del Servidor";
            // 
            // groupBoxInfoUsuario
            // 
            this.groupBoxInfoUsuario.Controls.Add(this.txtdirecioncorreoElectronico);
            this.groupBoxInfoUsuario.Controls.Add(this.labelDireccioncoreeo);
            this.groupBoxInfoUsuario.Controls.Add(this.txtSuNombre);
            this.groupBoxInfoUsuario.Controls.Add(this.labelNombre);
            this.groupBoxInfoUsuario.Location = new System.Drawing.Point(0, 3);
            this.groupBoxInfoUsuario.Name = "groupBoxInfoUsuario";
            this.groupBoxInfoUsuario.Size = new System.Drawing.Size(739, 90);
            this.groupBoxInfoUsuario.TabIndex = 3;
            this.groupBoxInfoUsuario.TabStop = false;
            this.groupBoxInfoUsuario.Text = "Informacion sobre el Usuario";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Su nombre";
            // 
            // txtSuNombre
            // 
            this.txtSuNombre.Location = new System.Drawing.Point(168, 25);
            this.txtSuNombre.Name = "txtSuNombre";
            this.txtSuNombre.Size = new System.Drawing.Size(550, 20);
            this.txtSuNombre.TabIndex = 1;
            // 
            // txtdirecioncorreoElectronico
            // 
            this.txtdirecioncorreoElectronico.Location = new System.Drawing.Point(168, 51);
            this.txtdirecioncorreoElectronico.Name = "txtdirecioncorreoElectronico";
            this.txtdirecioncorreoElectronico.Size = new System.Drawing.Size(550, 20);
            this.txtdirecioncorreoElectronico.TabIndex = 3;
            // 
            // labelDireccioncoreeo
            // 
            this.labelDireccioncoreeo.AutoSize = true;
            this.labelDireccioncoreeo.Location = new System.Drawing.Point(6, 51);
            this.labelDireccioncoreeo.Name = "labelDireccioncoreeo";
            this.labelDireccioncoreeo.Size = new System.Drawing.Size(156, 13);
            this.labelDireccioncoreeo.TabIndex = 2;
            this.labelDireccioncoreeo.Text = "Direccion de correo Electronico";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Servidor de correo Saliente [SMTP]";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(532, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Servidor de Correo entrante";
            // 
            // lbTipoCenta
            // 
            this.lbTipoCenta.AutoSize = true;
            this.lbTipoCenta.Location = new System.Drawing.Point(11, 26);
            this.lbTipoCenta.Name = "lbTipoCenta";
            this.lbTipoCenta.Size = new System.Drawing.Size(76, 13);
            this.lbTipoCenta.TabIndex = 8;
            this.lbTipoCenta.Text = "tipo de Cuenta";
            // 
            // cmbtipoCuenta
            // 
            this.cmbtipoCuenta.Location = new System.Drawing.Point(191, 19);
            this.cmbtipoCuenta.Name = "cmbtipoCuenta";
            this.cmbtipoCuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbtipoCuenta.Size = new System.Drawing.Size(532, 20);
            this.cmbtipoCuenta.TabIndex = 9;
            // 
            // UC_Cuenta_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "UC_Cuenta_Configuracion";
            this.Size = new System.Drawing.Size(745, 470);
            this.panelPrincipal.ResumeLayout(false);
            this.groupBoxServidor.ResumeLayout(false);
            this.groupBoxServidor.PerformLayout();
            this.groupBoxInfoUsuario.ResumeLayout(false);
            this.groupBoxInfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtipoCuenta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.GroupBox groupBoxInfosesion;
        private System.Windows.Forms.GroupBox groupBoxServidor;
        private DevExpress.XtraEditors.ComboBoxEdit cmbtipoCuenta;
        private System.Windows.Forms.Label lbTipoCenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxInfoUsuario;
        private System.Windows.Forms.TextBox txtdirecioncorreoElectronico;
        private System.Windows.Forms.Label labelDireccioncoreeo;
        private System.Windows.Forms.TextBox txtSuNombre;
        private System.Windows.Forms.Label labelNombre;
    }
}
