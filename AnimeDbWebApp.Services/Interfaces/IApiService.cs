using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IApiService
	{
		public Task<ICollection<T>> GetAdded<T, TU>(int status, Expression<Func<TU, bool>> whereFunc, string[] include)
			where T : class where TU : class;
	}
}