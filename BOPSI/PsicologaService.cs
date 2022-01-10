using Dominio.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BOPSI
{
    public class PsicologaService
    {
        private static List<PsicologaViewModel> _lstPsicologoViewModel;
        public static List<PsicologaViewModel> lstPsicologoViewModel
        {
            get
            {
                if (_lstPsicologoViewModel == null)
                    _lstPsicologoViewModel = new List<PsicologaViewModel>();
                return _lstPsicologoViewModel;
            }
        }


        private PSIClient.PsicologaClient _PsicologaClient;
        private PSIClient.PsicologaClient PsicologaClient
        {
            get
            {
                if (_PsicologaClient == null)
                    _PsicologaClient = new PSIClient.PsicologaClient();
                return _PsicologaClient;
            }
        }
        public async Task<List<PsicologaViewModel>> ObterTodos()
        {
            var retorno = PsicologaClient.ObterTodos();
            return JsonConvert.DeserializeObject<List<PsicologaViewModel>>(retorno);
        }

        public async Task<List<PsicologaViewModel>> ObterPorNome(string nome)
        {
            var retorno = PsicologaClient.ObterPorNome(nome);
            return JsonConvert.DeserializeObject<List<PsicologaViewModel>>(retorno);
        }

        public async Task<PsicologaViewModel> ObterTodos(Guid Id)
        {
            var retorno = PsicologaClient.ObterPorId(Id);
            return JsonConvert.DeserializeObject<PsicologaViewModel>(retorno);
        }

        public async Task<List<PsicologaViewModel>> ObterPorEmpresa(Guid empresa_id)
        {
            var retorno = PsicologaClient.ObterPorEmpresa(empresa_id);
            return JsonConvert.DeserializeObject<List<PsicologaViewModel>>(retorno);
        }


        public async Task<PsicologaViewModel> Incluir(PsicologaViewModel psicologaViewModel)
        {
            string output = JsonConvert.SerializeObject(psicologaViewModel);
            var retorno = PsicologaClient.Post(output);
            if (retorno.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var msg = UtilErroPsicologo.RetornarErroTratado(retorno);
                throw new Exception(msg);
            }
            else if (retorno.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception(UtilErroPsicologo.RetornarErroTratado(retorno));
            }
            else if (retorno.StatusCode == System.Net.HttpStatusCode.OK || retorno.StatusCode == System.Net.HttpStatusCode.Created)
            {
                var token = (PsicologaViewModel)JsonConvert.DeserializeObject<PsicologaViewModel>(retorno.Content.ReadAsStringAsync().Result);
                return token;
            }
            else
                throw new Exception(retorno.Content.ReadAsStringAsync().Result);
        }

        public async Task<bool> Alterar(PsicologaViewModel psicologaViewModel)
        {
            string output = JsonConvert.SerializeObject(psicologaViewModel);
            var retorno = PsicologaClient.Put(output);
            if (retorno.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                throw new Exception(UtilErroPsicologo.RetornarErroTratado(retorno));
            }
            else if (retorno.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception(UtilErroPsicologo.RetornarErroTratado(retorno));
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
            var retorno = await PsicologaClient.Delete(id);
            if (retorno == "")
                return true;

            return false;
        }
    }
}
