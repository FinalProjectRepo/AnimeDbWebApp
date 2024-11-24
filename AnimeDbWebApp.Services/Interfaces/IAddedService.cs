using System.Threading.Tasks;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Models.BaseModels;
using AnimeDbWebApp.ViewModels.Generic;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IAddedService
	{
		public Task<AddedWithCountViewModel<TT>> GetAdded<T, TT, TU>
			(string userId, int page, int itemsPerPage, int status, string mappingProp)
			where T : class where TT : class where TU : UserGeneral;

		public Task AddEntity<T, TT>(string userId, int id, int status) 
			where T : UserGeneral where TT : General;
	}
}