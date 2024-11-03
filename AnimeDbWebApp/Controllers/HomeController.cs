using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using AnimeDbWebApp.ViewModels;
using AnimeDbWebApp.Data;
using System.Linq;

namespace AnimeDbWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AnimeDbContext _dbContext;

        public HomeController(AnimeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var authors = _dbContext.Authors.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
