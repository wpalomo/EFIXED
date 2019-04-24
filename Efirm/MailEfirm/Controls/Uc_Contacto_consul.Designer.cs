namespace MailEfirm.Controls
{
    partial class Uc_Contacto_consul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Contacto_consul));
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelContribuyente = new System.Windows.Forms.Panel();
            this.gridControlContacto = new DevExpress.XtraGrid.GridControl();
            this.gridViewContactos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdContribuyente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEscliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEsproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColContraseña = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipoContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelRefres = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Refresc = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelContribuyente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContactos)).BeginInit();
            this.PanelRefres.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(901, 519);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(901, 519);
            this.layoutControlGroup2.Text = "Root";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelPrincipal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 550);
            this.panel2.TabIndex = 2;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelContribuyente);
            this.panelPrincipal.Controls.Add(this.PanelRefres);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(865, 550);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelContribuyente
            // 
            this.panelContribuyente.Controls.Add(this.gridControlContacto);
            this.panelContribuyente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContribuyente.Location = new System.Drawing.Point(0, 30);
            this.panelContribuyente.Name = "panelContribuyente";
            this.panelContribuyente.Size = new System.Drawing.Size(865, 520);
            this.panelContribuyente.TabIndex = 3;
            // 
            // gridControlContacto
            // 
            this.gridControlContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlContacto.Location = new System.Drawing.Point(0, 0);
            this.gridControlContacto.MainView = this.gridViewContactos;
            this.gridControlContacto.Name = "gridControlContacto";
            this.gridControlContacto.Size = new System.Drawing.Size(865, 520);
            this.gridControlContacto.TabIndex = 1;
            this.gridControlContacto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContactos});
            this.gridControlContacto.Click += new System.EventHandler(this.gridControlContacto_Click);
            this.gridControlContacto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControlContacto_MouseClick);
            // 
            // gridViewContactos
            // 
            this.gridViewContactos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdContribuyente,
            this.ColRazonSocial,
            this.CoCedula,
            this.ColNombre,
            this.ColMail,
            this.ColEscliente,
            this.ColEsproveedor,
            this.ColContraseña,
            this.ColTipoContacto,
            this.ColDireccion,
            this.ColTelefono});
            this.gridViewContactos.GridControl = this.gridControlContacto;
            this.gridViewContactos.Name = "gridViewContactos";
            this.gridViewContactos.OptionsBehavior.Editable = false;
            this.gridViewContactos.OptionsFind.AlwaysVisible = true;
            this.gridViewContactos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewContactos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewContactos_RowClick);
            // 
            // ColIdContribuyente
            // 
            this.ColIdContribuyente.Caption = "Id Contribuyente";
            this.ColIdContribuyente.FieldName = "IdContribuyente";
            this.ColIdContribuyente.Name = "ColIdContribuyente";
            this.ColIdContribuyente.Visible = true;
            this.ColIdContribuyente.VisibleIndex = 0;
            // 
            // ColRazonSocial
            // 
            this.ColRazonSocial.Caption = "Emisor";
            this.ColRazonSocial.FieldName = "RazonSocial";
            this.ColRazonSocial.Name = "ColRazonSocial";
            this.ColRazonSocial.Visible = true;
            this.ColRazonSocial.VisibleIndex = 10;
            // 
            // CoCedula
            // 
            this.CoCedula.Caption = "Cedula";
            this.CoCedula.FieldName = "cedulaRuc_contri";
            this.CoCedula.Name = "CoCedula";
            this.CoCedula.Visible = true;
            this.CoCedula.VisibleIndex = 1;
            // 
            // ColNombre
            // 
            this.ColNombre.Caption = "Nombre";
            this.ColNombre.FieldName = "Nom_Contribuyente";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Visible = true;
            this.ColNombre.VisibleIndex = 2;
            // 
            // ColMail
            // 
            this.ColMail.Caption = "Mail";
            this.ColMail.FieldName = "Mail";
            this.ColMail.Name = "ColMail";
            this.ColMail.Visible = true;
            this.ColMail.VisibleIndex = 3;
            // 
            // ColEscliente
            // 
            this.ColEscliente.Caption = "Es Cliente";
            this.ColEscliente.FieldName = "Mail_secundario";
            this.ColEscliente.Name = "ColEscliente";
            this.ColEscliente.Visible = true;
            this.ColEscliente.VisibleIndex = 4;
            // 
            // ColEsproveedor
            // 
            this.ColEsproveedor.Caption = "Esproveedor";
            this.ColEsproveedor.FieldName = "EsProveedor";
            this.ColEsproveedor.Name = "ColEsproveedor";
            this.ColEsproveedor.Visible = true;
            this.ColEsproveedor.VisibleIndex = 5;
            // 
            // ColContraseña
            // 
            this.ColContraseña.Caption = "Contraseña";
            this.ColContraseña.FieldName = "Password";
            this.ColContraseña.Name = "ColContraseña";
            this.ColContraseña.Visible = true;
            this.ColContraseña.VisibleIndex = 6;
            // 
            // ColTipoContacto
            // 
            this.ColTipoContacto.Caption = "Tipo Contacto";
            this.ColTipoContacto.FieldName = "TipoContacto";
            this.ColTipoContacto.Name = "ColTipoContacto";
            this.ColTipoContacto.Visible = true;
            this.ColTipoContacto.VisibleIndex = 7;
            // 
            // ColDireccion
            // 
            this.ColDireccion.Caption = "Direccion";
            this.ColDireccion.FieldName = "Direccion";
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.Visible = true;
            this.ColDireccion.VisibleIndex = 8;
            // 
            // ColTelefono
            // 
            this.ColTelefono.Caption = "Telefono";
            this.ColTelefono.FieldName = "Telefono";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.Visible = true;
            this.ColTelefono.VisibleIndex = 9;
            // 
            // PanelRefres
            // 
            this.PanelRefres.Controls.Add(this.toolStrip1);
            this.PanelRefres.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRefres.Location = new System.Drawing.Point(0, 0);
            this.PanelRefres.Name = "PanelRefres";
            this.PanelRefres.Size = new System.Drawing.Size(865, 30);
            this.PanelRefres.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Refresc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(865, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Refresc
            // 
            this.btn_Refresc.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresc.Image")));
            this.btn_Refresc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresc.Name = "btn_Refresc";
            this.btn_Refresc.Size = new System.Drawing.Size(59, 22);
            this.btn_Refresc.Text = "Refres";
            this.btn_Refresc.Click += new System.EventHandler(this.btn_Refresc_Click);
            // 
            // Uc_Contacto_consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Uc_Contacto_consul";
            this.Size = new System.Drawing.Size(865, 550);
            this.Load += new System.EventHandler(this.Uc_Contactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelContribuyente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContactos)).EndInit();
            this.PanelRefres.ResumeLayout(false);
            this.PanelRefres.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPrincipal;
        private DevExpress.XtraGrid.GridControl gridControlContacto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContactos;
        private DevExpress.XtraGrid.Columns.GridColumn ColRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn CoCedula;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ColMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColEscliente;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdContribuyente;
        private DevExpress.XtraGrid.Columns.GridColumn ColEsproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn ColContraseña;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipoContacto;
        private DevExpress.XtraGrid.Columns.GridColumn ColDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn ColTelefono;
        private System.Windows.Forms.Panel PanelRefres;
        private System.Windows.Forms.Panel panelContribuyente;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Refresc;
    }
}
