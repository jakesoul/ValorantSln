using Microsoft.AspNetCore.Mvc;
using ValorantWebsite.Models;

namespace ValorantWebsite.Components
{
    public class AgentNavigationViewComponent : ViewComponent
    {
        private IValorantRepository repository;

        public AgentNavigationViewComponent(IValorantRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedRole = RouteData?.Values["role"];

            return View(repository.Agents
                .Select(x => x.Role)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
