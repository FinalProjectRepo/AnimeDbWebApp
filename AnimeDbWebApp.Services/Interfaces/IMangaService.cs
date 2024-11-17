using AnimeDbWebApp.ViewModels.Manga;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IMangaService
	{
		public Task<MangaWithCountViewModel> GetAll(string? userId, int page, int itemsPerPage, string search);
		public Task<MangaDetailsViewModel> GetAnime(int animeId);
	}
}