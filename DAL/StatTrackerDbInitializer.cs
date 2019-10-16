using System.Collections.Generic;
using StatTrackerAPI.Models;

namespace StatTrackerAPI.DAL
{
    public class StatTrackerDbInitializer //: CreateDatabaseIfNotExists<RosterContext>
    {
        //protected override void Seed(RosterContext context)
        public void Seed(RosterContext context)
        {
            var player = new Player();
            player.AtBats = 99;
            player.PlateAppearances = 120;
            player.Hits = 28;
            player.Doubles = 12;
            player.Triples = 2;
            player.HomeRuns = 9;
            player.FirstName = "Jeremy";
            player.LastName = "Burchett";
            player.RBIs = 23;
            player.Runs = 26;
            player.StolenBases = 6;
            player.StrikeOuts = 17;
            player.BattingAverage = .329;
            player.OnBasePercentage = .412;
            player.OnBasePlusSlugging = .951;
            player.SluggingPercentage = .539;
            context.Players.Add(player);
            var roster = new Roster();
            roster.Players = new List<Player>();
            roster.Players.Add(player);
            context.Roster.Add(roster);
            //base.Seed(context);
        }
    }
}
