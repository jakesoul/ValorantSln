namespace ValorantWebsite.Models
{
    public class EFValorantRepository : IValorantRepository
    {
        private ValorantDbContext context;
        
        public EFValorantRepository(ValorantDbContext ctx) 
        {
            context = ctx;
        }

        public IQueryable<Agent> Agents => context.Agents;
        public IQueryable<Map> Maps => context.Maps;
        public IQueryable<Weapon> Weapons => context.Weapons;
    }
}
