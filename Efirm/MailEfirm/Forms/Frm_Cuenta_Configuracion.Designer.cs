﻿namespace MailEfirm.Forms
{
    partial class Frm_Cuenta_Configuracion
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
            this.uC_Cuenta_Configuracion1 = new MailEfirm.Controls.UC_Cuenta_Mant();
            this.SuspendLayout();
            // 
            // uC_Cuenta_Configuracion1
            // 
            this.uC_Cuenta_Configuracion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Cuenta_Configuracion1.eAccion = eAcciones.Nuevo;
            this.uC_Cuenta_Configuracion1.Location = new System.Drawing.Point(0, 0);
            this.uC_Cuenta_Configuracion1.Name = "uC_Cuenta_Configuracion1";
            this.uC_Cuenta_Configuracion1.Size = new System.Drawing.Size(989, 523);
            this.uC_Cuenta_Configuracion1.TabIndex = 0;
            this.uC_Cuenta_Configuracion1.Load += new System.EventHandler(this.uC_Cuenta_Configuracion1_Load);
            // 
            // Frm_Cuenta_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 523);
            this.Controls.Add(this.uC_Cuenta_Configuracion1);
            this.Name = "Frm_Cuenta_Configuracion";
            this.Text = "Configuracion de Cuenta";
            this.Load += new System.EventHandler(this.Frm_Cuenta_Configuracion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UC_Cuenta_Mant uC_Cuenta_Configuracion1;
    }
}