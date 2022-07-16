using ChoreManagement.core.lib.Models;

namespace ChoreManagement.core.lib.interfaces
{
    public interface IDataRepository
    {
        List<Player> GetAllPlayers();
        List<Chore> GetAllShors();
    }
}
