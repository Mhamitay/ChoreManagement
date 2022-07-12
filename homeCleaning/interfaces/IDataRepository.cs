using homeCleaning.Models;
using homeCleaning.services;
using System.Collections.Generic;

namespace homeCleaning.interfaces
{
    public interface IDataRepository
    {
         List<Player> GetAllPlayers();
         List<Shore> GetAllShors();
    }
}
