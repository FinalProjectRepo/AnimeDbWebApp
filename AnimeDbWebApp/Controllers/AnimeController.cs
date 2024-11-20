using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using System.Threading.Tasks;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Anime;

namespace AnimeDbWebApp.Controllers
{
    public class AnimeController(IGeneralService service) : Controller
    {
        private readonly IGeneralService _service = service;

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int itemsPerPage = 50, string search = "")
        {
            var userId = User?.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await _service.GetAll<Anime, AnimeViewModel, AppUserAnime>(userId, page, itemsPerPage, search);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
		{
			var userId = User?.FindFirstValue(ClaimTypes.NameIdentifier);
			string[] includes =
			{
				"Type","Source", "Genres", "Genres.Genre", "AnimesProducers", "AnimesProducers.Producer",
				"AnimesLicensors", "AnimesLicensors.Licensor", "AnimesStudios", "AnimesStudios.Studio",
				 "AnimesRelations", "AnimesRelations.Relation", "MangaAdaptations", "MangaAdaptations.Manga"
			};
			var model = await _service.GetModel<Anime, AnimeDetailsViewModel, AppUserAnime>(userId, id, includes);
            return View(model);
        }
    }
}