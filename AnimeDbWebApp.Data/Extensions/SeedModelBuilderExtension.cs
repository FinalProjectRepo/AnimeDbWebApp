using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using AnimeDbWebApp.Common;
using AnimeDbWebApp.DTOs.Primals;
using AnimeDbWebApp.Mapping;
using AnimeDbWebApp.Models;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Data.Extensions
{
    public static class SeedModelBuilderExtension
    {
        private static readonly string PathDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName, DataFolderName, DatasetFolderName);
        private static readonly CustomMapper _mapper = new();

        public static void Seed(this ModelBuilder builder)
        {
            SeedPrimals(builder, MultipleTypesSeparator);
        }

        private static void SeedPrimals(ModelBuilder builder, string multipleTypeSeparator)
        {
            var importTypes = Assembly.GetAssembly(typeof(AuthorImportModel))!
                            .GetTypes()
                            .Where(t => t.Namespace!.EndsWith(PrimalImportsNamespace));
            var entityTypes = Assembly.GetAssembly(typeof(Author))!.GetTypes();

            var seedMethod = typeof(SeedModelBuilderExtension)
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Static)
                .FirstOrDefault(m => m.IsGenericMethod && m.Name == nameof(Seed))!;

            foreach (var type in importTypes)
            {
                string entityName = type.Name[..^11];
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

        private static void Seed<T, TT>(ModelBuilder builder, string fileName) 
            where T : class 
            where TT : class
        {
            string filePath = Path.Combine(PathDirectory, fileName);
            string json = File.ReadAllText(filePath);
            var inputs = JsonConvert.DeserializeObject<T[]>(json)!;
            List<TT> types = [];
            foreach (var input in inputs)
            {
                TT type = Activator.CreateInstance<TT>();
                _mapper.Map(input, type);
                types.Add(type);
            }
            builder.Entity<TT>().HasData(types);
        }

        private static void InvokeMethod(ModelBuilder builder,Type type, Type entityType, MethodInfo seedMethod)
        {
            var fileNameProperty = typeof(GeneralConstants)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
                        .FirstOrDefault(p => p.Name.StartsWith(entityType.Name));

            var fileName = fileNameProperty!.GetValue(typeof(GeneralConstants));
            var method = seedMethod!.MakeGenericMethod(type, entityType!);
            method.Invoke(typeof(SeedModelBuilderExtension), [builder, fileName]);
        }
    }
}