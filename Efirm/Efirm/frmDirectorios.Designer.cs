namespace Efirm
{
    partial class frmDirectorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectorios));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtComprobantesRepositorio = new DevExpress.XtraEditors.ButtonEdit();
            this.txtPathRoot = new DevExpress.XtraEditors.ButtonEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtComprobantesValidos = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCertificados = new DevExpress.XtraEditors.ButtonEdit();
            this.txtComprobantes_con_errores = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobantesRepositorio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathRoot.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobantesValidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCertificados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobantes_con_errores.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 65);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(168, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Ruta Repositorio de Comprobantes";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Ruta Principal";
            // 
            // txtComprobantesRepositorio
            // 
            this.txtComprobantesRepositorio.Location = new System.Drawing.Point(185, 62);
            this.txtComprobantesRepositorio.Name = "txtComprobantesRepositorio";
            this.txtComprobantesRepositorio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtComprobantesRepositorio.Size = new System.Drawing.Size(494, 20);
            this.txtComprobantesRepositorio.TabIndex = 11;
            this.txtComprobantesRepositorio.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SeleccionarRuta);
            // 
            // txtPathRoot
            // 
            this.txtPathRoot.Location = new System.Drawing.Point(185, 39);
            this.txtPathRoot.Name = "txtPathRoot";
            this.txtPathRoot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPathRoot.Size = new System.Drawing.Size(494, 20);
            this.txtPathRoot.TabIndex = 12;
            this.txtPathRoot.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SeleccionarRuta);
            this.txtPathRoot.EditValueChanged += new System.EventHandler(this.txtPathRoot_EditValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 91);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(137, 13);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Rutas Comprobantes Validos";
            // 
            // txtComprobantesValidos
            // 
            this.txtComprobantesValidos.Location = new System.Drawing.Point(185, 88);
            this.txtComprobantesValidos.Name = "txtComprobantesValidos";
            this.txtComprobantesValidos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtComprobantesValidos.Size = new System.Drawing.Size(494, 20);
            this.txtComprobantesValidos.TabIndex = 26;
            this.txtComprobantesValidos.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SeleccionarRuta);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 113);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 13);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Ruta Certificados";
            // 
            // txtCertificados
            // 
            this.txtCertificados.Location = new System.Drawing.Point(185, 110);
            this.txtCertificados.Name = "txtCertificados";
            this.txtCertificados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCertificados.Size = new System.Drawing.Size(494, 20);
            this.txtCertificados.TabIndex = 28;
            this.txtCertificados.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SeleccionarRuta);
            // 
            // txtComprobantes_con_errores
            // 
            this.txtComprobantes_con_errores.Location = new System.Drawing.Point(185, 161);
            this.txtComprobantes_con_errores.Name = "txtComprobantes_con_errores";
            this.txtComprobantes_con_errores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtComprobantes_con_errores.Size = new System.Drawing.Size(494, 20);
            this.txtComprobantes_con_errores.TabIndex = 30;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(161, 13);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Rutas Comprobantes Con Errores";
            // 
            // frmDirectorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 219);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtComprobantes_con_errores);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCertificados);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtComprobantesValidos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtComprobantesRepositorio);
            this.Controls.Add(this.txtPathRoot);
            this.Name = "frmDirectorios";
            this.Text = "Directorios";
            this.Load += new System.EventHandler(this.frmDirectorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobantesRepositorio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathRoot.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobantesValidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCertificados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobantes_con_errores.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtComprobantesRepositorio;
        private DevExpress.XtraEditors.ButtonEdit txtPathRoot;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ButtonEdit txtComprobantesValidos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtCertificados;
        private DevExpress.XtraEditors.ButtonEdit txtComprobantes_con_errores;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}