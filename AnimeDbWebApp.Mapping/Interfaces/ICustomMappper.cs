namespace AnimeDbWebApp.Mapping.Interfaces
{
    public interface ICustomMappper
    {
        public void Map<T, TT>(T input, TT output)
            where T : class
            where TT : class;
    }
}