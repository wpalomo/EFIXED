namespace Efirm
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_Bajar_Correo = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.gridControl_Buzon_Entrada = new DevExpress.XtraGrid.GridControl();
            this.gridView_Buzon_Entrada = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.icEditors = new DevExpress.Utils.ImageCollection();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiene_Adjunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTexto_mensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMosTrar_icono_Ride = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMosTrar_icono_xml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImagen_Prioridad = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.cmbImage_Leido = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.cmbImagen_Tiene_Adjunto = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.cmbImagen_Ride = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.cmbImagen_xml = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colIdMensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Buzon_Entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Buzon_Entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Prioridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImage_Leido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Tiene_Adjunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Ride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_xml)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Bajar_Correo
            // 
            this.btn_Bajar_Correo.Location = new System.Drawing.Point(24, 12);
            this.btn_Bajar_Correo.Name = "btn_Bajar_Correo";
            this.btn_Bajar_Correo.Size = new System.Drawing.Size(75, 23);
            this.btn_Bajar_Correo.TabIndex = 0;
            this.btn_Bajar_Correo.Text = "Bajar Correo";
            this.btn_Bajar_Correo.UseVisualStyleBackColor = true;
            this.btn_Bajar_Correo.Click += new System.EventHandler(this.btn_Bajar_Correo_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(142, 12);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 1;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // gridControl_Buzon_Entrada
            // 
            this.gridControl_Buzon_Entrada.Location = new System.Drawing.Point(12, 86);
            this.gridControl_Buzon_Entrada.MainView = this.gridView_Buzon_Entrada;
            this.gridControl_Buzon_Entrada.Name = "gridControl_Buzon_Entrada";
            this.gridControl_Buzon_Entrada.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbImagen_Prioridad,
            this.cmbImage_Leido,
            this.cmbImagen_Tiene_Adjunto,
            this.cmbImagen_Ride,
            this.cmbImagen_xml});
            this.gridControl_Buzon_Entrada.Size = new System.Drawing.Size(990, 291);
            this.gridControl_Buzon_Entrada.TabIndex = 2;
            this.gridControl_Buzon_Entrada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Buzon_Entrada});
            // 
            // gridView_Buzon_Entrada
            // 
            this.gridView_Buzon_Entrada.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChecked,
            this.colPrioridad,
            this.colLeido,
            this.colTiene_Adjunto,
            this.colPara,
            this.colAsunto,
            this.colTexto_mensaje,
            this.colMosTrar_icono_Ride,
            this.colMosTrar_icono_xml,
            this.colIdMensaje});
            this.gridView_Buzon_Entrada.GridControl = this.gridControl_Buzon_Entrada;
            this.gridView_Buzon_Entrada.Name = "gridView_Buzon_Entrada";
            this.gridView_Buzon_Entrada.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_Buzon_Entrada.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Buzon_Entrada.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_Buzon_Entrada_RowCellClick);
            // 
            // icEditors
            // 
            this.icEditors.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icEditors.ImageStream")));
            this.icEditors.Images.SetKeyName(0, "1417488454_pdf.png");
            this.icEditors.Images.SetKeyName(1, "xml_ok.png");
            this.icEditors.Images.SetKeyName(2, "AttachmentObject_16x16.png");
            this.icEditors.Images.SetKeyName(3, "Contact_Us.png");
            this.icEditors.Images.SetKeyName(4, "High16x16.png");
            this.icEditors.Images.SetKeyName(5, "Low16x16.png");
            this.icEditors.Images.SetKeyName(6, "sendE.png");
            // 
            // colChecked
            // 
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.OptionsColumn.AllowSize = false;
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            this.colChecked.Width = 26;
            // 
            // colPrioridad
            // 
            this.colPrioridad.Caption = ".";
            this.colPrioridad.ColumnEdit = this.cmbImagen_Prioridad;
            this.colPrioridad.FieldName = "Prioridad";
            this.colPrioridad.Name = "colPrioridad";
            this.colPrioridad.OptionsColumn.AllowSize = false;
            this.colPrioridad.Visible = true;
            this.colPrioridad.VisibleIndex = 1;
            this.colPrioridad.Width = 26;
            // 
            // colLeido
            // 
            this.colLeido.ColumnEdit = this.cmbImage_Leido;
            this.colLeido.FieldName = "Leido";
            this.colLeido.Name = "colLeido";
            this.colLeido.OptionsColumn.AllowSize = false;
            this.colLeido.Visible = true;
            this.colLeido.VisibleIndex = 2;
            this.colLeido.Width = 26;
            // 
            // colTiene_Adjunto
            // 
            this.colTiene_Adjunto.ColumnEdit = this.cmbImagen_Tiene_Adjunto;
            this.colTiene_Adjunto.FieldName = "Tiene_Adjunto";
            this.colTiene_Adjunto.Name = "colTiene_Adjunto";
            this.colTiene_Adjunto.OptionsColumn.AllowSize = false;
            this.colTiene_Adjunto.Visible = true;
            this.colTiene_Adjunto.VisibleIndex = 3;
            this.colTiene_Adjunto.Width = 22;
            // 
            // colPara
            // 
            this.colPara.Caption = "De";
            this.colPara.FieldName = "Para";
            this.colPara.Name = "colPara";
            this.colPara.Visible = true;
            this.colPara.VisibleIndex = 4;
            this.colPara.Width = 188;
            // 
            // colAsunto
            // 
            this.colAsunto.Caption = "Asunto";
            this.colAsunto.FieldName = "Asunto";
            this.colAsunto.Name = "colAsunto";
            this.colAsunto.Visible = true;
            this.colAsunto.VisibleIndex = 5;
            this.colAsunto.Width = 215;
            // 
            // colTexto_mensaje
            // 
            this.colTexto_mensaje.Caption = "Mensaje";
            this.colTexto_mensaje.FieldName = "Texto_mensaje";
            this.colTexto_mensaje.Name = "colTexto_mensaje";
            this.colTexto_mensaje.Visible = true;
            this.colTexto_mensaje.VisibleIndex = 6;
            this.colTexto_mensaje.Width = 596;
            // 
            // colMosTrar_icono_Ride
            // 
            this.colMosTrar_icono_Ride.Caption = "Ride";
            this.colMosTrar_icono_Ride.ColumnEdit = this.cmbImagen_Ride;
            this.colMosTrar_icono_Ride.FieldName = "MosTrar_icono_Ride";
            this.colMosTrar_icono_Ride.Name = "colMosTrar_icono_Ride";
            this.colMosTrar_icono_Ride.OptionsColumn.AllowEdit = false;
            this.colMosTrar_icono_Ride.Visible = true;
            this.colMosTrar_icono_Ride.VisibleIndex = 7;
            this.colMosTrar_icono_Ride.Width = 30;
            // 
            // colMosTrar_icono_xml
            // 
            this.colMosTrar_icono_xml.Caption = "xml";
            this.colMosTrar_icono_xml.ColumnEdit = this.cmbImagen_xml;
            this.colMosTrar_icono_xml.FieldName = "MosTrar_icono_xml";
            this.colMosTrar_icono_xml.Name = "colMosTrar_icono_xml";
            this.colMosTrar_icono_xml.OptionsColumn.AllowEdit = false;
            this.colMosTrar_icono_xml.Visible = true;
            this.colMosTrar_icono_xml.VisibleIndex = 8;
            this.colMosTrar_icono_xml.Width = 41;
            // 
            // cmbImagen_Prioridad
            // 
            this.cmbImagen_Prioridad.AutoHeight = false;
            this.cmbImagen_Prioridad.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_Prioridad.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 4)});
            this.cmbImagen_Prioridad.LargeImages = this.icEditors;
            this.cmbImagen_Prioridad.Name = "cmbImagen_Prioridad";
            // 
            // cmbImage_Leido
            // 
            this.cmbImage_Leido.AutoHeight = false;
            this.cmbImage_Leido.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImage_Leido.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", false, 3)});
            this.cmbImage_Leido.LargeImages = this.icEditors;
            this.cmbImage_Leido.Name = "cmbImage_Leido";
            // 
            // cmbImagen_Tiene_Adjunto
            // 
            this.cmbImagen_Tiene_Adjunto.AutoHeight = false;
            this.cmbImagen_Tiene_Adjunto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_Tiene_Adjunto.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2)});
            this.cmbImagen_Tiene_Adjunto.LargeImages = this.icEditors;
            this.cmbImagen_Tiene_Adjunto.Name = "cmbImagen_Tiene_Adjunto";
            // 
            // cmbImagen_Ride
            // 
            this.cmbImagen_Ride.AutoHeight = false;
            this.cmbImagen_Ride.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_Ride.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmbImagen_Ride.LargeImages = this.icEditors;
            this.cmbImagen_Ride.Name = "cmbImagen_Ride";
            // 
            // cmbImagen_xml
            // 
            this.cmbImagen_xml.AutoHeight = false;
            this.cmbImagen_xml.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_xml.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 1)});
            this.cmbImagen_xml.LargeImages = this.icEditors;
            this.cmbImagen_xml.Name = "cmbImagen_xml";
            // 
            // colIdMensaje
            // 
            this.colIdMensaje.Caption = "IdMensaje";
            this.colIdMensaje.FieldName = "IdMensaje";
            this.colIdMensaje.Name = "colIdMensaje";
            this.colIdMensaje.Visible = true;
            this.colIdMensaje.VisibleIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 398);
            this.Controls.Add(this.gridControl_Buzon_Entrada);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Bajar_Correo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Buzon_Entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Buzon_Entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Prioridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImage_Leido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Tiene_Adjunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Ride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_xml)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bajar_Correo;
        private System.Windows.Forms.Button btn_Actualizar;
        private DevExpress.XtraGrid.GridControl gridControl_Buzon_Entrada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Buzon_Entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
        private DevExpress.XtraGrid.Columns.GridColumn colPrioridad;
        private DevExpress.XtraGrid.Columns.GridColumn colLeido;
        private DevExpress.XtraGrid.Columns.GridColumn colTiene_Adjunto;
        private DevExpress.XtraGrid.Columns.GridColumn colPara;
        private DevExpress.XtraGrid.Columns.GridColumn colAsunto;
        private DevExpress.XtraGrid.Columns.GridColumn colTexto_mensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colMosTrar_icono_Ride;
        private DevExpress.XtraGrid.Columns.GridColumn colMosTrar_icono_xml;
        private DevExpress.Utils.ImageCollection icEditors;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_Prioridad;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImage_Leido;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_Tiene_Adjunto;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_Ride;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_xml;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMensaje;
    }
}