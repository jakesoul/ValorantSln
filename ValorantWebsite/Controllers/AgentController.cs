using Microsoft.AspNetCore.Mvc;
using ValorantWebsite.Models;
using ValorantWebsite.Models.ViewModels;

namespace ValorantWebsite.Controllers
{
    public class AgentController : Controller
    {
        private IValorantRepository repository;

        public int PageSize = 4;

        public AgentController(IValorantRepository repo)
        {
            repository = repo;
        }

        public ViewResult AgentList(string? role, int agentPage = 1)
        => View(new AgentsListViewModel
        {
            Agents = repository.Agents
                .Where(a => role == null || a.Role == role)
                .OrderBy(a => a.AgentID)
                .Skip((agentPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = agentPage,
                ItemsPerPage = PageSize,
                TotalItems = role == null
                ? repository.Agents.Count()
                : repository.Agents.Where(e => e.Role == role).Count()
            },
            CurrentRole = role
        });
    }
}
