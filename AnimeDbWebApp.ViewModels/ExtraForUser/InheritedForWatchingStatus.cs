using System.Collections.Generic;

namespace AnimeDbWebApp.ViewModels.ExtraForUser
{
    public class InheritedForWatchingStatus : EnumSelectListViewModel
    {
        public Dictionary<int, int> UserAdded { get; set; } = [];
    }
}