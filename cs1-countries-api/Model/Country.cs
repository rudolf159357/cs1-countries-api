using System.ComponentModel.DataAnnotations;

namespace cs1_countries_api.Model
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string CapitalCity { get; set; } = string.Empty;

        public string Currency { get;  set; } = string.Empty;

        public int TotalArea { get; set; } = 0;

        public string Language { get; set; } = string.Empty;

        public  long Population { get;  set; } = 0;

        public long CityPopulation { get; set; } = 0;

    }
}
