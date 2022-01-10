using Dominio.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOPSI
{
   public class PacienteService
    {

        private static List<PacienteViewModel> _lstPacienteViewModel;
        public static List<PacienteViewModel> lstPacienteViewModel
        {
            get
            {
                if (_lstPacienteViewModel == null)
                    _lstPacienteViewModel = new List<PacienteViewModel>();
                return _lstPacienteViewModel;
            }
        }
        private PSIClient.PacienteClient _PacienteClient;
        private PSIClient.PacienteClient PacienteClient
        {
            get
            {
                if (_PacienteClient == null)
                    _PacienteClient = new PSIClient.PacienteClient();
                return _PacienteClient;
            }
        }
        public async Task<List<PacienteViewModel>> ObterTodos()
        {
            var retorno = PacienteClient.ObterTodos();
            return JsonConvert.DeserializeObject<List<PacienteViewModel>>(retorno);
        }

        public async Task<List<PacienteViewModel>> ObterPorNome(string nome)
        {
            var retorno = PacienteClient.ObterPorNome(nome);
            return JsonConvert.DeserializeObject<List<PacienteViewModel>>(retorno);
        }

        public async Task<PacienteViewModel> ObterPorId(Guid Id)
        {
            var retorno = PacienteClient.ObterPorId(Id);
            return JsonConvert.DeserializeObject<PacienteViewModel>(retorno);
        }

        public async Task<List<PacienteViewModel>> ObterPorEmpresa(string empresa_id)
        {
            var retorno = PacienteClient.ObterPorEmpresa(empresa_id);
            return JsonConvert.DeserializeObject<List<PacienteViewModel>>(retorno);
        }

       



        public async Task<PacienteViewModel> Incluir(PacienteViewModel pacienteViewModel)
        {
            string output = JsonConvert.SerializeObject(pacienteViewModel);
            var retorno = PacienteClient.Post(output);
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
                var token = (PacienteViewModel)JsonConvert.DeserializeObject<PacienteViewModel>(retorno.Content.ReadAsStringAsync().Result);
                return token;
            }
            else
                throw new Exception(retorno.Content.ReadAsStringAsync().Result);
        }

        public async Task<bool> Alterar(PacienteViewModel pacienteViewModel)
        {
            string output = JsonConvert.SerializeObject(pacienteViewModel);
            var retorno =  PacienteClient.Put(output);
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
            var retorno = await PacienteClient.Delete(id);
            if (retorno == "")
                return true;

            return false;
        }
    }
}
