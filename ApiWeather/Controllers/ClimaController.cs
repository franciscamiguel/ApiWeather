using ApiWeather.Data;
using ApiWeather.Modelo;
using ApiWeather.Servico;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiWeather.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClimaController : ControllerBase
    {
        private readonly IRepositorio repositorio;

        public ClimaController(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        /// <summary>
        /// endpoint para pesquisar temperatura
        /// </summary>
        /// <param name="cidade"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(string cidade)
        {
            var climaDoBanco = repositorio.BuscarClima(cidade);

            if (climaDoBanco is null)
            {
                var climaService = new ClimaServico();
                var temperatura = climaService.BuscarTemperatura(cidade);


                var clima = new Clima
                {
                    Atual = 22,//(int)temperatura.Main.Temp,
                    Minimo = 20,//(int)temperatura.Main.Temp_min,
                    Maximo = 28,//(int)temperatura.Main.Temp_max
                    Horario = DateTime.Now,
                    Cidade = cidade
                };

                repositorio.Adicionar(clima);

                if (await repositorio.Salvar())
                    return Ok(clima);
            }

            return Ok(climaDoBanco);
        }

    }
}
