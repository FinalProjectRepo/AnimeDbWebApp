namespace AnimeDbWebApp.Mapping.Interfaces
{
    public interface ICustomMappper
    {
        public void Map<T, TT>(T input, TT output, Dictionary<string, Dictionary<string, int>>? connectedEntitiesDict)
            where T : class
            where TT : class;
    }
}