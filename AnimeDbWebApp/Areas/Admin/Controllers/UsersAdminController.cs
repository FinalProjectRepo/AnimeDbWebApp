using AnimeDbWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Authorize(Roles = RoleAdmin)]
	[Area("Admin")]
	public class UsersAdminController(IAdminService service) : Controller
	{
		private readonly IAdminService _service = service;

		[HttpPost]
		public async Task<IActionResult> AddToRole(string userName, string role)
		{
			await _service.AssignRole(userName, role);
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpPost]
		public async Task<IActionResult> RemoveFromRole(string userName, string role)
		{
			await _service.RemoveFromRole(userName, role);
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpPost]
		public async Task<IActionResult> AddRole(string role)
		{
			await _service.AddRole(role);
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpPost]
		public async Task<IActionResult> RemoveRole(string role)
		{
			await _service.RemoveRole(role);
			return RedirectToAction("Index", "HomeAdmin");
		}
	}
}