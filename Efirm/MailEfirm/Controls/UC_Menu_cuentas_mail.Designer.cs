namespace MailEfirm.Controls
{
    partial class UC_Menu_cuentas_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Menu_cuentas_mail));
            this.panelMain = new System.Windows.Forms.Panel();
            this.treeListMenuMail = new DevExpress.XtraTreeList.TreeList();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenuMail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.treeListMenuMail);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(246, 326);
            this.panelMain.TabIndex = 0;
            // 
            // treeListMenuMail
            // 
            this.treeListMenuMail.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.treeListMenuMail.ActiveFilterEnabled = false;
            this.treeListMenuMail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeListMenuMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenuMail.Location = new System.Drawing.Point(0, 0);
            this.treeListMenuMail.Name = "treeListMenuMail";
            this.treeListMenuMail.BeginUnboundLoad();
            this.treeListMenuMail.AppendNode(new object[0], -1);
            this.treeListMenuMail.AppendNode(new object[0], 0);
            this.treeListMenuMail.EndUnboundLoad();
            this.treeListMenuMail.OptionsBehavior.Editable = false;
            this.treeListMenuMail.OptionsPrint.PrintHorzLines = false;
            this.treeListMenuMail.OptionsPrint.PrintPageHeader = false;
            this.treeListMenuMail.OptionsPrint.PrintReportFooter = false;
            this.treeListMenuMail.OptionsPrint.PrintTree = false;
            this.treeListMenuMail.OptionsPrint.PrintTreeButtons = false;
            this.treeListMenuMail.OptionsPrint.PrintVertLines = false;
            this.treeListMenuMail.OptionsPrint.UsePrintStyles = true;
            this.treeListMenuMail.OptionsView.ShowButtons = false;
            this.treeListMenuMail.OptionsView.ShowColumns = false;
            this.treeListMenuMail.OptionsView.ShowHorzLines = false;
            this.treeListMenuMail.OptionsView.ShowIndicator = false;
            this.treeListMenuMail.OptionsView.ShowVertLines = false;
            this.treeListMenuMail.SelectImageList = this.imageList1;
            this.treeListMenuMail.Size = new System.Drawing.Size(246, 326);
            this.treeListMenuMail.StateImageList = this.imageList1;
            this.treeListMenuMail.TabIndex = 1;
            this.treeListMenuMail.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListMenuMail_AfterFocusNode);
            this.treeListMenuMail.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListMenuMail_FocusedNodeChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Principal");
            this.imageList1.Images.SetKeyName(1, "Buzon_Ent");
            this.imageList1.Images.SetKeyName(2, "Buzon_Sal");
            this.imageList1.Images.SetKeyName(3, "Enviado");
            this.imageList1.Images.SetKeyName(4, "Eliminado");
            this.imageList1.Images.SetKeyName(5, "Borrador");
            this.imageList1.Images.SetKeyName(6, "Mail_NO_Env_x_error");
            // 
            // UC_Menu_cuentas_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "UC_Menu_cuentas_mail";
            this.Size = new System.Drawing.Size(246, 326);
            this.Load += new System.EventHandler(this.UC_Menu_cuentas_mail_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenuMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTreeList.TreeList treeListMenuMail;
    }
}
