using System;
using System.Threading.Tasks;
using Domain.Consulta.ViewModels;
using Refit;
namespace ClientAPI.Client.Contratos
{
    public interface IUsuarioClient
    {
        [Post("v1/usuario/autenticar")]
        Task<bool> Autenticar(LoginViewModel loginViewModel);
        
        [Post("v1/usuario")]
        Task<LoginViewModel> Incluir(LoginViewModel loginViewModel);
       
        
        [Get("/api/usuario/{id}")]
        Task<LoginViewModel> ObterUsuario([AliasAs("id")] Guid Id);

    }
}
