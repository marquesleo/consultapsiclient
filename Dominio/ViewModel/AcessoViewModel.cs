using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dominio.ViewModel
{
    public class AcessoViewModel
    {
        
        public Guid Id { get; set; }
        [JsonPropertyName("empresa_Id")]
        public Guid Empresa_Id { get; set; }
        [JsonPropertyName("usuario_Id")]
        public Guid Usuario_Id { get; set; }
    }
}
