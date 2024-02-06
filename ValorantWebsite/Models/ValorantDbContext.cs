using Microsoft.EntityFrameworkCore;

namespace ValorantWebsite.Models
{
    public class ValorantDbContext : DbContext
    {
        public ValorantDbContext(DbContextOptions<ValorantDbContext> options) : base(options) { }

        public DbSet<Agent> Agents => Set<Agent>();
    }
}
