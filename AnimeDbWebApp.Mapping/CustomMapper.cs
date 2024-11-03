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
                if (outputType == null || type.GetValue(input) == null) continue;

                if (type.PropertyType != outputType.PropertyType)
                {
                    string inputValue = $"{type.GetValue(input)}";
                    bool success = false;
                    if (outputType.PropertyType == typeof(DateTime?) || outputType.PropertyType == typeof(DateTime))
                    {
                        success = DateTime.TryParse(inputValue, out DateTime outputValue);
                        if (success) outputType.SetValue(output, outputValue);
                    }
                    else if (outputType.PropertyType == typeof(int?) || outputType.PropertyType == typeof(int))
                    {
                        success = int.TryParse(inputValue, out int outputValue);
                        if (success) outputType.SetValue(output, outputValue);
                    }
                    else outputType.SetValue(output, null);
                }
                else outputType.SetValue(output, type.GetValue(input));
            }
        }
    }
}