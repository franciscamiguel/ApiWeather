using ApiWeather.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeather.Data
{
    public class Repositorio : IRepositorio
    {
        private readonly DataContext context;

        public Repositorio(DataContext context)
        {
            this.context = context;
        }

        public void Adicionar<T>(T entidade) where T : class => context.Add(entidade);

        public async Task<bool> Salvar() => await context.SaveChangesAsync() > 0;

        public Clima BuscarClima(string nomeCidade)
        {
            var clima = context.Climas
                .FirstOrDefault(
                c => c.Cidade.Contains(nomeCidade) && (DateTime.UtcNow - c.Horario).TotalMinutes >= 20
                );

            return clima;
        }
    }
}
