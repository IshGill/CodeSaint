using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeSaint.Data;
using CodeSaint.Models;

namespace CodeSaint.Controllers
{
    public class StocksController : Controller
    {
        private readonly ICodeSaintRepo _repository;

        public StocksController(ICodeSaintRepo repository)
        {
            _repository = repository;
        }

        [HttpPost("TestStock")]
        public async Task<IActionResult> TestStock(Stock stock)
        {
            string addStock = await _repository.TestStock(stock);
            return (addStock != "") ? Ok(addStock) : BadRequest(addStock);
        }

        [HttpGet("GetTestStock")]
        public async Task<IActionResult> GetTestStock(string ticker)
        {
            IEnumerable<Stock> s = await _repository.GetTestStock(ticker);
            return (s != null) ? Ok(s) : NotFound(s);
        }
    }
}

//// GET: Stocks
//public async Task<IActionResult> Index()
//{
//    return _context.Stocks != null ?
//                View(await _context.Stocks.ToListAsync()) :
//                Problem("Entity set 'CodeSaintDbContext.Stocks'  is null.");
//}

//// GET: Stocks/Details/5
//public async Task<IActionResult> Details(string id)
//{
//    if (id == null || _context.Stocks == null)
//    {
//        return NotFound();
//    }

//    var stock = await _context.Stocks
//        .FirstOrDefaultAsync(m => m.Ticker == id);
//    if (stock == null)
//    {
//        return NotFound();
//    }

//    return View(stock);
//}

//// GET: Stocks/Create
//public IActionResult Create()
//{
//    return View();
//}

//// POST: Stocks/Create
//// To protect from overposting attacks, enable the specific properties you want to bind to.
//// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> Create([Bind("Ticker,Name,Price,OneYearHistoricalAverage,FiveYearHistoricalAverage,TenYearHistoricalAverage,MarketCap,PERatio,EPS,Debt,ProfitMarginGrowth,RevenueGrowth,NetIncomeGrowth,FCFGrowth,ROICGrowth,HeavyInvestingRate,TwitterFlag,RedditFlag,EarningsFlag,NewsFlag,InsiderHoldSellRate,SuperInvestors,DCF,EbitdaDCF,PriceToCompetition,DateAdded")] Stock stock)
//{
//    if (ModelState.IsValid)
//    {
//        _context.Add(stock);
//        await _context.SaveChangesAsync();
//        return RedirectToAction(nameof(Index));
//    }
//    return View(stock);
//}

//// GET: Stocks/Edit/5
//public async Task<IActionResult> Edit(string id)
//{
//    if (id == null || _context.Stocks == null)
//    {
//        return NotFound();
//    }

//    var stock = await _context.Stocks.FindAsync(id);
//    if (stock == null)
//    {
//        return NotFound();
//    }
//    return View(stock);
//}

//// POST: Stocks/Edit/5
//// To protect from overposting attacks, enable the specific properties you want to bind to.
//// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> Edit(string id, [Bind("Ticker,Name,Price,OneYearHistoricalAverage,FiveYearHistoricalAverage,TenYearHistoricalAverage,MarketCap,PERatio,EPS,Debt,ProfitMarginGrowth,RevenueGrowth,NetIncomeGrowth,FCFGrowth,ROICGrowth,HeavyInvestingRate,TwitterFlag,RedditFlag,EarningsFlag,NewsFlag,InsiderHoldSellRate,SuperInvestors,DCF,EbitdaDCF,PriceToCompetition,DateAdded")] Stock stock)
//{
//    if (id != stock.Ticker)
//    {
//        return NotFound();
//    }

//    if (ModelState.IsValid)
//    {
//        try
//        {
//            _context.Update(stock);
//            await _context.SaveChangesAsync();
//        }
//        catch (DbUpdateConcurrencyException)
//        {
//            if (!StockExists(stock.Ticker))
//            {
//                return NotFound();
//            }
//            else
//            {
//                throw;
//            }
//        }
//        return RedirectToAction(nameof(Index));
//    }
//    return View(stock);
//}

//// GET: Stocks/Delete/5
//public async Task<IActionResult> Delete(string id)
//{
//    if (id == null || _context.Stocks == null)
//    {
//        return NotFound();
//    }

//    var stock = await _context.Stocks
//        .FirstOrDefaultAsync(m => m.Ticker == id);
//    if (stock == null)
//    {
//        return NotFound();
//    }

//    return View(stock);
//}

//// POST: Stocks/Delete/5
//[HttpPost, ActionName("Delete")]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> DeleteConfirmed(string id)
//{
//    if (_context.Stocks == null)
//    {
//        return Problem("Entity set 'CodeSaintDbContext.Stocks'  is null.");
//    }
//    var stock = await _context.Stocks.FindAsync(id);
//    if (stock != null)
//    {
//        _context.Stocks.Remove(stock);
//    }

//    await _context.SaveChangesAsync();
//    return RedirectToAction(nameof(Index));
//}

//private bool StockExists(string id)
//{
//    return (_context.Stocks?.Any(e => e.Ticker == id)).GetValueOrDefault();
//}
