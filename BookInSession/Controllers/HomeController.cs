using System.Collections.Generic;
using System.Linq;
using BookInSession.Database;
using BookInSession.ExtensionMethods;
using BookInSession.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookInSession.Controllers
{
    public class HomeController : Controller
    {
        List<BookViewModel> _bookModel;
        public HomeController()
        {
            _bookModel = Books.BookList;
        }

        public IActionResult Index(int categoryId = 0)
        {
            HttpContext.Session.SetObject("book", _bookModel);
            return View(HttpContext.Session.GetObject<List<BookViewModel>>("book")
                .Where(b=> b.CategoryId == categoryId || categoryId==0)
                .ToList());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookViewModel bookModel)
        {
            if (ModelState.IsValid)
            {
                _bookModel.Add(bookModel);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}