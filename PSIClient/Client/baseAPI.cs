using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PSIClient.Client
{
    public abstract class baseAPI
    {
        protected HttpClient client;
        protected Uri usuarioUri;
        protected virtual string url
        {
            get
            {
                return API.url();
            }
        }

        protected virtual string ApiController
        {
            get
            {

                return API.controller();
            }
        }


        public baseAPI()
        {
            if (client == null)
            {
                client = new HttpClient() { BaseAddress = new Uri(url) };
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/json"));
               
            }
        }



        protected HttpResponseMessage post(string controler, String json,bool comToken = true)
        {

            string retorno = string.Empty;

            if (comToken)
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Util.Usuario.UsuarioLogado.token);

            StringContent content = new StringContent(json, Encoding.UTF8, "text/json");
            HttpResponseMessage response = client.PostAsync(ApiController + controler, content).Result;
            return response;

            //se retornar com sucesso busca os dados
            //if (response.IsSuccessStatusCode)
            //{
            //    //pegando o cabeçalho
                //usuarioUri = response.Headers.Location;


                //retorno = await response.Content.ReadAsStringAsync();

            //}

            //return retorno;


        }

        protected async Task<string> delete(String controler, object codigo)
        {
            string retorno = string.Empty;
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Util.Usuario.UsuarioLogado.token);
            HttpResponseMessage response = client.DeleteAsync(ApiController + controler + codigo.ToString()).Result;

            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {
                //pegando o cabeçalho
                usuarioUri = response.Headers.Location;


                retorno = await response.Content.ReadAsStringAsync();

            }
            return retorno;

        }

        protected HttpResponseMessage put(String controler, String json)
        {           
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Util.Usuario.UsuarioLogado.token);
            StringContent content = new StringContent(json, Encoding.UTF8, "text/json");
            HttpResponseMessage response = client.PutAsync(ApiController + controler, content).Result;
            return response;
        }


        protected string retornar(string controler)
        {
            string retorno = string.Empty;

            // if (Lutils.PingServer.Ping(url))

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Util.Usuario.UsuarioLogado.token);
            HttpResponseMessage response = client.GetAsync(ApiController + controler).Result;

            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {
                //pegando o cabeçalho
                usuarioUri = response.Headers.Location;

                //Pegando os dados do Rest e armazenando na variável usuários
                retorno = response.Content.ReadAsStringAsync().Result;

            }
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
            //}

            return retorno;
        }


    }
}
