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

        public IActionResult Index(int pageNum)
        {
            int pageSize = 5;

            var bookData = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum -1) * pageSize)
                .Take(pageSize);

            return View(bookData);
        }
    }
}
