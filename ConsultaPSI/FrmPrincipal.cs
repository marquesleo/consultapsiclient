using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaPSI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            frm = this;
        }

        public static FrmPrincipal frm;

        private void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private List<ConsultaPSI.Consulta.ViewModel.ConsultaViewModel> lstConsulta
        {
            get
            {
                return (List<ConsultaPSI.Consulta.ViewModel.ConsultaViewModel>)dgrdConsulta.DataSource;
            }
        }

        private void ChamarLogin()
        {
            try
            {
                var frm = new ConsultaPSI.Usuario.FrmLoginUsuario();
                frm.ShowDialog();
                if (frm.UsuarioToken != null)
                {
                    Util.Usuario.UsuarioLogado = frm.UsuarioToken;
                    RetornarConsultasNaoRealizadas();
                }
                else
                    Application.Exit();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

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

        public async Task RetornarConsultasNaoRealizadas()
        {
            try
            {

                OnBeginRefresh();
                DateTime dtInicial = DateTime.MinValue;
                string paciente = string.Empty;
                string psicologo = string.Empty;

                Guid paciente_id = Guid.Empty;
                Guid psicologo_id = Guid.Empty;
               if (dateEditDia.EditValue != null)
                {
                    dtInicial = Convert.ToDateTime(dateEditDia.EditValue);
                   
                }
                if (!string.IsNullOrEmpty(txtPaciente.Text))
                {
                    paciente = txtPaciente.Text;
                }

                if (!string.IsNullOrEmpty(txtPsicologo.Text))
                {
                    psicologo = txtPsicologo.Text;
                }

                var ConsultaService = new BOPSI.ConsultaService();
                var lstConsulta = await ConsultaService.ConsultarAgendaNaoRealizada(Guid.Parse(Util.Usuario.UsuarioLogado.acesso.empresa_Id), dtInicial, paciente, psicologo);

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
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "Horario", 2, true, false, 200, "Dt.Consulta", false, DevExpress.Utils.FormatType.DateTime, DevExpress.Data.ColumnSortOrder.None, "dd/MM/yyyy HH:mm");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "proposito", 3, true, false, 200, "Propósito");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "Situacao", 4, true, false, 200, "Status");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "TempoDeConsulta", 5, true, false, 200, "Tempo de Consulta");
                Lutils.Controles.GridView.Formatar(ref grdConsulta, "NomeDoPsicologo", 6, true, false, 200, "Psicologo");

            }

        }

        private void ChamarTelaDeUsuario()
        {
            try
            {
                var frm = new ConsultaPSI.Usuario.FrmUsuario();
                frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ChamarTelaDePaciente()
        {
            try
            {
                var frm = new ConsultaPSI.Paciente.FrmPaciente();
                frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ChamarTelaDePsicologos()
        {
            try
            {
                var frm = new ConsultaPSI.Psicologa.FrmPsicologa();
                frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ChamarTelaDeAgendamento()
        {
            try
            {
                var frm = new ConsultaPSI.Consulta.FrmAgendamento();
                frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ChamarTelaDeConsultaAgendamento()
        {
            try
            {
                var frm = new ConsultaPSI.Consulta.FrmConsultaAgendamento();
                frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ChamarTelaDeCadastroDeEmpresa()
        {
            try
            {
                var frm = new ConsultaPSI.Empresa.FrmEmpresa();
                frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private ConsultaPSI.Consulta.ViewModel.ConsultaViewModel getSelecionado
        {
            get
            {
                if (grdConsulta.SelectedRowsCount > 0)
                {
                    return lstConsulta[grdConsulta.GetDataSourceRowIndex(grdConsulta.FocusedRowHandle)];
                }
                else
                    return new ConsultaPSI.Consulta.ViewModel.ConsultaViewModel(null);
            }
        }

        private void Alterar()
        {
            if (getSelecionado != null && !string.IsNullOrEmpty(getSelecionado.Id.ToString()))
            {
                var frm = new ConsultaPSI.Consulta.FrmAlterarConsulta();
                frm.Consulta = getSelecionado;
             
                frm.ShowDialog();
                if (frm.HouveAlteracao)
                    RetornarConsultasNaoRealizadas();
            }
        }

        private void btnUsuarioCadastro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChamarTelaDeUsuario();
        }

        private void btnCadastroDePaciente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChamarTelaDePaciente();
        }

        private void btnCadastroDeTipoDeRecebimento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChamarTelaDePsicologos();
        }

        private void btnExcluirPedidoEmAberto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChamarTelaDeAgendamento();
        }
       

        private void btnConsultaAgendamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChamarTelaDeConsultaAgendamento();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            RetornarConsultasNaoRealizadas();
        }

        private void btnSair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogoff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void grdConsulta_DoubleClick(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChamarTelaDeCadastroDeEmpresa();
        }
    }
}
