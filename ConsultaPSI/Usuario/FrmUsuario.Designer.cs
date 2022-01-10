namespace ConsultaPSI.Usuario
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.grpUsuario = new DevExpress.XtraEditors.GroupControl();
            this.dgrdUsuario = new DevExpress.XtraGrid.GridControl();
            this.grdUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ToolTip = new DevExpress.Utils.DefaultToolTipController(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grpUsuario)).BeginInit();
            this.grpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.ToolTip.SetAllowHtmlText(this.btnImprimir, DevExpress.Utils.DefaultBoolean.Default);
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(836, 559);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 60);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSair
            // 
            this.ToolTip.SetAllowHtmlText(this.btnSair, DevExpress.Utils.DefaultBoolean.Default);
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(918, 559);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 60);
            this.btnSair.TabIndex = 4;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.ToolTip.SetAllowHtmlText(this.btnAlterar, DevExpress.Utils.DefaultBoolean.Default);
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(670, 559);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 60);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLancar
            // 
            this.ToolTip.SetAllowHtmlText(this.btnLancar, DevExpress.Utils.DefaultBoolean.Default);
            this.btnLancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLancar.Image = ((System.Drawing.Image)(resources.GetObject("btnLancar.Image")));
            this.btnLancar.Location = new System.Drawing.Point(587, 559);
            this.btnLancar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(75, 60);
            this.btnLancar.TabIndex = 0;
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // grpUsuario
            // 
            this.grpUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUsuario.Controls.Add(this.dgrdUsuario);
            this.grpUsuario.Location = new System.Drawing.Point(3, 3);
            this.grpUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(998, 547);
            this.grpUsuario.TabIndex = 24;
            this.grpUsuario.Text = "Usuário";
            this.grpUsuario.ToolTipController = this.ToolTip.DefaultController;
            this.grpUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.grpUsuario_Paint);
            // 
            // dgrdUsuario
            // 
            this.dgrdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrdUsuario.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dgrdUsuario.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgrdUsuario.Location = new System.Drawing.Point(12, 37);
            this.dgrdUsuario.MainView = this.grdUsuario;
            this.dgrdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.dgrdUsuario.Name = "dgrdUsuario";
            this.dgrdUsuario.Size = new System.Drawing.Size(978, 503);
            this.dgrdUsuario.TabIndex = 1;
            this.dgrdUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdUsuario});
            // 
            // grdUsuario
            // 
            this.grdUsuario.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUsuario.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Red;
            this.grdUsuario.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdUsuario.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdUsuario.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdUsuario.Appearance.FooterPanel.Options.UseFont = true;
            this.grdUsuario.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdUsuario.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.grdUsuario.DetailHeight = 512;
            this.grdUsuario.FixedLineWidth = 3;
            this.grdUsuario.GridControl = this.dgrdUsuario;
            this.grdUsuario.GroupPanelText = "Arraste uma coluna para Agrupar";
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.grdUsuario.OptionsCustomization.AllowColumnMoving = false;
            this.grdUsuario.OptionsCustomization.AllowFilter = false;
            this.grdUsuario.OptionsCustomization.AllowGroup = false;
            this.grdUsuario.OptionsCustomization.AllowRowSizing = true;
            this.grdUsuario.OptionsMenu.EnableColumnMenu = false;
            this.grdUsuario.OptionsMenu.EnableFooterMenu = false;
            this.grdUsuario.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdUsuario.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.grdUsuario.OptionsView.ColumnAutoWidth = false;
            this.grdUsuario.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.grdUsuario.OptionsView.RowAutoHeight = true;
            this.grdUsuario.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.grdUsuario.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdUsuario.OptionsView.ShowGroupPanel = false;
            this.grdUsuario.DoubleClick += new System.EventHandler(this.grdUsuario_DoubleClick);
            // 
            // btnExcluir
            // 
            this.ToolTip.SetAllowHtmlText(this.btnExcluir, DevExpress.Utils.DefaultBoolean.Default);
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(753, 559);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 60);
            this.btnExcluir.TabIndex = 2;
            this.ToolTip.SetTitle(this.btnExcluir, "Excluir Categoria - F4");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmUsuario
            // 
            this.ToolTip.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 657);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.grpUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.Shown += new System.EventHandler(this.FrmUsuario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpUsuario)).EndInit();
            this.grpUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.Button btnLancar;
        private DevExpress.XtraEditors.GroupControl grpUsuario;
        private DevExpress.XtraGrid.GridControl dgrdUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView grdUsuario;
        private DevExpress.Utils.DefaultToolTipController ToolTip;
        internal System.Windows.Forms.Button btnExcluir;
    }
}