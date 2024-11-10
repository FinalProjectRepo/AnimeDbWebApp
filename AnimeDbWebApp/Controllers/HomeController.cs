using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;
using System.Threading.Tasks;

using AnimeDbWebApp.Services;
using AnimeDbWebApp.ViewModels;
using AnimeDbWebApp.Services.Interfaces;

namespace AnimeDbWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _service;

        public HomeController(IHomeService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _service.GetModel();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
