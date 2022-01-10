using Domain.Consulta.ViewModels;
using Refit;
using System;
using ClientAPI.Client.Contratos;
using System.Threading.Tasks;

namespace ClientAPI.Client
{
    public class UsuarioClient : IUsuarioClient
    {
        private readonly IUsuarioClient _usuarioClient;
        public UsuarioClient()
        {
            _usuarioClient = RestService.For<IUsuarioClient>("https://localhost:44393/");
        }
        public async Task<bool> Autenticar(LoginViewModel loginViewModel)
        {
            return await _usuarioClient.Autenticar(loginViewModel);
        }

        public async Task<LoginViewModel> Incluir(LoginViewModel loginViewModel)
        {
            return await _usuarioClient.Incluir(loginViewModel);
        }

        public async Task<LoginViewModel> ObterUsuario([AliasAs("id")] Guid Id)
        {
            return await _usuarioClient.ObterUsuario(Id);
        }
    }
}
