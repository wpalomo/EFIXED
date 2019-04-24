
namespace Efirm
{
    partial class FrmCargarDatosEx
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
            this.chkSelecTodos = new System.Windows.Forms.CheckBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtRutaOrigen = new DevExpress.XtraEditors.ButtonEdit();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gridControlCbtes = new DevExpress.XtraGrid.GridControl();
            this.gridViewCbtes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pb_barra_estado = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gridControlXml = new DevExpress.XtraGrid.GridControl();
            this.colNomArch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColNomFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTmamaño = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.txtrutaDestino = new DevExpress.XtraEditors.ButtonEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_generar_xml = new System.Windows.Forms.Button();
            this.fileSystemWatcherExcel = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbtes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbtes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_barra_estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNomArch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtrutaDestino.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSelecTodos
            // 
            this.chkSelecTodos.AutoSize = true;
            this.chkSelecTodos.Location = new System.Drawing.Point(15, 85);
            this.chkSelecTodos.Name = "chkSelecTodos";
            this.chkSelecTodos.Size = new System.Drawing.Size(115, 17);
            this.chkSelecTodos.TabIndex = 12;
            this.chkSelecTodos.Text = "Seleccionar Todos";
            this.chkSelecTodos.UseVisualStyleBackColor = true;
            this.chkSelecTodos.CheckedChanged += new System.EventHandler(this.chkSelecTodos_CheckedChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCargar.Location = new System.Drawing.Point(503, 36);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(84, 63);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtRutaOrigen
            // 
            this.txtRutaOrigen.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRutaOrigen.EditValue = "";
            this.txtRutaOrigen.Location = new System.Drawing.Point(3, 16);
            this.txtRutaOrigen.Name = "txtRutaOrigen";
            this.txtRutaOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtRutaOrigen.Size = new System.Drawing.Size(584, 20);
            this.txtRutaOrigen.TabIndex = 8;
            this.txtRutaOrigen.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtRutaOrigen_ButtonClick);
            this.txtRutaOrigen.EditValueChanged += new System.EventHandler(this.txtRutaOrigen_EditValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(94, 63);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(94, 38);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 498);
            this.splitContainer1.SplitterDistance = 590;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridControlCbtes);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(590, 396);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Registro Excel Disponibles";
            // 
            // gridControlCbtes
            // 
            this.gridControlCbtes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCbtes.Location = new System.Drawing.Point(3, 16);
            this.gridControlCbtes.MainView = this.gridViewCbtes;
            this.gridControlCbtes.Name = "gridControlCbtes";
            this.gridControlCbtes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.pb_barra_estado});
            this.gridControlCbtes.Size = new System.Drawing.Size(584, 377);
            this.gridControlCbtes.TabIndex = 2;
            this.gridControlCbtes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCbtes,
            this.gridView4,
            this.gridView6,
            this.gridView8,
            this.gridView9,
            this.gridView1});
            // 
            // gridViewCbtes
            // 
            this.gridViewCbtes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdComprobante,
            this.colFecha,
            this.colTipoCbte,
            this.colObservacion,
            this.colchecked});
            this.gridViewCbtes.GridControl = this.gridControlCbtes;
            this.gridViewCbtes.Name = "gridViewCbtes";
            // 
            // colIdComprobante
            // 
            this.colIdComprobante.Caption = "IdComprobante ";
            this.colIdComprobante.FieldName = "IdComprobante";
            this.colIdComprobante.Name = "colIdComprobante";
            this.colIdComprobante.Visible = true;
            this.colIdComprobante.VisibleIndex = 1;
            this.colIdComprobante.Width = 142;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha ";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 100;
            // 
            // colTipoCbte
            // 
            this.colTipoCbte.Caption = "TipoCbte";
            this.colTipoCbte.FieldName = "TipoCbte";
            this.colTipoCbte.Name = "colTipoCbte";
            this.colTipoCbte.Visible = true;
            this.colTipoCbte.VisibleIndex = 3;
            this.colTipoCbte.Width = 114;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observacion";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 4;
            this.colObservacion.Width = 125;
            // 
            // colchecked
            // 
            this.colchecked.Caption = "*";
            this.colchecked.FieldName = "Checked";
            this.colchecked.Name = "colchecked";
            this.colchecked.Visible = true;
            this.colchecked.VisibleIndex = 0;
            this.colchecked.Width = 52;
            // 
            // pb_barra_estado
            // 
            this.pb_barra_estado.Name = "pb_barra_estado";
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControlCbtes;
            this.gridView4.Name = "gridView4";
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gridControlCbtes;
            this.gridView6.Name = "gridView6";
            // 
            // gridView8
            // 
            this.gridView8.GridControl = this.gridControlCbtes;
            this.gridView8.Name = "gridView8";
            // 
            // gridView9
            // 
            this.gridView9.GridControl = this.gridControlCbtes;
            this.gridView9.Name = "gridView9";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlCbtes;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.chkSelecTodos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRutaOrigen);
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 102);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ruta de Origen";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gridControlXml);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(72, 73);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(351, 425);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Archivos Aml Disponibles";
            // 
            // gridControlXml
            // 
            this.gridControlXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlXml.Location = new System.Drawing.Point(3, 16);
            this.gridControlXml.MainView = this.colNomArch;
            this.gridControlXml.Name = "gridControlXml";
            this.gridControlXml.Size = new System.Drawing.Size(345, 406);
            this.gridControlXml.TabIndex = 1;
            this.gridControlXml.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.colNomArch,
            this.gridView3,
            this.gridView5,
            this.gridView7,
            this.gridView10,
            this.gridView2});
            // 
            // colNomArch
            // 
            this.colNomArch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColNomFile,
            this.ColRuta,
            this.ColTmamaño,
            this.ColDoc});
            this.colNomArch.GridControl = this.gridControlXml;
            this.colNomArch.Name = "colNomArch";
            // 
            // ColNomFile
            // 
            this.ColNomFile.Caption = "Nombre";
            this.ColNomFile.FieldName = "Name";
            this.ColNomFile.Name = "ColNomFile";
            this.ColNomFile.Visible = true;
            this.ColNomFile.VisibleIndex = 0;
            // 
            // ColRuta
            // 
            this.ColRuta.Caption = "Ruta";
            this.ColRuta.FieldName = "Directory";
            this.ColRuta.Name = "ColRuta";
            this.ColRuta.Visible = true;
            this.ColRuta.VisibleIndex = 1;
            // 
            // ColTmamaño
            // 
            this.ColTmamaño.Caption = "Tamaño";
            this.ColTmamaño.FieldName = "Length";
            this.ColTmamaño.Name = "ColTmamaño";
            this.ColTmamaño.Visible = true;
            this.ColTmamaño.VisibleIndex = 2;
            // 
            // ColDoc
            // 
            this.ColDoc.Caption = "Existe";
            this.ColDoc.FieldName = "Exists";
            this.ColDoc.Name = "ColDoc";
            this.ColDoc.Visible = true;
            this.ColDoc.VisibleIndex = 3;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlXml;
            this.gridView3.Name = "gridView3";
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridControlXml;
            this.gridView5.Name = "gridView5";
            // 
            // gridView7
            // 
            this.gridView7.GridControl = this.gridControlXml;
            this.gridView7.Name = "gridView7";
            // 
            // gridView10
            // 
            this.gridView10.GridControl = this.gridControlXml;
            this.gridView10.Name = "gridView10";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlXml;
            this.gridView2.Name = "gridView2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_refrescar);
            this.groupBox4.Controls.Add(this.txtrutaDestino);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(72, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 73);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ruta para los xml";
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_refrescar.Image = global::LoadEfirm.Properties.Resources.reload;
            this.btn_refrescar.Location = new System.Drawing.Point(278, 36);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(70, 34);
            this.btn_refrescar.TabIndex = 12;
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // txtrutaDestino
            // 
            this.txtrutaDestino.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtrutaDestino.EditValue = "\\\\192.168.10.250\\Repositorio de Comprobantes\\";
            this.txtrutaDestino.Location = new System.Drawing.Point(3, 16);
            this.txtrutaDestino.Name = "txtrutaDestino";
            this.txtrutaDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtrutaDestino.Size = new System.Drawing.Size(345, 20);
            this.txtrutaDestino.TabIndex = 11;
            this.txtrutaDestino.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtrutaDestino_ButtonClick);
            this.txtrutaDestino.EditValueChanged += new System.EventHandler(this.txtrutaDestino_EditValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_generar_xml);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(72, 498);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btn_generar_xml
            // 
            this.btn_generar_xml.Image = global::LoadEfirm.Properties.Resources.bt_ff;
            this.btn_generar_xml.Location = new System.Drawing.Point(2, 111);
            this.btn_generar_xml.Name = "btn_generar_xml";
            this.btn_generar_xml.Size = new System.Drawing.Size(69, 37);
            this.btn_generar_xml.TabIndex = 1;
            this.btn_generar_xml.UseVisualStyleBackColor = true;
            this.btn_generar_xml.Click += new System.EventHandler(this.btn_generar_xml_Click);
            // 
            // fileSystemWatcherExcel
            // 
            this.fileSystemWatcherExcel.EnableRaisingEvents = true;
            this.fileSystemWatcherExcel.SynchronizingObject = this;
            this.fileSystemWatcherExcel.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcherExcel_Changed);
            this.fileSystemWatcherExcel.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcherExcel_Deleted);
            // 
            // FrmCargarDatosEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 498);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmCargarDatosEx";
            this.Text = "FrmCargarDatosEx";
            this.Load += new System.EventHandler(this.FrmCargarDatosEx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaOrigen.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbtes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbtes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_barra_estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNomArch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtrutaDestino.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.IO.FileSystemWatcher fileSystemWatcherExcel;
        private System.Windows.Forms.Button btn_generar_xml;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ButtonEdit txtRutaOrigen;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.CheckBox chkSelecTodos;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraGrid.GridControl gridControlCbtes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCbtes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colchecked;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar pb_barra_estado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraGrid.GridControl gridControlXml;
        private DevExpress.XtraGrid.Views.Grid.GridView colNomArch;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomFile;
        private DevExpress.XtraGrid.Columns.GridColumn ColRuta;
        private DevExpress.XtraGrid.Columns.GridColumn ColTmamaño;
        private DevExpress.XtraGrid.Columns.GridColumn ColDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.ButtonEdit txtrutaDestino;
    }
}