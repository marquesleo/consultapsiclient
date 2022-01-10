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

namespace ConsultaPSI.Psicologa
{
    public partial class FrmPsicologa : Form
    {
        public FrmPsicologa()
        {
            InitializeComponent();
        }

        private BOPSI.PsicologaService _PsicologaService;
        private BOPSI.PsicologaService PsicologaService
        {
            get
            {
                if (_PsicologaService == null)
                    _PsicologaService = new BOPSI.PsicologaService();
                return _PsicologaService;
            }
        }

        private List<Dominio.ViewModel.PsicologaViewModel> lstPsicologa
        {
            get
            {
                return (List<Dominio.ViewModel.PsicologaViewModel>)dgrdPsicologo.DataSource;
            }
        }

        private Dominio.ViewModel.PsicologaViewModel getSelecionado
        {
            get
            {
                if (grdPsicologo.SelectedRowsCount > 0)
                {
                    return lstPsicologa[grdPsicologo.GetDataSourceRowIndex(grdPsicologo.FocusedRowHandle)];
                }
                else
                    return new Dominio.ViewModel.PsicologaViewModel();
            }
        }

        private void Alterar()
        {
            if (getSelecionado != null && !string.IsNullOrEmpty(getSelecionado.Id.ToString()))
            {
                var frm = new FrmCadastroDePsicologa();
                frm.OPERACAO = FrmCadastroDePsicologa.enuOperacao.Alterar;
                frm.Psicologa = getSelecionado;
                frm.ShowDialog();
                if (frm.houveInclusao)
                    EfetuarConsulta();
            }
        }


        private void OnBeginRefresh()
        {
            dgrdPsicologo.BeginUpdate();
            splashScreenManager1.ShowWaitForm();

        }

        private void OnEndRefresh()
        {
            dgrdPsicologo.EndUpdate();
            splashScreenManager1.CloseWaitForm();
        }

        private void FormatarGrid()
        {
            Lutils.Controles.GridView.ocultarColunas(ref grdPsicologo);
            if (grdPsicologo.RowCount > 0)
            {
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "Ativo", 0, true, false, 50, " ");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "Nome", 1, true, false, 150, "Nome Completo");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "CRP", 2, true, false, 150, "CRP");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "Email", 3, true, false, 100, "E-mail");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "Celular", 4, true, false, 100, "Celular");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "Telefone", 5, true, false, 100, "Telefone");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "Bairro", 6, true, false, 100, "Bairro");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "Endereco", 7, true, false, 200, "Endereco");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "Cidade", 8, true, false, 100, "Cidade");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "Cep", 9, true, false, 100, "Cep");
                Lutils.Controles.GridView.Formatar(ref grdPsicologo, "DtNascimento", 10, true, false, 100, "Dt.Nascimento");
            }

        }
        private void EfetuarConsulta()
        {
            OnBeginRefresh();
            try
            {
                var lstPacientes = PsicologaService.ObterPorNome(txtNomeDoPaciente.EditValue.ToString()).Result;
                dgrdPsicologo.DataSource = lstPacientes;
                FormatarGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                dgrdPsicologo.DataSource = null;
            }
            finally
            {
                OnEndRefresh();
            }
        }
        private void ExcluirParticipante()
        {
            if (grdPsicologo.RowCount > 0 && XtraMessageBox.Show($"Deseja Excluir Psicologo:{getSelecionado.Nome} ?",
                            this.Text, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes){
                try
                {
                    PsicologaService.ExcluirRegistro(getSelecionado.Id);
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
                var frm = new FrmCadastroDePsicologa();
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
            dgrdPsicologo.ShowPrintPreview();
        }

        private void FrmPsicologa_Load(object sender, EventArgs e)
        {

        }
    }
}
