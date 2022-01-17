using System;
using System.Windows.Forms;
using Dominio.ViewModel;
using BOPSI;
using DevExpress.XtraEditors;
using System.Threading.Tasks;

namespace ConsultaPSI.Usuario
{
    public partial class FrmCadastroDeUsuario : Form
    {
        public FrmCadastroDeUsuario()
        {
            InitializeComponent();
        }
        private LoginViewModel _oUsuario = new LoginViewModel();
        private UsuarioService UsuarioService = new UsuarioService();
      
        private Guid codigoUsuario;
        private bool _houveInclusao;
        public bool houveInclusao
        {
            get
            {
                return _houveInclusao;
            }
            set
            {
                _houveInclusao = value;
            }
        }

        private bool _somenteIncluir;
        public bool somenteIncluir
        {
            get
            {
                return _somenteIncluir;
            }
            set
            {
                _somenteIncluir = value;
            }
        }

        public LoginViewModel OUSUARIO
        {
            get
            {
                return _oUsuario;
            }
            set
            {
                _oUsuario = value;
            }
        }
        private enuOperacao _operacao;
        public enuOperacao OPERACAO
        {
            get
            {
                return _operacao;
            }

            set
            {
                _operacao = value;
            }
        }
        public enum enuOperacao
        {
            Incluir,
            Alterar
        }
        private void carregarObjeto()
        {
            _oUsuario.Username = txtUsuario.Text;
            _oUsuario.Password = txtSenha.Text;
            _oUsuario.Email = txtEmail.Text;
            _oUsuario.Id = codigoUsuario;
            _oUsuario.Ativo = chkSituacao.Checked;
            _oUsuario.Empresa_Id = Guid.Parse(Util.Usuario.UsuarioLogado.acesso.empresa_Id);
        }



        private void carregarRegistro()
        {
            txtUsuario.Text = _oUsuario.Username;
            txtSenha.Text =  Util.Criptografia.Decriptografar( _oUsuario.Password);
            codigoUsuario = _oUsuario.Id;
            chkSituacao.Checked = _oUsuario.Ativo;
            txtEmail.Text = _oUsuario.Email;
        }

        private void validarRegistroParaGravacao()
        {
            string mserro = string.Empty;

            if (txtUsuario.Text.Length == 0)
            {
                mserro = "Usuário Deve ser Preenchido.";
            }

            if (txtSenha.Text.Length == 0)
            {
                mserro += "\n Senha deve ser Preenchida.";
            }

            var usuarioExistente = UsuarioService.ObterPorUsuarioESenha(txtUsuario.Text, txtSenha.Text).Result;

            if (_operacao == enuOperacao.Incluir &&  
                    usuarioExistente != null && !string.IsNullOrEmpty(usuarioExistente.Id.ToString()))
                   
            {
                mserro += "\n Usuário Já está cadastrado.";
            }

            if (mserro.Length == 0)

            {
                this.gravarRegistro();
            }
            else
            {
                XtraMessageBox.Show(mserro, this.Text, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void limpar()
        {
            if (_operacao == enuOperacao.Incluir)
            {
                _oUsuario = new LoginViewModel();
            }
            this.carregarRegistro();
            _houveInclusao = false;
        }

        private  async Task gravarRegistro()
        {
            this.carregarObjeto();
            switch (_operacao)
            {
                case enuOperacao.Incluir:
                    try
                    {
                        await UsuarioService.Incluir(_oUsuario);
                        XtraMessageBox.Show("Registro Incluído com Sucesso !!", this.Text, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        if (FrmUsuario.frm != null)
                            await FrmUsuario.frm.EfetuarConsultaAsync();
                        this.limpar();
                        _houveInclusao = true;
                        if (_somenteIncluir)
                            this.Close();
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }
                    break;
                case enuOperacao.Alterar:
                    try
                    {
                       await UsuarioService.Alterar(_oUsuario);
                        XtraMessageBox.Show("Registro Alterado com Sucesso !!", this.Text, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        if (FrmUsuario.frm != null)
                           await FrmUsuario.frm.EfetuarConsultaAsync();
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }

                    break;

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            validarRegistroParaGravacao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpar();
            chkSituacao.Checked = true;
        }

        private void FrmCadastroDeUsuario_Load(object sender, EventArgs e)
        {
            if (_operacao == enuOperacao.Alterar)
            {
                codigoUsuario = _oUsuario.Id;
                this.carregarRegistro();
            }else 
            chkSituacao.Checked = true;

        }
    }
}
