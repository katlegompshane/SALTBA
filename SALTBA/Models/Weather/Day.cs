namespace SALTBA.Models.Weather
{
    public class Day
    {
        public decimal maxtemp_c { get; set; }
        public decimal maxtemp_f { get; set; }
        public decimal mdecimalemp_c { get; set; }
        public decimal mdecimalemp_f { get; set; }
        public decimal avgtemp_c { get; set; }
        public decimal avgtemp_f { get; set; }
        public decimal maxwind_mph { get; set; }
        public decimal maxwind_kph { get; set; }
        public decimal totalprecip_mm { get; set; }
        public decimal totalprecip_in { get; set; }
        public decimal totalsnow_cm { get; set; }
        public decimal avgvis_km { get; set; }
        public decimal avgvis_miles { get; set; }
        public decimal avghumidity { get; set; }
        public decimal daily_will_it_rain { get; set; }
        public decimal daily_chance_of_rain { get; set; }
        public decimal daily_will_it_snow { get; set; }
        public decimal daily_chance_of_snow { get; set; }
        public Condition condition { get; set; }
        public decimal uv { get; set; }
    }
}
