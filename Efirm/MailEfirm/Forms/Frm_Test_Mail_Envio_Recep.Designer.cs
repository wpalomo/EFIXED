namespace MailEfirm.Forms
{
    partial class Frm_Test_Mail_Envio_Recep
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_detener = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl_tareas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControl_tareas_realizadas = new DevExpress.XtraGrid.GridControl();
            this.gridView_tareas_realizadas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoRespuesta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControl_errores = new DevExpress.XtraGrid.GridControl();
            this.gridView_errores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timerSensorHilo_enviar_mail = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl_tareas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_tareas_realizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tareas_realizadas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_errores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_errores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressPanel1);
            this.groupBox1.Controls.Add(this.lbl_mensaje);
            this.groupBox1.Controls.Add(this.btn_cerrar);
            this.groupBox1.Controls.Add(this.btn_detener);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Caption = "Por Favor Espere";
            this.progressPanel1.Description = "Procesando";
            this.progressPanel1.Location = new System.Drawing.Point(366, 19);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(163, 42);
            this.progressPanel1.TabIndex = 3;
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(7, 19);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(353, 13);
            this.lbl_mensaje.TabIndex = 2;
            this.lbl_mensaje.Text = "Pruebas completadas correctamente. Haga click en cerrar para continuar";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(554, 48);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_detener
            // 
            this.btn_detener.Location = new System.Drawing.Point(554, 19);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(75, 23);
            this.btn_detener.TabIndex = 0;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl_tareas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tabControl_tareas
            // 
            this.tabControl_tareas.Controls.Add(this.tabPage1);
            this.tabControl_tareas.Controls.Add(this.tabPage2);
            this.tabControl_tareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_tareas.Location = new System.Drawing.Point(3, 16);
            this.tabControl_tareas.Name = "tabControl_tareas";
            this.tabControl_tareas.SelectedIndex = 0;
            this.tabControl_tareas.Size = new System.Drawing.Size(646, 234);
            this.tabControl_tareas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControl_tareas_realizadas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tareas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControl_tareas_realizadas
            // 
            this.gridControl_tareas_realizadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_tareas_realizadas.Location = new System.Drawing.Point(3, 3);
            this.gridControl_tareas_realizadas.MainView = this.gridView_tareas_realizadas;
            this.gridControl_tareas_realizadas.Name = "gridControl_tareas_realizadas";
            this.gridControl_tareas_realizadas.Size = new System.Drawing.Size(632, 202);
            this.gridControl_tareas_realizadas.TabIndex = 0;
            this.gridControl_tareas_realizadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_tareas_realizadas});
            // 
            // gridView_tareas_realizadas
            // 
            this.gridView_tareas_realizadas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.coldetalle,
            this.colsfecha,
            this.colTipoError,
            this.colTipoRespuesta});
            this.gridView_tareas_realizadas.GridControl = this.gridControl_tareas_realizadas;
            this.gridView_tareas_realizadas.Name = "gridView_tareas_realizadas";
            this.gridView_tareas_realizadas.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 32;
            // 
            // coldetalle
            // 
            this.coldetalle.Caption = "detalle";
            this.coldetalle.FieldName = "detalle";
            this.coldetalle.Name = "coldetalle";
            this.coldetalle.Visible = true;
            this.coldetalle.VisibleIndex = 1;
            this.coldetalle.Width = 692;
            // 
            // colsfecha
            // 
            this.colsfecha.Caption = "sfecha";
            this.colsfecha.FieldName = "sfecha";
            this.colsfecha.Name = "colsfecha";
            this.colsfecha.Visible = true;
            this.colsfecha.VisibleIndex = 2;
            this.colsfecha.Width = 138;
            // 
            // colTipoError
            // 
            this.colTipoError.Caption = "TipoError";
            this.colTipoError.FieldName = "TipoError";
            this.colTipoError.Name = "colTipoError";
            this.colTipoError.Visible = true;
            this.colTipoError.VisibleIndex = 3;
            this.colTipoError.Width = 132;
            // 
            // colTipoRespuesta
            // 
            this.colTipoRespuesta.Caption = "TipoRespuesta";
            this.colTipoRespuesta.FieldName = "TipoRespuesta";
            this.colTipoRespuesta.Name = "colTipoRespuesta";
            this.colTipoRespuesta.Visible = true;
            this.colTipoRespuesta.VisibleIndex = 4;
            this.colTipoRespuesta.Width = 186;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControl_errores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Errores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControl_errores
            // 
            this.gridControl_errores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_errores.Location = new System.Drawing.Point(3, 3);
            this.gridControl_errores.MainView = this.gridView_errores;
            this.gridControl_errores.Name = "gridControl_errores";
            this.gridControl_errores.Size = new System.Drawing.Size(632, 202);
            this.gridControl_errores.TabIndex = 0;
            this.gridControl_errores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_errores});
            // 
            // gridView_errores
            // 
            this.gridView_errores.GridControl = this.gridControl_errores;
            this.gridView_errores.Name = "gridView_errores";
            this.gridView_errores.OptionsView.ShowGroupPanel = false;
            // 
            // Frm_Test_Mail_Envio_Recep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Test_Mail_Envio_Recep";
            this.Text = "Test Envio Recepcion";
            this.Load += new System.EventHandler(this.Frm_Test_Mail_Envio_Recep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl_tareas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_tareas_realizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tareas_realizadas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_errores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_errores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl_tareas;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControl_tareas_realizadas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_tareas_realizadas;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControl_errores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_errores;
        private System.Windows.Forms.Label lbl_mensaje;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn coldetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colsfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoError;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoRespuesta;
        private System.Windows.Forms.Timer timerSensorHilo_enviar_mail;
    }
}