using AnimeDbWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Controllers
{
    public class AnimeController(IAnimeService service) : Controller
    {
        private readonly IAnimeService _service = service;

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int itemsPerPage = 50, string search = "")
        {
            var model = await _service.GetAll(page, itemsPerPage, search);
            return View(model);
        }
    }
}