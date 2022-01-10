
using DevExpress.XtraSplashScreen;

namespace ConsultaPSI.Psicologa
{
    partial class FrmPsicologa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPsicologa));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ConsultaPSI.Utils.WaitForm1), true, true);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.toolTipController2 = new DevExpress.Utils.ToolTipController(this.components);
            this.grdPsicologo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgrdPsicologo = new DevExpress.XtraGrid.GridControl();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.txtNomeDoPaciente = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnFiltrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovoPaciente = new DevExpress.XtraBars.BarButtonItem();
            this.btnAlterarPaciente = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcluirParticipante = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnLancamento = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.btnAlterarLancamento = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransferencia = new DevExpress.XtraBars.BarButtonItem();
            this.lblSaldo = new DevExpress.XtraBars.BarStaticItem();
            this.lblTotal = new DevExpress.XtraBars.BarStaticItem();
            this.lblLancamento = new DevExpress.XtraBars.BarStaticItem();
            this.lblUltimoLancamento = new DevExpress.XtraBars.BarStaticItem();
            this.btnImpressao = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barAndDockingController = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.grdPsicologo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdPsicologo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // grdPsicologo
            // 
            this.grdPsicologo.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPsicologo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdPsicologo.Appearance.GroupFooter.Options.UseFont = true;
            this.grdPsicologo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdPsicologo.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.grdPsicologo.Appearance.GroupPanel.Options.UseFont = true;
            this.grdPsicologo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdPsicologo.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.grdPsicologo.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.grdPsicologo.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdPsicologo.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdPsicologo.Appearance.GroupRow.Options.UseFont = true;
            this.grdPsicologo.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdPsicologo.Appearance.GroupRow.Options.UseTextOptions = true;
            this.grdPsicologo.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPsicologo.AppearancePrint.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdPsicologo.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.grdPsicologo.AppearancePrint.FilterPanel.Options.UseForeColor = true;
            this.grdPsicologo.DetailHeight = 512;
            this.grdPsicologo.FixedLineWidth = 3;
            this.grdPsicologo.GridControl = this.dgrdPsicologo;
            this.grdPsicologo.GroupPanelText = "Arraste uma coluna para Agrupar";
            this.grdPsicologo.Name = "grdPsicologo";
            this.grdPsicologo.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.grdPsicologo.OptionsCustomization.AllowRowSizing = true;
            this.grdPsicologo.OptionsView.ColumnAutoWidth = false;
            this.grdPsicologo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.grdPsicologo.OptionsView.RowAutoHeight = true;
            this.grdPsicologo.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.grdPsicologo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdPsicologo.OptionsView.ShowFooter = true;
            // 
            // dgrdPsicologo
            // 
            this.dgrdPsicologo.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.dgrdPsicologo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrdPsicologo.CausesValidation = false;
            this.dgrdPsicologo.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dgrdPsicologo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgrdPsicologo.Location = new System.Drawing.Point(0, 55);
            this.dgrdPsicologo.LookAndFeel.SkinName = "Blue";
            this.dgrdPsicologo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.dgrdPsicologo.LookAndFeel.UseWindowsXPTheme = true;
            this.dgrdPsicologo.MainView = this.grdPsicologo;
            this.dgrdPsicologo.Margin = new System.Windows.Forms.Padding(4);
            this.dgrdPsicologo.Name = "dgrdPsicologo";
            this.dgrdPsicologo.Size = new System.Drawing.Size(998, 629);
            this.dgrdPsicologo.TabIndex = 15;
            this.dgrdPsicologo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdPsicologo});
            this.dgrdPsicologo.DoubleClick += new System.EventHandler(this.dgrdPaciente_DoubleClick);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemGridLookUpEdit1;
            this.barEditItem1.Id = 6;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "]";
            this.barLargeButtonItem1.Id = 1;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 44);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 646);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLancamento,
            this.barLargeButtonItem1,
            this.btnExcluir,
            this.btnAlterarLancamento,
            this.btnTransferencia,
            this.barEditItem1,
            this.lblSaldo,
            this.lblTotal,
            this.lblLancamento,
            this.lblUltimoLancamento,
            this.btnImpressao,
            this.barButtonItem1,
            this.btnNovoPaciente,
            this.btnAlterarPaciente,
            this.barEditItem2,
            this.barStaticItem1,
            this.txtNomeDoPaciente,
            this.btnExcluirParticipante,
            this.btnImprimir,
            this.btnFiltrar});
            this.barManager.MaxItemId = 21;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemHypertextLabel1,
            this.repositoryItemTextEdit1});
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 2";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.txtNomeDoPaciente, "", false, true, true, 248, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFiltrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovoPaciente),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAlterarPaciente),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcluirParticipante),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImprimir)});
            this.bar3.Text = "Custom 2";
            // 
            // txtNomeDoPaciente
            // 
            this.txtNomeDoPaciente.Caption = "Nome do Psicologo:";
            this.txtNomeDoPaciente.Edit = this.repositoryItemTextEdit1;
            this.txtNomeDoPaciente.EditValue = "";
            this.txtNomeDoPaciente.Id = 17;
            this.txtNomeDoPaciente.Name = "txtNomeDoPaciente";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Caption = "Filtrar";
            this.btnFiltrar.Id = 20;
            this.btnFiltrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.Image")));
            this.btnFiltrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.LargeImage")));
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnFiltrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFiltrar_ItemClick);
            // 
            // btnNovoPaciente
            // 
            this.btnNovoPaciente.Caption = "Novo Psicologo";
            this.btnNovoPaciente.Id = 13;
            this.btnNovoPaciente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoPaciente.ImageOptions.Image")));
            this.btnNovoPaciente.Name = "btnNovoPaciente";
            this.btnNovoPaciente.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNovoPaciente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovoPaciente_ItemClick);
            // 
            // btnAlterarPaciente
            // 
            this.btnAlterarPaciente.Caption = "Alterar Psicologo";
            this.btnAlterarPaciente.Hint = "Alterar Psicologo";
            this.btnAlterarPaciente.Id = 14;
            this.btnAlterarPaciente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarPaciente.ImageOptions.Image")));
            this.btnAlterarPaciente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAlterarPaciente.ImageOptions.LargeImage")));
            this.btnAlterarPaciente.Name = "btnAlterarPaciente";
            this.btnAlterarPaciente.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAlterarPaciente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAlterarPaciente_ItemClick);
            // 
            // btnExcluirParticipante
            // 
            this.btnExcluirParticipante.Caption = "Excluir Psicologo";
            this.btnExcluirParticipante.Id = 18;
            this.btnExcluirParticipante.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirParticipante.ImageOptions.Image")));
            this.btnExcluirParticipante.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirParticipante.ImageOptions.LargeImage")));
            this.btnExcluirParticipante.Name = "btnExcluirParticipante";
            this.btnExcluirParticipante.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnExcluirParticipante.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcluirParticipante_ItemClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Impressão";
            this.btnImprimir.Id = 19;
            this.btnImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.Image")));
            this.btnImprimir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.LargeImage")));
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImprimir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(998, 44);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 690);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(998, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(998, 44);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 646);
            // 
            // btnLancamento
            // 
            this.btnLancamento.Caption = "Lançamento";
            this.btnLancamento.Hint = "Lançamento de Movimentação - F2";
            this.btnLancamento.Id = 0;
            this.btnLancamento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLancamento.ImageOptions.Image")));
            this.btnLancamento.Name = "btnLancamento";
            this.btnLancamento.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Caption = "Excluir";
            this.btnExcluir.Hint = "Excluir Movimentação - F4";
            this.btnExcluir.Id = 2;
            this.btnExcluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.ImageOptions.Image")));
            this.btnExcluir.Name = "btnExcluir";
            // 
            // btnAlterarLancamento
            // 
            this.btnAlterarLancamento.Caption = "Alterar";
            this.btnAlterarLancamento.Hint = "Alterar Movimentação - F3";
            this.btnAlterarLancamento.Id = 3;
            this.btnAlterarLancamento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarLancamento.ImageOptions.Image")));
            this.btnAlterarLancamento.Name = "btnAlterarLancamento";
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Caption = "Transferência";
            this.btnTransferencia.Hint = "Realizar Transferência - F7";
            this.btnTransferencia.Id = 4;
            this.btnTransferencia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferencia.ImageOptions.Image")));
            this.btnTransferencia.Name = "btnTransferencia";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Caption = "Saldo :";
            this.lblSaldo.Id = 7;
            this.lblSaldo.Name = "lblSaldo";
            // 
            // lblTotal
            // 
            this.lblTotal.Id = 8;
            this.lblTotal.Name = "lblTotal";
            // 
            // lblLancamento
            // 
            this.lblLancamento.Caption = "Último Lançamento";
            this.lblLancamento.Id = 9;
            this.lblLancamento.Name = "lblLancamento";
            // 
            // lblUltimoLancamento
            // 
            this.lblUltimoLancamento.Id = 10;
            this.lblUltimoLancamento.Name = "lblUltimoLancamento";
            // 
            // btnImpressao
            // 
            this.btnImpressao.Caption = "Impressão";
            this.btnImpressao.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnImpressao.Hint = "Impressão - F5";
            this.btnImpressao.Id = 11;
            this.btnImpressao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImpressao.ImageOptions.Image")));
            this.btnImpressao.Name = "btnImpressao";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Nome Do Paciente";
            this.barEditItem2.Edit = this.repositoryItemHypertextLabel1;
            this.barEditItem2.Id = 15;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Nome do Paciente";
            this.barStaticItem1.Id = 16;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barAndDockingController
            // 
            this.barAndDockingController.AppearancesBar.BarAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.barAndDockingController.AppearancesBar.BarAppearance.Normal.Options.UseBackColor = true;
            this.barAndDockingController.PaintStyleName = "Office2003";
            this.barAndDockingController.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 2";
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Custom 3";
            // 
            // FrmPsicologa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 690);
            this.Controls.Add(this.dgrdPsicologo);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPsicologa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Psicologos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPsicologa_Load);
            this.Shown += new System.EventHandler(this.FrmPaciente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdPsicologo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdPsicologo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       

        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.Utils.ToolTipController toolTipController2;
        private DevExpress.XtraGrid.Views.Grid.GridView grdPsicologo;
        private DevExpress.XtraGrid.GridControl dgrdPsicologo;
        private SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarEditItem txtNomeDoPaciente;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btnNovoPaciente;
        private DevExpress.XtraBars.BarButtonItem btnAlterarPaciente;
        private DevExpress.XtraBars.BarButtonItem btnExcluirParticipante;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLancamento;
        private DevExpress.XtraBars.BarButtonItem btnExcluir;
        private DevExpress.XtraBars.BarButtonItem btnAlterarLancamento;
        private DevExpress.XtraBars.BarButtonItem btnTransferencia;
        private DevExpress.XtraBars.BarStaticItem lblSaldo;
        private DevExpress.XtraBars.BarStaticItem lblTotal;
        private DevExpress.XtraBars.BarStaticItem lblLancamento;
        private DevExpress.XtraBars.BarStaticItem lblUltimoLancamento;
        private DevExpress.XtraBars.BarLargeButtonItem btnImpressao;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnFiltrar;
    }
}