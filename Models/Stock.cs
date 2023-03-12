using System.ComponentModel.DataAnnotations;

namespace CodeSaint.Models
{
    public class Stock
    {
        [Key]
        public string? Ticker { get; set; }
        public string? Name { get; set; }
        public float? Price { get; set; }
        public float? OneYearHistoricalAverage { get; set; }
        public float? FiveYearHistoricalAverage { get; set; }
        public float? TenYearHistoricalAverage { get; set; }
        public float? MarketCap { get; set; }
        public float? PERatio { get; set; }
        public float? EPS { get; set; }
        public float? Debt { get; set; }
        public float? ProfitMarginGrowth { get; set; }
        public float? RevenueGrowth { get; set; }
        public float? NetIncomeGrowth { get; set; }
        public float? FCFGrowth { get; set; }
        public float? ROICGrowth { get; set; }
        public float? HeavyInvestingRate { get; set; }
        public bool? TwitterFlag { get; set; }
        public bool? RedditFlag { get; set; }
        public bool? EarningsFlag { get; set; }
        public bool? NewsFlag { get; set; }
        public float? InsiderHoldSellRate { get; set; }
        public List<String>? SuperInvestors { get; set; }
        public float? DCF { get; set; }
        public float? EbitdaDCF { get; set; }
        public float? PriceToCompetition { get; set; }

    }
}
