namespace MailEfirm.Controls
{
    partial class UC_Botones_Paginas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Botones_Paginas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblbusqueda = new System.Windows.Forms.ToolStripLabel();
            this.txtBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_registros_x_pagina = new System.Windows.Forms.ToolStripComboBox();
            this.lblRegxPag = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_pagIni = new System.Windows.Forms.ToolStripButton();
            this.btn_pagAnt = new System.Windows.Forms.ToolStripButton();
            this.lblPagina = new System.Windows.Forms.ToolStripLabel();
            this.btn_PagSgt = new System.Windows.Forms.ToolStripButton();
            this.btn_PagFin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblbusqueda,
            this.txtBusqueda,
            this.toolStripSeparator2,
            this.cmb_registros_x_pagina,
            this.lblRegxPag,
            this.toolStripSeparator1,
            this.btn_pagIni,
            this.btn_pagAnt,
            this.lblPagina,
            this.btn_PagSgt,
            this.btn_PagFin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(950, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(116, 22);
            this.lblbusqueda.Text = "Búsqueda Avanzada:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(300, 25);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmb_registros_x_pagina
            // 
            this.cmb_registros_x_pagina.Items.AddRange(new object[] {
            "300",
            "600",
            "900"});
            this.cmb_registros_x_pagina.Name = "cmb_registros_x_pagina";
            this.cmb_registros_x_pagina.Size = new System.Drawing.Size(75, 25);
            this.cmb_registros_x_pagina.SelectedIndexChanged += new System.EventHandler(this.cmb_registros_x_pagina_SelectedIndexChanged);
            this.cmb_registros_x_pagina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_registros_x_pagina_KeyPress);
            this.cmb_registros_x_pagina.TextChanged += new System.EventHandler(this.cmb_registros_x_pagina_TextChanged);
            // 
            // lblRegxPag
            // 
            this.lblRegxPag.Name = "lblRegxPag";
            this.lblRegxPag.Size = new System.Drawing.Size(115, 22);
            this.lblRegxPag.Text = "Registros por Página";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_pagIni
            // 
            this.btn_pagIni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_pagIni.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagIni.Image")));
            this.btn_pagIni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pagIni.Name = "btn_pagIni";
            this.btn_pagIni.Size = new System.Drawing.Size(30, 22);
            this.btn_pagIni.Text = "|<<";
            this.btn_pagIni.Click += new System.EventHandler(this.btn_pagIni_Click);
            // 
            // btn_pagAnt
            // 
            this.btn_pagAnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_pagAnt.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagAnt.Image")));
            this.btn_pagAnt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pagAnt.Name = "btn_pagAnt";
            this.btn_pagAnt.Size = new System.Drawing.Size(23, 22);
            this.btn_pagAnt.Text = "<";
            this.btn_pagAnt.Click += new System.EventHandler(this.btn_pagAnt_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(45, 22);
            this.lblPagina.Text = "1/100   ";
            // 
            // btn_PagSgt
            // 
            this.btn_PagSgt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_PagSgt.Image = ((System.Drawing.Image)(resources.GetObject("btn_PagSgt.Image")));
            this.btn_PagSgt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PagSgt.Name = "btn_PagSgt";
            this.btn_PagSgt.Size = new System.Drawing.Size(23, 22);
            this.btn_PagSgt.Text = ">";
            this.btn_PagSgt.Click += new System.EventHandler(this.btn_PagSgt_Click);
            // 
            // btn_PagFin
            // 
            this.btn_PagFin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_PagFin.Image = ((System.Drawing.Image)(resources.GetObject("btn_PagFin.Image")));
            this.btn_PagFin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PagFin.Name = "btn_PagFin";
            this.btn_PagFin.Size = new System.Drawing.Size(30, 22);
            this.btn_PagFin.Text = ">>|";
            this.btn_PagFin.Click += new System.EventHandler(this.btn_PagFin_Click);
            // 
            // UC_Botones_Paginas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_Botones_Paginas";
            this.Size = new System.Drawing.Size(950, 27);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cmb_registros_x_pagina;
        private System.Windows.Forms.ToolStripLabel lblRegxPag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_pagIni;
        private System.Windows.Forms.ToolStripButton btn_pagAnt;
        private System.Windows.Forms.ToolStripLabel lblPagina;
        private System.Windows.Forms.ToolStripButton btn_PagSgt;
        private System.Windows.Forms.ToolStripButton btn_PagFin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblbusqueda;
        private System.Windows.Forms.ToolStripTextBox txtBusqueda;

    }
}
