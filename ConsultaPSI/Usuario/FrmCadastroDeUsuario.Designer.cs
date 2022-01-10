
namespace ConsultaPSI.Usuario
{
    partial class FrmCadastroDeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroDeUsuario));
            this.grpCadastroDeUsuario = new DevExpress.XtraEditors.GroupControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.chkSituacao = new DevExpress.XtraEditors.CheckEdit();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lblSenha = new DevExpress.XtraEditors.LabelControl();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.ToolTip = new DevExpress.Utils.DefaultToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grpCadastroDeUsuario)).BeginInit();
            this.grpCadastroDeUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCadastroDeUsuario
            // 
            this.grpCadastroDeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCadastroDeUsuario.Controls.Add(this.txtEmail);
            this.grpCadastroDeUsuario.Controls.Add(this.lblEmail);
            this.grpCadastroDeUsuario.Controls.Add(this.chkSituacao);
            this.grpCadastroDeUsuario.Controls.Add(this.txtSenha);
            this.grpCadastroDeUsuario.Controls.Add(this.txtUsuario);
            this.grpCadastroDeUsuario.Controls.Add(this.lblSenha);
            this.grpCadastroDeUsuario.Controls.Add(this.lblEstado);
            this.grpCadastroDeUsuario.Controls.Add(this.btnSair);
            this.grpCadastroDeUsuario.Controls.Add(this.btnCancelar);
            this.grpCadastroDeUsuario.Controls.Add(this.btnConfirmar);
            this.grpCadastroDeUsuario.Location = new System.Drawing.Point(4, 2);
            this.grpCadastroDeUsuario.Name = "grpCadastroDeUsuario";
            this.grpCadastroDeUsuario.Size = new System.Drawing.Size(419, 311);
            this.grpCadastroDeUsuario.TabIndex = 1;
            this.grpCadastroDeUsuario.Text = "Usuário";
            this.grpCadastroDeUsuario.ToolTipController = this.ToolTip.DefaultController;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 100;
            this.txtEmail.Size = new System.Drawing.Size(386, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(12, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(28, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail";
            // 
            // chkSituacao
            // 
            this.chkSituacao.Location = new System.Drawing.Point(12, 179);
            this.chkSituacao.Name = "chkSituacao";
            this.chkSituacao.Properties.Caption = "Ativo";
            this.chkSituacao.Size = new System.Drawing.Size(75, 19);
            this.chkSituacao.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.ToolTip.SetAllowHtmlText(this.txtSenha, DevExpress.Utils.DefaultBoolean.Default);
            this.txtSenha.Location = new System.Drawing.Point(12, 149);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(189, 21);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 69);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Properties.MaxLength = 100;
            this.txtUsuario.Size = new System.Drawing.Size(386, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // lblSenha
            // 
            this.lblSenha.Location = new System.Drawing.Point(13, 132);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(30, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(12, 51);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(36, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Usuário";
            // 
            // btnSair
            // 
            this.ToolTip.SetAllowHtmlText(this.btnSair, DevExpress.Utils.DefaultBoolean.Default);
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(361, 261);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 39);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.ToolTip.SetAllowHtmlText(this.btnCancelar, DevExpress.Utils.DefaultBoolean.Default);
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(305, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.ToolTip.SetAllowHtmlText(this.btnConfirmar, DevExpress.Utils.DefaultBoolean.Default);
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.Location = new System.Drawing.Point(249, 261);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(50, 39);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmCadastroDeUsuario
            // 
            this.ToolTip.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 321);
            this.Controls.Add(this.grpCadastroDeUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastroDeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            this.Load += new System.EventHandler(this.FrmCadastroDeUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpCadastroDeUsuario)).EndInit();
            this.grpCadastroDeUsuario.ResumeLayout(false);
            this.grpCadastroDeUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCadastroDeUsuario;
        public DevExpress.XtraEditors.CheckEdit chkSituacao;
        private System.Windows.Forms.TextBox txtSenha;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnConfirmar;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.Utils.DefaultToolTipController ToolTip;
    }
}