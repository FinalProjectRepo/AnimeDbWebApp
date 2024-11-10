using System.Threading.Tasks;
using AnimeDbWebApp.ViewModels.Home;

namespace AnimeDbWebApp.Services.Interfaces
{
    public interface IHomeService
    {
        public Task<HomeViewModel> GetModel();
    }
}