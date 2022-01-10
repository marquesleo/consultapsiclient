
using DevExpress.XtraSplashScreen;

namespace ConsultaPSI.Consulta
{
    partial class FrmConsultaAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAgendamento));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ConsultaPSI.Utils.WaitForm1), true, true);
            this.dgrdConsulta = new DevExpress.XtraGrid.GridControl();
            this.grdConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.gridLookUpEditPsicologa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPsicologo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEditPaciente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPaciente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkPaciente = new DevExpress.XtraEditors.CheckEdit();
            this.chkPsicologa = new DevExpress.XtraEditors.CheckEdit();
            this.dateEditConsultaInicial = new DevExpress.XtraEditors.DateEdit();
            this.grpPeriodo = new System.Windows.Forms.GroupBox();
            this.dateEditConsultaFinal = new DevExpress.XtraEditors.DateEdit();
            this.lblAte = new DevExpress.XtraEditors.LabelControl();
            this.lblDe = new DevExpress.XtraEditors.LabelControl();
            this.chkPeriodo = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPsicologa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPaciente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaciente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPsicologa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsultaInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsultaInicial.Properties)).BeginInit();
            this.grpPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsultaFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsultaFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // dgrdConsulta
            // 
            this.dgrdConsulta.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.dgrdConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrdConsulta.CausesValidation = false;
            this.dgrdConsulta.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dgrdConsulta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgrdConsulta.Location = new System.Drawing.Point(3, 162);
            this.dgrdConsulta.LookAndFeel.SkinName = "Blue";
            this.dgrdConsulta.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.dgrdConsulta.LookAndFeel.UseWindowsXPTheme = true;
            this.dgrdConsulta.MainView = this.grdConsulta;
            this.dgrdConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgrdConsulta.Name = "dgrdConsulta";
            this.dgrdConsulta.Size = new System.Drawing.Size(782, 349);
            this.dgrdConsulta.TabIndex = 16;
            this.dgrdConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdConsulta});
            // 
            // grdConsulta
            // 
            this.grdConsulta.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdConsulta.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdConsulta.Appearance.GroupFooter.Options.UseFont = true;
            this.grdConsulta.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdConsulta.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.grdConsulta.Appearance.GroupPanel.Options.UseFont = true;
            this.grdConsulta.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdConsulta.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.grdConsulta.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.grdConsulta.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdConsulta.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdConsulta.Appearance.GroupRow.Options.UseFont = true;
            this.grdConsulta.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdConsulta.Appearance.GroupRow.Options.UseTextOptions = true;
            this.grdConsulta.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdConsulta.AppearancePrint.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdConsulta.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.grdConsulta.AppearancePrint.FilterPanel.Options.UseForeColor = true;
            this.grdConsulta.DetailHeight = 512;
            this.grdConsulta.FixedLineWidth = 3;
            this.grdConsulta.GridControl = this.dgrdConsulta;
            this.grdConsulta.GroupPanelText = "Arraste uma coluna para Agrupar";
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.grdConsulta.OptionsCustomization.AllowRowSizing = true;
            this.grdConsulta.OptionsView.ColumnAutoWidth = false;
            this.grdConsulta.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.grdConsulta.OptionsView.RowAutoHeight = true;
            this.grdConsulta.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.grdConsulta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdConsulta.OptionsView.ShowFooter = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnConfirmar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.Image")));
            this.btnConfirmar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(3, 518);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(98, 38);
            this.btnConfirmar.TabIndex = 41;
            this.btnConfirmar.Text = "Processar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gridLookUpEditPsicologa
            // 
            this.gridLookUpEditPsicologa.Enabled = false;
            this.gridLookUpEditPsicologa.Location = new System.Drawing.Point(218, 36);
            this.gridLookUpEditPsicologa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridLookUpEditPsicologa.Name = "gridLookUpEditPsicologa";
            this.gridLookUpEditPsicologa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditPsicologa.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditPsicologa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditPsicologa.Properties.PopupView = this.gridView1;
            this.gridLookUpEditPsicologa.Size = new System.Drawing.Size(182, 26);
            this.gridLookUpEditPsicologa.TabIndex = 45;
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
            // gridColumnPsicologo
            // 
            this.gridColumnPsicologo.Caption = "Psicologo";
            this.gridColumnPsicologo.FieldName = "Nome";
            this.gridColumnPsicologo.Name = "gridColumnPsicologo";
            this.gridColumnPsicologo.Visible = true;
            this.gridColumnPsicologo.VisibleIndex = 0;
            // 
            // gridLookUpEditPaciente
            // 
            this.gridLookUpEditPaciente.Enabled = false;
            this.gridLookUpEditPaciente.Location = new System.Drawing.Point(13, 36);
            this.gridLookUpEditPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridLookUpEditPaciente.Name = "gridLookUpEditPaciente";
            this.gridLookUpEditPaciente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditPaciente.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditPaciente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditPaciente.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditPaciente.Size = new System.Drawing.Size(189, 26);
            this.gridLookUpEditPaciente.TabIndex = 43;
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
            // gridColumnPaciente
            // 
            this.gridColumnPaciente.Caption = "Nome";
            this.gridColumnPaciente.FieldName = "Nome";
            this.gridColumnPaciente.Name = "gridColumnPaciente";
            this.gridColumnPaciente.Visible = true;
            this.gridColumnPaciente.VisibleIndex = 0;
            // 
            // chkPaciente
            // 
            this.chkPaciente.Location = new System.Drawing.Point(13, 12);
            this.chkPaciente.Name = "chkPaciente";
            this.chkPaciente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaciente.Properties.Appearance.Options.UseFont = true;
            this.chkPaciente.Properties.Caption = "Paciente";
            this.chkPaciente.Size = new System.Drawing.Size(97, 23);
            this.chkPaciente.TabIndex = 46;
            this.chkPaciente.CheckedChanged += new System.EventHandler(this.chkPaciente_CheckedChanged);
            // 
            // chkPsicologa
            // 
            this.chkPsicologa.Location = new System.Drawing.Point(218, 12);
            this.chkPsicologa.Name = "chkPsicologa";
            this.chkPsicologa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPsicologa.Properties.Appearance.Options.UseFont = true;
            this.chkPsicologa.Properties.Caption = "Psicologa";
            this.chkPsicologa.Size = new System.Drawing.Size(96, 23);
            this.chkPsicologa.TabIndex = 47;
            this.chkPsicologa.CheckedChanged += new System.EventHandler(this.chkPsicologa_CheckedChanged);
            // 
            // dateEditConsultaInicial
            // 
            this.dateEditConsultaInicial.EditValue = null;
            this.dateEditConsultaInicial.Enabled = false;
            this.dateEditConsultaInicial.Location = new System.Drawing.Point(33, 51);
            this.dateEditConsultaInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateEditConsultaInicial.Name = "dateEditConsultaInicial";
            this.dateEditConsultaInicial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditConsultaInicial.Properties.Appearance.Options.UseFont = true;
            this.dateEditConsultaInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditConsultaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditConsultaInicial.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditConsultaInicial.Size = new System.Drawing.Size(141, 26);
            this.dateEditConsultaInicial.TabIndex = 48;
            // 
            // grpPeriodo
            // 
            this.grpPeriodo.Controls.Add(this.dateEditConsultaFinal);
            this.grpPeriodo.Controls.Add(this.lblAte);
            this.grpPeriodo.Controls.Add(this.lblDe);
            this.grpPeriodo.Controls.Add(this.chkPeriodo);
            this.grpPeriodo.Controls.Add(this.dateEditConsultaInicial);
            this.grpPeriodo.Location = new System.Drawing.Point(13, 70);
            this.grpPeriodo.Name = "grpPeriodo";
            this.grpPeriodo.Size = new System.Drawing.Size(387, 85);
            this.grpPeriodo.TabIndex = 49;
            this.grpPeriodo.TabStop = false;
            // 
            // dateEditConsultaFinal
            // 
            this.dateEditConsultaFinal.EditValue = null;
            this.dateEditConsultaFinal.Enabled = false;
            this.dateEditConsultaFinal.Location = new System.Drawing.Point(229, 51);
            this.dateEditConsultaFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateEditConsultaFinal.Name = "dateEditConsultaFinal";
            this.dateEditConsultaFinal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditConsultaFinal.Properties.Appearance.Options.UseFont = true;
            this.dateEditConsultaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditConsultaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditConsultaFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditConsultaFinal.Size = new System.Drawing.Size(141, 26);
            this.dateEditConsultaFinal.TabIndex = 52;
            // 
            // lblAte
            // 
            this.lblAte.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Appearance.Options.UseFont = true;
            this.lblAte.Location = new System.Drawing.Point(192, 54);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(30, 19);
            this.lblAte.TabIndex = 51;
            this.lblAte.Text = "Até:";
            // 
            // lblDe
            // 
            this.lblDe.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Appearance.Options.UseFont = true;
            this.lblDe.Location = new System.Drawing.Point(6, 54);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(25, 19);
            this.lblDe.TabIndex = 50;
            this.lblDe.Text = "De:";
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.Location = new System.Drawing.Point(6, 11);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPeriodo.Properties.Appearance.Options.UseFont = true;
            this.chkPeriodo.Properties.Caption = "Dt.Agendamento";
            this.chkPeriodo.Size = new System.Drawing.Size(141, 23);
            this.chkPeriodo.TabIndex = 48;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(107, 518);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 38);
            this.simpleButton1.TabIndex = 50;
            this.simpleButton1.Text = "Imprimir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmConsultaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grpPeriodo);
            this.Controls.Add(this.chkPsicologa);
            this.Controls.Add(this.chkPaciente);
            this.Controls.Add(this.gridLookUpEditPsicologa);
            this.Controls.Add(this.gridLookUpEditPaciente);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgrdConsulta);
            this.Name = "FrmConsultaAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConsultaAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPsicologa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPaciente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaciente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPsicologa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsultaInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsultaInicial.Properties)).EndInit();
            this.grpPeriodo.ResumeLayout(false);
            this.grpPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsultaFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditConsultaFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.GridControl dgrdConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView grdConsulta;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditPsicologa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPsicologo;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditPaciente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPaciente;
        private DevExpress.XtraEditors.CheckEdit chkPaciente;
        private DevExpress.XtraEditors.CheckEdit chkPsicologa;
        private DevExpress.XtraEditors.DateEdit dateEditConsultaInicial;
        private System.Windows.Forms.GroupBox grpPeriodo;
        private DevExpress.XtraEditors.DateEdit dateEditConsultaFinal;
        private DevExpress.XtraEditors.LabelControl lblAte;
        private DevExpress.XtraEditors.LabelControl lblDe;
        private DevExpress.XtraEditors.CheckEdit chkPeriodo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}