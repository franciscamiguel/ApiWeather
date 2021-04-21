using ApiWeather.Modelo;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace ApiWeather.Servico
{
    public class ClimaServico
    {
        public RetornoDaTemperatura BuscarTemperatura(string cidade)
        {
            var client = new RestClient($"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid=59f710608d2daba691dae552915f1dff")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<RetornoDaTemperatura>(response.Content);

            return result;

        }
    }
}
