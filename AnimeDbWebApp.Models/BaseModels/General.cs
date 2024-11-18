using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.Models.BaseModels
{
	public class General
	{
		[Key]
		[Comment("Unique identifier that equals mal_id")]
		public int Id { get; set; }
		public string Title { get; set; } = null!;
	}
}