
namespace ConsultaPSI.Consulta
{
    partial class FrmAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendamento));
            this.lblPaciente = new System.Windows.Forms.Label();
            this.gridLookUpEditPaciente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblPsicologa = new System.Windows.Forms.Label();
            this.gridLookUpEditPsicologa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblProposito = new System.Windows.Forms.Label();
            this.txtProposito = new DevExpress.XtraEditors.TextEdit();
            this.lblDataEHora = new System.Windows.Forms.Label();
            this.dateEditConsulta = new DevExpress.XtraEditors.DateEdit();
            this.timeSpanEditHora = new DevExpress.XtraEditors.TimeSpanEdit();
            this.lblTempoDaConsulta = new System.Windows.Forms.Label();
            this.cmbTempoDeConsulta = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumnPsicologo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPaciente = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPaciente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPsicologa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsulta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEditHora.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblPaciente.Location = new System.Drawing.Point(17, 57);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(80, 23);
            this.lblPaciente.TabIndex = 24;
            this.lblPaciente.Text = "Paciente";
            // 
            // gridLookUpEditPaciente
            // 
            this.gridLookUpEditPaciente.Location = new System.Drawing.Point(21, 90);
            this.gridLookUpEditPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridLookUpEditPaciente.Name = "gridLookUpEditPaciente";
            this.gridLookUpEditPaciente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditPaciente.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditPaciente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditPaciente.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditPaciente.Size = new System.Drawing.Size(622, 30);
            this.gridLookUpEditPaciente.TabIndex = 25;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPaciente});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblPsicologa
            // 
            this.lblPsicologa.AutoSize = true;
            this.lblPsicologa.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsicologa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblPsicologa.Location = new System.Drawing.Point(17, 153);
            this.lblPsicologa.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPsicologa.Name = "lblPsicologa";
            this.lblPsicologa.Size = new System.Drawing.Size(86, 23);
            this.lblPsicologa.TabIndex = 26;
            this.lblPsicologa.Text = "Psicologa";
            // 
            // gridLookUpEditPsicologa
            // 
            this.gridLookUpEditPsicologa.Location = new System.Drawing.Point(21, 185);
            this.gridLookUpEditPsicologa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridLookUpEditPsicologa.Name = "gridLookUpEditPsicologa";
            this.gridLookUpEditPsicologa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditPsicologa.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditPsicologa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditPsicologa.Properties.PopupView = this.gridView1;
            this.gridLookUpEditPsicologa.Size = new System.Drawing.Size(622, 30);
            this.gridLookUpEditPsicologa.TabIndex = 27;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPsicologo});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lblProposito
            // 
            this.lblProposito.AutoSize = true;
            this.lblProposito.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProposito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblProposito.Location = new System.Drawing.Point(17, 251);
            this.lblProposito.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProposito.Name = "lblProposito";
            this.lblProposito.Size = new System.Drawing.Size(86, 23);
            this.lblProposito.TabIndex = 28;
            this.lblProposito.Text = "Propósito";
            // 
            // txtProposito
            // 
            this.txtProposito.Location = new System.Drawing.Point(21, 283);
            this.txtProposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProposito.Name = "txtProposito";
            this.txtProposito.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProposito.Properties.Appearance.Options.UseFont = true;
            this.txtProposito.Size = new System.Drawing.Size(621, 30);
            this.txtProposito.TabIndex = 29;
            // 
            // lblDataEHora
            // 
            this.lblDataEHora.AutoSize = true;
            this.lblDataEHora.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblDataEHora.Location = new System.Drawing.Point(17, 347);
            this.lblDataEHora.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDataEHora.Name = "lblDataEHora";
            this.lblDataEHora.Size = new System.Drawing.Size(71, 23);
            this.lblDataEHora.TabIndex = 30;
            this.lblDataEHora.Text = "Horário";
            // 
            // dateEditConsulta
            // 
            this.dateEditConsulta.EditValue = null;
            this.dateEditConsulta.Location = new System.Drawing.Point(17, 380);
            this.dateEditConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateEditConsulta.Name = "dateEditConsulta";
            this.dateEditConsulta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditConsulta.Properties.Appearance.Options.UseFont = true;
            this.dateEditConsulta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditConsulta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditConsulta.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditConsulta.Size = new System.Drawing.Size(191, 30);
            this.dateEditConsulta.TabIndex = 31;
            // 
            // timeSpanEditHora
            // 
            this.timeSpanEditHora.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timeSpanEditHora.Location = new System.Drawing.Point(217, 380);
            this.timeSpanEditHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeSpanEditHora.Name = "timeSpanEditHora";
            this.timeSpanEditHora.Properties.AllowEditDays = false;
            this.timeSpanEditHora.Properties.AllowEditSeconds = false;
            this.timeSpanEditHora.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpanEditHora.Properties.Appearance.Options.UseFont = true;
            this.timeSpanEditHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeSpanEditHora.Size = new System.Drawing.Size(146, 30);
            this.timeSpanEditHora.TabIndex = 33;
            // 
            // lblTempoDaConsulta
            // 
            this.lblTempoDaConsulta.AutoSize = true;
            this.lblTempoDaConsulta.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoDaConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblTempoDaConsulta.Location = new System.Drawing.Point(17, 443);
            this.lblTempoDaConsulta.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTempoDaConsulta.Name = "lblTempoDaConsulta";
            this.lblTempoDaConsulta.Size = new System.Drawing.Size(172, 23);
            this.lblTempoDaConsulta.TabIndex = 34;
            this.lblTempoDaConsulta.Text = "Tempo da Consulta";
            // 
            // cmbTempoDeConsulta
            // 
            this.cmbTempoDeConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTempoDeConsulta.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTempoDeConsulta.FormattingEnabled = true;
            this.cmbTempoDeConsulta.Items.AddRange(new object[] {
            "30 Minutos",
            "60 Minutos"});
            this.cmbTempoDeConsulta.Location = new System.Drawing.Point(21, 475);
            this.cmbTempoDeConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTempoDeConsulta.Name = "cmbTempoDeConsulta";
            this.cmbTempoDeConsulta.Size = new System.Drawing.Size(191, 31);
            this.cmbTempoDeConsulta.TabIndex = 39;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnConfirmar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.Image")));
            this.btnConfirmar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(495, 517);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(45, 38);
            this.btnConfirmar.TabIndex = 40;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelar.Location = new System.Drawing.Point(546, 517);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 38);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSair.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.ImageOptions.Image")));
            this.btnSair.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSair.Location = new System.Drawing.Point(597, 517);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 38);
            this.btnSair.TabIndex = 42;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gridColumnPsicologo
            // 
            this.gridColumnPsicologo.Caption = "Psicologo";
            this.gridColumnPsicologo.FieldName = "Nome";
            this.gridColumnPsicologo.Name = "gridColumnPsicologo";
            this.gridColumnPsicologo.Visible = true;
            this.gridColumnPsicologo.VisibleIndex = 0;
            // 
            // gridColumnPaciente
            // 
            this.gridColumnPaciente.Caption = "Nome";
            this.gridColumnPaciente.FieldName = "Nome";
            this.gridColumnPaciente.Name = "gridColumnPaciente";
            this.gridColumnPaciente.Visible = true;
            this.gridColumnPaciente.VisibleIndex = 0;
            // 
            // FrmAgendamento
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(687, 599);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cmbTempoDeConsulta);
            this.Controls.Add(this.lblTempoDaConsulta);
            this.Controls.Add(this.timeSpanEditHora);
            this.Controls.Add(this.dateEditConsulta);
            this.Controls.Add(this.lblDataEHora);
            this.Controls.Add(this.txtProposito);
            this.Controls.Add(this.lblProposito);
            this.Controls.Add(this.gridLookUpEditPsicologa);
            this.Controls.Add(this.lblPsicologa);
            this.Controls.Add(this.gridLookUpEditPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FrmAgendamento_Load);
            this.Shown += new System.EventHandler(this.FrmAgendamento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPaciente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPsicologa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProposito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsulta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEditHora.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditPaciente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label lblPsicologa;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditPsicologa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblProposito;
        private DevExpress.XtraEditors.TextEdit txtProposito;
        private System.Windows.Forms.Label lblDataEHora;
        private DevExpress.XtraEditors.DateEdit dateEditConsulta;
        private DevExpress.XtraEditors.TimeSpanEdit timeSpanEditHora;
        private System.Windows.Forms.Label lblTempoDaConsulta;
        private System.Windows.Forms.ComboBox cmbTempoDeConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPaciente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPsicologo;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSair;
    }
}