using cs1_countries_api.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace cs1_countries_api.Data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<EuropeModel>().HasData(
                new EuropeModel { Id=1, Name="Germany", CapitalCity="Berlin", Currency="Euro", TotalArea= 357588, Language="German",Population=83200000, CityPopulation=3645000 },
                new EuropeModel { Id = 2, Name = "Poland", CapitalCity = "Warsaw", Currency = "Zloty", TotalArea = 312696, Language = "Polish", Population = 37750000, CityPopulation = 1700139 },
                new EuropeModel { Id = 3, Name = "Switzerland", CapitalCity = "Bern", Currency = "Swiss Frank", TotalArea = 41285, Language = "German, French", Population = 8700000, CityPopulation = 140000 },
                new EuropeModel { Id = 4, Name = "Netherlands", CapitalCity = "Amsterdam", Currency = "Euro", TotalArea = 41543, Language = "Dutch", Population = 17530000, CityPopulation = 821752 },
                new EuropeModel { Id = 5, Name = "Austria", CapitalCity = "Viena", Currency = "Euro", TotalArea = 83871, Language = "German", Population = 8900000, CityPopulation = 1800000 },
                new EuropeModel { Id = 6, Name = "Belgium", CapitalCity = "Brussel", Currency = "Euro", TotalArea = 30688, Language = "German, Dutch, French", Population = 11056000, CityPopulation = 1222637 },
                new EuropeModel { Id = 7, Name = "Czech Republic", CapitalCity = "Prague", Currency = "Czech Crown", TotalArea = 78870, Language = "Czech", Population = 10510000, CityPopulation = 1309000 },
                new EuropeModel { Id = 8, Name = "Slovakia", CapitalCity = "Bratislava", Currency = "Euro", TotalArea = 49035, Language = "Slovak", Population = 5474000, CityPopulation = 475577 },
                new EuropeModel { Id = 9, Name = "France", CapitalCity = "Paris", Currency = "Euro", TotalArea = 551695, Language = "French", Population = 67750000, CityPopulation = 2249975 },
                new EuropeModel { Id = 10, Name = "Italy", CapitalCity = "Rome", Currency = "Euro", TotalArea = 301230, Language = "Italian", Population = 59110000, CityPopulation = 2873000 },
                new EuropeModel { Id = 11, Name = "Spain", CapitalCity = "Madrid", Currency = "Euro", TotalArea = 505990, Language = "Spanish", Population = 47420000, CityPopulation = 3223000 },
                new EuropeModel { Id = 12, Name = "Hungaria", CapitalCity = "Budapest", Currency = "Forint", TotalArea = 93030, Language = "Hungarian", Population = 9967308, CityPopulation = 1756000 },
                new EuropeModel { Id = 13, Name = "Romania", CapitalCity = "Bucharest", Currency = "Lei", TotalArea = 238400, Language = "Romanian", Population = 19120000, CityPopulation = 1830000 },
                new EuropeModel { Id = 14, Name = "Ukraine", CapitalCity = "Kyjev", Currency = "Hryvnia", TotalArea = 603700, Language = "Ukrainian", Population = 43790000, CityPopulation = 3223000 }
                );

            // AMERICA 
            modelBuilder.Entity<AmericaModel>().HasData(
                new AmericaModel { Id = 1, Name = "new york", CapitalCity = "new york city", Currency = "Dollar", TotalArea = 141300, Language = "English", Population = 19680000, CityPopulation = 8467513 },
                new AmericaModel { Id = 2, Name = "california", CapitalCity = "Sacramento", Currency = "Dollar", TotalArea = 423970, Language = "English", Population = 39240000, CityPopulation = 525041 },
                new AmericaModel { Id = 3, Name = "illinois", CapitalCity = "Chicago", Currency = "Dollar", TotalArea = 149998, Language = "English", Population = 12580000, CityPopulation = 2696555 },
                new AmericaModel { Id = 4, Name = "texas", CapitalCity = "Austin", Currency = "Dollar", TotalArea = 695662, Language = "English", Population = 29530000, CityPopulation = 2176000 }
                );
            
            // Asia
            modelBuilder.Entity<AsiaModel>().HasData(
                new AsiaModel { Id = 1, Name = "russia", CapitalCity = "Moskow", Currency = "Rubel", TotalArea = 17100000, Language = "Russian", Population = 143400000, CityPopulation = 12641000 },
                new AsiaModel { Id = 2, Name = "china", CapitalCity = "Beijing", Currency = "Juan", TotalArea = 9597000, Language = "Chinise", Population = 1412000000, CityPopulation = 21000000 },
                new AsiaModel { Id = 3, Name = "india", CapitalCity = "Delhi", Currency = "Rupee", TotalArea = 3287000, Language = "indian", Population = 1402000000, CityPopulation = 32941000 },
                new AsiaModel { Id = 4, Name = "Korea", CapitalCity = "Soul", Currency = "Won", TotalArea = 100210, Language = "korean", Population = 51740000, CityPopulation = 9776000 }
                );

        }

        public DbSet<EuropeModel> EuropeCountries { get; set; }

        public DbSet<AmericaModel> AmericaCountries { get; set; }

        public DbSet<AsiaModel> AsiaCountries { get; set; }
    }
}
