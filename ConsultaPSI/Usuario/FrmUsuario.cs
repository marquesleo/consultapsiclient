using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ConsultaPSI.Usuario
{
    public partial class FrmUsuario : DevExpress.XtraEditors.XtraForm
    {

        private List<Dominio.ViewModel.LoginViewModel> lstLoginViewModel = new List<Dominio.ViewModel.LoginViewModel>();
        private BOPSI.UsuarioService _usuarioService;
        private BOPSI.UsuarioService UsuarioService
        {
            get
            {
                if (_usuarioService == null)
                    _usuarioService = new BOPSI.UsuarioService();
                return _usuarioService;
            }
        }

        public static FrmUsuario frm;
        public FrmUsuario()
        {
            InitializeComponent();
            frm = this;
        }

        private void grpUsuario_Paint(object sender, PaintEventArgs e)
        {

        }
        public async Task EfetuarConsultaAsync()
        {
            lstLoginViewModel.Clear();
            try
            {
                lstLoginViewModel = await UsuarioService.ObterTodos(Guid.Parse(Util.Usuario.UsuarioLogado.acesso.empresa_Id));
                dgrdUsuario.DataSource = lstLoginViewModel;
                FormatarGrid();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void FormatarGrid()
        {
            Lutils.Controles.GridView.ocultarColunas(ref grdUsuario);
            if (grdUsuario.RowCount > 0)
            {
                Lutils.Controles.GridView.Formatar(ref grdUsuario, "Username", 0, true, false, 100, "Usuário");
                Lutils.Controles.GridView.Formatar(ref grdUsuario, "Email", 1, true, false, 200, "E-mail");
                Lutils.Controles.GridView.Formatar(ref grdUsuario, "Ativo", 2, true, false, 50, " ");
            }

        }

        private void Alterar()
        {
            if (grdUsuario.SelectedRowsCount > 0)
            {
               
                var selecionado = lstLoginViewModel[grdUsuario.GetDataSourceRowIndex(grdUsuario.FocusedRowHandle)];
                if (selecionado != null && !string.IsNullOrEmpty(selecionado.Id.ToString()))
                {
                    var frmCadastro = new FrmCadastroDeUsuario();
                    frmCadastro.OPERACAO = FrmCadastroDeUsuario.enuOperacao.Alterar;
                    frmCadastro.OUSUARIO = selecionado;
                    frmCadastro.Show();


                }
            }
        }

        private void Novo()
        {
            var frm = new FrmCadastroDeUsuario();
            frm.Show();
        }

        private void Excluir()
        {
            if (grdUsuario.SelectedRowsCount > 0)
            {
                var selecionado = lstLoginViewModel[grdUsuario.GetDataSourceRowIndex(grdUsuario.FocusedRowHandle)];
                if (selecionado != null && !string.IsNullOrEmpty(selecionado.Id.ToString()))
                {
                    if (MessageBox.Show(String.Format("Deseja Excluir Usuário :{0} ?", selecionado.Username), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UsuarioService.ExcluirRegistro(selecionado.Id);
                        MessageBox.Show("Usuário Excluído com Sucesso !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EfetuarConsultaAsync();
                    }
                }

            }
        }

        private void FrmUsuario_Shown(object sender, EventArgs e)
        {
            EfetuarConsultaAsync();
        }

        private void grdUsuario_DoubleClick(object sender, EventArgs e)
        {
            Alterar();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dgrdUsuario.ShowPrintPreview();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            Novo();
        }
    }
}