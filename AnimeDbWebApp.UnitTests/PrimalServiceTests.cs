using Moq;
using Newtonsoft.Json;

using System.Linq.Expressions;

using AnimeDbWebApp.Data.Repositories.Interfaces;
using AnimeDbWebApp.DTOs.Primals;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Services;
using AnimeDbWebApp.Services.Interfaces;
using AnimeDbWebApp.ViewModels.Author;

namespace AnimeDbWebApp.UnitTests
{
	public class PrimalServiceTests
	{
		private List<Author> _authors = [];
		private Mock<IRepository> _repo;

		[SetUp]
		public void Setup()
		{
			_repo = new Mock<IRepository>();
			_authors = new();

			string json = File.ReadAllText(@"../../../../AnimeDbWebApp.Data/Datasets/authors.json");
			ICollection<AuthorImportModel> inputs = JsonConvert.DeserializeObject<AuthorImportModel[]>(json)!;
			CustomMapper.MapAll(inputs, _authors);
		}

		[Test]
		[TestCase(1, 50, "")]
		[TestCase(1, 50, "Naoki")]
		[TestCase(-1, 50, "")]
		[TestCase(1, 20, "")]
		[TestCase(1, 20, "")]
		[TestCase(2, 10, "")]
		public async Task GetAllTests(int page, int itemsPerPage, string search)
		{
			Expression<Func<Author, bool>>? whereSearch = null;
			if (!string.IsNullOrEmpty(search))
			{
				whereSearch = a => a.Name.Contains(search);
				_authors = _authors.Where(a => a.Name.Contains(search)).ToList();
			}

			int pageMock = page <= 0 ? 1 : page;
			int itemsPerPageMock = itemsPerPage;
			if (itemsPerPageMock is not (10 or 20 or 50)) itemsPerPageMock = 50;

			int totalPagesMock = (_authors.Count - 1) / itemsPerPage + 1;
			var tuple = Tuple.Create<int, ICollection<Author>>(totalPagesMock, _authors);
			_repo.Setup(r => r.TakePageAsync<Author>(itemsPerPageMock, pageMock, whereSearch))
				 .Returns(Task.FromResult(tuple));

			IPrimalService service = new PrimalService(_repo.Object);
			var returnModel = await service.GetAll<Author, AuthorViewModel>(page, itemsPerPage, whereSearch);

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
			Expression<Func<Author, bool>> firstFunc = a => a.Id == id;

			var entity = _authors.FirstOrDefault(a => a.Id == id);
			_authors = _authors.Where(ua => ua.Id == id).ToList();

			_repo.Setup(r => r.FirstWithIncludeAsync<Author>(firstFunc, new string[1]))
				 .Returns(Task.FromResult(entity));

			IPrimalService service = new PrimalService(_repo.Object);
			var model = await service.GetModel<Author, AuthorDetailsViewModel>(id, firstFunc, new string[1]);

			if (entity != null)
			{
				Assert.That(model.Name.Equals(entity.Name));
			}
			else Assert.IsNull(model.Name);
		}
	}
}