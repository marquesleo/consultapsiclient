using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPSI.Consulta.ViewModel
{
    public class ConsultaViewModel :Dominio.ViewModel.ConsultaViewModel
    {

        public ConsultaViewModel(Dominio.ViewModel.ConsultaViewModel p)
        {
            if (p != null)
            {
                foreach (FieldInfo prop in p.GetType().GetFields())
                    GetType().GetField(prop.Name).SetValue(this, prop.GetValue(p));

                foreach (PropertyInfo prop in p.GetType().GetProperties())
                    GetType().GetProperty(prop.Name).SetValue(this, prop.GetValue(p, null), null);
            }
        }

       
        private Dominio.ViewModel.PacienteViewModel _Paciente;
        private Dominio.ViewModel.PsicologaViewModel _Psicologa;
        private Dominio.ViewModel.PacienteViewModel Paciente
        {
            get {
                if (_Paciente == null)
                {
                    var PacienteService = new BOPSI.PacienteService();

                    if (!BOPSI.PacienteService.lstPacienteViewModel.Any(p => p.Id == this.Paciente_Id))
                    {
                        _Paciente = PacienteService.ObterPorId(this.Paciente_Id).Result;
                        BOPSI.PacienteService.lstPacienteViewModel.Add(_Paciente);
                        return _Paciente;
                    }
                    else
                        _Paciente = BOPSI.PacienteService.lstPacienteViewModel.Find(p => p.Id == this.Paciente_Id);

                }
                return _Paciente;
            }
        }
        private Dominio.ViewModel.PsicologaViewModel Psicologo
        {
            get
            {
                if (_Psicologa == null)
                {
                    var PsicologoService = new BOPSI.PsicologaService();

                    if (!BOPSI.PsicologaService.lstPsicologoViewModel.Any(p => p.Id == this.Psicologa_Id))
                    {
                        _Psicologa = PsicologoService.ObterTodos(this.Psicologa_Id).Result;
                        BOPSI.PsicologaService.lstPsicologoViewModel.Add(_Psicologa);
                        return _Psicologa;
                    }
                    else
                        _Psicologa = BOPSI.PsicologaService.lstPsicologoViewModel.Find(p => p.Id == this.Psicologa_Id);

                }
                return _Psicologa;
            }
        }
        public string NomeDoPaciente => Paciente.Nome;
        public string NomeDoPsicologo => Psicologo.Nome;
        public string Situacao
        {
            get
            {
                if (this.Status == "N")
                    return "Não Ocorrido";
                else if (this.Status == "O")
                    return "Ocorrido";
                else
                    return "Cancelado";
            }
        }
        public string TelefoneDoPaciente
        {
            get
            {
                return $"{Paciente.Telefone}/{Paciente.Celular}";
            }
        }

        public string TempoDeConsulta
        {
            get
            {
                return (this.UmaHora ? "60 Minutos" : "30 Minutos"); 
            }
        }

    }
}
