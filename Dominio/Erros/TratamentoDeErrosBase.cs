using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Erros
{
    public abstract class TratamentoDeErrosBase
    {
        public string mensagem { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string traceId { get; set; }
     
    }
}
