﻿using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AnimeDbWebApp.Areas.Admin.Models.SelectEnum
{
	public class SeasonStatusEnumSelect : AnimeStatusEnumSelect
	{
		public List<BasicClassForList> SeasonEnums { get; set; } = new()
		{
			new(){ Id = 1, Name = "spring" },
			new(){ Id = 2, Name = "summer" },
			new(){ Id = 3, Name = "fall" },
			new(){ Id = 4, Name = "winter" }
		};
	}
}