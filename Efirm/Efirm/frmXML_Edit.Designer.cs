namespace Efirm
{
    partial class frmXML_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXML_Edit));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.barra_estado = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_guardar_db = new System.Windows.Forms.ToolStripButton();
            this.btn_guardar_como_xml = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar_db,
            this.toolStripSeparator1,
            this.btn_guardar_como_xml,
            this.toolStripSeparator2,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(630, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // barra_estado
            // 
            this.barra_estado.Location = new System.Drawing.Point(0, 373);
            this.barra_estado.Name = "barra_estado";
            this.barra_estado.Size = new System.Drawing.Size(630, 22);
            this.barra_estado.TabIndex = 1;
            this.barra_estado.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 348);
            this.panel1.TabIndex = 2;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(630, 348);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // btn_guardar_db
            // 
            this.btn_guardar_db.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar_db.Image")));
            this.btn_guardar_db.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar_db.Name = "btn_guardar_db";
            this.btn_guardar_db.Size = new System.Drawing.Size(161, 22);
            this.btn_guardar_db.Text = "Guardar en Base de Datos";
            // 
            // btn_guardar_como_xml
            // 
            this.btn_guardar_como_xml.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar_como_xml.Image")));
            this.btn_guardar_como_xml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar_como_xml.Name = "btn_guardar_como_xml";
            this.btn_guardar_como_xml.Size = new System.Drawing.Size(130, 22);
            this.btn_guardar_como_xml.Text = "Guardar como XML";
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmXML_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barra_estado);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmXML_Edit";
            this.Text = "XML edit";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip barra_estado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripButton btn_guardar_db;
        private System.Windows.Forms.ToolStripButton btn_guardar_como_xml;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}