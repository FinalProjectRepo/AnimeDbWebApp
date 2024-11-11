using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Anime;
using Azure;

namespace AnimeDbWebApp.Services
{
    public class AnimeService(IRepository repository) : IAnimeService
    {
        private readonly IRepository _repo = repository;

        public async Task<AnimeWithCountViewModel> GetAll(int page, int itemsPerPage, string search)
        {
            if (page <= 0) page = 1;
            if (itemsPerPage is not 10 or 20 or 50) itemsPerPage = 50;

			Expression<Func<Anime, bool>>? whereFunc = null;
			if (!string.IsNullOrEmpty(search)) whereFunc = a => a.Title.Contains(search);
			Expression<Func<Anime, object>> include = a => a.Type;
            IEnumerable<Anime> animes = [];
            int totalPages = 0;
			(totalPages, animes) = await _repo.TakePageAsync<Anime>(itemsPerPage, page, whereFunc, include);

            var viewModel = new AnimeWithCountViewModel()
            {
				TotalPages = totalPages,
                Page = page > totalPages ? totalPages : page,
                ItemsPerPage = itemsPerPage,
                Search = search
            };

            CustomMapper.MapAll(animes, viewModel.Animes, true);
            return viewModel;
        }
    }
}