using Microsoft.AspNetCore.Identity;
using Moq;
using Newtonsoft.Json;

using System.Linq.Expressions;

using AnimeDbWebApp.ViewModels.Anime;
using AnimeDbWebApp.DTOs.Generals;
using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.DTOs.Mappings;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.Services;
using AnimeDbWebApp.ViewModels.Added;

namespace AnimeDbWebApp.UnitTests
{
	public class GeneralServiceTests
	{
		private List<Anime> _animes = [];
		private ICollection<AppUserAnime> _userAnime = [];
		private Mock<IRepository> _repo;

		[SetUp]
		public void Setup()
		{
			_repo = new Mock<IRepository>();
			_animes = new();
			_userAnime = new List<AppUserAnime>();

			string json = File.ReadAllText(@"../../../../AnimeDbWebApp.Data/Datasets/animes.json");
			ICollection<AnimeImportModel> inputs = JsonConvert.DeserializeObject<AnimeImportModel[]>(json)!;
			CustomMapper.MapAll(inputs, _animes);

			json = File.ReadAllText(@"../../../../AnimeDbWebApp.Data/Datasets/userAnimeMapping.json");
			ICollection<AppUserAnimeImportModel> userAnimes = JsonConvert.DeserializeObject<AppUserAnimeImportModel[]>(json)!;
			CustomMapper.MapAll(userAnimes, _userAnime);
		}

		[Test]
		[TestCase(1, 50, "")]
		[TestCase(1, 50, "Naruto")]
		[TestCase(-1, 50, "")]
		[TestCase(1, 20, "")]
		[TestCase(1, 20, "")]
		[TestCase(2, 10, "")]
		public async Task GetAllTests(int page, int itemsPerPage, string search)
		{
			Expression<Func<Anime, bool>>? whereSearch = null;
			if (!string.IsNullOrEmpty(search))
			{
				whereSearch = a => a.Title.Contains(search);
				_animes = _animes.Where(a => a.Title.Contains(search)).ToList();
			}

			int pageMock = page <= 0 ? 1 : page;
			int itemsPerPageMock = itemsPerPage;
			if (itemsPerPageMock is not (10 or 20 or 50)) itemsPerPageMock = 50;

			int totalPagesMock = (_animes.Count - 1) / itemsPerPage + 1;
			var tuple = Tuple.Create<int, ICollection<Anime>>(totalPagesMock, _animes);
			_repo.Setup(r => r.TakePageAsync<Anime>(itemsPerPageMock, pageMock, whereSearch, "Type"))
				 .Returns(Task.FromResult(tuple));

			IGeneralService service = new GeneralService(_repo.Object);
			var returnModel = await service.GetAll<Anime, AnimeViewModel, AppUserAnime>(page, itemsPerPage, whereSearch, null);

			if (pageMock > totalPagesMock) pageMock = totalPagesMock;

			Assert.IsNotNull(returnModel);
			Assert.That(totalPagesMock.Equals(returnModel.TotalPages));
			Assert.That(pageMock.Equals(returnModel.Page));
			Assert.That(itemsPerPageMock.Equals(returnModel.ItemsPerPage));
			Assert.That(tuple.Item2.Count.Equals(returnModel.Entities.Count));
		}

		[Test]
		[TestCase(1)]
		[TestCase(2)]
		[TestCase(3)]
		[TestCase(4)]
		[TestCase(5)]
		public async Task GetModelTests(int id)
		{
			Guid userId = Guid.Parse("44CC80E4-84E1-437A-B943-90730089868A");
			Expression<Func<Anime, bool>> firstFunc = a => a.Id == id;
			Expression<Func<AppUserAnime, bool>> whereUser = ua => ua.UserId == userId && ua.Id == id;

			var entity = _animes.FirstOrDefault(a => a.Id == id);
			_userAnime = _userAnime.Where(ua => ua.Id == id).ToList();

			Func<AppUserAnime, bool> TpredicateMock = um => um.UserId == userId && um.Id == id;
			_repo.Setup(r => r.WhereAsync<AppUserAnime>(whereUser))
				 .Returns(Task.FromResult(_userAnime));

			_repo.Setup(r => r.FirstWithIncludeAsync<Anime>(firstFunc, new string[1]))
				 .Returns(Task.FromResult(entity));

			IGeneralService service = new GeneralService(_repo.Object);
			var model = await service.GetModel<Anime, AnimeDetailsViewModel, AppUserAnime>(id, firstFunc, whereUser, new string[1]);

			if (entity != null)
			{
				Assert.That(model.Title.Equals(entity.Title));
				Assert.That(model.UserAdded.ContainsKey(entity.Id));
			}
			else Assert.IsNull(model.Title);
		}
	}
}