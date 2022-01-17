using PSIClient.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PSIClient
{
    public class UsuarioClient:baseAPI
    {
        public HttpResponseMessage Autenticar(string json)
        {
            return   base.post("v1/usuario/autenticar", json,false);
        }

        public string ObterPorUsuarioESenha(string username, string senha)
        {
            return base.retornar($"v1/usuario/obterporusuarioesenha?username={username}&password={senha}");
        }
        public HttpResponseMessage Post(string json)
        {
            return  base.post("v1/usuario", json);
        }

       public HttpResponseMessage Put(string json)
        {
            return base.put("v1/usuario", json);
        }

        public async Task<string> Delete(Guid id)
        {
            return await base.delete("v1/usuario/", id);
        }
      
        public string ObterPorId(Guid id)
        {
            return base.retornar("v1/usuario/" + id.ToString());
        }
       

        public string ObterTodos(Guid empresa_id)
        {
            return base.retornar($"v1/usuario/obterporempresa/{empresa_id}");
        }


    }
}
