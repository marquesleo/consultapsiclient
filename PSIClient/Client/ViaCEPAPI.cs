using PSIClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSIClient
{
    public class ViaCEPAPI : baseAPI, IDisposable
    {


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        protected override string ApiController
        {
            get
            {
                return "ws";
            }
        }
        protected override string url
        {
            get
            {
                return "http://viacep.com.br";
            }
        }

        public String retornarRegistro(string cep)
        {
            string retorno = retornar("/" + cep.Replace("-", null) + "/json");
            return retorno;

        }

        public String retornarRegistros(string uf, string localidade, string logradouro)
        {
            string retorno = retornar("/" + uf + "/" + localidade + "/" + logradouro + "/json");
            return retorno;

        }
    }
}
