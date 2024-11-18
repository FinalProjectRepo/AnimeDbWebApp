using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AnimeDbWebApp.Models.BaseModels
{
	public class Primal
	{
		[Key]
		[Comment("Unique identifier that equals mal_id")]
		public int Id { get; set; }
		public string Name { get; set; } = null!;
	}
}