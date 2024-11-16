using AnimeDbWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Controllers
{
    public class AnimeController(IAnimeService service) : Controller
    {
        private readonly IAnimeService _service = service;

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int itemsPerPage = 50, string search = "")
        {
            var userId = User?.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await _service.GetAll(userId, page, itemsPerPage, search);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int animeId)
        {
            var model = await _service.GetAnime(animeId);
            return View(model);
        }
    }
}