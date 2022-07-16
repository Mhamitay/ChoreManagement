using homeCleaning.Enums;

namespace ChoreManagement.core.lib.interfaces
{
    public interface ITrophy
    {
        int id { get; set; }
        string name { get; set; }
        TrophyType TrophyType { get; set; }
    }
}