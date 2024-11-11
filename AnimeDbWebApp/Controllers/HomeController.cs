using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;
using System.Threading.Tasks;

using AnimeDbWebApp.ViewModels;
using AnimeDbWebApp.Services.Interfaces;

namespace AnimeDbWebApp.Controllers
{
    public class HomeController(IHomeService service) : Controller
    {
        private readonly IHomeService _service = service;

		[HttpGet]
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
