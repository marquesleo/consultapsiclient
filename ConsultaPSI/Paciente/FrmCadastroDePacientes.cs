using BOPSI;
using DevExpress.XtraEditors;
using Dominio.ViewModel;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaPSI.Paciente
{
    public partial class FrmCadastroDePacientes : Form
    {
        public FrmCadastroDePacientes()
        {
            InitializeComponent();
        }

        private PacienteViewModel _pacienteViewModel;
       

        private PacienteService _PacienteService;
        private PacienteService PacienteService
        {
            get
            {
                if (_PacienteService == null)
                    _PacienteService = new PacienteService();
                return _PacienteService;
            }
        }


        private Guid codigoPaciente;
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

        public Dominio.ViewModel.PacienteViewModel Paciente
        {
            get
            {
                return _pacienteViewModel;
            }
            set
            {
                _pacienteViewModel = value;
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
            _pacienteViewModel.Bairro = txtBairro.Text;
            _pacienteViewModel.Endereco = txtEndereco.Text;
            _pacienteViewModel.Email = txtEmail.Text;
            _pacienteViewModel.Cep = txtCep.Text;
            _pacienteViewModel.Celular = txtCelular.Text;
            _pacienteViewModel.Telefone = txtTelefone.Text;
            _pacienteViewModel.Nome = txtNomeCompleto.Text;
            _pacienteViewModel.Cidade = txtCidade.Text;
            _pacienteViewModel.Ativo = chkAtivo.Checked;
            _pacienteViewModel.DtNascimento = Convert.ToDateTime(dtpNascimento.EditValue);
            _pacienteViewModel.Acesso_Id = Guid.Parse(Util.Usuario.UsuarioLogado.acesso.id);
        }

      

        private async Task EfetuarGravacao()
        {
            try
            {
                CarregarObjeto();

                switch (OPERACAO)
                {
                    case enuOperacao.Incluir:
                        await PacienteService.Incluir(_pacienteViewModel);
                        XtraMessageBox.Show("Registro Incluído!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        houveInclusao = true;
                        if (FrmPaciente.frm != null)
                           await FrmPaciente.frm.EfetuarConsulta();
                        Limpar();
                       
                        break;
                    case enuOperacao.Alterar:
                        await PacienteService.Alterar(_pacienteViewModel);
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
                codigoPaciente = _pacienteViewModel.Id;
                this.CarregarRegistro();
            }else
                _pacienteViewModel = new Dominio.ViewModel.PacienteViewModel();
            chkAtivo.Checked = true;
        }

        private void CarregarRegistro()
        {
            txtNomeCompleto.Text = _pacienteViewModel.Nome;
            txtBairro.Text = _pacienteViewModel.Bairro;
            txtCidade.Text = _pacienteViewModel.Cidade;
            txtCelular.Text = _pacienteViewModel.Celular;
            txtTelefone.Text = _pacienteViewModel.Telefone;
            txtEndereco.Text = _pacienteViewModel.Endereco;
            chkAtivo.EditValue = _pacienteViewModel.Ativo;
            txtCep.EditValue = _pacienteViewModel.Cep;
            dtpNascimento.EditValue = Convert.ToDateTime(_pacienteViewModel.DtNascimento);
            txtEmail.Text = _pacienteViewModel.Email;
        }

        private void Limpar()
        {
            if (_operacao == enuOperacao.Incluir)
                _pacienteViewModel = new PacienteViewModel();
            CarregarRegistro();
            chkAtivo.Checked = true;
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
