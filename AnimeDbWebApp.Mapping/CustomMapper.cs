using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Mapping
{
	public static class CustomMapper
	{
		public static void MapAll<T, TT>(IEnumerable<T> inputs, IList<TT> outputs, bool view = false, string dateTimeFormat = GeneralDateTimeFormat) 
			where T : class where TT : class
		{
			foreach (var input in inputs)
			{
				TT type = Activator.CreateInstance<TT>();
				if (view) MapViews(input, type, dateTimeFormat);
				else Map(input, type);
				outputs.Add(type);
			}
		}

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

		public static void MapViews<T, TT>(T input, TT output, string dateTimeFormat = GeneralDateTimeFormat) 
			where T : class where TT : class
		{
			var inputProperties = typeof(T).GetProperties();
			var outputProperties = typeof(TT).GetProperties();
			var allEntityTypes = Assembly.GetAssembly(typeof(AnimeStatus))!.GetTypes();
			foreach (var outputProperty in outputProperties)
			{
				var inputProperty = inputProperties.FirstOrDefault(t => t.Name == outputProperty.Name);
				if (inputProperty == null || inputProperty.GetValue(input) == null) continue;

				if (inputProperty.PropertyType != outputProperty.PropertyType)
				{
					string inputAsString = $"{inputProperty.GetValue(input)}";
					if (inputProperty.PropertyType == typeof(DateTime?) || inputProperty.PropertyType == typeof(DateTime))
					{
						bool success = DateTime.TryParse(inputAsString, out DateTime date);
						if(success) outputProperty.SetValue(output, date.ToString(dateTimeFormat));
					}
                    else if (inputProperty.PropertyType.BaseType == typeof(Enum))
                    {
						Regex regex = new("[A-Z][a-z]+");
						var parts = regex.Matches(inputAsString);
						if (parts.Count > 1) inputAsString = string.Join(' ', parts);
						outputProperty.SetValue(output, inputAsString);
					}
					else if (allEntityTypes.Contains(inputProperty.PropertyType))
					{
						var innerValue = inputProperty.GetValue(input);
						if (innerValue == null) continue;
						var innerProperty = innerValue.GetType().GetProperty("Name");
						if (innerProperty == null) continue;
						var value = innerProperty.GetValue(innerValue);
						outputProperty.SetValue(output, value);
					}
					else outputProperty.SetValue(output, null);
				}
				else outputProperty.SetValue(output, inputProperty.GetValue(input));
			}
		}
    }
}