using AnimeDbWebApp.Models.BaseModels;
using AnimeDbWebApp.ViewModels.Generic;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Services.Interfaces
{
    public interface IGeneralService
	{
		public Task<GeneralWithCountViewModel<TT>> GetAll<T, TT, TU>(string? userId, int page, int itemsPerPage, string search)
			where T : General where TT : class where TU : UserGeneral;
		public Task<TT> GetModel<T, TT, TU>(string? userId, int id, string[] includes) 
			where T : General where TT : GeneralDetailsViewModel where TU : UserGeneral;
	}
}