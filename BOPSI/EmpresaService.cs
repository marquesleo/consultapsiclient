using Dominio.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOPSI
{
    public class EmpresaService
    {
        private PSIClient.EmpresaClient _EmpresaClient;
        private PSIClient.EmpresaClient EmpresaClient
        {
            get
            {
                if (_EmpresaClient == null)
                    _EmpresaClient = new PSIClient.EmpresaClient();
                return _EmpresaClient;
            }
        }


        public async Task<EmpresaViewModel> ObterPorId(Guid Id)
        {
            var retorno = EmpresaClient.ObterPorId(Id);
            return JsonConvert.DeserializeObject<EmpresaViewModel>(retorno);
        }

        public async Task<EmpresaViewModel> Incluir(EmpresaViewModel empresaViewModel)
        {
            string output = JsonConvert.SerializeObject(empresaViewModel);
            var retorno = EmpresaClient.Post(output);
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
                var token = (EmpresaViewModel)JsonConvert.DeserializeObject<EmpresaViewModel>(retorno.Content.ReadAsStringAsync().Result);
                return token;
            }
            else
                throw new Exception(retorno.Content.ReadAsStringAsync().Result);
        }

        public async Task<bool> Alterar(EmpresaViewModel empresaViewModel)
        {
            string output = JsonConvert.SerializeObject(empresaViewModel);
            var retorno = EmpresaClient.Put(output);
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
    }
}
