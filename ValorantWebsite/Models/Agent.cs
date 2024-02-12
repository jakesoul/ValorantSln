using System.ComponentModel.DataAnnotations.Schema;

namespace ValorantWebsite.Models
{
    public class Agent
    {
        public int? AgentID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Role {  get; set; } = string.Empty;
        //see ValorantDbContext.cs file for AgentRole? AgentRole
        //public AgentRole? AgentRole { get; set; }
        public string Q_Ability { get; set; } = string.Empty;
        public string E_Ability { get; set; } = string.Empty;
        public string C_Ability { get; set; } = string.Empty;
        public string X_Ability { get; set; } = string.Empty;
        public string Biography {  get; set; } = string.Empty;
        public string AgentImage { get; set; } = string.Empty;
    }
}
