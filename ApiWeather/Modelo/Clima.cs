using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeather.Modelo
{
    public class Clima
    {
        public int Id {get; set;}
        public int Maximo { get; set; }
        public int Minimo { get; set; }
        public int Atual { get; set; }
        public DateTime Horario { get; set; }
        public string Cidade { get; set; }
    }
}
