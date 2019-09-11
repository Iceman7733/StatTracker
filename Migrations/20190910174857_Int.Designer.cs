﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StatTrackerAPI.DataPersistence;

namespace StatTrackerAPI.Migrations
{
    [DbContext(typeof(RosterContext))]
    [Migration("20190910174857_Int")]
    partial class Int
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StatTrackerAPI.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtBats");

                    b.Property<double>("BattingAverage");

                    b.Property<int>("Doubles");

                    b.Property<string>("FirstName");

                    b.Property<int>("Hits");

                    b.Property<int>("HomeRuns");

                    b.Property<string>("LastName");

                    b.Property<double>("OnBasePercentage");

                    b.Property<double>("OnBasePlusSlugging");

                    b.Property<int>("PlateAppearances");

                    b.Property<int>("RBIs");

                    b.Property<int>("RosterId");

                    b.Property<int>("Runs");

                    b.Property<double>("SluggingPercentage");

                    b.Property<int>("StolenBases");

                    b.Property<int>("StrikeOuts");

                    b.Property<int>("Triples");

                    b.HasKey("Id");

                    b.HasIndex("RosterId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("StatTrackerAPI.Models.Roster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Roster");
                });

            modelBuilder.Entity("StatTrackerAPI.Models.Player", b =>
                {
                    b.HasOne("StatTrackerAPI.Models.Roster", "Roster")
                        .WithMany("Players")
                        .HasForeignKey("RosterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
