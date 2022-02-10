using homeCleaning.Enums;
using homeCleaning.interfaces;

namespace homeCleaning.Models
{
    public class Trophy : ITrophy
    {
        public int id { get; set; }
        public string name { get; set; }
        public TrophyType TrophyType { get; set; }
    }
}
 