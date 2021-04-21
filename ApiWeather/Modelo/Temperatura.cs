using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeather
{
    public class Temperatura
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public int Minima { get; set; }
        public int Atual { get; set; }
        public int Maxima { get; set; }
    }
}
