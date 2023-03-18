using CodeSaint.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeSaint.Data
{
    public interface ICodeSaintRepo
    {
        public string TestStock(Stock stock);
        public ActionResult<IEnumerable<Stock>> GetTestStock(string ticker);
    }
}
