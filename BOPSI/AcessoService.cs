using Dominio.ViewModel;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace BOPSI
{
    public class AcessoService
    {
        private PSIClient.AcessoClient _AcessoClient;
        private PSIClient.AcessoClient AcessoClient
        {
            get
            {
                if (_AcessoClient == null)
                    _AcessoClient = new PSIClient.AcessoClient();
                return _AcessoClient;
            }
        }

        public async Task<AcessoViewModel> ObterPorUsuarioESenha(Guid idUsuario, Guid idEmpresa)
        {
            try
            {
                var retorno = AcessoClient.ObterPorUsuarioEEmpresa(idUsuario, idEmpresa);

                return (AcessoViewModel)JsonConvert.DeserializeObject<AcessoViewModel>(retorno);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return null;

        }

     
        public async Task<AcessoViewModel> ObterPorId(Guid Id)
        {
            var retorno = AcessoClient.ObterPorId(Id);
            return JsonConvert.DeserializeObject<AcessoViewModel>(retorno);
        }


        public async Task<AcessoViewModel> Incluir(AcessoViewModel acessoViewModel)
        {
            string output = JsonConvert.SerializeObject(acessoViewModel);
            var retorno = AcessoClient.Post(output);
            return null;
        }

        public async Task<bool> Alterar(AcessoViewModel acessoViewModel)
        {
            string output = JsonConvert.SerializeObject(acessoViewModel);
            var retorno =  AcessoClient.Put(output);
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

            return false;
        }

      
    }
}
