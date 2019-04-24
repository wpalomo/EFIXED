namespace MailEfirm.Forms
{
    partial class Frm_Enviar_y_Recibir_Cuentas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl_tareas = new System.Windows.Forms.TabControl();
            this.tabPageErrores = new System.Windows.Forms.TabPage();
            this.gridControl_errores = new DevExpress.XtraGrid.GridControl();
            this.gridView_errores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pgb_estado_envio = new System.Windows.Forms.ProgressBar();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_detener = new System.Windows.Forms.Button();
            this.backgroundWorkerEnvio_y_Recep = new System.ComponentModel.BackgroundWorker();
            this.timerSensorHiloEnviar = new System.Windows.Forms.Timer();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timerCerrarForm = new System.Windows.Forms.Timer();
            this.groupBox2.SuspendLayout();
            this.tabControl_tareas.SuspendLayout();
            this.tabPageErrores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_errores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_errores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl_tareas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tabControl_tareas
            // 
            this.tabControl_tareas.Controls.Add(this.tabPageErrores);
            this.tabControl_tareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_tareas.Location = new System.Drawing.Point(3, 16);
            this.tabControl_tareas.Name = "tabControl_tareas";
            this.tabControl_tareas.SelectedIndex = 0;
            this.tabControl_tareas.Size = new System.Drawing.Size(675, 203);
            this.tabControl_tareas.TabIndex = 0;
            // 
            // tabPageErrores
            // 
            this.tabPageErrores.Controls.Add(this.gridControl_errores);
            this.tabPageErrores.Location = new System.Drawing.Point(4, 22);
            this.tabPageErrores.Name = "tabPageErrores";
            this.tabPageErrores.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageErrores.Size = new System.Drawing.Size(667, 177);
            this.tabPageErrores.TabIndex = 1;
            this.tabPageErrores.Text = "Errores";
            this.tabPageErrores.UseVisualStyleBackColor = true;
            // 
            // gridControl_errores
            // 
            this.gridControl_errores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_errores.Location = new System.Drawing.Point(3, 3);
            this.gridControl_errores.MainView = this.gridView_errores;
            this.gridControl_errores.Name = "gridControl_errores";
            this.gridControl_errores.Size = new System.Drawing.Size(661, 171);
            this.gridControl_errores.TabIndex = 0;
            this.gridControl_errores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_errores,
            this.gridView1});
            // 
            // gridView_errores
            // 
            this.gridView_errores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.coldetalle,
            this.colsfecha,
            this.Estado,
            this.colTipoError});
            this.gridView_errores.GridControl = this.gridControl_errores;
            this.gridView_errores.Name = "gridView_errores";
            this.gridView_errores.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 59;
            // 
            // coldetalle
            // 
            this.coldetalle.Caption = "detalle";
            this.coldetalle.FieldName = "detalle";
            this.coldetalle.Name = "coldetalle";
            this.coldetalle.Visible = true;
            this.coldetalle.VisibleIndex = 1;
            this.coldetalle.Width = 544;
            // 
            // colsfecha
            // 
            this.colsfecha.Caption = "sfecha";
            this.colsfecha.FieldName = "sfecha";
            this.colsfecha.Name = "colsfecha";
            this.colsfecha.Visible = true;
            this.colsfecha.VisibleIndex = 2;
            this.colsfecha.Width = 159;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            this.Estado.Width = 208;
            // 
            // colTipoError
            // 
            this.colTipoError.Caption = "TipoError";
            this.colTipoError.FieldName = "TipoError";
            this.colTipoError.Name = "colTipoError";
            this.colTipoError.Visible = true;
            this.colTipoError.VisibleIndex = 4;
            this.colTipoError.Width = 210;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_errores;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pgb_estado_envio);
            this.groupBox1.Controls.Add(this.lbl_mensaje);
            this.groupBox1.Controls.Add(this.btn_cerrar);
            this.groupBox1.Controls.Add(this.btn_detener);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pgb_estado_envio
            // 
            this.pgb_estado_envio.Location = new System.Drawing.Point(12, 48);
            this.pgb_estado_envio.Name = "pgb_estado_envio";
            this.pgb_estado_envio.Size = new System.Drawing.Size(536, 23);
            this.pgb_estado_envio.TabIndex = 5;
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(7, 19);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(117, 13);
            this.lbl_mensaje.TabIndex = 2;
            this.lbl_mensaje.Text = "Enviando y Recibiendo";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(554, 48);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(113, 23);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_detener
            // 
            this.btn_detener.Location = new System.Drawing.Point(554, 19);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(113, 23);
            this.btn_detener.TabIndex = 0;
            this.btn_detener.Text = "Cancelar Todo";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Visible = false;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // backgroundWorkerEnvio_y_Recep
            // 
            this.backgroundWorkerEnvio_y_Recep.WorkerReportsProgress = true;
            this.backgroundWorkerEnvio_y_Recep.WorkerSupportsCancellation = true;
            this.backgroundWorkerEnvio_y_Recep.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerEnvio_y_Recep_DoWork);
            this.backgroundWorkerEnvio_y_Recep.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerEnvio_y_Recep_ProgressChanged);
            this.backgroundWorkerEnvio_y_Recep.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerEnvio_y_Recep_RunWorkerCompleted);
            // 
            // timerSensorHiloEnviar
            // 
            this.timerSensorHiloEnviar.Tick += new System.EventHandler(this.timerSensorHiloEnviar_Tick);
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // timerCerrarForm
            // 
            this.timerCerrarForm.Interval = 1000;
            this.timerCerrarForm.Tick += new System.EventHandler(this.timerCerrarForm_Tick);
            // 
            // Frm_Enviar_y_Recibir_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 304);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Enviar_y_Recibir_Cuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar y Recibir";
            this.Load += new System.EventHandler(this.Frm_Enviar_y_Recibir_Cuentas_Load);
            this.groupBox2.ResumeLayout(false);
            this.tabControl_tareas.ResumeLayout(false);
            this.tabPageErrores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_errores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_errores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_detener;
        private System.ComponentModel.BackgroundWorker backgroundWorkerEnvio_y_Recep;
        private System.Windows.Forms.ProgressBar pgb_estado_envio;
        private System.Windows.Forms.Timer timerSensorHiloEnviar;
        private System.Windows.Forms.TabControl tabControl_tareas;
        private System.Windows.Forms.TabPage tabPageErrores;
        private DevExpress.XtraGrid.GridControl gridControl_errores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_errores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn coldetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colsfecha;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoError;
        private System.Windows.Forms.Timer timerCerrarForm;
    }
}