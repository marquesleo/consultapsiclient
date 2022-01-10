using Dominio.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOPSI
{
    public class ConsultaService
    {
        private PSIClient.ConsultaClient _ConsultaClient;
        private PSIClient.ConsultaClient ConsultaClient
        {
            get
            {
                if (_ConsultaClient == null)
                    _ConsultaClient = new PSIClient.ConsultaClient();
                return _ConsultaClient;
            }
        }
        public async Task<List<ConsultaViewModel>> ObterTodos()
        {
            var retorno = ConsultaClient.ObterTodos();
            return JsonConvert.DeserializeObject<List<ConsultaViewModel>>(retorno);
        }
        public async Task<ConsultaViewModel> ObterTodos(Guid Id)
        {
            var retorno = ConsultaClient.ObterPorId(Id);
            return JsonConvert.DeserializeObject<ConsultaViewModel>(retorno);
        }

        public async Task<bool> IsJaExisteMarcado(Guid empresa_id, DateTime dataHora)
        {
            var retorno = ConsultaClient.IsJaExisteMarcado(empresa_id, dataHora);
            return JsonConvert.DeserializeObject<bool>(retorno);
        }


        public async Task<List<ConsultaViewModel>> ConsultarAgendamento(Guid empresa_id,
                                                                      DateTime diaInicial,
                                                                      DateTime diaFinal,
                                                                      Guid paciente_id,
                                                                      Guid psicologo_id)
        {
            var retorno = ConsultaClient.ConsultarAgendamento(empresa_id, diaInicial,diaFinal,paciente_id,psicologo_id);
            return JsonConvert.DeserializeObject<List<ConsultaViewModel>>(retorno);
        }

        public async Task<List<ConsultaViewModel>> ConsultarAgendaNaoRealizada(Guid empresa_id,
                                                                     DateTime dia,
                                                                     string paciente,
                                                                     string psicologo)
        {
            var retorno = ConsultaClient.ConsultarAgendaNaoRealizada(empresa_id, dia.ToShortDateString(), paciente, psicologo);
            return JsonConvert.DeserializeObject<List<ConsultaViewModel>>(retorno);
        }


        public async Task<ConsultaViewModel> Incluir(ConsultaViewModel consultaViewModel)
        {
            string output = JsonConvert.SerializeObject(consultaViewModel);
            var retorno = ConsultaClient.Post(output);
            if (retorno.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var msg = UtilErroPaciente.RetornarErroTratado(retorno);
                throw new Exception(msg);
            }
            else if (retorno.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception(UtilErroPaciente.RetornarErroTratado(retorno));
            }
            else if (retorno.StatusCode == System.Net.HttpStatusCode.OK || retorno.StatusCode == System.Net.HttpStatusCode.Created)
            {
                var token = (ConsultaViewModel)JsonConvert.DeserializeObject<ConsultaViewModel>(retorno.Content.ReadAsStringAsync().Result);
                return token;
            }
            else
                throw new Exception(retorno.Content.ReadAsStringAsync().Result);
        }

        public async Task<bool> Alterar(ConsultaViewModel consultaViewModel)
        {
            string output = JsonConvert.SerializeObject(consultaViewModel);
            var retorno = ConsultaClient.Put(output);
            if (retorno.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var msg = UtilErroPaciente.RetornarErroTratado(retorno);
                throw new Exception(msg);
            }
            else if (retorno.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception(UtilErroPaciente.RetornarErroTratado(retorno));
            }
            else if (retorno.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
                throw new Exception(retorno.Content.ReadAsStringAsync().Result);
        }

        public async Task<bool> ExcluirRegistro(Guid id)
        {
            var retorno = await ConsultaClient.Delete(id);
            if (retorno == "")
                return true;

            return false;
        }



    }
}
