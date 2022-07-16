
using ChoreManagement.core.lib.interfaces;
using ChoreManagement.core.lib.Models;

namespace ChoreManagement.core.lib.Services
{
    public class DataRepository : IDataRepository
    {
        public List<Player> GetAllPlayers()
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

        public List<Chore> GetAllChors()
        {
            return new List<Chore>
            {
                new Chore{ name ="kitchen"},
                new Chore{ name ="FirstFloor"},
                new Chore{ name ="SecondFloor"},
                new Chore{ name ="Basemint"},
                new Chore{ name ="BathRoomFirstFloor"},
                new Chore{ name ="BathRoomSecondFloor"},
                new Chore{ name ="BathRoomBasemint"},
                new Chore{ name ="Basemint"},
                new Chore{ name ="sall"},
                new Chore{ name ="Gurage"}
            };
        }

    }
}
