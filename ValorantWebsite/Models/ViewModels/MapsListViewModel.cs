namespace ValorantWebsite.Models.ViewModels
{
    public class MapsListViewModel
    {
        public IEnumerable<Map> Maps { get; set; } = Enumerable.Empty<Map>();
        public PagingInfo PagingInfo { get; set; } = new();
        public string? CurrentMapName { get; set; }
    }
}
