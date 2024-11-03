using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

using System.IO;
using System.Collections.Generic;

using AnimeDbWebApp.DTOs;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Mapping;
using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Data.Extensions
{
    public static class SeedModelBuilderExtension
    {
        private static readonly string PathDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName, DataFolderName, DatasetFolderName);
        private static readonly CustomMapper _mapper = new();

        public static void Seed(this ModelBuilder builder)
        {
            SeedTypes(builder);
        }

        public static void SeedTypes(ModelBuilder builder) 
        {
            string filePath = Path.Combine(PathDirectory, TypeDataSetFileName);
            string json = File.ReadAllText(filePath);
            var inputs = JsonConvert.DeserializeObject<TypeImportModel[]>(json)!;
            List<Type> types = [];
            foreach (var input in inputs)
            {
                Type type = new();
                _mapper.Map(input, type);
                types.Add(type);
            }
            builder.Entity<Type>().HasData(types);
        }
    }
}