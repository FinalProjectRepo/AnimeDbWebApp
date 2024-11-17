using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Manga;

namespace AnimeDbWebApp.Services
{
	public class MangaService(IRepository repository) : IMangaService
	{
		private readonly IRepository _repo = repository;

		public async Task<MangaWithCountViewModel> GetAll(string? userId, int page, int itemsPerPage, string search)
		{
			if (page <= 0) page = 1;
			if (itemsPerPage is not 10 or 20 or 50) itemsPerPage = 50;

			Expression<Func<Manga, bool>>? whereFunc = null;
			if (!string.IsNullOrEmpty(search)) whereFunc = a => a.Title.Contains(search);
			Expression<Func<Manga, object>> include = a => a.Type;
			IEnumerable<Manga> mangas = [];
			int totalPages = 0;
			(totalPages, mangas) = await _repo.TakePageAsync<Manga>(itemsPerPage, page, whereFunc, include);

			var dict = new Dictionary<int, int>();
			bool userParse = Guid.TryParse(userId, out Guid userGuid);
			if (userParse)
			{
				var userMangas = await _repo.WhereAsync<AppUserManga>(ua => ua.UserId == userGuid);
				foreach (var entity in userMangas)
				{
					dict[entity.MangaId] = (int)entity.Status;
				}
			}

			var viewModel = new MangaWithCountViewModel()
			{
				TotalPages = totalPages,
				Page = page > totalPages ? totalPages : page,
				ItemsPerPage = itemsPerPage,
				Search = search,
				AddedMangas = dict
			};

			CustomMapper.MapAll(mangas, viewModel.Mangas, true);
			return viewModel;
		}

		public async Task<MangaDetailsViewModel> GetAnime(int mangaId)
		{
			string[] includes =
			{
				"Type", "Genres", "Genres.Genre", "MangasAuthors", "MangasAuthors.Author",
				 "MangaRelations", "MangaRelations.Relation", "Adaptations", "Adaptations.Anime",
				 "MangasMagazines", "MangasMagazines.Magazine"
			};

			Expression<Func<Manga, bool>> firstFunc = a => a.Id == mangaId;
			var manga = await _repo.FirstWithIncludeAsync<Manga>(firstFunc, includes);
			var model = new MangaDetailsViewModel();
			if (manga == null) return model;

			CustomMapper.MapViews(manga, model);
			return model;
		}
	}
}