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

namespace ConsultaPSI.Consulta
{
    public partial class FrmConsultaAgendamento : DevExpress.XtraEditors.XtraForm
    {
        public FrmConsultaAgendamento()
        {
            InitializeComponent();
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            dateEditConsultaInicial.Enabled = chkPeriodo.Checked;
            dateEditConsultaFinal.Enabled = chkPeriodo.Checked;
            if (!chkPeriodo.Checked)
            {
                dateEditConsultaInicial.EditValue = null;
                dateEditConsultaFinal.EditValue = null;
            }
            else
            {
                dateEditConsultaFinal.EditValue = DateTime.Now;
                dateEditConsultaInicial.EditValue = DateTime.Now;
            }
        }

        private void chkPaciente_CheckedChanged(object sender, EventArgs e)
        {
            gridLookUpEditPaciente.Enabled = chkPaciente.Checked;
            if (!chkPaciente.Checked)
            {
                gridLookUpEditPaciente.EditValue = null;
            }
           
        }

        private void CarregarCombox()
        {
            var lstPaciente = new List<Dominio.ViewModel.PacienteViewModel>();
            var lstPsicologo = new List<Dominio.ViewModel.PsicologaViewModel>();
            var PacienteService = new BOPSI.PacienteService();
            var PsicologoService = new BOPSI.PsicologaService();

            lstPaciente = PacienteService.ObterPorEmpresa(Util.Usuario.UsuarioLogado.acesso.empresa_Id).Result;
            lstPsicologo = PsicologoService.ObterPorEmpresa(Guid.Parse(Util.Usuario.UsuarioLogado.acesso.empresa_Id)).Result;
            Lutils.Controles.LookUpEdit.CarregarComboBox<Dominio.ViewModel.PacienteViewModel>(gridLookUpEditPaciente, lstPaciente, "Nome", "Id", "Paciente");
            Lutils.Controles.LookUpEdit.CarregarComboBox<Dominio.ViewModel.PsicologaViewModel>(gridLookUpEditPsicologa, lstPsicologo, "Nome", "Id", "Psicologo");

        }

        private void chkPsicologa_CheckedChanged(object sender, EventArgs e)
        {
            gridLookUpEditPsicologa.Enabled = chkPsicologa.Checked;
            if (!chkPsicologa.Checked)
            {
                gridLookUpEditPsicologa.EditValue = null;
            }
        }

        private void FrmConsultaAgendamento_Load(object sender, EventArgs e)
        {
            CarregarCombox();
        }

        private async Task EfetuarConsulta()
        {
            try
            {

                OnBeginRefresh();
                DateTime dtInicial = DateTime.MinValue;
                DateTime dtFinal = DateTime.MinValue;
                Guid paciente_id = Guid.Empty;
                Guid psicologo_id = Guid.Empty;
                if (chkPeriodo.Checked)
                {
                    dtInicial = (DateTime)dateEditConsultaInicial.EditValue;
                    dtFinal = (DateTime)dateEditConsultaFinal.EditValue;
                }
                if (chkPaciente.Checked)
                {
                    paciente_id = (Guid)gridLookUpEditPaciente.EditValue;
                }

                if (chkPsicologa.Checked)
                {
                    psicologo_id = (Guid)gridLookUpEditPsicologa.EditValue;
                }

                var ConsultaService = new BOPSI.ConsultaService();
                var lstConsulta = await ConsultaService.ConsultarAgendamento(Guid.Parse(Util.Usuario.UsuarioLogado.acesso.empresa_Id), dtInicial, dtFinal, paciente_id, psicologo_id);

                List<ConsultaPSI.Consulta.ViewModel.ConsultaViewModel> lstNovaConsulta = lstConsulta.Select(parent => new ConsultaPSI.Consulta.ViewModel.ConsultaViewModel(parent)).ToList();

              
                if (lstNovaConsulta != null)
                {

                    dgrdConsulta.DataSource = lstNovaConsulta;
                    FormatarGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                dgrdConsulta.DataSource = null;
            }
            finally
            {
                OnEndRefresh();
            }
        }

       

        private void FormatarGrid()
        {
            Lutils.Controles.GridView.ocultarColunas(ref grdConsulta);
            if (grdConsulta.RowCount > 0)
            {
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "NomeDoPaciente", 0, true, false, 200, "Paciente");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "TelefoneDoPaciente", 1, true, false, 200, "Telefone do Paciente");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "Horario", 2, true, false, 200, "Dt.Consulta",false,  DevExpress.Utils.FormatType.DateTime, DevExpress.Data.ColumnSortOrder.None,"dd/MM/yyyy HH:mm");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "proposito", 3, true, false, 200, "Propósito");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "Situacao", 4, true, false, 200, "Status");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "TempoDeConsulta", 5, true, false, 200, "Tempo de Consulta");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "NomeDoPsicologo", 6, true, false, 200, "Psicologo");

            }

        }

        private void OnBeginRefresh()
        {
            dgrdConsulta.BeginUpdate();
            splashScreenManager1.ShowWaitForm();

        }

        private void OnEndRefresh()
        {
            dgrdConsulta.EndUpdate();
            splashScreenManager1.CloseWaitForm();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EfetuarConsulta();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dgrdConsulta.ShowPrintPreview();
        }
    }
}