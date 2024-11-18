using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Producer;

namespace AnimeDbWebApp.Controllers
{
	public class ProducerController(IPrimalService service) : Controller
	{
		private readonly IPrimalService _service = service;
		
		[HttpGet]
		public async Task<IActionResult> Index(int page, int itemsPerPage, string search)
		{
			var model = await _service.GetAll<Producer, ProducerViewModel>(page, itemsPerPage, search);
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			string[] includes =
			{
				"AnimesProducers", "AnimesProducers.Anime", "AnimesLicensors", "AnimesLicensors.Anime", 
				"AnimesStudios", "AnimesStudios.Anime"
			};
			var model = await _service.GetModel<Producer, ProducerDetailsViewModel>(id, includes);
			return View(model);
		}
	}
}