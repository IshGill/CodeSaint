using CodeSaint.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeSaint.Data
{
    public class CodeSaintRepo : ICodeSaintRepo
    {
        private readonly CodeSaintDbContext _dbContext;

        public CodeSaintRepo(CodeSaintDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string TestStock(Stock stock)
        {
            _dbContext.Stocks.Add(stock);
            _dbContext.SaveChanges();
            return "Stock added to DB successfully.";
        }

        public ActionResult<IEnumerable<Stock>> GetTestStock(string ticker)
        {
            return _dbContext.Stocks.Where(x => x.Ticker == ticker).ToList();
        }

    }
}
