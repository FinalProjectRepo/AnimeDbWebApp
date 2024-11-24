using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Services.Interfaces;

namespace AnimeDbWebApp.Services
{
	public class AdminService(IRepository repository) : IAdminService
	{
		private readonly IRepository _repo = repository;

		public async Task<bool> AddEntity<T, TT>(TT model, Expression<Func<T, bool>> predicate) 
			where T : class where TT : class
		{
			if (await _repo.AnyAsync(predicate)) return false;
			var entity = Activator.CreateInstance(typeof(T)) as T;
			if (entity == null) return false;
			var inputEntities = typeof(TT).GetProperties();
			var outputEntities = typeof(T).GetProperties();
			CustomMapper.MapViews(model, entity, inputEntities, outputEntities);
			await _repo.AddAsync(entity);
			await _repo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> RemoveEntity<T, TT>(TT model, Expression<Func<T, bool>> predicate)
			where T : class where TT : class
		{
			var entity = _repo.FirstOrDefaultAsync(predicate);
			if (entity == null) return false;
			_repo.Remove(entity);
			await _repo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> EditEntity<T, TT>(TT model, Expression<Func<T, bool>> predicate)
			where T : class where TT : class
		{
			var entity = _repo.FirstOrDefaultAsync(predicate);
			if (entity == null) return false;
			var inputEntities = typeof(TT).GetProperties();
			var outputEntities = typeof(T).GetProperties();
			CustomMapper.MapViews(model, entity, inputEntities, outputEntities);
			await _repo.SaveChangesAsync();
			return true;
		}
	}
}