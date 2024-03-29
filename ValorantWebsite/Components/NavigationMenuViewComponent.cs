﻿/*
 * using Microsoft.AspNetCore.Mvc;
using ValorantWebsite.Models;

namespace ValorantWebsite.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IValorantRepository repository;

        public NavigationMenuViewComponent(IValorantRepository repo)
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
/*
 Change page so that it matches the filter for the Index.cshtml file
 */