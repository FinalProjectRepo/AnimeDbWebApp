using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

using AnimeDbWebApp.Models;
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
			var allEntityTypes = Assembly.GetAssembly(typeof(Anime))!.GetTypes();
            var method = typeof(CustomMapper).GetMethod(nameof(MapCollections));
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
                    else if (inputProperty.PropertyType.IsEnum || inputProperty.PropertyType.BaseType == typeof(AnimeStatus?).BaseType)
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
					else if (inputProperty.PropertyType.IsGenericType)
					{
						var methodTType = inputProperty.PropertyType.GetGenericArguments()[0]; 
						var methodTTType = outputProperty.PropertyType.GetGenericArguments()[0]; 
						var map = method!.MakeGenericMethod(methodTType, methodTTType);
						var value = outputProperty.GetValue(output);

                        map.Invoke(typeof(CustomMapper), [inputProperty.GetValue(input), value]);
                        outputProperty.SetValue(output, value);
                    }
					else outputProperty.SetValue(output, null);
				}
				else outputProperty.SetValue(output, inputProperty.GetValue(input));
			}
		}

		public static void MapCollections<T, TT>(ICollection<T> inputCollection, ICollection<TT> outputCollection)
			where T : class where TT : class
		{
			string mappingProp = typeof(T).Name.Substring(5);
			if (typeof(T).Name == "AnimeManga" && typeof(TT).Name.Contains("Manga")) mappingProp = "Anime";
			var inputProps = typeof(T).GetProperties();
            var innerProp = typeof(T).GetProperties().FirstOrDefault(p => p.Name == mappingProp);
			if (innerProp == null) return;
			if (typeof(TT) == typeof(string))
			{
				foreach (var input in inputCollection)
				{
					var innerValue = innerProp.GetValue(input);
					if (innerValue == null) continue;
					var inputProp = innerValue.GetType().GetProperty("Name");
					if (inputProp == null) continue;
					var value = inputProp.GetValue(innerValue);
					outputCollection.Add((value as TT)!);
				}
			}
			else
			{
				var outputProps = typeof(TT).GetProperties();
				foreach (var input in inputCollection)
				{
					var innerValue = innerProp.GetValue(input);
					var output = Activator.CreateInstance(typeof(TT)) as TT;
					foreach (var prop in outputProps)
					{
						var valueProp = inputProps.FirstOrDefault(p => p.Name == prop.Name);
						if (valueProp == null)
						{
							if (innerValue == null) continue;
							var inputProp = innerValue.GetType().GetProperties().FirstOrDefault(p => p.Name == prop.Name);
							if (inputProp == null) continue;
							var value = inputProp.GetValue(innerValue);
							prop.SetValue(output, value);
						}
						else prop.SetValue(output, valueProp.GetValue(input));
					}
					outputCollection.Add(output!);
				}
			}
        }
    }
}