namespace Efirm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtpagina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.gridControl_Buzon_Ent = new DevExpress.XtraGrid.GridControl();
            this.gridView_Buzon_Ent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsunto_texto_mostrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiene_Adjunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRespondido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo_Leido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTexto_mensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_Mensaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdContribuyente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmail_remitente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPara_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMensaje1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMosTrar_icono_Ride = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMosTrar_icono_xml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Buzon_Ent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Buzon_Ent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(920, 32);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(475, 415);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(102, 20);
            this.txtIndice.TabIndex = 3;
            // 
            // txtpagina
            // 
            this.txtpagina.Location = new System.Drawing.Point(295, 415);
            this.txtpagina.Name = "txtpagina";
            this.txtpagina.Size = new System.Drawing.Size(102, 20);
            this.txtpagina.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "pagina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Indice";
            // 
            // btnCorreo
            // 
            this.btnCorreo.Location = new System.Drawing.Point(456, 12);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(75, 23);
            this.btnCorreo.TabIndex = 5;
            this.btnCorreo.Text = "correo";
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // gridControl_Buzon_Ent
            // 
            this.gridControl_Buzon_Ent.Location = new System.Drawing.Point(12, 92);
            this.gridControl_Buzon_Ent.MainView = this.gridView_Buzon_Ent;
            this.gridControl_Buzon_Ent.Name = "gridControl_Buzon_Ent";
            this.gridControl_Buzon_Ent.Size = new System.Drawing.Size(978, 27);
            this.gridControl_Buzon_Ent.TabIndex = 6;
            this.gridControl_Buzon_Ent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Buzon_Ent});
            // 
            // gridView_Buzon_Ent
            // 
            this.gridView_Buzon_Ent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMensaje,
            this.colFecha,
            this.colPara,
            this.colAsunto,
            this.colAsunto_texto_mostrado,
            this.colTiene_Adjunto,
            this.colPrioridad,
            this.colLeido,
            this.colRespondido,
            this.colNo_Leido,
            this.colTexto_mensaje,
            this.colIdTipo_Mensaje,
            this.colEliminado,
            this.colIdContribuyente,
            this.colmail_remitente,
            this.colPara_CC});
            this.gridView_Buzon_Ent.GridControl = this.gridControl_Buzon_Ent;
            this.gridView_Buzon_Ent.Name = "gridView_Buzon_Ent";
            // 
            // colIdMensaje
            // 
            this.colIdMensaje.Caption = "IdMensaje";
            this.colIdMensaje.FieldName = "IdMensaje";
            this.colIdMensaje.Name = "colIdMensaje";
            this.colIdMensaje.Visible = true;
            this.colIdMensaje.VisibleIndex = 0;
            this.colIdMensaje.Width = 60;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 73;
            // 
            // colPara
            // 
            this.colPara.Caption = "Para";
            this.colPara.FieldName = "Para";
            this.colPara.Name = "colPara";
            this.colPara.Visible = true;
            this.colPara.VisibleIndex = 2;
            this.colPara.Width = 138;
            // 
            // colAsunto
            // 
            this.colAsunto.Caption = "Asunto";
            this.colAsunto.FieldName = "Asunto";
            this.colAsunto.Name = "colAsunto";
            this.colAsunto.Visible = true;
            this.colAsunto.VisibleIndex = 3;
            this.colAsunto.Width = 104;
            // 
            // colAsunto_texto_mostrado
            // 
            this.colAsunto_texto_mostrado.Caption = "Asunto_texto_mostrado";
            this.colAsunto_texto_mostrado.FieldName = "Asunto_texto_mostrado";
            this.colAsunto_texto_mostrado.Name = "colAsunto_texto_mostrado";
            this.colAsunto_texto_mostrado.Visible = true;
            this.colAsunto_texto_mostrado.VisibleIndex = 4;
            this.colAsunto_texto_mostrado.Width = 121;
            // 
            // colTiene_Adjunto
            // 
            this.colTiene_Adjunto.Caption = "Tiene_Adjunto";
            this.colTiene_Adjunto.FieldName = "Tiene_Adjunto";
            this.colTiene_Adjunto.Name = "colTiene_Adjunto";
            this.colTiene_Adjunto.Visible = true;
            this.colTiene_Adjunto.VisibleIndex = 5;
            this.colTiene_Adjunto.Width = 60;
            // 
            // colPrioridad
            // 
            this.colPrioridad.Caption = "Prioridad";
            this.colPrioridad.FieldName = "Prioridad";
            this.colPrioridad.Name = "colPrioridad";
            this.colPrioridad.Visible = true;
            this.colPrioridad.VisibleIndex = 6;
            this.colPrioridad.Width = 60;
            // 
            // colLeido
            // 
            this.colLeido.Caption = "Leido";
            this.colLeido.FieldName = "Leido";
            this.colLeido.Name = "colLeido";
            this.colLeido.Visible = true;
            this.colLeido.VisibleIndex = 7;
            this.colLeido.Width = 60;
            // 
            // colRespondido
            // 
            this.colRespondido.Caption = "Respondido";
            this.colRespondido.FieldName = "Respondido";
            this.colRespondido.Name = "colRespondido";
            this.colRespondido.Visible = true;
            this.colRespondido.VisibleIndex = 8;
            this.colRespondido.Width = 60;
            // 
            // colNo_Leido
            // 
            this.colNo_Leido.Caption = "No_Leido";
            this.colNo_Leido.FieldName = "No_Leido";
            this.colNo_Leido.Name = "colNo_Leido";
            this.colNo_Leido.Visible = true;
            this.colNo_Leido.VisibleIndex = 9;
            this.colNo_Leido.Width = 60;
            // 
            // colTexto_mensaje
            // 
            this.colTexto_mensaje.Caption = "Texto_mensaje";
            this.colTexto_mensaje.FieldName = "Texto_mensaje";
            this.colTexto_mensaje.Name = "colTexto_mensaje";
            this.colTexto_mensaje.Visible = true;
            this.colTexto_mensaje.VisibleIndex = 10;
            this.colTexto_mensaje.Width = 60;
            // 
            // colIdTipo_Mensaje
            // 
            this.colIdTipo_Mensaje.Caption = "IdTipo_Mensaje";
            this.colIdTipo_Mensaje.FieldName = "IdTipo_Mensaje";
            this.colIdTipo_Mensaje.Name = "colIdTipo_Mensaje";
            this.colIdTipo_Mensaje.Visible = true;
            this.colIdTipo_Mensaje.VisibleIndex = 11;
            this.colIdTipo_Mensaje.Width = 60;
            // 
            // colEliminado
            // 
            this.colEliminado.Caption = "Eliminado";
            this.colEliminado.FieldName = "Eliminado";
            this.colEliminado.Name = "colEliminado";
            this.colEliminado.Visible = true;
            this.colEliminado.VisibleIndex = 12;
            this.colEliminado.Width = 60;
            // 
            // colIdContribuyente
            // 
            this.colIdContribuyente.Caption = "IdContribuyente";
            this.colIdContribuyente.FieldName = "IdContribuyente";
            this.colIdContribuyente.Name = "colIdContribuyente";
            this.colIdContribuyente.Visible = true;
            this.colIdContribuyente.VisibleIndex = 13;
            this.colIdContribuyente.Width = 60;
            // 
            // colmail_remitente
            // 
            this.colmail_remitente.Caption = "mail_remitente";
            this.colmail_remitente.FieldName = "mail_remitente";
            this.colmail_remitente.Name = "colmail_remitente";
            this.colmail_remitente.Visible = true;
            this.colmail_remitente.VisibleIndex = 14;
            this.colmail_remitente.Width = 60;
            // 
            // colPara_CC
            // 
            this.colPara_CC.Caption = "Para_CC";
            this.colPara_CC.FieldName = "Para_CC";
            this.colPara_CC.Name = "colPara_CC";
            this.colPara_CC.Visible = true;
            this.colPara_CC.VisibleIndex = 15;
            this.colPara_CC.Width = 84;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(12, 134);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(969, 207);
            this.gridControl2.TabIndex = 8;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMensaje1,
            this.colMosTrar_icono_Ride,
            this.colMosTrar_icono_xml});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            // 
            // colIdMensaje1
            // 
            this.colIdMensaje1.Caption = "IdMensaje";
            this.colIdMensaje1.FieldName = "IdMensaje";
            this.colIdMensaje1.Name = "colIdMensaje1";
            this.colIdMensaje1.OptionsColumn.AllowEdit = false;
            this.colIdMensaje1.Visible = true;
            this.colIdMensaje1.VisibleIndex = 0;
            // 
            // colMosTrar_icono_Ride
            // 
            this.colMosTrar_icono_Ride.Caption = "Ride";
            this.colMosTrar_icono_Ride.FieldName = "MosTrar_icono_Ride";
            this.colMosTrar_icono_Ride.Name = "colMosTrar_icono_Ride";
            this.colMosTrar_icono_Ride.OptionsColumn.AllowEdit = false;
            this.colMosTrar_icono_Ride.Visible = true;
            this.colMosTrar_icono_Ride.VisibleIndex = 1;
            // 
            // colMosTrar_icono_xml
            // 
            this.colMosTrar_icono_xml.Caption = "xml";
            this.colMosTrar_icono_xml.FieldName = "MosTrar_icono_xml";
            this.colMosTrar_icono_xml.Name = "colMosTrar_icono_xml";
            this.colMosTrar_icono_xml.OptionsColumn.AllowEdit = false;
            this.colMosTrar_icono_xml.Visible = true;
            this.colMosTrar_icono_xml.VisibleIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(668, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 61);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 447);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gridControl_Buzon_Ent);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpagina);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Buzon_Ent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Buzon_Ent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtpagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCorreo;
        private DevExpress.XtraGrid.GridControl gridControl_Buzon_Ent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Buzon_Ent;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colPara;
        private DevExpress.XtraGrid.Columns.GridColumn colAsunto;
        private DevExpress.XtraGrid.Columns.GridColumn colAsunto_texto_mostrado;
        private DevExpress.XtraGrid.Columns.GridColumn colTiene_Adjunto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrioridad;
        private DevExpress.XtraGrid.Columns.GridColumn colLeido;
        private DevExpress.XtraGrid.Columns.GridColumn colRespondido;
        private DevExpress.XtraGrid.Columns.GridColumn colNo_Leido;
        private DevExpress.XtraGrid.Columns.GridColumn colTexto_mensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_Mensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdContribuyente;
        private DevExpress.XtraGrid.Columns.GridColumn colmail_remitente;
        private DevExpress.XtraGrid.Columns.GridColumn colPara_CC;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMensaje1;
        private DevExpress.XtraGrid.Columns.GridColumn colMosTrar_icono_Ride;
        private DevExpress.XtraGrid.Columns.GridColumn colMosTrar_icono_xml;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button4;
    }
}