namespace Efirm
{
    partial class frmLogError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogError));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnt_eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlLog = new DevExpress.XtraGrid.GridControl();
            this.gridViewLog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPantalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsamble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Trans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_refrescar,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.bnt_eliminar,
            this.toolStripLabel2,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_refrescar.Image")));
            this.btn_refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(98, 22);
            this.btn_refrescar.Text = "Refrescar Log";
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(124, 22);
            this.toolStripLabel1.Text = "                                       ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bnt_eliminar.Image")));
            this.bnt_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnt_eliminar.Name = "bnt_eliminar";
            this.bnt_eliminar.Size = new System.Drawing.Size(93, 22);
            this.bnt_eliminar.Text = "Eliminar Log";
            this.bnt_eliminar.Click += new System.EventHandler(this.bnt_eliminar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel2.Text = "                     ";
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 477);
            this.panel1.TabIndex = 1;
            // 
            // gridControlLog
            // 
            this.gridControlLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLog.Location = new System.Drawing.Point(0, 0);
            this.gridControlLog.MainView = this.gridViewLog;
            this.gridControlLog.Name = "gridControlLog";
            this.gridControlLog.Size = new System.Drawing.Size(889, 477);
            this.gridControlLog.TabIndex = 0;
            this.gridControlLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLog});
            this.gridControlLog.Click += new System.EventHandler(this.gridControlLog_Click);
            // 
            // gridViewLog
            // 
            this.gridViewLog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetalle,
            this.colTipo,
            this.colClase,
            this.colPantalla,
            this.colAsamble,
            this.colUsuario,
            this.colIp,
            this.colPC,
            this.colFecha_Trans,
            this.colId,
            this.colsFecha});
            this.gridViewLog.GridControl = this.gridControlLog;
            this.gridViewLog.Name = "gridViewLog";
            this.gridViewLog.OptionsFind.AlwaysVisible = true;
            this.gridViewLog.OptionsView.ShowAutoFilterRow = true;
            this.gridViewLog.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewLog_RowCellClick);
            // 
            // colDetalle
            // 
            this.colDetalle.Caption = "Detalle";
            this.colDetalle.FieldName = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.OptionsColumn.AllowEdit = false;
            this.colDetalle.Visible = true;
            this.colDetalle.VisibleIndex = 0;
            this.colDetalle.Width = 404;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 78;
            // 
            // colClase
            // 
            this.colClase.Caption = "Clase";
            this.colClase.FieldName = "Clase";
            this.colClase.Name = "colClase";
            this.colClase.Visible = true;
            this.colClase.VisibleIndex = 2;
            this.colClase.Width = 78;
            // 
            // colPantalla
            // 
            this.colPantalla.Caption = "Pantalla";
            this.colPantalla.FieldName = "Pantalla";
            this.colPantalla.Name = "colPantalla";
            this.colPantalla.Visible = true;
            this.colPantalla.VisibleIndex = 4;
            this.colPantalla.Width = 73;
            // 
            // colAsamble
            // 
            this.colAsamble.Caption = "Asamble";
            this.colAsamble.FieldName = "Asamble";
            this.colAsamble.Name = "colAsamble";
            this.colAsamble.Visible = true;
            this.colAsamble.VisibleIndex = 5;
            this.colAsamble.Width = 73;
            // 
            // colUsuario
            // 
            this.colUsuario.Caption = "Usuario";
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 6;
            this.colUsuario.Width = 73;
            // 
            // colIp
            // 
            this.colIp.Caption = "Ip";
            this.colIp.FieldName = "Ip";
            this.colIp.Name = "colIp";
            this.colIp.Visible = true;
            this.colIp.VisibleIndex = 7;
            this.colIp.Width = 73;
            // 
            // colPC
            // 
            this.colPC.Caption = "PC";
            this.colPC.FieldName = "PC";
            this.colPC.Name = "colPC";
            this.colPC.Visible = true;
            this.colPC.VisibleIndex = 8;
            this.colPC.Width = 73;
            // 
            // colFecha_Trans
            // 
            this.colFecha_Trans.Caption = "Fecha_Trans";
            this.colFecha_Trans.FieldName = "Fecha_Trans";
            this.colFecha_Trans.Name = "colFecha_Trans";
            this.colFecha_Trans.Visible = true;
            this.colFecha_Trans.VisibleIndex = 3;
            this.colFecha_Trans.Width = 146;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 9;
            this.colId.Width = 38;
            // 
            // colsFecha
            // 
            this.colsFecha.FieldName = "sFecha";
            this.colsFecha.Name = "colsFecha";
            this.colsFecha.Visible = true;
            this.colsFecha.VisibleIndex = 10;
            this.colsFecha.Width = 71;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(889, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmLogError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 502);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLogError";
            this.Text = "frmLogError";
            this.Load += new System.EventHandler(this.frmLogError_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btn_refrescar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colClase;
        private DevExpress.XtraGrid.Columns.GridColumn colPantalla;
        private DevExpress.XtraGrid.Columns.GridColumn colAsamble;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIp;
        private DevExpress.XtraGrid.Columns.GridColumn colPC;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Trans;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colsFecha;
        private System.Windows.Forms.ToolStripButton bnt_eliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}