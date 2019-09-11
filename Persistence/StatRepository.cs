using StatTrackerAPI.Models;
using System;

namespace StatTrackerAPI.Persistence
{
    public class StatRepository : IStatRepository
    {
        private RosterContext _context;
        public StatRepository(RosterContext context)
        {
            _context = context;
        }

        public int CreateRoster(string name)
        {
            var roster = new Roster();
            roster.Name = name;
            _context.Roster.Add(roster);
            _context.SaveChanges();
            return roster.Id;
        }

        public bool AddPlayerToRoster(int rosterId, Player player)
        {
            var roster = _context.Roster.Find(rosterId);
            if(roster == null)
            {
                return false;
            }
            roster.Players.Add(player);
            _context.SaveChanges();
            return true;
        }

        public Player GetPlayer(int id)
        {
            throw new NotImplementedException();
        }

        public Roster GetRoster(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayer(Player player)
        {
            throw new NotImplementedException();
        }

        void IStatRepository.AddPlayerToRoster(int rosterId, Player player)
        {
            throw new NotImplementedException();
        }
    }
}
