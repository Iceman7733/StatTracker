using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatTrackerAPI.Models
{
    public class Roster
    {
        public int Id { get; set; }
        public List<Player> Players { get; set; }
    }
}
