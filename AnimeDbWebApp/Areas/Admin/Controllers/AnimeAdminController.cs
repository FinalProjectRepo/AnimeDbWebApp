using AnimeDbWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	public class AnimeAdminController(IAdminService service) : Controller
	{
		private readonly IAdminService _service = service;

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}
	}
}