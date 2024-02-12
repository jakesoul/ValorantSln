using System.Net.Http.Headers;

namespace ValorantWebsite.Models
{
    public interface IValorantRepository
    {
        IQueryable<Agent> Agents { get; }
        IQueryable<Map> Maps { get; }
        IQueryable<Weapon> Weapons { get; }
    }
}
