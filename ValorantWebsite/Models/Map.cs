using System.ComponentModel.DataAnnotations.Schema;

namespace ValorantWebsite.Models
{
    public class Map
    {
        public string? MapID { get; set; }
        public string MapName { get; set; } = string.Empty;
        public string MapLocation { get; set; } = string.Empty;
        public string MapImage { get; set; } = string.Empty;
        public string MinimapImage { get; set; } = string.Empty;
    }
}
