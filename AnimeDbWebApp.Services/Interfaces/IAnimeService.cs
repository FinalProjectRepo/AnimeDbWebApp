using AnimeDbWebApp.ViewModels.Anime;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Services.Interfaces
{
    public interface IAnimeService
    {
        public Task<AnimeWithCountViewModel> GetAll(int page, int itemsPerPage, string search);
    }
}