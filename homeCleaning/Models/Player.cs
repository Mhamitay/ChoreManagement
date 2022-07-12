namespace HomeCleaningLib.services
{
    public class Player
    {
        public Player(int id,string name)
        {
            _id = id;
            _name = name;

        }
        public int _id { get; set; }
        public string _name { get; set; }
    }
}