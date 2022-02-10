namespace homeCleaning.services
{
    public class Player
    {
        private int _id;
        private string _name;

        public Player(int id,string name)
        {
            _id = id;
            _name = name;

        }
        public int id { get; set; }
        public string name { get; set; }
    }
}