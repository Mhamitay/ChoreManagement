using HomeCleaningLib.Models;
using HomeCleaningLib.services;
using System.Collections.Generic;

namespace HomeCleaningLib.interfaces
{
    public interface IDataRepository
    {
         List<Player> GetAllPlayers();
         List<Shore> GetAllShors();
    }
}
