using PSIClient.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PSIClient
{
    public class PsicologaClient : baseAPI
    {

        public HttpResponseMessage Post(string json)
        {
            return base.post("v1/psicologa", json);
        }

        public HttpResponseMessage Put(string json)
        {
            return base.put("v1/psicologa", json);
        }

        public async Task<string> Delete(Guid id)
        {
            return await base.delete("v1/psicologa/", id);
        }

        public string ObterPorId(Guid id)
        {
            return base.retornar("v1/psicologa/" + id.ToString());
        }

        public string  ObterPorEmpresa(Guid empresa_id)
        {
            return base.retornar($"v1/psicologa/obterporempresa/{empresa_id}");
        }


        public string ObterPorNome(string nome)
        {
            return base.retornar($"v1/psicologa/obterporfiltros?nomeDaPsicologa={nome}");
        }

        public string ObterTodos()
        {
            return base.retornar("v1/psicologa");
        }
    }
   
}
