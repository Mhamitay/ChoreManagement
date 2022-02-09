using homeCleaning.Enums;

namespace homeCleaning.interfaces
{
    public interface ITrophy
    {
        int id { get; set; }
        string name { get; set; }
        TrophyType TrophyType { get; set; }
    }
}