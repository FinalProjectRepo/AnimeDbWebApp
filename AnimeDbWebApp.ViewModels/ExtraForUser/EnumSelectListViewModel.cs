using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.ExtraForUser
{
    public class EnumSelectListViewModel
    {
        public List<EnumSelectList> Enums { get; set; } = new()
        {
            new(){ Id = 1, Name = "Plan To Watch" },
            new(){ Id = 2, Name = "Watching" },
            new(){ Id = 3, Name = "Finished" },
            new(){ Id = 4, Name = "Abandon" }
        };
    }
}