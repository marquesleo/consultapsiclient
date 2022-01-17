
namespace ConsultaPSI.Consulta
{
    partial class FrmAlterarConsulta
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
            this.panelControlFiltro = new DevExpress.XtraEditors.PanelControl();
            this.labelPaciente = new DevExpress.XtraEditors.LabelControl();
            this.lblPaciente = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelPsicologo = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.timeSpanEditHora = new DevExpress.XtraEditors.TimeSpanEdit();
            this.dateEditConsulta = new DevExpress.XtraEditors.DateEdit();
            this.lblHorario = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmbTempoDeConsulta = new System.Windows.Forms.ComboBox();
            this.lblDuracao = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.labelObservacao = new DevExpress.XtraEditors.LabelControl();
            this.memObservacao = new DevExpress.XtraEditors.MemoEdit();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFiltro)).BeginInit();
            this.panelControlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEditHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsulta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memObservacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlFiltro
            // 
            this.panelControlFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlFiltro.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControlFiltro.Appearance.Options.UseBackColor = true;
            this.panelControlFiltro.Appearance.Options.UseForeColor = true;
            this.panelControlFiltro.AutoSize = true;
            this.panelControlFiltro.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControlFiltro.Controls.Add(this.labelPaciente);
            this.panelControlFiltro.Controls.Add(this.lblPaciente);
            this.panelControlFiltro.Location = new System.Drawing.Point(34, 45);
            this.panelControlFiltro.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControlFiltro.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControlFiltro.Name = "panelControlFiltro";
            this.panelControlFiltro.Size = new System.Drawing.Size(750, 85);
            this.panelControlFiltro.TabIndex = 20;
            // 
            // labelPaciente
            // 
            this.labelPaciente.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaciente.Appearance.Options.UseFont = true;
            this.labelPaciente.Location = new System.Drawing.Point(142, 29);
            this.labelPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(105, 29);
            this.labelPaciente.TabIndex = 3;
            this.labelPaciente.Text = "Psicólogo:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Appearance.Options.UseFont = true;
            this.lblPaciente.Location = new System.Drawing.Point(21, 29);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(97, 29);
            this.lblPaciente.TabIndex = 1;
            this.lblPaciente.Text = "Paciente:";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseForeColor = true;
            this.panelControl1.AutoSize = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelPsicologo);
            this.panelControl1.Location = new System.Drawing.Point(34, 151);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(750, 85);
            this.panelControl1.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 29);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 29);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Psicólogo:";
            // 
            // labelPsicologo
            // 
            this.labelPsicologo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPsicologo.Appearance.Options.UseFont = true;
            this.labelPsicologo.Location = new System.Drawing.Point(142, 29);
            this.labelPsicologo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelPsicologo.Name = "labelPsicologo";
            this.labelPsicologo.Size = new System.Drawing.Size(97, 29);
            this.labelPsicologo.TabIndex = 1;
            this.labelPsicologo.Text = "Paciente:";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Appearance.Options.UseForeColor = true;
            this.panelControl2.AutoSize = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl2.Controls.Add(this.timeSpanEditHora);
            this.panelControl2.Controls.Add(this.dateEditConsulta);
            this.panelControl2.Controls.Add(this.lblHorario);
            this.panelControl2.Location = new System.Drawing.Point(34, 263);
            this.panelControl2.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(750, 85);
            this.panelControl2.TabIndex = 22;
            // 
            // timeSpanEditHora
            // 
            this.timeSpanEditHora.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timeSpanEditHora.Location = new System.Drawing.Point(442, 23);
            this.timeSpanEditHora.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.timeSpanEditHora.Name = "timeSpanEditHora";
            this.timeSpanEditHora.Properties.AllowEditDays = false;
            this.timeSpanEditHora.Properties.AllowEditSeconds = false;
            this.timeSpanEditHora.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpanEditHora.Properties.Appearance.Options.UseFont = true;
            this.timeSpanEditHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeSpanEditHora.Size = new System.Drawing.Size(219, 42);
            this.timeSpanEditHora.TabIndex = 35;
            // 
            // dateEditConsulta
            // 
            this.dateEditConsulta.EditValue = null;
            this.dateEditConsulta.Location = new System.Drawing.Point(142, 23);
            this.dateEditConsulta.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateEditConsulta.Name = "dateEditConsulta";
            this.dateEditConsulta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditConsulta.Properties.Appearance.Options.UseFont = true;
            this.dateEditConsulta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditConsulta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditConsulta.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditConsulta.Size = new System.Drawing.Size(286, 42);
            this.dateEditConsulta.TabIndex = 34;
            // 
            // lblHorario
            // 
            this.lblHorario.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Appearance.Options.UseFont = true;
            this.lblHorario.Location = new System.Drawing.Point(28, 28);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(86, 29);
            this.lblHorario.TabIndex = 1;
            this.lblHorario.Text = "Horário:";
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Appearance.Options.UseForeColor = true;
            this.panelControl3.AutoSize = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl3.Controls.Add(this.cmbTempoDeConsulta);
            this.panelControl3.Controls.Add(this.lblDuracao);
            this.panelControl3.Location = new System.Drawing.Point(34, 368);
            this.panelControl3.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(750, 85);
            this.panelControl3.TabIndex = 23;
            // 
            // cmbTempoDeConsulta
            // 
            this.cmbTempoDeConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTempoDeConsulta.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTempoDeConsulta.FormattingEnabled = true;
            this.cmbTempoDeConsulta.Items.AddRange(new object[] {
            "30 Minutos",
            "60 Minutos"});
            this.cmbTempoDeConsulta.Location = new System.Drawing.Point(142, 20);
            this.cmbTempoDeConsulta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbTempoDeConsulta.Name = "cmbTempoDeConsulta";
            this.cmbTempoDeConsulta.Size = new System.Drawing.Size(284, 42);
            this.cmbTempoDeConsulta.TabIndex = 40;
            // 
            // lblDuracao
            // 
            this.lblDuracao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Appearance.Options.UseFont = true;
            this.lblDuracao.Location = new System.Drawing.Point(21, 29);
            this.lblDuracao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(96, 29);
            this.lblDuracao.TabIndex = 1;
            this.lblDuracao.Text = "Duração:";
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl4.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.Appearance.Options.UseForeColor = true;
            this.panelControl4.AutoSize = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl4.Controls.Add(this.cmbSituacao);
            this.panelControl4.Controls.Add(this.labelStatus);
            this.panelControl4.Location = new System.Drawing.Point(34, 474);
            this.panelControl4.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(750, 85);
            this.panelControl4.TabIndex = 24;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Ocorrido",
            "Não Ocorrido",
            "Cancelado"});
            this.cmbSituacao.Location = new System.Drawing.Point(142, 20);
            this.cmbSituacao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(284, 42);
            this.cmbSituacao.TabIndex = 41;
            // 
            // labelStatus
            // 
            this.labelStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Appearance.Options.UseFont = true;
            this.labelStatus.Location = new System.Drawing.Point(44, 29);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 29);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status:";
            // 
            // labelObservacao
            // 
            this.labelObservacao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservacao.Appearance.Options.UseFont = true;
            this.labelObservacao.Location = new System.Drawing.Point(34, 579);
            this.labelObservacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(125, 29);
            this.labelObservacao.TabIndex = 25;
            this.labelObservacao.Text = "Observação";
            // 
            // memObservacao
            // 
            this.memObservacao.Location = new System.Drawing.Point(34, 615);
            this.memObservacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.memObservacao.Name = "memObservacao";
            this.memObservacao.Size = new System.Drawing.Size(750, 140);
            this.memObservacao.TabIndex = 26;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Appearance.Options.UseFont = true;
            this.btnAlterar.Location = new System.Drawing.Point(162, 764);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(452, 72);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Atualizar Dados da Consulta";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // FrmAlterarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 908);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.memObservacao);
            this.Controls.Add(this.labelObservacao);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControlFiltro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAlterarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTERAR CONSULTA";
            this.Load += new System.EventHandler(this.FrmAlterarConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFiltro)).EndInit();
            this.panelControlFiltro.ResumeLayout(false);
            this.panelControlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEditHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsulta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memObservacao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlFiltro;
        private DevExpress.XtraEditors.LabelControl labelPaciente;
        private DevExpress.XtraEditors.LabelControl lblPaciente;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelPsicologo;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblHorario;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblDuracao;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.TimeSpanEdit timeSpanEditHora;
        private DevExpress.XtraEditors.DateEdit dateEditConsulta;
        private System.Windows.Forms.ComboBox cmbTempoDeConsulta;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private DevExpress.XtraEditors.LabelControl labelObservacao;
        private DevExpress.XtraEditors.MemoEdit memObservacao;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
    }
}