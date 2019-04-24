
namespace Efirm
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_frecuencia_semanal = new System.Windows.Forms.GroupBox();
            this.chkdomingo = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkmiercoles = new System.Windows.Forms.CheckBox();
            this.chkmartes = new System.Windows.Forms.CheckBox();
            this.chklunes = new System.Windows.Forms.CheckBox();
            this.gb_frecuencia_diaria = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumDias = new System.Windows.Forms.Label();
            this.txt_hora_ocurre_1_vez_a_las = new DevExpress.XtraEditors.TimeEdit();
            this.gb_ocurre_cada = new System.Windows.Forms.GroupBox();
            this.txt_hora_inicia_a = new DevExpress.XtraEditors.TimeEdit();
            this.txt_valor_ocurre_cada = new System.Windows.Forms.NumericUpDown();
            this.cmb_ocurre_cada_tiempo = new System.Windows.Forms.ComboBox();
            this.txt_finaliza_a_las = new DevExpress.XtraEditors.TimeEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opt_ocurre_cada = new System.Windows.Forms.RadioButton();
            this.opt_ocurre_1_vez = new System.Windows.Forms.RadioButton();
            this.cmb_tipo_ejecucion = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.gb_frecuencia_semanal.SuspendLayout();
            this.gb_frecuencia_diaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hora_ocurre_1_vez_a_las.Properties)).BeginInit();
            this.gb_ocurre_cada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hora_inicia_a.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_ocurre_cada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_finaliza_a_las.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 265);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.gb_frecuencia_semanal);
            this.panelMain.Controls.Add(this.gb_frecuencia_diaria);
            this.panelMain.Controls.Add(this.cmb_tipo_ejecucion);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(605, 240);
            this.panelMain.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Ejecucion";
            // 
            // gb_frecuencia_semanal
            // 
            this.gb_frecuencia_semanal.Controls.Add(this.chkdomingo);
            this.gb_frecuencia_semanal.Controls.Add(this.chkSabado);
            this.gb_frecuencia_semanal.Controls.Add(this.chkViernes);
            this.gb_frecuencia_semanal.Controls.Add(this.chkJueves);
            this.gb_frecuencia_semanal.Controls.Add(this.chkmiercoles);
            this.gb_frecuencia_semanal.Controls.Add(this.chkmartes);
            this.gb_frecuencia_semanal.Controls.Add(this.chklunes);
            this.gb_frecuencia_semanal.Location = new System.Drawing.Point(6, 37);
            this.gb_frecuencia_semanal.Name = "gb_frecuencia_semanal";
            this.gb_frecuencia_semanal.Size = new System.Drawing.Size(592, 62);
            this.gb_frecuencia_semanal.TabIndex = 1;
            this.gb_frecuencia_semanal.TabStop = false;
            this.gb_frecuencia_semanal.Text = "Frecuencia Semanal";
            this.gb_frecuencia_semanal.Enter += new System.EventHandler(this.gb_frecuencia_semanal_Enter);
            // 
            // chkdomingo
            // 
            this.chkdomingo.AutoSize = true;
            this.chkdomingo.Checked = true;
            this.chkdomingo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkdomingo.Location = new System.Drawing.Point(109, 43);
            this.chkdomingo.Name = "chkdomingo";
            this.chkdomingo.Size = new System.Drawing.Size(68, 17);
            this.chkdomingo.TabIndex = 6;
            this.chkdomingo.Text = "Domingo";
            this.chkdomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Checked = true;
            this.chkSabado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSabado.Location = new System.Drawing.Point(23, 43);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(63, 17);
            this.chkSabado.TabIndex = 5;
            this.chkSabado.Text = "Sabado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Checked = true;
            this.chkViernes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkViernes.Location = new System.Drawing.Point(403, 19);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(61, 17);
            this.chkViernes.TabIndex = 4;
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Checked = true;
            this.chkJueves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJueves.Location = new System.Drawing.Point(308, 19);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(60, 17);
            this.chkJueves.TabIndex = 3;
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkmiercoles
            // 
            this.chkmiercoles.AutoSize = true;
            this.chkmiercoles.Checked = true;
            this.chkmiercoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkmiercoles.Location = new System.Drawing.Point(202, 19);
            this.chkmiercoles.Name = "chkmiercoles";
            this.chkmiercoles.Size = new System.Drawing.Size(71, 17);
            this.chkmiercoles.TabIndex = 2;
            this.chkmiercoles.Text = "Miercoles";
            this.chkmiercoles.UseVisualStyleBackColor = true;
            // 
            // chkmartes
            // 
            this.chkmartes.AutoSize = true;
            this.chkmartes.Checked = true;
            this.chkmartes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkmartes.Location = new System.Drawing.Point(109, 19);
            this.chkmartes.Name = "chkmartes";
            this.chkmartes.Size = new System.Drawing.Size(58, 17);
            this.chkmartes.TabIndex = 1;
            this.chkmartes.Text = "Martes";
            this.chkmartes.UseVisualStyleBackColor = true;
            // 
            // chklunes
            // 
            this.chklunes.AutoSize = true;
            this.chklunes.Checked = true;
            this.chklunes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chklunes.Location = new System.Drawing.Point(23, 19);
            this.chklunes.Name = "chklunes";
            this.chklunes.Size = new System.Drawing.Size(51, 17);
            this.chklunes.TabIndex = 0;
            this.chklunes.Text = "lunes";
            this.chklunes.UseVisualStyleBackColor = true;
            // 
            // gb_frecuencia_diaria
            // 
            this.gb_frecuencia_diaria.Controls.Add(this.txtDias);
            this.gb_frecuencia_diaria.Controls.Add(this.label4);
            this.gb_frecuencia_diaria.Controls.Add(this.lbNumDias);
            this.gb_frecuencia_diaria.Controls.Add(this.txt_hora_ocurre_1_vez_a_las);
            this.gb_frecuencia_diaria.Controls.Add(this.gb_ocurre_cada);
            this.gb_frecuencia_diaria.Controls.Add(this.opt_ocurre_cada);
            this.gb_frecuencia_diaria.Controls.Add(this.opt_ocurre_1_vez);
            this.gb_frecuencia_diaria.Location = new System.Drawing.Point(6, 105);
            this.gb_frecuencia_diaria.Name = "gb_frecuencia_diaria";
            this.gb_frecuencia_diaria.Size = new System.Drawing.Size(592, 123);
            this.gb_frecuencia_diaria.TabIndex = 2;
            this.gb_frecuencia_diaria.TabStop = false;
            this.gb_frecuencia_diaria.Text = "Frecuencia Diaria";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(447, 27);
            this.txtDias.Mask = "00";
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(67, 20);
            this.txtDias.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dias";
            // 
            // lbNumDias
            // 
            this.lbNumDias.AutoSize = true;
            this.lbNumDias.Location = new System.Drawing.Point(280, 28);
            this.lbNumDias.Name = "lbNumDias";
            this.lbNumDias.Size = new System.Drawing.Size(167, 13);
            this.lbNumDias.TabIndex = 11;
            this.lbNumDias.Text = "Buscar Comprobantes los Ultimos ";
            // 
            // txt_hora_ocurre_1_vez_a_las
            // 
            this.txt_hora_ocurre_1_vez_a_las.EditValue = new System.DateTime(2014, 11, 19, 0, 0, 0, 0);
            this.txt_hora_ocurre_1_vez_a_las.Location = new System.Drawing.Point(145, 25);
            this.txt_hora_ocurre_1_vez_a_las.Name = "txt_hora_ocurre_1_vez_a_las";
            this.txt_hora_ocurre_1_vez_a_las.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_hora_ocurre_1_vez_a_las.Size = new System.Drawing.Size(120, 20);
            this.txt_hora_ocurre_1_vez_a_las.TabIndex = 1;
            // 
            // gb_ocurre_cada
            // 
            this.gb_ocurre_cada.Controls.Add(this.txt_hora_inicia_a);
            this.gb_ocurre_cada.Controls.Add(this.txt_valor_ocurre_cada);
            this.gb_ocurre_cada.Controls.Add(this.cmb_ocurre_cada_tiempo);
            this.gb_ocurre_cada.Controls.Add(this.txt_finaliza_a_las);
            this.gb_ocurre_cada.Controls.Add(this.label1);
            this.gb_ocurre_cada.Controls.Add(this.label2);
            this.gb_ocurre_cada.Location = new System.Drawing.Point(139, 51);
            this.gb_ocurre_cada.Name = "gb_ocurre_cada";
            this.gb_ocurre_cada.Size = new System.Drawing.Size(390, 65);
            this.gb_ocurre_cada.TabIndex = 10;
            this.gb_ocurre_cada.TabStop = false;
            // 
            // txt_hora_inicia_a
            // 
            this.txt_hora_inicia_a.EditValue = new System.DateTime(2014, 11, 19, 8, 30, 0, 0);
            this.txt_hora_inicia_a.Location = new System.Drawing.Point(266, 17);
            this.txt_hora_inicia_a.Name = "txt_hora_inicia_a";
            this.txt_hora_inicia_a.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_hora_inicia_a.Size = new System.Drawing.Size(120, 20);
            this.txt_hora_inicia_a.TabIndex = 9;
            this.txt_hora_inicia_a.EditValueChanged += new System.EventHandler(this.timeEdit1_EditValueChanged);
            // 
            // txt_valor_ocurre_cada
            // 
            this.txt_valor_ocurre_cada.Location = new System.Drawing.Point(6, 19);
            this.txt_valor_ocurre_cada.Name = "txt_valor_ocurre_cada";
            this.txt_valor_ocurre_cada.Size = new System.Drawing.Size(61, 20);
            this.txt_valor_ocurre_cada.TabIndex = 3;
            this.txt_valor_ocurre_cada.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cmb_ocurre_cada_tiempo
            // 
            this.cmb_ocurre_cada_tiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ocurre_cada_tiempo.FormattingEnabled = true;
            this.cmb_ocurre_cada_tiempo.Items.AddRange(new object[] {
            "Hora",
            "Minutos"});
            this.cmb_ocurre_cada_tiempo.Location = new System.Drawing.Point(85, 19);
            this.cmb_ocurre_cada_tiempo.Name = "cmb_ocurre_cada_tiempo";
            this.cmb_ocurre_cada_tiempo.Size = new System.Drawing.Size(88, 21);
            this.cmb_ocurre_cada_tiempo.TabIndex = 4;
            // 
            // txt_finaliza_a_las
            // 
            this.txt_finaliza_a_las.EditValue = new System.DateTime(2014, 11, 19, 18, 30, 0, 0);
            this.txt_finaliza_a_las.Location = new System.Drawing.Point(266, 39);
            this.txt_finaliza_a_las.Name = "txt_finaliza_a_las";
            this.txt_finaliza_a_las.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_finaliza_a_las.Size = new System.Drawing.Size(120, 20);
            this.txt_finaliza_a_las.TabIndex = 8;
            this.txt_finaliza_a_las.EditValueChanged += new System.EventHandler(this.txt_finaliza_a_las_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inicia a las:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Finaliza a las:";
            // 
            // opt_ocurre_cada
            // 
            this.opt_ocurre_cada.AutoSize = true;
            this.opt_ocurre_cada.Location = new System.Drawing.Point(19, 64);
            this.opt_ocurre_cada.Name = "opt_ocurre_cada";
            this.opt_ocurre_cada.Size = new System.Drawing.Size(87, 17);
            this.opt_ocurre_cada.TabIndex = 2;
            this.opt_ocurre_cada.Text = "Ocurre cada:";
            this.opt_ocurre_cada.UseVisualStyleBackColor = true;
            // 
            // opt_ocurre_1_vez
            // 
            this.opt_ocurre_1_vez.AutoSize = true;
            this.opt_ocurre_1_vez.Checked = true;
            this.opt_ocurre_1_vez.Location = new System.Drawing.Point(19, 28);
            this.opt_ocurre_1_vez.Name = "opt_ocurre_1_vez";
            this.opt_ocurre_1_vez.Size = new System.Drawing.Size(126, 17);
            this.opt_ocurre_1_vez.TabIndex = 0;
            this.opt_ocurre_1_vez.TabStop = true;
            this.opt_ocurre_1_vez.Text = "Ocurre una vez a las:";
            this.opt_ocurre_1_vez.UseVisualStyleBackColor = true;
            // 
            // cmb_tipo_ejecucion
            // 
            this.cmb_tipo_ejecucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_ejecucion.FormattingEnabled = true;
            this.cmb_tipo_ejecucion.Items.AddRange(new object[] {
            "Manual",
            "Automatico"});
            this.cmb_tipo_ejecucion.Location = new System.Drawing.Point(103, 6);
            this.cmb_tipo_ejecucion.Name = "cmb_tipo_ejecucion";
            this.cmb_tipo_ejecucion.Size = new System.Drawing.Size(181, 21);
            this.cmb_tipo_ejecucion.TabIndex = 6;
            this.cmb_tipo_ejecucion.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_ejecucion_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGrabar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(605, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(62, 22);
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 265);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConfiguracion";
            this.Text = "CONFIGURACION DE TIEMPO";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.gb_frecuencia_semanal.ResumeLayout(false);
            this.gb_frecuencia_semanal.PerformLayout();
            this.gb_frecuencia_diaria.ResumeLayout(false);
            this.gb_frecuencia_diaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hora_ocurre_1_vez_a_las.Properties)).EndInit();
            this.gb_ocurre_cada.ResumeLayout(false);
            this.gb_ocurre_cada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hora_inicia_a.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_ocurre_cada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_finaliza_a_las.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_frecuencia_semanal;
        private System.Windows.Forms.CheckBox chkdomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkmiercoles;
        private System.Windows.Forms.CheckBox chkmartes;
        private System.Windows.Forms.CheckBox chklunes;
        private System.Windows.Forms.GroupBox gb_frecuencia_diaria;
        private DevExpress.XtraEditors.TimeEdit txt_hora_ocurre_1_vez_a_las;
        private System.Windows.Forms.GroupBox gb_ocurre_cada;
        private System.Windows.Forms.NumericUpDown txt_valor_ocurre_cada;
        private System.Windows.Forms.ComboBox cmb_ocurre_cada_tiempo;
        private DevExpress.XtraEditors.TimeEdit txt_finaliza_a_las;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton opt_ocurre_cada;
        private System.Windows.Forms.RadioButton opt_ocurre_1_vez;
        private System.Windows.Forms.ComboBox cmb_tipo_ejecucion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private DevExpress.XtraEditors.TimeEdit txt_hora_inicia_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNumDias;
        private System.Windows.Forms.MaskedTextBox txtDias;


    }
}