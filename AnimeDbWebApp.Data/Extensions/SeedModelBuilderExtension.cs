using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using AnimeDbWebApp.Common;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.DTOs.Generals;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Data.Extensions
{
	public static class SeedModelBuilderExtension
    {
        private static readonly string PathDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName, DataFolderName, DatasetFolderName);

        public static ModelBuilder Seed(this ModelBuilder builder)
        {
            Seed(builder, PrimalImportsNamespace, MultipleTypesSeparator);
            Seed(builder, GeneralImportsNamespace, MultipleTypesSeparator);
            Seed(builder, MappingImportsNamespace, MultipleTypesSeparator);

            return builder;

		}

        private static void Seed(ModelBuilder builder,string namespaceToSeed, string multipleTypeSeparator, 
            int extraCharsImportModel = ImportModelLength)
        {
            var importTypes = Assembly.GetAssembly(typeof(AnimeImportModel))!
                            .GetTypes()
                            .Where(t => t.Namespace!.EndsWith(namespaceToSeed));
            var entityTypes = Assembly.GetAssembly(typeof(Anime))!.GetTypes();

            var seedMethod = typeof(SeedModelBuilderExtension)
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Static)
                .FirstOrDefault(m => m.IsGenericMethod && m.Name == nameof(Seed))!;

            foreach (var type in importTypes)
            {
                string entityName = type.Name[..^extraCharsImportModel];
                var entityType = entityTypes.FirstOrDefault(t => t.Name == entityName);

                if (entityType != null) InvokeMethod(builder, type, entityType, seedMethod);
                else
                {
                    foreach (var entity in entityTypes.Where(t => t.Name.StartsWith($"{entityName}{multipleTypeSeparator}")))
                    {
                        InvokeMethod(builder, type, entity, seedMethod);
                    }
                }
            }
        }
        private static void InvokeMethod(ModelBuilder builder,Type type, Type entityType, MethodInfo seedMethod)
        {
            var fileNameProperty = typeof(GeneralConstants)
                        .GetFields(BindingFlags.Public | BindingFlags.Static)
                        .FirstOrDefault(p => p.Name == $"{entityType.Name}DatasetFileName");

            var fileName = fileNameProperty!.GetValue(typeof(GeneralConstants));
            var method = seedMethod!.MakeGenericMethod(type, entityType!);
            method.Invoke(typeof(SeedModelBuilderExtension), [builder, fileName]);
        }
        private static void Seed<T, TT>(ModelBuilder builder, string fileName)
            where T : class
            where TT : class
        {
            string filePath = Path.Combine(PathDirectory, fileName);
            string json = File.ReadAllText(filePath);
            var inputs = JsonConvert.DeserializeObject<T[]>(json)!;
            List<TT> types = [];
            CustomMapper.MapAll(inputs, types);
            builder.Entity<TT>().HasData(types);
        }
    }
}