using Dominio.Erros;
using Dominio.Erros.Login;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BOPSI
{
    public class UtilErroLogin
    {

        public static string RetornarErroTratado(HttpResponseMessage  httpResponse)
        {
         
           var retorno = string.Empty;
          
            var msg = httpResponse.Content.ReadAsStringAsync().Result;

            if (!string.IsNullOrEmpty(msg) && msg.Contains("errors"))

            {
                var tratamento = (TratamentoDeErrosLogin)JsonConvert.DeserializeObject<TratamentoDeErrosLogin>(msg);
                if (tratamento != null)
                {
                    if (tratamento.errors != null)
                    {
                        if (tratamento.errors.Password.Any())
                        {
                            foreach (var item in tratamento.errors.Password)
                            {
                                retorno += "\n " + item;
                            }
                        }

                        if (tratamento.errors.Username.Any())
                        {
                            foreach (var item in tratamento.errors.Username)
                            {
                                retorno += "\n " + item;
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(tratamento.mensagem))
                    {
                        retorno += "\n " + tratamento.mensagem;
                    }
                }
            }
            else
                retorno = msg;
            return retorno;
        }

    }

    public class UtilErroPsicologo
    {

        public static string RetornarErroTratado(HttpResponseMessage httpResponse)
        {

          
            var retorno = string.Empty;
            var msg = httpResponse.Content.ReadAsStringAsync().Result;


            if (!string.IsNullOrEmpty(msg) && msg.Contains("errors"))
            {
                var tratamento = (TratamentoDeErrosPsicologo)JsonConvert.DeserializeObject<TratamentoDeErrosPsicologo>(msg);
                if (tratamento != null)
                {
                    if (tratamento.errors != null)
                    {
                        if (tratamento.errors.Nome.Any())
                        {
                            foreach (var item in tratamento.errors.Nome)
                            {
                                retorno += "\n " + item;
                            }
                        }

                        if (tratamento.errors.Celular.Any())
                        {
                            foreach (var item in tratamento.errors.Celular)
                            {
                                retorno += "\n " + item;
                            }
                        }

                        if (tratamento.errors.Telefone.Any())
                        {
                            foreach (var item in tratamento.errors.Telefone)
                            {
                                retorno += "\n " + item;
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(tratamento.mensagem))
                    {
                        retorno += "\n " + tratamento.mensagem;
                    }
                }
            }
            else
                retorno = msg;
            return retorno;
        }

    }

    public class UtilErroPaciente
    {

        public static string RetornarErroTratado(HttpResponseMessage httpResponse)
        {
            var retorno = string.Empty;
            var msg = httpResponse.Content.ReadAsStringAsync().Result;
            if (!string.IsNullOrEmpty(msg) && msg.Contains("errors"))
            {
                var tratamento = (TratamentoDeErrosPsicologo)JsonConvert.DeserializeObject<TratamentoDeErrosPsicologo>(msg);
               
                if (tratamento != null)
                {
                    if (tratamento.errors != null)
                    {
                        if (tratamento.errors.Nome.Any())
                        {
                            foreach (var item in tratamento.errors.Nome)
                            {
                                retorno += "\n " + item;
                            }
                        }

                        if (tratamento.errors.Celular.Any())
                        {
                            foreach (var item in tratamento.errors.Celular)
                            {
                                retorno += "\n " + item;
                            }
                        }

                        if (tratamento.errors.Telefone.Any())
                        {
                            foreach (var item in tratamento.errors.Telefone)
                            {
                                retorno += "\n " + item;
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(tratamento.mensagem))
                    {
                        retorno += "\n " + tratamento.mensagem;
                    }

                }
            }
            else
                retorno = msg;
            return retorno;
        }

    }
}

