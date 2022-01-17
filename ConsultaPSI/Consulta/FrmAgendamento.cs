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
    public partial class FrmAgendamento : DevExpress.XtraEditors.XtraForm
    {
        public FrmAgendamento()
        {
            InitializeComponent();
        }
        private Dominio.ViewModel.ConsultaViewModel _ConsultaViewModel;
        public Dominio.ViewModel.ConsultaViewModel ConsultaViewModel
        {
          set
            {
                _ConsultaViewModel = value;
            }  
        }

        private BOPSI.ConsultaService _consultaService;
        private BOPSI.ConsultaService consultaService
        {
            get
            {
                if (_consultaService == null)
                    _consultaService = new BOPSI.ConsultaService();
                return _consultaService;
            }
        }

        private enuOPeracao _operacao = enuOPeracao.Incluir;
        public enum enuOPeracao
        {
            Incluir,
            Alterar
        }


        private void CarregarCombox()
        {
            var lstPaciente = new List<Dominio.ViewModel.PacienteViewModel>();
            var lstPsicologo = new List<Dominio.ViewModel.PsicologaViewModel>();
            var PacienteService = new BOPSI.PacienteService();
            var PsicologoService = new BOPSI.PsicologaService();

            lstPaciente =  PacienteService.ObterPorEmpresa(Util.Usuario.UsuarioLogado.acesso.empresa_Id).Result;
            lstPsicologo = PsicologoService.ObterPorEmpresa(Guid.Parse(Util.Usuario.UsuarioLogado.acesso.empresa_Id)).Result;
            Lutils.Controles.LookUpEdit.CarregarComboBox<Dominio.ViewModel.PacienteViewModel>(gridLookUpEditPaciente, lstPaciente,"Nome","Id","Paciente");
            Lutils.Controles.LookUpEdit.CarregarComboBox<Dominio.ViewModel.PsicologaViewModel>(gridLookUpEditPsicologa, lstPsicologo, "Nome", "Id", "Psicologo");

        }

        private void FrmAgendamento_Load(object sender, EventArgs e)
        {
            cmbTempoDeConsulta.SelectedIndex = 1;
        }

        private void FrmAgendamento_Shown(object sender, EventArgs e)
        {
            CarregarCombox();
        }

        private void CarregarObjeto()
        {
            _ConsultaViewModel = new Dominio.ViewModel.ConsultaViewModel();
            _ConsultaViewModel.proposito = txtProposito.Text;
            _ConsultaViewModel.Paciente_Id = Guid.Parse(gridLookUpEditPaciente.EditValue.ToString());
            _ConsultaViewModel.Psicologa_Id = Guid.Parse(gridLookUpEditPsicologa.EditValue.ToString());
            DateTime dataHora = Convert.ToDateTime( dateEditConsulta.EditValue);
            _ConsultaViewModel.Horario = new DateTime(dataHora.Year, dataHora.Month, dataHora.Day, timeSpanEditHora.TimeSpan.Hours, timeSpanEditHora.TimeSpan.Minutes, 0);
                        
            _ConsultaViewModel.UmaHora = cmbTempoDeConsulta.SelectedItem.ToString().Contains("60");
            _ConsultaViewModel.JaViuSatisfacao = false;
            _ConsultaViewModel.Status = Dominio.ViewModel.ConsultaViewModel.enuStatus.NaoOcorrido.ToString().Substring(0,1);
            _ConsultaViewModel.Empresa_Id = Guid.Parse(Util.Usuario.UsuarioLogado.acesso.empresa_Id);
        }

        private void Limpar()
        {
            _ConsultaViewModel = new Dominio.ViewModel.ConsultaViewModel();
            CarregarRegistro();
        }

        private void CarregarRegistro()
        {
            txtProposito.Text = _ConsultaViewModel.proposito;
            gridLookUpEditPaciente.EditValue = _ConsultaViewModel.Paciente_Id;
            gridLookUpEditPsicologa.EditValue = _ConsultaViewModel.Psicologa_Id;
            dateEditConsulta.EditValue = _ConsultaViewModel.Horario.Date;
            timeSpanEditHora.EditValue = _ConsultaViewModel.Horario.TimeOfDay;
            if (_ConsultaViewModel.UmaHora)
                cmbTempoDeConsulta.SelectedIndex = 1;
            else
                cmbTempoDeConsulta.SelectedIndex = 0;


        }


     private void ValidarParaGravacao()
        {
            
            if (dateEditConsulta.EditValue == null)
                throw new Exception("Data Precisa ser preenchida!");

            if (timeSpanEditHora.EditValue == null || timeSpanEditHora.EditValue.ToString() == "00:00:00")
                throw new Exception("Horário ser preenchido!");
            DateTime data = (DateTime)dateEditConsulta.EditValue;
            if (_operacao == enuOPeracao.Incluir && data.Date < DateTime.Now.Date)
                throw new Exception("Data não pode ser anterior a hoje!");

           
        }

        private async Task EfetuarGravacao()
        {
            try
            {
                ValidarParaGravacao();
                CarregarObjeto();
                switch (_operacao)
                {
                    case enuOPeracao.Incluir:
                        await consultaService.Incluir(_ConsultaViewModel);
                        XtraMessageBox.Show("Registro Incluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        await ConsultaPSI.FrmPrincipal.frm.RetornarConsultasNaoRealizadas();
                        break;
                    default:
                        break;
                }


               
               
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EfetuarGravacao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}