using HomeCleaningLib.Enums;

namespace HomeCleaningLib.interfaces
{
    public interface ITrophy
    {
        int id { get; set; }
        string name { get; set; }
        TrophyType TrophyType { get; set; }
    }
}