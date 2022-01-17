
namespace ConsultaPSI.Empresa
{
    partial class FrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarCEPNaInternet = new DevExpress.XtraEditors.SimpleButton();
            this.txtCidade = new DevExpress.XtraEditors.TextEdit();
            this.lblCidade = new DevExpress.XtraEditors.LabelControl();
            this.txtEndereco = new DevExpress.XtraEditors.TextEdit();
            this.txtBairro = new DevExpress.XtraEditors.TextEdit();
            this.lblEndereco = new DevExpress.XtraEditors.LabelControl();
            this.lblBairro = new DevExpress.XtraEditors.LabelControl();
            this.txtCep = new DevExpress.XtraEditors.TextEdit();
            this.lblCep = new DevExpress.XtraEditors.LabelControl();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new DevExpress.XtraEditors.TextEdit();
            this.txtCelular = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new DevExpress.XtraEditors.TextEdit();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCnpj = new DevExpress.XtraEditors.TextEdit();
            this.lblCnpj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCompleto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnpj.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSair.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.ImageOptions.Image")));
            this.btnSair.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSair.Location = new System.Drawing.Point(889, 758);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 78);
            this.btnSair.TabIndex = 12;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelar.Location = new System.Drawing.Point(787, 758);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 78);
            this.btnCancelar.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnConfirmar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.Image")));
            this.btnConfirmar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(683, 758);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.ShowToolTips = false;
            this.btnConfirmar.Size = new System.Drawing.Size(88, 78);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBuscarCEPNaInternet
            // 
            this.btnBuscarCEPNaInternet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCEPNaInternet.ImageOptions.Image")));
            this.btnBuscarCEPNaInternet.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnBuscarCEPNaInternet.Location = new System.Drawing.Point(342, 383);
            this.btnBuscarCEPNaInternet.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBuscarCEPNaInternet.LookAndFeel.UseWindowsXPTheme = true;
            this.btnBuscarCEPNaInternet.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarCEPNaInternet.Name = "btnBuscarCEPNaInternet";
            this.btnBuscarCEPNaInternet.Size = new System.Drawing.Size(224, 58);
            this.btnBuscarCEPNaInternet.TabIndex = 6;
            this.btnBuscarCEPNaInternet.Text = "Buscar CEP na Web";
            this.btnBuscarCEPNaInternet.ToolTip = "Buscar CEP na Web";
            this.btnBuscarCEPNaInternet.ToolTipTitle = "Incluir";
            this.btnBuscarCEPNaInternet.Click += new System.EventHandler(this.btnBuscarCEPNaInternet_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(37, 683);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(6);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Properties.Appearance.Options.UseFont = true;
            this.txtCidade.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Size = new System.Drawing.Size(938, 38);
            this.txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Appearance.Options.UseFont = true;
            this.lblCidade.Location = new System.Drawing.Point(38, 642);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(6);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(71, 29);
            this.lblCidade.TabIndex = 104;
            this.lblCidade.Text = "Cidade";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(40, 596);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(6);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Properties.Appearance.Options.UseFont = true;
            this.txtEndereco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Size = new System.Drawing.Size(938, 38);
            this.txtEndereco.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(38, 493);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(6);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Properties.Appearance.Options.UseFont = true;
            this.txtBairro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Size = new System.Drawing.Size(938, 38);
            this.txtBairro.TabIndex = 7;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Appearance.Options.UseFont = true;
            this.lblEndereco.Location = new System.Drawing.Point(40, 548);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(6);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(98, 29);
            this.lblEndereco.TabIndex = 103;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblBairro
            // 
            this.lblBairro.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Appearance.Options.UseFont = true;
            this.lblBairro.Location = new System.Drawing.Point(40, 451);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(6);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(63, 29);
            this.lblBairro.TabIndex = 102;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCep
            // 
            this.txtCep.EditValue = "";
            this.txtCep.Location = new System.Drawing.Point(38, 395);
            this.txtCep.Margin = new System.Windows.Forms.Padding(6);
            this.txtCep.Name = "txtCep";
            this.txtCep.Properties.Appearance.Options.UseFont = true;
            this.txtCep.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.txtCep.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtCep.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d-\\d?\\d?\\d?";
            this.txtCep.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtCep.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCep.Size = new System.Drawing.Size(273, 28);
            this.txtCep.TabIndex = 5;
            this.txtCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCep_KeyDown);
            // 
            // lblCep
            // 
            this.lblCep.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Appearance.Options.UseFont = true;
            this.lblCep.Location = new System.Drawing.Point(40, 357);
            this.lblCep.Margin = new System.Windows.Forms.Padding(6);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(40, 29);
            this.lblCep.TabIndex = 101;
            this.lblCep.Text = "CEP";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblTelefone.Location = new System.Drawing.Point(336, 272);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(105, 29);
            this.lblTelefone.TabIndex = 100;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblCelular.Location = new System.Drawing.Point(31, 272);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(85, 29);
            this.lblCelular.TabIndex = 99;
            this.lblCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.EditValue = "";
            this.txtTelefone.Location = new System.Drawing.Point(342, 307);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.txtTelefone.Properties.Appearance.Options.UseFont = true;
            this.txtTelefone.Properties.Appearance.Options.UseForeColor = true;
            this.txtTelefone.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.txtTelefone.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtTelefone.Properties.Mask.EditMask = "(\\d?\\d?)\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTelefone.Properties.NullText = " ";
            this.txtTelefone.Size = new System.Drawing.Size(294, 38);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtCelular
            // 
            this.txtCelular.EditValue = "";
            this.txtCelular.Location = new System.Drawing.Point(34, 307);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(6);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.txtCelular.Properties.Appearance.Options.UseFont = true;
            this.txtCelular.Properties.Appearance.Options.UseForeColor = true;
            this.txtCelular.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.txtCelular.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtCelular.Properties.Mask.EditMask = "(\\d?\\d?)\\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtCelular.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCelular.Properties.NullText = " ";
            this.txtCelular.Size = new System.Drawing.Size(274, 38);
            this.txtCelular.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(38, 226);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(951, 38);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblEmail.Location = new System.Drawing.Point(38, 191);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 29);
            this.lblEmail.TabIndex = 98;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(34, 59);
            this.txtNomeCompleto.Margin = new System.Windows.Forms.Padding(6);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.Properties.Appearance.Options.UseFont = true;
            this.txtNomeCompleto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCompleto.Size = new System.Drawing.Size(951, 38);
            this.txtNomeCompleto.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblNome.Location = new System.Drawing.Point(28, 23);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 29);
            this.lblNome.TabIndex = 97;
            this.lblNome.Text = "Nome";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(36, 144);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(6);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Properties.Appearance.Options.UseFont = true;
            this.txtCnpj.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCnpj.Size = new System.Drawing.Size(951, 38);
            this.txtCnpj.TabIndex = 1;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lblCnpj.Location = new System.Drawing.Point(30, 108);
            this.lblCnpj.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(115, 29);
            this.lblCnpj.TabIndex = 106;
            this.lblCnpj.Text = "CNPJ/CPF";
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 868);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.btnBuscarCEPNaInternet);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.Shown += new System.EventHandler(this.FrmEmpresa_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCompleto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnpj.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSair;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.SimpleButton btnBuscarCEPNaInternet;
        internal DevExpress.XtraEditors.TextEdit txtCidade;
        private DevExpress.XtraEditors.LabelControl lblCidade;
        internal DevExpress.XtraEditors.TextEdit txtEndereco;
        internal DevExpress.XtraEditors.TextEdit txtBairro;
        private DevExpress.XtraEditors.LabelControl lblEndereco;
        private DevExpress.XtraEditors.LabelControl lblBairro;
        internal DevExpress.XtraEditors.TextEdit txtCep;
        private DevExpress.XtraEditors.LabelControl lblCep;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        internal DevExpress.XtraEditors.TextEdit txtTelefone;
        internal DevExpress.XtraEditors.TextEdit txtCelular;
        internal DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.Label lblEmail;
        internal DevExpress.XtraEditors.TextEdit txtNomeCompleto;
        private System.Windows.Forms.Label lblNome;
        internal DevExpress.XtraEditors.TextEdit txtCnpj;
        private System.Windows.Forms.Label lblCnpj;
    }
}