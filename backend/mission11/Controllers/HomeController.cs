using Microsoft.AspNetCore.Mvc;
using mission11.Models;
using System.Diagnostics;

namespace mission11.Controllers
{
    public class HomeController : Controller
    {

        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var bookData = _repo.Books;

            return View(bookData);
        }
    }
}
