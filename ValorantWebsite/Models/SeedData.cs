using Microsoft.EntityFrameworkCore;

namespace ValorantWebsite.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ValorantDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ValorantDbContext>();

            if (context.Database.GetPendingMigrations().Any()) 
            {
                context.Database.Migrate();
            }

            if (!context.Agents.Any()) 
            {
                context.Agents.AddRange(
                    new Agent
                    {
                        Name = "Brimstone", 
                        Role = "Controller",
                        Q_Ability = "Incendiary",
                        E_Ability = "Sky Smoke",
                        C_Ability = "Stim Beacon",
                        X_Ability = "Orbital Strike",
                        Biography = "Joining from the U.S.A., Brimstone's orbital arsenal ensures his squad always has the advantage. His ability to deliver utility precisely and safely make him the unmatched boots-on-the-ground commander.",
                        AgentImage = "brimstone.png"
                    },
                    new Agent
                    {
                        Name = "Phoenix",
                        Role = "Duelist",
                        Q_Ability = "Curveball",
                        E_Ability = "Hot Hands",
                        C_Ability = "Blaze",
                        X_Ability = "Run It Back",
                        Biography = "Hailing from the U.K., Phoenix's star power shines through in his fighting style, igniting the battlefield with flash and flare. Whether he's got backup or not, he'll rush into a fight on his own terms.",
                        AgentImage = "phoenix.png"
                    },
                    new Agent
                    {
                        Name = "Sage",
                        Role = "Sentinel",
                        Q_Ability = "Slow Orb",
                        E_Ability = "Healing Orb",
                        C_Ability = "Barrier Orb",
                        X_Ability = "Resurrection",
                        Biography = "The stronghold of China, Sage creates safety for herself and her team wherever she goes. Able to revive fallen friends and stave off aggressive pushes, she provides a calm center to a hellish fight.",
                        AgentImage = "sage.png"
                    },
                    new Agent
                    {
                        Name = "Sova",
                        Role = "Initiator",
                        Q_Ability = "Shock Bolt",
                        E_Ability = "Recon Bolt",
                        C_Ability = "Owl Drone",
                        X_Ability = "Hunter's Fury",
                        Biography = "Born from the eternal winter of Russia's tundra, Sova tracks, finds, and eliminates enemies with ruthless efficiency and precision. His custom bow and incredible scouting abilities ensure that even if you run, you cannot hide.",
                        AgentImage = "sova.png"
                    },
                    new Agent
                    {
                        Name = "Viper",
                        Role = "Controller",
                        Q_Ability = "Poison Cloud",
                        E_Ability = "Toxic Screen",
                        C_Ability = "Snake Bite",
                        X_Ability = "Viper's Pit",
                        Biography = "The American Chemist, Viper deploys an array of poisonous chemical devices to control the battlefield and choke the enemy's vision. If the toxins don't kill her prey, her mindgames surely will.",
                        AgentImage = "viper.png"
                    },
                    new Agent
                    {
                        Name = "Cypher",
                        Role = "Sentinel",
                        Q_Ability = "Cyber Cage",
                        E_Ability = "Spycam",
                        C_Ability = "Trapwire",
                        X_Ability = "Neural Theft",
                        Biography = "The Moroccan information broker, Cypher is a one-man surveillance network who keeps tabs on the enemy's every move. No secret is safe. No maneuver goes unseen. Cypher is always watching.",
                        AgentImage = "cypher.png"
                    },
                    new Agent
                    {
                        Name = "Reyna",
                        Role = "Duelist",
                        Q_Ability = "Devour",
                        E_Ability = "Dismiss",
                        C_Ability = "Leer",
                        X_Ability = "Empress",
                        Biography = "Forged in the heart of Mexico, Reyna dominates single combat, popping off with each kill she scores. Her capability is only limited by her raw skill, making her highly dependent on performance.",
                        AgentImage = "reyna.png"
                    },
                    new Agent
                    {
                        Name = "Killjoy",
                        Role = "Sentinel",
                        Q_Ability = "Alarmbot",
                        E_Ability = "Turret",
                        C_Ability = "Nanoswarm",
                        X_Ability = "Lockdown",
                        Biography = "The genius of Germany. Killjoy secures the battlefield with ease using her arsenal of inventions. If the damage from her gear doesn't stop her enemies, her robots' debuff will help make short work of them.",
                        AgentImage = "killjoy.png"
                    },
                    new Agent
                    {
                        Name = "Breach",
                        Role = "Initiator",
                        Q_Ability = "Flashpoint",
                        E_Ability = "Fault Line",
                        C_Ability = "Aftershock",
                        X_Ability = "Rolling Thunder",
                        Biography = "Breach, the bionic Swede, fires powerful, targeted kinetic blasts to aggressively clear a path through enemy ground. The damage and disruption he inflicts ensures no fight is ever fair.",
                        AgentImage = "breach.png"
                    },
                    new Agent
                    {
                        Name = "Omen",
                        Role = "Controller",
                        Q_Ability = "Paranoia",
                        E_Ability = "Dark Cover",
                        C_Ability = "Shrouded Step",
                        X_Ability = "From The Shadows",
                        Biography = "A phantom of a memory, Omen hunts in the shadows. He renders enemies blind, teleports across the field, then lets paranoia take hold as his foe scrambles to learn where he might strike next.",
                        AgentImage = "omen.png"
                    },
                    new Agent
                    {
                        Name = "Jett",
                        Role = "Duelist",
                        Q_Ability = "Updraft",
                        E_Ability = "Tailwind",
                        C_Ability = "Cloudburst",
                        X_Ability = "Blade Storm",
                        Biography = "Representing her home country of South Korea, Jett's agile and evasive fighting style lets her take risks no one else can. She runs circles around every skirmish, cutting enemies before they even know what hit them.",
                        AgentImage = "jett.png"
                    },
                    new Agent
                    {
                        Name = "Raze",
                        Role = "Duelist",
                        Q_Ability = "Blast Pack",
                        E_Ability = "Paint Shells",
                        C_Ability = "Boom Bo",
                        X_Ability = "Showstopper",
                        Biography = "Raze explodes out of Brazil with her big personality and big guns. With her blunt-force-trauma playstyle, she excels at flushing entrenched enemies and clearing tight spaces with a generous dose of \"boom.\"",
                        AgentImage = "raze.png"
                    },
                    new Agent
                    {
                        Name = "Skye",
                        Role = "Initiator",
                        Q_Ability = "Trailblazer",
                        E_Ability = "Guiding Light",
                        C_Ability = "Regrowth",
                        X_Ability = "Seekers",
                        Biography = "Hailing from Australia, Skye and her band of beasts trail-blaze the way through hostile territory. With her creations hampering the enemy, and her power to heal others, the team is strongest and safest by Skye’s side.",
                        AgentImage = "skye.png"
                    },
                    new Agent
                    {
                        Name = "Yoru",
                        Role = "Duelist",
                        Q_Ability = "Blindside",
                        E_Ability = "Gatecrash",
                        C_Ability = "Fakeout",
                        X_Ability = "Dimensional Drift",
                        Biography = "Japanese native, Yoru, rips holes straight through reality to infiltrate enemy lines unseen. Using deception and aggression in equal measure, he gets the drop on each target before they know where to look.",
                        AgentImage = "yoru.png"
                    },
                    new Agent
                    {
                        Name = "Astra",
                        Role = "Controller",
                        Q_Ability = "Nova Pulse",
                        E_Ability = "Nebula",
                        C_Ability = "Gravity Well",
                        X_Ability = "Astral Form / Cosmic Divide",
                        Biography = "Ghanaian Agent Astra harnesses the energies of the cosmos to reshape battlefields to her whim. With full command of her astral form and a talent for deep strategic foresight, she's always eons ahead of her enemy's next move.",
                        AgentImage = "astra.png"
                    },
                    new Agent
                    {
                        Name = "Kay/o",
                        Role = "Initiator",
                        Q_Ability = "Flash/Drive",
                        E_Ability = "Zero/Point",
                        C_Ability = "Frag/Ment",
                        X_Ability = "Null/CMD",
                        Biography = "KAY/O is a machine of war built for a single purpose: neutralizing radiants. His power to Suppress enemy abilities dismantles his opponents' capacity to fight back, securing him and his allies the ultimate edge.",
                        AgentImage = "kayo.png"
                    },
                    new Agent
                    {
                        Name = "Chamber",
                        Role = "Sentinel",
                        Q_Ability = "Headhunter",
                        E_Ability = "Rendezvous",
                        C_Ability = "Trademark",
                        X_Ability = "Tour De Force",
                        Biography = "Well-dressed and well-armed, French weapons designer Chamber expels aggressors with deadly precision. He leverages his custom arsenal to hold the line and pick off enemies from afar, with a contingency built for every plan.",
                        AgentImage = "chamber.png"
                    },
                    new Agent
                    {
                        Name = "Neon",
                        Role = "Duelist",
                        Q_Ability = "Relay Bolt",
                        E_Ability = "High Gear",
                        C_Ability = "Fast Lane",
                        X_Ability = "Overdrive",
                        Biography = "Filipino Agent Neon surges forward at shocking speeds, discharging bursts of bioelectric radiance as fast as her body generates it. She races ahead to catch enemies off guard, then strikes them down quicker than lightning.",
                        AgentImage = "neon.png"
                    },
                    new Agent
                    {
                        Name = "Fade",
                        Role = "Initiator",
                        Q_Ability = "Seize",
                        E_Ability = "Haunt",
                        C_Ability = "Prowler",
                        X_Ability = "Nightfall",
                        Biography = "Turkish bounty hunter, Fade, unleashes the power of raw nightmares to seize enemy secrets. Attuned with terror itself, she hunts targets and reveals their deepest fears—before crushing them in the dark.",
                        AgentImage = "fade.png"
                    },
                    new Agent
                    {
                        Name = "Harbor",
                        Role = "Controller",
                        Q_Ability = "Cove",
                        E_Ability = "High Tide",
                        C_Ability = "Cascade",
                        X_Ability = "Reckoning",
                        Biography = "Hailing from India’s coast, Harbor storms the field wielding ancient technology with dominion over water. He unleashes frothing rapids and crushing waves to shield his allies, or pummel those that oppose him.",
                        AgentImage = "harbor.png"
                    },
                    new Agent
                    {
                        Name = "Gekko",
                        Role = "Initiator",
                        Q_Ability = "Wingman",
                        E_Ability = "Dizzy",
                        C_Ability = "Mosh Pit",
                        X_Ability = "Thrash",
                        Biography = "Gekko the Angeleno leads a tight-knit crew of calamitous creatures. His buddies bound forward, scattering enemies out of the way, with Gekko chasing them down to regroup and go again.",
                        AgentImage = "gekko.png"
                    },
                    new Agent
                    {
                        Name = "Deadlock",
                        Role = "Sentinel",
                        Q_Ability = "Sonic Sensor",
                        E_Ability = "Barrier Mesh",
                        C_Ability = "Gravnet",
                        X_Ability = "Annihilation",
                        Biography = "Norwegian operative Deadlock deploys an array of cutting-edge nanowire to secure the battlefield from even the most lethal assault. No one escapes her vigilant watch, nor survives her unyielding ferocity.",
                        AgentImage = "deadlock.png"
                    },
                    new Agent
                    {
                        Name = "Iso",
                        Role = "Duelist",
                        Q_Ability = "Undercut",
                        E_Ability = "Double Tap",
                        C_Ability = "Contingency",
                        X_Ability = "Kill Contract",
                        Biography = "Chinese fixer for hire, Iso falls into a flow state to dismantle the opposition. Reconfiguring ambient energy into bulletproof protection, he advances with focus towards his next duel to the death.",
                        AgentImage = "iso.png"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
