using ChoreManagement.core.lib.interfaces;
using homeCleaning.Enums;


namespace ChoreManagement.core.lib.Models
{
    public class Trophy : ITrophy
    {
        public int id { get; set; }
        public string name { get; set; }
        public TrophyType TrophyType { get; set; }
    }
}
 