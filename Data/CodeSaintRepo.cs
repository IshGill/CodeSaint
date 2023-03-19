using CodeSaint.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeSaint.Data
{
    public class CodeSaintRepo : ICodeSaintRepo
    {
        private readonly CodeSaintDbContext _dbContext;

        public CodeSaintRepo(CodeSaintDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> TestStock(Stock stock)
        {
            _dbContext.Stocks.Add(stock);
            int numAdded = await _dbContext.SaveChangesAsync();
            return (numAdded > 0) ? "Stock added to DB successfully." : "Stock could not be added, please check your inputted stock data";
        }

        public async Task<IEnumerable<Stock>> GetTestStock(string ticker)
        {
            IEnumerable<Stock> s = await _dbContext.Stocks.Where(x => x.Ticker == ticker).ToListAsync();
            return (!s.Any()) ? null : s;
        }

    }
}
