using ChoreManagement.core.lib.Models;

namespace ChoreManagement.core.lib.Services
{
    public class DataProvider
    {
        public static void InitiateData(out List<Player> playerlst, out List<Chore> shorelst)
        {
            playerlst = new MemDataRepository().GetAllPlayers();
            shorelst = new MemDataRepository().GetAllShors();
        }
    }
}