using Microsoft.AspNetCore.Mvc;
using ValorantWebsite.Models;
using ValorantWebsite.Models.ViewModels;

namespace ValorantWebsite.Controllers
{
    public class MapController : Controller
    {
        private IValorantRepository repository;

        public int PageSize = 3;

        public MapController(IValorantRepository repo)
        {
            repository = repo;
        }

        public ViewResult MapList(string? mapName, int mapPage = 1)
        => View(new MapsListViewModel
        {
            Maps = repository.Maps
                .Where(m => mapName == null || m.MapName == mapName)
                .OrderBy(m => m.MapID)
                .Skip((mapPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = mapPage,
                ItemsPerPage = PageSize,
                TotalItems = mapName == null
                ? repository.Maps.Count()
                : repository.Maps.Where(e => e.MapName == mapName).Count()
            },
            CurrentMapName = mapName
        });
    }
}
