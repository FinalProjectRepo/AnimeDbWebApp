using Microsoft.AspNetCore.Identity;
using Moq;
using Newtonsoft.Json;

using System.Linq.Expressions;
using System.Linq;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.DTOs.Primals;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.Services;
using AnimeDbWebApp.ViewModels.Added;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;
using AnimeDbWebApp.DTOs.Generals;
using AnimeDbWebApp.DTOs.Mappings;

namespace AnimeDbWebApp.UnitTests
{
	public class ApiServiceTests
	{
		private Mock<UserManager<AppUser>> GetMockUserManager()
		{
			var userStoreMock = new Mock<IUserStore<AppUser>>();
			return new Mock<UserManager<AppUser>>(
			userStoreMock.Object, null, null, null, null, null, null, null, null);
		}

		private ICollection<AppUserAnime> _userAnime = [];
		private ICollection<Anime> _animes = [];
		private Mock<IRepository> _repo;
		private Mock<UserManager<AppUser>> _manager;

		[SetUp]
		public void Setup()
		{
			_repo = new Mock<IRepository>();
			_manager = GetMockUserManager();
			_userAnime = new List<AppUserAnime>();
			_animes = new List<Anime>();

			string json = File.ReadAllText(@"../../../../AnimeDbWebApp.Data/Datasets/userAnimeMapping.json");
			ICollection<AppUserAnimeImportModel> inputs = JsonConvert.DeserializeObject<AppUserAnimeImportModel[]>(json)!;
			CustomMapper.MapAll(inputs, _userAnime);

			string jsonAnimes = File.ReadAllText(@"../../../../AnimeDbWebApp.Data/Datasets/animes.json");
			ICollection<AnimeImportModel> animes = JsonConvert.DeserializeObject<AnimeImportModel[]>(jsonAnimes)!;
			CustomMapper.MapAll(animes, _animes);
		}

		[Test]
		[TestCase(0)]
		[TestCase(1)]
		[TestCase(2)]
		public async Task GetAddedTests(int status)
		{
			Expression<Func<AppUserAnime, bool>> whereFunc = ua => ua.WatchingStatus == (WatchingStatus)status;
			if (status >= MinRangeWatchingStatus && status <= MaxRangeWatchingStatus)
			{
				Func<AppUserAnime, bool> whereFunc2 = ua => ua.WatchingStatus == (WatchingStatus)status;
				_userAnime = _userAnime.Where(whereFunc2).ToList();
			}
			_repo.Setup(r => r.WhereWithIncludeAsync(whereFunc, new string[1]))
				 .Returns(Task.FromResult(_userAnime));

			IApiService service = new ApiService(_repo.Object, _manager.Object);
			var returnModel = await service.GetAdded<AddedAnimeViewModel, AppUserAnime>(status, whereFunc, new string[1]);

			Assert.IsNotNull(returnModel);
			Assert.That(_userAnime.Count.Equals(returnModel.Count));
		}

		[Test]
		[TestCase(1, 1)]
		[TestCase(1, 3)]
		[TestCase(5, 4)]
		[TestCase(7, 1)]
		[TestCase(3, 1)]
		public async Task AddMappingTests(int id, int status)
		{
			Guid userId = Guid.Parse("44CC80E4-84E1-437A-B943-90730089868A");
			Expression<Func<AppUserAnime, bool>> Tpredicate = um => um.UserId == userId && um.Id == id;
			Expression<Func<Anime, bool>> TTpredicate = a => a.Id == id;
			Expression<Func<AppUserAnime, bool>> TUserPredicate = um => um.UserId == userId;

			var mappingExists = _userAnime.Any(a => a.Id == id);
			var animeExists = _animes.Any(a => a.Id == id);

			Func<AppUserAnime, bool> TpredicateMock = um => um.UserId == userId && um.Id == id;
			var entity = _userAnime.FirstOrDefault(TpredicateMock);
			if(entity  == null && animeExists) _userAnime.Add(new AppUserAnime() { Id = id, UserId = userId});

			_repo.Setup(r => r.FirstOrDefaultAsync<AppUserAnime>(Tpredicate))
				 .Returns(Task.FromResult(_userAnime.FirstOrDefault(TpredicateMock)));

			_repo.Setup(r => r.AnyAsync(TTpredicate))
				 .Returns(Task.FromResult(animeExists));

			_repo.Setup(r => r.AddAsync(entity!))
				 .Returns(Task.FromResult(entity));

			var user = new AppUser();
			_manager.Setup(m => m.FindByIdAsync(userId.ToString()))
					.Returns(Task.FromResult(user)!);

			_manager.Setup(m => m.IsInRoleAsync(user, "AnimeWeeb"))
					.Returns(Task.FromResult(true));

			IApiService service = new ApiService(_repo.Object, _manager.Object);
			await service.AddMapping<AppUserAnime, Anime>(userId!, id, status, Tpredicate, TTpredicate, TUserPredicate);

			if (animeExists)
			{
				if(mappingExists)
				{
					Assert.IsNotNull(entity);
					Assert.That(entity.WatchingStatus.Equals((WatchingStatus)status));
				}
				else Assert.That(_userAnime.Count.Equals(51));
			}
			else Assert.That(_userAnime.Count.Equals(50));
		}
	}
}