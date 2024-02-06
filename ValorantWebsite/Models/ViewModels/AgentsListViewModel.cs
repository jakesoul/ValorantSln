namespace ValorantWebsite.Models.ViewModels
{
    public class AgentsListViewModel
    {
        public IEnumerable<Agent> Agents { get; set; } = Enumerable.Empty<Agent>();
        public PagingInfo PagingInfo { get; set; } = new();
        public string? CurrentRole { get; set; }
    }
}
