namespace MailEfirm.Controls
{
    partial class UC_Menu_Redactar_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Menu_Redactar_Email));
            this.TopSuperior = new System.Windows.Forms.ToolStrip();
            this.BtnEnviarMail = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_correo_destinatario_CC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_correo_destinatario = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlComprobantes = new DevExpress.XtraGrid.GridControl();
            this.gridViewgridComprobantes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaemision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadodoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaautori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEmisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colxml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpdf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbDestinatarios = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldIdContribuyente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombreContr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomEmisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbRuta = new System.Windows.Forms.Label();
            this.BtnAdjuntar = new System.Windows.Forms.Button();
            this.lblTo = new DevExpress.XtraEditors.LabelControl();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.txtAsunto = new DevExpress.XtraEditors.TextEdit();
            this.PanelRedactarMail = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_mensaje = new DevExpress.XtraRichEdit.RichEditControl();
            this.errorPValidarTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.TopSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_correo_destinatario_CC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_correo_destinatario.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewgridComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDestinatarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).BeginInit();
            this.PanelRedactarMail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPValidarTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // TopSuperior
            // 
            this.TopSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnEnviarMail,
            this.btn_salir});
            this.TopSuperior.Location = new System.Drawing.Point(0, 0);
            this.TopSuperior.Name = "TopSuperior";
            this.TopSuperior.Size = new System.Drawing.Size(839, 25);
            this.TopSuperior.TabIndex = 6;
            this.TopSuperior.Text = "toolStrip1";
            this.TopSuperior.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TopSuperior_ItemClicked);
            // 
            // BtnEnviarMail
            // 
            this.BtnEnviarMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEnviarMail.Image = global::MailEfirm.Properties.Resources.Contact_Us;
            this.BtnEnviarMail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEnviarMail.Name = "BtnEnviarMail";
            this.BtnEnviarMail.Size = new System.Drawing.Size(23, 22);
            this.BtnEnviarMail.Text = "Enviar";
            this.BtnEnviarMail.Click += new System.EventHandler(this.BtnEnviarMail_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(23, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl.Controls.Add(this.labelControl2);
            this.panelControl.Controls.Add(this.txt_correo_destinatario_CC);
            this.panelControl.Controls.Add(this.labelControl1);
            this.panelControl.Controls.Add(this.txt_correo_destinatario);
            this.panelControl.Controls.Add(this.groupBox1);
            this.panelControl.Controls.Add(this.cmbDestinatarios);
            this.panelControl.Controls.Add(this.lbRuta);
            this.panelControl.Controls.Add(this.BtnAdjuntar);
            this.panelControl.Controls.Add(this.lblTo);
            this.panelControl.Controls.Add(this.lblSubject);
            this.panelControl.Controls.Add(this.txtAsunto);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 25);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(839, 277);
            this.panelControl.TabIndex = 7;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Cliente/Proveedor";
            // 
            // txt_correo_destinatario_CC
            // 
            this.txt_correo_destinatario_CC.Location = new System.Drawing.Point(105, 54);
            this.txt_correo_destinatario_CC.Name = "txt_correo_destinatario_CC";
            this.txt_correo_destinatario_CC.Size = new System.Drawing.Size(481, 20);
            this.txt_correo_destinatario_CC.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "&CC:";
            // 
            // txt_correo_destinatario
            // 
            this.txt_correo_destinatario.Location = new System.Drawing.Point(105, 29);
            this.txt_correo_destinatario.Name = "txt_correo_destinatario";
            this.txt_correo_destinatario.Size = new System.Drawing.Size(481, 20);
            this.txt_correo_destinatario.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlComprobantes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adjuntar Ride & XML";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gridControlComprobantes
            // 
            this.gridControlComprobantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlComprobantes.Location = new System.Drawing.Point(3, 16);
            this.gridControlComprobantes.MainView = this.gridViewgridComprobantes;
            this.gridControlComprobantes.Name = "gridControlComprobantes";
            this.gridControlComprobantes.Size = new System.Drawing.Size(833, 115);
            this.gridControlComprobantes.TabIndex = 0;
            this.gridControlComprobantes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewgridComprobantes});
            this.gridControlComprobantes.Click += new System.EventHandler(this.gridControlComprobantes_Click);
            // 
            // gridViewgridComprobantes
            // 
            this.gridViewgridComprobantes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChecked,
            this.ColIdComprobante,
            this.ColFechaemision,
            this.colEstadodoc,
            this.ColFechaautori,
            this.ColEmisor,
            this.Colxml,
            this.Colpdf});
            this.gridViewgridComprobantes.GridControl = this.gridControlComprobantes;
            this.gridViewgridComprobantes.Name = "gridViewgridComprobantes";
            this.gridViewgridComprobantes.OptionsBehavior.Editable = false;
            this.gridViewgridComprobantes.OptionsView.ShowAutoFilterRow = true;
            this.gridViewgridComprobantes.OptionsView.ShowGroupPanel = false;
            this.gridViewgridComprobantes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewgridComprobantes_RowClick);
            this.gridViewgridComprobantes.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewgridComprobantes_RowCellClick);
            // 
            // colChecked
            // 
            this.colChecked.Caption = "*";
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            // 
            // ColIdComprobante
            // 
            this.ColIdComprobante.Caption = "Id Comprobante";
            this.ColIdComprobante.FieldName = "IdComprobante";
            this.ColIdComprobante.Name = "ColIdComprobante";
            this.ColIdComprobante.OptionsColumn.AllowEdit = false;
            this.ColIdComprobante.Visible = true;
            this.ColIdComprobante.VisibleIndex = 1;
            // 
            // ColFechaemision
            // 
            this.ColFechaemision.Caption = "Fecha Emision Doc";
            this.ColFechaemision.FieldName = "Fecha_Emi_Fact";
            this.ColFechaemision.Name = "ColFechaemision";
            this.ColFechaemision.OptionsColumn.AllowEdit = false;
            this.ColFechaemision.Visible = true;
            this.ColFechaemision.VisibleIndex = 2;
            // 
            // colEstadodoc
            // 
            this.colEstadodoc.Caption = "Estado";
            this.colEstadodoc.FieldName = "EstadoDoc";
            this.colEstadodoc.Name = "colEstadodoc";
            this.colEstadodoc.OptionsColumn.AllowEdit = false;
            this.colEstadodoc.Visible = true;
            this.colEstadodoc.VisibleIndex = 3;
            // 
            // ColFechaautori
            // 
            this.ColFechaautori.Caption = "Fecha Autorizacion";
            this.ColFechaautori.FieldName = "FechaAutorizacion";
            this.ColFechaautori.Name = "ColFechaautori";
            this.ColFechaautori.OptionsColumn.AllowEdit = false;
            this.ColFechaautori.Visible = true;
            this.ColFechaautori.VisibleIndex = 4;
            // 
            // ColEmisor
            // 
            this.ColEmisor.Caption = "Emisor";
            this.ColEmisor.FieldName = "Nom_emisor";
            this.ColEmisor.Name = "ColEmisor";
            this.ColEmisor.OptionsColumn.AllowEdit = false;
            this.ColEmisor.Visible = true;
            this.ColEmisor.VisibleIndex = 5;
            // 
            // Colxml
            // 
            this.Colxml.Caption = ".Xml";
            this.Colxml.FieldName = "Checked";
            this.Colxml.Name = "Colxml";
            this.Colxml.Visible = true;
            this.Colxml.VisibleIndex = 6;
            // 
            // Colpdf
            // 
            this.Colpdf.Caption = ".Pdf";
            this.Colpdf.FieldName = "Checked";
            this.Colpdf.Name = "Colpdf";
            this.Colpdf.Visible = true;
            this.Colpdf.VisibleIndex = 7;
            // 
            // cmbDestinatarios
            // 
            this.cmbDestinatarios.EditValue = "";
            this.cmbDestinatarios.Location = new System.Drawing.Point(105, 5);
            this.cmbDestinatarios.Name = "cmbDestinatarios";
            this.cmbDestinatarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDestinatarios.Properties.DisplayMember = "Nom_Contribuyente2";
            this.cmbDestinatarios.Properties.ValueMember = "IdContribuyente";
            this.cmbDestinatarios.Properties.View = this.searchLookUpEdit1View;
            this.cmbDestinatarios.Size = new System.Drawing.Size(481, 20);
            this.cmbDestinatarios.TabIndex = 5;
            this.cmbDestinatarios.EditValueChanged += new System.EventHandler(this.cmbDestinatarios_EditValueChanged);
            this.cmbDestinatarios.Click += new System.EventHandler(this.cmbDestinatarios_Click);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldIdContribuyente,
            this.ColIdEmpresa,
            this.ColNombreContr,
            this.ColMail,
            this.colNomEmisor});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coldIdContribuyente
            // 
            this.coldIdContribuyente.Caption = "ID Contribuyente";
            this.coldIdContribuyente.FieldName = "IdContribuyente";
            this.coldIdContribuyente.Name = "coldIdContribuyente";
            this.coldIdContribuyente.Visible = true;
            this.coldIdContribuyente.VisibleIndex = 0;
            this.coldIdContribuyente.Width = 110;
            // 
            // ColIdEmpresa
            // 
            this.ColIdEmpresa.Caption = "Id Emisor";
            this.ColIdEmpresa.FieldName = "IdEmisor";
            this.ColIdEmpresa.Name = "ColIdEmpresa";
            this.ColIdEmpresa.Visible = true;
            this.ColIdEmpresa.VisibleIndex = 3;
            this.ColIdEmpresa.Width = 240;
            // 
            // ColNombreContr
            // 
            this.ColNombreContr.Caption = "Nombre";
            this.ColNombreContr.FieldName = "Nom_Contribuyente";
            this.ColNombreContr.Name = "ColNombreContr";
            this.ColNombreContr.Visible = true;
            this.ColNombreContr.VisibleIndex = 1;
            this.ColNombreContr.Width = 347;
            // 
            // ColMail
            // 
            this.ColMail.Caption = "Mail";
            this.ColMail.FieldName = "Mail";
            this.ColMail.Name = "ColMail";
            this.ColMail.Visible = true;
            this.ColMail.VisibleIndex = 2;
            this.ColMail.Width = 240;
            // 
            // colNomEmisor
            // 
            this.colNomEmisor.Caption = "Emisor";
            this.colNomEmisor.FieldName = "Nom_Emisor";
            this.colNomEmisor.Name = "colNomEmisor";
            this.colNomEmisor.Visible = true;
            this.colNomEmisor.VisibleIndex = 4;
            this.colNomEmisor.Width = 243;
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Location = new System.Drawing.Point(102, 119);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(125, 13);
            this.lbRuta.TabIndex = 4;
            this.lbRuta.Text = "Ruta del Archivo Adjunto";
            // 
            // BtnAdjuntar
            // 
            this.BtnAdjuntar.Location = new System.Drawing.Point(12, 114);
            this.BtnAdjuntar.Name = "BtnAdjuntar";
            this.BtnAdjuntar.Size = new System.Drawing.Size(63, 23);
            this.BtnAdjuntar.TabIndex = 3;
            this.BtnAdjuntar.Text = "Ad&juntar";
            this.BtnAdjuntar.UseVisualStyleBackColor = true;
            this.BtnAdjuntar.Click += new System.EventHandler(this.BtnAdjuntar_Click_1);
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(12, 31);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "&Para:";
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(12, 87);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(38, 13);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "&Asunto:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.EditValue = "Ha recibido un Nuevo comprobante Electronico";
            this.txtAsunto.Location = new System.Drawing.Point(105, 80);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(731, 20);
            this.txtAsunto.TabIndex = 2;
            // 
            // PanelRedactarMail
            // 
            this.PanelRedactarMail.Controls.Add(this.groupBox2);
            this.PanelRedactarMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRedactarMail.Location = new System.Drawing.Point(0, 302);
            this.PanelRedactarMail.Name = "PanelRedactarMail";
            this.PanelRedactarMail.Size = new System.Drawing.Size(839, 167);
            this.PanelRedactarMail.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_mensaje);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 167);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Mensaje";
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.txt_mensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mensaje.Location = new System.Drawing.Point(3, 16);
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Options.DocumentCapabilities.Bookmarks = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txt_mensaje.Options.DocumentCapabilities.HeadersFooters = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txt_mensaje.Options.DocumentCapabilities.Sections = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txt_mensaje.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.txt_mensaje.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txt_mensaje.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txt_mensaje.Size = new System.Drawing.Size(833, 148);
            this.txt_mensaje.TabIndex = 6;
            this.txt_mensaje.Text = "Correo Enviado por Facturacion Electronica.";
            this.txt_mensaje.Click += new System.EventHandler(this.txt_mensaje_Click);
            // 
            // errorPValidarTxt
            // 
            this.errorPValidarTxt.ContainerControl = this;
            // 
            // UC_Menu_Redactar_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelRedactarMail);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.TopSuperior);
            this.Name = "UC_Menu_Redactar_Email";
            this.Size = new System.Drawing.Size(839, 469);
            this.Load += new System.EventHandler(this.UC_Menu_Redactar_Email_Load);
            this.TopSuperior.ResumeLayout(false);
            this.TopSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_correo_destinatario_CC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_correo_destinatario.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewgridComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDestinatarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).EndInit();
            this.PanelRedactarMail.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorPValidarTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TopSuperior;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.Button BtnAdjuntar;
        private DevExpress.XtraEditors.LabelControl lblTo;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraEditors.TextEdit txtAsunto;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbDestinatarios;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Panel PanelRedactarMail;
        private DevExpress.XtraRichEdit.RichEditControl txt_mensaje;
        private DevExpress.XtraGrid.Columns.GridColumn coldIdContribuyente;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombreContr;
        private DevExpress.XtraGrid.Columns.GridColumn ColMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlComprobantes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewgridComprobantes;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaemision;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadodoc;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaautori;
        private DevExpress.XtraGrid.Columns.GridColumn ColEmisor;
        private DevExpress.XtraGrid.Columns.GridColumn Colxml;
        private DevExpress.XtraGrid.Columns.GridColumn Colpdf;
        private DevExpress.XtraEditors.TextEdit txt_correo_destinatario;
        private System.Windows.Forms.ErrorProvider errorPValidarTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn colNomEmisor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_correo_destinatario_CC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.ToolStripButton BtnEnviarMail;
        public System.Windows.Forms.ToolStripButton btn_salir;
    }
}
