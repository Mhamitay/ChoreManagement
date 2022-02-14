using HomeCleaningLib.Enums;
using HomeCleaningLib.interfaces;

namespace HomeCleaningLib.Models
{
    public class Trophy : ITrophy
    {
        public int id { get; set; }
        public string name { get; set; }
        public TrophyType TrophyType { get; set; }
    }
}
 