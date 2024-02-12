﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ValorantWebsite.Models;

#nullable disable

namespace ValorantWebsite.Migrations
{
    [DbContext(typeof(ValorantDbContext))]
    [Migration("20240211004947_Maps")]
    partial class Maps
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ValorantWebsite.Models.Agent", b =>
                {
                    b.Property<int?>("AgentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("AgentID"));

                    b.Property<string>("AgentImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Ability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E_Ability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q_Ability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("X_Ability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgentID");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("ValorantWebsite.Models.AgentRole", b =>
                {
                    b.Property<string>("AgentRoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AgentRoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgentRoleId");

                    b.ToTable("AgentRoles");

                    b.HasData(
                        new
                        {
                            AgentRoleId = "Duel",
                            AgentRoleName = "Duelist"
                        },
                        new
                        {
                            AgentRoleId = "Init",
                            AgentRoleName = "Initiator"
                        },
                        new
                        {
                            AgentRoleId = "Cont",
                            AgentRoleName = "Controller"
                        },
                        new
                        {
                            AgentRoleId = "Sent",
                            AgentRoleName = "Sentinel"
                        });
                });

            modelBuilder.Entity("ValorantWebsite.Models.Map", b =>
                {
                    b.Property<string>("MapID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MapImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinimapImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MapID");

                    b.ToTable("Maps");

                    b.HasData(
                        new
                        {
                            MapID = "asce",
                            MapImage = "Loading_Screen_Ascent.png",
                            MapLocation = "Venice, Italy",
                            MapName = "Ascent",
                            MinimapImage = "Ascent_Minimap.png"
                        },
                        new
                        {
                            MapID = "bind",
                            MapImage = "Loading_Screen_Bind.png",
                            MapLocation = "Rabat, Morocco",
                            MapName = "Bind",
                            MinimapImage = "Bind_Minimap.png"
                        },
                        new
                        {
                            MapID = "bree",
                            MapImage = "Loading_Screen_Breeze.png",
                            MapLocation = "Bermuda Triangle, Atlantic Ocean",
                            MapName = "Breeze",
                            MinimapImage = "Breeze_Minimap.png"
                        },
                        new
                        {
                            MapID = "frac",
                            MapImage = "Loading_Screen_Fracture.png",
                            MapLocation = "Santa Fe County, New Mexico, USA",
                            MapName = "Fracture",
                            MinimapImage = "Fracture_Minimap.png"
                        },
                        new
                        {
                            MapID = "have",
                            MapImage = "Loading_Screen_Haven.png",
                            MapLocation = "Thimphu, Bhutan",
                            MapName = "Haven",
                            MinimapImage = "Haven_Minimap.png"
                        },
                        new
                        {
                            MapID = "iceb",
                            MapImage = "Loading_Screen_Icebox.png",
                            MapLocation = "Bennett Island, Russia",
                            MapName = "Icebox",
                            MinimapImage = "Icebox_Minimap.png"
                        },
                        new
                        {
                            MapID = "lotu",
                            MapImage = "Loading_Screen_Lotus.png",
                            MapLocation = "Western Ghats, India",
                            MapName = "Lotus",
                            MinimapImage = "Lotus_Minimap.png"
                        },
                        new
                        {
                            MapID = "pear",
                            MapImage = "Loading_Screen_Pearl.png",
                            MapLocation = "Lisbon, Portugal",
                            MapName = "Pearl",
                            MinimapImage = "Pearl_Minimap.png"
                        },
                        new
                        {
                            MapID = "spli",
                            MapImage = "Loading_Screen_Split.png",
                            MapLocation = "Tokyo, Japan",
                            MapName = "Split",
                            MinimapImage = "Split_Minimap.png"
                        },
                        new
                        {
                            MapID = "suns",
                            MapImage = "Loading_Screen_Sunset.png",
                            MapLocation = "Los Angeles, California, USA",
                            MapName = "Sunset",
                            MinimapImage = "Sunset_Minimap.png"
                        });
                });

            modelBuilder.Entity("ValorantWebsite.Models.Weapon", b =>
                {
                    b.Property<int>("WeaponID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeaponID"));

                    b.Property<int?>("CreditCost")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("FireMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("FireRatePerSec")
                        .HasColumnType("float");

                    b.Property<int?>("MagazineSize")
                        .HasColumnType("int");

                    b.Property<double?>("ReloadSpeedPerSec")
                        .HasColumnType("float");

                    b.Property<int?>("ReserveSize")
                        .HasColumnType("int");

                    b.Property<double>("RunSpeedPerSec")
                        .HasColumnType("float");

                    b.Property<string>("WeaponImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeaponName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeaponType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeaponID");

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            WeaponID = 1,
                            CreditCost = 0,
                            Damage = 0,
                            FireMode = "Semi-Automatic",
                            FireRatePerSec = 6.75,
                            MagazineSize = 12,
                            ReloadSpeedPerSec = 1.75,
                            ReserveSize = 36,
                            RunSpeedPerSec = 5.7300000000000004,
                            WeaponImage = "Classic.png",
                            WeaponName = "Classic",
                            WeaponType = "Sidearm"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
