namespace Efirm
{
    partial class UC_Botones_Paginas
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
		////
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Botones_Paginas));
            this.toolStrip_Pagina = new System.Windows.Forms.ToolStrip();
            this.cmb_registros_x_pagina = new System.Windows.Forms.ToolStripComboBox();
            this.lblRegxPag = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_pagina_Ini = new System.Windows.Forms.ToolStripButton();
            this.btn_pagina_ant = new System.Windows.Forms.ToolStripButton();
            this.lblPagina = new System.Windows.Forms.ToolStripLabel();
            this.btn_pagina_sig = new System.Windows.Forms.ToolStripButton();
            this.btn_pagina_fin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Pagina.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_Pagina
            // 
            this.toolStrip_Pagina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmb_registros_x_pagina,
            this.lblRegxPag,
            this.toolStripSeparator1,
            this.btn_pagina_Ini,
            this.btn_pagina_ant,
            this.lblPagina,
            this.btn_pagina_sig,
            this.btn_pagina_fin});
            this.toolStrip_Pagina.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Pagina.Name = "toolStrip_Pagina";
            this.toolStrip_Pagina.Size = new System.Drawing.Size(685, 25);
            this.toolStrip_Pagina.TabIndex = 0;
            this.toolStrip_Pagina.Text = "toolStrip1";
            this.toolStrip_Pagina.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_Pagina_ItemClicked);
            // 
            // cmb_registros_x_pagina
            // 
            this.cmb_registros_x_pagina.Items.AddRange(new object[] {
            "300",
            "600",
            "900"});
            this.cmb_registros_x_pagina.MaxLength = 4;
            this.cmb_registros_x_pagina.Name = "cmb_registros_x_pagina";
            this.cmb_registros_x_pagina.Size = new System.Drawing.Size(121, 25);
            this.cmb_registros_x_pagina.SelectedIndexChanged += new System.EventHandler(this.cmb_registros_x_pagina_SelectedIndexChanged);
            this.cmb_registros_x_pagina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_registros_x_pagina_KeyPress);
            this.cmb_registros_x_pagina.Click += new System.EventHandler(this.cmb_registros_x_pagina_Click);
            this.cmb_registros_x_pagina.TextChanged += new System.EventHandler(this.cmb_registros_x_pagina_TextChanged);
            // 
            // lblRegxPag
            // 
            this.lblRegxPag.Name = "lblRegxPag";
            this.lblRegxPag.Size = new System.Drawing.Size(115, 22);
            this.lblRegxPag.Text = "Registros Por Pagina";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_pagina_Ini
            // 
            this.btn_pagina_Ini.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_pagina_Ini.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagina_Ini.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagina_Ini.Image")));
            this.btn_pagina_Ini.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pagina_Ini.Name = "btn_pagina_Ini";
            this.btn_pagina_Ini.Size = new System.Drawing.Size(35, 22);
            this.btn_pagina_Ini.Text = "|<<";
            this.btn_pagina_Ini.Click += new System.EventHandler(this.btn_pagina_Ini_Click);
            // 
            // btn_pagina_ant
            // 
            this.btn_pagina_ant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_pagina_ant.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagina_ant.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagina_ant.Image")));
            this.btn_pagina_ant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pagina_ant.Name = "btn_pagina_ant";
            this.btn_pagina_ant.Size = new System.Drawing.Size(23, 22);
            this.btn_pagina_ant.Text = "<";
            this.btn_pagina_ant.Click += new System.EventHandler(this.btn_pagina_ant_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(45, 22);
            this.lblPagina.Text = "1/100   ";
            // 
            // btn_pagina_sig
            // 
            this.btn_pagina_sig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_pagina_sig.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagina_sig.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagina_sig.Image")));
            this.btn_pagina_sig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pagina_sig.Name = "btn_pagina_sig";
            this.btn_pagina_sig.Size = new System.Drawing.Size(23, 22);
            this.btn_pagina_sig.Text = ">";
            this.btn_pagina_sig.Click += new System.EventHandler(this.btn_pagina_sig_Click);
            // 
            // btn_pagina_fin
            // 
            this.btn_pagina_fin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_pagina_fin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagina_fin.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagina_fin.Image")));
            this.btn_pagina_fin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pagina_fin.Name = "btn_pagina_fin";
            this.btn_pagina_fin.Size = new System.Drawing.Size(35, 22);
            this.btn_pagina_fin.Text = ">>|";
            this.btn_pagina_fin.Click += new System.EventHandler(this.btn_pagina_fin_Click);
            // 
            // UC_Botones_Paginas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip_Pagina);
            this.Name = "UC_Botones_Paginas";
            this.Size = new System.Drawing.Size(685, 27);
            this.toolStrip_Pagina.ResumeLayout(false);
            this.toolStrip_Pagina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_Pagina;
        private System.Windows.Forms.ToolStripComboBox cmb_registros_x_pagina;
        private System.Windows.Forms.ToolStripLabel lblRegxPag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_pagina_Ini;
        private System.Windows.Forms.ToolStripButton btn_pagina_ant;
        private System.Windows.Forms.ToolStripLabel lblPagina;
        private System.Windows.Forms.ToolStripButton btn_pagina_sig;
        private System.Windows.Forms.ToolStripButton btn_pagina_fin;

    }
}
