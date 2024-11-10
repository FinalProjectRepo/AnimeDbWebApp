using System;
using System.Linq;
using System.Collections.Generic;

namespace AnimeDbWebApp.Mapping
{
    public static class CustomMapper
    {
        public static void Map<T, TT>(T input, TT output) where T : class where TT : class
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
                    else outputProperty.SetValue(output, null);
                }
                else outputProperty.SetValue(output, inputProperty.GetValue(input));
            }
        }

        public static void MapAll<T, TT>(IEnumerable<T> inputs, IList<TT> outputs) where T : class where TT : class
        {
            foreach (var input in inputs)
            {
                TT type = Activator.CreateInstance<TT>();
                Map(input, type);
                outputs.Add(type);
            }
        }
    }
}