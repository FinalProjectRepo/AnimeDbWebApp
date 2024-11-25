namespace AnimeDbWebApp.AdminViewModels.AddGenre
{
    public class AddGenreViewModel
    {
        public int Id { get; set; }
        public List<BasicClassForGenreList> Genres { get; set; } = [];
    }
}