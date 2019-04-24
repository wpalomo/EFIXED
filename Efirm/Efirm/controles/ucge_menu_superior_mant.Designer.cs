namespace Efirms
{
    partial class ucge_menu_superior_mant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_guardar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_guardar_salir = new DevExpress.XtraBars.BarButtonItem();
            this.btn_limpiar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_anular = new DevExpress.XtraBars.BarButtonItem();
            this.btn_salir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_imprimir = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_guardar,
            this.btn_guardar_salir,
            this.btn_limpiar,
            this.btn_anular,
            this.btn_salir,
            this.btn_imprimir});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_guardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_guardar_salir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_limpiar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_anular, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_salir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_imprimir)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Caption = "Guardar y nuevo";
            this.btn_guardar.Glyph = global::Core.Erp.Winform.Properties.Resources.Guardar_16x16;
            this.btn_guardar.Id = 0;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_guardar_ItemClick);
            // 
            // btn_guardar_salir
            // 
            this.btn_guardar_salir.Caption = "Guardar y salir";
            this.btn_guardar_salir.Glyph = global::Core.Erp.Winform.Properties.Resources.Guardar_salir_16x16;
            this.btn_guardar_salir.Id = 1;
            this.btn_guardar_salir.Name = "btn_guardar_salir";
            this.btn_guardar_salir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_guardar_salir_ItemClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Caption = "Limpiar";
            this.btn_limpiar.Glyph = global::Core.Erp.Winform.Properties.Resources.Limpiar_16x16;
            this.btn_limpiar.Id = 2;
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_limpiar_ItemClick);
            // 
            // btn_anular
            // 
            this.btn_anular.Caption = "Anular";
            this.btn_anular.Glyph = global::Core.Erp.Winform.Properties.Resources.Anular_16x16;
            this.btn_anular.Id = 3;
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_anular_ItemClick);
            // 
            // btn_salir
            // 
            this.btn_salir.Caption = "Salir";
            this.btn_salir.Glyph = global::Core.Erp.Winform.Properties.Resources.salir_16x16;
            this.btn_salir.Id = 4;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_salir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(663, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 24);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(663, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(663, 24);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Caption = "Imprimir";
            this.btn_imprimir.Id = 5;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_imprimir_ItemClick);
            // 
            // ucge_menu_superior_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucge_menu_superior_mant";
            this.Size = new System.Drawing.Size(663, 24);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.BarButtonItem btn_guardar;
        public DevExpress.XtraBars.BarButtonItem btn_guardar_salir;
        public DevExpress.XtraBars.BarButtonItem btn_limpiar;
        public DevExpress.XtraBars.BarButtonItem btn_anular;
        public DevExpress.XtraBars.BarButtonItem btn_salir;
        public DevExpress.XtraBars.BarButtonItem btn_imprimir;
    }
}
