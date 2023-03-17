using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeSaint.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Ticker = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    OneYearHistoricalAverage = table.Column<float>(type: "real", nullable: false),
                    FiveYearHistoricalAverage = table.Column<float>(type: "real", nullable: false),
                    TenYearHistoricalAverage = table.Column<float>(type: "real", nullable: false),
                    MarketCap = table.Column<float>(type: "real", nullable: false),
                    PERatio = table.Column<float>(type: "real", nullable: false),
                    EPS = table.Column<float>(type: "real", nullable: false),
                    Debt = table.Column<float>(type: "real", nullable: false),
                    ProfitMarginGrowth = table.Column<float>(type: "real", nullable: false),
                    RevenueGrowth = table.Column<float>(type: "real", nullable: false),
                    NetIncomeGrowth = table.Column<float>(type: "real", nullable: false),
                    FCFGrowth = table.Column<float>(type: "real", nullable: false),
                    ROICGrowth = table.Column<float>(type: "real", nullable: false),
                    HeavyInvestingRate = table.Column<float>(type: "real", nullable: false),
                    TwitterFlag = table.Column<bool>(type: "bit", nullable: false),
                    RedditFlag = table.Column<bool>(type: "bit", nullable: false),
                    EarningsFlag = table.Column<bool>(type: "bit", nullable: false),
                    NewsFlag = table.Column<bool>(type: "bit", nullable: false),
                    InsiderHoldSellRate = table.Column<float>(type: "real", nullable: false),
                    SuperInvestors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DCF = table.Column<float>(type: "real", nullable: false),
                    EbitdaDCF = table.Column<float>(type: "real", nullable: false),
                    PriceToCompetition = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Ticker);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
