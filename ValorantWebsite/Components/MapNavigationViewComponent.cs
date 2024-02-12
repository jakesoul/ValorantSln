using Microsoft.AspNetCore.Mvc;
using ValorantWebsite.Models;

namespace ValorantWebsite.Components
{
    public class MapNavigationViewComponent : ViewComponent
    {
        private IValorantRepository repository;

        public MapNavigationViewComponent(IValorantRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedMapName = RouteData?.Values["mapName"];

            return View(repository.Maps
                .Select(x => x.MapName)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
