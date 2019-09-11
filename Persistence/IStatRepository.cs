using StatTrackerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatTrackerAPI.Persistence
{
    public interface IStatRepository
    {
        int CreateRoster(string name);
        Player GetPlayer(int id);

        Roster GetRoster(int id);

        void UpdatePlayer(Player player);

        void AddPlayerToRoster(int rosterId, Player player);
    }
}
