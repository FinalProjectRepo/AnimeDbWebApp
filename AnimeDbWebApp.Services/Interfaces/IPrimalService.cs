using System.Threading.Tasks;
using AnimeDbWebApp.Models.BaseModels;
using AnimeDbWebApp.ViewModels.Generic;
using AnimeDbWebApp.ViewModels.Manga;
using AnimeDbWebApp.ViewModels.Producer;

namespace AnimeDbWebApp.Services.Interfaces
{
    public interface IPrimalService
	{
		public Task<PrimalWithCountViewModel<TT>> GetAll<T, TT>(int page, int itemsPerPage, string search)
			where T : Primal where TT : class;
		public Task<TT> GetModel<T, TT>(int id, string[] includes)
			where T : Primal where TT : class;
	}
}