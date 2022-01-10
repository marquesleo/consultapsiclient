using Dominio.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace BOPSI
{
    public class UsuarioService
    {
        private PSIClient.UsuarioClient _UsuarioClient;
        private PSIClient.UsuarioClient UsuarioClient
        {
            get
            {
                if (_UsuarioClient == null)
                    _UsuarioClient = new PSIClient.UsuarioClient();
                return _UsuarioClient;
            }
        }


        public async Task<TokenLogado> Autenticar(LoginViewModel loginViewModel)
        {
            try
            {
                string output = JsonConvert.SerializeObject(loginViewModel);

                var retorno =  UsuarioClient.Autenticar(output);
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
                    var token = (TokenLogado)JsonConvert.DeserializeObject<TokenLogado>(retorno.Content.ReadAsStringAsync().Result);
                    return token;
                }
                else
                    throw new Exception(retorno.Content.ReadAsStringAsync().Result);
              
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return null;
           
        }

        public async Task<LoginViewModel> ObterPorUsuarioESenha(string usuario,string senha)
        {
            try
            {
                             

                var retorno = UsuarioClient.ObterPorUsuarioESenha(usuario,senha);
                 
                return (LoginViewModel)JsonConvert.DeserializeObject<LoginViewModel>(retorno);

             

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return null;

        }

        public async Task<List<LoginViewModel>> ObterTodos()
        { 
            var retorno = UsuarioClient.ObterTodos();
            return JsonConvert.DeserializeObject<List<LoginViewModel>>(retorno);
        }
        public async Task<LoginViewModel> ObterTodos(Guid Id)
        {
            var retorno = UsuarioClient.ObterPorId(Id);
            return JsonConvert.DeserializeObject<LoginViewModel>(retorno);
        }


        public async Task<LoginViewModel> Incluir(LoginViewModel loginViewModel)
        {
            string output = JsonConvert.SerializeObject(loginViewModel);
            var retorno =  UsuarioClient.Post(output);
            return null; 
        }

        public async Task<bool> Alterar(LoginViewModel loginViewModel)
        {
            string output = JsonConvert.SerializeObject(loginViewModel);
            var retorno = UsuarioClient.Put(output);
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
            var retorno  = await  UsuarioClient.Delete(id);
            if (retorno == "")
                return true;

            return false;
        }
    }
}
