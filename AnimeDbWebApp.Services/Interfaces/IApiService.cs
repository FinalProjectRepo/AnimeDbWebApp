using System.Collections.Generic;
using System.Threading.Tasks;

using AnimeDbWebApp.Models.BaseModels;
using AnimeDbWebApp.ViewModels.Generic;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IApiService
	{
		public Task<ICollection<T>> GetAdded<T, TU>(string userId, int status, string[] include)
			where T : class where TU : UserGeneral;
	}
}