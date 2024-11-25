using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Authorize(Roles=RoleAdmin)]
	[Area("Admin")]
	public class HomeAdminController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
	}
}