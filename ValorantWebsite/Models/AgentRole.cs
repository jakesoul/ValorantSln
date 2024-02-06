using System.ComponentModel.DataAnnotations.Schema;

namespace ValorantWebsite.Models
{
    public class AgentRole : Agent
    {
        public string Duelist { get; set; } = string.Empty;
        public string Initator { get; set; } = string.Empty;
        public string Controller { get; set; } = string.Empty;
        public string Sentinel { get; set; } = string.Empty;

    }
}
