using System.Collections.Generic;

namespace AnimeDbWebApp.Areas.Admin.Models.SelectEnum
{
	public class MangaStatusEnumSelect
	{
		public List<BasicClassForList> StatusEnums { get; set; } = new()
		{
			new(){ Id = 1, Name = "Discontinued" },
			new(){ Id = 2, Name = "Finished" },
			new(){ Id = 3, Name = "On Hiatus" },
			new(){ Id = 4, Name = "Publishing" }
		};
	}
}