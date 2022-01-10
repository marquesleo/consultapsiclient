using PSIClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PSIClient
{
    public class ConsultaClient: baseAPI
    {
        public HttpResponseMessage Post(string json)
        {
            return base.post("v1/consulta", json);
        }

        public HttpResponseMessage Put(string json)
        {
            return base.put("v1/consulta", json);
        }

        public async Task<string> Delete(Guid id)
        {
            return await base.delete("v1/consulta/", id);
        }

        public string ObterPorId(Guid id)
        {
            return base.retornar("v1/consulta/" + id.ToString());
        }

        public string IsJaExisteMarcado(Guid empresa_id,DateTime dataHora)
        {
            return base.retornar($"v1/consulta/validar?empresa_id={empresa_id}&diaHora={dataHora}");
        }

        public string ConsultarAgendamento(Guid empresa_id, DateTime diaInicial,
                                           DateTime diaFinal, Guid paciente_id,
                                           Guid psicologo_id)
        {
            return base.retornar($"v1/consulta/ConsultarAgenda?empresa_id={empresa_id}&diaInicial={diaInicial}&diaFinal={diaFinal}&paciente_id={paciente_id}&psicologo={psicologo_id}");
        }
        public string ConsultarAgendaNaoRealizada(Guid empresa_id, string dia,
                                           string paciente, string psicologo)
        {
            return base.retornar($"v1/consulta/ConsultarAgendaNaoRealizada?empresa_id={empresa_id}&dia={dia}&paciente={paciente}&psicologo={psicologo}");
        }



        public string ObterTodos()
        {
            return base.retornar("v1/consulta");
        }
    }
}
