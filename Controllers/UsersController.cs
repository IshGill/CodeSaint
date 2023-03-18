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
    public class UsersController : Controller
    {
        private readonly CodeSaintDbContext _UserContext;

        public UsersController(CodeSaintDbContext context)
        {
            _UserContext = context;
        }
    }
}


//// GET: Users
//public async Task<IActionResult> Index()
//{
//    return _context.Users != null ?
//                View(await _context.Users.ToListAsync()) :
//                Problem("Entity set 'CodeSaintDbContext.Users'  is null.");
//}

//// GET: Users/Details/5
//public async Task<IActionResult> Details(string id)
//{
//    if (id == null || _context.Users == null)
//    {
//        return NotFound();
//    }

//    var user = await _context.Users
//        .FirstOrDefaultAsync(m => m.UserName == id);
//    if (user == null)
//    {
//        return NotFound();
//    }

//    return View(user);
//}

//// GET: Users/Create
//public IActionResult Create()
//{
//    return View();
//}

//// POST: Users/Create
//// To protect from overposting attacks, enable the specific properties you want to bind to.
//// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> Create([Bind("UserName,Password,Email,Country,Gender,Age")] User user)
//{
//    if (ModelState.IsValid)
//    {
//        _context.Add(user);
//        await _context.SaveChangesAsync();
//        return RedirectToAction(nameof(Index));
//    }
//    return View(user);
//}

//// GET: Users/Edit/5
//public async Task<IActionResult> Edit(string id)
//{
//    if (id == null || _context.Users == null)
//    {
//        return NotFound();
//    }

//    var user = await _context.Users.FindAsync(id);
//    if (user == null)
//    {
//        return NotFound();
//    }
//    return View(user);
//}

//// POST: Users/Edit/5
//// To protect from overposting attacks, enable the specific properties you want to bind to.
//// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> Edit(string id, [Bind("UserName,Password,Email,Country,Gender,Age")] User user)
//{
//    if (id != user.UserName)
//    {
//        return NotFound();
//    }

//    if (ModelState.IsValid)
//    {
//        try
//        {
//            _context.Update(user);
//            await _context.SaveChangesAsync();
//        }
//        catch (DbUpdateConcurrencyException)
//        {
//            if (!UserExists(user.UserName))
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
//    return View(user);
//}

//// GET: Users/Delete/5
//public async Task<IActionResult> Delete(string id)
//{
//    if (id == null || _context.Users == null)
//    {
//        return NotFound();
//    }

//    var user = await _context.Users
//        .FirstOrDefaultAsync(m => m.UserName == id);
//    if (user == null)
//    {
//        return NotFound();
//    }

//    return View(user);
//}

//// POST: Users/Delete/5
//[HttpPost, ActionName("Delete")]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> DeleteConfirmed(string id)
//{
//    if (_context.Users == null)
//    {
//        return Problem("Entity set 'CodeSaintDbContext.Users'  is null.");
//    }
//    var user = await _context.Users.FindAsync(id);
//    if (user != null)
//    {
//        _context.Users.Remove(user);
//    }

//    await _context.SaveChangesAsync();
//    return RedirectToAction(nameof(Index));
//}

//private bool UserExists(string id)
//{
//    return (_context.Users?.Any(e => e.UserName == id)).GetValueOrDefault();
//}