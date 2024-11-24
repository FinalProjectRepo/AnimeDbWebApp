using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

using AnimeDbWebApp.Models;
using AnimeDbWebApp.Models.Enums;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Mapping
{
	public static class CustomMapper
	{
		private static MethodInfo Method = typeof(CustomMapper).GetMethod(nameof(MapAll))!;
		private static Type[] AllEntityTypes = Assembly.GetAssembly(typeof(Anime))!.GetTypes();

        public static void MapAll<T, TT>(ICollection<T> inputs, ICollection<TT> outputs, string mappingType = "entity",
			string? mappingProp = null, string dateTimeFormat = GeneralDateTimeFormat) 
			where T : class where TT : class
        {
            var inputProperties = typeof(T).GetProperties();
			var outputProperties = typeof(TT).GetProperties();
			if(mappingProp == null)
			{
                int mappingLength = GeneralModelLength;
                if (typeof(T).Name.Contains(nameof(AppUser))) mappingLength = nameof(AppUser).Length;

                mappingProp = typeof(T).Name.Substring(mappingLength);
                if (typeof(TT).Name.Contains("General") && !typeof(TT).Name.StartsWith(mappingProp))
                    mappingProp = typeof(T).Name.Substring(0, mappingLength);
            }

            if (mappingType == "entity")
			{
				foreach (var input in inputs)
				{
					TT output = Activator.CreateInstance<TT>() as TT;
					Map(input, output, inputProperties, outputProperties);
					outputs.Add(output);
				}
			}
			else if (mappingType == "view")
			{
				foreach (var input in inputs)
				{
					TT output = Activator.CreateInstance<TT>() as TT;
					MapViews(input, output, inputProperties, outputProperties, dateTimeFormat);
					outputs.Add(output);
				}
			}
			else if (mappingType == "withInner")
			{
				var innerProp = typeof(T).GetProperties().FirstOrDefault(p => p.Name == mappingProp);
				if (innerProp == null) return;
				if(typeof(TT) == typeof(string))
				{
                    foreach (var input in inputs)
                    {
                        var value = MapInnerString<T>(input, innerProp);
						if(value != null) outputs.Add((value as TT)!);
                    }
                }
				else
				{
					foreach (var input in inputs)
                    {
                        TT output = Activator.CreateInstance<TT>() as TT;
                        MapInner(input, output, inputProperties, outputProperties, innerProp);
                        outputs.Add(output);
                    }
                }
			}
		}

		public static void Map<T, TT>(T input, TT output, PropertyInfo[] inputProperties,
			PropertyInfo[] outputProperties) where T : class where TT : class
        {
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
					else if(outputProperty.PropertyType == typeof(Guid))
					{
						success = Guid.TryParse(inputValue, out Guid outputValue);
						if (success) outputProperty.SetValue(output, outputValue);
					}
                    else outputProperty.SetValue(output, null);
                }
                else outputProperty.SetValue(output, inputProperty.GetValue(input));
            }
        }

		public static void MapViews<T, TT>(T input, TT output, PropertyInfo[] inputProperties,
			PropertyInfo[] outputProperties, string dateTimeFormat = GeneralDateTimeFormat) 
			where T : class where TT : class
		{
            foreach (var outputProperty in outputProperties)
			{
				var inputProperty = inputProperties.FirstOrDefault(t => t.Name == outputProperty.Name);
				if (inputProperty == null || inputProperty.GetValue(input) == null) continue;

				if (inputProperty.PropertyType != outputProperty.PropertyType)
					MapDifferentPropType(input, output, inputProperty, outputProperty);
				else outputProperty.SetValue(output, inputProperty.GetValue(input));
			}
		}

		public static void MapInner<T, TT>(T input, TT output, PropertyInfo[] inputProperties,
			PropertyInfo[] outputProperties, PropertyInfo innerProp)
			where T : class where TT : class
		{
			var innerValue = innerProp.GetValue(input);
			foreach (var outputProp in outputProperties)
			{
				var valueProp = inputProperties.FirstOrDefault(p => p.Name == outputProp.Name);
				if (valueProp == null)
				{
					if (innerValue == null) continue;
					var inputProp = innerValue.GetType().GetProperties().FirstOrDefault(p => p.Name == outputProp.Name);
					if (inputProp == null) continue;
                    if (inputProp.PropertyType != outputProp.PropertyType)
                        MapDifferentPropType(innerValue, output, inputProp, outputProp);
                    else outputProp.SetValue(output, inputProp.GetValue(innerValue));
				}
				else outputProp.SetValue(output, valueProp.GetValue(input));
			}
        }

		private static object? MapInnerString<T>(T input, PropertyInfo innerProp) 
			where T : class
		{
			var innerValue = innerProp.GetValue(input);
			if (innerValue == null) return null;
			var inputProp = innerValue.GetType().GetProperty("Name");
			if (inputProp == null) return null;
			return inputProp.GetValue(innerValue);
        }

		private static void MapDifferentPropType<T, TT>(T input, TT output, PropertyInfo inputProperty, 
			PropertyInfo outputProperty, string dateTimeFormat = GeneralDateTimeFormat) 
			where T : class where TT : class
        {
            string inputAsString = $"{inputProperty.GetValue(input)}";
            if (inputProperty.PropertyType == typeof(DateTime?) || inputProperty.PropertyType == typeof(DateTime))
            {
                bool success = DateTime.TryParse(inputAsString, out DateTime date);
                if (success) outputProperty.SetValue(output, date.ToString(dateTimeFormat));
            }
            else if (inputProperty.PropertyType.IsEnum || inputProperty.PropertyType.BaseType == typeof(AnimeStatus?).BaseType)
            {
                Regex regex = new("[A-Z][a-z]+");
                var parts = regex.Matches(inputAsString);
                if (parts.Count > 1) inputAsString = string.Join(' ', parts);
                outputProperty.SetValue(output, inputAsString);
            }
            else if (AllEntityTypes.Contains(inputProperty.PropertyType))
            {
                var value = MapInnerString<T>(input, inputProperty);
                if (value == null) return;
                outputProperty.SetValue(output, value);
            }
            else if (inputProperty.PropertyType.IsGenericType)
            {
                var methodTType = inputProperty.PropertyType.GetGenericArguments()[0];
                var methodTTType = outputProperty.PropertyType.GetGenericArguments()[0];
                var map = Method.MakeGenericMethod(methodTType, methodTTType);
                var value = outputProperty.GetValue(output);

                map.Invoke(typeof(CustomMapper), [inputProperty.GetValue(input), value,
                            "withInner", null, GeneralDateTimeFormat]);
                outputProperty.SetValue(output, value);
            }
            else outputProperty.SetValue(output, null);
        }

		public static void MapAppUserMapping<T>(T input, int id, Guid userId, int status)
		{
			var props = typeof(T).GetProperties();
			var propId = props.FirstOrDefault(p => p.Name == "Id");
			var propUserId = props.FirstOrDefault(p => p.Name == "UserId");
			var propStatus = props.FirstOrDefault(p => p.Name == "WatchingStatus");
			if(propId != null &&propUserId != null && propStatus != null)
			{
				propId.SetValue(input, id);
				propUserId.SetValue(input, userId);
				propStatus.SetValue(input, (WatchingStatus)status);
			}
		}
    }
}