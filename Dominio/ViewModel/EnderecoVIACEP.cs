using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ViewModel
{
    public class EnderecoVIACEP
    {
        public string cep { get; set; }
        public string logradouro { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public string Localidade { get; set; }

        public string uf { get; set; }

        public string unidade { get; set; }
        public string ibge { get; set; }

        public string gia { get; set; }
    }
}
