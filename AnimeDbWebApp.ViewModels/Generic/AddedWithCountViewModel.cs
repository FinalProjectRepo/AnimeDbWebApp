using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.Generic
{
	public class AddedWithCountViewModel<T>
	{
		public int TotalPages { get; set; }
		public int Page { get; set; }
		public int ItemsPerPage { get; set; }
		public int Status { get; set; }
		public IList<T> Entities { get; set; } = [];
	}
}