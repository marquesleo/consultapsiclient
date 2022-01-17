using BOPSI;
using DevExpress.XtraEditors;
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

namespace ConsultaPSI.Empresa
{
    public partial class FrmEmpresa : DevExpress.XtraEditors.XtraForm
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {

        }

        private Dominio.ViewModel.EmpresaViewModel Empresa;

        private BOPSI.EmpresaService _EmpresaService;
        private BOPSI.EmpresaService EmpresaService
        {
            get
            {
                if (_EmpresaService == null)
                    _EmpresaService = new BOPSI.EmpresaService();
                return _EmpresaService;
            }
        }

        private void CarregarRegistro()
        {
            Empresa = EmpresaService.ObterPorId(Guid.Parse(Util.Usuario.UsuarioLogado.acesso.empresa_Id)).Result;
            if (Empresa != null)
            {
                txtNomeCompleto.Text = Empresa.Nome;
                txtEmail.Text = Empresa.Email;
                txtBairro.Text = Empresa.Bairro;
                txtCidade.Text = Empresa.Cidade;
                txtEndereco.Text = Empresa.Endereco;
                txtCep.Text = Empresa.Cep;
                txtCnpj.Text = Empresa.Cnpj;
                txtCelular.Text = Empresa.Celular;
                txtTelefone.Text = Empresa.Telefone;
            }
        }

        private void FrmEmpresa_Shown(object sender, EventArgs e)
        {
            CarregarRegistro();
        }

        private void CarregarObjeto()
        {
            Empresa.Nome = txtNomeCompleto.Text;
            Empresa.Email = txtEmail.Text;
            Empresa.Bairro = txtBairro.Text;
            Empresa.Cidade = txtCidade.Text;
            Empresa.Endereco = txtEndereco.Text;
            Empresa.Cep = txtCep.Text;
            Empresa.Cnpj =txtCnpj.Text;
            Empresa.Celular = txtCelular.Text;
            Empresa.Telefone = txtTelefone.Text;
        }

        private async Task EfetuarGravacao()
        {
            try
            {
                CarregarObjeto();
               await EmpresaService.Alterar(Empresa);
               MessageBox.Show("Empresa Alterada com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EfetuarGravacao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnBuscarCEPNaInternet_Click(object sender, EventArgs e)
        {

        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscarCEPViaCEP(true);
        }
    }
}