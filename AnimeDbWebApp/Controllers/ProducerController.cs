﻿using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;
using System.Linq.Expressions;
using System;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Producer;

namespace AnimeDbWebApp.Controllers
{
	public class ProducerController(IPrimalService service) : Controller
	{
		private readonly IPrimalService _service = service;
		
		[HttpGet]
		public async Task<IActionResult> Index(int page, int itemsPerPage, string search)
		{
			Expression<Func<Producer, bool>>? searchFunc = null;
			if (!string.IsNullOrEmpty(search)) searchFunc = a => a.Name.Contains(search);
			var model = await _service.GetAll<Producer, ProducerViewModel>(page, itemsPerPage, searchFunc);
			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			Expression<Func<Producer, bool>> firstFunc = a => a.Id == id;
			string[] includes =
			{
				"AnimesProducers", "AnimesProducers.Anime", "AnimesLicensors", "AnimesLicensors.Anime", 
				"AnimesStudios", "AnimesStudios.Anime"
			};
			var model = await _service.GetModel<Producer, ProducerDetailsViewModel>(id, firstFunc, includes);
			return View(model);
		}
	}
}