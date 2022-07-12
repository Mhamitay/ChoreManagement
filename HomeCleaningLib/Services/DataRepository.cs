using HomeCleaningLib.interfaces;
using HomeCleaningLib.Models;
using System.Collections.Generic;

namespace HomeCleaningLib.services
{
    public  class FromMemDataRepository : IDataRepository
    {
        public  List<Player> GetAllPlayers()
        {
            return new List<Player>
            {
                {new Player(0,"Ayah")},
                {new Player(1,"Hajir")},
                {new Player(2,"Solafa")},
                {new Player(3,"Malik")},
                {new Player(4,"Azooz")},
                {new Player(5,"Hinda")},
                {new Player(6,"Zain")}
            };
        } 
        
        public List<Shore> GetAllShors()
        {
            return new List<Shore>
            {
                new Shore{ name ="kitchen"},
                new Shore{ name ="FirstFloor"},
                new Shore{ name ="SecondFloor"},
                new Shore{ name ="Basemint"},
                new Shore{ name ="BathRoomFirstFloor"},
                new Shore{ name ="BathRoomSecondFloor"},
                new Shore{ name ="BathRoomBasemint"},
                new Shore{ name ="Basemint"},
                new Shore{ name ="sall"},
                new Shore{ name ="Gurage"}
            };
        }

    }
}
