using System.Collections.Generic;
using AnimeDbWebApp.ViewModels.ExtraForUser;

namespace AnimeDbWebApp.ViewModels.Generic
{
    public class AddedWithCountViewModel<T> : EnumSelectListViewModel
	{
		public int TotalPages { get; set; }
		public int Page { get; set; }
		public int ItemsPerPage { get; set; }
		public int Status { get; set; }
		public IList<T> Entities { get; set; } = [];
	}
}