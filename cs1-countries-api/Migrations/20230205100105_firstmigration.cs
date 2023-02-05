using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cs1_countries_api.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmericaCountries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapitalCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalArea = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false),
                    CityPopulation = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmericaCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsiaCountries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapitalCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalArea = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false),
                    CityPopulation = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsiaCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EuropeCountries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapitalCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalArea = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false),
                    CityPopulation = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EuropeCountries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AmericaCountries",
                columns: new[] { "Id", "CapitalCity", "CityPopulation", "Currency", "Language", "Name", "Population", "TotalArea" },
                values: new object[,]
                {
                    { 1, "new york city", 8467513L, "Dollar", "English", "new york", 19680000L, 141300 },
                    { 2, "Sacramento", 525041L, "Dollar", "English", "california", 39240000L, 423970 },
                    { 3, "Chicago", 2696555L, "Dollar", "English", "illinois", 12580000L, 149998 },
                    { 4, "Austin", 2176000L, "Dollar", "English", "texas", 29530000L, 695662 }
                });

            migrationBuilder.InsertData(
                table: "AsiaCountries",
                columns: new[] { "Id", "CapitalCity", "CityPopulation", "Currency", "Language", "Name", "Population", "TotalArea" },
                values: new object[,]
                {
                    { 1, "Moskow", 12641000L, "Rubel", "Russian", "russia", 143400000L, 17100000 },
                    { 2, "Beijing", 21000000L, "Juan", "Chinise", "china", 1412000000L, 9597000 },
                    { 3, "Delhi", 32941000L, "Rupee", "indian", "india", 1402000000L, 3287000 },
                    { 4, "Soul", 9776000L, "Won", "korean", "Korea", 51740000L, 100210 }
                });

            migrationBuilder.InsertData(
                table: "EuropeCountries",
                columns: new[] { "Id", "CapitalCity", "CityPopulation", "Currency", "Language", "Name", "Population", "TotalArea" },
                values: new object[,]
                {
                    { 1, "Berlin", 3645000L, "Euro", "German", "Germany", 83200000L, 357588 },
                    { 2, "Warsaw", 1700139L, "Zloty", "Polish", "Poland", 37750000L, 312696 },
                    { 3, "Bern", 140000L, "Swiss Frank", "German, French", "Switzerland", 8700000L, 41285 },
                    { 4, "Amsterdam", 821752L, "Euro", "Dutch", "Netherlands", 17530000L, 41543 },
                    { 5, "Viena", 1800000L, "Euro", "German", "Austria", 8900000L, 83871 },
                    { 6, "Brussel", 1222637L, "Euro", "German, Dutch, French", "Belgium", 11056000L, 30688 },
                    { 7, "Prague", 1309000L, "Czech Crown", "Czech", "Czech Republic", 10510000L, 78870 },
                    { 8, "Bratislava", 475577L, "Euro", "Slovak", "Slovakia", 5474000L, 49035 },
                    { 9, "Paris", 2249975L, "Euro", "French", "France", 67750000L, 551695 },
                    { 10, "Rome", 2873000L, "Euro", "Italian", "Italy", 59110000L, 301230 },
                    { 11, "Madrid", 3223000L, "Euro", "Spanish", "Spain", 47420000L, 505990 },
                    { 12, "Budapest", 1756000L, "Forint", "Hungarian", "Hungaria", 9967308L, 93030 },
                    { 13, "Bucharest", 1830000L, "Lei", "Romanian", "Romania", 19120000L, 238400 },
                    { 14, "Kyjev", 3223000L, "Hryvnia", "Ukrainian", "Ukraine", 43790000L, 603700 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmericaCountries");

            migrationBuilder.DropTable(
                name: "AsiaCountries");

            migrationBuilder.DropTable(
                name: "EuropeCountries");
        }
    }
}
