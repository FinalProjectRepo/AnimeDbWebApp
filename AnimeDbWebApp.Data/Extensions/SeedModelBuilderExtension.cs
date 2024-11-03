using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

using System.IO;
using System.Collections.Generic;

using AnimeDbWebApp.DTOs;
using AnimeDbWebApp.Models;
using AnimeDbWebApp.Mapping;
using static AnimeDbWebApp.Common.GeneralConstants;
using System;

namespace AnimeDbWebApp.Data.Extensions
{
    public static class SeedModelBuilderExtension
    {
        private static readonly string PathDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName, DataFolderName, DatasetFolderName);
        private static readonly CustomMapper _mapper = new();

        public static void Seed(this ModelBuilder builder)
        {
            Seed<TypeImportModel, Models.Type>(builder, TypeDataSetFileName);
            Seed<AuthorImportModel, Author>(builder, AuthorDataSetFileName);
            Seed<ProducerImportModel, Producer>(builder, ProducerDataSetFileName);
        }

        public static void Seed<T, TT>(ModelBuilder builder, string fileName) 
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
    }
}