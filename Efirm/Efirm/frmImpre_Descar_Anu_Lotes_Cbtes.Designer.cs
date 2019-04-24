namespace Efirm
{
    partial class frmImpre_Descar_Anu_Lotes_Cbtes
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Impr_descar_cbtes_Lote1 = new Efirm.UC_Impr_descar_cbtes_Lote();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1232, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Impr_descar_cbtes_Lote1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 451);
            this.panel1.TabIndex = 2;
            // 
            // uC_Impr_descar_cbtes_Lote1
            // 
            this.uC_Impr_descar_cbtes_Lote1.AutoScroll = true;
            this.uC_Impr_descar_cbtes_Lote1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Impr_descar_cbtes_Lote1.Location = new System.Drawing.Point(0, 0);
            this.uC_Impr_descar_cbtes_Lote1.Name = "uC_Impr_descar_cbtes_Lote1";
            this.uC_Impr_descar_cbtes_Lote1.Size = new System.Drawing.Size(1232, 451);
            this.uC_Impr_descar_cbtes_Lote1.TabIndex = 0;
            this.uC_Impr_descar_cbtes_Lote1.Load += new System.EventHandler(this.uC_Impr_descar_cbtes_Lote1_Load);
            // 
            // frmImpre_Descar_Anu_Lotes_Cbtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmImpre_Descar_Anu_Lotes_Cbtes";
            this.Text = "Impresion/Descarga/Anulacion de Cbtes en Lotes";
            this.Load += new System.EventHandler(this.frmImpre_Descar_Anu_Lotes_Cbtes_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private UC_Impr_descar_cbtes_Lote uC_Impr_descar_cbtes_Lote1;
    }
}