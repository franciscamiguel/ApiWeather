using ApiWeather.Modelo;
using ApiWeather.Servico;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiWeather.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClimaController : ControllerBase
    {
        [HttpGet]
        public RetornoDaTemperatura Get(string cidade)
        {
            var clima = new ClimaServico();
            var temperatura = clima.BuscarTemperatura(cidade);
            return temperatura;
        }

    }
}
