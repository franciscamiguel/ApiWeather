namespace ApiWeather.Modelo
{
    public class RetornoDaTemperatura
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
        public int Timezone { get; set; }
        public Coord Coord { get; set; }
        public Weather[] Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public int Visibility { get; set; }
    }
}
