using PSIClient.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PSIClient
{
    public class PacienteClient : baseAPI
    {

        public HttpResponseMessage Post(string json)
        {
            return base.post("v1/paciente", json);
        }

        public HttpResponseMessage Put(string json)
        {
            return  base.put("v1/paciente", json);
        }

        public async Task<string> Delete(Guid id)
        {
            return await base.delete("v1/paciente/", id);
        }

        public string ObterPorId(Guid id)
        {
            return base.retornar("v1/paciente/" + id.ToString());
        }

        public string ObterPorNome(string nome)
        {
            return base.retornar($"v1/paciente/obterporfiltros?nomeDoPaciente={nome}");
        }

        public string ObterPorEmpresa(string id_empresa)
        {
            return base.retornar($"v1/paciente/obterporempresa/{id_empresa}");
        }


        public string ObterTodos()
        {
            return base.retornar("v1/paciente");
        }
    }
}
