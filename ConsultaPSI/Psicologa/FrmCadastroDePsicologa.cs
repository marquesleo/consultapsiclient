using BOPSI;
using DevExpress.XtraEditors;
using Dominio.ViewModel;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaPSI.Psicologa
{
    public partial class FrmCadastroDePsicologa : Form
    {
        public FrmCadastroDePsicologa()
        {
            InitializeComponent();
        }

        private PsicologaViewModel _psicologaViewModel;
       

        private PsicologaService _PsicologaService;
        private PsicologaService PsicologaService
        {
            get
            {
                if (_PsicologaService == null)
                    _PsicologaService = new PsicologaService();
                return _PsicologaService;
            }
        }


        private Guid codigoPsicologo;
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

        public PsicologaViewModel Psicologa
        {
            get
            {
                return _psicologaViewModel;
            }
            set
            {
                _psicologaViewModel = value;
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



        private void CarregarCamposDoCep(EnderecoVIACEP enderecoVIACEP)
        {
            txtBairro.Text = enderecoVIACEP.bairro;
            txtCidade.Text = enderecoVIACEP.Localidade;
            txtEndereco.Text = enderecoVIACEP.logradouro;
           
        }
        private bool buscarCEPViaCEP(bool exibeMensagemQueNaoAchou)
        {
            bool retorno = false;
            try
            {
                CarregarCamposDoCep(new EnderecoVIACEP());
                var viaCEPBO = new ViaCEP();
                var enderecoVIACEP = viaCEPBO.retornarRegistro(txtCep.Text);
                if (enderecoVIACEP != null && !string.IsNullOrEmpty(enderecoVIACEP.cep))
                {
                    retorno = true;
                    CarregarCamposDoCep(enderecoVIACEP);
                }
                else
                {
                    if (exibeMensagemQueNaoAchou)
                        XtraMessageBox.Show("Endereço não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
           
            return retorno;
        }

      

        private void CarregarObjeto()
        {
            _psicologaViewModel.Bairro = txtBairro.Text;
            _psicologaViewModel.Endereco = txtEndereco.Text;
            _psicologaViewModel.Email = txtEmail.Text;
            _psicologaViewModel.Cep = txtCep.Text;
            _psicologaViewModel.Celular = txtCelular.Text;
            _psicologaViewModel.Telefone = txtTelefone.Text;
            _psicologaViewModel.Nome = txtNomeCompleto.Text;
            _psicologaViewModel.Cidade = txtCidade.Text;
            _psicologaViewModel.Ativo = chkAtivo.Checked;
            _psicologaViewModel.CRP = txtCRP.Text;
            _psicologaViewModel.DtNascimento = Convert.ToDateTime(dtpNascimento.EditValue);
            _psicologaViewModel.Acesso_Id = Guid.Parse(Util.Usuario.UsuarioLogado.acesso.id);
        }

      

        private async Task EfetuarGravacao()
        {
            try
            {
                CarregarObjeto();

                switch (OPERACAO)
                {
                    case enuOperacao.Incluir:
                        await PsicologaService.Incluir(_psicologaViewModel);
                        XtraMessageBox.Show("Registro Incluído!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        houveInclusao = true;
                        if (FrmPsicologa.frm != null)
                           await  FrmPsicologa.frm.EfetuarConsulta();
                        Limpar();
                        
                        break; 
                    case enuOperacao.Alterar:
                        _psicologaViewModel.Id = codigoPsicologo;
                        await PsicologaService.Alterar(_psicologaViewModel);
                        XtraMessageBox.Show("Registro Alterado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        houveInclusao = true;
                        Close();
                        break;
                   
                }

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void FrmCadastroDePacientes_Load(object sender, EventArgs e)
        {
            
            if (_operacao == enuOperacao.Alterar)
            {
                codigoPsicologo = _psicologaViewModel.Id;
                this.CarregarRegistro();
            }else
                _psicologaViewModel = new PsicologaViewModel();

        }

        private void CarregarRegistro()
        {
            codigoPsicologo = _psicologaViewModel.Id;
            txtCRP.Text = _psicologaViewModel.CRP;
            txtNomeCompleto.Text = _psicologaViewModel.Nome;
            txtBairro.Text = _psicologaViewModel.Bairro;
            txtCidade.Text = _psicologaViewModel.Cidade;
            txtCelular.Text = _psicologaViewModel.Celular;
            txtTelefone.Text = _psicologaViewModel.Telefone;
            txtEndereco.Text = _psicologaViewModel.Endereco;
            chkAtivo.EditValue = _psicologaViewModel.Ativo;
            txtCep.EditValue = _psicologaViewModel.Cep;
            dtpNascimento.EditValue = Convert.ToDateTime(_psicologaViewModel.DtNascimento);
            txtEmail.Text = _psicologaViewModel.Email;
        }

        private void Limpar()
        {
            if (_operacao == enuOperacao.Incluir)
                _psicologaViewModel = new PsicologaViewModel();
            CarregarRegistro();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EfetuarGravacao();
        }

        private void btnBuscarCEPNaInternet_Click(object sender, EventArgs e)
        {
            buscarCEPViaCEP(true);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscarCEPViaCEP(true);
        }
    }
}
