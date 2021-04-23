using ApiWeather.Modelo;
using System.Threading.Tasks;

namespace ApiWeather.Data
{
    public interface IRepositorio
    {
        void Adicionar<T>(T entidade) where T : class;
        Task<bool> Salvar();

        Clima BuscarClima(string nomeCidade);
    }
}
