namespace SALTBA.Models.Countries
{
    public class Country
    {
        public string code { get; set; }
        public List<string> currencyCodes { get; set; }
        public string name { get; set; }
        public string wikiDataId { get; set; }
    }
}
