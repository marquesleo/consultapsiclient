using PSIClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PSIClient
{
    public class EmpresaClient : baseAPI
    {

        public HttpResponseMessage Post(string json)
        {
            return base.post("v1/empresa", json);
        }

        public HttpResponseMessage Put(string json)
        {
            return base.put("v1/empresa", json);
        }

        public async Task<string> Delete(Guid id)
        {
            return await base.delete("v1/paciente/", id);
        }

        public string ObterPorId(Guid id)
        {
            return base.retornar("v1/empresa/" + id.ToString());
        }
    
    }
}

