using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaPSI.Paciente
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
            frm = this;
        }
        public static FrmPaciente frm;

        private BOPSI.PacienteService _PacienteService;
        private BOPSI.PacienteService PacienteService
        {
            get
            {
                if (_PacienteService == null)
                    _PacienteService = new BOPSI.PacienteService();
                return _PacienteService;
            }
        }

        private List<Dominio.ViewModel.PacienteViewModel> lstPacientes
        {
            get
            {
                return (List<Dominio.ViewModel.PacienteViewModel>)dgrdPaciente.DataSource;
            }
        }

        private Dominio.ViewModel.PacienteViewModel getSelecionado
        {
            get
            {
                if (grdPaciente.SelectedRowsCount > 0)
                {
                    return lstPacientes[grdPaciente.GetDataSourceRowIndex(grdPaciente.FocusedRowHandle)];
                }
                else
                    return new Dominio.ViewModel.PacienteViewModel();
            }
        }

        private void Alterar()
        {
            if (getSelecionado != null && !string.IsNullOrEmpty(getSelecionado.Id.ToString()))
            {
                var frm = new FrmCadastroDePacientes();
                frm.OPERACAO = FrmCadastroDePacientes.enuOperacao.Alterar;
                frm.Paciente = getSelecionado;
                frm.ShowDialog();
                if (frm.houveInclusao)
                    EfetuarConsulta();
            }
        }


        private void OnBeginRefresh()
        {
            dgrdPaciente.BeginUpdate();
            splashScreenManager1.ShowWaitForm();

        }

        private void OnEndRefresh()
        {
            dgrdPaciente.EndUpdate();
            splashScreenManager1.CloseWaitForm();
        }

        private void FormatarGrid()
        {
            Lutils.Controles.GridView.ocultarColunas(ref grdPaciente);
            if (grdPaciente.RowCount > 0)
            {
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "Ativo", 0, true, false, 50, " ");
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "Nome", 1, true, false, 150, "Nome Completo");
               
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "Email", 2, true, false, 100, "E-mail");
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "Celular", 3, true, false, 100, "Celular");
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "Telefone", 4, true, false, 100, "Telefone");
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "Bairro", 5, true, false, 100, "Bairro");
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "Endereco", 6, true, false, 200, "Endereco");
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "Cidade", 7, true, false, 100, "Cidade");
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "Cep", 8, true, false, 100, "Cep");
                Lutils.Controles.GridView.Formatar(ref grdPaciente, "DtNascimento", 9, true, false, 100, "Dt.Nascimento");
            }

        }
        public async Task  EfetuarConsulta()
        {
            OnBeginRefresh();
            try
            {
                var lstPacientes = PacienteService.ObterPorNome(txtNomeDoPaciente.EditValue.ToString()).Result;
                dgrdPaciente.DataSource = lstPacientes;
                FormatarGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                dgrdPaciente.DataSource = null;
            }
            finally
            {
                OnEndRefresh();
            }
        }
        private void ExcluirParticipante()
        {
            if (grdPaciente.RowCount > 0 && XtraMessageBox.Show($"Deseja Excluir Paciente:{getSelecionado.Nome} ?",
                            this.Text, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes){
                try
                {
                    PacienteService.ExcluirRegistro(getSelecionado.Id);
                    EfetuarConsulta();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnFiltrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EfetuarConsulta();
        }

        private void FrmPaciente_Shown(object sender, EventArgs e)
        {
            EfetuarConsulta();
        }

        private void NovoPaciente()
        {
            try
            {
                var frm = new FrmCadastroDePacientes();
                frm.Show();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnNovoPaciente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NovoPaciente();
        }

        private void dgrdPaciente_DoubleClick(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnAlterarPaciente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Alterar();
        }

        private void btnExcluirParticipante_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExcluirParticipante();
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dgrdPaciente.ShowPrintPreview();
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
