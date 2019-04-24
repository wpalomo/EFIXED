namespace MailEfirm.Controls
{
    partial class UC_Cuentas_Menu
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
            this.panelPrincipalMenucuenta = new System.Windows.Forms.Panel();
            this.tabControlCuentasConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uC_Ceuntas1 = new MailEfirm.Controls.UC_Cuentas();
            this.uC_Cuenta_Configuracion1 = new MailEfirm.Controls.UC_Cuenta_Mant();
            this.panelPrincipalMenucuenta.SuspendLayout();
            this.tabControlCuentasConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipalMenucuenta
            // 
            this.panelPrincipalMenucuenta.Controls.Add(this.tabControlCuentasConfig);
            this.panelPrincipalMenucuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipalMenucuenta.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipalMenucuenta.Name = "panelPrincipalMenucuenta";
            this.panelPrincipalMenucuenta.Size = new System.Drawing.Size(781, 427);
            this.panelPrincipalMenucuenta.TabIndex = 0;
            // 
            // tabControlCuentasConfig
            // 
            this.tabControlCuentasConfig.Controls.Add(this.tabPage1);
            this.tabControlCuentasConfig.Controls.Add(this.tabPage2);
            this.tabControlCuentasConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCuentasConfig.Location = new System.Drawing.Point(0, 0);
            this.tabControlCuentasConfig.Name = "tabControlCuentasConfig";
            this.tabControlCuentasConfig.SelectedIndex = 0;
            this.tabControlCuentasConfig.Size = new System.Drawing.Size(781, 427);
            this.tabControlCuentasConfig.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uC_Ceuntas1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuentas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uC_Cuenta_Configuracion1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuracion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uC_Ceuntas1
            // 
            this.uC_Ceuntas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Ceuntas1.Location = new System.Drawing.Point(3, 3);
            this.uC_Ceuntas1.Name = "uC_Ceuntas1";
            this.uC_Ceuntas1.Size = new System.Drawing.Size(767, 395);
            this.uC_Ceuntas1.TabIndex = 0;
            this.uC_Ceuntas1.Load += new System.EventHandler(this.uC_Ceuntas1_Load);
            // 
            // uC_Cuenta_Configuracion1
            // 
            this.uC_Cuenta_Configuracion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Cuenta_Configuracion1.Location = new System.Drawing.Point(3, 3);
            this.uC_Cuenta_Configuracion1.Name = "uC_Cuenta_Configuracion1";
            this.uC_Cuenta_Configuracion1.Size = new System.Drawing.Size(767, 395);
            this.uC_Cuenta_Configuracion1.TabIndex = 0;
            // 
            // UC_Cuentas_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipalMenucuenta);
            this.Name = "UC_Cuentas_Menu";
            this.Size = new System.Drawing.Size(781, 427);
            this.panelPrincipalMenucuenta.ResumeLayout(false);
            this.tabControlCuentasConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipalMenucuenta;
        private System.Windows.Forms.TabControl tabControlCuentasConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UC_Cuentas uC_Ceuntas1;
        private UC_Cuenta_Mant uC_Cuenta_Configuracion1;
    }
}
