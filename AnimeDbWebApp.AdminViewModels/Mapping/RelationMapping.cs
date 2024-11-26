namespace AnimeDbWebApp.AdminViewModels.Mapping
{
	public class RelationMapping
	{
		public int First { get; set; }
		public int FirstId { get; set; }
		public int SecondId { get; set; }
		public string Relation { get; set; } = null!;
	}
}