using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.AdminViewModels.SelectEnum;
using AnimeDbWebApp.AdminViewModels.AddGenre;

namespace AnimeDbWebApp.Services
{
	public class AdminService(IRepository repository) : IAdminService
	{
		private readonly IRepository _repo = repository;

		public async Task<ICollection<BasicClassForList>> GetListEntities<T>() where T : class
		{
			var entities = await _repo.AllAsync<T>();
			ICollection<BasicClassForList> listModel = new List<BasicClassForList>();
			CustomMapper.MapAll(entities, listModel);
			return listModel;
		}
		public async Task AddEntity<T, TT>(TT model) 
			where T : class where TT : class
		{
			var entity = Activator.CreateInstance(typeof(T)) as T;
			if (entity == null) return;
			var inputEntities = typeof(TT).GetProperties();
			var outputEntities = typeof(T).GetProperties();
			CustomMapper.Map(model, entity, inputEntities, outputEntities);
			await _repo.AddAsync(entity);
			await _repo.SaveChangesAsync();
		}

		public async Task<bool> RemoveEntity<T>(Expression<Func<T, bool>> predicate)
			where T : class
		{
			var entity = await _repo.FirstOrDefaultAsync(predicate);
			if (entity == null) return false;
			_repo.Remove(entity);
			await _repo.SaveChangesAsync();
			return true;
		}

		public async Task<TT?> GetEditEntity<T, TT>(Expression<Func<T, bool>> predicate)
			where T : class where TT : class
		{
			var entity = await _repo.FirstOrDefaultAsync(predicate);
			if (entity == null) return null;
			var model = Activator.CreateInstance(typeof(TT)) as TT;
			var inputProps = typeof(T).GetProperties();
			var outputProps = typeof(TT).GetProperties();
			CustomMapper.Map(entity, model!, inputProps, outputProps);
			return model;
		}

		public async Task EditEntity<T, TT>(TT model, Expression<Func<T, bool>> predicate)
			where T : class where TT : class
		{
			var entity = await _repo.FirstOrDefaultAsync(predicate);
			if (entity == null) return;
			var inputEntities = typeof(TT).GetProperties();
			var outputEntities = typeof(T).GetProperties();
			CustomMapper.Map(model, entity, inputEntities, outputEntities);
			await _repo.SaveChangesAsync();
		}
	}
}