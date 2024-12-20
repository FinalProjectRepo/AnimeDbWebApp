﻿using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using AnimeDbWebApp.AdminViewModels.SelectEnum;
using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;

namespace AnimeDbWebApp.Services
{
	public class AdminService(IRepository repository, UserManager<AppUser> userManager,
		RoleManager<AppRole> roleManager) : IAdminService
	{
		private readonly IRepository _repo = repository;
		private readonly UserManager<AppUser> _userManager = userManager;
		private readonly RoleManager<AppRole> _roleManager = roleManager;

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

        public async Task RemoveEntity<T>(Expression<Func<T, bool>> predicate)
			where T : class
		{
			var entity = await _repo.FirstOrDefaultAsync(predicate);
			if (entity == null) return;
			_repo.Remove(entity);
			await _repo.SaveChangesAsync();
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

		public async Task AddMapping<T>(int firstId, int secondId, Expression<Func<T, bool>> predicate) 
			where T : class
		{
			if(!(await _repo.AnyAsync(predicate)))
			{
				var mapping = Activator.CreateInstance(typeof(T)) as T;
				if (mapping == null) return;
				var props = typeof(T).GetProperties();
				var firstProp = props.FirstOrDefault(p => p.Name == $"{typeof(T).Name[..5]}Id");
				var secondProp = props.FirstOrDefault(p => p.Name == $"{typeof(T).Name[5..]}Id");
				if (firstProp == null || secondProp == null) return;
				firstProp.SetValue(mapping, firstId);
				secondProp.SetValue(mapping, secondId);
				await _repo.AddAsync(mapping);
				await _repo.SaveChangesAsync();
			}
		}

		public async Task RemoveMapping<T>(Expression<Func<T, bool>> predicate) where T : class
		{
			var mapping = await _repo.FirstOrDefaultAsync(predicate);
			if (mapping != null)
			{
				_repo.Remove(mapping);
				await _repo.SaveChangesAsync();
			}
		}

		public async Task AddOrEditRelation<T>(int firstId, int secondId, string relation,
			Expression<Func<T, bool>> predicate) where T : class
		{
			var mapping = await _repo.FirstOrDefaultAsync(predicate);
			var props = typeof(T).GetProperties();
			var relProp = props.FirstOrDefault(p => p.Name == "RelationType");
			if (mapping != null)
			{
				if (relProp == null) return;
				relProp.SetValue(mapping, relation);
			}
			else
			{
				mapping = Activator.CreateInstance(typeof(T)) as T;
				if (mapping == null) return;
				var firstProp = props.FirstOrDefault(p => p.Name == $"{typeof(T).Name[..5]}Id");
				var secondProp = props.FirstOrDefault(p => p.Name == $"{typeof(T).Name[5..]}Id");
				if (firstProp == null || secondProp == null || relProp == null) return;
				firstProp.SetValue(mapping, firstId);
				secondProp.SetValue(mapping, secondId);
				relProp.SetValue(mapping, relation);
				await _repo.AddAsync(mapping);
			}
			await _repo.SaveChangesAsync();
		}

		public async Task AssignRole(string userName, string role)
		{
			if(!(await _roleManager.RoleExistsAsync(role))) throw new ArgumentException($"There is no such role: {role}");
			var user = await _userManager.FindByNameAsync(userName);
			if (user == null) throw new ArgumentException($"User with username {userName} doesn't exist");
			await _userManager.AddToRoleAsync(user, role);
		}

		public async Task RemoveFromRole(string userName, string role)
		{
			if (!(await _roleManager.RoleExistsAsync(role))) throw new ArgumentException($"There is no such role: {role}");
			var user = await _userManager.FindByNameAsync(userName);
			if (user == null) throw new ArgumentException($"User with username {userName} doesn't exist");
			await _userManager.RemoveFromRoleAsync(user, role);
		}

		public async Task AddRole(string role)
		{
			if (!(await _roleManager.RoleExistsAsync(role)))
				await _roleManager.CreateAsync(new AppRole(role));
		}

		public async Task RemoveRole(string role)
		{
			var fullRole = await _roleManager.FindByNameAsync(role);
			if (fullRole == null) return; 
			await _roleManager.DeleteAsync(fullRole);
		}
	}
}