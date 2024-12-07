using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.Common;
using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Services
{
	public class ApiService(IRepository repository, UserManager<AppUser> userManager) : IApiService
	{
		private readonly IRepository _repo = repository;
		private readonly UserManager<AppUser> _userManager = userManager;

		public async Task<ICollection<T>> GetAdded<T, TU> (int status, Expression<Func<TU, bool>> whereFunc, string[] include)
			where T : class where TU : class
		{
			ICollection<TU> entities = await _repo.WhereWithIncludeAsync(whereFunc, include);
			var viewModel = new List<T>();
			var mappingProp = typeof(TU).Name.Substring(7);
			CustomMapper.MapAll(entities, viewModel, "withInner", mappingProp);
			return viewModel;
		}

		public async Task AddMapping<T, TT>(Guid userId, int id, int status, Expression<Func<T, bool>> Tpredicate,
			Expression<Func<TT, bool>> TTpredicate, Expression<Func<T, bool>> TUserPredicate)
			where T : class where TT : class
		{
			if (!(await _repo.AnyAsync<TT>(TTpredicate))) return;
			var user = await _userManager.FindByIdAsync(userId.ToString());
			if (user == null) return;

			var entity = await _repo.FirstOrDefaultAsync<T>(Tpredicate);
			int threshold = WeebTreshold;
			if (entity == null)
			{
				threshold -= 1;
				entity = Activator.CreateInstance(typeof(T)) as T;
				if (entity == null) return;
				CustomMapper.MapAppUserMapping(entity, id, userId, status);
				await _repo.AddAsync(entity);
			}
			else CustomMapper.MapAppUserMapping(entity, id, userId, status);

			var prop = typeof(GeneralConstants).GetFields().FirstOrDefault(p => p.Name == $"Role{typeof(TT).Name}Weeb");
			if (prop == null) throw new ArgumentException("Role name is not included in GeneralConstants", nameof(GeneralConstants));
			string role = $"{prop.GetValue(typeof(GeneralConstants))}";
			if (await _repo.EntitiesCountAsync<T>(TUserPredicate) >= threshold
				&& !(await _userManager.IsInRoleAsync(user, role)))
			{
				await _userManager.AddToRoleAsync(user, role);
			}

			await _repo.SaveChangesAsync();
		}
	}
}