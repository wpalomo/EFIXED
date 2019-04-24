namespace MailEfirm.Controls
{
    partial class UC_Cuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cuentas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_consultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageCuenta = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlCuentas = new DevExpress.XtraGrid.GridControl();
            this.gridViewCuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion_correo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServidorCorreoEntrante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPort_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colport_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageCtaxEmisor = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlCtaPoEmisor = new DevExpress.XtraGrid.GridControl();
            this.gridViewRela_emisro_cta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbx_top = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAgregarRelacion = new System.Windows.Forms.Button();
            this.cmbEmisores = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coolIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collRUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCuentas = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collNombre_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colldireccion_correo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collTipoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCuentas)).BeginInit();
            this.xtraTabPageCtaxEmisor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCtaPoEmisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRela_emisro_cta)).BeginInit();
            this.gbx_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmisores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuentas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_modificar,
            this.toolStripSeparator1,
            this.btn_consultar,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.btn_refrescar,
            this.toolStripSeparator3,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = global::MailEfirm.Properties.Resources.Card_32x32;
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(62, 22);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(78, 22);
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultar.Image")));
            this.btn_consultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(78, 22);
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "                           ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_refrescar.Image")));
            this.btn_refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(75, 22);
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel2.Text = "                      ";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.xtraTabControl1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 25);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(762, 355);
            this.panelPrincipal.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageCuenta;
            this.xtraTabControl1.Size = new System.Drawing.Size(762, 355);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageCuenta,
            this.xtraTabPageCtaxEmisor});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPageCuenta
            // 
            this.xtraTabPageCuenta.Controls.Add(this.gridControlCuentas);
            this.xtraTabPageCuenta.Name = "xtraTabPageCuenta";
            this.xtraTabPageCuenta.Size = new System.Drawing.Size(756, 327);
            this.xtraTabPageCuenta.Text = "Cuentas";
            // 
            // gridControlCuentas
            // 
            this.gridControlCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCuentas.Location = new System.Drawing.Point(0, 0);
            this.gridControlCuentas.MainView = this.gridViewCuentas;
            this.gridControlCuentas.Name = "gridControlCuentas";
            this.gridControlCuentas.Size = new System.Drawing.Size(756, 327);
            this.gridControlCuentas.TabIndex = 0;
            this.gridControlCuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCuentas});
            this.gridControlCuentas.Load += new System.EventHandler(this.gridControlCuentas_Load);
            this.gridControlCuentas.Click += new System.EventHandler(this.gridControlCuentas_Click);
            this.gridControlCuentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControlCuentas_KeyPress);
            // 
            // gridViewCuentas
            // 
            this.gridViewCuentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCuenta,
            this.colNombre_cuenta,
            this.coldireccion_correo,
            this.colUsuario,
            this.colPassword,
            this.colTipoCuenta,
            this.colServidorCorreoEntrante,
            this.colPort_salida,
            this.colport_entrada});
            this.gridViewCuentas.GridControl = this.gridControlCuentas;
            this.gridViewCuentas.Name = "gridViewCuentas";
            this.gridViewCuentas.OptionsBehavior.Editable = false;
            this.gridViewCuentas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCuentas.OptionsView.ShowGroupPanel = false;
            this.gridViewCuentas.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCuentas_RowClick);
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.Caption = "IdCuenta";
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.Visible = true;
            this.colIdCuenta.VisibleIndex = 0;
            this.colIdCuenta.Width = 52;
            // 
            // colNombre_cuenta
            // 
            this.colNombre_cuenta.Caption = "Nombre";
            this.colNombre_cuenta.FieldName = "Nombre_cuenta";
            this.colNombre_cuenta.Name = "colNombre_cuenta";
            this.colNombre_cuenta.Visible = true;
            this.colNombre_cuenta.VisibleIndex = 1;
            this.colNombre_cuenta.Width = 168;
            // 
            // coldireccion_correo
            // 
            this.coldireccion_correo.Caption = "Correo";
            this.coldireccion_correo.FieldName = "direccion_correo";
            this.coldireccion_correo.Name = "coldireccion_correo";
            this.coldireccion_correo.Visible = true;
            this.coldireccion_correo.VisibleIndex = 2;
            this.coldireccion_correo.Width = 87;
            // 
            // colUsuario
            // 
            this.colUsuario.Caption = "Usuario";
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 3;
            this.colUsuario.Width = 69;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Contraseña";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 4;
            this.colPassword.Width = 69;
            // 
            // colTipoCuenta
            // 
            this.colTipoCuenta.Caption = "Tipo Cuenta";
            this.colTipoCuenta.FieldName = "TipoCuenta";
            this.colTipoCuenta.Name = "colTipoCuenta";
            this.colTipoCuenta.Visible = true;
            this.colTipoCuenta.VisibleIndex = 5;
            this.colTipoCuenta.Width = 69;
            // 
            // colServidorCorreoEntrante
            // 
            this.colServidorCorreoEntrante.Caption = "Servidor Correo Entrante";
            this.colServidorCorreoEntrante.FieldName = "ServidorCorreoEntrante";
            this.colServidorCorreoEntrante.Name = "colServidorCorreoEntrante";
            this.colServidorCorreoEntrante.Visible = true;
            this.colServidorCorreoEntrante.VisibleIndex = 6;
            this.colServidorCorreoEntrante.Width = 69;
            // 
            // colPort_salida
            // 
            this.colPort_salida.Caption = "Puerto Salida";
            this.colPort_salida.FieldName = "Port_salida";
            this.colPort_salida.Name = "colPort_salida";
            this.colPort_salida.Visible = true;
            this.colPort_salida.VisibleIndex = 7;
            this.colPort_salida.Width = 69;
            // 
            // colport_entrada
            // 
            this.colport_entrada.Caption = "Puerto Entrada";
            this.colport_entrada.FieldName = "port_entrada";
            this.colport_entrada.Name = "colport_entrada";
            this.colport_entrada.Visible = true;
            this.colport_entrada.VisibleIndex = 8;
            this.colport_entrada.Width = 86;
            // 
            // xtraTabPageCtaxEmisor
            // 
            this.xtraTabPageCtaxEmisor.Controls.Add(this.panel1);
            this.xtraTabPageCtaxEmisor.Controls.Add(this.gbx_top);
            this.xtraTabPageCtaxEmisor.Name = "xtraTabPageCtaxEmisor";
            this.xtraTabPageCtaxEmisor.Size = new System.Drawing.Size(756, 327);
            this.xtraTabPageCtaxEmisor.Text = "Cuentas x Emisor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlCtaPoEmisor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 190);
            this.panel1.TabIndex = 2;
            // 
            // gridControlCtaPoEmisor
            // 
            this.gridControlCtaPoEmisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCtaPoEmisor.Location = new System.Drawing.Point(0, 0);
            this.gridControlCtaPoEmisor.MainView = this.gridViewRela_emisro_cta;
            this.gridControlCtaPoEmisor.Name = "gridControlCtaPoEmisor";
            this.gridControlCtaPoEmisor.Size = new System.Drawing.Size(756, 190);
            this.gridControlCtaPoEmisor.TabIndex = 0;
            this.gridControlCtaPoEmisor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRela_emisro_cta});
            // 
            // gridViewRela_emisro_cta
            // 
            this.gridViewRela_emisro_cta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEliminar,
            this.colIdEmpresa,
            this.colIdCuenta1,
            this.colobservacion});
            this.gridViewRela_emisro_cta.GridControl = this.gridControlCtaPoEmisor;
            this.gridViewRela_emisro_cta.Name = "gridViewRela_emisro_cta";
            this.gridViewRela_emisro_cta.OptionsView.ShowGroupPanel = false;
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "*";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 0;
            this.colEliminar.Width = 35;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "Emisor";
            this.colIdEmpresa.FieldName = "RazonSocial";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 1;
            this.colIdEmpresa.Width = 259;
            // 
            // colIdCuenta1
            // 
            this.colIdCuenta1.Caption = "Cuenta";
            this.colIdCuenta1.FieldName = "IdCuenta";
            this.colIdCuenta1.Name = "colIdCuenta1";
            this.colIdCuenta1.Visible = true;
            this.colIdCuenta1.VisibleIndex = 2;
            this.colIdCuenta1.Width = 262;
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "observacion";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 3;
            this.colobservacion.Width = 388;
            // 
            // gbx_top
            // 
            this.gbx_top.Controls.Add(this.label3);
            this.gbx_top.Controls.Add(this.txtObservaciones);
            this.gbx_top.Controls.Add(this.btnAgregarRelacion);
            this.gbx_top.Controls.Add(this.cmbEmisores);
            this.gbx_top.Controls.Add(this.cmbCuentas);
            this.gbx_top.Controls.Add(this.label2);
            this.gbx_top.Controls.Add(this.label1);
            this.gbx_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbx_top.Location = new System.Drawing.Point(0, 0);
            this.gbx_top.Name = "gbx_top";
            this.gbx_top.Size = new System.Drawing.Size(756, 137);
            this.gbx_top.TabIndex = 1;
            this.gbx_top.TabStop = false;
            this.gbx_top.Text = "Relacion Emisor Cuenta";
            this.gbx_top.Enter += new System.EventHandler(this.gbx_top_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Observacion:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(86, 82);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(622, 20);
            this.txtObservaciones.TabIndex = 5;
            // 
            // btnAgregarRelacion
            // 
            this.btnAgregarRelacion.Location = new System.Drawing.Point(86, 108);
            this.btnAgregarRelacion.Name = "btnAgregarRelacion";
            this.btnAgregarRelacion.Size = new System.Drawing.Size(137, 25);
            this.btnAgregarRelacion.TabIndex = 4;
            this.btnAgregarRelacion.Text = "Agregar Relacion";
            this.btnAgregarRelacion.UseVisualStyleBackColor = true;
            this.btnAgregarRelacion.Click += new System.EventHandler(this.btnAgregarRelacion_Click);
            // 
            // cmbEmisores
            // 
            this.cmbEmisores.Location = new System.Drawing.Point(86, 19);
            this.cmbEmisores.Name = "cmbEmisores";
            this.cmbEmisores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmisores.Properties.DisplayMember = "RazonSocial";
            this.cmbEmisores.Properties.ValueMember = "IdEmpresa";
            this.cmbEmisores.Properties.View = this.gridView2;
            this.cmbEmisores.Size = new System.Drawing.Size(363, 20);
            this.cmbEmisores.TabIndex = 3;
            this.cmbEmisores.EditValueChanged += new System.EventHandler(this.cmbEmisores_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coolIdEmpresa,
            this.collRazonSocial,
            this.collRUC});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // coolIdEmpresa
            // 
            this.coolIdEmpresa.Caption = "Id Empresa";
            this.coolIdEmpresa.FieldName = "IdEmpresa";
            this.coolIdEmpresa.Name = "coolIdEmpresa";
            this.coolIdEmpresa.Visible = true;
            this.coolIdEmpresa.VisibleIndex = 0;
            // 
            // collRazonSocial
            // 
            this.collRazonSocial.Caption = "Razon Social";
            this.collRazonSocial.FieldName = "RazonSocial";
            this.collRazonSocial.Name = "collRazonSocial";
            this.collRazonSocial.Visible = true;
            this.collRazonSocial.VisibleIndex = 1;
            // 
            // collRUC
            // 
            this.collRUC.Caption = "Ruc";
            this.collRUC.FieldName = "RUC";
            this.collRUC.Name = "collRUC";
            this.collRUC.Visible = true;
            this.collRUC.VisibleIndex = 2;
            // 
            // cmbCuentas
            // 
            this.cmbCuentas.Location = new System.Drawing.Point(86, 52);
            this.cmbCuentas.Name = "cmbCuentas";
            this.cmbCuentas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCuentas.Properties.DisplayMember = "IdCuenta";
            this.cmbCuentas.Properties.ValueMember = "IdCuenta";
            this.cmbCuentas.Properties.View = this.searchLookUpEdit1View;
            this.cmbCuentas.Size = new System.Drawing.Size(363, 20);
            this.cmbCuentas.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collIdCuenta,
            this.collNombre_cuenta,
            this.colldireccion_correo,
            this.collTipoCuenta});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // collIdCuenta
            // 
            this.collIdCuenta.Caption = "Id Cuenta";
            this.collIdCuenta.FieldName = "IdCuenta";
            this.collIdCuenta.Name = "collIdCuenta";
            this.collIdCuenta.Visible = true;
            this.collIdCuenta.VisibleIndex = 0;
            // 
            // collNombre_cuenta
            // 
            this.collNombre_cuenta.Caption = "Nombre Cuenta";
            this.collNombre_cuenta.FieldName = "Nombre_cuenta";
            this.collNombre_cuenta.Name = "collNombre_cuenta";
            this.collNombre_cuenta.Visible = true;
            this.collNombre_cuenta.VisibleIndex = 1;
            // 
            // colldireccion_correo
            // 
            this.colldireccion_correo.Caption = "Correo";
            this.colldireccion_correo.FieldName = "direccion_correo";
            this.colldireccion_correo.Name = "colldireccion_correo";
            this.colldireccion_correo.Visible = true;
            this.colldireccion_correo.VisibleIndex = 2;
            // 
            // collTipoCuenta
            // 
            this.collTipoCuenta.Caption = "tipo Cuenta";
            this.collTipoCuenta.FieldName = "TipoCuenta";
            this.collTipoCuenta.Name = "collTipoCuenta";
            this.collTipoCuenta.Visible = true;
            this.collTipoCuenta.VisibleIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emisor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta:";
            // 
            // UC_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_Cuentas";
            this.Size = new System.Drawing.Size(762, 380);
            this.Load += new System.EventHandler(this.UC_Cuentas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageCuenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCuentas)).EndInit();
            this.xtraTabPageCtaxEmisor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCtaPoEmisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRela_emisro_cta)).EndInit();
            this.gbx_top.ResumeLayout(false);
            this.gbx_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmisores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCuentas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelPrincipal;
        private DevExpress.XtraGrid.GridControl gridControlCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCuentas;
        private System.Windows.Forms.ToolStripButton btn_modificar;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCuenta;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCtaxEmisor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_cuenta;
        private DevExpress.XtraGrid.GridControl gridControlCtaPoEmisor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRela_emisro_cta;
        private System.Windows.Forms.ToolStripButton btn_refrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_consultar;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion_correo;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colServidorCorreoEntrante;
        private DevExpress.XtraGrid.Columns.GridColumn colPort_salida;
        private DevExpress.XtraGrid.Columns.GridColumn colport_entrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbx_top;
        private System.Windows.Forms.Button btnAgregarRelacion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEmisores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn collIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn collNombre_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colldireccion_correo;
        private DevExpress.XtraGrid.Columns.GridColumn collTipoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coolIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn collRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn collRUC;
    }
}
