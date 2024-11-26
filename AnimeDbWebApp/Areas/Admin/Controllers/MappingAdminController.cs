using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.Models;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Areas.Admin.Controllers
{
	[Authorize(Roles = RoleAdmin)]
	[Area("Admin")]
	public class MappingAdminController(IAdminService service) : Controller
	{
		private readonly IAdminService _service = service;

		[HttpPost]
		public async Task<IActionResult> Add(int first, int second, int firstId, int secondId)
		{
			if (first == 1)
			{
				switch (second)
				{
					case 2: await _service.AddMapping<AnimeManga>(firstId, secondId,
						am => am.AnimeId == firstId && am.MangaId == secondId); break;
					case 3: await _service.AddMapping<AnimeGenre>(firstId, secondId,
						ag => ag.AnimeId == firstId && ag.GenreId == secondId); break;
					case 4: await _service.AddMapping<AnimeProducer>(firstId, secondId,
						ap => ap.AnimeId == firstId && ap.ProducerId == secondId); break;
					case 5: await _service.AddMapping<AnimeStudio>(firstId, secondId,
						ast => ast.AnimeId == firstId && ast.StudioId == secondId); break;
					case 6: await _service.AddMapping<AnimeLicensor>(firstId, secondId,
						al => al.AnimeId == firstId && al.LicensorId == secondId); break;
				}
			}
			else if (first == 2)
			{
				switch (second)
				{
					case 1:
					await _service.AddMapping<AnimeManga>(secondId, firstId,
							am => am.MangaId == firstId && am.AnimeId == secondId); break;
					case 3:
						await _service.AddMapping<MangaGenre>(firstId, secondId,
						mg => mg.MangaId == firstId && mg.GenreId == secondId); break;
					case 7:
						await _service.AddMapping<MangaAuthor>(firstId, secondId,
						ma => ma.MangaId == firstId && ma.AuthorId == secondId); break;
					case 8:
						await _service.AddMapping<MangaMagazine>(firstId, secondId,
						mm => mm.MangaId == firstId && mm.MagazineId == secondId); break;
				}
			}
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpPost]
		public async Task<IActionResult> Remove(int first, int second, int firstId, int secondId)
		{
			if (first == 1)
			{
				switch (second)
				{
					case 2:
						await _service.RemoveMapping<AnimeManga>(
							am => am.AnimeId == firstId && am.MangaId == secondId); break;
					case 3:
						await _service.RemoveMapping<AnimeGenre>(
							ag => ag.AnimeId == firstId && ag.GenreId == secondId); break;
					case 4:
						await _service.RemoveMapping<AnimeProducer>(
							ap => ap.AnimeId == firstId && ap.ProducerId == secondId); break;
					case 5:
						await _service.RemoveMapping<AnimeStudio>(
						ast => ast.AnimeId == firstId && ast.StudioId == secondId); break;
					case 6:
						await _service.RemoveMapping<AnimeLicensor>(
						al => al.AnimeId == firstId && al.LicensorId == secondId); break;
				}
			}
			else if (first == 2)
			{
				switch (second)
				{
					case 1:
						await _service.RemoveMapping<AnimeManga>(
								am => am.MangaId == firstId && am.AnimeId == secondId); break;
					case 3:
						await _service.RemoveMapping<MangaGenre>(
						mg => mg.MangaId == firstId && mg.GenreId == secondId); break;
					case 7:
						await _service.RemoveMapping<MangaAuthor>(
						ma => ma.MangaId == firstId && ma.AuthorId == secondId); break;
					case 8:
						await _service.RemoveMapping<MangaMagazine>(
						mm => mm.MangaId == firstId && mm.MagazineId == secondId); break;
				}
			}
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpPost]
		public async Task<IActionResult> AddOrEditRelation(int first, string relation, int firstId, int secondId)
		{
			if (first == 1) await _service.AddOrEditRelation<AnimeRelation>(firstId, secondId, relation,
				ar => ar.AnimeId == firstId && ar.RelationId == secondId);
			else await _service.AddOrEditRelation<MangaRelation>(firstId, secondId, relation,
				mr => mr.MangaId == firstId && mr.RelationId == secondId);
			return RedirectToAction("Index", "HomeAdmin");
		}

		[HttpPost]
		public async Task<IActionResult> RemoveRelation(int first, int firstId, int secondId)
		{
			if (first == 1) await _service.RemoveEntity<AnimeRelation>(
				ar => ar.AnimeId == firstId && ar.RelationId == secondId);
			else await _service.RemoveEntity<MangaRelation>(
				mr => mr.MangaId == firstId && mr.RelationId == secondId);
			return RedirectToAction("Index", "HomeAdmin");
		}


	}
}