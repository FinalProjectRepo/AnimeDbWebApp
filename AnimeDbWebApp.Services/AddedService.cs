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
using AnimeDbWebApp.ViewModels.Generic;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Services
{
	public class AddedService(IRepository repository, UserManager<AppUser> userManager) : IAddedService
	{
		private readonly IRepository _repo = repository;
		private readonly UserManager<AppUser> _userManager = userManager;

		public async Task<AddedWithCountViewModel<TT>> GetAdded<T, TT, TU> (int page, int itemsPerPage,
			int status, Expression<Func<TU, bool>>? whereFunc)
			where T : class where TT : class where TU : class
		{
			if (page <= 0) page = 1;
			if (itemsPerPage is not (10 or 20 or 50)) itemsPerPage = 50;

			ICollection<TU> entities = [];
			int totalPages = 0;
			(totalPages, entities) = await _repo.TakePageAsync<TU>(itemsPerPage, page, 
				whereFunc, typeof(T).Name, $"{typeof(T).Name}.Type");

			var viewModel = new AddedWithCountViewModel<TT>()
			{
				TotalPages = totalPages,
				Page = page > totalPages ? totalPages : page,
				ItemsPerPage = itemsPerPage,
				Status = status,
			};

			CustomMapper.MapAll(entities, viewModel.Entities, "withInner", typeof(T).Name);
			return viewModel;
		}

		public async Task RemoveMapping<T, TT>(Guid userId, int id, Expression<Func<T, bool>> Tpredicate,
			Expression<Func<T, bool>> TUserPredicate) where T : class where TT : class
		{
			var user = await _userManager.FindByIdAsync(userId.ToString());
			if (user == null) return;

			var entity = await _repo.FirstOrDefaultAsync<T>(Tpredicate);
			if (entity == null) return;
			_repo.Remove(entity);

			var prop = typeof(GeneralConstants).GetFields().FirstOrDefault(p => p.Name == $"Role{typeof(TT).Name}Weeb");
			if (prop == null) throw new ArgumentException("Role name is not included in GeneralConstants", nameof(GeneralConstants));
			string role = $"{prop.GetValue(typeof(GeneralConstants))}";
			var count = await _repo.EntitiesCountAsync<T>(TUserPredicate);
			bool result = await _userManager.IsInRoleAsync(user, role);
			if (await _repo.EntitiesCountAsync<T>(TUserPredicate) <= WeebTreshold
				&& (await _userManager.IsInRoleAsync(user, role)))
			{
				await _userManager.RemoveFromRoleAsync(user, role);
			}

			await _repo.SaveChangesAsync();
		}
	}
}