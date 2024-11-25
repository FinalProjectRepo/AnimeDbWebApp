namespace AnimeDbWebApp.AdminViewModels.AddGenre
{
    public class BasicClassForGenreList
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsSelected { get; set; } = false;
    }
}