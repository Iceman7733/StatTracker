using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatTrackerAPI.Models
{
    public class Player
    {
        public int Id { get; set; }
        public int RosterId { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public int PlateAppearances { get; set; }
        public int AtBats { get; set; }
        public int Hits { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }
        public int Runs { get; set; }
        public int RBIs { get; set; }
        public int StolenBases { get; set; }
        public int StrikeOuts { get; set; }
        public double BattingAverage { get; set; }
        public double OnBasePercentage { get; set; }
        public double SluggingPercentage { get; set; }
        public double OnBasePlusSlugging { get; set; }
        public virtual Roster Roster { get; set; }
    }
}
