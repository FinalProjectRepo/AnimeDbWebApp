using System.Linq.Expressions;
using System.Threading.Tasks;
using System;

namespace AnimeDbWebApp.Services.Interfaces
{
	public interface IAdminService
    {
		public Task<bool> AddEntity<T, TT>(TT model, Expression<Func<T, bool>> predicate)
			where T : class where TT : class;
		public Task<bool> RemoveEntity<T, TT>(TT model, Expression<Func<T, bool>> predicate)
			where T : class where TT : class;
		public Task<bool> EditEntity<T, TT>(TT model, Expression<Func<T, bool>> predicate)
			where T : class where TT : class;
	}
}