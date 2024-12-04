using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;

using System.Net.Http;
using System.Threading.Tasks;

using AnimeDbWebApp.AdminViewModels.Anime;
using AnimeDbWebApp.AdminViewModels.Author;
using AnimeDbWebApp.AdminViewModels.Magazine;
using AnimeDbWebApp.AdminViewModels.Manga;
using AnimeDbWebApp.AdminViewModels.Producer;
using AnimeDbWebApp.AdminViewModels.SelectEnum;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Route("[area]/[controller]/")]
	[ApiController]
	[Authorize(Roles=RoleAdmin)]
	[Area("Admin")]
	public class SiteFetchController(IAdminService service) : ControllerBase
	{
		private readonly IAdminService _service = service;

		[HttpPost("[action]")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddAnime([FromBody] AnimeApiImportModel model)
		{
            if (model == null) return BadRequest();
            await _service.AddEntity<Anime, AnimeApiImportModel>(model);
			return Ok();
		}

        [HttpPost("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddManga([FromBody] MangaApiImportModel model)
        {
            if (model == null) return BadRequest();
            await _service.AddEntity<Manga, MangaApiImportModel>(model);
			return Ok();
		}

        [HttpPost("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddAuthor([FromBody] AuthorApiImportModel model)
        {
            if (model == null) return BadRequest();
            await _service.AddEntity<Author, AuthorApiImportModel>(model);
			return Ok();
		}

		[HttpPost("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddProducer([FromBody] ProducerApiImportModel model)
        {
            if (model == null) return BadRequest();
            await _service.AddEntity<Producer, ProducerApiImportModel>(model);
            return Ok();
        }

        [HttpPost("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddMagazine([FromBody] MagazineApiImportModel model)
        {
            if (model == null) return BadRequest();
            await _service.AddEntity<Magazine, MagazineApiImportModel>(model);
			return Ok();
		}

		[HttpGet("[action]")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<string> GetFromMALMagazine([FromQuery] int id)
		{
			if (id <= 0) return BadRequest();
			HttpClient http = new HttpClient();
			var html = http.GetAsync($"https://myanimelist.net/manga/magazine/{id}").Result.Content.ReadAsStringAsync().Result;
			if (string.IsNullOrEmpty(html)) return BadRequest();

			int first = html.IndexOf("<title>") + 8;
			int second = html.IndexOf("</title>");
			string name = html.Substring(first, second - first).Split(" - ")[0];

			first = html.IndexOf("<link rel=\"canonical\" href=", second) + 28;
			second = html.IndexOf("\" />", first);
			string link = html.Substring(first, second - first);

			return JsonConvert.SerializeObject(new MagazineApiImportModel() { Name = name, Url = link });
		}

		[HttpGet("[action]")]
        [ProducesResponseType(typeof(BasicClassForList), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BasicClassForList>> AnimeTypes()
		{
			var type = await _service.GetListEntities<TypeForAnime>();
			return Ok(type);
        }

        [HttpGet("[action]")]
        [ProducesResponseType(typeof(BasicClassForList), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BasicClassForList>> MangaTypes()
        {
            var type = await _service.GetListEntities<TypeForManga>();
            return Ok(type);
        }

        [HttpGet("[action]")]
        [ProducesResponseType(typeof(BasicClassForList), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BasicClassForList>> Sources()
        {
            var source = await _service.GetListEntities<Source>();
            return Ok(source);
        }
    }
}