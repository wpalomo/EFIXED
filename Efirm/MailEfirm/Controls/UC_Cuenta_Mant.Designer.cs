namespace MailEfirm.Controls
{
    partial class UC_Cuenta_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cuenta_Mant));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.BtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword_smtp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuario_smtp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiasServer = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkCopiaCorreo = new System.Windows.Forms.CheckBox();
            this.chkConexCifra = new System.Windows.Forms.CheckBox();
            this.chk_UseDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbtiposeguridad = new System.Windows.Forms.ComboBox();
            this.txtpuertoSalida = new System.Windows.Forms.NumericUpDown();
            this.lbPuertoSalida = new System.Windows.Forms.Label();
            this.btnCuentaPredeterminada = new System.Windows.Forms.Button();
            this.lbPuertoentrante = new System.Windows.Forms.Label();
            this.TxtPuertoEntada = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnTesCuenta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxInfosesion = new System.Windows.Forms.GroupBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxServidor = new System.Windows.Forms.GroupBox();
            this.cmbTipoAutenticacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbtipoCuenta = new System.Windows.Forms.ComboBox();
            this.lbTipoCenta = new System.Windows.Forms.Label();
            this.TxtServidorSaliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtServidorEntrante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxInfoUsuario = new System.Windows.Forms.GroupBox();
            this.gbSeguimiento = new DevExpress.XtraEditors.GroupControl();
            this.chkConfirmacion_de_lectura = new System.Windows.Forms.CheckBox();
            this.chkConfirmacion_de_entrega = new System.Windows.Forms.CheckBox();
            this.txtEnviaMail_CbteNoAuto = new DevExpress.XtraEditors.TextEdit();
            this.txtenviomail_ctaRespaldo = new DevExpress.XtraEditors.TextEdit();
            this.chk_envioMail_Cbte_NoAuto = new System.Windows.Forms.CheckBox();
            this.chk_enviar_copia_x_cada_mail_enviado = new System.Windows.Forms.CheckBox();
            this.chk_Cuenta_predeterminada = new System.Windows.Forms.CheckBox();
            this.txtidCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdirecioncorreoElectronico = new System.Windows.Forms.TextBox();
            this.labelDireccioncoreeo = new System.Windows.Forms.Label();
            this.txtSuNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.ErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripMenu.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpuertoSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPuertoEntada)).BeginInit();
            this.groupBoxInfosesion.SuspendLayout();
            this.groupBoxServidor.SuspendLayout();
            this.groupBoxInfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSeguimiento)).BeginInit();
            this.gbSeguimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnviaMail_CbteNoAuto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenviomail_ctaRespaldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGuardar});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(950, 25);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            this.toolStripMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenu_ItemClicked_1);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(69, 22);
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.groupBox1);
            this.panelPrincipal.Controls.Add(this.btnTesCuenta);
            this.panelPrincipal.Controls.Add(this.label8);
            this.panelPrincipal.Controls.Add(this.label7);
            this.panelPrincipal.Controls.Add(this.groupBoxInfosesion);
            this.panelPrincipal.Controls.Add(this.groupBoxServidor);
            this.panelPrincipal.Controls.Add(this.groupBoxInfoUsuario);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 25);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(950, 509);
            this.panelPrincipal.TabIndex = 2;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword_smtp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUsuario_smtp);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDiasServer);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.chkCopiaCorreo);
            this.groupBox1.Controls.Add(this.chkConexCifra);
            this.groupBox1.Controls.Add(this.chk_UseDefaultCredentials);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbtiposeguridad);
            this.groupBox1.Controls.Add(this.txtpuertoSalida);
            this.groupBox1.Controls.Add(this.lbPuertoSalida);
            this.groupBox1.Controls.Add(this.btnCuentaPredeterminada);
            this.groupBox1.Controls.Add(this.lbPuertoentrante);
            this.groupBox1.Controls.Add(this.TxtPuertoEntada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.shapeContainer2);
            this.groupBox1.Location = new System.Drawing.Point(478, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 262);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion Avanzada";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPassword_smtp
            // 
            this.txtPassword_smtp.Location = new System.Drawing.Point(179, 241);
            this.txtPassword_smtp.Name = "txtPassword_smtp";
            this.txtPassword_smtp.Size = new System.Drawing.Size(242, 20);
            this.txtPassword_smtp.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Usuario:";
            // 
            // txtUsuario_smtp
            // 
            this.txtUsuario_smtp.Location = new System.Drawing.Point(180, 215);
            this.txtUsuario_smtp.Name = "txtUsuario_smtp";
            this.txtUsuario_smtp.Size = new System.Drawing.Size(241, 20);
            this.txtUsuario_smtp.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Password";
            // 
            // txtDiasServer
            // 
            this.txtDiasServer.Location = new System.Drawing.Point(188, 121);
            this.txtDiasServer.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtDiasServer.Name = "txtDiasServer";
            this.txtDiasServer.Size = new System.Drawing.Size(71, 20);
            this.txtDiasServer.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(158, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Cada Cuantos dias Borrar Server";
            // 
            // chkCopiaCorreo
            // 
            this.chkCopiaCorreo.AutoSize = true;
            this.chkCopiaCorreo.Location = new System.Drawing.Point(53, 97);
            this.chkCopiaCorreo.Name = "chkCopiaCorreo";
            this.chkCopiaCorreo.Size = new System.Drawing.Size(235, 17);
            this.chkCopiaCorreo.TabIndex = 23;
            this.chkCopiaCorreo.Text = "Mantener una copia de correo en el servidor";
            this.chkCopiaCorreo.UseVisualStyleBackColor = true;
            // 
            // chkConexCifra
            // 
            this.chkConexCifra.AutoSize = true;
            this.chkConexCifra.Location = new System.Drawing.Point(53, 74);
            this.chkConexCifra.Name = "chkConexCifra";
            this.chkConexCifra.Size = new System.Drawing.Size(379, 17);
            this.chkConexCifra.TabIndex = 22;
            this.chkConexCifra.Text = "Este Servidor Precisa una conexion cifrada(SSL) para descarga de correos";
            this.chkConexCifra.UseVisualStyleBackColor = true;
            this.chkConexCifra.CheckedChanged += new System.EventHandler(this.chkConexCifra_CheckedChanged);
            // 
            // chk_UseDefaultCredentials
            // 
            this.chk_UseDefaultCredentials.AutoSize = true;
            this.chk_UseDefaultCredentials.Location = new System.Drawing.Point(75, 192);
            this.chk_UseDefaultCredentials.Name = "chk_UseDefaultCredentials";
            this.chk_UseDefaultCredentials.Size = new System.Drawing.Size(321, 17);
            this.chk_UseDefaultCredentials.TabIndex = 12;
            this.chk_UseDefaultCredentials.Text = "Usar la Misma Cuenta de Inicio de sesion para envio de correo";
            this.chk_UseDefaultCredentials.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Usar el Siguiente Tipo de Conexion Cifrada:";
            // 
            // cmbtiposeguridad
            // 
            this.cmbtiposeguridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtiposeguridad.FormattingEnabled = true;
            this.cmbtiposeguridad.Location = new System.Drawing.Point(290, 173);
            this.cmbtiposeguridad.Name = "cmbtiposeguridad";
            this.cmbtiposeguridad.Size = new System.Drawing.Size(121, 21);
            this.cmbtiposeguridad.TabIndex = 20;
            this.cmbtiposeguridad.SelectedIndexChanged += new System.EventHandler(this.cmbtiposeguridad_SelectedIndexChanged);
            // 
            // txtpuertoSalida
            // 
            this.txtpuertoSalida.Location = new System.Drawing.Point(167, 153);
            this.txtpuertoSalida.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtpuertoSalida.Name = "txtpuertoSalida";
            this.txtpuertoSalida.Size = new System.Drawing.Size(71, 20);
            this.txtpuertoSalida.TabIndex = 14;
            // 
            // lbPuertoSalida
            // 
            this.lbPuertoSalida.AutoSize = true;
            this.lbPuertoSalida.Location = new System.Drawing.Point(18, 153);
            this.lbPuertoSalida.Name = "lbPuertoSalida";
            this.lbPuertoSalida.Size = new System.Drawing.Size(132, 13);
            this.lbPuertoSalida.TabIndex = 10;
            this.lbPuertoSalida.Text = "Servidor de Salida(SMTP):";
            // 
            // btnCuentaPredeterminada
            // 
            this.btnCuentaPredeterminada.Location = new System.Drawing.Point(268, 44);
            this.btnCuentaPredeterminada.Name = "btnCuentaPredeterminada";
            this.btnCuentaPredeterminada.Size = new System.Drawing.Size(143, 23);
            this.btnCuentaPredeterminada.TabIndex = 18;
            this.btnCuentaPredeterminada.Text = "Usar Predeterminados";
            this.btnCuentaPredeterminada.UseVisualStyleBackColor = true;
            this.btnCuentaPredeterminada.Click += new System.EventHandler(this.btnCuentaPredeterminada_Click);
            // 
            // lbPuertoentrante
            // 
            this.lbPuertoentrante.AutoSize = true;
            this.lbPuertoentrante.Location = new System.Drawing.Point(18, 48);
            this.lbPuertoentrante.Name = "lbPuertoentrante";
            this.lbPuertoentrante.Size = new System.Drawing.Size(104, 13);
            this.lbPuertoentrante.TabIndex = 12;
            this.lbPuertoentrante.Text = "Servidor de Entrada:";
            // 
            // TxtPuertoEntada
            // 
            this.TxtPuertoEntada.Location = new System.Drawing.Point(167, 46);
            this.TxtPuertoEntada.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.TxtPuertoEntada.Name = "TxtPuertoEntada";
            this.TxtPuertoEntada.Size = new System.Drawing.Size(71, 20);
            this.TxtPuertoEntada.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Numero de Puertos del Servidor";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(427, 243);
            this.shapeContainer2.TabIndex = 18;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 17;
            this.lineShape2.X2 = 406;
            this.lineShape2.Y1 = 131;
            this.lineShape2.Y2 = 131;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 164;
            this.lineShape1.X2 = 407;
            this.lineShape1.Y1 = 18;
            this.lineShape1.Y2 = 18;
            // 
            // btnTesCuenta
            // 
            this.btnTesCuenta.Location = new System.Drawing.Point(685, 97);
            this.btnTesCuenta.Name = "btnTesCuenta";
            this.btnTesCuenta.Size = new System.Drawing.Size(250, 23);
            this.btnTesCuenta.TabIndex = 13;
            this.btnTesCuenta.Text = "Probar configuracion de cuenta";
            this.btnTesCuenta.UseVisualStyleBackColor = true;
            this.btnTesCuenta.Click += new System.EventHandler(this.btnTesCuenta_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(682, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 39);
            this.label8.TabIndex = 12;
            this.label8.Text = "Le recomendamos que pruebe  su cuenta para garantizar que las entradas sean corre" +
    "ctas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(691, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Configuracion de la Cuenta:";
            // 
            // groupBoxInfosesion
            // 
            this.groupBoxInfosesion.Controls.Add(this.TxtContraseña);
            this.groupBoxInfosesion.Controls.Add(this.lbContraseña);
            this.groupBoxInfosesion.Controls.Add(this.TxtNombreUsuario);
            this.groupBoxInfosesion.Controls.Add(this.label3);
            this.groupBoxInfosesion.Location = new System.Drawing.Point(6, 407);
            this.groupBoxInfosesion.Name = "groupBoxInfosesion";
            this.groupBoxInfosesion.Size = new System.Drawing.Size(444, 96);
            this.groupBoxInfosesion.TabIndex = 5;
            this.groupBoxInfosesion.TabStop = false;
            this.groupBoxInfosesion.Text = "Informacion de Inicio de Sesion";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(191, 39);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(242, 20);
            this.TxtContraseña.TabIndex = 11;
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Location = new System.Drawing.Point(12, 20);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(46, 13);
            this.lbContraseña.TabIndex = 10;
            this.lbContraseña.Text = "Usuario:";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(192, 13);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(241, 20);
            this.TxtNombreUsuario.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // groupBoxServidor
            // 
            this.groupBoxServidor.Controls.Add(this.cmbTipoAutenticacion);
            this.groupBoxServidor.Controls.Add(this.label9);
            this.groupBoxServidor.Controls.Add(this.cmbtipoCuenta);
            this.groupBoxServidor.Controls.Add(this.lbTipoCenta);
            this.groupBoxServidor.Controls.Add(this.TxtServidorSaliente);
            this.groupBoxServidor.Controls.Add(this.label1);
            this.groupBoxServidor.Controls.Add(this.TxtServidorEntrante);
            this.groupBoxServidor.Controls.Add(this.label2);
            this.groupBoxServidor.Location = new System.Drawing.Point(12, 253);
            this.groupBoxServidor.Name = "groupBoxServidor";
            this.groupBoxServidor.Size = new System.Drawing.Size(444, 150);
            this.groupBoxServidor.TabIndex = 4;
            this.groupBoxServidor.TabStop = false;
            this.groupBoxServidor.Text = "Informacion del Servidor";
            this.groupBoxServidor.Enter += new System.EventHandler(this.groupBoxServidor_Enter);
            // 
            // cmbTipoAutenticacion
            // 
            this.cmbTipoAutenticacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAutenticacion.FormattingEnabled = true;
            this.cmbTipoAutenticacion.Location = new System.Drawing.Point(192, 58);
            this.cmbTipoAutenticacion.Name = "cmbTipoAutenticacion";
            this.cmbTipoAutenticacion.Size = new System.Drawing.Size(241, 21);
            this.cmbTipoAutenticacion.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de Authenticacion";
            // 
            // cmbtipoCuenta
            // 
            this.cmbtipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipoCuenta.FormattingEnabled = true;
            this.cmbtipoCuenta.Location = new System.Drawing.Point(192, 19);
            this.cmbtipoCuenta.Name = "cmbtipoCuenta";
            this.cmbtipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.cmbtipoCuenta.TabIndex = 16;
            this.cmbtipoCuenta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbTipoCenta
            // 
            this.lbTipoCenta.AutoSize = true;
            this.lbTipoCenta.Location = new System.Drawing.Point(11, 26);
            this.lbTipoCenta.Name = "lbTipoCenta";
            this.lbTipoCenta.Size = new System.Drawing.Size(80, 13);
            this.lbTipoCenta.TabIndex = 8;
            this.lbTipoCenta.Text = "Tipo de Cuenta";
            // 
            // TxtServidorSaliente
            // 
            this.TxtServidorSaliente.Location = new System.Drawing.Point(191, 123);
            this.TxtServidorSaliente.Name = "TxtServidorSaliente";
            this.TxtServidorSaliente.Size = new System.Drawing.Size(242, 20);
            this.TxtServidorSaliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Servidor de correo Saliente [SMTP]";
            // 
            // TxtServidorEntrante
            // 
            this.TxtServidorEntrante.Location = new System.Drawing.Point(191, 97);
            this.TxtServidorEntrante.Name = "TxtServidorEntrante";
            this.TxtServidorEntrante.Size = new System.Drawing.Size(242, 20);
            this.TxtServidorEntrante.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Servidor de Correo entrante";
            // 
            // groupBoxInfoUsuario
            // 
            this.groupBoxInfoUsuario.Controls.Add(this.gbSeguimiento);
            this.groupBoxInfoUsuario.Controls.Add(this.txtEnviaMail_CbteNoAuto);
            this.groupBoxInfoUsuario.Controls.Add(this.txtenviomail_ctaRespaldo);
            this.groupBoxInfoUsuario.Controls.Add(this.chk_envioMail_Cbte_NoAuto);
            this.groupBoxInfoUsuario.Controls.Add(this.chk_enviar_copia_x_cada_mail_enviado);
            this.groupBoxInfoUsuario.Controls.Add(this.chk_Cuenta_predeterminada);
            this.groupBoxInfoUsuario.Controls.Add(this.txtidCuenta);
            this.groupBoxInfoUsuario.Controls.Add(this.label4);
            this.groupBoxInfoUsuario.Controls.Add(this.txtdirecioncorreoElectronico);
            this.groupBoxInfoUsuario.Controls.Add(this.labelDireccioncoreeo);
            this.groupBoxInfoUsuario.Controls.Add(this.txtSuNombre);
            this.groupBoxInfoUsuario.Controls.Add(this.labelNombre);
            this.groupBoxInfoUsuario.Location = new System.Drawing.Point(6, 0);
            this.groupBoxInfoUsuario.Name = "groupBoxInfoUsuario";
            this.groupBoxInfoUsuario.Size = new System.Drawing.Size(670, 235);
            this.groupBoxInfoUsuario.TabIndex = 3;
            this.groupBoxInfoUsuario.TabStop = false;
            this.groupBoxInfoUsuario.Text = "Informacion sobre el Usuario";
            this.groupBoxInfoUsuario.Enter += new System.EventHandler(this.groupBoxInfoUsuario_Enter);
            // 
            // gbSeguimiento
            // 
            this.gbSeguimiento.Controls.Add(this.chkConfirmacion_de_lectura);
            this.gbSeguimiento.Controls.Add(this.chkConfirmacion_de_entrega);
            this.gbSeguimiento.Location = new System.Drawing.Point(12, 153);
            this.gbSeguimiento.Name = "gbSeguimiento";
            this.gbSeguimiento.Size = new System.Drawing.Size(652, 76);
            this.gbSeguimiento.TabIndex = 23;
            this.gbSeguimiento.Text = "Seguimiento de Correo";
            // 
            // chkConfirmacion_de_lectura
            // 
            this.chkConfirmacion_de_lectura.AutoSize = true;
            this.chkConfirmacion_de_lectura.Checked = true;
            this.chkConfirmacion_de_lectura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConfirmacion_de_lectura.Location = new System.Drawing.Point(31, 47);
            this.chkConfirmacion_de_lectura.Name = "chkConfirmacion_de_lectura";
            this.chkConfirmacion_de_lectura.Size = new System.Drawing.Size(311, 17);
            this.chkConfirmacion_de_lectura.TabIndex = 20;
            this.chkConfirmacion_de_lectura.Text = "Confirmación de lectura de que el destinatario vio el mensaje";
            this.chkConfirmacion_de_lectura.UseVisualStyleBackColor = true;
            // 
            // chkConfirmacion_de_entrega
            // 
            this.chkConfirmacion_de_entrega.AutoSize = true;
            this.chkConfirmacion_de_entrega.Checked = true;
            this.chkConfirmacion_de_entrega.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConfirmacion_de_entrega.Location = new System.Drawing.Point(31, 24);
            this.chkConfirmacion_de_entrega.Name = "chkConfirmacion_de_entrega";
            this.chkConfirmacion_de_entrega.Size = new System.Drawing.Size(511, 17);
            this.chkConfirmacion_de_entrega.TabIndex = 18;
            this.chkConfirmacion_de_entrega.Text = "Confirmación de entrega de que el mensaje se entrego al servidor de correo electr" +
    "ónico del destinatario";
            this.chkConfirmacion_de_entrega.UseVisualStyleBackColor = true;
            // 
            // txtEnviaMail_CbteNoAuto
            // 
            this.txtEnviaMail_CbteNoAuto.Location = new System.Drawing.Point(380, 117);
            this.txtEnviaMail_CbteNoAuto.Name = "txtEnviaMail_CbteNoAuto";
            this.txtEnviaMail_CbteNoAuto.Size = new System.Drawing.Size(284, 20);
            this.txtEnviaMail_CbteNoAuto.TabIndex = 21;
            // 
            // txtenviomail_ctaRespaldo
            // 
            this.txtenviomail_ctaRespaldo.Location = new System.Drawing.Point(380, 94);
            this.txtenviomail_ctaRespaldo.Name = "txtenviomail_ctaRespaldo";
            this.txtenviomail_ctaRespaldo.Size = new System.Drawing.Size(284, 20);
            this.txtenviomail_ctaRespaldo.TabIndex = 20;
            // 
            // chk_envioMail_Cbte_NoAuto
            // 
            this.chk_envioMail_Cbte_NoAuto.AutoSize = true;
            this.chk_envioMail_Cbte_NoAuto.Checked = true;
            this.chk_envioMail_Cbte_NoAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_envioMail_Cbte_NoAuto.Location = new System.Drawing.Point(6, 117);
            this.chk_envioMail_Cbte_NoAuto.Name = "chk_envioMail_Cbte_NoAuto";
            this.chk_envioMail_Cbte_NoAuto.Size = new System.Drawing.Size(373, 17);
            this.chk_envioMail_Cbte_NoAuto.TabIndex = 19;
            this.chk_envioMail_Cbte_NoAuto.Text = "Enviar un correo de Informe por cada Comprobante NO AUTORIZADO a:";
            this.chk_envioMail_Cbte_NoAuto.UseVisualStyleBackColor = true;
            // 
            // chk_enviar_copia_x_cada_mail_enviado
            // 
            this.chk_enviar_copia_x_cada_mail_enviado.AutoSize = true;
            this.chk_enviar_copia_x_cada_mail_enviado.Checked = true;
            this.chk_enviar_copia_x_cada_mail_enviado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_enviar_copia_x_cada_mail_enviado.Location = new System.Drawing.Point(6, 96);
            this.chk_enviar_copia_x_cada_mail_enviado.Name = "chk_enviar_copia_x_cada_mail_enviado";
            this.chk_enviar_copia_x_cada_mail_enviado.Size = new System.Drawing.Size(368, 17);
            this.chk_enviar_copia_x_cada_mail_enviado.TabIndex = 17;
            this.chk_enviar_copia_x_cada_mail_enviado.Text = "Enviar una copia  por cada mail  a esta cuenta (como respaldo de envio)";
            this.chk_enviar_copia_x_cada_mail_enviado.UseVisualStyleBackColor = true;
            // 
            // chk_Cuenta_predeterminada
            // 
            this.chk_Cuenta_predeterminada.AutoSize = true;
            this.chk_Cuenta_predeterminada.Location = new System.Drawing.Point(527, 22);
            this.chk_Cuenta_predeterminada.Name = "chk_Cuenta_predeterminada";
            this.chk_Cuenta_predeterminada.Size = new System.Drawing.Size(137, 17);
            this.chk_Cuenta_predeterminada.TabIndex = 16;
            this.chk_Cuenta_predeterminada.Text = "Cuenta Predeterminada";
            this.chk_Cuenta_predeterminada.UseVisualStyleBackColor = true;
            // 
            // txtidCuenta
            // 
            this.txtidCuenta.Location = new System.Drawing.Point(197, 19);
            this.txtidCuenta.Name = "txtidCuenta";
            this.txtidCuenta.Size = new System.Drawing.Size(138, 20);
            this.txtidCuenta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id Cuenta:";
            // 
            // txtdirecioncorreoElectronico
            // 
            this.txtdirecioncorreoElectronico.Location = new System.Drawing.Point(197, 69);
            this.txtdirecioncorreoElectronico.Name = "txtdirecioncorreoElectronico";
            this.txtdirecioncorreoElectronico.Size = new System.Drawing.Size(467, 20);
            this.txtdirecioncorreoElectronico.TabIndex = 3;
            this.txtdirecioncorreoElectronico.TextChanged += new System.EventHandler(this.txtdirecioncorreoElectronico_TextChanged);
            // 
            // labelDireccioncoreeo
            // 
            this.labelDireccioncoreeo.AutoSize = true;
            this.labelDireccioncoreeo.Location = new System.Drawing.Point(6, 69);
            this.labelDireccioncoreeo.Name = "labelDireccioncoreeo";
            this.labelDireccioncoreeo.Size = new System.Drawing.Size(156, 13);
            this.labelDireccioncoreeo.TabIndex = 2;
            this.labelDireccioncoreeo.Text = "Direccion de correo Electronico";
            // 
            // txtSuNombre
            // 
            this.txtSuNombre.Location = new System.Drawing.Point(197, 45);
            this.txtSuNombre.Name = "txtSuNombre";
            this.txtSuNombre.Size = new System.Drawing.Size(467, 20);
            this.txtSuNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 45);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Su nombre";
            // 
            // ErrProvider
            // 
            this.ErrProvider.ContainerControl = this;
            // 
            // UC_Cuenta_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "UC_Cuenta_Mant";
            this.Size = new System.Drawing.Size(950, 534);
            this.Load += new System.EventHandler(this.UC_Cuenta_Mant_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpuertoSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPuertoEntada)).EndInit();
            this.groupBoxInfosesion.ResumeLayout(false);
            this.groupBoxInfosesion.PerformLayout();
            this.groupBoxServidor.ResumeLayout(false);
            this.groupBoxServidor.PerformLayout();
            this.groupBoxInfoUsuario.ResumeLayout(false);
            this.groupBoxInfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSeguimiento)).EndInit();
            this.gbSeguimiento.ResumeLayout(false);
            this.gbSeguimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnviaMail_CbteNoAuto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenviomail_ctaRespaldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.GroupBox groupBoxInfosesion;
        private System.Windows.Forms.GroupBox groupBoxServidor;
        private System.Windows.Forms.Label lbTipoCenta;
        private System.Windows.Forms.TextBox TxtServidorSaliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtServidorEntrante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxInfoUsuario;
        private System.Windows.Forms.TextBox txtdirecioncorreoElectronico;
        private System.Windows.Forms.Label labelDireccioncoreeo;
        private System.Windows.Forms.TextBox txtSuNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label lbPuertoentrante;
        private System.Windows.Forms.Label lbPuertoSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TxtPuertoEntada;
        private System.Windows.Forms.NumericUpDown txtpuertoSalida;
        private System.Windows.Forms.ErrorProvider ErrProvider;
        private System.Windows.Forms.ComboBox cmbtipoCuenta;
        private System.Windows.Forms.CheckBox chk_Cuenta_predeterminada;
        private System.Windows.Forms.Button btnTesCuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbtiposeguridad;
        private System.Windows.Forms.Button btnCuentaPredeterminada;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.CheckBox chk_enviar_copia_x_cada_mail_enviado;
        private System.Windows.Forms.CheckBox chk_UseDefaultCredentials;
        private System.Windows.Forms.CheckBox chk_envioMail_Cbte_NoAuto;
        private DevExpress.XtraEditors.TextEdit txtenviomail_ctaRespaldo;
        private DevExpress.XtraEditors.TextEdit txtEnviaMail_CbteNoAuto;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        public System.Windows.Forms.ToolStripButton BtnGuardar;
        private System.Windows.Forms.CheckBox chkCopiaCorreo;
        private System.Windows.Forms.CheckBox chkConexCifra;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown txtDiasServer;
        private System.Windows.Forms.ComboBox cmbTipoAutenticacion;
        private System.Windows.Forms.TextBox txtPassword_smtp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuario_smtp;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.GroupControl gbSeguimiento;
        private System.Windows.Forms.CheckBox chkConfirmacion_de_lectura;
        private System.Windows.Forms.CheckBox chkConfirmacion_de_entrega;
    }
}
