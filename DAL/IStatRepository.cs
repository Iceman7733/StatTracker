using StatTrackerAPI.Models;

namespace StatTrackerAPI.DAL
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
