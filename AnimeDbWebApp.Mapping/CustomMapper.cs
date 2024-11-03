using AnimeDbWebApp.Mapping.Interfaces;

namespace AnimeDbWebApp.Mapping
{
    public class CustomMapper : ICustomMappper
    {
        public void Map<T, TT>(T input, TT output) where T : class where TT : class
        {
            var inputTypes = typeof(T).GetProperties();
            var outputTypes = typeof(TT).GetProperties();
            foreach (var type in inputTypes)
            {
                var outputType = outputTypes.FirstOrDefault(t => t.Name == type.Name);
                if (outputType != null) outputType.SetValue(output, type.GetValue(input));
            }
        }
    }
}