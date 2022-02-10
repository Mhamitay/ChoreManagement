using homeCleaning.interfaces;
using homeCleaning.Models;
using System.Collections.Generic;

namespace homeCleaning.services
{
    public  class FromMemDataRepository : IDataRepository
    {
        public  List<Player> GetAllPlayers()
        {
            return new List<Player>
            {
                {new Player(0,"Ayah")},
                {new Player(1,"Hajir")},
                {new Player(2,"Solafa")}
            };
        } 
        
        public List<Shore> GetAllShors()
        {
            return new List<Shore>
            {
                new Shore{ name ="kitchen"} ,
                new Shore{ name ="BathRoom1"},
                new Shore{ name ="BathRoom2"},
                new Shore{ name ="sall"}
            };
        }

    }
}
