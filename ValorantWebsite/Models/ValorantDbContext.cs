using Microsoft.EntityFrameworkCore;

namespace ValorantWebsite.Models
{
    public class ValorantDbContext : DbContext
    {
        public ValorantDbContext(DbContextOptions<ValorantDbContext> options) : base(options) { }

        public DbSet<Agent> Agents => Set<Agent>();
        /**/
        public DbSet<AgentRole> AgentRoles => Set<AgentRole>();
        public DbSet<Map> Maps => Set<Map>();
        public DbSet<Weapon> Weapons => Set<Weapon>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AgentRole>().HasData(
                new AgentRole { AgentRoleId = "Duel", AgentRoleName = "Duelist" },
                new AgentRole { AgentRoleId = "Init", AgentRoleName = "Initiator" },
                new AgentRole { AgentRoleId = "Cont", AgentRoleName = "Controller" },
                new AgentRole { AgentRoleId = "Sent", AgentRoleName = "Sentinel" }
                );

            modelBuilder.Entity<Map>().HasData(
                new Map
                {
                    MapID = "asce",
                    MapName = "Ascent",
                    MapLocation = "Venice, Italy",
                    MapImage = "Loading_Screen_Ascent.png",
                    MinimapImage = "Ascent_Minimap.png"
                },
                new Map
                {
                    MapID = "bind",
                    MapName = "Bind",
                    MapLocation = "Rabat, Morocco",
                    MapImage = "Loading_Screen_Bind.png",
                    MinimapImage = "Bind_Minimap.png"
                },
                new Map
                {
                    MapID = "bree",
                    MapName = "Breeze",
                    MapLocation = "Bermuda Triangle, Atlantic Ocean",
                    MapImage = "Loading_Screen_Breeze.png",
                    MinimapImage = "Breeze_Minimap.png"
                },
                new Map
                {
                    MapID = "frac",
                    MapName = "Fracture",
                    MapLocation = "Santa Fe County, New Mexico, USA",
                    MapImage = "Loading_Screen_Fracture.png",
                    MinimapImage = "Fracture_Minimap.png"
                },
                new Map
                {
                    MapID = "have",
                    MapName = "Haven",
                    MapLocation = "Thimphu, Bhutan",
                    MapImage = "Loading_Screen_Haven.png",
                    MinimapImage = "Haven_Minimap.png"
                },
                new Map
                {
                    MapID = "iceb",
                    MapName = "Icebox",
                    MapLocation = "Bennett Island, Russia",
                    MapImage = "Loading_Screen_Icebox.png",
                    MinimapImage = "Icebox_Minimap.png"
                },
                new Map
                {
                    MapID = "lotu",
                    MapName = "Lotus",
                    MapLocation = "Western Ghats, India",
                    MapImage = "Loading_Screen_Lotus.png",
                    MinimapImage = "Lotus_Minimap.png"
                },
                new Map
                {
                    MapID = "pear",
                    MapName = "Pearl",
                    MapLocation = "Lisbon, Portugal",
                    MapImage = "Loading_Screen_Pearl.png",
                    MinimapImage = "Pearl_Minimap.png"
                },
                new Map
                {
                    MapID = "spli",
                    MapName = "Split",
                    MapLocation = "Tokyo, Japan",
                    MapImage = "Loading_Screen_Split.png",
                    MinimapImage = "Split_Minimap.png"
                },
                new Map
                {
                    MapID = "suns",
                    MapName = "Sunset",
                    MapLocation = "Los Angeles, California, USA",
                    MapImage = "Loading_Screen_Sunset.png",
                    MinimapImage = "Sunset_Minimap.png"
                }
                );

            modelBuilder.Entity<Weapon>().HasData(
                new Weapon
                {
                    WeaponID = 1,
                    WeaponName = "Classic",
                    WeaponType = "Sidearm",
                    CreditCost = 0,
                    WeaponImage = "Classic.png",
                    FireMode = "Semi-Automatic",
                    FireRatePerSec = 6.75,
                    RunSpeedPerSec = 5.73,
                    ReloadSpeedPerSec = 1.75,
                    MagazineSize = 12,
                    ReserveSize = 36,
                    Damage = 0
                }
                );
        }
        
    }
}
