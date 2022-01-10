using Dominio.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace ConsultaPSI.Usuario
{
    public partial class FrmLoginUsuario : Form
    {
        public FrmLoginUsuario()
        {
            InitializeComponent();
        }
        private TokenLogado _UsuarioToken;
        public TokenLogado UsuarioToken
        {
            get
            {
                return _UsuarioToken;
            }
        }

        private void ValidarParaLogin() {

            string erro = string.Empty;
            if (string.IsNullOrEmpty(txtUsuario.Text))
                erro = "Usuário deve ser preenchido!";

            if (string.IsNullOrEmpty(txtSenha.Text))
                erro += "\n Senha deve ser preenchido!";


            if (!string.IsNullOrEmpty(erro))
                throw new Exception(erro);
        }

        private void RealizarLogin()
        {
            try
            {
                var loginView = new LoginViewModel();
                var usuarioService = new BOPSI.UsuarioService();
                loginView.Username = txtUsuario.Text.ToUpper();
                loginView.Password = txtSenha.Text;
                loginView.Email = "teste@gmail.com";
                _UsuarioToken =  usuarioService.Autenticar(loginView).Result;
                if (_UsuarioToken != null)
                {
                    Close();
                }
                
                   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        private void FrmLoginUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FrmLoginUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RealizarLogin();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
