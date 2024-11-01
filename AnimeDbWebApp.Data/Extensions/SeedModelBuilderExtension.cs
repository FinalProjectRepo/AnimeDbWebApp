using Microsoft.EntityFrameworkCore;
using System.IO;

using static AnimeDbWebApp.Common.GeneralConstants;

namespace AnimeDbWebApp.Data.Extensions
{
    public static class SeedModelBuilderExtension
    {
        static string PathDirectory = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;

        public static void Seed(this ModelBuilder builder)
        {
            SeedType();
        }

        public static void SeedType() 
        {
            string filePath = Path.Combine(PathDirectory + DatasetFolderName + TypeDataSetFileName);
        }
    }
}