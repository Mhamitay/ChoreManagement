using homeCleaning.Models;
using homeCleaning.services;
using System;
using System.Collections.Generic;

namespace homeCleaning
{
    public class DataProvider
    {
        public static void InitiateData(out List<Player> playerlst, out List<Shore> shorelst)
        {
            playerlst = new MemDataRepository().GetAllPlayers();
            shorelst = new MemDataRepository().GetAllShors();
        }
    }
}