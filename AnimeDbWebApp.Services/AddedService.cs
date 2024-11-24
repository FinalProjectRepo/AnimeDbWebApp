using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Threading.Tasks;
using System.Linq;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models.BaseModels;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Generic;
using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Common;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.Services
{
	public class AddedService(IRepository repository, UserManager<AppUser> userManager) : IAddedService
	{
		private readonly IRepository _repo = repository;
		private readonly UserManager<AppUser> _userManager = userManager;

		public async Task<AddedWithCountViewModel<TT>> GetAdded<T, TT, TU>
			(string userId, int page, int itemsPerPage, int status, string mappingProp)
			where T : class where TT : class where TU : UserGeneral
		{
			if (page <= 0) page = 1;
			if (itemsPerPage is not (10 or 20 or 50)) itemsPerPage = 50;

			bool userParse = Guid.TryParse(userId, out Guid userGuid);
			Expression<Func<TU, bool>>? whereFunc = null;
			if (status < MinRangeWatchingStatus || status > MaxRangeWatchingStatus) whereFunc = a => a.UserId == userGuid;
			else whereFunc = a => (a.UserId == userGuid && a.WatchingStatus == (WatchingStatus)status);

			ICollection<TU> entities = [];
			int totalPages = 0;
			(totalPages, entities) = await _repo.TakePageAsync<TU>(itemsPerPage, page, whereFunc, typeof(T).Name, $"{typeof(T).Name}.Type");

			var viewModel = new AddedWithCountViewModel<TT>()
			{
				TotalPages = totalPages,
				Page = page > totalPages ? totalPages : page,
				ItemsPerPage = itemsPerPage,
				Status = status,
			};

			CustomMapper.MapAll(entities, viewModel.Entities, "withInner", mappingProp);
			return viewModel;
		}

		public async Task AddEntity<T, TT>(string userId, int id, int status)
			where T : UserGeneral where TT : General
		{
			if (status < MinRangeWatchingStatus && status > MaxRangeAnimeStatus) return;
			if (!(await _repo.AnyAsync<TT>(e => e.Id == id))) return;
			bool success = Guid.TryParse(userId, out Guid userGuid);
			if (!success) return;
			var user = await _userManager.FindByIdAsync(userId);
			if (user == null) return;

			var entity = await _repo.FirstOrDefaultAsync<T>(e => e.Id == id && e.UserId == userGuid);
			if (entity == null)
			{
				entity = Activator.CreateInstance(typeof(T)) as T;
				if (entity == null) return;
				entity.Id = id;
				entity.UserId = userGuid;
				entity.WatchingStatus = (WatchingStatus)status;
				await _repo.AddAsync(entity);
			}
			else entity.WatchingStatus = (WatchingStatus)status;

			var prop = typeof(GeneralConstants).GetProperties().FirstOrDefault(p => p.Name == $"{typeof(TT).Name}Weeb");
			string role = $"{prop.GetValue(typeof(GeneralConstants))}";
			if (role == null) return;
			if (await _repo.EntitiesCountAsync<T>(a => a.UserId == userGuid) >= 50 
				&& !(await _userManager.IsInRoleAsync(user, role)))
			{
				await _userManager.AddToRoleAsync(user, role);
			}

			await _repo.SaveChangesAsync();
		}
	}
}