using AnimeDbWebApp.Mapping.Interfaces;

namespace AnimeDbWebApp.Mapping
{
    public class CustomMapper : ICustomMappper
    {
        public void Map<T, TT>(T input, TT output, Dictionary<string, Dictionary<string, int>>? connectedEntitiesDict) where T : class where TT : class
        {
            var inputProperties = typeof(T).GetProperties();
            var outputProperties = typeof(TT).GetProperties();
            foreach (var inputProperty in inputProperties)
            {
                var outputProperty = outputProperties.FirstOrDefault(t => t.Name == inputProperty.Name);
                if (outputProperty == null || inputProperty.GetValue(input) == null) continue;

                if (inputProperty.PropertyType != outputProperty.PropertyType)
                {
                    string inputValue = $"{inputProperty.GetValue(input)}";
                    bool success = false;
                    if (outputProperty.PropertyType == typeof(DateTime?) || outputProperty.PropertyType == typeof(DateTime))
                    {
                        success = DateTime.TryParse(inputValue, out DateTime outputValue);
                        if (success) outputProperty.SetValue(output, outputValue);
                    }
                    else if (outputProperty.PropertyType == typeof(int?) || outputProperty.PropertyType == typeof(int)
                            || outputProperty.PropertyType.BaseType == typeof(Enum))
                    {
                        var name = "";
                        if (outputProperty.PropertyType.BaseType == typeof(Enum))
                            name = outputProperty.PropertyType.ToString();
                        else name = outputProperty.PropertyType.Name;

                        if (connectedEntitiesDict == null 
                            || !connectedEntitiesDict.TryGetValue(name, out Dictionary<string, int>? innerDict) 
                            || !innerDict.TryGetValue(inputValue, out int value)) 
                            throw new ArgumentException($"Not supported mapping for {outputProperty.Name}");

                        outputProperty.SetValue(output, value);
                    }
                    else outputProperty.SetValue(output, null);
                }
                else outputProperty.SetValue(output, inputProperty.GetValue(input));
            }
        }
    }
}