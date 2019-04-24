namespace Efirm
{
    partial class Frm_comprobantes_generados
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_comprobantes_generados));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlCG = new DevExpress.XtraGrid.GridControl();
            this.gridViewCG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Checke = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colID_REGISTRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaCarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox6 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlCG);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 459);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControlCG
            // 
            this.gridControlCG.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlCG.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlCG.Location = new System.Drawing.Point(2, 2);
            this.gridControlCG.MainView = this.gridViewCG;
            this.gridControlCG.Name = "gridControlCG";
            this.gridControlCG.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox4,
            this.repositoryItemImageComboBox5,
            this.repositoryItemImageComboBox6,
            this.repositoryItemImageComboBox1});
            this.gridControlCG.Size = new System.Drawing.Size(780, 455);
            this.gridControlCG.TabIndex = 4;
            this.gridControlCG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCG});
            // 
            // gridViewCG
            // 
            this.gridViewCG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Checke,
            this.colID_REGISTRO,
            this.ColFechaCarga,
            this.colESTADO});
            this.gridViewCG.GridControl = this.gridControlCG;
            this.gridViewCG.Name = "gridViewCG";
            this.gridViewCG.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCG.OptionsView.ShowGroupPanel = false;
            this.gridViewCG.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewCG_RowCellClick);
            // 
            // Checke
            // 
            this.Checke.Caption = "*";
            this.Checke.ColumnEdit = this.repositoryItemImageComboBox1;
            this.Checke.FieldName = "Checked";
            this.Checke.Name = "Checke";
            this.Checke.OptionsColumn.AllowEdit = false;
            this.Checke.Visible = true;
            this.Checke.VisibleIndex = 2;
            this.Checke.Width = 66;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anular1_64x64.png");
            // 
            // colID_REGISTRO
            // 
            this.colID_REGISTRO.Caption = "Documento Nº";
            this.colID_REGISTRO.FieldName = "IdRegistro";
            this.colID_REGISTRO.Name = "colID_REGISTRO";
            this.colID_REGISTRO.OptionsColumn.AllowEdit = false;
            this.colID_REGISTRO.Visible = true;
            this.colID_REGISTRO.VisibleIndex = 0;
            this.colID_REGISTRO.Width = 550;
            // 
            // ColFechaCarga
            // 
            this.ColFechaCarga.Caption = "FECHA_CARGA";
            this.ColFechaCarga.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ColFechaCarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColFechaCarga.FieldName = "FechaCarga";
            this.ColFechaCarga.Name = "ColFechaCarga";
            this.ColFechaCarga.OptionsColumn.AllowEdit = false;
            this.ColFechaCarga.Visible = true;
            this.ColFechaCarga.VisibleIndex = 1;
            this.ColFechaCarga.Width = 146;
            // 
            // colESTADO
            // 
            this.colESTADO.Caption = "Estado";
            this.colESTADO.FieldName = "Estado";
            this.colESTADO.Name = "colESTADO";
            this.colESTADO.Width = 131;
            // 
            // repositoryItemImageComboBox4
            // 
            this.repositoryItemImageComboBox4.AutoHeight = false;
            this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox4.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2)});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            // 
            // repositoryItemImageComboBox5
            // 
            this.repositoryItemImageComboBox5.AutoHeight = false;
            this.repositoryItemImageComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox5.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1)});
            this.repositoryItemImageComboBox5.Name = "repositoryItemImageComboBox5";
            // 
            // repositoryItemImageComboBox6
            // 
            this.repositoryItemImageComboBox6.AutoHeight = false;
            this.repositoryItemImageComboBox6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox6.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", false, 3)});
            this.repositoryItemImageComboBox6.Name = "repositoryItemImageComboBox6";
            // 
            // Frm_comprobantes_generados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frm_comprobantes_generados";
            this.Text = "Comprobantes generados";
            this.Load += new System.EventHandler(this.Frm_comprobantes_generados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlCG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCG;
        private DevExpress.XtraGrid.Columns.GridColumn Checke;
        private DevExpress.XtraGrid.Columns.GridColumn colID_REGISTRO;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaCarga;
        private DevExpress.XtraGrid.Columns.GridColumn colESTADO;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox5;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox6;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}