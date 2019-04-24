namespace Efirm
{
    partial class frmValidadorFileXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidadorFileXML));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridControlDirectorio = new DevExpress.XtraGrid.GridControl();
            this.gridViewDirectorio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastAccessTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_Valicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmensaje_error_validacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBuscarDirectorio = new System.Windows.Forms.Button();
            this.btn_validar_file_xml = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDirectorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDirectorio)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 461);
            this.panel1.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControlDirectorio);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(792, 361);
            this.panelMain.TabIndex = 4;
            // 
            // gridControlDirectorio
            // 
            this.gridControlDirectorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDirectorio.Location = new System.Drawing.Point(0, 0);
            this.gridControlDirectorio.MainView = this.gridViewDirectorio;
            this.gridControlDirectorio.Name = "gridControlDirectorio";
            this.gridControlDirectorio.Size = new System.Drawing.Size(792, 361);
            this.gridControlDirectorio.TabIndex = 0;
            this.gridControlDirectorio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDirectorio});
            this.gridControlDirectorio.Click += new System.EventHandler(this.gridControlDirectorio_Click);
            // 
            // gridViewDirectorio
            // 
            this.gridViewDirectorio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colName,
            this.colLastAccessTime,
            this.colLength,
            this.colCreationTime,
            this.colExtension,
            this.colEstado_Valicion,
            this.colmensaje_error_validacion,
            this.colFullName});
            this.gridViewDirectorio.GridControl = this.gridControlDirectorio;
            this.gridViewDirectorio.Name = "gridViewDirectorio";
            this.gridViewDirectorio.OptionsBehavior.Editable = false;
            this.gridViewDirectorio.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDirectorio.OptionsView.ShowGroupPanel = false;
            this.gridViewDirectorio.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewDirectorio_RowCellClick);
            this.gridViewDirectorio.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewDirectorio_RowCellStyle);
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "Checked";
            this.colCheck.Name = "colCheck";
            this.colCheck.OptionsColumn.AllowSize = false;
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 20;
            // 
            // colName
            // 
            this.colName.Caption = "Nombre";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 352;
            // 
            // colLastAccessTime
            // 
            this.colLastAccessTime.Caption = "Ultima Modificion";
            this.colLastAccessTime.FieldName = "LastAccessTime";
            this.colLastAccessTime.Name = "colLastAccessTime";
            this.colLastAccessTime.Visible = true;
            this.colLastAccessTime.VisibleIndex = 3;
            this.colLastAccessTime.Width = 49;
            // 
            // colLength
            // 
            this.colLength.Caption = "Tamaño";
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 4;
            this.colLength.Width = 51;
            // 
            // colCreationTime
            // 
            this.colCreationTime.Caption = "CreationTime";
            this.colCreationTime.FieldName = "CreationTime";
            this.colCreationTime.Name = "colCreationTime";
            this.colCreationTime.Visible = true;
            this.colCreationTime.VisibleIndex = 2;
            this.colCreationTime.Width = 55;
            // 
            // colExtension
            // 
            this.colExtension.Caption = "Extension";
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            this.colExtension.Visible = true;
            this.colExtension.VisibleIndex = 5;
            this.colExtension.Width = 38;
            // 
            // colEstado_Valicion
            // 
            this.colEstado_Valicion.Caption = "Estado_Valicion";
            this.colEstado_Valicion.FieldName = "Estado_Valicion";
            this.colEstado_Valicion.Name = "colEstado_Valicion";
            this.colEstado_Valicion.Visible = true;
            this.colEstado_Valicion.VisibleIndex = 6;
            this.colEstado_Valicion.Width = 66;
            // 
            // colmensaje_error_validacion
            // 
            this.colmensaje_error_validacion.Caption = "Mensaje Error";
            this.colmensaje_error_validacion.FieldName = "mensaje_error_validacion";
            this.colmensaje_error_validacion.Name = "colmensaje_error_validacion";
            this.colmensaje_error_validacion.Visible = true;
            this.colmensaje_error_validacion.VisibleIndex = 7;
            this.colmensaje_error_validacion.Width = 111;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "FullName";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 8;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnBuscarDirectorio);
            this.panelTop.Controls.Add(this.btn_validar_file_xml);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txt_ruta);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(792, 100);
            this.panelTop.TabIndex = 3;
            // 
            // btnBuscarDirectorio
            // 
            this.btnBuscarDirectorio.Location = new System.Drawing.Point(711, 22);
            this.btnBuscarDirectorio.Name = "btnBuscarDirectorio";
            this.btnBuscarDirectorio.Size = new System.Drawing.Size(49, 20);
            this.btnBuscarDirectorio.TabIndex = 3;
            this.btnBuscarDirectorio.Text = "....";
            this.btnBuscarDirectorio.UseVisualStyleBackColor = true;
            this.btnBuscarDirectorio.Click += new System.EventHandler(this.btnBuscarDirectorio_Click);
            // 
            // btn_validar_file_xml
            // 
            this.btn_validar_file_xml.Location = new System.Drawing.Point(547, 62);
            this.btn_validar_file_xml.Name = "btn_validar_file_xml";
            this.btn_validar_file_xml.Size = new System.Drawing.Size(158, 32);
            this.btn_validar_file_xml.TabIndex = 2;
            this.btn_validar_file_xml.Text = "Validar Archivos XML";
            this.btn_validar_file_xml.UseVisualStyleBackColor = true;
            this.btn_validar_file_xml.Click += new System.EventHandler(this.btn_validar_file_xml_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directorio a Validar:";
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(159, 22);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(546, 20);
            this.txt_ruta.TabIndex = 1;
            this.txt_ruta.Text = "C:\\Comprobantes electronicos\\Documentos Electronicos Generados\\";
            // 
            // frmValidadorFileXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmValidadorFileXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador File XML";
            this.Load += new System.EventHandler(this.frmValidadorFileXML_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDirectorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDirectorio)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlDirectorio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDirectorio;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btn_validar_file_xml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Button btnBuscarDirectorio;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastAccessTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationTime;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_Valicion;
        private DevExpress.XtraGrid.Columns.GridColumn colmensaje_error_validacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
    }
}