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
    public partial class FrmAlterarConsulta : DevExpress.XtraEditors.XtraForm
    {
        public FrmAlterarConsulta()
        {
            InitializeComponent();
        }
        private bool _HouveAlteracao =  false;
        public bool HouveAlteracao
        {
            get
            {
                return _HouveAlteracao;
            }
        }
        private Dominio.ViewModel.ConsultaViewModel ConsultaIns;

        private ViewModel.ConsultaViewModel _Consulta;
        public ViewModel.ConsultaViewModel Consulta
        {
            set
            {
                _Consulta = value;
            }
        }

        private void CarregarRegistro()
        {
            labelPaciente.Text = _Consulta.NomeDoPaciente;
            labelPsicologo.Text = _Consulta.NomeDoPsicologo;
            dateEditConsulta.EditValue = _Consulta.Horario;
            timeSpanEditHora.EditValue = _Consulta.Horario.TimeOfDay;
            if (_Consulta.UmaHora)
                cmbTempoDeConsulta.SelectedIndex = 1;
            else
                cmbTempoDeConsulta.SelectedIndex = 0;
            cmbSituacao.SelectedItem = _Consulta.Situacao;
            memObservacao.Text = _Consulta.Obervacao;


        }

        private void FrmAlterarConsulta_Load(object sender, EventArgs e)
        {
            CarregarRegistro();
        }

        private void ValidarParaGravacao()
        {

            if (dateEditConsulta.EditValue == null)
                throw new Exception("Data Precisa ser preenchida!");

            if (timeSpanEditHora.EditValue == null || timeSpanEditHora.EditValue.ToString() == "00:00:00")
                throw new Exception("Horário ser preenchido!");
            DateTime data = (DateTime)dateEditConsulta.EditValue;
            if (data.Date < DateTime.Now.Date)
                throw new Exception("Data não pode ser anterior a hoje!");


        }

        private void CarregarObjeto()
        {
            ConsultaIns = new Dominio.ViewModel.ConsultaViewModel();
            ConsultaIns.Id = _Consulta.Id;
            ConsultaIns.Paciente_Id = _Consulta.Paciente_Id;
            ConsultaIns.Psicologa_Id = _Consulta.Psicologa_Id;
            ConsultaIns.proposito = _Consulta.proposito;
            ConsultaIns.Obervacao = memObservacao.Text;
            DateTime dataHora = Convert.ToDateTime(dateEditConsulta.EditValue);
            ConsultaIns.Horario = new DateTime(dataHora.Year, dataHora.Month, dataHora.Day, timeSpanEditHora.TimeSpan.Hours, timeSpanEditHora.TimeSpan.Minutes, 0);

            ConsultaIns.UmaHora = cmbTempoDeConsulta.SelectedItem.ToString().Contains("60");
            ConsultaIns.JaViuSatisfacao = false;
            if (cmbSituacao.SelectedItem.ToString() == "Não Ocorrido")
                ConsultaIns.Status = "N";
            else if (cmbSituacao.SelectedItem.ToString() == "Ocorrido")
                ConsultaIns.Status = "O";
            else
                ConsultaIns.Status = "C";
            ConsultaIns.Empresa_Id = Guid.Parse(Util.Usuario.UsuarioLogado.acesso.empresa_Id);
        }

        private async  Task EfetuarAlteracao()
        {
            try
            {
                ValidarParaGravacao();
                CarregarObjeto();
                var ConsultaService = new BOPSI.ConsultaService();
                await ConsultaService.Alterar(ConsultaIns);
                XtraMessageBox.Show("Consulta Alterada Com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _HouveAlteracao = true;
                this.Close();

            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            EfetuarAlteracao();
        }
    }
}