namespace MailEfirm.Controls
{
    partial class UC_Visor_Mail
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Visor_Mail));
            this.gridControlVisor_Mail = new DevExpress.XtraGrid.GridControl();
            this.gridViewVisorMail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColImportancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIcono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAdjunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAsunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRecibido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColLeido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageListColumns = new System.Windows.Forms.ImageList(this.components);
            this.icEditors = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVisor_Mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVisorMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlVisor_Mail
            // 
            this.gridControlVisor_Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVisor_Mail.Location = new System.Drawing.Point(0, 0);
            this.gridControlVisor_Mail.MainView = this.gridViewVisorMail;
            this.gridControlVisor_Mail.Name = "gridControlVisor_Mail";
            this.gridControlVisor_Mail.Size = new System.Drawing.Size(655, 383);
            this.gridControlVisor_Mail.TabIndex = 0;
            this.gridControlVisor_Mail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVisorMail});
            this.gridControlVisor_Mail.Load += new System.EventHandler(this.gridControlVisor_Mail_Load);
            this.gridControlVisor_Mail.Click += new System.EventHandler(this.gridControlVisor_Mail_Click);
            // 
            // gridViewVisorMail
            // 
            this.gridViewVisorMail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColImportancia,
            this.ColIcono,
            this.ColAdjunto,
            this.ColAsunto,
            this.ColFrom,
            this.ColRecibido,
            this.ColLeido});
            this.gridViewVisorMail.GridControl = this.gridControlVisor_Mail;
            this.gridViewVisorMail.Images = this.imageListColumns;
            this.gridViewVisorMail.Name = "gridViewVisorMail";
            this.gridViewVisorMail.OptionsFind.AlwaysVisible = true;
            this.gridViewVisorMail.OptionsView.ShowAutoFilterRow = true;
            // 
            // ColImportancia
            // 
            this.ColImportancia.FieldName = "Prioridad";
            this.ColImportancia.ImageIndex = 0;
            this.ColImportancia.Name = "ColImportancia";
            this.ColImportancia.Visible = true;
            this.ColImportancia.VisibleIndex = 0;
            this.ColImportancia.Width = 36;
            // 
            // ColIcono
            // 
            this.ColIcono.ImageIndex = 1;
            this.ColIcono.Name = "ColIcono";
            this.ColIcono.Visible = true;
            this.ColIcono.VisibleIndex = 1;
            this.ColIcono.Width = 37;
            // 
            // ColAdjunto
            // 
            this.ColAdjunto.ImageIndex = 2;
            this.ColAdjunto.Name = "ColAdjunto";
            this.ColAdjunto.Visible = true;
            this.ColAdjunto.VisibleIndex = 2;
            this.ColAdjunto.Width = 35;
            // 
            // ColAsunto
            // 
            this.ColAsunto.Caption = "Asunto";
            this.ColAsunto.FieldName = "Asunto";
            this.ColAsunto.Name = "ColAsunto";
            this.ColAsunto.Visible = true;
            this.ColAsunto.VisibleIndex = 3;
            this.ColAsunto.Width = 325;
            // 
            // ColFrom
            // 
            this.ColFrom.Caption = "Para";
            this.ColFrom.FieldName = "Para";
            this.ColFrom.Name = "ColFrom";
            this.ColFrom.Visible = true;
            this.ColFrom.VisibleIndex = 4;
            this.ColFrom.Width = 80;
            // 
            // ColRecibido
            // 
            this.ColRecibido.Caption = "Recibido";
            this.ColRecibido.Name = "ColRecibido";
            this.ColRecibido.Visible = true;
            this.ColRecibido.VisibleIndex = 5;
            this.ColRecibido.Width = 88;
            // 
            // ColLeido
            // 
            this.ColLeido.ImageIndex = 3;
            this.ColLeido.Name = "ColLeido";
            this.ColLeido.Visible = true;
            this.ColLeido.VisibleIndex = 6;
            this.ColLeido.Width = 36;
            // 
            // imageListColumns
            // 
            this.imageListColumns.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListColumns.ImageStream")));
            this.imageListColumns.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListColumns.Images.SetKeyName(0, "Importancia.png");
            this.imageListColumns.Images.SetKeyName(1, "Icono.png");
            this.imageListColumns.Images.SetKeyName(2, "ArchivoAdjunto.png");
            this.imageListColumns.Images.SetKeyName(3, "leido.png");
            // 
            // icEditors
            // 
            this.icEditors.ImageSize = new System.Drawing.Size(13, 13);
            this.icEditors.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icEditors.ImageStream")));
            this.icEditors.Images.SetKeyName(0, "Low.png");
            this.icEditors.Images.SetKeyName(1, "High.png");
            this.icEditors.Images.SetKeyName(2, "ReadMessage_13x13.png");
            this.icEditors.Images.SetKeyName(3, "UnreadMessage_13x13.png");
            this.icEditors.Images.SetKeyName(4, "Attachment.png");
            this.icEditors.Images.SetKeyName(5, "Unread.png");
            this.icEditors.Images.SetKeyName(6, "Read.png");
            // 
            // UC_Visor_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlVisor_Mail);
            this.Name = "UC_Visor_Mail";
            this.Size = new System.Drawing.Size(655, 383);
            this.Load += new System.EventHandler(this.UC_Visor_Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVisor_Mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVisorMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlVisor_Mail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVisorMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColImportancia;
        private DevExpress.XtraGrid.Columns.GridColumn ColIcono;
        private System.Windows.Forms.ImageList imageListColumns;
        private DevExpress.XtraGrid.Columns.GridColumn ColAdjunto;
        private DevExpress.XtraGrid.Columns.GridColumn ColAsunto;
        private DevExpress.XtraGrid.Columns.GridColumn ColFrom;
        private DevExpress.XtraGrid.Columns.GridColumn ColRecibido;
        private DevExpress.XtraGrid.Columns.GridColumn ColLeido;
        private DevExpress.Utils.ImageCollection icEditors;
    }
}
