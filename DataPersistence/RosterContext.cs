using Microsoft.EntityFrameworkCore;
using StatTrackerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatTrackerAPI.DataPersistence
{
    public class RosterContext: DbContext
    {

        public RosterContext(DbContextOptions<RosterContext> options): base(options)
        {
            //Database.SetInitializer<RosterContext>(new StatTrackerDbInitializer());
        }

        public DbSet<Roster> Roster { get; set; }
        public DbSet<Player> Players { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    return;
        //    var player = new Player();
        //    player.Id = 1;
        //    player.AtBats = 99;
        //    player.PlateAppearances = 120;
        //    player.Hits = 28;
        //    player.Doubles = 12;
        //    player.Triples = 2;
        //    player.HomeRuns = 9;
        //    player.FirstName = "Jeremy";
        //    player.LastName = "Burchett";
        //    player.RBIs = 23;
        //    player.Runs = 26;
        //    player.StolenBases = 6;
        //    player.StrikeOuts = 17;
        //    player.BattingAverage = .329;
        //    player.OnBasePercentage = .412;
        //    player.OnBasePlusSlugging = .951;
        //    player.SluggingPercentage = .539;
        //    modelBuilder.Entity<Player>().HasData(player);
        //    //context.Players.Add(player);
        //    var roster = new Roster();
        //    roster.Id = 1;
        //    roster.Players = new List<Player>();
        //    roster.Players.Add(player);
        //    modelBuilder.Entity<Roster>().HasMany(r => r.Players).WithOne(p => p.Roster);
        //    //context.Roster.Add(roster);
        //    //base.Seed(context);
        //}
    }
}
