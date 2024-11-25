using System.Collections.Generic;

namespace AnimeDbWebApp.Areas.Admin.Models.SelectEnum
{
	public class AnimeStatusEnumSelect
	{
		public List<BasicClassForList> StatusEnums { get; set; } = new()
		{
			new(){ Id = 1, Name = "Finished Airing" },
			new(){ Id = 2, Name = "Currently Airing" },
			new(){ Id = 3, Name = "Not Yet Aired" }
		};
	}
}