using CodeSaint.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeSaint.Data
{
    public interface ICodeSaintRepo
    {
        public Task<string> TestStock(Stock stock);
        public Task<IEnumerable<Stock>> GetTestStock(string ticker);
    }
}
