using Dominio.ViewModel;
using PSIClient;
using System.Collections.Generic;

namespace BOPSI
{
    public class ViaCEP
    {
        private ViaCEPAPI _viaCEPAPI;
        private ViaCEPAPI viaCEPAPI
        {
            get
            {
                if (_viaCEPAPI == null)
                    _viaCEPAPI = new ViaCEPAPI();
                return _viaCEPAPI;
            }
        }

        public EnderecoVIACEP retornarRegistro(string cep)
        {
            try
            {
                if (string.IsNullOrEmpty(cep))
                    throw new System.Exception("Cep não informado!");

                if (!string.IsNullOrEmpty(cep) && cep.Equals("_____-___"))
                    throw new System.Exception("Cep não informado!");

                var endereco = new EnderecoVIACEP();
                string json = viaCEPAPI.retornarRegistro(cep);
                endereco = Newtonsoft.Json.JsonConvert.DeserializeObject<EnderecoVIACEP>(json);
                return endereco;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
          
        }

        public List<EnderecoVIACEP> retornarRegistro(string uf, string localidade, string logradouro)
        {
            var lstEndereco = new List<EnderecoVIACEP>();
            string json = viaCEPAPI.retornarRegistros(uf, localidade, logradouro);
            lstEndereco = Newtonsoft.Json.JsonConvert.DeserializeObject<List<EnderecoVIACEP>>(json);
            return lstEndereco;
        }

    }
}

