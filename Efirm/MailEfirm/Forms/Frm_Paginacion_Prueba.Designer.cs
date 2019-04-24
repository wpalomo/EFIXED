namespace MailEfirm.Forms
{
    partial class Frm_Paginacion_Prueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Paginacion_Prueba));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btndescargarcorreo = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.pgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControlVisor_Mail_Buzon_Entrada = new DevExpress.XtraGrid.GridControl();
            this.gridViewVisorMail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColImportancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ColIcono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAdjunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ColAsunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColLeido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTexto_Mensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMosTrar_icono_Ride = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mostrar_icono_Ride = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colMosTrar_icono_xml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MosTrar_icono_xml = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArchivo_correo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodMensajeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVisor_Mail_Buzon_Entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVisorMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_icono_Ride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MosTrar_icono_xml)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btndescargarcorreo,
            this.btnCancel,
            this.pgBar,
            this.lblStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(911, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btndescargarcorreo
            // 
            this.btndescargarcorreo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btndescargarcorreo.Image = ((System.Drawing.Image)(resources.GetObject("btndescargarcorreo.Image")));
            this.btndescargarcorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndescargarcorreo.Name = "btndescargarcorreo";
            this.btndescargarcorreo.Size = new System.Drawing.Size(107, 22);
            this.btndescargarcorreo.Text = "Descargar Correos";
            this.btndescargarcorreo.Click += new System.EventHandler(this.btndescargarcorreo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 22);
            this.btnCancel.Text = "Cancelar Descarga";
            // 
            // pgBar
            // 
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(100, 22);
            // 
            // lblStatus
            // 
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 22);
            this.lblStatus.Text = "                                     ";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 25);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(911, 380);
            this.splitContainerControl1.SplitterPosition = 231;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xtraScrollableControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 231);
            this.panel1.TabIndex = 0;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.gridControlVisor_Mail_Buzon_Entrada);
            this.xtraScrollableControl1.Controls.Add(this.toolStrip2);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(911, 231);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // gridControlVisor_Mail_Buzon_Entrada
            // 
            this.gridControlVisor_Mail_Buzon_Entrada.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlVisor_Mail_Buzon_Entrada.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlVisor_Mail_Buzon_Entrada.Location = new System.Drawing.Point(0, 0);
            this.gridControlVisor_Mail_Buzon_Entrada.MainView = this.gridViewVisorMail;
            this.gridControlVisor_Mail_Buzon_Entrada.Name = "gridControlVisor_Mail_Buzon_Entrada";
            this.gridControlVisor_Mail_Buzon_Entrada.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.Mostrar_icono_Ride,
            this.MosTrar_icono_xml});
            this.gridControlVisor_Mail_Buzon_Entrada.Size = new System.Drawing.Size(911, 206);
            this.gridControlVisor_Mail_Buzon_Entrada.TabIndex = 2;
            this.gridControlVisor_Mail_Buzon_Entrada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVisorMail});
            // 
            // gridViewVisorMail
            // 
            this.gridViewVisorMail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColImportancia,
            this.ColIcono,
            this.ColAdjunto,
            this.ColAsunto,
            this.ColDe,
            this.ColLeido,
            this.colcheck,
            this.colTexto_Mensaje,
            this.colMosTrar_icono_Ride,
            this.colMosTrar_icono_xml,
            this.colFecha,
            this.colfileName,
            this.colArchivo_correo,
            this.colcodMensajeId,
            this.colIdMensaje});
            this.gridViewVisorMail.GridControl = this.gridControlVisor_Mail_Buzon_Entrada;
            this.gridViewVisorMail.Name = "gridViewVisorMail";
            this.gridViewVisorMail.OptionsView.ShowAutoFilterRow = true;
            this.gridViewVisorMail.OptionsView.ShowGroupPanel = false;
            // 
            // ColImportancia
            // 
            this.ColImportancia.Caption = ".";
            this.ColImportancia.ColumnEdit = this.repositoryItemImageComboBox2;
            this.ColImportancia.FieldName = "Prioridad";
            this.ColImportancia.ImageIndex = 0;
            this.ColImportancia.Name = "ColImportancia";
            this.ColImportancia.OptionsColumn.AllowSize = false;
            this.ColImportancia.Width = 20;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // ColIcono
            // 
            this.ColIcono.ImageIndex = 1;
            this.ColIcono.Name = "ColIcono";
            this.ColIcono.OptionsColumn.ShowCaption = false;
            this.ColIcono.Width = 34;
            // 
            // ColAdjunto
            // 
            this.ColAdjunto.ColumnEdit = this.repositoryItemImageComboBox1;
            this.ColAdjunto.FieldName = "Tiene_Adjunto";
            this.ColAdjunto.ImageIndex = 2;
            this.ColAdjunto.Name = "ColAdjunto";
            this.ColAdjunto.OptionsColumn.AllowEdit = false;
            this.ColAdjunto.OptionsColumn.AllowSize = false;
            this.ColAdjunto.OptionsColumn.ShowCaption = false;
            this.ColAdjunto.Visible = true;
            this.ColAdjunto.VisibleIndex = 0;
            this.ColAdjunto.Width = 20;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 4)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // ColAsunto
            // 
            this.ColAsunto.Caption = "Asunto";
            this.ColAsunto.FieldName = "Asunto";
            this.ColAsunto.Name = "ColAsunto";
            this.ColAsunto.OptionsColumn.AllowEdit = false;
            this.ColAsunto.Visible = true;
            this.ColAsunto.VisibleIndex = 2;
            this.ColAsunto.Width = 464;
            // 
            // ColDe
            // 
            this.ColDe.Caption = "De";
            this.ColDe.FieldName = "Para";
            this.ColDe.Name = "ColDe";
            this.ColDe.Visible = true;
            this.ColDe.VisibleIndex = 1;
            this.ColDe.Width = 479;
            // 
            // ColLeido
            // 
            this.ColLeido.ColumnEdit = this.repositoryItemImageComboBox3;
            this.ColLeido.FieldName = "Leido";
            this.ColLeido.ImageIndex = 3;
            this.ColLeido.Name = "ColLeido";
            this.ColLeido.OptionsColumn.AllowSize = false;
            this.ColLeido.OptionsColumn.ShowCaption = false;
            this.ColLeido.Width = 20;
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", false, 3)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // colcheck
            // 
            this.colcheck.Caption = "*";
            this.colcheck.FieldName = "Checked";
            this.colcheck.Name = "colcheck";
            this.colcheck.OptionsColumn.AllowSize = false;
            this.colcheck.OptionsColumn.ShowCaption = false;
            this.colcheck.Width = 20;
            // 
            // colTexto_Mensaje
            // 
            this.colTexto_Mensaje.Caption = "Mensaje";
            this.colTexto_Mensaje.FieldName = "Texto_mensaje";
            this.colTexto_Mensaje.Name = "colTexto_Mensaje";
            this.colTexto_Mensaje.Width = 795;
            // 
            // colMosTrar_icono_Ride
            // 
            this.colMosTrar_icono_Ride.Caption = "Ride";
            this.colMosTrar_icono_Ride.ColumnEdit = this.Mostrar_icono_Ride;
            this.colMosTrar_icono_Ride.FieldName = "MosTrar_icono_Ride";
            this.colMosTrar_icono_Ride.Name = "colMosTrar_icono_Ride";
            this.colMosTrar_icono_Ride.OptionsColumn.AllowEdit = false;
            this.colMosTrar_icono_Ride.Width = 59;
            // 
            // Mostrar_icono_Ride
            // 
            this.Mostrar_icono_Ride.AutoHeight = false;
            this.Mostrar_icono_Ride.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Mostrar_icono_Ride.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 7)});
            this.Mostrar_icono_Ride.Name = "Mostrar_icono_Ride";
            // 
            // colMosTrar_icono_xml
            // 
            this.colMosTrar_icono_xml.Caption = "xml";
            this.colMosTrar_icono_xml.ColumnEdit = this.MosTrar_icono_xml;
            this.colMosTrar_icono_xml.FieldName = "MosTrar_icono_xml";
            this.colMosTrar_icono_xml.Name = "colMosTrar_icono_xml";
            this.colMosTrar_icono_xml.OptionsColumn.AllowEdit = false;
            this.colMosTrar_icono_xml.Width = 63;
            // 
            // MosTrar_icono_xml
            // 
            this.MosTrar_icono_xml.AutoHeight = false;
            this.MosTrar_icono_xml.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MosTrar_icono_xml.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 8)});
            this.MosTrar_icono_xml.Name = "MosTrar_icono_xml";
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            this.colFecha.Width = 217;
            // 
            // colfileName
            // 
            this.colfileName.FieldName = "fileName";
            this.colfileName.Name = "colfileName";
            // 
            // colArchivo_correo
            // 
            this.colArchivo_correo.FieldName = "Archivo_correo";
            this.colArchivo_correo.Name = "colArchivo_correo";
            // 
            // colcodMensajeId
            // 
            this.colcodMensajeId.FieldName = "codMensajeId";
            this.colcodMensajeId.Name = "colcodMensajeId";
            // 
            // colIdMensaje
            // 
            this.colIdMensaje.FieldName = "IdMensaje";
            this.colIdMensaje.Name = "colIdMensaje";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 206);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(911, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(27, 22);
            this.toolStripButton1.Text = "<<";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "<";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = " Pagina ";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = ">";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(27, 22);
            this.toolStripButton4.Text = ">>";
            // 
            // Frm_Paginacion_Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 405);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Paginacion_Prueba";
            this.Text = "Frm_Paginacion_Prueba";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVisor_Mail_Buzon_Entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVisorMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_icono_Ride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MosTrar_icono_xml)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private DevExpress.XtraGrid.GridControl gridControlVisor_Mail_Buzon_Entrada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVisorMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColImportancia;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIcono;
        private DevExpress.XtraGrid.Columns.GridColumn ColAdjunto;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn ColAsunto;
        private DevExpress.XtraGrid.Columns.GridColumn ColDe;
        private DevExpress.XtraGrid.Columns.GridColumn ColLeido;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private DevExpress.XtraGrid.Columns.GridColumn colTexto_Mensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colMosTrar_icono_Ride;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox Mostrar_icono_Ride;
        private DevExpress.XtraGrid.Columns.GridColumn colMosTrar_icono_xml;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox MosTrar_icono_xml;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colfileName;
        private DevExpress.XtraGrid.Columns.GridColumn colArchivo_correo;
        private DevExpress.XtraGrid.Columns.GridColumn colcodMensajeId;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMensaje;
        private System.Windows.Forms.ToolStripButton btndescargarcorreo;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripProgressBar pgBar;
        private System.Windows.Forms.ToolStripLabel lblStatus;

    }
}