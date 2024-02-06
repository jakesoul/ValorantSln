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
    }
}
