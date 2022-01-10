using PSIClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PSIClient
{
    public class AcessoClient : baseAPI
    {

        public HttpResponseMessage Post(string json)
        {
            return base.post("v1/acesso", json);
        }

        public HttpResponseMessage Put(string json)
        {
            return  base.put("v1/acesso", json);
        }

        public string ObterPorId(Guid id)
        {
            return base.retornar("v1/acesso/" + id.ToString());
        }

        public string ObterPorUsuarioEEmpresa(Guid idUsuario,Guid idEmpresa)
        {
            return base.retornar($"v1/acesso/obteracessoporusuarioeempresa?idUsuario={idUsuario}&idEmpresa={idEmpresa}");
        }


        public string ObterTodos()
        {
            return base.retornar("v1/paciente");
        }
    }
}
