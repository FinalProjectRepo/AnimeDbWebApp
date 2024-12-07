using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Newtonsoft.Json;

using System.Linq.Expressions;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.DTOs.Primals;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Models.Enums;
using AnimeDbWebApp.Services;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Added;
using AnimeDbWebApp.Data;
using AnimeDbWebApp.DTOs.Mappings;
using static AnimeDbWebApp.Common.ValidationConstants.EnumsRangeConstants;

namespace AnimeDbWebApp.UnitTests
{
	public class AddedServicesTests
	{
		private Mock<UserManager<AppUser>> GetMockUserManager()
		{
			var userStoreMock = new Mock<IUserStore<AppUser>>();
			return new Mock<UserManager<AppUser>>(
			userStoreMock.Object, null, null, null, null, null, null, null, null);
		}

		private List<AppUserAnime> _userAnime = [];
		private Mock<IRepository> _repo;
		private Mock<UserManager<AppUser>> _manager;

		[SetUp]
		public void Setup()
		{
			_repo = new Mock<IRepository>();
			_manager = GetMockUserManager();
			_userAnime = new();

			string json = File.ReadAllText(@"../../../../AnimeDbWebApp.Data/Datasets/userAnimeMapping.json");
			ICollection<AppUserAnimeImportModel> inputs = JsonConvert.DeserializeObject<AppUserAnimeImportModel[]>(json)!;
			CustomMapper.MapAll(inputs, _userAnime);
		}

		[Test]
		[TestCase(1, 50, 1)]
		[TestCase(-1, 50, 1)]
		[TestCase(1, 20, 1)]
		[TestCase(1, 20, 3)]
		[TestCase(2, 10, 0)]
		public async Task GetAddedTests(int page, int itemsPerPage, int status)
		{
			int pageMock = page <= 0 ? 1 : page;
			int itemsPerPageMock = itemsPerPage;
			if (itemsPerPageMock is not (10 or 20 or 50)) itemsPerPageMock = 50;

			Expression<Func<AppUserAnime, bool>> whereFunc = ua => ua.WatchingStatus == (WatchingStatus)status;
			if (status >= MinRangeWatchingStatus && status <= MaxRangeWatchingStatus)
			{
				Func<AppUserAnime, bool> whereFunc2 = ua => ua.WatchingStatus == (WatchingStatus)status;
				_userAnime = _userAnime.Where(whereFunc2).ToList();
			}
			int totalPagesMock = (_userAnime.Count - 1) / itemsPerPage + 1;
			var tuple = Tuple.Create<int, ICollection<AppUserAnime>>(totalPagesMock, _userAnime.ToArray());
			_repo.Setup(r => r.TakePageAsync<AppUserAnime>(itemsPerPageMock, pageMock,
						whereFunc, nameof(Anime), $"{nameof(Anime)}.Type"))
				 .Returns(Task.FromResult(tuple));

			IAddedService service = new AddedService(_repo.Object, _manager.Object);
			var returnModel = await service.GetAdded<Anime, AddedAnimeViewModel, AppUserAnime>(page, itemsPerPage, status, whereFunc);

			if (pageMock > totalPagesMock) pageMock = totalPagesMock;

			Assert.IsNotNull(returnModel);
			Assert.That(totalPagesMock.Equals(returnModel.TotalPages));
			Assert.That(pageMock.Equals(returnModel.Page));
			Assert.That(itemsPerPageMock.Equals(returnModel.ItemsPerPage));
			Assert.That(status.Equals(returnModel.Status));
			Assert.That(tuple.Item2.Count.Equals(returnModel.Entities.Count));
		}

		[Test]
		[TestCase(1)]
		[TestCase(2)]
		[TestCase(3)]
		[TestCase(4)]
		[TestCase(5)]
		public async Task RemoveMappingTests(int id)
		{
			Guid userId = Guid.Parse("44CC80E4-84E1-437A-B943-90730089868A");
			Expression<Func<AppUserAnime, bool>> Tpredicate = um => um.UserId == userId && um.Id == id;
			Expression<Func<AppUserAnime, bool>> TUserPredicate = um => um.UserId == userId;

			var entity = _userAnime.FirstOrDefault(a => a.Id == id);
			if(entity != null) _userAnime.Remove(entity);

			Func<AppUserAnime, bool> TpredicateMock = um => um.UserId == userId && um.Id == id;
			_repo.Setup(r => r.FirstOrDefaultAsync<AppUserAnime>(Tpredicate))
				 .Returns(Task.FromResult(_userAnime.FirstOrDefault(TpredicateMock)));

			_repo.Setup(r => r.EntitiesCountAsync<AppUserAnime>(TUserPredicate))
				 .Returns(Task.FromResult(_userAnime.Count));

			var user = new AppUser();
			_manager.Setup(m => m.FindByIdAsync(userId.ToString()))
					.Returns(Task.FromResult(user)!);

			_manager.Setup(m => m.IsInRoleAsync(user, "AnimeWeeb"))
					.Returns(Task.FromResult(false));

			IAddedService service = new AddedService(_repo.Object, _manager.Object);
			await service.RemoveMapping<AppUserAnime, Anime>(userId, id, Tpredicate, TUserPredicate);

			if (entity != null) Assert.That(_userAnime.Count.Equals(49));
			else Assert.That(_userAnime.Count.Equals(50));
		}
	}
}