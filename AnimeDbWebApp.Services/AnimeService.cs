using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Anime;

namespace AnimeDbWebApp.Services
{
    public class AnimeService(IRepository repository) : IAnimeService
    {
        private readonly IRepository _repo = repository;

        public async Task<AnimeWithCountViewModel> GetAll(string? userId, int page, int itemsPerPage, string search)
        {
            if (page <= 0) page = 1;
            if (itemsPerPage is not 10 or 20 or 50) itemsPerPage = 50;

			Expression<Func<Anime, bool>>? whereFunc = null;
			if (!string.IsNullOrEmpty(search)) whereFunc = a => a.Title.Contains(search);
			Expression<Func<Anime, object>> include = a => a.Type;
            IEnumerable<Anime> animes = [];
            int totalPages = 0;
			(totalPages, animes) = await _repo.TakePageAsync<Anime>(itemsPerPage, page, whereFunc, include);

            var dict = new Dictionary<int, int>();
            bool userParse = Guid.TryParse(userId, out Guid userGuid);
            if (userParse)
            {
                var userAnimes = await _repo.WhereAsync<AppUserAnime>(ua => ua.UserId == userGuid);
                foreach(var entity in userAnimes)
                {
                    dict[entity.AnimeId] = (int)entity.Status;
                }
            }

            var viewModel = new AnimeWithCountViewModel()
            {
                TotalPages = totalPages,
                Page = page > totalPages ? totalPages : page,
                ItemsPerPage = itemsPerPage,
                Search = search,
                AddedAnimes = dict
            };

            CustomMapper.MapAll(animes, viewModel.Animes, true);
            return viewModel;
        }

        public async Task<AnimeDetailsViewModel> GetAnime(int animeId)
		{
            Expression<Func<Anime, object>>[] includes =
            {
                a => a.Type,
                a => a.Source,
                a => a.Genres,
                a => a.AnimesProducers,
                a => a.AnimesLicensors,
                a => a.AnimesStudios,
                a => a.AnimesLicensors,
                a => a.AnimesRelations,
                a => a.Adaptations,
            };
			
			Expression<Func<Anime, bool>> firstFunc = a => a.Id == animeId;
			var anime = await _repo.FirstWithIncludeAsync<Anime>(firstFunc, includes);
            var model = new AnimeDetailsViewModel();
            if (anime == null) return model;

            CustomMapper.MapViews(anime, model);
            return model;
        }
    }
}