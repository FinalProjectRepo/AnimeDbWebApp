using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Home;

namespace AnimeDbWebApp.Services
{
    public class HomeService : IHomeService
    {
        private readonly IRepository _repo;

        public HomeService(IRepository repository)
        {
            _repo = repository;
        }

        public async Task<HomeViewModel> GetModel()
        {
            var viewModel = new HomeViewModel();

            var animes = await _repo.WhereAsync<Anime>(a => a.Status == AnimeStatus.NotYetAired);
            var mangas = await _repo.WhereAsync<Manga>(a => a.StartDate > DateTime.Parse("2023/1/1"));

            CustomMapper.MapAll(animes, viewModel.Animes);
            CustomMapper.MapAll(mangas, viewModel.Mangas);
            return viewModel;
        }
    }
}